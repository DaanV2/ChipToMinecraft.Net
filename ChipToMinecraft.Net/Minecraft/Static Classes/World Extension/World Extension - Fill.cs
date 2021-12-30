using System.Runtime.CompilerServices;
using DaanV2.NBT;

namespace Chip.Minecraft {
    /// <summary>
    /// 
    /// </summary>
    public static partial class WorldExtension {
        /// <summary> </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="World"></param>
        /// <param name="call"></param>
        /// <param name="Area"></param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Fill<T>(this T World, Box Area, NBTTagCompound Block)
            where T : IWorld {
#if DEBUG
            System.Diagnostics.Debug.WriteLine($"Debug: Filling: {Block} at {Area}");
#endif

            Box? nArea = Operations.FillEntireSubChunk.FillCheck<T>(World, Area, Block);

            var From = (ChunkLocation)Area.From;
            var To = (ChunkLocation)Area.To;

            //XY Planes
            InternalFill<T>(World, From, new ChunkLocation(From.X, To.Y, To.Z), Area, Block);
            if (From.X != To.X) {
                InternalFill<T>(World, new ChunkLocation(To.X, From.Y, From.Z), To, Area, Block);
            }

            //XZ Planes
            InternalFill<T>(World, From.Offset(1, 0, 1), new ChunkLocation(To.X - 1, From.Y, To.Z - 1), Area, Block);
            if (From.Y != To.Y) {
                InternalFill<T>(World, new ChunkLocation(From.X + 1, To.Y, From.Z + 1), To.Offset(-1, 0, -1), Area, Block);
            }

            //YZ Planes
            InternalFill<T>(World, From.Offset(1, 0, 0), new ChunkLocation(To.X - 1, To.Y, From.Z), Area, Block);
            if (From.Z != To.Z) {
                InternalFill<T>(World, new ChunkLocation(From.X + 1, From.Y, To.Z), To.Offset(-1, 0, 0), Area, Block);
            }
        }

        /// <summary> </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="World"></param>
        /// <param name="From"></param>
        /// <param name="To"></param>
        /// <param name="Area"></param>
        /// <param name="block"></param>
        internal static void InternalFill<T>(T World, ChunkLocation From, ChunkLocation To, Box Area, NBTTagCompound block)
            where T : IWorld {

            if (From.X > To.X) { return; }
            if (From.Y > To.Y) { return; }
            if (From.Z > To.Z) { return; }

            var Op = new Operations.FillSubChunk(block);
            var NewBox = new Box((Location)From, (Location)To);

            World.ForEach(Op.Fill, NewBox, Area);
        }
    }
}
