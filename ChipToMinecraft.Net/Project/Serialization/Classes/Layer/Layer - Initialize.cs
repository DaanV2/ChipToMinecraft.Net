using System;
using System.Collections.Generic;

namespace Chip.Project.Serialization {
    ///DOLATER <summary>add description for class: Layer</summary>
    [Serializable]
    public partial class Layer {
        /// <summary>Creates a new instance of <see cref="Layer"/></summary>
        public Layer() {
            this.Block = Minecraft.BlockFactory.Blocks.Air.Block;
            this.Filepath = null;
            this.Scale = 1f;
            this.Thickness = 1;
            this.StartLocation = new List<Int32>() { 0, 0, 0 };
        }
    }
}
