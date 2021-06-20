using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Chip.Minecraft {
    ///DOLATER <summary>add description for struct: ChunkLocation</summary>
    public partial struct ChunkLocation {
        /// <summary>Creates a new instance of <see cref="ChunkLocation"/></summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="z"></param>
        public ChunkLocation(Int32 x, Int32 y, Int32 z) {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }
    }
}
