using System.Threading;

namespace Chip.Minecraft.Threading {
    public partial class BedrockWorld : IWorld {
        /// <summary>
        /// 
        /// </summary>
        public void Close() {
            this._World.Close();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Location"></param>
        /// <returns></returns>
        public Chip.Minecraft.SubChunk GetSubChunk(ChunkLocation Location) {
            AutoResetEvent Lock = this.GetLock(Location);

#if DEBUG
            System.Diagnostics.Debug.WriteLine($"[Chunk: {Location}]: Locking T{Thread.CurrentThread.ManagedThreadId}");
#endif

            Lock.WaitOne();
            var SC = SubChunk.Cast(this._World.GetSubChunk(Location), Lock);

            return SC;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Data"></param>
        public void SetSubChunk(Chip.Minecraft.SubChunk Data) {
            this._World.SetSubChunk(Data);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Data"></param>
        public void SetSubChunk(SubChunk Data) {
            this._World.SetSubChunk(Data);
        }
    }
}
