using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Chip.Serialization {
    public partial class Project {
        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("world")]
        public String World { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("layers")]
        public List<Layer> Layers { get; set; }
    }
}
