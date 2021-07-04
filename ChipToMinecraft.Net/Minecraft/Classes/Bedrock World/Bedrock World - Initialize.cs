using System;
using LevelDB;

namespace Chip.Minecraft {
    /// <summary>Non current access to the bedrock world</summary>
    /// <remarks>Not threadsafe</remarks>
    public partial class BedrockWorld {
        /// <summary>Creates a new instance of <see cref="BedrockWorld"/></summary>
        internal BedrockWorld() {
            this.Folder = String.Empty;
            this.Db = null;
        }

        /// <summary>Disposes of this bedrock world</summary>
        ~BedrockWorld() {
            this.Close();
        }
    }
}
