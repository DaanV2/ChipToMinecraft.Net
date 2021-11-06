using System;
using System.Diagnostics.CodeAnalysis;
using System.Threading;

namespace Chip.Minecraft.Threading {
    public partial class BedrockWorld {
        /// <summary>
        /// 
        /// </summary>
        
        private readonly Minecraft.BedrockWorld _World;

        /// <summary>
        /// 
        /// </summary>
        
        private readonly AutoResetEvent[] _Locks;

        /// <summary>
        /// 
        /// </summary>
        
        private readonly Int32 _Count;
    }
}
