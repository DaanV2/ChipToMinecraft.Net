using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chip.Minecraft.LevelDB;

namespace Chip.Minecraft.World {
    public partial class BedrockWorld : ILevelDBContainer {
        /// <summary> </summary>
        public global::LevelDB.DB Db { get; private set; }

        /// <summary> </summary>
        public string Folder { get; private set; }
    }
}
