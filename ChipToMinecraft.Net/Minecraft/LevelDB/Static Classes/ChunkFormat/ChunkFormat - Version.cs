using System;

namespace Chip.Minecraft.LevelDB {
    ///DOLATER <summary>add description for class: ChunkFormat</summary>
    public static partial class ChunkFormat {
        public static Byte GetVersion<T>(T Container, Int32 X, Int32 Z)
            where T : ILevelDBContainer {
            global::LevelDB.DB DB = Container.Db;
            Byte[] VersionKey = KeyUtillities.CreateVersionKey(X, Z);
            Byte[] VersionRequest = DB.Get(VersionKey);

            if (VersionRequest == null || VersionRequest.Length < 1) {
                VersionRequest = new Byte[] { 8 };
                DB.Put(VersionKey, VersionRequest);
            }

            return VersionRequest[0];
        }
    }
}
