using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Chip.Minecraft {
    public partial class Block {
        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("id")]
        public String ID { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("states")]
        public List<BlockState> States { get; set; }
    }
}
