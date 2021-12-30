using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Chip.Project.Serialization {
    public partial class Project {
        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("world")]
        public String World { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("output")]
        public String Output { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("options")]
        public ProjectOptions Options { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("layers")]
        public List<Layer> Layers { get; set; }
    }
}
