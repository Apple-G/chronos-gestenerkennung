using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ChronosGestenerkennung.Com;

namespace ChronosGestenerkennung
{
    public partial class Form1 : Form
    {
        private Communication chronosCom;

        public Form1()
        {
            chronosCom = new Communication();
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
            chronosCom.UpdateData();
            labelRaw.Text = "Raw Value: " + chronosCom.Data.ToString("X");
            labelX.Text = "X: " + chronosCom.GetX();
            labelY.Text = "Y: " + chronosCom.GetY();
            labelZ.Text = "Z: " + chronosCom.GetZ();

            labelGesture.Text = "Analyzed Gesture: " + chronosCom.analysedGesture;
        }
    }
}
