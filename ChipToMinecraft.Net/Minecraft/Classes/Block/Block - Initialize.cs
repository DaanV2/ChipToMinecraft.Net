using System;
using System.Collections.Generic;

namespace Chip.Minecraft {
    ///DOLATER <summary>add description for class: Block</summary>
    public partial class Block {
        /// <summary>Creates a new instance of <see cref="Block"/></summary>
        public Block() {
            this.ID = String.Empty;
            this.States = new List<BlockState>();
        }

        /// <summary>Creates a new instance of <see cref="Block"/></summary>ID
        /// <param name="ID"></param>
        public Block(String ID) {
            this.ID = ID;
            this.States = new List<BlockState>();
        }
    }
}
