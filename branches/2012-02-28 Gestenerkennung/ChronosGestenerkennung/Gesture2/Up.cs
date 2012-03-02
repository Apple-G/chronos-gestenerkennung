using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChronosGestenerkennung.Gesture2
{
    class Up : Gesture
    {
        public Up()
        {
            base.init(0, 0, 0, 0, 0, 100, GestureType.Up);
        }

        public override bool accept(int minValue, int maxValue, Axis axis)
        {
            bool accept = false;

            switch (axis)
            {
                case Axis.X:
                    accept = (base.calcDistance(minValue, maxValue) <= (2 * Gesture.error)) ? true : false;
                    break;
                case Axis.Y:
                    accept = (base.calcDistance(minValue, maxValue) <= ((100 - Gesture.error) * 2)) ? true : false;
                    break;
                default:
                    // Z-axis
                    accept = (base.calcDistance(0, maxValue) >= (this.maxZ - Gesture.error)) ? true : false;
                    break;
            }

            return accept;
        }
    }
}
