using System;

namespace Chip.Minecraft {
    ///DOLATER <summary>add description for class: SubChunk</summary>
    public partial class SubChunk {
        /// <summary>Creates a new instance of <see cref="SubChunk"/></summary>
        public SubChunk() {
            this.Location = new ChunkLocation();
            this.Pallete = null;
            this.Words = null;
        }

        /// <summary>
        /// 
        /// </summary>
        public const Int32 DefaultWordLength = 16 * 16 * 16;
    }
}
