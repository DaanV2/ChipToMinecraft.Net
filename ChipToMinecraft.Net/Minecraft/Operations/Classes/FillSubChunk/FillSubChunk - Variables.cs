using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DaanV2.NBT;

namespace Chip.Minecraft.Operations {
    public partial class FillSubChunk {
        /// <summary>
        /// 
        /// </summary>
        public Int32 StartX { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        public Int32 StartY { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        public Int32 StartZ { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        public Int32 EndX { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        public Int32 EndY { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        public Int32 EndZ { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        public readonly NBTTagCompound Block;
    }
}
