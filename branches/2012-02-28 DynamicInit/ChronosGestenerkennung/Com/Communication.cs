using System;
using ChronosGestenerkennung.Gestures;
using eZ430ChronosNet;

namespace ChronosGestenerkennung.Com
{
    class Communication
    {
        private int arraySize { get { return 10; } }

        private Chronos myChronos;
        private String portName;

        public uint Data { private set; get; }

        public GestureType analysedGesture { private set; get; }

        private int valueIndex;

        private Point[] values;
        private Point[] values2;
        private Gesture[] gesture;
        private Algo algo;

        public bool record { private set; get; }
        private int recordIndex;
        private Point[] RecordValues;

        private TobiTest test;
        private GestureType recordType;

        public Communication(int offset, int genauigkeit)
        {
            myChronos = new Chronos();
            values = new Point[arraySize];
            values2 = new Point[arraySize];
            RecordValues = new Point[arraySize];
            for (int i = 0; i < arraySize; i++)
            {
                values[i] = new Point(0, 0, 0);
                RecordValues[i] = values[i];
                values2[i] = values[i];
            }
            valueIndex = 0;
            analysedGesture = GestureType.None;



            int definedGesture = 5;

            //First create an array from gestures
            gesture = new Gesture[definedGesture];

            //Fill the array of gesture with new gesture
            for (int i = 0; i < definedGesture; i++)
                gesture[i] = new Gesture(i);

            //A new Algorithm object
            algo = new Algo(gesture, definedGesture);


            test = new TobiTest();

            record = false;
        }

        public Communication()
            :this (0,100)
        {
    
        }

        public bool Connect()
        {
            portName = myChronos.GetComPortName();
            if (!String.IsNullOrEmpty(portName))
            {
                if (myChronos.OpenComPort(portName))
                {
                    myChronos.StartSimpliciTI();
                    portName = myChronos.GetComPortName();
                    return true;
                }
            }

            return false;
        }

        public void Disconnect()
        {
            myChronos.CloseComPort();
        }

        public bool GetConnectonStatus()
        {
            return myChronos.PortOpen;
        }

        private uint GetData()
        {
            uint data;
            myChronos.GetData(out data);
            return data;
        }

        public int GetX()
        {
            return (sbyte)(Data >> 8);
        }

        public int GetY()
        {
            return (sbyte)(Data >> 16);
        }

        public int GetZ()
        {
            return (sbyte)(Data >> 24);
        }

        public void UpdateData()
        {
            Data = GetData();

            if (valueIndex >= arraySize)
            {
                valueIndex = 0;
                AnalyseGesture();
            }

            values[valueIndex].X = GetX();
            values[valueIndex].Y= GetY();
            values[valueIndex].Z = GetZ();

            if (values2[valueIndex] == null)
            {
                values2[valueIndex] = values[valueIndex];
                return;
            }
            else
            {
                for (int i = 0; i < arraySize-1; i++)
                {
                    values2[i] = values2[i + 1];
                }
                values2[arraySize - 1] = values[valueIndex];

               // printValues(values2, 1);
            }



            if (record)
            {
                if (recordIndex < arraySize)
                {
                    RecordValues[recordIndex] = values[valueIndex];
                    recordIndex++;
                }
                else
                {
                    printValues(RecordValues);
                    test.SaveGestur(recordType, RecordValues);
                    record = false; 
               }
            }
            else
            {
                
                analysedGesture = test.Analytic(values2);
                if (analysedGesture != GestureType.None)
                {
                    for (int i=0; i<arraySize; i++)
                    {
                        values2[i] = new Point(0, 0, 0);
                    }
                }
               // TestGeste(0, 70);
            }
            
            valueIndex++;
        }

        private void AnalyseGesture()
        {
           GestureType temp = algo.getGesture(values, arraySize);
           if (temp != GestureType.None)
               analysedGesture = temp;
        }










        // Test geste
        private void TestGeste(int offset, int genauigkeit)
        {
            int countTreffer = 0;
            for (int i = 0; i < arraySize; i++)
            {
                if (CheckValues(offset, values2[i].X, RecordValues[i].X))
                {
                    Console.WriteLine(values2[i].X + " = " + RecordValues[i].X);
                    countTreffer++;
                }
            }
            double p = (double) countTreffer / (double)arraySize *100;
            Console.WriteLine("Treffer: " + countTreffer + ", => " + p);

            if (p >= genauigkeit)
            {
                analysedGesture = GestureType.Push;
               
            }        

        }

        private bool CheckValues(int offset, int value1, int value2)
        {
            if (value1 == value2)
                return true;

            if (value1 + offset == value2)
                return true;

            if (value1 + offset == value2)
                return true;

            return false;
        }

        //Confog

        public void StartRecord(GestureType type)
        {
            record = true;
            recordType = type;
            recordIndex = 0;
        }

        //Console

        private void printValues(Point[] points)
        {
            for (int i = 1; i <= 3; i++)
                printValues(points, i); 
        }

        private void printValues(Point[] points, int i)
        {
             string temp = "";
             switch (i)
             {
                 case 1:
                     temp = "X: =>";
                     foreach (Point p in points)
                     {
                         temp += p.X + ", ";
                     }
                     break;
                 case 2:
                     temp = "Y: =>";
                     foreach (Point p in points)
                     {
                         temp += p.Y + ", ";
                     }
                     break;
                 case 3:
                     temp = "Z: =>";
                     foreach (Point p in points)
                     {
                         temp += p.Z + ", ";
                     }
                     break;

             }
            Console.WriteLine(temp);
        }


    }
}
