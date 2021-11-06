using System;
using System.Collections.Generic;
using DaanV2.NBT;

namespace Chip.Minecraft {
    public partial class SubChunk {
        /// <summary> </summary>
        public ChunkLocation Location;

        /// <summary> </summary>
        public UInt32[] Words;

        /// <summary> </summary>
        public List<NBTTagCompound> Pallete;
    }
}
