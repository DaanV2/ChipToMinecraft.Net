using System;

namespace Chip.Minecraft.Operations {
    public readonly partial struct Location2D {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="point"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public static Location2D operator *(Location2D point, Int32 value) {
            return new Location2D(point.X * value, point.Z * value);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="point"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public static Location2D operator *(Location2D point, Single value) {
            return new Location2D((Int32)(point.X * value), (Int32)(point.Z * value));
        }
    }
}
