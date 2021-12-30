using System;
using System.IO;
using Chip.Project;

namespace Chip {
    internal class Program {
        private static void Main(String[] args) {
            args = new String[] {
                @"F:\Projects\Minecraft\I4004-CPU\project.json"
            };

            var Options = new ProgramOptions();
            Options.Read(args);

            //Load
            Project.Project Data = Chip.Project.ProjectLoader.Load(Options.Filepath);

            //
            Data.Process();

            Console.WriteLine("Done");
        }
    }

    /// <summary>
    /// 
    /// </summary>
    public class ProgramOptions {
        /// <summary>
        /// 
        /// </summary>
        public String Filepath { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Args"></param>
        public void Read(String[] Args) {
            foreach (String Arg in Args) {
                if (Arg.EndsWith(".json")) {
                    this.Filepath = Arg;

                    if (!Path.IsPathFullyQualified(this.Filepath)) {
                        this.Filepath = Path.Combine(Environment.CurrentDirectory, this.Filepath);
                    }
                }
            }
        }
    }
}
