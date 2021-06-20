using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Chip.Minecraft {
    ///DOLATER <summary>add description for struct: ChunkSpecificLocation</summary>
    public partial struct ChunkSpecificLocation {
        /// <summary>Creates a new instance of <see cref="ChunkSpecificLocation"/></summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="z"></param>
        public ChunkSpecificLocation(ChunkSpecificCoordinate x, ChunkSpecificCoordinate y, ChunkSpecificCoordinate z) {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }
    }
}
