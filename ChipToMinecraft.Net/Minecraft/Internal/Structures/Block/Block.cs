using System;

namespace Chip.Minecraft.Internal {
    ///DOLATER <summary>add description for struct: Block</summary>
    public readonly partial struct Block {
        /// <summary>Creates a new instance of <see cref="Block"/></summary>
        public Block(Byte[] Data) {
            if (Data is null) throw new ArgumentNullException(nameof(Data));

            this.Data = Data;
        }


        /// <summary>
        /// 
        /// </summary>
        public readonly Byte[] Data;
    }
}
