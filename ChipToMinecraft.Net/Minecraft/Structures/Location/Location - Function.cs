using System;

namespace Chip.Minecraft {
    public readonly partial struct Location {
        /// <summary> </summary>
        /// <param name="X"></param>
        /// <param name="Y"></param>
        /// <param name="Z"></param>
        /// <returns></returns>
        public Location Offset(Int32 X, Int32 Y, Int32 Z) {
            return new Location(this.X + X, this.Y + Y, this.Z + Z);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        public static Location operator *(Location A, Single value) {
            return new Location(
                (Int32)(A.X * value),
                (Int32)(A.Y * value),
                (Int32)(A.Z * value));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="A"></param>
        /// <param name="B"></param>
        /// <returns></returns>
        public static Location Min(Location A, Location B) {
            return new Location(
                Math.Min(A.X, B.X),
                Math.Min(A.Y, B.Y),
                Math.Min(A.Z, B.Z));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="A"></param>
        /// <param name="B"></param>
        /// <returns></returns>
        public static Location Max(Location A, Location B) {
            return new Location(
                Math.Max(A.X, B.X),
                Math.Max(A.Y, B.Y),
                Math.Max(A.Z, B.Z));
        }
    }
}
