using System;
using System.Collections.Generic;

namespace Chip.Minecraft {
    public partial class ChunkCache : IWorld {
        /// <inheritdoc/>
        public void Close() {
            this.SaveCache();
        }

        /// <inheritdoc/>
        public SubChunk GetSubChunk(ChunkLocation Location) {
            SubChunk result;

            this._Lock.WaitOne();
            try {
                result = this.InternalGetSubChunk(Location);
            }
            catch {
                result = SubChunk.Create(Location, BlockFactory.Blocks.Air);
            }
            finally {
                this._Lock.Set();
            }

            return result;
        }

        internal SubChunk InternalGetSubChunk(ChunkLocation Location) {
            if (this.SubChunks.TryGetValue(Location, out SubChunk result))
                return result;
#if DEBUG
            System.Diagnostics.Debug.WriteLine($"Cache: Loading: {Location}");
#endif

            result = this.World.GetSubChunk(Location);
            this.SubChunks[Location] = result;

            return result;
        }

        /// <inheritdoc/>
        public void SetSubChunk(SubChunk Data) {
            this._Lock.WaitOne();

            try {
                this.InternalSetSubChunk(Data);
            }
            finally {
                this._Lock.Set();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Data"></param>
        internal void InternalSetSubChunk(SubChunk Data) {
            this.SubChunks[Data.Location] = Data;

            if (this.ShouldDump) {
                Console.WriteLine("Cache: Dumping chunks");
            }
        }

        public void SaveCache() {
            foreach (KeyValuePair<ChunkLocation, SubChunk> SC in this.SubChunks) {
                this.World.SetSubChunk(SC.Value);
            }

            this.SubChunks.Clear();
        }
    }
}
