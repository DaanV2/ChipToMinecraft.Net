using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using Chip.Minecraft;

namespace Chip.Process {
    ///DOLATER <summary>add description for class: Context</summary>
    public partial class Context {
        /// <summary>Creates a new instance of <see cref="Context"/></summary>
        /// <param name="world"></param>
        /// <param name="project"></param>
        public Context(IWorld world, Project.Project project) {
            this.World = world;
            this.Project = project;
        }
    }
}
