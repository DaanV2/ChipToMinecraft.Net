using System;
using System.Text.Json.Serialization;
using Chip.Minecraft;

namespace Chip {
    public partial class LayerSpecification {
        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("file")]
        public String Filepath { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("block")]
        public Block Block { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("scale")]
        public Single Scale { get; set; }
    }
}
