using System;

namespace Chip.Minecraft {
    public readonly partial struct Box {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="A"></param>
        /// <param name="B"></param>
        /// <returns></returns>
        public static Box Create(Location A, Location B) {
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

            return new Box(xFrom, yFrom, zFrom, xTo, yTo, zTo);
        }
    }
}
