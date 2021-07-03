using System;

namespace Chip.Minecraft {
    public readonly partial struct ChunkLocation {
        /// <summary> </summary>
        /// <returns></returns>
        public ChunkLocation Offset(Int32 X, Int32 Y, Int32 Z) {
            return new ChunkLocation(this.X + X, this.Y + Y, this.Z + Z);
        }
    }
}
