using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chip.Minecraft.LevelDB {
    ///DOLATER <summary>add description for interface: ILevelDBContainer</summary>
    public interface ILevelDBContainer {
        /// <summary>
        /// 
        /// </summary>
        public global::LevelDB.DB Db { get; }
    }
}
