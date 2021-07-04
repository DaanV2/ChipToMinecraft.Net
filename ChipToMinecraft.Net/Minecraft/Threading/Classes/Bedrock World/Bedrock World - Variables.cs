using System;
using System.Diagnostics.CodeAnalysis;
using System.Threading;

namespace Chip.Minecraft.Threading {
    public partial class BedrockWorld {
        /// <summary>
        /// 
        /// </summary>
        [NotNull]
        private readonly Minecraft.BedrockWorld _World;

        /// <summary>
        /// 
        /// </summary>
        [NotNull]
        private readonly AutoResetEvent[] _Locks;

        /// <summary>
        /// 
        /// </summary>
        [NotNull]
        private readonly Int32 _Count;
    }
}
