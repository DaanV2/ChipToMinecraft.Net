using System;

namespace Chip.Minecraft {
    ///DOLATER <summary>add description for struct: Box</summary>
    public readonly partial struct Box {
        /// <summary>Creates a new instance of <see cref="Box"/></summary>
        /// <param name="From"></param>
        /// <param name="To"></param>
        public Box(Location From, Location To) {
            this.From = From;
            this.To = To;
        }


        /// <summary>Creates a new instance of <see cref="Box"/></summary>
        /// <param name="From"></param>
        /// <param name="To"></param>
        public Box(Int32 xFrom, Int32 yFrom, Int32 zFrom, Int32 xTo, Int32 yTo, Int32 zTo) {
            this.From = new Location(xFrom, yFrom, zFrom);
            this.To = new Location(xTo, yTo, zTo);
        }
    }
}
