namespace ChronosGestenerkennung.Gesture2
{
    public class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }

        //Constructor for this class
        public Point(int nX, int nY, int nZ)
        {
            this.X = nX;
            this.Y = nY;
            this.Z = nZ;
        }
    }
}
