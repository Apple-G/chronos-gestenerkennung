using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChronosGestenerkennung
{
    class CalcValues
    {

        private readonly int arraySize;
        private int valueIndex;
        private int[] values;
        public int Values
        {
            set
            {
                for (int i = 0; i < arraySize - 1; i++)
                {
                    values[i] = values[i + 1];
                }
                values[arraySize - 1] = value;

                valueIndex++;
            }
        }

        public CalcValues(int pArraySize)
        {
            arraySize = pArraySize;
            values = new int[arraySize];
            valueIndex = 0;
        }

        public void Reset()
        {
            Reset(0);
        }

        public void Reset(int value)
        {
            for (int i = 0; i < arraySize; i++)
            {
                values[i] = value;
            }
            valueIndex = 0;
        }

        public int CalculateMin()
        {
            return CalculateMin(0, arraySize);
        }

        public int CalculateMin(int start, int end)
        {
            int min = 255;
            if (end <= arraySize)
            {

                for (int i = start; i < end; i++)
                {
                    if (values[i] < min)
                    {
                        min = values[i];
                    }
                }
            }
            return min;
        }
        public int CalculateMax()
        {
            return CalculateMax(0, arraySize);
        }

        public int CalculateMax(int start, int end)
        {
            int max = -255;
            if (end <= arraySize)
            {

                for (int i = start; i < end; i++)
                {
                    if (values[i] > max)
                    {
                        max = values[i];
                    }
                }
            }
            return max;
        }

        public int CalculateDifference()
        {
            return CalculateDifference(0, arraySize);
        }

        public int CalculateDifference(int start, int end)
        {
            return (CalculateMax(start, end) - CalculateMin(start, end));
        }

        public bool IsDirectionUp()
        {
            return IsDirectionUp(0, arraySize);
        }

        public bool IsDirectionUp(int start, int end)
        {
            return (GetIndex(CalculateMax(start, end)) > GetIndex(CalculateMin(start, end)));
        }

        public bool IsDirectionDown()
        {
            return IsDirectionDown(0, arraySize);
        }

        public bool IsDirectionDown(int start, int end)
        {
            return (GetIndex(CalculateMax(start, end)) < GetIndex(CalculateMin(start, end)));
        }

        public int GetIndex(int value)
        {
            for (int i = 0; i < arraySize; i++)
            {
                if (values[i] == value)
                    return i;
            }
            return -1;
        }

        public int CalculateMedian()
        {
            int[] tempArray = new int[arraySize];

            for (int i = 0; i < arraySize; i++)
            {
                tempArray[i] = values[i];
            }

            Array.Sort(tempArray);
            if (arraySize % 2 == 0)
            {
                return (tempArray[arraySize / 2] + tempArray[(arraySize / 2) + 1]) / 2;
            }
            else
            {
                return tempArray[arraySize / 2];
            }
        }
    }
}
