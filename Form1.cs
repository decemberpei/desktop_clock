using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace Clock2
{
    public partial class Clock : Form
    {
        private bool mRunning = true;
        public Clock()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            /*this.Location = new Point(Screen.PrimaryScreen.Bounds.Width - this.Width,
                          Screen.PrimaryScreen.Bounds.Height - this.Height);*/
            this.Location = new Point(Screen.PrimaryScreen.WorkingArea.Width - this.Width,
                          Screen.PrimaryScreen.WorkingArea.Height - this.Height);

            DateTime now = System.DateTime.Now;
            txt_clock.Text = now.Hour + ":" + now.Minute + ":" + now.Second;

            Thread work_thread = new Thread(worker);
            work_thread.Start();
        }

        private void worker()
        {
            while (mRunning)
            {
                Thread.Sleep(1000);
                if (mRunning)
                {
                    DateTime now = System.DateTime.Now;
                    txt_clock.Invoke(new MethodInvoker(delegate { txt_clock.Text = now.Hour + ":" + now.Minute + ":" + now.Second; }));
                }
            }
        }

        private void Clock_FormClosing(object sender, System.Windows.Forms.FormClosingEventArgs e)
        {
            mRunning = false;
            Thread.Sleep(0);
        }
    }
}
