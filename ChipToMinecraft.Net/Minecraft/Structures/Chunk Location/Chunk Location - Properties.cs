using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chip.Minecraft {
    public readonly partial struct ChunkLocation  {
        /// <summary>The Chunk X coordinate in the world</summary>
        public readonly Int32 X;

        /// <summary>The Chunk Y coordinate in the world</summary>
        public readonly Int32 Y;

        /// <summary>The Chunk Z coordinate in the world</summary>
        public readonly Int32 Z;
    }
}
