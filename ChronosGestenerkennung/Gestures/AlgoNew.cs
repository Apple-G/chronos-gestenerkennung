using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChronosGestenerkennung.Gestures
{
    class AlgoNew
    {
        private readonly int arraySize;

        CalcValues valueX;
        CalcValues valueY;
        CalcValues valueZ;

        public AlgoNew()
        {
            arraySize = 10;
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
            return GestureType.None;
        }

        private bool isUp()
        {
            if (valueX.CalculateDifference() < 100 && valueY.CalculateDifference() < 100 && valueZ.CalculateDifference() > 140)
            {
                return !valueZ.IsDirectionUp(); //erst Max, dann Min
            }

            return false;
        }

        private bool isPush()
        {
            if (valueX.CalculateDifference() < 70 && valueY.CalculateDifference() < 120 && valueZ.CalculateDifference() > 90)
            {
                return valueY.IsDirectionUp(); 
            }
            return false;
        }
    }
}
