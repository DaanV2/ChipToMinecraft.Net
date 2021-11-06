using Chip.Minecraft;

namespace Chip {
    ///DOLATER <summary>add description for class: ChipBuilder</summary>
    public partial class ChipBuilder<T>
        where T : IWorld {

        /// <summary>Creates a new instance of <see cref="ChipBuilder"/></summary>
        internal ChipBuilder(T World, BuilderOptions O) {
            this.Options = O;
            this.World = World;
        }
    }
}
