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

            if (Index > this._Locks.Length) return this._Locks[0];

            return this._Locks[Index];
        }
    }
}
