using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chip.Minecraft.LevelDB;

namespace Chip.Minecraft.World {
    public partial class BedrockWorld : IWorld {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public void Close() {
            this.Db.Close();
            this.Db = null;
            GC.Collect();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Location"></param>
        /// <returns></returns>
        public SubChunk GetSubChunk(ChunkLocation Location) {
            return SubChunkFormat.Get(this, Location);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Data"></param>
        public void SetSubChunk(SubChunk Data) {
            return SubChunkFormat.Set(this, Data);
        }
    }
}
