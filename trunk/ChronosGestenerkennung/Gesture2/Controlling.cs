using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChronosGestenerkennung.Gesture2
{
    class Controlling
    {
        public const int arraySize = 10;
        private Point[] values;
        private Gesture[] gesture;
        private Algo algo;
        private int valueIndex;
        public GestureType analysedGesture { private set; get; }
        public int logicTime;

        public Controlling()
        {
             values = new Point[arraySize];
            for (int i=0; i<arraySize; i++)
            {
                values[i] = new Point(0, 0, 0);
            }
            valueIndex = 0;
            //First create an array from gestures
            gesture = new Gesture[7];

            //Fill the array of gesture with new gesture
            gesture[0] = new Up();
            gesture[1] = new Down();
            gesture[2] = new Push();
            gesture[3] = new Left();
            gesture[4] = new Right();
            gesture[5] = new Circle();
            gesture[6] = new Wave();

            //A new Algorithm object
            algo = new Algo(gesture, arraySize);

            logicTime = 0;
        }

        public void UpdateData(int x, int y, int z)
        {

            if (analysedGesture == GestureType.None)
            {
                if (valueIndex >= arraySize)
                {
                    valueIndex = 0;
                    AnalyseGesture();
                }

                values[valueIndex].X = x;
                values[valueIndex].Y = y;
                values[valueIndex].Z = z;
                valueIndex++;
            }
            else
            {
                logicTime++;
                //Autorise reading new value after 5 seconds
                if (logicTime == 30)
                {
                    analysedGesture = GestureType.None;
                    logicTime = 0;
                }
            }
        }

        private void AnalyseGesture()
        {
           //GestureType temp = algo.getGesture(values);
            analysedGesture = algo.getGesture(values);
        }

        internal Algo Algo
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public Gesture Gesture
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        internal Algo Algo1
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public Gesture Gesture1
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }
    }
}
