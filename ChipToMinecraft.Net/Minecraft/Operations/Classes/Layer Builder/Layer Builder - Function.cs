using DaanV2.NBT;

namespace Chip.Minecraft.Operations {
    public partial class LayerBuilder {

        /// <summary> </summary>
        /// <param name="Area"></param>
        /// <param name="Block"></param>
        public void Fill(Square Area, NBTTagCompound Block) {
            Box Box = this.Combine(Area);

            this.World.Fill(Box, Block);
        }

        /// <summary>Combines the given area and this layer builder data to create a new box</summary>
        /// <param name="Area"></param>
        /// <returns></returns>
        public Box Combine(Square Area) {
            Area *= this.Scale;

            return new Box(
                new Location(this.Offset.X + Area.From.X, this.Layer.Start, this.Offset.Z + Area.From.Z),
                new Location(this.Offset.X + Area.To.X, this.Layer.End, this.Offset.Z + Area.To.Z));
        }
    }
}
