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
using System.Runtime.Serialization.Formatters.Binary;
using System.Data.SqlClient;
using System.Configuration;

namespace Server
{
    public partial class Form1 : Form
    {
        SqlConnection connection;
        Socket listenSocket;
        SqlCommand command;
        public Form1()
        {
            InitializeComponent();
        }

        private void start_server_Click(object sender, EventArgs e)
        {
            connection = new SqlConnection();
            connection.ConnectionString= ConfigurationManager.ConnectionStrings["DbConnection"].ConnectionString;

            

            listenSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPHostEntry iPHost = Dns.GetHostEntry("localhost");
            IPAddress iPAddress = iPHost.AddressList[1];
            int port = 8005;

            IPEndPoint iPEndPoint = new IPEndPoint(iPAddress, port);

            listenSocket.Bind(iPEndPoint);

            Task.Factory.StartNew(
                () => ListenThreat(listenSocket)
                );
        }
        private void ListenThreat(Socket listenSocket)
        {
            listenSocket.Listen(5);
            while (true)
            {
                Socket clientSocket=  listenSocket.Accept();
                Info info = new Info() { RemoteEndPoint = clientSocket.RemoteEndPoint.ToString(), clientSocket = clientSocket };

                Task.Factory.StartNew(
                    () =>ReceiveClientMessage(clientSocket)
                    );
            }
            
        }

        private void ReceiveClientMessage(Socket clientSocket)
        {
            while (true)
            {
                Byte[] receivemessage = new Byte[1024];
                Int32 nCount= clientSocket.Receive(receivemessage);
                
            }
        }

        private void stop_server_Click(object sender, EventArgs e)
        {
            listenSocket.Close();
            connection.Close();
            
        }

    
    }
}
