using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChronosGestenerkennung.Gestures
{
    class AlgoNew
    {
        GestureType analysedGesture;
        Point[] values;

        public AlgoNew()
        {
            analysedGesture = GestureType.None;

        }

        internal GestureType getGesture(Point[] values, int arraySize)
        {
            this.values = values;
            if (isPush())
            {
                analysedGesture = GestureType.Push;
            }
            return analysedGesture;
        }

        private bool isPush()
        {
            if (minMaxDifferenzX() < 50)
            {
                return true;
            }

            return false;
        }

        private int minMaxDifferenzX()
        {
            int max = getMaxX(this.values);
            int min = getMinX(this.values);
            return max - min;
        }

        private int getMinX(Point[] point)
        {
            int min = point[0].X;
            for (int i = 1; i < point.Length; i++)
            {
                min = System.Math.Min(point[i].X, min);
            }
            return min;
        }

        private int getMaxX(Point[] point)
        {
            int max = point[0].X;
            for (int i = 1; i < point.Length; i++)
            {
                max = System.Math.Max(point[i].X, max);
            }
            return max;
        }
    }
}
