using System;
using System.Text.Json.Serialization;

namespace Chip.Minecraft {
    public partial class BlockState {
        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("name")]
        public String Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("type")]
        public String Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("value")]
        public Object Value { get; set; }
    }
}
