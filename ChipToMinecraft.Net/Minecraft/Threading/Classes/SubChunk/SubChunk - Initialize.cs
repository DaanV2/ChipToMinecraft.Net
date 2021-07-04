using System.Threading;

namespace Chip.Minecraft.Threading {
    ///DOLATER <summary>add description for class: SubChunk</summary>
    public partial class SubChunk : Chip.Minecraft.SubChunk {
        /// <summary>Creates a new instance of <see cref="SubChunk"/></summary>
        public SubChunk(AutoResetEvent Lock) : base() {
            this._Lock = Lock;
        }

        /// <summary>Unlocks the subchunk during </summary>
        ~SubChunk() {
#if DEBUG
            System.Diagnostics.Debug.WriteLine($"[Chunk: {Location}]: Unlocking T{Thread.CurrentThread.ManagedThreadId}");
#endif

            this._Lock.Set();
            this._Lock = null;
        }
    }
}
