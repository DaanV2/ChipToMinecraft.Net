using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chip.Minecraft {
    public readonly partial struct ChunkBox : IEquatable<ChunkBox> {
        /// <summary> </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override Boolean Equals(Object obj) {
            return obj is ChunkBox ChunkBox && this.Equals(ChunkBox);
        }

        /// <summary> </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public Boolean Equals(ChunkBox other) {
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
        public static Boolean operator ==(ChunkBox left, ChunkBox right) {
            return left.Equals(right);
        }

        /// <summary> </summary>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <returns></returns>
        public static Boolean operator !=(ChunkBox left, ChunkBox right) {
            return !(left == right);
        }

        /// <summary> </summary>
        /// <param name="Area"></param>
        public static explicit operator ChunkBox(Box Area) {
            return new ChunkBox((ChunkLocation)Area.From, (ChunkLocation)Area.To);
        }

        /// <summary> </summary>
        /// <param name="Area"></param>
        public static explicit operator Box(ChunkBox Area) {
            return new Box((Location)Area.From, (Location)Area.To);
        }

        /// <summary> </summary>
        /// <returns></returns>
        public override String ToString() {
            return $"{this.From.X} {this.From.Y} {this.From.Z} {this.To.X} {this.To.Y} {this.To.Z}";
        }
    }
}
