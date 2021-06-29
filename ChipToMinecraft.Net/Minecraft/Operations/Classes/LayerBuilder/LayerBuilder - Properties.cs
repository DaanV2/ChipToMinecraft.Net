using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chip.Minecraft.Operations {
    public partial class LayerBuilder<T>
        where T : IWorld {
        /// <summary>
        /// 
        /// </summary>
        public T World { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        public Range Layer { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Location2D Offset { get; set; }
    }
}
