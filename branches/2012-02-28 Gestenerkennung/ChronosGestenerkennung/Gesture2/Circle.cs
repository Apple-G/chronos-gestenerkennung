using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChronosGestenerkennung.Gesture2
{
    class Circle : Gesture
    {
        public Circle()
        {
            base.init(-100, 100, 0, 0, -100, 100, GestureType.Circle);
        }

        public override bool accept(int minValue, int maxValue, Axis axis)
        {
            bool accept = false;

            switch (axis)
            {
                case Axis.X:
                    accept = (base.calcDistance(minValue, maxValue) >= ((this.maxX - Gesture.error) * 2)) ? true : false;
                    break;
                case Axis.Y:
                    accept = (base.calcDistance(minValue, maxValue) > (100 - Gesture.error)) ? true : false;
                    break;
                default:
                    // Z-axis
                    accept = (base.calcDistance(minValue, maxValue) >= ((this.maxZ - Gesture.error) * 2)) ? true : false;
                    break;
            }

            return accept;
        }
    }
}
