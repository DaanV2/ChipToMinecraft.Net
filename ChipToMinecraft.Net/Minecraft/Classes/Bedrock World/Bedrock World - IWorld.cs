using System;
using Chip.Minecraft.LevelDB;

namespace Chip.Minecraft {
    public partial class BedrockWorld : IWorld {
        /// <summary> </summary>
        /// <returns></returns>
        public void Close() {
#if DEBUG
            System.Diagnostics.Debug.WriteLine($"Closing world: {this.Folder}");
#endif

            if (this.Db != null) {
                this.Db.Close();
                this.Db = null;
            }
            GC.Collect();
        }

        /// <summary> </summary>
        /// <param name="Location"></param>
        /// <returns></returns>
        public SubChunk GetSubChunk(ChunkLocation Location) {
            return SubChunkFormat.Get(this, Location);
        }

        /// <summary> </summary>
        /// <param name="Data"></param>
        public void SetSubChunk(SubChunk Data) {
            SubChunkFormat.Set(this, Data);
        }
    }
}
