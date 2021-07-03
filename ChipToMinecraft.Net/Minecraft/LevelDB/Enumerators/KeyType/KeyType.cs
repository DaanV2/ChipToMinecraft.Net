using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Chip.Minecraft.LevelDB {
    ///DOLATER <summary>add description for enumerator: KeyType</summary>
    public enum KeyType {
        /// <summary>Wrong request</summary>
        NONE = 0,

        /// <summary>Entity data, stored as little-endian NBT</summary>
        TagEntity = 0x02,

        /// <summary>Biomes and elevation data</summary>
        Data2D = 45,

        ///DOLATER <summary>Add Description</summary>
        Data2DLegacy = 46,

        /// <summary>Terrain for a 16×16×16 subchunk</summary>
        SubChunkPrefix = 47,

        ///DOLATER <summary>Add Description</summary>
        LegacyTerrain = 48,

        ///DOLATER <summary>Add Description</summary>
        BlockEntity = 49,

        /// <summary>Entity data, stored as little-endian NBT</summary>
        Entity = 50,

        /// <summary>Pending tick data (little-endian NBT)</summary>
        PendingTicks = 51,

        /// <summary>BlockExtraData</summary>
        BlockExtraData = 52,

        /// <summary>BiomeState</summary>
        BiomeState = 53,

        ///DOLATER <summary>Add Description</summary>
        FinalizedState = 54,

        /// <summary>A byte representing the version of the chunk</summary>
        Version = 118
    }
}
