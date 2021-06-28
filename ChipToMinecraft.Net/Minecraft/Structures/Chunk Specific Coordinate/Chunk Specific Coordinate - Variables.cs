using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chip.Minecraft {
    public readonly partial struct ChunkSpecificCoordinate {
        /// <summary>The chunk coordiante</summary>
        public readonly Int32 Chunk;

        /// <summary>The relative coordinate in the chunk</summary>
        public readonly Int32 RelCoordinate;

    }
}
