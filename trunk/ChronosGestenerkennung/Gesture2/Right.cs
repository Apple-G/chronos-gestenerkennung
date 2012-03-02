using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChronosGestenerkennung.Gesture2
{
    class Right : Gesture
    {
        public Right()
        {
            base.init(0, 100, 0, 0, 0, 0, GestureType.Right);
        }

        public override bool accept(int minValue, int maxValue, Axis axis)
        {
            bool accept = false;

            switch (axis)
            {
                case Axis.X:
                    accept = ((calcDistance(0, maxValue) >= (this.maxX - Gesture.error)) && (minValue > (-Gesture.error))) ? true : false;
                    break;
                case Axis.Y:
                    accept = (base.calcDistance(minValue, maxValue) > (this.maxX - Gesture.error)) ? true : false;
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
