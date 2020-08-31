using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testSystemClient
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();

            userNameField.Text = "Enter Name";
            userNameField.ForeColor = Color.Gray;
            userSurnameField.Text = "Enter Surname";
            userSurnameField.ForeColor = Color.Gray;
            loginField.Text = "Enter Login";
            loginField.ForeColor = Color.Gray;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        Point lastPoint;
        private void mainPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void mainPanel_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void userNameField_Enter(object sender, EventArgs e)
        {
            if (userNameField.Text == "Enter Name")
            {
                userNameField.Text = "";
                userNameField.ForeColor = Color.Black;
            }
        }

        private void userNameField_Leave(object sender, EventArgs e)
        {
            if (userNameField.Text == "")
            {
                userNameField.Text = "Enter Name";
                userNameField.ForeColor = Color.Gray;
            }
        }
        private void userSurnameField_Enter(object sender, EventArgs e)
        {
            if (userSurnameField.Text == "Enter Surname")
            {
                userSurnameField.Text = "";
                userSurnameField.ForeColor = Color.Black;
            }
        }

        private void userSurnameField_Leave(object sender, EventArgs e)
        {
            if (userSurnameField.Text == "")
            {
                userSurnameField.Text = "Enter Surname";
                userSurnameField.ForeColor = Color.Gray;
            }
        }

        private void loginField_Enter(object sender, EventArgs e)
        {
            if (loginField.Text == "Enter Login")
            {
                loginField.Text = "";
                loginField.ForeColor = Color.Black;
            }
        }

        private void loginField_Leave(object sender, EventArgs e)
        {
            if (loginField.Text == "")
            {
                loginField.Text = "Enter Login";
                loginField.ForeColor = Color.Gray;
            }
        }

        private void regButtonClick_Click(object sender, EventArgs e)
        {
            if(userNameField.Text=="Enter Name")
            {
                MessageBox.Show("Enter Name");
                return;
            }

            if (ifUserExist())
                return;

            DB db = new DB();
            SqlCommand command = new SqlCommand("INSERT INTO UserInfoTable (id, login, pass, name, surname) VALUES (@id, @login, @pass, @name, @surname)",db.getConnection());

            command.Parameters.Add("@id", SqlDbType.VarChar).Value = 2;
            command.Parameters.Add("@login",SqlDbType.VarChar).Value = loginField.Text;
            command.Parameters.Add("@pass", SqlDbType.VarChar).Value = passField.Text;
            command.Parameters.Add("@name", SqlDbType.VarChar).Value = userNameField.Text;
            command.Parameters.Add("@surname", SqlDbType.VarChar).Value = userSurnameField.Text;

            db.openConnection();

            if (command.ExecuteNonQuery() == 1)
                MessageBox.Show("Account was created.");
            else
                MessageBox.Show("Account was not created.");

            db.closeConnection();
        }
        public Boolean ifUserExist()
        {
            DB db = new DB();

            DataTable table = new DataTable();
            table.Locale = System.Globalization.CultureInfo.InvariantCulture;
            SqlDataAdapter adapter = new SqlDataAdapter();

            SqlCommand command = new SqlCommand("SELECT * FROM UserInfoTable WHERE login = @uL", db.getConnection());
            command.Parameters.Add("@uL", SqlDbType.VarChar).Value = loginField.Text;
            
            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("This login already exist!");
                return true;
            }
            else
                return false;
        }

        private void regAccount_Click(object sender, EventArgs e)
        {
            this.Hide();
            loginForm logForm = new loginForm();
            logForm.Show();
        }

        

        private void label1_MouseDown(object sender, MouseEventArgs e)
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
    }
}
