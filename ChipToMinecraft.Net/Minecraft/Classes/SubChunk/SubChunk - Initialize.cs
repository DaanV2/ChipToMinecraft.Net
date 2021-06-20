using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Chip.Minecraft {
    ///DOLATER <summary>add description for class: SubChunk</summary>
    public partial class SubChunk {
        /// <summary>Creates a new instance of <see cref="SubChunk"/></summary>
        public SubChunk() {
            this.Location = new ChunkLocation();
        }
    }
}
