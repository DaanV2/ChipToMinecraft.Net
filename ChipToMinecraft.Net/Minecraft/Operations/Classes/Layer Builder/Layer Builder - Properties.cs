using System;

namespace Chip.Minecraft.Operations {
    public partial class LayerBuilder {
        /// <summary> </summary>
        public IWorld World { get; private set; }

        /// <summary> </summary>
        public Range Layer { get; set; }

        /// <summary> </summary>
        public Location2D Offset { get; set; }

        /// <summary> </summary>
        public Single Scale { get; private set; }
    }
}
