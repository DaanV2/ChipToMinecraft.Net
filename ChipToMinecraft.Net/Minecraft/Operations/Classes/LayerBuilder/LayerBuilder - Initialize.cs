using System;

namespace Chip.Minecraft.Operations {
    ///DOLATER <summary>add description for class: LayerBuilder</summary>
    public partial class LayerBuilder<T>
        where T : IWorld {
        /// <summary>Creates a new instance of <see cref="LayerBuilder"/></summary>
        /// <param name="World">The world to build upon</param>
        /// <param name="YStart">The start of the layer, height wise</param>
        /// <param name="Thickness">The thickness in blocks of the layer</param>
        /// <param name="Offset">The offset of the layer in the world</param>
        public LayerBuilder(T World, Int32 YStart, Int32 Thickness, Location2D Offset) {
            this.World = World;
            this.Layer = Range.CreateLength(YStart, Thickness);
            this.Offset = Offset;
        }
    }
}
