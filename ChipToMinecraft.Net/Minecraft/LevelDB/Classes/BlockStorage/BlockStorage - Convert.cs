using System;
using System.Collections.Generic;
using DaanV2.NBT;

namespace Chip.Minecraft.LevelDB {
    public partial class BlockStorage {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="From"></param>
        /// <param name="To"></param>
        public static void ConvertTo(BlockStorage From, SubChunk To) {
            To.Pallete = new List<NBTTagCompound>(From.Tags);
            To.Words = Decompress(From);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="From"></param>
        /// <param name="To"></param>
        public static void ConvertFrom(SubChunk From, BlockStorage To) {
            To.Tags = From.Pallete.ToArray();

            //Get Blocks
            Byte BlockSize = GetBlockSize(From.Pallete.Count);

            To.BlockSize = BlockSize;

            //Default data
            To.Persistance = false;

            ChunkLocation Location = From.Location;

            // Block storage length grows as the block size grows.
            Int32 Length = BlockStorage.LengthConstant / (BlockStorage.WordBitSize / BlockSize);

            if (BlockSize == 3 || BlockSize == 5 || BlockSize == 6) {
                // Padded formats require one more word to ensure there is enough for the blocks.
                // 4096 / 10 (10 blocks per word with 3 bits per block) results in 409 words, but those are not
                // enough to store, because the number is truncated.
                // All padded formats have another padding word to resolve the problem.
                Length += 4;
            }

            //Fill words
            Int32 WordCount = Length / BlockStorage.WordByteSize;
            UInt32[] Words = new UInt32[WordCount];
            To.Words = Words;

            //Nothing to write, dotnet already nulls the entire array
            if (From.Pallete.Count <= 0) { return; }

            Int32 BlocksPerWord = BlockStorage.WordBitSize / BlockSize;
            Int32 ShiftStart = (BlocksPerWord - 1) * BlockSize;
            //Current Holder
            UInt32 Word = 0;
            //Index current word
            Int32 Index = 0;
            Int32 Shift = 0;
            UInt32 BlockIndex;
            Boolean Empty;

            for (Int32 I = 0; I < From.Words.Length; I++) {
                BlockIndex = From.Words[I];
                Word |= BlockIndex << Shift;
                Shift += BlockSize;
                Empty = false;

                if (Shift > ShiftStart) {
                    Empty = true;
                    Words[Index] = Word;
                    Word = 0;
                    Index++;
                    Shift = 0;
                }

                if (!Empty) {
                    Words[Index] = Word;
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Process"></param>
        /// <returns></returns>
        public static UInt32[] Decompress(BlockStorage Process) {
            UInt32[] Words = Process.Words;
            Int32 WordCount = Words.Length;
            Int32 BlockSize = Process.BlockSize;
            Int32 BlocksPerWord = BlockStorage.WordBitSize / BlockSize;
            UInt32[] Out = new UInt32[WordCount * BlocksPerWord];
            Int32 Index = 0;
            UInt32 Mask = GetMask(BlockSize);

            //Grab all the IDs from the words
            for (Int32 I = 0; I < WordCount; I++) {
                UInt32 Word = Words[I];

                for (Int32 B = 0; B < BlocksPerWord; B++) {
                    Out[Index++] = (UInt16)(Word & Mask);
                    Word >>= BlockSize;
                }
            }

            return Out;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="BlockSize"></param>
        /// <returns></returns>
        public static UInt32 GetMask(Int32 BlockSize) {
            switch (BlockSize) {
                case 1:
                    return 0b0000_0001;
                case 2:
                    return 0b0000_0011;
                case 3:
                    return 0b0000_0111;
                case 4:
                    return 0b0000_1111;
                case 5:
                    return 0b0001_1111;
                case 6:
                    return 0b0011_1111;
                case 8:
                    return 0b1111_1111;
                case 16:
                    return 0b1111_1111_1111_1111;
            }

            return 0;
        }

        /// <summary>Gets the blocksize that is needed to store the specified amount of blocks</summary>
        /// <param name="AmountOfBlocks">The amount of blocks to store</param>
        /// <returns>Gets the blocksize that is needed to store the specified amount of blocks</returns>
        public static Byte GetBlockSize(Int32 AmountOfBlocks) {
            Int32 MaxValue = AmountOfBlocks - 1;
            Byte Count;

            //Count bits
            for (Count = 0; MaxValue > 0; MaxValue >>= 1) {
                Count++;
            }

            if (Count == 0) {
                return 1;
            }

            if (Count <= 6) {
                return Count;
            }

            if (Count == 7) {
                return 8;
            }

            return 16;
        }
    }
}
