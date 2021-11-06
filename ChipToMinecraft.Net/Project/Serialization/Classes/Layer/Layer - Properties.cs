using System;
using System.Text.Json.Serialization;

namespace Chip.Project.Serialization {
    public partial class Layer {
        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("file")]
        public String Filepath { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("block")]
        public Minecraft.Block Block { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("scale")]
        public Single Scale { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("thickness")]
        public Int32 Thickness { get; set; }
    }
}
