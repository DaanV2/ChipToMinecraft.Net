using System;
using System.Collections.Generic;
using Chip.Minecraft;
using DaanV2.NBT;

namespace UnitTesting {
    public partial class FakeWorld {
        /// <summary> </summary>
        /// <param name="Block"></param>
        /// <returns></returns>
        public Int32 CountBlock(NBTTagCompound Block) {
            Int32 Out = 0;

            foreach (KeyValuePair<ChunkLocation, FakeSubChunk> Item in this.Cache) {
                FakeSubChunk SubChunk = Item.Value;

                //Find block in subchunk
                Int32 Index = SubChunk.Pallete.IndexOf(Block);

                if (Index > -1) {
                    UInt32 Find = (UInt32)Index;

                    //Count words
                    for (Int32 I = 0; I < SubChunk.Words.Length; I++) {
                        if (SubChunk.Words[I] == Find) {
                            Out++;
                        }
                    }
                }
            }

            return Out;
        }
    }
}
