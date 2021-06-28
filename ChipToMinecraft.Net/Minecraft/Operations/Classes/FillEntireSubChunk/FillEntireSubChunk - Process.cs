using System;
using System.Collections.Generic;
using DaanV2.NBT;

namespace Chip.Minecraft.Operations {
    public partial class FillEntireSubChunk {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ToFill"></param>
        /// <returns></returns>
        public ChunkUpdate Fill(SubChunk ToFill) {
            ToFill.Pallete = new List<NBTTagCompound> {
                this.Block
            };

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
