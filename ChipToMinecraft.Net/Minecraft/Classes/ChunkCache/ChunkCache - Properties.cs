using System;
using System.Collections.Generic;

namespace Chip.Minecraft {
    public partial class ChunkCache {
        /// <summary>
        /// 
        /// </summary>
        public IWorld World { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        public Dictionary<ChunkLocation, SubChunk> SubChunks { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        public Boolean ShouldDump {
            get {
                GCMemoryInfo Info = GC.GetGCMemoryInfo();

                return Info.TotalAvailableMemoryBytes < Int16.MaxValue;
            }
        }
    }
}
