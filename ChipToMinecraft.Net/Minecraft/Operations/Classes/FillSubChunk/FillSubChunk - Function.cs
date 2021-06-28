using System;
using DaanV2.NBT;

namespace Chip.Minecraft.Operations {
    public partial class FillSubChunk {
        /// <summary>
        /// 
        /// </summary>
        public void SetData(Box Area, Location Anchor) {
            this.StartX = Math.Clamp(Area.From.X - Anchor.X, 0, 15);
            this.StartY = Math.Clamp(Area.From.Y - Anchor.Y, 0, 15);
            this.StartZ = Math.Clamp(Area.From.Z - Anchor.Z, 0, 15);

            this.EndX = Math.Clamp(Area.To.X - Anchor.X, 0, 15) + 1;
            this.EndY = Math.Clamp(Area.To.Y - Anchor.Y, 0, 15) + 1;
            this.EndZ = Math.Clamp(Area.To.Z - Anchor.Z, 0, 15) + 1;
        }
}
}
