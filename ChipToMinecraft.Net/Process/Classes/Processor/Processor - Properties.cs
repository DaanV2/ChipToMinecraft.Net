using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chip.Process {
    public partial class Processor {
        /// <summary>
        /// 
        /// </summary>
        public Context Context { get; private set; }

        public BitmapProcessor BitmapProcessor { get; private set; }
    }
}
