using System;
using LevelDB;

namespace Chip.Minecraft.World {
    /// <summary>Non current access to the bedrock world</summary>
    /// <remarks>Not threadsafe</remarks>
    public partial class BedrockWorld {
        /// <summary>Creates a new instance of <see cref="BedrockWorld"/></summary>
        internal BedrockWorld() {
            this.Folder = String.Empty;
        }

        /// <summary>Creates a new instance of <see cref="BedrockWorld"/></summary>
        /// <param name="Folder">The world storage location</param>
        internal BedrockWorld(String Folder) {
            this.Folder = Folder;
            var O = new Options {
                CompressionLevel = global::LevelDB.CompressionLevel.ZlibRawCompression
            };

            this.Db = new DB(Folder + "db", O);
        }

        /// <summary>Disposes of this bedrock world</summary>
        ~BedrockWorld() {
            this.Close();
        }
    }
}
