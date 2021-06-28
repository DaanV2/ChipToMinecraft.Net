using System;

namespace Chip.Minecraft {
    ///DOLATER <summary>add description for struct: Box</summary>
    public readonly partial struct ChunkBox {
        /// <summary>Creates a new instance of <see cref="Box"/></summary>
        /// <param name="From"></param>
        /// <param name="To"></param>
        public ChunkBox(ChunkLocation From, ChunkLocation To) {
            this.From = From;
            this.To = To;
        }


        /// <summary>Creates a new instance of <see cref="Box"/></summary>
        /// <param name="From"></param>
        /// <param name="To"></param>
        public ChunkBox(Int32 xFrom, Int32 yFrom, Int32 zFrom, Int32 xTo, Int32 yTo, Int32 zTo) {
            this.From = new ChunkLocation(xFrom, yFrom, zFrom);
            this.To = new ChunkLocation(xTo, yTo, zTo);
        }
    }
}
