using System;
using System.Threading;

namespace Chip.Minecraft.Threading {
    public partial class BedrockWorld {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Location"></param>
        /// <returns></returns>
        internal AutoResetEvent GetLock(ChunkLocation Location) {
            Int32 Index = Location.X ^ Location.Y ^ Location.Z;

            Index %= this._Count;

            return this._Locks[Index];
        }
    }
}
