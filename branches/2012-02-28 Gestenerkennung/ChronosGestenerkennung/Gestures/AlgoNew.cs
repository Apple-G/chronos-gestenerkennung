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
        private CalcValues valueX;
        private CalcValues valueY;
        private CalcValues valueZ;

        private GestureType oldGesture;
        private int countGesture;

        public AlgoNew()
        {
            arraySize = 40;
            valueX = new CalcValues(arraySize);
            valueY = new CalcValues(arraySize);
            valueZ = new CalcValues(arraySize);
            oldGesture = GestureType.None;
        }

        public void UpdateValues(int x, int y, int z)
        {
            valueX.Values = x;
            valueY.Values = y;
            valueZ.Values = z;
        }

        public void ResetValues(int x, int y, int z)
        {
            valueX.Reset(x);
            valueY.Reset(y);
            valueZ.Reset(z);
        }
        public GestureType AnalyticGesture()
        {
            GestureType tempGesture = oldGesture;
            oldGesture = GetGesture();

            if (tempGesture == oldGesture)
        {
                countGesture++;
                if (countGesture > 5)
                {
                    countGesture = 0;
                    ResetValues(valueX.CalculateMedian(), valueY.CalculateMedian(), valueZ.CalculateMedian());
                    return tempGesture;
                }
            }
            else
            {
                countGesture = 0;
            }
            return GestureType.None;

        }

        private GestureType GetGesture()
        {
            //if (isWave())
            //{
            //    Console.WriteLine("Wave!!");
            //    return GestureType.Wave;
            //}
            //if (isCircle())
            //{
            //    Console.WriteLine("Circle!!");
            //    return GestureType.Circle;
            //}
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

        private bool isWave()
        {
            throw new NotImplementedException();
        }

        private bool isCircle()
        {
            throw new NotImplementedException();
        }

        private bool isUp()
        {
            if (valueX.CalculateDifference() < 90 && valueY.CalculateDifference() < 90
                && valueZ.CalculateDifference() > 100)
            {
                //Min und Max jeweils weit genug von Median entfernt?
                if ((valueZ.CalculateMedian() - valueZ.CalculateMin()) > MedianDiffValue
                    && valueZ.CalculateMax() - valueZ.CalculateMedian() > MedianDiffValue)
                {
                    return !valueZ.IsDirectionUp(); //erst Max, dann Min
                }
            }

            return false;
        }
        private bool isDown()
        {
            if (valueX.CalculateDifference() < 90 && valueY.CalculateDifference() < 90
                && valueZ.CalculateDifference() > 140)
            {
                //Min und Max jeweils weit genug von Median entfernt?
                if (valueZ.CalculateMedian() - valueZ.CalculateMin() > MedianDiffValue
                    && valueZ.CalculateMax() - valueZ.CalculateMedian() > MedianDiffValue)
                {
                    return valueZ.IsDirectionUp(); //erst Max, dann Min
                }
            }

            return false;
        }

        private bool isPush()
        {
            if (valueX.CalculateDifference() < 120 && valueY.CalculateDifference() > 120
                && valueZ.CalculateDifference() < 120)
            {
                return valueY.IsDirectionUp();
            }
            return false;
        }
        private bool isLeft()
        {
            if (valueX.CalculateDifference() > 120 && valueY.CalculateDifference() < 90
                && valueZ.CalculateDifference() < 90)
            {
                if ((valueX.CalculateMedian() - valueX.CalculateMin()) > MedianDiffValue
                    && valueX.CalculateMax() - valueX.CalculateMedian() > MedianDiffValue)
                {

                    return !valueX.IsDirectionUp();
                }
            }
            return false;
        }

        private bool isRight()
        {
            if (valueX.CalculateDifference() > 120 && valueY.CalculateDifference() < 90
                && valueZ.CalculateDifference() < 90)
            {
                if ((valueX.CalculateMedian() - valueX.CalculateMin()) > MedianDiffValue
                    && valueX.CalculateMax() - valueX.CalculateMedian() > MedianDiffValue)
                {

                    return valueX.IsDirectionUp();
                }
            }
            return false;
        }


    }
}
