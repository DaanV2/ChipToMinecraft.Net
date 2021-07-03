using System;

namespace Chip.Minecraft.LevelDB {
    ///DOLATER <summary>add description for class: KeyUtillities</summary>
    public static partial class KeyUtillities {

        ///DOLATER <summary>Add Description</summary>
        /// <param name="X">The X coordinate of the chunk, not the world</param>
        /// <param name="Z">The Z coordinate of the chunk, not the world</param>
        /// <param name="Type">FILL IN</param>
        /// <param name="AdditionalData">FILL IN</param>
        ///DOLATER <returns>Fill in return</returns>
        public static Byte[] CreateKey(Int32 X, Int32 Z, KeyType Type, Byte AdditionalData = 0) {
            switch (Type) {
                case KeyType.SubChunkPrefix:
                    return CreateSubChunkKey(X, Z, AdditionalData);

                default:
                    Byte[] Out = new Byte[9];
                    DaanV2.Binary.BitConverter.LittleEndian.OntoBytes(Out, X, 0);
                    DaanV2.Binary.BitConverter.LittleEndian.OntoBytes(Out, Z, 4);
                    Out[8] = (Byte)Type;

                    return Out;
            }
        }

        ///DOLATER <summary>Add Description</summary>
        /// <param name="X">The X coordinate of the chunk, not the world</param>
        /// <param name="Z">The Z coordinate of the chunk, not the world</param>
        /// <param name="Type">FILL IN</param>
        /// <param name="AdditionalData">FILL IN</param>
        ///DOLATER <returns>Fill in return</returns>
        public static Byte[] CreateKey(Int32 X, Int32 Z, WorldLocation Location, KeyType Type, Byte AdditionalData = 0) {
            switch (Type) {
                case KeyType.SubChunkPrefix:
                    return CreateSubChunkKey(X, Z, Location, AdditionalData);

                default:
                    Byte[] Out = new Byte[13];
                    DaanV2.Binary.BitConverter.LittleEndian.OntoBytes(Out, X, 0);
                    DaanV2.Binary.BitConverter.LittleEndian.OntoBytes(Out, Z, 4);
                    DaanV2.Binary.BitConverter.LittleEndian.OntoBytes(Out, (Int32)Location, 8);
                    Out[12] = (Byte)Type;

                    return Out;
            }
        }

        ///DOLATER <summary>Add Description</summary>
        /// <param name="X">The X coordinate of the chunk, not the world</param>
        /// <param name="Z">The Z coordinate of the chunk, not the world</param>
        ///DOLATER <returns>Fill in return</returns>
        public static Byte[] CreateVersionKey(Int32 X, Int32 Z) {
            Byte[] Out = new Byte[9];
            DaanV2.Binary.BitConverter.LittleEndian.OntoBytes(Out, X, 0);
            DaanV2.Binary.BitConverter.LittleEndian.OntoBytes(Out, Z, 4);

            Out[8] = (Byte)KeyType.Version;

            return Out;
        }

        ///DOLATER <summary>Add Description</summary>
        /// <param name="X">The X coordinate of the chunk, not the world</param>
        /// <param name="Z">The Z coordinate of the chunk, not the world</param>
        /// <param name="Y">FILL IN</param>
        ///DOLATER <returns>Fill in return</returns>
        public static Byte[] CreateSubChunkKey(Int32 X, Int32 Z, Byte Y) {
            Byte[] Out = new Byte[10];
            DaanV2.Binary.BitConverter.LittleEndian.OntoBytes(Out, X, 0);
            DaanV2.Binary.BitConverter.LittleEndian.OntoBytes(Out, Z, 4);

            Out[8] = (Byte)KeyType.SubChunkPrefix;
            Out[9] = Y;

            return Out;
        }

        ///DOLATER <summary>Add Description</summary>
        /// <param name="X">The X coordinate of the chunk, not the world</param>
        /// <param name="Z">The Z coordinate of the chunk, not the world</param>
        /// <param name="Y">FILL IN</param>
        ///DOLATER <returns>Fill in return</returns>
        public static Byte[] CreateSubChunkKey(ChunkLocation Chunk) {
            Byte[] Out = new Byte[10];
            DaanV2.Binary.BitConverter.LittleEndian.OntoBytes(Out, Chunk.X, 0);
            DaanV2.Binary.BitConverter.LittleEndian.OntoBytes(Out, Chunk.Z, 4);

            Out[8] = (Byte)KeyType.SubChunkPrefix;
            Out[9] = (Byte)Chunk.Y;

            return Out;
        }

        ///DOLATER <summary>Add Description</summary>
        /// <param name="X">The X coordinate of the chunk, not the world</param>
        /// <param name="Z">The Z coordinate of the chunk, not the world</param>
        /// <param name="Location">FILL IN</param>
        /// <param name="Y">FILL IN</param>
        ///DOLATER <returns>Fill in return</returns>
        public static Byte[] CreateSubChunkKey(Int32 X, Int32 Z, WorldLocation Location, Byte Y) {
            if (Location == WorldLocation.Overworld) {
                return CreateSubChunkKey(X, Z, Y);
            }

            Byte[] Out = new Byte[14];
            DaanV2.Binary.BitConverter.LittleEndian.OntoBytes(Out, X, 0);
            DaanV2.Binary.BitConverter.LittleEndian.OntoBytes(Out, Z, 4);
            DaanV2.Binary.BitConverter.LittleEndian.OntoBytes(Out, (Int32)Location, 8);

            Out[12] = (Byte)KeyType.SubChunkPrefix;
            Out[13] = Y;

            return Out;
        }

    }
}
