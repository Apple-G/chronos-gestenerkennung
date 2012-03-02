using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using eZ430ChronosNet;

namespace ChronosGestenerkennung.Com
{
    class ChronosCommunication
    {
        private Chronos myChronos;
        private String portName;

        public uint Data { private set; get; }

        public ChronosCommunication()
        {
            myChronos = new Chronos();
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

        public void UpdateValues()
        {
            Data = GetData();
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
    }
}
