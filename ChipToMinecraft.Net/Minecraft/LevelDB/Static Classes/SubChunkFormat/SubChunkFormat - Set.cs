using System;
using System.Collections.Generic;
using System.IO;
using Chip.Minecraft;

namespace Chip.Minecraft.LevelDB {
    public static partial class SubChunkFormat {
        /// <summary> </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="Container"></param>
        /// <param name="Chunk"></param>
        /// <returns></returns>
        public static void Set<T>(this T Container, SubChunk Data)
            where T : ILevelDBContainer {

            global::LevelDB.DB DB = Container.Db;
            if (DB == null) return;

            var Writer = new MemoryStream(411);

            //Write the version
            Writer.WriteByte((Byte)8);
            //Write amount of storages
            Writer.WriteByte((Byte)1);

            SubChunkFormat.Serialize(Data, Writer);

            Byte[] SubChunkKey = KeyUtillities.CreateSubChunkKey(Data.Location);
            DB.Put(SubChunkKey, Writer.ToArray());
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="Container"></param>
        /// <param name="Data"></param>
        public static void Set<T>(this T Container, List<SubChunk> Data)
            where T : ILevelDBContainer {

            global::LevelDB.DB DB = Container.Db;
            if (DB == null) return;

            var Writer = new MemoryStream((Data.Count * 410) + 1);

            //Write the version
            Writer.WriteByte((Byte)8);
            //Write amount of storages
            Writer.WriteByte((Byte)Data.Count);

            foreach (SubChunk SC in Data) {
                SubChunkFormat.Serialize(SC, Writer);
            }

            Byte[] SubChunkKey = KeyUtillities.CreateSubChunkKey(Data[0].Location);
            DB.Put(SubChunkKey, Writer.ToArray());
        }
    }
}
