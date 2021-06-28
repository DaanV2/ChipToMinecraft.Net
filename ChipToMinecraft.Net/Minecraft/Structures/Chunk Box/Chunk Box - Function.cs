using System;

namespace Chip.Minecraft {
    public readonly partial struct ChunkBox {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="A"></param>
        /// <param name="B"></param>
        /// <returns></returns>
        public static ChunkBox Create(ChunkLocation A, ChunkLocation B) {
            Int32 xFrom, yFrom, zFrom;
            Int32 xTo, yTo, zTo;


            //X
            if (A.X < B.X) {
                xFrom = A.X;
                xTo = B.X;
            }
            else {
                xFrom = B.X;
                xTo = A.X;
            }

            //Y
            if (A.Y < B.Y) {
                yFrom = A.Y;
                yTo = B.Y;
            }
            else {
                yFrom = B.Y;
                yTo = A.Y;
            }

            //Z
            if (A.Z < B.Z) {
                zFrom = A.Z;
                zTo = B.Z;
            }
            else {
                zFrom = B.Z;
                zTo = A.Z;
            }

            return new ChunkBox(xFrom, yFrom, zFrom, xTo, yTo, zTo);
        }
    }
}
