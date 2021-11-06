﻿using System;
using System.Collections.Generic;
using System.IO;
using DaanV2.NBT;

namespace Chip.Minecraft.LevelDB {
    public static partial class SubChunkFormat {
        /// <summary> </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="Container"></param>
        /// <param name="X"></param>
        /// <param name="Y"></param>
        /// <param name="Z"></param>
        /// <returns></returns>
        public static SubChunk Get<T>(this T Container, Int32 X, Int32 Y, Int32 Z)
            where T : ILevelDBContainer {
            return Get<T>(Container, new ChunkLocation(X, Y, Z));
        }

        /// <summary> </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="Container"></param>
        /// <param name="Chunk"></param>
        /// <returns></returns>
        public static SubChunk Get<T>(this T Container, ChunkLocation Chunk)
            where T : ILevelDBContainer {

            global::LevelDB.DB DB = Container.Db;
            if (DB == null) return null;

            Byte Version = ChunkFormat.GetVersion(Container, Chunk.X, Chunk.Z);

            var Out = new SubChunk();

            if (Version != 8) {
                return Out;
            }

            Byte[] SubChunkKey = KeyUtillities.CreateSubChunkKey(Chunk);
            Byte[] Data = DB.Get(SubChunkKey);
            var stream = new MemoryStream(Data);
            Version = (Byte)stream.ReadByte();
            Int32 LayerCount = stream.ReadByte();

            if (LayerCount == 0) {
                return Out;
            }

            if (Version == 8) {
                BlockStorage BS = Deserialize(stream);
                BlockStorage.ConvertTo(BS, Out);
            }
            else {
                Out.Pallete = new List<NBTTagCompound>() { BlockFactory.Blocks.Air.ToNBT() };
            }

            return Out;
        }
    }
}
