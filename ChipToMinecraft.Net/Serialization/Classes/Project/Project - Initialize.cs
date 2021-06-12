using System;
using System.Collections.Generic;

namespace Chip.Serialization {
    ///DOLATER <summary>add description for class: Project</summary>
    public partial class Project {
        /// <summary>Creates a new instance of <see cref="Project"/></summary>
        public Project() {
            this.World = String.Empty;
            this.Layers = new List<Layer>();
        }
    }
}
