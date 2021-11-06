using System;
using System.Collections.Concurrent;
using Chip.Minecraft;
using DaanV2.NBT;

namespace UnitTesting {
    public partial class FakeWorld : IWorld {
        private Int32 _SubChunkReads;
        private Int32 _SubChunkWrites;

        /// <summary> </summary>
        public Boolean IsClosed { get; set; }

        /// <summary> </summary>
        public ConcurrentDictionary<ChunkLocation, FakeSubChunk> Cache { get; set; }

        public Int32 SubChunkReads { get => _SubChunkReads; set => _SubChunkReads = value; }
        public Int32 SubChunkWrites { get => _SubChunkWrites; set => _SubChunkWrites = value; }

        public FakeWorld(Boolean StoreCache = true) {
            this.IsClosed = false;
            this.SubChunkReads = 0;
            this.SubChunkWrites = 0;

            if (StoreCache) {
                this.Cache = new ConcurrentDictionary<ChunkLocation, FakeSubChunk>();
            }
        }

        /// <summary> </summary>
        /// <returns></returns>
        public Boolean Close() {
            this.IsClosed = true;
            return this.IsClosed;
        }

        /// <summary> </summary>
        /// <param name="Location"></param>
        /// <returns></returns>
        public SubChunk GetSubChunk(ChunkLocation Location) {
            System.Threading.Interlocked.Increment(ref this._SubChunkReads);

            FakeSubChunk Out;

            if (this.Cache != null) {
                Out = this.Cache.GetOrAdd(Location, this.Create);
            }
            else {
                Out = this.Create(Location);
            }

            System.Threading.Interlocked.Increment(ref Out.Gets);

            return Out;
        }

        /// <summary> </summary>
        /// <param name="Data"></param>
        public void SetSubChunk(SubChunk Data) {
            FakeSubChunk Item;

            if (Data is FakeSubChunk FSC) {
                Item = FSC;
            }
            else {
                Item = new FakeSubChunk {
                    Location = Data.Location,
                    Pallete = Data.Pallete,
                    Words = Data.Words
                };
            }

            System.Threading.Interlocked.Increment(ref this._SubChunkWrites);
            System.Threading.Interlocked.Increment(ref Item.Sets);

            if (this.Cache != null) {
                this.Cache[Item.Location] = Item;
            }
        }

        internal FakeSubChunk Create(ChunkLocation Location) {
            return FakeSubChunk.Create(Location);
        }


        void IWorld.Close() {
            this.Close();
        }
    }
}
