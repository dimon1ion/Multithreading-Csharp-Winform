using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Multithreading_Csharp_Winform
{
    public partial class Form1 : Form
    {
        List<ProgressBar> progressBars;
        bool started;
        public Form1()
        {
            InitializeComponent();
            progressBars = new List<ProgressBar>();
            started = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (button.Text == "start")
            {
                buttonGenerateProgressBars.Enabled = false;
                button.Text = "stop";
                started = true;

                foreach (ProgressBar progressBar in progressBars)
                {
                    ThreadPool.QueueUserWorkItem(StartBar, progressBar);
                }
            }
            else
            {
                buttonGenerateProgressBars.Enabled = true;
                button.Text = "start";
                started = false;
            }
        }

        private void StartBar(object state)
        {
            ProgressBar progressBar = (ProgressBar)state;
            Random random = new Random();
            while (started)
            {
                progressBar.Value = random.Next(0, 100);
                Thread.Sleep(600);
            }
        }

        private void buttonGenerateProgressBars_Click(object sender, EventArgs e)
        {
            if (progressBars.Count > 0)
            {
                foreach (ProgressBar progressBar in progressBars)
                {
                    this.Controls.Remove(progressBar);
                }
                progressBars.Clear();
            }
            int count = Convert.ToInt32(numericUpDown1.Value);
            int num1;
            int available;

            ThreadPool.GetAvailableThreads(out num1, out available);
            ThreadPool.SetMinThreads(count, available);

            int yCoord = 50;
            int xCoord = 10;
            bool rightToLeft = false;
            Random random = new Random();
            for (int i = 0; i < count; i++)
            {
                ProgressBar progressBar = new ProgressBar();
                progressBar.Width = 700;
                progressBar.Height = 23;

                progressBar.Top = yCoord;
                progressBar.Left = xCoord;

                if (rightToLeft)
                {
                    progressBar.RightToLeft = RightToLeft.Yes;
                    progressBar.RightToLeftLayout = rightToLeft;
                    rightToLeft = false;
                }
                else
                {
                    rightToLeft = true;
                }

                progressBar.SetState(random.Next(0, 4));

                this.Controls.Add(progressBar);

                yCoord = progressBar.Top + 23;

                progressBars.Add(progressBar);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HorseRacing horseRacing = new HorseRacing();
            this.Visible = false;
            started = false;
            horseRacing.ShowDialog();
            this.Close();
        }
    }
}
