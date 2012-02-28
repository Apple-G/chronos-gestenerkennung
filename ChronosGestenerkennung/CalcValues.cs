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
                if (values[valueIndex] == null)
                {
                    values[valueIndex] = value;
                }
                else
                {
                    for (int i = 0; i < arraySize - 1; i++)
                    {
                        values[i] = values[i + 1];
                    }
                    values[arraySize - 1] = value;
                }
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
            for (int i = 0; i < arraySize; i++)
            {
                values[i] = 0;
            }
            valueIndex = 0;
        }

        public void SetValues(int value)
        {
            
        }


        private void CalculateMin()
        {
            if (values != null)
            {
                Min = new Point(255, 255, 255);
                MinIndex = new Point(0, 0, 0);
                for (int i = 0; i < values.Length; i++)
                {
                    if (values[i].X < Min.X)
                    {
                        Min.X = values[i].X;
                        MinIndex.X = i;
                    }

                    if (values[i].Y < Min.Y)
                    {
                        Min.Y = values[i].Y;
                        MinIndex.Y = i;
                    }

                    if (values[i].Z < Min.Z)
                    {
                        Min.Z = values[i].Z;
                        MinIndex.Z = i;
                    }

                }
            }
        }



        private void CalculateMax()
        {
            if (values != null)
            {
                Max = new Point(-255, -255, -255);
                MaxIndex = new Point(0, 0, 0);

                for (int i = 0; i < values.Length; i++)
                {
                    if (values[i].X > Max.X)
                    {
                        Max.X = values[i].X;
                        MaxIndex.X = i;
                    }

                    if (values[i].Y > Max.Y)
                    {
                        Max.Y = values[i].Y;
                        MaxIndex.Y = i;
                    }

                    if (values[i].Z > Max.Z)
                    {
                        Max.Z = values[i].Z;
                        MaxIndex.Z = i;
                    }

                }
            }
        }

        private void CalculateDifference()
        {
            Difference = new Point((Max.X - Min.X), (Max.Y - Min.Y), (Max.Z - Min.Z));
        }

        private void CalculateDirection()
        {
            DirectionUp = new bool[3];
            if (MaxIndex.X > MinIndex.X)
                DirectionUp[0] = true;
            else
                DirectionUp[0] = false;

            if (MaxIndex.Y > MinIndex.Y)
                DirectionUp[1] = true;
            else
                DirectionUp[1] = false;

            if (MaxIndex.Z > MinIndex.Z)
                DirectionUp[2] = true;
            else
                DirectionUp[2] = false;
        }
    }
}
