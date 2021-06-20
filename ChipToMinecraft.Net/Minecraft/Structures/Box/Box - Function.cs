namespace Chip.Minecraft {
    public partial struct Box {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="A"></param>
        /// <param name="B"></param>
        /// <returns></returns>
        public static Box Create(Location A, Location B) {
            var Area = new Box();

            //X
            if (A.X < B.X) {
                Area.From.X = A.X;
                Area.To.X = B.X;
            }
            else {
                Area.From.X = B.X;
                Area.To.X = A.X;
            }

            //Y
            if (A.Y < B.Y) {
                Area.From.Y = A.Y;
                Area.To.Y = B.Y;
            }
            else {
                Area.From.Y = B.Y;
                Area.To.Y = A.Y;
            }

            //Z
            if (A.Z < B.Z) {
                Area.From.Z = A.Z;
                Area.To.Z = B.Z;
            }
            else {
                Area.From.Z = B.Z;
                Area.To.Z = A.Z;
            }

            return Area;
        }
    }
}
