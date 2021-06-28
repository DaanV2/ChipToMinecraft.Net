using DaanV2.NBT;

namespace Chip.Minecraft.Operations {
    public partial class FillEntireSubChunk {
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="World"></param>
        /// <param name="Area"></param>
        /// <param name="block"></param>
        public static void Fill<T>(T World, Box Area, NBTTagCompound block)
            where T : IWorld {

            var Op = new FillEntireSubChunk(block);

            World.ForEach(Op.Fill, Area);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Area"></param>
        /// <returns></returns>
        public static Box? GetFullSubChunk(Box Area) {
            var From = (ChunkLocation)Area.From;
            var To = (ChunkLocation)Area.To;

            if (To.X - From.X >= 2) {
                if (To.Y - From.Y >= 2) {
                    if (To.Z - From.Z >= 2) {
                        Location bFrom = (Location)From.Offset(1, 1, 1);
                        Location bTo = ((Location)To).Offset(-1, -1, -1);

                        return new Box(bFrom, bTo);
                    }
                }
            }

            return null;
        }

        /// <summary>Calculates only the area it can fill and fill that area</summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="World"></param>
        /// <param name="Area"></param>
        /// <param name="block"></param>
        public static Box? FillCheck<T>(T World, Box Area, NBTTagCompound block)
            where T : IWorld {

            Box? nArea = GetFullSubChunk(Area);

            if (nArea.HasValue) {
                Fill(World, nArea.Value, block);
            }

            return nArea;
        }
    }
}
