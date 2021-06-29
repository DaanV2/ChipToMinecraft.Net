using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chip.Minecraft {
    public partial struct Range : IEquatable<Range>{
        /// <summary>
        /// 
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override Boolean Equals(Object obj) {
            return obj is Range range && this.Equals(range);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public Boolean Equals(Range other) {
            return this.Start == other.Start &&
                   this.End == other.End;
        }

        public IEnumerator<Int32> GetEnumerator() {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override Int32 GetHashCode() {
            return HashCode.Combine(this.Start, this.End);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <returns></returns>
        public static Boolean operator ==(Range left, Range right) {
            return left.Equals(right);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <returns></returns>
        public static Boolean operator !=(Range left, Range right) {
            return !(left == right);
        }
    }
}
