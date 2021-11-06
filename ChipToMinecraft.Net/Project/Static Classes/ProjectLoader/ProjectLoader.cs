using System;
using System.IO;
using System.Threading.Tasks;

namespace Chip.Project {
    ///DOLATER <summary>add description for class: ProjectLoader</summary>
    public static partial class ProjectLoader {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Fillepath"></param>
        /// <returns></returns>
        /// <exception cref="FileNotFoundException" />
        public static Project Load(String Filepath) {
            var FI = new FileInfo(Filepath);

            if (!FI.Exists) {
                throw new FileNotFoundException("Cannot find project file: " + Filepath);
            }

            var Reader = new FileStream(Filepath, FileMode.Open, FileAccess.Read);
            ValueTask<Serialization.Project> TData = System.Text.Json.JsonSerializer.DeserializeAsync<Serialization.Project>(Reader);
            TData.AsTask().Wait();
            Reader.Close();

            Serialization.Project Data = TData.Result;
            String ParentDir = FI.Directory.FullName;

            var Out = new Project {
                Options = Data.Options ?? new Serialization.ProjectOptions(),
                Output = Resolve(ParentDir, Data.Output),
                World = Resolve(ParentDir, Data.World)
            };

            return Out;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Folder"></param>
        /// <param name="Filepath"></param>
        /// <returns></returns>
        private static String Resolve(String Folder, String Filepath) {
            if (Path.IsPathFullyQualified(Filepath)) return Filepath;

            return Path.Combine(Folder, Filepath);
        }
    }
}
