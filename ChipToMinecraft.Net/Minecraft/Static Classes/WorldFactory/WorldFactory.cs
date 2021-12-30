using System;

namespace Chip.Minecraft {
    ///DOLATER <summary>add description for class: WorldFactory</summary>
    public static partial class WorldFactory {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Folder"></param>
        /// <param name="MultiThread"></param>
        /// <returns></returns>
        public static IWorld Open(String Folder, Boolean MultiThread = false, Int32 Concurrency = -1) {
            Console.WriteLine($"World: Opening '{Folder}' Multithread:{MultiThread} Concurrenty:{Concurrency}");

            if (MultiThread) {
                return Chip.Minecraft.Threading.BedrockWorld.Open(Folder, Concurrency);
            }

            return Chip.Minecraft.BedrockWorld.Open(Folder);
        }
    }
}
