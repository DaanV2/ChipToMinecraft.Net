using System;

namespace Chip.Minecraft {
    public readonly partial struct Location : IEquatable<Location> {
        /// <summary> </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override Boolean Equals(Object obj) {
            return obj is Location location && this.Equals(location);
        }

        /// <summary> </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public Boolean Equals(Location other) {
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
        public static Boolean operator ==(Location left, Location right) {
            return left.Equals(right);
        }

        /// <summary> </summary>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <returns></returns>
        public static Boolean operator !=(Location left, Location right) {
            return !(left == right);
        }

        /// <summary> </summary>
        /// <param name="A"></param>
        /// <param name="B"></param>
        /// <returns></returns>
        public static Location operator +(Location A, Location B) {
            return new Location(A.X + B.X, A.Y + B.Y, A.Z + B.Z);
        }

        /// <summary> </summary>
        /// <param name="A"></param>
        /// <param name="B"></param>
        /// <returns></returns>
        public static Location operator -(Location A, Location B) {
            return new Location(A.X - B.X, A.Y - B.Y, A.Z - B.Z);
        }

        /// <summary> </summary>
        /// <returns></returns>
        public override String ToString() {
            return $"{this.X} {this.Y} {this.Z}";
        }
    }
}
