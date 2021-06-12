using System;
using System.Text.Json.Serialization;

namespace Chip.Minecraft {
    ///DOLATER <summary>add description for struct: Location</summary>
    [JsonConverter(typeof(Serialization.LocationConverter))]
    public partial struct Location {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="z"></param>
        public Location(Int32 x, Int32 y, Int32 z) {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }
    }
}
