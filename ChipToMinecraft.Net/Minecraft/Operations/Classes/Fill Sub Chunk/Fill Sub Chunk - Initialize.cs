using System;
using DaanV2.NBT;

namespace Chip.Minecraft.Operations {
    ///DOLATER <summary>add description for class: FillSubChunk</summary>
    public partial class FillSubChunk {
        /// <summary>Creates a new instance of <see cref="FillSubChunk"/></summary>
        public FillSubChunk(NBTTagCompound Block) {
            this.Block = Block;
        }

        /// <summary> </summary>
        /// <param name="Area">The total area to filled</param>
        /// <param name="Anchor">The chunk coordinates to determine the pattern from</param>
        public FillSubChunk(Box Area, Location Anchor, NBTTagCompound Block) {
            this.Block = Block;
            this.SetData(Area, Anchor);
        }
    }
}
