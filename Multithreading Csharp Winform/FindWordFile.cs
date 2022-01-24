using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Multithreading_Csharp_Winform
{
    public partial class FindWordFile : Form
    {
        string path;
        public FindWordFile()
        {
            InitializeComponent();
            path = String.Empty;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "All files(*.*)|*.*";
            if (ofd.ShowDialog() != DialogResult.Cancel)
            {
                label1.Text = $"path: {ofd.FileName}";
                path = ofd.FileName;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (path == String.Empty)
            {
                MessageBox.Show("Choose file");
                return;
            }
            string result;
            using (FileStream fs = new FileStream(path, FileMode.Open))
            {
                byte[] arr = new byte[fs.Length];
                IAsyncResult asyncResult = fs.BeginRead(arr, 0, arr.Length, null, null);
                fs.EndRead(asyncResult);
                result = Encoding.UTF8.GetString(arr);
            }
            MessageBox.Show($"Find: {result.Split($"{textBox1.Text}").Length - 1}");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FindWordDir findWordDir = new FindWordDir();
            this.Visible = false;
            findWordDir.ShowDialog();
            this.Close();
        }
    }
}
