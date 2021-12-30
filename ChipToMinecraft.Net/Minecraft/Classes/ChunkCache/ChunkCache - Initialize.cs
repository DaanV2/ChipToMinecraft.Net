using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Threading;

namespace Chip.Minecraft {
    ///DOLATER <summary>add description for class: ChunkCache</summary>
    public partial class ChunkCache {
        /// <summary>Creates a new instance of <see cref="ChunkCache"/></summary>
        public ChunkCache(IWorld world) {
            this.World = world;
            this.SubChunks = new Dictionary<ChunkLocation, SubChunk>(100000);
            this._Lock = new AutoResetEvent(true);
        }
    }
}
