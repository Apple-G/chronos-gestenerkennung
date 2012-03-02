using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChronosGestenerkennung.Gesture2
{
    public abstract class Gesture
    {
        //Points needed for each gesture
        public int maxZ;
        public int minZ;
        public int maxY;
        public int minY;
        public int maxX;
        public int minX;
        public const int error = 40; //40

        /**
         * Accept value on x-axis
         * */
        public abstract bool accept(int minValue, int maxValue, Axis axis);

        /**
         * TO init this gesture
         * */
        public void init(int minX, int maxX, int minY, int maxY, int minZ, int maxZ, GestureType type)
        {
            this.minX = minX;
            this.maxX = maxX;
            this.minY = minY;
            this.maxY = maxY;
            this.minZ = minZ;
            this.maxZ = maxZ;
            Name = type;
        }

        //Name of this Gesture
        public GestureType Name { private set; get; }

        /**
         * Use to calculate distance between to points
         * */
        public int calcDistance(int from, int to)
        {
            int distValue = 0;
            for (int i = from; i < to; i++)
            {
                distValue++;
            }
            return distValue;
        }
    }
}
