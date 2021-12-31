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
            if (Out.HasValue) EnsureFilledWorld(World, Out.Value);

            World.Close();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="World"></param>
        /// <param name="AreaUsed"></param>
        public static void EnsureFilledWorld(IWorld World, Box AreaUsed) {
            Console.WriteLine("Ensuring world is correctly filled");

            if (AreaUsed.From.Y == 0) return;
            AreaUsed = new Box(AreaUsed.From.X, 0, AreaUsed.From.Z, AreaUsed.To.X, AreaUsed.From.Y - 1, AreaUsed.From.Z);

            World.ForEach((sc) => ChunkUpdate.Updated, AreaUsed);
        }
    }
}
