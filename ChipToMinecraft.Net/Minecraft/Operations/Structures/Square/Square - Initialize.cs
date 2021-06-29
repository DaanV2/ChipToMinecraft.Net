using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Chip.Minecraft.Operations {
    ///DOLATER <summary>add description for struct: Square</summary>
    public readonly partial struct Square {
        /// <summary>Creates a new instance of <see cref="Square"/></summary>
        /// <param name="from"></param>
        /// <param name="to"></param>
        public Square(Location2D from, Location2D to) {
            this.From = from;
            this.To = to;
        }

        /// <summary>Creates a new instance of <see cref="Square"/></summary>
        /// <param name="from"></param>
        /// <param name="to"></param>
        public Square(Int32 FromX, Int32 FromZ, Int32 ToX, Int32 ToZ) {
            this.From = new Location2D(FromX, FromZ);
            this.To = new Location2D(ToX, ToZ);
        }
    }
}
