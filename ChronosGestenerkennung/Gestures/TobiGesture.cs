using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChronosGestenerkennung.Gestures
{
    class TobiGesture
    {

        public GestureType Name { set; get; }
        public Point Difference {  set; get; }
        public bool[] DirectionUp {  set; get; }

        public TobiGesture(GestureType name, Point dif, bool[] dir)
        {
            Name = name;
            Difference = dif;
            DirectionUp = dir;
        }


    }
}
