using System.Runtime.CompilerServices;

namespace Chip.Minecraft {
    ///DOLATER <summary>add description for class: WorldExtension</summary>
    public static partial class WorldExtension {
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="World"></param>
        /// <param name="WordLocation"></param>
        /// <returns></returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SubChunk GetSubChunk<T>(this T World, Location WordLocation)
            where T : IWorld {
            return World.GetSubChunk((ChunkLocation)WordLocation);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="World"></param>
        /// <param name="WordLocation"></param>
        /// <returns></returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SubChunk GetSubChunk<T>(this T World, ChunkSpecificLocation WordLocation)
            where T : IWorld {
            //Keep the casting
            #pragma warning disable IDE0004
            return World.GetSubChunk((ChunkLocation)WordLocation);
            #pragma warning restore IDE0004
        }
    }
}
