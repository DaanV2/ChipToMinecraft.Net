using System;
using System.IO;
using System.Runtime.CompilerServices;
using DaanV2.Binary;
using DaanV2.IO;
using DaanV2.NBT;
using DaanV2.NBT.Serialization;

namespace Chip.Minecraft.LevelDB {
    ///DOLATER <summary>add description for class: SubChunkFormat</summary>
    public static partial class SubChunkFormat {
        /// <summary> </summary>
        /// <param name="O"></param>
        /// <param name="Writer"></param>
        public static void Serialize(SubChunk data, MemoryStream Writer) {
            var storage = new BlockStorage();
            BlockStorage.ConvertFrom(data, storage);
            InternalSerialize(storage, Writer);
        }

        /// <summary> </summary>
        /// <param name="O"></param>
        /// <param name="Writer"></param>
        public static void Serialize(BlockStorage O, MemoryStream Writer) {
            InternalSerialize(O, Writer);
        }

        /// <summary> </summary>
        /// <param name="O"></param>
        /// <param name="Writer"></param>
        public static void Serialize(BlockStorage O, Stream Writer) {
            InternalSerialize(O, Writer);
        }

        /// <summary> </summary>
        /// <param name="O"></param>
        /// <param name="Writer"></param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static void InternalSerialize(BlockStorage O, Stream Writer) {
#if DEBUG
            if (O.BlockSize <= 0) {
                throw new ArgumentException("Blockstorage blocksize cannot be 0 or lower");
            }
#endif

            //Write block size and presistance into the stream
            Byte Data = (Byte)((O.BlockSize << 1) | (O.Persistance ? 0b0000_0001 : 0));
            Writer.WriteByte(Data);
            var Context = new SerializationContext(Endianness.LittleEndian, Writer);

            //Write Words
            // Block storage length grows as the block size grows.
            Byte BlockSize = O.BlockSize;
            Int32 Length = BlockStorage.LengthConstant / (BlockStorage.WordBitSize / BlockSize);

            if (BlockSize == 3 || BlockSize == 5 || BlockSize == 6) {
                // Padded formats require one more word to ensure there is enough for the blocks.
                // 4096 / 10 (10 blocks per word with 3 bits per block) results in 409 words, but those are not
                // enough to store, because the number is truncated.
                // All padded formats have another padding word to resolve the problem.
                Length += 4;
            }

            Int32 WordCount = Length / BlockStorage.WordByteSize;
            UInt32[] Words = O.Words;

            for (Int32 I = 0; I < WordCount; I++) {
                Writer.LittleEndian_Write(Words[I]);
            }

            //Write Palette
            ITag[] Tags = O.Tags;
            Int32 PaletteEntryCount = Tags.Length;

#if DEBUG
            if (PaletteEntryCount <= 0) {
                throw new ArgumentException("Blockstorage palette count cannot be 0 or lower");
            }
#endif

            //Write count away
            Writer.LittleEndian_Write(PaletteEntryCount);

            //Write tags
            for (Int32 I = 0; I < PaletteEntryCount; I++) {
                NBTWriter.Write(Tags[I], Context);
            }
        }
    }
}
