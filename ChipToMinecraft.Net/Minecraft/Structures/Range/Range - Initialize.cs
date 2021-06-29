using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Chip.Minecraft {
    ///DOLATER <summary>add description for struct: Range</summary>
    public partial struct Range {
        /// <summary>Creates a new instance of <see cref="Range"/></summary>
        /// <param name="Start"></param>
        /// <param name="End"></param>
        public Range(Int32 Start, Int32 End) {
            this.Start = Start;
            this.End = End;
        }
    }
}
