using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Multithreading_Csharp_Winform
{
    public partial class Fiponachi : Form
    {
        public Fiponachi()
        {
            InitializeComponent();
        }

        public async Task<int> FibAsync(int stopNum)
        {
            int tmp;
            int numbers = 0;
            for (int firstNum = 0, secNum = 1; secNum + firstNum <= stopNum; numbers++)
            {
                tmp = secNum;
                secNum += firstNum;
                firstNum = tmp;
            }
            return numbers;
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            int res = await FibAsync(Convert.ToInt32(numericUpDown1.Value));
            MessageBox.Show($"Result: {res}!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FindWordFile findWordFile = new FindWordFile();
            this.Visible = false;
            findWordFile.ShowDialog();
            this.Close();
        }
    }
}
