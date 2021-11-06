using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using DaanV2.NBT;

namespace Chip.Minecraft.LevelDB {
    ///DOLATER <summary>add description for class: BlockStorage</summary>
    public partial class BlockStorage {
        /// <summary>Creates a new instance of <see cref="BlockStorage"/></summary>
        public BlockStorage() {
            this.BlockSize = 1;
            this.Persistance = true;
            this.Words = null;
            this.Tags = null;
        }

        /// <summary>Creates a new instance of <see cref="BlockStorage"/></summary>
        /// <param name="blockSize">The size of the block</param>
        /// <param name="persistance">If the data should be presistance</param>
        /// <param name="words">The words</param>
        /// <param name="tags">The palette of blocks</param>
        public BlockStorage(Byte blockSize, Boolean persistance, UInt32[] words, NBTTagCompound[] tags) {
            this.BlockSize = blockSize;
            this.Persistance = persistance;
            this.Words = words;
            this.Tags = tags;
        }
    }
}
