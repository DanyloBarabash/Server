using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ToMakeConnection;

namespace testSystemClient
{
    public partial class Form_student : Form
    {
        Socket srSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        public Form_student()
        {
            
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ReceiveMessageType Message = new ReceiveMessageType
            {
                MessageType = MessageType.GetTest,
                Data = null
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
            if (receiveMessageType.MessageType == MessageType.GetTest)
            {
            
                MessageBox.Show("ok");
               
            }
        }
    }
}
