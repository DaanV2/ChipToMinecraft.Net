using System;

namespace Chip.Minecraft.Operations {
    public readonly partial struct Location2D : IEquatable<Location2D> {
        /// <summary> </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override Boolean Equals(Object obj) {
            return obj is Location2D d && this.Equals(d);
        }

        /// <summary> </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public Boolean Equals(Location2D other) {
            if (this.X == other.X && this.Z == other.Z)
                return true;

            return false;
        }

        /// <summary> </summary>
        /// <returns></returns>
        public override Int32 GetHashCode() {
            return HashCode.Combine(this.X, this.Z);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override String ToString() {
            return $"{{x:{this.X} Z:{this.Z}}}";
        }

        /// <summary> </summary>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <returns></returns>
        public static Boolean operator ==(Location2D left, Location2D right) {
            return left.Equals(right);
        }

        /// <summary> </summary>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <returns></returns>
        public static Boolean operator !=(Location2D left, Location2D right) {
            return !(left == right);
        }

        /// <summary> </summary>
        /// <param name="A"></param>
        public static explicit operator Location2D(Location A) {
            return new Location2D(A.X, A.Z);
        }
    }
}
