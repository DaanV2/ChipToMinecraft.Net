using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
