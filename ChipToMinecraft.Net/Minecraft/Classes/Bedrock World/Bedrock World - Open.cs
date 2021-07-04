using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using LevelDB;

namespace Chip.Minecraft {
    public partial class BedrockWorld {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Folder"></param>
        /// <returns></returns>
        [NotNull]
        public static readonly Options DefaultOptions = new() {
            CompressionLevel = CompressionLevel.ZlibRawCompression
        };

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Folder"></param>
        /// <returns></returns>
        [return: NotNull]
        public static BedrockWorld Open([DisallowNull] String Folder) {
            return Open(Folder, BedrockWorld.DefaultOptions);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Folder"></param>
        /// <param name="O"></param>
        /// <returns>Return a new bedrock world object or null if that failed</returns>
        [return: NotNull]
        public static BedrockWorld Open([DisallowNull] String Folder, [DisallowNull] Options O) {
            var BW = new BedrockWorld {
                Folder = Folder,
                Db = new DB(Folder + "db", O)
            };

            return BW;
        }
    }
}
