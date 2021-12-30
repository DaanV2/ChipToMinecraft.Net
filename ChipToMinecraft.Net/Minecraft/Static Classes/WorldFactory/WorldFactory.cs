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
        public static IWorld Open(String Folder, Project.Serialization.ProjectOptions Options) {
            Console.WriteLine($"World: Opening '{Folder}' Multithread:{Options.MultiThread} Concurrenty:{Options.Concurrency} CacheChunks:{Options.CacheChunks}");

            IWorld world;

            if (Options.MultiThread && Options.CacheChunks == false) {
                world = Chip.Minecraft.Threading.BedrockWorld.Open(Folder, Options.Concurrency);
            }
            else {
                world = Chip.Minecraft.BedrockWorld.Open(Folder);
            }

            if (Options.CacheChunks) {
                world = new ChunkCache(world);
            }

            return world;
        }
    }
}
