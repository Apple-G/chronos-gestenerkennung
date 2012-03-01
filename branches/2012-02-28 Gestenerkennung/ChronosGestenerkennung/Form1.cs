using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ChronosGestenerkennung.Com;
using ChronosGestenerkennung.Gestures;

namespace ChronosGestenerkennung
{
    public partial class Form1 : Form
    {

        private bool UseAlgo1;
        private ChronosCommunication chronosCom;
        private AlgoNew algoGesture;
        private int timerGesture;

        public Form1()
        {
            UseAlgo1 = true;
            chronosCom = new ChronosCommunication();
            algoGesture = new AlgoNew();
            InitializeComponent();

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
                algoGesture.UpdateValues(chronosCom.GetX(), chronosCom.GetY(), chronosCom.GetZ());
                tempGesture = algoGesture.AnalyseGesture();
            }
            //Algo 2
            else
            {
                //ToDo
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
                UseAlgo1 = false;

            }
            else if (temp.Name == "radioButtonAlgo1" && temp.Checked)
            {

                Console.WriteLine("radioButtonAlgo1 checked");
                UseAlgo1 = true;
            }

        }     
        

    }
}
