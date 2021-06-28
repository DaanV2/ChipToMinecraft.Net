using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chip.Minecraft {
    public readonly partial struct ChunkSpecificCoordinate : IEquatable<ChunkSpecificCoordinate> {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override Boolean Equals(Object obj) {
            return obj is ChunkSpecificCoordinate coordinate && this.Equals(coordinate);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public Boolean Equals(ChunkSpecificCoordinate other) {
            return this.Chunk == other.Chunk &&
                   this.RelCoordinate == other.RelCoordinate;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override Int32 GetHashCode() {
            return HashCode.Combine(this.Chunk, this.RelCoordinate);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <returns></returns>
        public static Boolean operator ==(ChunkSpecificCoordinate left, ChunkSpecificCoordinate right) {
            return left.Equals(right);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <returns></returns>
        public static Boolean operator !=(ChunkSpecificCoordinate left, ChunkSpecificCoordinate right) {
            return !(left == right);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override String ToString() {
            return $"{this.Chunk}:{this.RelCoordinate}";
        }
    }
}
