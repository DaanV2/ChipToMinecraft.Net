using System;

namespace Chip.Minecraft {
    public partial struct Range {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Start"></param>
        /// <param name="Length"></param>
        /// <returns></returns>
        public static Range CreateLength(Int32 Start, Int32 Length) {
            return new Range(Start, Start + Length);
        }
    }
}
