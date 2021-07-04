using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using DaanV2.NBT;

namespace Chip.Minecraft.Operations {
    ///DOLATER <summary>add description for class: FillEntireSubChunk</summary>
    public partial class FillEntireSubChunk {
        /// <summary>Creates a new instance of <see cref="FillEntireSubChunk"/></summary>
        /// <param name="Block"></param>
        public FillEntireSubChunk(NBTTagCompound Block) {
            this.Block = Block;
        }
    }
}
