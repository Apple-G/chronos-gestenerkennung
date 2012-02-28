using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChronosGestenerkennung.Gestures
{
    class TobiTest
    {
        private List<TobiGesture> gesture;
        
        private Point[] values;
        public Point Max { private set; get; }
        public Point Min { private set; get; }
        public Point MaxIndex { private set; get; }
        public Point MinIndex { private set; get; }
        public Point Difference { private set; get; }
        public bool[] DirectionUp { private set; get; }

        public TobiTest()
        {
            gesture = new List<TobiGesture>();
           


            gesture.Add(new TobiGesture(GestureType.Push, new Point(160, 0, 0), new bool[] {true, false, false}));

        }

        public void SaveGestur(GestureType name, Point[] p)
        {
            Calculate(p);
            TobiGesture t = new TobiGesture(name, Difference, DirectionUp);
            Console.WriteLine("Difference X: " + t.Difference.X + "\t Y: " + t.Difference.Y + "\t Z: " + t.Difference.Z);
            Console.WriteLine("DirectionUp X: " + t.DirectionUp[0] + "\t Y: " + t.DirectionUp[1] + "\t Z: " + t.DirectionUp[2]);
            foreach (TobiGesture g in gesture)
            {
                if (g.Name == name)
                {
                    g.Difference = t.Difference;
                    g.DirectionUp = t.DirectionUp;

                    return;
                }
            }


            gesture.Add(t);
        }

        public GestureType Analytic(Point [] p)
        {
            Calculate(p);

            Console.WriteLine("Difference X: " + Difference.X + "\t Y: " + Difference.Y + "\t Z: " + Difference.Z);
            Console.WriteLine("DirectionUp X: " + DirectionUp[0] + "\t Y: " + DirectionUp[1] + "\t Z: " + DirectionUp[2]);
            foreach (TobiGesture g in gesture)
            {
                if ((Difference.X >= g.Difference.X) && (DirectionUp[0] == g.DirectionUp[0]))
                {
                    Console.WriteLine("X: " + Difference.X + "\t " + DirectionUp[0]);
                    if ((Difference.Y >= g.Difference.Y) && (DirectionUp[1] == g.DirectionUp[1]))
                    {
                        Console.WriteLine("Y: " + Difference.Y + "\t " + DirectionUp[1]);

                        if ((Difference.Z >= g.Difference.Z) && (DirectionUp[2] == g.DirectionUp[2]))
                        {
                            Console.WriteLine("Z: " + Difference.Z + "\t " + DirectionUp[2]);

                            Console.WriteLine("========================>" + g.Name + "\n\n\n");
                            return g.Name;
                        }
                    }
                }
            }

            

            return GestureType.None;
        }


        //Calculate

        private void Calculate(Point[] p)
        {
            values = p;
            if (values != null)
            {
                CalculateMin();
                CalculateMax();
                CalculateDifference();
                CalculateDirection();
            }
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
