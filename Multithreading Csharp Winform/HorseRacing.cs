using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Multithreading_Csharp_Winform
{
    public partial class HorseRacing : Form
    {
        List<ProgressBar> progressBars;
        bool won;
        public HorseRacing()
        {
            InitializeComponent();
            won = true;
            progressBars = new List<ProgressBar>() { Horse1, Horse2, Horse3, Horse4, Horse5 };
            int i = 1;
            foreach (ProgressBar progressBar in progressBars)
            {
                progressBar.Name = $"Horse {i++}";
            }
            int num1;
            int available;

            ThreadPool.GetAvailableThreads(out num1, out available);
            ThreadPool.SetMinThreads(5, available);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!won)
            {
                won = true;
                MessageBox.Show("Stopped");
            }
            else
            {
                won = false;
                foreach (ProgressBar progressBar in progressBars)
                {
                    progressBar.Value = 0;
                }
                foreach (ProgressBar progressBar in progressBars)
                {
                    ThreadPool.QueueUserWorkItem(StartRace, progressBar);
                }
            }
        }

        private void StartRace(object state)
        {
            ProgressBar progressBar = (ProgressBar)state;
            Random random = new Random();
            int speed;
            int num;
            while (!won)
            {
                speed = random.Next(20);
                num = progressBar.Value + random.Next(0, speed);
                progressBar.Value = (num > 100 ? 100 : num);
                Thread.Sleep(500);
                if (progressBar.Value == 100)
                {
                    won = true;
                    MessageBox.Show($"{progressBar.Name} won!");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Fiponachi fiponachi = new Fiponachi();
            this.Visible = false;
            won = true;
            fiponachi.ShowDialog();
            this.Close();
        }
    }
}
