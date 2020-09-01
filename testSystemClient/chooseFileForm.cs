using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net.Sockets;
using System.IO;
using System.Xml;
using ToMakeConnection;
using System.Net;
using System.Xml.Linq;

namespace testSystemClient
{
    public partial class chooseFileForm : Form
    {
        Socket srSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        BackgroundWorker worker = new BackgroundWorker();
        public chooseFileForm()
        {
            InitializeComponent();

            worker.WorkerSupportsCancellation = true;
            worker.WorkerReportsProgress = true;

            //worker.ProgressChanged += Worker_ProgressChanged;
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

        //private void Worker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        //{
        //    throw new NotImplementedException();
        //}

        

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
            XmlDocument xml = new XmlDocument();
            
            xml.Load("C:\\Users\\barab\\Desktop\\1.xml");


            ReceiveMessageType Message = new ReceiveMessageType
            {
                MessageType = MessageType.UploadTest,
                Data = new Up_Test()
                {
                    xml = xml.ToString()
                }
            };
            IPHostEntry ipHost = Dns.GetHostEntry("localhost");
            IPAddress ipAddr = ipHost.AddressList[1];
            IPEndPoint ipEndPoint = new IPEndPoint(ipAddr, 20000);
            srSocket.Connect(ipEndPoint);
            byte[] data = Serialization.ToByteArray(Message);
            srSocket.Send(data);

            data = new byte[2048];
            do
            {
                srSocket.Receive(data, data.Length, 0);
            }
            while (srSocket.Available > 0);

            srSocket.Shutdown(SocketShutdown.Both);
            srSocket.Close();

            ReceiveMessageType receiveMessageType = Serialization.FromByteArray<ReceiveMessageType>(data);
            if (receiveMessageType.MessageType == MessageType.Error)
            {
                
                MessageBox.Show($"ok");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

            Close();
        }
        Point lastPoint;

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

