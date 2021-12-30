using System;
using System.Drawing;
using System.Runtime.CompilerServices;

namespace Chip.Process {
    ///DOLATER <summary>add description for class: BitMap</summary>
    public static partial class BitMapExtension {
        /// <summary>
        /// 
        /// </summary>
        public const Int32 Thresshold = 127;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="map"></param>
        /// <param name="X"></param>
        /// <param name="yStart"></param>
        /// <returns></returns>
        [MethodImpl(MethodImplOptions.AggressiveOptimization)]
        public static Int32 FindYStart(this Bitmap map, Int32 X, Int32 yStart = 0) {
            for (Int32 Y = yStart; Y < map.Height; Y++) {
                Color p = map.GetPixel(X, Y);

                if (IsBlackIsh(p))
                    return Y;
            }

            return -1;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="map"></param>
        /// <param name="X"></param>
        /// <param name="yStart"></param>
        /// <returns></returns>
        [MethodImpl(MethodImplOptions.AggressiveOptimization)]
        public static Int32 FindYEnd(this Bitmap map, Int32 X, Int32 yStart = 0) {
            Color p;
            Int32 Y = yStart;
            Int32 End = map.Height;

            do {
                Y++;
                p = map.GetPixel(X, Y);
            } while (IsBlackIsh(p) && Y < End);

            return Y;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="color"></param>
        /// <returns></returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Boolean IsBlackIsh(Color color) {
            if (color.R > Thresshold) return false;
            if (color.B > Thresshold) return false;
            if (color.G > Thresshold) return false;

            return true;
        }
    }
}
