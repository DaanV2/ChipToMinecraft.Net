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

            IWorld World = WorldFactory.Open(project.Output, project.Options.MultiThread, project.Options.Concurrency);
            var context = new Process.Context(World, project);
            var processor = new Process.Processor(context);
            processor.Process();

            World.Close();
        }
    }
}
