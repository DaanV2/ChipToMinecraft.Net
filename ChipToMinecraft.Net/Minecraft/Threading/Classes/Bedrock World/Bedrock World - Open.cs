using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using LevelDB;

namespace Chip.Minecraft.Threading {
    public partial class BedrockWorld {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Folder"></param>
        /// <param name="Concurrency"></param>
        /// <returns></returns>
        
        public static BedrockWorld Open( String Folder, Int32 Concurrency = -1) {
            return Open(Folder, Chip.Minecraft.BedrockWorld.DefaultOptions);
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="Folder"></param>
        /// <param name="O"></param>
        /// <param name="Concurrency"></param>
        /// <returns></returns>
        
        public static BedrockWorld Open( String Folder,  Options O, Int32 Concurrency = -1) {
#if DEBUG
            System.Diagnostics.Debug.WriteLine($"Opening world: {Folder}");
#endif

            return new BedrockWorld(Minecraft.BedrockWorld.Open(Folder, O), Concurrency);
        }
    }
}
