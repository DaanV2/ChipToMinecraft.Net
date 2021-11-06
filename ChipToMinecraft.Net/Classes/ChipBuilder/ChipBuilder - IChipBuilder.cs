using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chip.Minecraft;

namespace Chip {
    public partial class ChipBuilder<T> : IChipBuilder {
        /// <inheritdoc/>
        public BuilderOptions Options { get; private set; }

        /// <inheritdoc/>
        public Boolean Process(String SpecificationFile) {
            return ChipBuilding.Process(SpecificationFile, this);
        }
    }
}
