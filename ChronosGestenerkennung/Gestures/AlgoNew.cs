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
        Point diff;
        Point minIndex;
        Point maxIndex;
        public AlgoNew()
        {
            analysedGesture = GestureType.None;

        }

        internal GestureType getGesture(Point[] values, int arraySize)
        {
            this.values = values;
            analysedGesture = GestureType.None;
            diff = minMaxDifferenz();
            minIndex = getMinIndex();
            maxIndex = getMaxIndex();

            if (isPush())
            {
                analysedGesture = GestureType.Push;
                Console.WriteLine("Push!!");
            }
            if (isUp())
            {
                analysedGesture = GestureType.Up;
                Console.WriteLine("UP!!!");
            }
            return analysedGesture;
        }

        private bool isUp()
        {
            // Console.WriteLine("x: " + diff.X + " y: " + diff.Y + " Z: " + diff.Z + " \t x: " + values[values.Length - 1].X + " y: " + values[values.Length - 1].Y + " Z: " + values[values.Length - 1].Z + " \t minIndexX: " + minIndex.X + " maxIndexX: " + maxIndex.X);
            if (diff.X < 100 && diff.Y < 100 && diff.Z > 140)
            {
                if (minIndex.X > maxIndex.X + 1) //erst Max, dann Min
                {
                    return true;
                }
            }

            return false;
        }
        private bool isPush()
        {

            // Console.WriteLine("x: " + diff.X + " y: " + diff.Y + " Z: " + diff.Z + " \t x: " + values[values.Length - 1].X + " y: " + values[values.Length - 1].Y + " Z: " + values[values.Length - 1].Z + " \t minIndexX: " + minIndex.X + " maxIndexX: " + maxIndex.X);

            if (minIndex.X < maxIndex.X)
            {
                //         Console.WriteLine("minIndex<MaxIndex");
            }
            if (diff.X < 70 && diff.Y > 140 && diff.Z < 70)
            {
                Console.WriteLine("x>50 && y>100 && z<50");
                if (minIndex.X + 1 < maxIndex.X) //erst minimum, dann Maximum
                {
                    Console.WriteLine("minIndexX: " + minIndex.X + " maxIndexX: " + maxIndex.X);
                    return true;
                }
            }

            return false;
        }


        private Point minMaxDifferenz()
        {
            int maxX = getMax(this.values).X;
            int minX = getMin(this.values).X;
            int maxY = getMax(this.values).Y;
            int minY = getMin(this.values).Y;
            int maxZ = getMax(this.values).Z;
            int minZ = getMin(this.values).Z;
            return new Point(maxX - minX, maxY - minY, maxZ - minZ);
        }
        private Point getMinIndex()
        {
            int x = -1, y = -1, z = -1;//hässlich
            Point min = getMin(this.values);
            for (int i = 0; i < this.values.Length; i++)
            {
                if (min.X == values[i].X)
                {
                    x = i;
                }
                if (min.Y == values[i].Y)
                {
                    x = i;
                }
                if (min.Z == values[i].Z)
                {
                    x = i;
                }
            }
            return new Point(x, y, z);
        }
        private Point getMaxIndex()
        {
            int x = -1, y = -1, z = -1;//hässlich
            Point max = getMax(this.values);
            for (int i = 0; i < this.values.Length; i++)
            {
                if (max.X == values[i].X)
                {
                    x = i;
                }
                if (max.Y == values[i].Y)
                {
                    x = i;
                }
                if (max.Z == values[i].Z)
                {
                    x = i;
                }
            }
            return new Point(x, y, z);
        }
        private Point getMin(Point[] point)
        {
            int minX = point[0].X;
            int minY = point[0].Y;
            int minZ = point[0].Z;
            for (int i = 1; i < point.Length; i++)
            {
                minX = System.Math.Min(point[i].X, minX);
                minY = System.Math.Min(point[i].Y, minY);
                minZ = System.Math.Min(point[i].Z, minZ);
            }
            return new Point(minX, minY, minZ);
        }

        private Point getMax(Point[] point)
        {
            int maxX = point[0].X;
            int maxY = point[0].Y;
            int maxZ = point[0].Z;
            for (int i = 1; i < point.Length; i++)
            {
                maxX = System.Math.Max(point[i].X, maxX);
                maxY = System.Math.Max(point[i].Y, maxY);
                maxZ = System.Math.Max(point[i].Z, maxZ);
            }
            return new Point(maxX, maxY, maxZ);
        }
    }
}
