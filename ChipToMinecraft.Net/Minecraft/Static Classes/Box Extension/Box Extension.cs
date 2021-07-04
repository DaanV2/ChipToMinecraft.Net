using System;
using System.Runtime.CompilerServices;

namespace Chip.Minecraft {
    ///DOLATER <summary>add description for class: BoxExtension</summary>
    public static partial class BoxExtension {
        /// <summary>Gets the length of the area (x - axis)</summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="Box"></param>
        /// <returns></returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int32 GetLength(this Box Box) {
            return (Box.To.X - Box.From.X) + 1;
        }

        /// <summary>Gets the length of the area (x - axis)</summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="Box"></param>
        /// <returns></returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int32 GetWidth(this Box Box) {
            return (Box.To.Z - Box.From.Z) + 1;
        }

        /// <summary>Gets the length of the area (x - axis)</summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="Box"></param>
        /// <returns></returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int32 GetHeight(this Box Box) {
            return (Box.To.Y - Box.From.Y) + 1;
        }

        /// <summary> </summary>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="U"></typeparam>
        /// <param name="Box"></param>
        /// <returns></returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int32 GetVolume(this Box Box) {
            return GetWidth(Box) * GetHeight(Box) * GetLength(Box);
        }

        /// <summary>Gets the length of the area (x - axis)</summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="Box"></param>
        /// <returns></returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int32 GetLength(this ChunkBox Box) {
            return (Box.To.X - Box.From.X) + 1;
        }

        /// <summary>Gets the length of the area (x - axis)</summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="Box"></param>
        /// <returns></returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int32 GetWidth(this ChunkBox Box) {
            return (Box.To.Z - Box.From.Z) + 1;
        }

        /// <summary>Gets the length of the area (x - axis)</summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="Box"></param>
        /// <returns></returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int32 GetHeight(this ChunkBox Box) {
            return (Box.To.Y - Box.From.Y) + 1;
        }

        /// <summary> </summary>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="U"></typeparam>
        /// <param name="Box"></param>
        /// <returns></returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int32 GetVolume(this ChunkBox Box) {
            return GetWidth(Box) * GetHeight(Box) * GetLength(Box);
        }
    }
}
