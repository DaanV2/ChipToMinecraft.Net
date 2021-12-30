using System;
using DaanV2.NBT;

namespace Chip.Minecraft {
    ///DOLATER <summary>add description for struct: BlockCache</summary>
    public partial struct BlockCache {
        /// <summary>Creates a new instance of <see cref="BlockCache"/></summary>
        /// <param name="Block"></param>
        public BlockCache(Block Block) {
            this.Block = Block;
            this.NBT = this.Block.ToNBT();
        }

        /// <summary>Creates a new instance of <see cref="BlockCache"/></summary>
        /// <param name="ID"></param>
        public BlockCache(String ID) {
            this.Block = new Block(ID);
            this.NBT = this.Block.ToNBT();
        }

        public readonly Block Block;
        public readonly NBTTagCompound NBT;


        /// <summary></summary>
        /// <param name="value"></param>
        public static implicit operator Block(BlockCache value) {
            return value.Block;
        }

        /// <summary></summary>
        /// <param name="value"></param>
        public static implicit operator NBTTagCompound(BlockCache value) {
            return value.NBT;
        }
    }
}
