using System;
using DaanV2.NBT;

namespace Chip.Minecraft.LevelDB {
    public partial class BlockStorage {
        /// <summary>The amount of bits used per block</summary>
        public Byte BlockSize { get; set; }

        /// <summary></summary>
        public Boolean Persistance { get; set; }

        /// <summary>The block ID in this blockstorage</summary>
        public UInt32[] Words { get; set; }

        ///DOLATER <summary>Tags is a list of block used as a palette for this section of data</summary>
        public NBTTagCompound[] Tags { get; set; }

    }
}
