using System;
using System.Collections.Generic;
using System.IO;
using Chip.Minecraft;
using Chip.Project;

namespace Chip.Process {
    public partial class Processor {
        /// <summary>
        /// 
        /// </summary>
        public Box? Process() {
            List<Layer> Layers = this.Context.Project.Layers;

            if (Layers.Count == 0) return null;

            Location Point = Layers[0].StartLocation * Layers[0].Scale;
            Box result = new Box(Point, Point);

            foreach (Layer Layer in Layers) {
                Box? box = this.ProcessLayer(Layer);

                if (box.HasValue) {
                    result = result.Combine(box.Value);
                }
            }

            return result;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="layer"></param>
        public Box? ProcessLayer(Layer layer) {
            String ext = Path.GetExtension(layer.Filepath);

            switch (ext) {
                case ".bmp":
                    return this.BitmapProcessor.Process(layer);

                default:
                    Console.WriteLine("unknown filetype: " + layer.Filepath);
                    break;
            }

            return null;
        }
    }
}
