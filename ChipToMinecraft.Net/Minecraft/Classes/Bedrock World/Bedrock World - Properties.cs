using System;
using Chip.Minecraft.LevelDB;

namespace Chip.Minecraft {
    public partial class BedrockWorld : ILevelDBContainer {
        /// <summary> </summary>
        public global::LevelDB.DB Db { get; private set; }

        /// <summary> </summary>
        public String Folder { get; private set; }
    }
}
