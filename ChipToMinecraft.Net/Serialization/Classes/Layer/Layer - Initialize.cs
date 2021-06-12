using System;

namespace Chip.Serialization {
    ///DOLATER <summary>add description for class: Layer</summary>
    public partial class Layer {
        /// <summary>Creates a new instance of <see cref="Layer"/></summary>
        public Layer() {
            this.File = String.Empty;
            this.Start = new Minecraft.Location();
            this.Thickness = 1;
            this.Scale = 1.0f;
            this.Block = Minecraft.Block.AirBlock;
        }
    }
}
