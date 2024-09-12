using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace DataBase_test_
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();

            loginField.ForeColor = Color.White;
            passField.ForeColor = Color.White;

            userNameField.Text = "Name";
            userNameField.ForeColor = Color.White;
            userSurNameField.Text = "Surname";
            userSurNameField.ForeColor = Color.White;

        }



        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        Point point;
        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - point.X;
                this.Top += e.Y - point.Y;

            }
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            point = new Point(e.X, e.Y);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - point.X;
                this.Top += e.Y - point.Y;

            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            point = new Point(e.X, e.Y);
        }

        private void userNameField_Enter(object sender, EventArgs e)
        {
            if (userNameField.Text == "Name")
            {
                userNameField.Text = "";
            }
        }

        private void userSurNameField_Enter(object sender, EventArgs e)
        {
            if (userSurNameField.Text == "Surname")
            {
                userSurNameField.Text = "";
            }

        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (loginField.Text == "")
            {
                MessageBox.Show("You must do login");
                return;
            }
            if (passField.Text == "")
            {
                MessageBox.Show("You must do password");
                return;
            }
            if (userNameField.Text == "Name")
            {
                MessageBox.Show("Write your Name");
                return;
            }
            if (userSurNameField.Text == "Surname")
            {
                MessageBox.Show("Write your SurName");
                return;
            }
   
            if(checkUser())
            {
                return;
            }

            DataBase db = new DataBase();
            MySqlCommand command = new MySqlCommand("INSERT INTO `users` ( `login`, `pass`, `name`, `surname`) VALUES (@login,@pass,@name,@surname)", db.getConnection());

            command.Parameters.Add("@login",MySqlDbType.VarChar).Value = loginField.Text;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = passField.Text;
            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = userNameField.Text;
            command.Parameters.Add("@surname", MySqlDbType.VarChar).Value = userSurNameField.Text;


            db.openConnection();

            if(command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("вы успешно зарегестрировались");
            }
            else
            {
               MessageBox.Show("error");
            }

            db.closeConnection();
        }

        public Boolean checkUser()
        {
            DataBase db = new DataBase();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @uL ", db.getConnection());
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginField.Text;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("change your login");
                return true;
            }
            else
            {
                return false;
            }
        }

        private void registerLable_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForms loginForm = new LoginForms();
            loginForm.Show();
        }
    }
}
