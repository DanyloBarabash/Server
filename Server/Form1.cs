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
using System.Threading;
using ToMakeConnection;


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
            connection.ConnectionString = ConfigurationManager.ConnectionStrings["DbConnection"].ConnectionString;
            connection.Open();



            listenSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPHostEntry iPHost = Dns.GetHostEntry("localhost");
            IPAddress iPAddress = iPHost.AddressList[1];
            int port = 20000;

            IPEndPoint iPEndPoint = new IPEndPoint(iPAddress, port);
           
        
            listenSocket.Bind(iPEndPoint); 
            listenSocket.Listen(5);
                  
                        new Thread(() =>
                        { 
                        try { 
                            while (true)
                            {
                                Socket clientSocket=  listenSocket.Accept();
                                Info info = new Info() { RemoteEndPoint = clientSocket.RemoteEndPoint.ToString(), clientSocket = clientSocket };
                                ReceiveClientMessage(clientSocket);
                            } 
                            }
                            catch  {}
                        }).Start();



            MessageBox.Show("Server is working");
         }
        
        private void ReceiveClientMessage(Socket clientSocket)
        {
            Byte[] receivemessage = new Byte[2024];
            do
            {
                int bytes = clientSocket.Receive(receivemessage);
            }
            while (clientSocket.Available > 0);

            var receiveMasageType = Serialization.FromByteArray<ReceiveMessageType>(receivemessage);

            Answer(clientSocket, receiveMasageType);
        }

        private void Answer(Socket clientSocket, ReceiveMessageType receiveMasageType)
        {
            try
            {

                command = new SqlCommand();
                switch (receiveMasageType.MessageType)
                {
                    case MessageType.Login:
                        {
                            Logins logins = (Logins)receiveMasageType.Data;
                            command = new SqlCommand();
                            command.Connection = connection;
                            command.CommandText = $"SELECT Id FROM Authorizations WHERE [Login]= '{logins.Login}' AND [Password]='{logins.Password}'";
                            SqlDataReader dataReader = command.ExecuteReader();
                            if (dataReader.HasRows)
                            {
                                int id = 0;
                                while (dataReader.Read())
                                {
                                    id = dataReader.GetInt32(0);
                                }
                                dataReader.Close();
                                command.CommandText = $"SELECT * FROM Teachers WHERE AuthorizationId='{id}'";
                                dataReader = command.ExecuteReader();
                                if (dataReader.HasRows)
                                {
                                    Teacher teacher = null;
                                    while (dataReader.Read())
                                    {


                                        teacher = new Teacher
                                        {
                                            Id = dataReader.GetInt32(0),
                                            First_Name = dataReader.GetString(1),
                                            Second_Name = dataReader.GetString(2),
                                            Test_Id = dataReader.GetInt32(4)
                                        };
                                    }
                                    SendResponse(clientSocket, MessageType.GetTeacher, teacher);
                                }
                                else
                                {
                                    while (dataReader.Read())
                                    {
                                        id = dataReader.GetInt32(0);
                                    }
                                    dataReader.Close();
                                    command.CommandText = $"SELECT * FROM Students WHERE AuthorizationId='{id}'";
                                    dataReader = command.ExecuteReader();
                                    Student student = null;
                                    while (dataReader.Read())
                                    {
                                        student = new Student
                                        {

                                            Id = dataReader.GetInt32(0),
                                            First_Name = dataReader.GetString(1),
                                            Second_Name = dataReader.GetString(2),
                                            Group_Id = dataReader.GetInt32(4)
                                        };

                                    }
                                    dataReader.Close();
                                    SendResponse(clientSocket, MessageType.GetStudent, student);
                                }
                            }


                            else
                            {
                                dataReader.Close();
                                SendResponse(clientSocket, MessageType.Error, "Invalid Login or Password");

                            }
                            break;
                        }
                }
            }
            catch(Exception e)
            {
                SendResponse(clientSocket, MessageType.Error, $"Respond Error: {e.Message}");
            }
            finally
            {
                clientSocket.Shutdown(SocketShutdown.Both);
                clientSocket.Close();
            }
        }

        private void SendResponse(Socket clientSocket, MessageType messageType, object data)
        {
            clientSocket.Send(Serialization.ToByteArray(new ReceiveMessageType()
            {
                MessageType = messageType,
                Data = data

            }));
        }

        private void stop_server_Click(object sender, EventArgs e)
        {
            
           
            listenSocket.Close();
            connection.Close();
            MessageBox.Show("Server stoped");
            //foreach (var process in System.Diagnostics.Process.GetProcessesByName("Server"))
            //{
            //    process.Kill();
            //}


        }
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            foreach (var process in System.Diagnostics.Process.GetProcessesByName("Server"))
            {
                process.Kill();
            }
        }


    }
}
