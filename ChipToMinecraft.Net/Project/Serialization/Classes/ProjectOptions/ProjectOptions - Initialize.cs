using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Chip.Project.Serialization {
    ///DOLATER <summary>add description for class: ProjectOptions</summary>
    public partial class ProjectOptions {
        /// <summary>Creates a new instance of <see cref="ProjectOptions"/></summary>
        public ProjectOptions() {
            this.Concurrency = Environment.ProcessorCount;
            this.MultiThread = true;
        }
    }
}
