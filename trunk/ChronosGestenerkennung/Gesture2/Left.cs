using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChronosGestenerkennung.Gesture2
{
    class Left : Gesture
    {
        public Left()
        {
            base.init(-100, 0, 0, 0, 0, 0, GestureType.Left);
        }

        public override bool accept(int minValue, int maxValue, Axis axis)
        {
            bool accept = false;

            switch (axis)
            {
                case Axis.X:
                    accept = ((calcDistance(minValue, 0) >= (Math.Abs(this.minX) - Gesture.error)) && (maxValue < Gesture.error)) ? true : false;
                    break;
                case Axis.Y:
                    accept = (base.calcDistance(minValue, maxValue) > (100 - Gesture.error)) ? true : false;
                    break;
                default:
                    // Z-axis
                    accept = (base.calcDistance(minValue, maxValue) <= (2 * Gesture.error)) ? true : false;
                    break;
            }

            return accept;
        }
    }
}
