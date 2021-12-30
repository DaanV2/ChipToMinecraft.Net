using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chip.Minecraft;

namespace Chip.Process {
    public partial class Context {
        /// <summary></summary>
        public IWorld World { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        public Project.Project Project { get; private set; }
    }
}
