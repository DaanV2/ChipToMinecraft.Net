using System;
using Chip.Minecraft;
using Chip.Process;

namespace Chip.Project {
    public static partial class ProjectProcessor {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="project"></param>
        public static void Process(this Project project) {
            Console.WriteLine("Processing");

            Files.Copy(project.World, project.Output);

            IWorld World = WorldFactory.Open(project.Output, project.Options);
            var context = new Process.Context(World, project);
            var processor = new Process.Processor(context);

            //Processing
            Box? Out = processor.Process();

            //Fill possibly any empty
            if (Out.HasValue) {
                Box area = Out.Value;
                Console.WriteLine("Ensuring world");

                if (area.From.Y != 0) {
                    area = new Box(area.From.X, 0, area.From.Z, area.To.X, area.From.Y - 1, area.From.Z);

                    World.ForEach((sc) => ChunkUpdate.Updated, area);
                }
            }

            World.Close();
        }
    }
}
