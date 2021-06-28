using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Chip.Minecraft.World {
    /// <summary>Non current access to the bedrock world</summary>
    /// <remarks>Not threadsafe</remarks>
    public partial class BedrockWorld {
        /// <summary>Creates a new instance of <see cref="BedrockWorld"/></summary>
        public BedrockWorld(string Folder) {
        }
    }
}
