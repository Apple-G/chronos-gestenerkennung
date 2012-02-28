using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChronosGestenerkennung.Gestures
{
    class Algo
    {
        private Gesture[] gesture;
        private GestureType detectedGesture;
        private int gesturelenght;

        public Algo(Gesture[] nGesture, int lenght)
        {
            this.gesture = nGesture;
            this.detectedGesture = GestureType.None;
            this.gesturelenght = lenght;
        }

        //This method retiurn teh detected gesture
        public GestureType getGesture(Point[] points, int lenght)
        {
            if (!isWinken(points, lenght))
            {
                if (!isCircle(points, lenght))
                {
                    if (!isStossen(points, lenght))
                    {
                        if (!isWischenAufAb(points, lenght))
                        {
                            if (!isWischenLinksRechts(points, lenght)) { }
                        }
                    }
                }
            }
            return this.detectedGesture;
        }

        //Search for waiving (Winken)
        private bool isWinken(Point[] points, int lenght)
        {
            return false;
        }
        //Search for circle (Kreisen)
        private bool isCircle(Point[] points, int lenght)
        {
            return false;
        }
        //Search for push (Stoßen)
        private bool isStossen(Point[] points, int lenght)
        {
            return false;
        }
        //Search for wipe up / down (Wischen Auf / Ab)
        private bool isWischenAufAb(Point[] points, int lenght)
        {
            return false;
        }
        //Search for wipe left / right (Wischen links / rechts)
        private bool isWischenLinksRechts(Point[] points, int lenght)
        {
            return false;
        }
    }
}
