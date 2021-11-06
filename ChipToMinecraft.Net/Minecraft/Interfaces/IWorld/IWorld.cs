using System;

namespace Chip.Minecraft {
    ///DOLATER <summary>add description for interface: IWorld</summary>
    public interface IWorld {
        /// <summary>Retrieves the specific subchunk at the specified chunk location</summary>
        /// <param name="Location"></param>
        /// <returns>A Subchunk, null if something went wrong</returns>
        public SubChunk GetSubChunk(ChunkLocation Location);

        /// <summary>Sets the subchunk data</summary>
        /// <param name="Data"></param>
        public void SetSubChunk(SubChunk Data);

        /// <summary>Closes the world</summary>
        /// <returns></returns>
        public void Close();
    }
}
