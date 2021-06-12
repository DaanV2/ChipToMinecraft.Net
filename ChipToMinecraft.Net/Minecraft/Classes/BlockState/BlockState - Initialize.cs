﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Chip.Minecraft {
    ///DOLATER <summary>add description for class: BlockState</summary>
    public partial class BlockState {
        /// <summary>Creates a new instance of <see cref="BlockState"/></summary>
        public BlockState() {
            this.Name = String.Empty;
            this.Type = "int";
            this.Value = 0;
        }
    }
}