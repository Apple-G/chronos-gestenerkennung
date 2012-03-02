using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChronosGestenerkennung.Gesture2
{
    class Algo
    {
        private Gesture[] gesture;
        private int arraySize;

        public Algo(Gesture[] nGesture, int pArraySize)
        {
            arraySize = pArraySize;
            this.gesture = nGesture;
        }

        public Gesture Gesture
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public Gesture Gesture1
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        /**
         * This method return teh detected gesture
         * When 80% of the given points corresponds to a gesture
         * the detected gesture is returned
         * **/
        public GestureType getGesture(Point[] points)
        {
            int maxX = 0;
            int minX = 0;
            int maxY = 0;
            int minY = 0;
            int maxZ = 0;
            int minZ = 0;

            /**
             * First build max and min points
             * */
            for (int k = 0; k < arraySize; k++)
            {
                if (points[k].X > maxX)
                    maxX = points[k].X;
                if (points[k].X <= minX)
                    minX = points[k].X;
                if (points[k].Y > maxY)
                    maxY = points[k].Y;
                if (points[k].Y <= minY)
                    minY = points[k].Y;
                if (points[k].Z > maxZ)
                    maxZ = points[k].Z;
                if (points[k].Z <= minZ)
                    minZ = points[k].Z;
            }
            Console.WriteLine("minX: " + minX + " maxX: " + maxX + " minY: " + minY + " maxY: " + maxY + " minZ: " + minZ + " maxZ: " + maxZ);
            /**
             * Go throw the muster array and looking for a muster that pass to the given points
             * */
            for (int i = 0; i < 7; i++)
            {
                /**
                 * Apply each gesture to an musster
                 * The first muster found ist the selected one
                 * */
                if (this.gesture[i].accept(minX, maxX, Axis.X))
                {
                    if (this.gesture[i].accept(minY, maxY, Axis.Y))
                    {
                        if (this.gesture[i].accept(minZ, maxZ, Axis.Z))
                            return this.gesture[i].Name;
                    }
                }
            }
            return GestureType.None;
        }
    }
}
