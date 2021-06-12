using System;
using System.Text.Json.Serialization;
using Chip.Minecraft;

namespace Chip.Serialization {
    public partial class Layer {
        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("file")]
        public String File { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("location")]
        public Location Start { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("thickness")]
        public Int32 Thickness { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("scale")]
        public Single Scale { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("block")]
        public Block Block { get; set; }
    }
}
