using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Threading;

namespace ChronosGestenerkennung
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Form1 tf = new Form1();
            Thread ct = new Thread(
                new ThreadStart(
                delegate()
                {
                    while (true)
                    {
                        string command = Console.ReadLine();
                        switch (command)
                        {
                            case "close":
                                tf.Invoke(new MethodInvoker(
                                    delegate()
                                    {
                                        tf.Close();
                                    }));
                                break;
                            case "max":
                                tf.Invoke(new MethodInvoker(
                                    delegate()
                                    {
                                        tf.WindowState = FormWindowState.Maximized;
                                    }));
                                break;
                            case "min":
                                tf.Invoke(new MethodInvoker(
                                    delegate()
                                    {
                                        tf.WindowState = FormWindowState.Minimized;
                                    }));
                                break;
                            case "res":
                                tf.Invoke(new MethodInvoker(
                                    delegate()
                                    {
                                        tf.WindowState = FormWindowState.Normal;
                                    }));
                                break;
                        }

                    }
                }));
            ct.Start();
            tf.Show();
            tf.Activate();
            Application.Run(tf);
            Environment.Exit(0);
        }
    }
}