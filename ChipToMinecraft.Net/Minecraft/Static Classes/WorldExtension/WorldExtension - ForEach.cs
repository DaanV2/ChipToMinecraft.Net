using System;
using System.Runtime.CompilerServices;

namespace Chip.Minecraft {
    /// <summary>
    /// 
    /// </summary>
    public static partial class WorldExtension {
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="World"></param>
        /// <param name="call"></param>
        /// <param name="Area"></param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void ForEach<T>(this T World, Func<SubChunk, ChunkUpdate> call, Box Area)
            where T : IWorld {

            var From = (ChunkLocation)Area.From;
            var To = (ChunkLocation)Area.To;

            for (Int32 X = From.X; X <= To.X; X++) {
                for (Int32 Y = From.Y; Y <= To.Y; Y++) {
                    for (Int32 Z = From.Z; Z <= To.Z; Z++) {
                        SubChunk SubChunk = World.GetSubChunk(new ChunkLocation(X, Y, Z));
                        ChunkUpdate Update = call(SubChunk);

                        if (Update == ChunkUpdate.Updated) { World.SetSubChunk(SubChunk); }
                    }
                }
            }

        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam+>
        /// <param name="World"></param>
        /// <param name="call"></param>
        /// <param name="Area"></param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void ForEach<T, T1>(this T World, Func<SubChunk, T1, ChunkUpdate> call, Box Area, T1 Parameter)
            where T : IWorld {

            var From = (ChunkLocation)Area.From;
            var To = (ChunkLocation)Area.To;

            for (Int32 X = From.X; X <= To.X; X++) {
                for (Int32 Y = From.Y; Y <= To.Y; Y++) {
                    for (Int32 Z = From.Z; Z <= To.Z; Z++) {
                        SubChunk SubChunk = World.GetSubChunk(new ChunkLocation(X, Y, Z));
                        ChunkUpdate Update = call(SubChunk, Parameter);

                        if (Update == ChunkUpdate.Updated) { World.SetSubChunk(SubChunk); }
                    }
                }
            }

        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="World"></param>
        /// <param name="call"></param>
        /// <param name="Area"></param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void ForEach<T>(this T World, Func<SubChunk, Box, ChunkUpdate> call, Box Area)
            where T : IWorld {

            var From = (ChunkLocation)Area.From;
            var To = (ChunkLocation)Area.To;

            for (Int32 X = From.X; X <= To.X; X++) {
                for (Int32 Y = From.Y; Y <= To.Y; Y++) {
                    for (Int32 Z = From.Z; Z <= To.Z; Z++) {
                        SubChunk SubChunk = World.GetSubChunk(new ChunkLocation(X, Y, Z));
                        ChunkUpdate Update = call(SubChunk, Area);

                        if (Update == ChunkUpdate.Updated) { World.SetSubChunk(SubChunk); }
                    }
                }
            }

        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam+>
        /// <param name="World"></param>
        /// <param name="call"></param>
        /// <param name="Area"></param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void ForEach<T, T1>(this T World, Func<SubChunk, Box, T1, ChunkUpdate> call, Box Area, T1 Parameter)
            where T : IWorld {

            var From = (ChunkLocation)Area.From;
            var To = (ChunkLocation)Area.To;

            for (Int32 X = From.X; X <= To.X; X++) {
                for (Int32 Y = From.Y; Y <= To.Y; Y++) {
                    for (Int32 Z = From.Z; Z <= To.Z; Z++) {
                        SubChunk SubChunk = World.GetSubChunk(new ChunkLocation(X, Y, Z));
                        ChunkUpdate Update = call(SubChunk, Area, Parameter);

                        if (Update == ChunkUpdate.Updated) { World.SetSubChunk(SubChunk); }
                    }
                }
            }

        }
    }
}
