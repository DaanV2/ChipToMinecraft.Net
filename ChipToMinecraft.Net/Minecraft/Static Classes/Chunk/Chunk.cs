using System;

namespace Chip.Minecraft {
    ///DOLATER <summary>add description for class: Chunk</summary>
    public static partial class Chunk {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="WorldCoordinate"></param>
        /// <returns></returns>
        public static Int32 ChunkCoordinate(Int32 WorldCoordinate) {
            return WorldCoordinate >> 4;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ChunkCoordinate"></param>
        /// <returns></returns>
        public static Int32 WorldCoordinate(Int32 ChunkCoordinate) {
            return ChunkCoordinate << 4;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ChunkCoordinate"></param>
        /// <param name="RelativeCoordinate"></param>
        /// <returns></returns>
        public static Int32 WorldCoordinate(Int32 ChunkCoordinate, Int32 RelativeCoordinate) {
            return WorldCoordinate(ChunkCoordinate) + RelativeCoordinate;
        }

        /// <summary>Returns the relative coordinate in the chunk</summary>
        /// <param name="WorldCoordinate"></param>
        /// <returns></returns>
        public static Int32 RelativeChunkCoordinate(Int32 WorldCoordinate) {
            return WorldCoordinate & 0b0000_1111;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="WorldCoordinate"></param>
        /// <returns></returns>
        public static Boolean CoordinateIsStartOfChunk(Int32 WorldCoordinate) {
            const Int32 Mask = ~0b0000_1111;
            Int32 Pattern = WorldCoordinate & Mask;

            if (Pattern == WorldCoordinate)
                return true;

            return false;
        }
    }
}
