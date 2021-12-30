using System;
using System.Collections.Generic;
using System.IO;
using Chip.Project;

namespace Chip.Process {
    public partial class Processor {
        /// <summary>
        /// 
        /// </summary>
        public void Process() {
            List<Layer> Layers = this.Context.Project.Layers;

            foreach (Layer Layer in Layers) {
                this.ProcessLayer(Layer);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="layer"></param>
        public void ProcessLayer(Layer layer) {
            String ext = Path.GetExtension(layer.Filepath);

            switch (ext) {
                case ".bmp":
                    this.BitmapProcessor.Process(layer);
                    break;

                default:
                    Console.WriteLine("unknown filetype: " + layer.Filepath);
                    break;
            }
        }
    }
}
