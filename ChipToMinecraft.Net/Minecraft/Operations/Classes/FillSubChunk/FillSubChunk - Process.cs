using System;

namespace Chip.Minecraft.Operations {
    public partial class FillSubChunk {
        /// <summary>
        /// 
        /// </summary>
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

            for (Int32 X = this.StartX; X < this.EndX; X++) {
                for (Int32 Y = this.StartY; Y < this.EndY; Y++) {
                    for (Int32 Z = this.StartZ; Z < this.EndZ; Z++) {
                        ToFill.SetWord(X, Y, Z, Index);
                    }
                }
            }

            return ChunkUpdate.Updated;
        }
    }
}
