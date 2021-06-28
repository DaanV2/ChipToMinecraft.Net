using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chip.Minecraft.World {
    public partial class BedrockWorld : IWorld {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public Boolean Close() {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Location"></param>
        /// <returns></returns>
        public SubChunk GetSubChunk(ChunkLocation Location) {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Data"></param>
        public void SetSubChunk(SubChunk Data) {
            throw new NotImplementedException();
        }
    }
}
