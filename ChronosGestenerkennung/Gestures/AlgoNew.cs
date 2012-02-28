using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChronosGestenerkennung.Gestures
{
    class AlgoNew
    {
        private readonly int arraySize;
        private int MedianDiffValue { get { return 10; } }
        CalcValues valueX;
        CalcValues valueY;
        CalcValues valueZ;

        public AlgoNew()
        {
            arraySize = 30;
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
                ResetValues();
                return GestureType.Push;
            }

            if (isUp())
            {
                Console.WriteLine("UP!!!");
                ResetValues();
                return GestureType.Up;
            }

            if (isDown())
            {
                Console.WriteLine("Down!!!");
                ResetValues();
                return GestureType.Down;
            }
            if (isLeft())
            {
                Console.WriteLine("Left!!!");
                ResetValues();
                return GestureType.Left;
            }
            if (isRight())
            {
                Console.WriteLine("Right!!!");
                ResetValues();
                return GestureType.Right;
            }

            return GestureType.None;
        }

        private bool isUp()
        {
            if (valueX.CalculateDifference() < 70 && valueY.CalculateDifference() < 70 && valueZ.CalculateDifference() > 120)
            {
                //Min und Max jeweils weit genug von Median entfernt?
                Console.WriteLine(("Median: " + valueZ.CalculateMedian() + " Min: " + valueZ.CalculateMin() + " Max: " + valueZ.CalculateMax() + "median-min: " + (valueZ.CalculateMedian() - valueZ.CalculateMin())));
                if ((valueZ.CalculateMedian() - valueZ.CalculateMin()) > MedianDiffValue && valueZ.CalculateMax() - valueZ.CalculateMedian() > MedianDiffValue)
                {

                    return !valueZ.IsDirectionUp(); //erst Max, dann Min
                }
            }

            return false;
        }
        private bool isDown()
        {
            if (valueX.CalculateDifference() < 70 && valueY.CalculateDifference() < 70 && valueZ.CalculateDifference() > 120)
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
            if (valueX.CalculateDifference() < 70 && valueY.CalculateDifference() > 120 && valueZ.CalculateDifference() < 70)
            {
                return valueY.IsDirectionUp();
            }
            return false;
        }
        private bool isLeft()
        {
            if (valueX.CalculateDifference() > 120 && valueY.CalculateDifference() < 70 && valueZ.CalculateDifference() < 70)
            {
                return !valueX.IsDirectionUp();
            }
            return false;
        }

        private bool isRight()
        {
            if (valueX.CalculateDifference() > 120 && valueY.CalculateDifference() < 70 && valueZ.CalculateDifference() < 70)
            {
                return valueX.IsDirectionUp();
            }
            return false;
        }
        

    }
}
