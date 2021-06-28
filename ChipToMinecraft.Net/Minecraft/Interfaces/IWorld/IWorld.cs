using System;

namespace Chip.Minecraft {
    ///DOLATER <summary>add description for interface: IWorld</summary>
    public interface IWorld {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Location"></param>
        /// <returns></returns>
        public SubChunk GetSubChunk(ChunkLocation Location);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Data"></param>
        public void SetSubChunk(SubChunk Data);

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public Boolean Close();
    }
}
