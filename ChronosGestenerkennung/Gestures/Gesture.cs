using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChronosGestenerkennung.Gestures
{
    class Gesture
    {
        private Point[] points;
        public GestureType Name { private set; get; }
        /**
         * For the precision
         * */
        private static int p = 0;
        public Gesture(int type)
        {
            points = new Point[4];
            this.init(type);
        }
       
        private void init(int type)
        {
            if (type == 0)
            {
                //Winken
                this.Name = GestureType.Wave;
                points[0] = new Point(p, -128, p);
                points[1] = new Point(p, p, 128);
                points[2] = new Point(p, 128, p);
                points[3] = new Point(p, p, p);
            }
            else if (type == 1)
            {
                //Kreisen
                this.Name = GestureType.Circle;
                points[0] = new Point(p, -128, p); // x, y, z
                points[1] = new Point(p, p, 128);
                points[2] = new Point(p, 128, p);
                points[3] = new Point(p, p, -128);
            }
            else if (type == 2)
            {
                //Stoßen
                this.Name = GestureType.Push;
                points[0] = new Point(128, p, p);
                points[1] = new Point(64, p, p);
                points[2] = new Point(-64, p, p);
                points[3] = new Point(-128, p, p);
            }
            else if (type == 3)
            {
                this.Name = GestureType.Up;
                points[0] = new Point(p, p, 128);
                points[1] = new Point(p, p, 64);
                points[2] = new Point(p, p, -64);
                points[3] = new Point(p, p, -128);
            }
            else
            {
                this.Name = GestureType.Right;
                points[0] = new Point(p, 128, p);
                points[1] = new Point(p, 64, p);
                points[2] = new Point(p, -64, p);
                points[3] = new Point(p, -128, p);
            }
        }
    }
}
