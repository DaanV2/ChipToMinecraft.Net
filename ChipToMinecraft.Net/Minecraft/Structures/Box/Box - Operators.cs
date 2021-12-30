using System;

namespace Chip.Minecraft {
    public readonly partial struct Box {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        public static Box operator *(Box A, Single value) {
            return new Box(A.From * value, A.To * value);
        }
    }
}
