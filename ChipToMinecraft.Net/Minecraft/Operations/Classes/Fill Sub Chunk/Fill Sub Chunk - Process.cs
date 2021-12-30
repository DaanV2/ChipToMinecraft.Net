using System;
using System.Threading;

namespace Chip.Minecraft.Operations {
    public partial class FillSubChunk {
        /// <summary> </summary>
        /// <param name="ToFill"></param>
        /// <returns></returns>
        public ChunkUpdate Fill(SubChunk ToFill, Box Area) {
            this.SetData(Area, (Location)ToFill.Location);

            UInt32 Index;
            Int32 Count = ToFill.Pallete.Count;

            for (Int32 I = 0; I < Count; I++) {
                if (this.Block.Equals(ToFill.Pallete[I])) {
                    Index = (UInt32)I;
                    goto skipset;
                }
            }

            //If nothing is found
            Index = (UInt32)Count;
            ToFill.Pallete.Add(this.Block);

        skipset:
            UInt32[] Words = ToFill.Words;

            for (Int32 X = this.StartX; X < this.EndX; X++) {
                Int32 xMask = SubChunk.GetIndex(X, 0, 0);

                for (Int32 Z = this.StartZ; Z < this.EndZ; Z++) {
                    Int32 zMask = SubChunk.GetIndex(0, 0, Z) | xMask;

                    for (Int32 Y = this.StartY; Y < this.EndY; Y++) {
                        Int32 c = zMask | Y;

                        Words[c] = Index;
                    }
                }
            }

            return ChunkUpdate.Updated;
        }
    }
}
