using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chip.Minecraft {
    public partial class SubChunk {
        /// <summary>
        /// 
        /// </summary>
        public ChunkLocation Location { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public UInt32[] Words { get; set; }
    }
}
