using System;

namespace Chip.Minecraft {
    public readonly partial struct ChunkSpecificLocation : IEquatable<ChunkSpecificLocation> {
        /// <summary> </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override Boolean Equals(Object obj) {
            return obj is ChunkSpecificLocation location && this.Equals(location);
        }

        /// <summary> </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public Boolean Equals(ChunkSpecificLocation other) {
            if (this.X.Equals(other.X) && this.Y.Equals(other.Y) && this.Z.Equals(other.Z)) {
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
        public static Boolean operator ==(ChunkSpecificLocation left, ChunkSpecificLocation right) {
            return left.Equals(right);
        }

        /// <summary> </summary>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <returns></returns>
        public static Boolean operator !=(ChunkSpecificLocation left, ChunkSpecificLocation right) {
            return !(left == right);
        }

        /// <summary> </summary>
        /// <param name="A"></param>
        public static implicit operator ChunkSpecificLocation(Location A) {
            return new ChunkSpecificLocation(
                ChunkSpecificCoordinate.FromWorld(A.X),
                ChunkSpecificCoordinate.FromWorld(A.Y),
                ChunkSpecificCoordinate.FromWorld(A.Z));
        }

        /// <summary> </summary>
        /// <param name="A"></param>
        public static implicit operator ChunkSpecificLocation(ChunkLocation A) {
            return new ChunkSpecificLocation(
                new ChunkSpecificCoordinate(A.X, 0),
                new ChunkSpecificCoordinate(A.Y, 0),
                new ChunkSpecificCoordinate(A.Z, 0));
        }

        /// <summary> </summary>
        /// <param name="A"></param>
        public static implicit operator ChunkLocation(ChunkSpecificLocation A) {
            return new ChunkLocation(A.X.Chunk, A.Y.Chunk, A.Z.Chunk);
        }

        /// <summary> </summary>
        public static explicit operator Location(ChunkSpecificLocation A) {
            return new Location(A.X.GetWorldCoordinate(), A.Y.GetWorldCoordinate(), A.Z.GetWorldCoordinate());
        }

        /// <summary> </summary>
        /// <returns></returns>
        public override String ToString() {
            return $"{this.X} {this.Y} {this.Z}";
        }
    }
}
