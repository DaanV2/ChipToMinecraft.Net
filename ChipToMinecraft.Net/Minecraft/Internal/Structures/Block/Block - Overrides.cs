using System;

namespace Chip.Minecraft.Internal {
    public readonly partial struct Block : IEquatable<Block> {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override Boolean Equals(Object obj) {
            return obj is Block block && this.Equals(block);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public Boolean Equals(Block other) {
            if (other.Data.Length != this.Data.Length) return false;

            return this.Data.AsSpan().SequenceEqual(other.Data.AsSpan());
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override Int32 GetHashCode() {
            Int32 Out = 0;
            Int32 Max = this.Data.Length;

            for (Int32 I = 0; I < Max; I++) {
                Out ^= this.Data[I].GetHashCode();
            }

            return Out;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <returns></returns>
        public static Boolean operator ==(Block left, Block right) {
            return left.Equals(right);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <returns></returns>
        public static Boolean operator !=(Block left, Block right) {
            return !(left == right);
        }
    }
}
