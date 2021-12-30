namespace Chip.Process {
    ///DOLATER <summary>add description for class: BitmapProcessor</summary>
    public partial class BitmapProcessor {
        /// <summary>Creates a new instance of <see cref="BitmapProcessor"/></summary>
        /// <param name="context"></param>
        public BitmapProcessor(Context context) {
            this.Context = context;

            this._Action = context.Project.Options.MultiThread ? this.ProcessMulti : this.ProcessDefault;
        }
    }
}
