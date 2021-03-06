using System;

namespace Chip.Minecraft {
    public readonly partial struct ChunkLocation : IEquatable<ChunkLocation> {
        /// <summary> </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override Boolean Equals(Object obj) {
            return obj is ChunkLocation location && this.Equals(location);
        }

        /// <summary> </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public Boolean Equals(ChunkLocation other) {
            if (this.X == other.X && this.Y == other.Y && this.Z == other.Z) {
                return true;
            }

            return false;
        }

        /// <summary> </summary>
        /// <returns></returns>
        public override Int32 GetHashCode() {
            return HashCode.Combine(this.X, this.Y, this.Z);
        }

        /// <summary> </summary>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <returns></returns>
        public static Boolean operator ==(ChunkLocation left, ChunkLocation right) {
            return left.Equals(right);
        }

        /// <summary> </summary>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <returns></returns>
        public static Boolean operator !=(ChunkLocation left, ChunkLocation right) {
            return !(left == right);
        }

        /// <summary> </summary>
        /// <param name="A"></param>
        public static explicit operator ChunkLocation(Location A) {
            return new ChunkLocation(Chunk.ChunkCoordinate(A.X), Chunk.ChunkCoordinate(A.Y), Chunk.ChunkCoordinate(A.Z));
        }

        /// <summary> </summary>
        /// <param name="A"></param>
        public static explicit operator Location(ChunkLocation A) {
            return new Location(Chunk.WorldCoordinate(A.X), Chunk.WorldCoordinate(A.Y), Chunk.WorldCoordinate(A.Z));
        }

        /// <summary> </summary>
        /// <param name="A"></param>
        /// <param name="B"></param>
        /// <returns></returns>
        public static ChunkLocation operator +(ChunkLocation A, ChunkLocation B) {
            return new ChunkLocation(A.X + B.X, A.Y + B.Y, A.Z + B.Z);
        }

        /// <summary> </summary>
        /// <param name="A"></param>
        /// <param name="B"></param>
        /// <returns></returns>
        public static ChunkLocation operator -(ChunkLocation A, ChunkLocation B) {
            return new ChunkLocation(A.X - B.X, A.Y - B.Y, A.Z - B.Z);
        }

        /// <summary> </summary>
        /// <returns></returns>
        public override String ToString() {
            return $"{this.X} {this.Y} {this.Z}";
        }
    }
}
