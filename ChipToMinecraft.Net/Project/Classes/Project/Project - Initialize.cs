using System;
using System.Collections.Generic;

namespace Chip.Project {
    ///DOLATER <summary>add description for class: Project</summary>
    public partial class Project {
        /// <summary>Creates a new instance of <see cref="Project"/></summary>
        public Project() {
            this.Layers = new List<Layer>();
            this.Options = new Serialization.ProjectOptions();
            this.Output = String.Empty;
            this.World = String.Empty;
        }
    }
}
