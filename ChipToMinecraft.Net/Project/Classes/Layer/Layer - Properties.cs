using System;
using Chip.Minecraft;
using DaanV2.NBT;

namespace Chip.Project {
    public partial class Layer {
        /// <summary>
        /// 
        /// </summary>
        public String Filepath { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Location StartLocation { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Single Scale { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Int32 Thickness { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public NBTTagCompound Block { get; set; }
    }
}
