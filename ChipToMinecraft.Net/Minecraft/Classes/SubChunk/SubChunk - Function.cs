using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DaanV2.NBT;

namespace Chip.Minecraft {
    public partial class SubChunk {
        /// <summary> </summary>
        /// <param name="X"></param>
        /// <param name="Y"></param>
        /// <param name="Z"></param>
        /// <returns></returns>
        public UInt32 GetWord(Int32 X, Int32 Y, Int32 Z) {
            return this.Words[GetIndex(X, Y, Z)];
        }

        /// <summary> </summary>
        /// <param name="X"></param>
        /// <param name="Y"></param>
        /// <param name="Z"></param>
        /// <param name="Word"></param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void SetWord(Int32 X, Int32 Y, Int32 Z, UInt32 Word) {
            this.Words[GetIndex(X, Y, Z)] = Word;
        }

        /// <summary> </summary>
        /// <param name="X"></param>
        /// <param name="Y"></param>
        /// <param name="Z"></param>
        /// <returns></returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int32 GetIndex(Int32 X, Int32 Y, Int32 Z) {
            return (X << 8) | (Z << 4) | Y;
        }


        /// <summary> </summary>
        /// <param name="Location"></param>
        /// <param name="block"></param>
        /// <returns></returns>
        public static SubChunk Create(ChunkLocation Location, NBTTagCompound block) {
            return new SubChunk() {
                Location = Location,
                Pallete = new List<NBTTagCompound>() { block },
                Words = new UInt32[16 * 16 * 16]
            };
        }
    }
}
