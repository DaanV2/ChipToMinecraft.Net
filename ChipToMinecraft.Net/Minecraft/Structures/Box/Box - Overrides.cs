using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chip.Minecraft {
    public readonly partial struct Box : IEquatable<Box> {
        /// <summary> </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override Boolean Equals(Object obj) {
            return obj is Box box && this.Equals(box);
        }

        /// <summary> </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public Boolean Equals(Box other) {
            if (this.From.Equals(other.From) && this.To.Equals(other.To))
                return true;

            return false;
        }

        /// <summary> </summary>
        /// <returns></returns>
        public override Int32 GetHashCode() {
            return HashCode.Combine(this.From, this.To);
        }

        /// <summary> </summary>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <returns></returns>
        public static Boolean operator ==(Box left, Box right) {
            return left.Equals(right);
        }

        /// <summary> </summary>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <returns></returns>
        public static Boolean operator !=(Box left, Box right) {
            return !(left == right);
        }

        /// <summary> </summary>
        /// <returns></returns>
        public override String ToString() {
            return $"{this.From.X} {this.From.Y} {this.From.Z} {this.To.X} {this.To.Y} {this.To.Z}";
        }
    }
}
