using System;
using System.Threading;

namespace Chip.Minecraft.Threading {
    ///DOLATER <summary>add description for class: BedrockWorld</summary>
    public partial class BedrockWorld {
        /// <summary>Creates a new instance of <see cref="BedrockWorld"/></summary>
        /// <param name="BW"></param>
        /// <param name="Concurrency"></param>
        internal BedrockWorld(Chip.Minecraft.BedrockWorld BW, Int32 Concurrency = -1) {
            this._World = BW;

            if (Concurrency <= 0) {
                Concurrency = Environment.ProcessorCount;
            }

            this._Count = Math.Max(Concurrency * 2, 16);
            this._Locks = new AutoResetEvent[this._Count];

            for (Int32 I = 0; I < this._Count; I++) {
                this._Locks[I] = new AutoResetEvent(true);
            }
        }
    }
}
