using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Chip.Minecraft.Operations {
    ///DOLATER <summary>add description for struct: Location2D</summary>
    public readonly partial struct Location2D {
        /// <summary>Creates a new instance of <see cref="Location2D"/></summary>
        /// <param name="x"></param>
        /// <param name="z"></param>
        public Location2D(Int32 x, Int32 z) {
            this.X = x;
            this.Z = z;
        }
    }
}
