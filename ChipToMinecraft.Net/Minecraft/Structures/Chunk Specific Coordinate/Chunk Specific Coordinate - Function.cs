using System;

namespace Chip.Minecraft {
    public readonly partial struct ChunkSpecificCoordinate {
        /// <summary> </summary>
        /// <param name="WorldCoordinate"></param>
        /// <returns></returns>
        public static ChunkSpecificCoordinate FromWorld(Int32 WorldCoordinate) {
            return new ChunkSpecificCoordinate(Minecraft.Chunk.WorldCoordinate(WorldCoordinate), Minecraft.Chunk.RelativeChunkCoordinate(WorldCoordinate));
        }

        /// <summary> </summary>
        /// <returns></returns>
        public Int32 GetWorldCoordinate() {
            return Minecraft.Chunk.WorldCoordinate(this.Chunk, this.RelCoordinate);
        }
    }
}
