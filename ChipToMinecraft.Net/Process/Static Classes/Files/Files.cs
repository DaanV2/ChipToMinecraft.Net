using System;
using System.IO;

namespace Chip.Process {
    ///DOLATER <summary>add description for class: Files</summary>
    public static partial class Files {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="SourceFolder"></param>
        /// <param name="DestinationFolder"></param>
        public static void Copy(String SourceFolder, String DestinationFolder) {
            Console.WriteLine($"Copying '{SourceFolder}' to '{DestinationFolder}'");

            try {
                Directory.Delete(DestinationFolder, true);
            }
            catch (Exception ex) {
                Console.WriteLine($"Error: clearing '${DestinationFolder}' folder didn't work:\n" + ex.Message + '\n' + ex.StackTrace);
            }

            //Create output
            Directory.CreateDirectory(DestinationFolder);

            String[] Files = Directory.GetFiles(SourceFolder, "*.*", SearchOption.AllDirectories);

            foreach (String F in Files) {
                String FN = NewPath(F, SourceFolder, DestinationFolder);

                String Parent = Path.GetDirectoryName(FN);
                Directory.CreateDirectory(Parent);

                File.Copy(F, FN, true);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="File"></param>
        /// <param name="SourceFolder"></param>
        /// <param name="DestinationFolder"></param>
        public static String NewPath(String File, String SourceFolder, String DestinationFolder) {
            return DestinationFolder + File[SourceFolder.Length..];
        }
    }
}
