using System;

namespace Chip.Minecraft.Operations {
    ///DOLATER <summary>add description for class: LayerBuilder</summary>
    public partial class LayerBuilder {
        /// <summary>Creates a new instance of <see cref="LayerBuilder"/></summary>
        /// <param name="World">The world to build upon</param>
        /// <param name="YStart">The start of the layer, height wise</param>
        /// <param name="Thickness">The thickness in blocks of the layer</param>
        /// <param name="Scale">The scale of blocks of the layer</param>
        /// <param name="Offset">The offset of the layer in the world</param>
        public LayerBuilder(IWorld World, Int32 YStart, Int32 Thickness, Single Scale, Location2D Offset) {
            this.World = World;
            this.Scale = Scale;
            this.Layer = Range.CreateLength(YStart, Thickness);
            this.Offset = Offset;            
        }

        /// <summary>Creates a new instance of <see cref="LayerBuilder"/></summary>
        /// <param name="World">The world to build upon</param>
        /// <param name="Thickness">The thickness in blocks of the layer</param>
        /// <param name="StartLocation">The location the start at</param>
        public LayerBuilder(IWorld World, Int32 Thickness, Single Scale, Location StartLocation) : 
            this(World, StartLocation.Y, Thickness, Scale, new Location2D(StartLocation.X, StartLocation.Z)) { }
    }
}
