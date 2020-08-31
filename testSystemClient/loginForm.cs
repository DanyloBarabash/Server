using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Net.Sockets;
using System.Net;
using testSystemClient;
using ToMakeConnection;

namespace testSystemClient
{
    public partial class loginForm : Form
    {
         
        
        Socket srSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
       

        public loginForm()
        {
            InitializeComponent();

            this.passField.AutoSize = false;
            this.passField.Size = new Size(this.passField.Size.Width, 50);
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void closeButton_MouseEnter(object sender, EventArgs e)
        {
            closeButton.ForeColor = Color.Green;
        }

        private void closeButton_MouseLeave(object sender, EventArgs e)
        {
            closeButton.ForeColor = Color.White;
        }
        Point lastPoint;
        private void mainPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button==MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void mainPanel_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string loginUser = loginField.Text.ToString();
            string passUser = passField.Text.ToString();

            ReceiveMessageType Message = new ReceiveMessageType
            {
                MessageType = MessageType.Login,
                Data = new Logins()
                {
                    Login = loginUser,
                    Password = passUser
                }
            };
            IPHostEntry ipHost = Dns.GetHostEntry("localhost");
            IPAddress ipAddr = ipHost.AddressList[1];
            IPEndPoint ipEndPoint = new IPEndPoint(ipAddr,20000);
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

           ReceiveMessageType receiveMessageType= Serialization.FromByteArray<ReceiveMessageType>(data);
            if (receiveMessageType.MessageType == MessageType.Login)
            {
                MessageBox.Show("ok");
            }


            //DB db = new DB();

            //DataTable table = new DataTable();
            //table.Locale = System.Globalization.CultureInfo.InvariantCulture;
            //SqlDataAdapter adapter = new SqlDataAdapter();
           
            //SqlCommand command = new SqlCommand("SELECT * FROM UserInfoTable WHERE login = @uL AND pass = @uP", db.getConnection());
            //command.Parameters.Add("@uL", SqlDbType.VarChar).Value = loginUser;
            //command.Parameters.Add("@uP", SqlDbType.VarChar).Value = passUser;
            //adapter.SelectCommand = command;
            //adapter.Fill(table);

            //if (table.Rows.Count > 0)
            //{
            //    this.Hide();
            //    questionForm qf = new questionForm();
            //    qf.Show();
            //}
                

            else
                MessageBox.Show("No");
        }

        private void regAccount_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisterForm regForm = new RegisterForm();
            regForm.Show();
        }

        private void loginField_TextChanged(object sender, EventArgs e)
        {

        }
        private void SendResponse(Socket serverSocket,MessageType messageType, object data)
        {
            serverSocket.Send(Serialization.ToByteArray(new ReceiveMessageType()
            {
                MessageType = messageType,
                Data = data

            }));
        }
    }
}
