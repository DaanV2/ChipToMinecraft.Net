using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using Chip.Minecraft;

namespace UnitTesting {
    ///DOLATER <summary>add description for class: FakeSubChunk</summary>
    public partial class FakeSubChunk : SubChunk {

        public FakeSubChunk() : base() {
            this.Gets = 0;
            this.Sets = 0;
        }

        public Int32 Gets;
        public Int32 Sets;

        public static FakeSubChunk Create(ChunkLocation Location) {
            return new FakeSubChunk() {
                Location = Location,
                Pallete = new List<DaanV2.NBT.NBTTagCompound>() { Blocks.AirBlock },
                Words = new UInt32[16 * 16 * 16]
            };
        }
    }
}
