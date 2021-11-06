namespace Chip.Project.Serialization {
    ///DOLATER <summary>add description for class: Layer</summary>
    public partial class Layer {

        /// <summary>Creates a new instance of <see cref="Layer"/></summary>
        public Layer() {
            this.Block = Minecraft.BlockFactory.Blocks.Air;
            this.Filepath = null;
            this.Scale = 1f;
            this.Thickness = 1;
        }
    }
}
