using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChronosGestenerkennung.Gestures
{
    class AlgoNew
    {
        private readonly int arraySize;
        private int MedianDiffValue { get { return 30; } }
        CalcValues valueX;
        CalcValues valueY;
        CalcValues valueZ;

        public AlgoNew()
        {
            arraySize = 40;
            valueX = new CalcValues(arraySize);
            valueY = new CalcValues(arraySize);
            valueZ = new CalcValues(arraySize);
        }

        public void UpdateValues(int x, int y, int z)
        {
            valueX.Values = x;
            valueY.Values = y;
            valueZ.Values = z;
        }

        public void ResetValues()
        {
            valueX.Reset();
            valueY.Reset();
            valueZ.Reset();
        }

        public GestureType getGesture()
        {
            if (isPush())
            {
                Console.WriteLine("Push!!");
                return GestureType.Push;
            }

            if (isUp())
            {
                Console.WriteLine("UP!!!");
                return GestureType.Up;
            }

            if (isDown())
            {
                Console.WriteLine("Down!!!");
                return GestureType.Down;
            }
            if (isLeft())
            {
                Console.WriteLine("Left!!!");
                return GestureType.Left;
            }
            if (isRight())
            {
                Console.WriteLine("Right!!!");
                return GestureType.Right;
            }

            return GestureType.None;
        }

        private bool isUp()
        {
            if (valueX.CalculateDifference() < 90 && valueY.CalculateDifference() < 90 && valueZ.CalculateDifference() > 100)
            {
                //Min und Max jeweils weit genug von Median entfernt?
                Console.WriteLine(("Median: " + valueZ.CalculateMedian() + " Min: " + valueZ.CalculateMin() + " Max: " + valueZ.CalculateMax() + "median-min: " + (valueZ.CalculateMedian() - valueZ.CalculateMin()))+ "UP: "+ valueZ.IsDirectionUp());
                if ((valueZ.CalculateMedian() - valueZ.CalculateMin()) > MedianDiffValue && valueZ.CalculateMax() - valueZ.CalculateMedian() > MedianDiffValue)
                {
                    return !valueZ.IsDirectionUp(); //erst Max, dann Min
                }
            }

            return false;
        }
        private bool isDown()
        {
            if (valueX.CalculateDifference() < 90 && valueY.CalculateDifference() < 90 && valueZ.CalculateDifference() > 140)
            {
                //Min und Max jeweils weit genug von Median entfernt?
                if (valueZ.CalculateMedian() - valueZ.CalculateMin() > MedianDiffValue && valueZ.CalculateMax() - valueZ.CalculateMedian() > MedianDiffValue)
                {
                    return valueZ.IsDirectionUp(); //erst Max, dann Min
                }
            }

            return false;
        }

        private bool isPush()
        {
            if (valueX.CalculateDifference() < 120 && valueY.CalculateDifference() > 120 && valueZ.CalculateDifference() < 120)
            {
                return valueY.IsDirectionUp();
            }
            return false;
        }
        private bool isLeft()
        {
            if (valueX.CalculateDifference() > 120 && valueY.CalculateDifference() < 90 && valueZ.CalculateDifference() < 90)
            {
                if ((valueX.CalculateMedian() - valueX.CalculateMin()) > MedianDiffValue && valueX.CalculateMax() - valueX.CalculateMedian() > MedianDiffValue)
                {

                    return !valueX.IsDirectionUp();
                }
            }
            return false;
        }

        private bool isRight()
        {
            if (valueX.CalculateDifference() > 120 && valueY.CalculateDifference() < 90 && valueZ.CalculateDifference() < 90)
            {
                if ((valueX.CalculateMedian() - valueX.CalculateMin()) > MedianDiffValue && valueX.CalculateMax() - valueX.CalculateMedian() > MedianDiffValue)
                {

                    return valueX.IsDirectionUp();
                }
            }
            return false;
        }
        

    }
}
