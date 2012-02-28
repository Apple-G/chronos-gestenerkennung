using System;
using ChronosGestenerkennung.Gestures;
using eZ430ChronosNet;

namespace ChronosGestenerkennung.Com
{
    class Communication
    {
        private int arraySize { get { return 10; } }
        private int recordIndexMax { get { return 10; } }

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

        public Communication()
        {
            myChronos = new Chronos();
            values = new Point[arraySize];
values2 = new Point[arraySize];
            for (int i=0; i<arraySize; i++)
            {
                values[i] = new Point(0, 0, 0);
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

            record = false;
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
            }
            else
            {
                for (int i = 0; i < arraySize-1; i++)
                {
                    values2[i] = values2[i + 1];
                }
                values2[arraySize - 1] = values[valueIndex];

                //string temp = "";
                //foreach (Point p in values2)
                //{
                //    temp += p.X + ", ";
                //}
                //Console.WriteLine(temp);

            }

            TestGeste(20, 70);

            if (record)
            {
                if (recordIndex < recordIndexMax)
                {
                    RecordValues[recordIndex] = values[valueIndex];
                    recordIndex++;
                }
                else
                {
                    record = false;
                }
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
                    countTreffer++;
            }
            Console.WriteLine("Treffer: " + countTreffer + ", => " +(countTreffer / arraySize) * 100);

            if ((countTreffer / arraySize) * 100 >= genauigkeit)
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

        public void StartRecord()
        {
            record = true;
            recordIndex = 0;
            RecordValues = new Point[recordIndexMax];
        }
    }
}
