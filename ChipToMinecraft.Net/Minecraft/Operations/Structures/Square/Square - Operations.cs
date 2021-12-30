using System;

namespace Chip.Minecraft.Operations {
    public readonly partial struct Square {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="point"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public static Square operator *(Square point, Int32 value) {
            return new Square(point.From * value, point.To * value);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="point"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public static Square operator *(Square point, Single value) {
            return new Square(point.From * value, point.To * value);
        }
    }
}
