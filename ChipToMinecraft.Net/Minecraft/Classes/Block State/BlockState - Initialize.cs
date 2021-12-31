using System;
using System.Text.Json.Serialization;
using Chip.Minecraft.Serialization;

namespace Chip.Minecraft {
    ///DOLATER <summary>add description for class: BlockState</summary>
    [Serializable, JsonConverter(typeof(BlockStateConverter))]
    public partial class BlockState {
        /// <summary>Creates a new instance of <see cref="BlockState"/></summary>
        public BlockState() {
            this.Name = String.Empty;
            this.Type = "int";
            this.Value = 0;
        }

        /// <summary>Creates a new instance of <see cref="BlockState"/></summary>
        /// <param name="name"></param>
        /// <param name="type"></param>
        /// <param name="value"></param>
        public BlockState(String name, String type, Object value) {
            this.Name = name;
            this.Type = type;
            this.Value = value;
        }
    }
}
