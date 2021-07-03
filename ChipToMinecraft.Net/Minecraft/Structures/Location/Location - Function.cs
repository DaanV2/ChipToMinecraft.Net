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
    }
}
