using System;
using ChronosGestenerkennung.Gestures;
using eZ430ChronosNet;

namespace ChronosGestenerkennung.Com
{
    class Communication
    {
        private Chronos myChronos;
        private String portName;

        public uint Data { private set; get; }

        public GestureType analysedGesture { private set; get; }

        private int valueIndex;
        private int arraySize;
        private Point[] values;
        private Gesture[] gesture;
        private Algo algo;
        private AlgoNew algo2;

        public Communication()
        {
            myChronos = new Chronos();
            arraySize = 10;
            values = new Point[arraySize];
            for (int i = 0; i < arraySize; i++)
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
            algo2 = new AlgoNew();
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
            AnalyseGesture2();
            values[valueIndex].X = GetX();
            values[valueIndex].Y = GetY();
            values[valueIndex].Z = GetZ();
            valueIndex++;
        }

        private void AnalyseGesture()
        {
            GestureType temp = algo.getGesture(values, arraySize);
            if (temp != GestureType.None)
                analysedGesture = temp;
        }
        private void AnalyseGesture2()
        {
            GestureType temp = algo2.getGesture(values, arraySize);
            if (temp != GestureType.None)
                analysedGesture = temp;
        }

    }
}
