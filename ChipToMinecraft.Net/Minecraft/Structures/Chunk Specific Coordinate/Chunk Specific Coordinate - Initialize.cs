using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Chip.Minecraft {
    ///DOLATER <summary>add description for struct: ChunkSpecificCoordinate</summary>
    public readonly partial struct ChunkSpecificCoordinate {
        /// <summary>Creates a new instance of <see cref="ChunkSpecificCoordinate"/></summary>
        /// <param name="chunk"></param>
        /// <param name="relCoordinate"></param>
        public ChunkSpecificCoordinate(Int32 chunk, Int32 relCoordinate) {
            this.Chunk = chunk;
            this.RelCoordinate = relCoordinate;
        }
    }
}
