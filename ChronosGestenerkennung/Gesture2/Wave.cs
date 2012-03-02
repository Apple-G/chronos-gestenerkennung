using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChronosGestenerkennung.Gesture2
{
    class Wave : Gesture
    {
        public Wave()
        {
            base.init(-100, 100, 0, 0, 0, 100, GestureType.Wave);
        }

        public override bool accept(int minValue, int maxValue, Axis axis)
        {
            bool accept = false;

            switch (axis)
            {
                case Axis.X:
                    accept = (base.calcDistance(minValue, maxValue) >= (this.maxX - Gesture.error)) ? true : false;
                    break;
                case Axis.Y:
                    accept = (base.calcDistance(minValue, maxValue) < Gesture.error) ? true : false;
                    break;
                default:
                    // Z-axis
                    accept = (base.calcDistance(minValue, maxValue) >= (this.maxZ - Gesture.error)) ? true : false;
                    break;
            }

            return accept;
        }
    }
}
