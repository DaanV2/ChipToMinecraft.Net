using System;
using System.Collections.Concurrent;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Chip.Minecraft;
using Chip.Minecraft.Operations;
using Chip.Project;
using DaanV2.NBT;

namespace Chip.Process {
    public partial class BitmapProcessor {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="layer"></param>
        public Box Process(Layer layer) {
            Console.WriteLine($"Bitmap: placing:{layer.Block} over {layer.Filepath}");
            Console.WriteLine($"\tscale:{layer.Scale} start:{layer.StartLocation} Thickness:{layer.Thickness}");
            return this._Action(layer);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="layer"></param>
        [MethodImpl(MethodImplOptions.AggressiveOptimization)]
        private Box ProcessDefault(Layer layer) {
            var Map = (Bitmap)Bitmap.FromFile(layer.Filepath);
            var Builder = new LayerBuilder(this.Context.World, layer.Thickness, layer.Scale, layer.StartLocation);
            NBTTagCompound Block = layer.Block;

            for (Int32 X = 0; X < Map.Width; X++)
                ProcessY(X, Map, Builder, Block);

            return GetBoxUsed(layer.StartLocation, Map.Width, layer.Thickness, Map.Height, layer.Scale);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="layer"></param>
        [MethodImpl(MethodImplOptions.AggressiveOptimization)]
        private Box ProcessMulti(Layer layer) {
            var Map = (Bitmap)Bitmap.FromFile(layer.Filepath);
            var Builder = new LayerBuilder(this.Context.World, layer.Thickness, layer.Scale, layer.StartLocation);
            NBTTagCompound Block = layer.Block;

            OrderablePartitioner<Tuple<Int32, Int32>> part = Partitioner.Create(0, Map.Width);
            Parallel.ForEach(part, (range, state, some) => {
                //Loop over the given X values
                for (Int32 X = range.Item1; X < range.Item2; X++)
                    ProcessY(X, Map, Builder, Block);
            });

            return GetBoxUsed(layer.StartLocation, Map.Width, layer.Thickness, Map.Height, layer.Scale);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static void ProcessY(Int32 X, Bitmap map, LayerBuilder builder, NBTTagCompound block) {
            Int32 Y = map.FindYStart(X);

            while (Y >= 0) {
                Int32 yEnd = map.FindYEnd(X, Y);

                var Area = new Square(X, Y, X + 1, yEnd + 1);
                builder.Fill(Area, block);

                Y = map.FindYStart(X, yEnd);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Box GetBoxUsed(Location Start, Int32 Width, Int32 Thickness, Int32 Height, Single Scale) {
            return new Box(Start, Start.Offset(Width, Thickness, Height)) * Scale;
        }
    }
}
