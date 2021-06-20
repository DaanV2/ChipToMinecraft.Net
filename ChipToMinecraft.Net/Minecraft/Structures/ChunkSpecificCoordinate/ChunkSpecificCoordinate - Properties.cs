using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chip.Minecraft {
    public partial struct ChunkSpecificCoordinate {
        /// <summary>The chunk coordiante</summary>
        public Int32 Chunk { get; set; }

        /// <summary>The relative coordinate in the chunk</summary>
        public Int32 RelCoordinate { get; set; }

    }
}
