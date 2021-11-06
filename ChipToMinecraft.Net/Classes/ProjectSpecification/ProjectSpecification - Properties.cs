using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Chip {
    public partial class ProjectSpecification {
        [JsonPropertyName("world")]
        public String World { get; set; }

        [JsonPropertyName("layers")]
        public List<LayerSpecification> Layers { get; set; }
    }
}
