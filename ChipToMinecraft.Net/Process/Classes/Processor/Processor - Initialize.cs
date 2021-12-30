namespace Chip.Process {
    ///DOLATER <summary>add description for class: Processor</summary>
    public partial class Processor {
        /// <summary>Creates a new instance of <see cref="Processor"/></summary>
        /// <param name="context"></param>
        public Processor(Context context) {
            this.Context = context;
            this.BitmapProcessor = new BitmapProcessor(context);
        }
    }
}
