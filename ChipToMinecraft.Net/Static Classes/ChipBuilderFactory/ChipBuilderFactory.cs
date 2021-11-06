using LevelDB;

namespace Chip {
    ///DOLATER <summary>add description for class: ChipBuilderFactory</summary>
    public static partial class ChipBuilderFactory {
        public static IChipBuilder Create(BuilderOptions options) {
            if (options.Multithread) {
                return CreateMultiThreaded(options);
            }

            return CreateSingleThread(options);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Folder"></param>
        /// <returns></returns>
        public static ChipBuilder<Chip.Minecraft.Threading.BedrockWorld> CreateMultiThreaded(BuilderOptions options) {
            var world = Chip.Minecraft.Threading.BedrockWorld.Open(options.WorldFolder, options.Concurrency);

            return new ChipBuilder<Minecraft.Threading.BedrockWorld>(world, options);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Folder"></param>
        /// <returns></returns>
        public static ChipBuilder<Chip.Minecraft.BedrockWorld> CreateSingleThread(BuilderOptions options) {
            var world = Chip.Minecraft.BedrockWorld.Open(options.WorldFolder);

            return new ChipBuilder<Chip.Minecraft.BedrockWorld>(world, options);
        }
    }
}
