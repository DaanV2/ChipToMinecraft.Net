using System;
using System.IO;
using LevelDB;

namespace Chip.Minecraft {
    public partial class BedrockWorld {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Folder"></param>
        /// <returns></returns>
        public static readonly Options DefaultOptions = new() {
            CompressionLevel = CompressionLevel.ZlibRawCompression
        };

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Folder"></param>
        /// <returns></returns>
        public static BedrockWorld Open(String Folder) {
            return Open(Folder, BedrockWorld.DefaultOptions);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Folder"></param>
        /// <param name="O"></param>
        /// <returns>Return a new bedrock world object or null if that failed</returns>        
        public static BedrockWorld Open(String Folder, Options O) {
            if (!Folder.EndsWith("db")) {
                Folder = Path.Join(Folder, "db");
            }

            var BW = new BedrockWorld {
                Folder = Folder,
                Db = new DB(Folder, O)
            };

            return BW;
        }
    }
}
