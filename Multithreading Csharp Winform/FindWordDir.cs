using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Multithreading_Csharp_Winform
{
    public partial class FindWordDir : Form
    {
        string path;
        bool stop;
        int filesInProcessing;
        public FindWordDir()
        {
            InitializeComponent();
            stop = true;
            filesInProcessing = 0;
            label3.Text = String.Empty;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            if (folderBrowserDialog.ShowDialog() != DialogResult.Cancel)
            {
                label1.Text = $"path: {folderBrowserDialog.SelectedPath}";
                path = folderBrowserDialog.SelectedPath;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (path == String.Empty)
            {
                MessageBox.Show("Choose folder");
                return;
            }
            else if (stop == false && filesInProcessing != 0)
            {
                MessageBox.Show("Finding word");
            }
            stop = false;
            Task.Run(() =>
            {
                FindWordInFolder(path);
                label3.Text = "Search in progress..";
                while (true)
                {
                    if (stop)
                    {
                        while (filesInProcessing > 0)
                        {

                        }
                        label3.Text = "Done";
                        break;
                    }
                }
            });
        }

        private void FindWordInFolder(object state)
        {
            string dirPath = (string)state;
            IEnumerable<string> directories = Directory.EnumerateDirectories(dirPath);
            IEnumerable<string> files = Directory.EnumerateFiles(dirPath);

            foreach (string folderPath in directories)
            {
                ThreadPool.QueueUserWorkItem(FindWordInFolder, folderPath);
            }

            foreach (string filePath in files)
            {
                ThreadPool.QueueUserWorkItem(FindWordInFile, filePath);
                Interlocked.Increment(ref filesInProcessing);
            }
            stop = true;
        }

        private void FindWordInFile(object state)
        {
            string filePath = (string)state;
            try
            {
                string result;
                using (FileStream fs = new FileStream(filePath, FileMode.Open))
                {
                    byte[] arr = new byte[fs.Length];
                    IAsyncResult asyncResult = fs.BeginRead(arr, 0, arr.Length, null, null);
                    fs.EndRead(asyncResult);
                    result = Encoding.UTF8.GetString(arr);
                }
                int count = result.Split($"{textBox1.Text}").Length - 1;
                string[] str = result.Split($"{textBox1.Text}");
                if (count > 0)
                {
                    lock (textBox2)
                    {
                        textBox2.Text += $"Found: {count} \"{textBox1.Text}\" in {filePath}\r\n";
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show($"Error while reading file: {filePath}");
            }
            finally
            {
                Interlocked.Decrement(ref filesInProcessing);
            }
        }
    }
}
