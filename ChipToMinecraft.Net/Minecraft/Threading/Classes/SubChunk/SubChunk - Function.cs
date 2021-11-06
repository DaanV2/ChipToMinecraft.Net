using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Threading;
using DaanV2.NBT;

namespace Chip.Minecraft.Threading {
    public partial class SubChunk : IEquatable<SubChunk> {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="SC"></param>
        /// <param name="Lock"></param>
        /// <returns></returns>
        public static SubChunk Cast(Chip.Minecraft.SubChunk SC, AutoResetEvent Lock) {
            var Out = (SubChunk)SC;
            Out._Lock = Lock;

            return Out;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override Boolean Equals(Object obj) {
            return this.Equals(obj as SubChunk);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public Boolean Equals(SubChunk other) {
            if (other is null) return false;

            if (this.Location.Equals(other.Location) &&
                   EqualityComparer<UInt32[]>.Default.Equals(this.Words, other.Words) &&
                   EqualityComparer<List<NBTTagCompound>>.Default.Equals(this.Pallete, other.Pallete) &&
                   EqualityComparer<AutoResetEvent>.Default.Equals(this._Lock, other._Lock)) return true;

            return false;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override Int32 GetHashCode() {
            return HashCode.Combine(this.Location, this.Words, this.Pallete, this._Lock);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <returns></returns>
        public static Boolean operator ==(SubChunk left, SubChunk right) {
            return EqualityComparer<SubChunk>.Default.Equals(left, right);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <returns></returns>
        public static Boolean operator !=(SubChunk left, SubChunk right) {
            return !(left == right);
        }
    }
}
