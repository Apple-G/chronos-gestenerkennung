using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ChronosGestenerkennung.Com;
using ChronosGestenerkennung.Gesture1;
using ChronosGestenerkennung.Gesture2;

namespace ChronosGestenerkennung
{
    public partial class Form1 : Form
    {

        private bool UseAlgo1;
        private ChronosCommunication chronosCom;
        private AlgoNew algoGesture1;
        private int timerGesture;
        private Controlling algoGestrue2;

        public Form1()
        {
            UseAlgo1 = true;
            chronosCom = new ChronosCommunication();
            algoGesture1 = new AlgoNew();
            algoGestrue2 = new Controlling();
            InitializeComponent();

        }

        internal ChronosGestenerkennung.Com.ChronosCommunication ChronosCommunication
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        internal ChronosGestenerkennung.Gesture1.AlgoNew AlgoNew
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        internal ChronosGestenerkennung.Gesture2.Controlling Controlling
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        internal ChronosGestenerkennung.Com.ChronosCommunication ChronosComm
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        internal ChronosGestenerkennung.Gesture1.AlgoNew AlgoNew1
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        internal ChronosGestenerkennung.Com.ChronosCommunication ChronosCommunication1
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        internal ChronosGestenerkennung.Gesture2.Controlling Controlling1
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            if (chronosCom.GetConnectonStatus())
            {
                //Disconnect
                chronosCom.Disconnect();
                buttonConnect.Text = "Connect";
                labelStatus.Text = "Disconnected";
                timer1.Enabled = false;

            }
            else
            {
                if (chronosCom.Connect())
                {
                    buttonConnect.Text = "Disonnect";
                    labelStatus.Text = "Connected";
                    timer1.Enabled = true;
                }
                else
                {
                    labelStatus.Text = "Error 2000: No Port";
                }

            }
        }

        void Timer1_Tick(object sender, EventArgs e)
        {
            chronosCom.UpdateValues();
            GestureType tempGesture = GestureType.None;


            //Algo 1
            if (UseAlgo1)
            {
                algoGesture1.UpdateValues(chronosCom.GetX(), chronosCom.GetY(), chronosCom.GetZ());
                tempGesture = algoGesture1.AnalyseGesture();
            }
            //Algo 2
            else
            {
                algoGestrue2.UpdateData(chronosCom.GetX(), chronosCom.GetY(), chronosCom.GetZ());
                tempGesture = algoGestrue2.analysedGesture;
            }

            if (tempGesture != GestureType.None || timerGesture > 40)
            {
                timerGesture = 0;
                labelGesture.Text = "Analyzed Gesture: " + tempGesture;
            }

            timerGesture++;

            labelRaw.Text = "Raw Value: " + chronosCom.Data.ToString("X");
            labelX.Text = "X: " + chronosCom.GetX();
            labelY.Text = "Y: " + chronosCom.GetY();
            labelZ.Text = "Z: " + chronosCom.GetZ();
        }



        private void buttonTimer_Click(object sender, EventArgs e)
        {
            timer1.Enabled = !timer1.Enabled;
        }

        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton temp = (RadioButton)sender;

            if (temp.Name == "radioButtonAlgo2" && temp.Checked)
            {
                Console.WriteLine("radioButtonAlgo2 checked");
                this.timer1.Interval = 100;
                UseAlgo1 = false;

            }
            else if (temp.Name == "radioButtonAlgo1" && temp.Checked)
            {

                Console.WriteLine("radioButtonAlgo1 checked");
                this.timer1.Interval = 50;
                UseAlgo1 = true;
            }

        }


    }
}
