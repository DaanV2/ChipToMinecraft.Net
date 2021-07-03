using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chip.Minecraft.LevelDB {
    public partial class BlockStorage {
        ///DOLATER <summary>Add Description</summary>
        public const Int32 WordByteSize = sizeof(UInt32);

        ///DOLATER <summary>Add Description</summary>
        public const Int32 WordBitSize = WordByteSize * 8;

        ///DOLATER <summary>Add Description</summary>
        public const Int32 SubChunkBlockCount = 4096;

        ///DOLATER <summary>Add Description</summary>
        public const Int32 LengthConstant = WordByteSize * SubChunkBlockCount;
    }
}
