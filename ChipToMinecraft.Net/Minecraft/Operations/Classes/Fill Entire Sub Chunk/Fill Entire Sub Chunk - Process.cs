using System;
using System.Collections.Generic;
using System.Threading;
using DaanV2.NBT;

namespace Chip.Minecraft.Operations {
    public partial class FillEntireSubChunk {
        /// <summary> </summary>
        /// <param name="ToFill"></param>
        /// <returns></returns>
        public ChunkUpdate Fill(SubChunk ToFill) {
            ToFill.Pallete = new List<NBTTagCompound> {
                this.Block
            };

#if DEBUG
            System.Diagnostics.Debug.WriteLine($"[Chunk: {ToFill.Location}]: Filling All: {this.Block.GetSubValue<String>("name")} T{Thread.CurrentThread.ManagedThreadId}");
#endif

            UInt32[] Words = ToFill.Words;
            Int32 Count = Words.Length;
            const UInt32 Index = 0;

            for (Int32 I = 0; I < Count; I++) {
                Words[I] = Index;
            }

            return ChunkUpdate.Updated;
        }
    }
}
