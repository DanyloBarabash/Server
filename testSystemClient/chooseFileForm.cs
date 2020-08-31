using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net.Sockets;
using System.IO;

namespace testSystemClient
{
    public partial class chooseFileForm : Form
    {
        BackgroundWorker worker = new BackgroundWorker();
        public chooseFileForm()
        {
            InitializeComponent();

            worker.WorkerSupportsCancellation = true;
            worker.WorkerReportsProgress = true;

            worker.ProgressChanged += Worker_ProgressChanged;
            worker.DoWork += Worker_DoWork;
        }

        void CopyFile(string sorce, string server)
        {
            FileStream fsOut = new FileStream(server, FileMode.Create);
            FileStream fsIn = new FileStream(sorce, FileMode.Open);
            byte[] bt = new byte[1048756];
            int readByte;

            while((readByte = fsIn.Read(bt,0,bt.Length))>0)
            {
                fsOut.Write(bt, 0, readByte);
                worker.ReportProgress((int) (fsIn.Position*100/fsIn.Length));
            }
            fsIn.Close();
            fsOut.Close();
        }

        private void Worker_DoWork(object sender, DoWorkEventArgs e)
        {
            CopyFile(textBox1.Text, textBox2.Text);
        }

        private void Worker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            throw new NotImplementedException();
        }

        

        private void button1_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            if(op.ShowDialog()==DialogResult.OK)
            {
                textBox1.Text = op.FileName;
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if(fbd.ShowDialog()==DialogResult.OK)
            {
                textBox2.Text = Path.Combine(fbd.SelectedPath, Path.GetFileName(textBox1.Text));
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            worker.RunWorkerAsync();
        }
    }
}

