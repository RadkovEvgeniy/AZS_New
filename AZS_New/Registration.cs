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

namespace AZS_New
{
    public partial class Registration : Form
    {
        Database_connection DataBase = new Database_connection();

        public Registration()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void Registration_Load(object sender, EventArgs e)
        {
            passbox.PasswordChar = '*';
            eyes1.Visible = false;
            enter.Enabled = false;
        }

        private void enter_Click(object sender, EventArgs e)
        {
            var LoginUser = loginbox.Text;
            var PassUser = passbox.Text;
            var SurnameUser = surnamebox.Text;
            var SecretUser = secretbox.Text;

            string query_string = $"insert into Users (Login_Users, Password_Users, Surname, Secret_words) values ('{LoginUser}', '{PassUser}', '{SurnameUser}', '{SecretUser}')";

            SqlCommand command = new SqlCommand(query_string, DataBase.getConnection());

            DataBase.OpenConnection();

            if (check_reg())

            {
                return;
            }
            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Регистрация выполнена успешно");
                Login log_in = new Login();
                this.Hide();
                log_in.ShowDialog();
            }
            else
            {
                MessageBox.Show("Произошла ошибка");
            }
        }

        private Boolean check_reg()
        {
            var login_user = loginbox.Text;
            var pass_user = passbox.Text;

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            String querystring = $"select Login_Users, Password_Users, Surname, Secret_words from Users where Login_Users = '{login_user}' and Password_Users = '{pass_user}'";

            SqlCommand command = new SqlCommand(querystring, DataBase.getConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Такой аккаунт уже существует");
                return true;
            }
            else
            {
                return false;
            }

        }

        private void eyes1_Click(object sender, EventArgs e)
        {
            passbox.UseSystemPasswordChar = false;
            eyes1.Visible = false;
            eyes2.Visible = true;
        }

        private void eyes2_Click(object sender, EventArgs e)
        {
            passbox.UseSystemPasswordChar = true;
            eyes1.Visible = true;
            eyes2.Visible = false;
        }

        private void backspace_Click(object sender, EventArgs e)
        {
            Login log_in = new Login();
            this.Hide();
            log_in.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Введите логин и свою фамилию");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Введите пароль и секретное слово. Оно понадобится для восстановления доступа");
        }

        private void loginbox_TextChanged(object sender, EventArgs e)
        {
            if(loginbox.Text.Length > 0 & passbox.Text.Length > 0 & surnamebox.Text.Length > 0 & secretbox.Text.Length > 0)
            {
                enter.Enabled = true;
                infobox.Visible = false;
            }
            else
            {
                enter.Enabled = false;
                infobox.Visible = true;
            }
        }

        private void surnamebox_TextChanged(object sender, EventArgs e)
        {
            if(surnamebox.Text.Length > 0 & passbox.Text.Length > 0 & loginbox.Text.Length > 0 & secretbox.Text.Length > 0)
            {
                enter.Enabled = true;
                infobox.Visible = false;
            }
            else
            {
                enter.Enabled = false;
                infobox.Visible = true;
            }
        }

        private void passbox_TextChanged(object sender, EventArgs e)
        {
            if(passbox.Text.Length > 0 & loginbox.Text.Length > 0 & surnamebox.Text.Length > 0 & secretbox.Text.Length > 0)
            {
                enter.Enabled = true;
                infobox.Visible = false;
            }
            else
            {
                enter.Enabled = false;
                infobox.Visible = true;
            }
        }

        private void secretbox_TextChanged(object sender, EventArgs e)
        {
            if(secretbox.Text.Length > 0 & loginbox.Text.Length > 0 & passbox.Text.Length > 0 & surnamebox.Text.Length > 0)
            {
                enter.Enabled = true;
                infobox.Visible = false;
            }
            else
            {
                enter.Enabled = false;
                infobox.Visible = true;
            }
        }

        private void infobox_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Все поля должны быть заполнены");
        }
    }
}
