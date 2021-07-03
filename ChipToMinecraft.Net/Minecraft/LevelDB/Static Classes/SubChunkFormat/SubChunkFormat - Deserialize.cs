using System;
using System.IO;
using System.Runtime.CompilerServices;
using DaanV2.Binary;
using DaanV2.IO;
using DaanV2.NBT;
using DaanV2.NBT.Serialization;

namespace Chip.Minecraft.LevelDB {
    public static partial class SubChunkFormat {
        /// <summary> </summary>
        /// <param name="stream"></param>
        /// <returns></returns>
        public static BlockStorage Deserialize(MemoryStream stream) {
            return InternalDeserialize(stream);
        }

        /// <summary> </summary>
        /// <param name="stream"></param>
        /// <returns></returns>
        public static BlockStorage Deserialize(Stream stream) {
            return InternalDeserialize(stream);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static BlockStorage InternalDeserialize(Stream stream) {
            // blockSize is contained in the header. It is the first 7 bits of the header byte. The last bit is
            // always set to 0 here. (persistent, not runtime)
            Byte Data = (Byte)stream.ReadByte();
            Byte BlockSize = (Byte)(Data >> 1);
            Boolean Presistance = (Data & 0b0000_0001) > 0;

            // Block storage length grows as the block size grows.
            Int32 Length = BlockStorage.LengthConstant / (BlockStorage.WordBitSize / BlockSize);

#if DEBUG
            Int32 BlocksPerWord = BlockStorage.WordBitSize / BlockSize;
            Int32 SusWordCount = 4096 / BlocksPerWord;
            if (SusWordCount != Length / BlockStorage.WordByteSize) {
                throw new Exception("wrong");
            }
#endif

            if (BlockSize == 3 || BlockSize == 5 || BlockSize == 6) {
                // Padded formats require one more word to ensure there is enough for the blocks.
                // 4096 / 10 (10 blocks per word with 3 bits per block) results in 409 words, but those are not
                // enough to store, because the number is truncated.
                // All padded formats have another padding word to resolve the problem.
                Length += 4;
            }

            Int32 WordCount = Length / BlockStorage.WordByteSize;
            UInt32[] Words = new UInt32[WordCount];

            //Read all block data
            for (Int32 I = 0; I < WordCount; I++) {
                Words[I] = stream.LittleEndian_ReadUInt32();
            }

            Int32 PaletteEntryCount = stream.LittleEndian_ReadInt32();
            var Tags = new NBTTagCompound[PaletteEntryCount];

            if (Presistance) {
                for (Int32 I = 0; I < PaletteEntryCount; I++) {
                    UInt32 Word = stream.LittleEndian_ReadUInt32();
                }
            }
            else {
                for (Int32 I = 0; I < PaletteEntryCount; I++) {
                    Tags[I] = (NBTTagCompound)NBTReader.Read(stream, Endianness.LittleEndian);
                }
            }

            return new BlockStorage() {
                Persistance = Presistance,
                Words = Words,
                Tags = Tags,
                BlockSize = BlockSize
            };
        }
    }
}
