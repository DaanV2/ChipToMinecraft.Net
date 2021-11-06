using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chip.Minecraft;

namespace Chip {
    public partial class ChipBuilder<T> : IWorld {
        /// <inheritdoc/>
        public void Close() {
            this.World.Close();
        }

        /// <inheritdoc/>
        public SubChunk GetSubChunk(ChunkLocation Location) {
            return this.World.GetSubChunk(Location);
        }

        /// <inheritdoc/>
        public void SetSubChunk(SubChunk Data) {
            this.SetSubChunk(Data);
        }
    }
}
