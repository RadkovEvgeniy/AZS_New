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
            sizeandlocation();
        }

        private void sizeandlocation()
        {
            StartPosition = FormStartPosition.CenterScreen;
            this.Size = new System.Drawing.Size(675, 740);
            label1.Location = new System.Drawing.Point(5, 73);
            panel2.Size = new System.Drawing.Size(738, 768);
            panel2.Location = new System.Drawing.Point(163, 179);
            loginbox.Size = new System.Drawing.Size(410, 50);
            loginbox.Location = new System.Drawing.Point(35, 83);
            passbox.Size = new System.Drawing.Size(410, 50);
            passbox.Location = new System.Drawing.Point(35, 271);
            enter.Size = new System.Drawing.Size(424, 65);
            enter.Location = new System.Drawing.Point(21, 425);
            pictureBox1.Size = new System.Drawing.Size(120, 120);
            pictureBox1.Location = new System.Drawing.Point(12, 224);
            pictureBox2.Size = new System.Drawing.Size(120, 120);
            pictureBox2.Location = new System.Drawing.Point(12, 410);
            eyes1.Size = new System.Drawing.Size(48, 48);
            eyes1.Location = new System.Drawing.Point(397, 271);
            eyes2.Size = new System.Drawing.Size(48, 48);
            eyes2.Location = new System.Drawing.Point(397, 271);
            infobox.Size = new System.Drawing.Size(45, 45);
            infobox.Location = new System.Drawing.Point(450, 435);
            backspace.Size = new System.Drawing.Size(52, 52);
            backspace.Location = new System.Drawing.Point(4, 13);
            pictureclose.Size = new System.Drawing.Size(52, 52);
            pictureclose.Location = new System.Drawing.Point(613, 13);
            iconButton1.Visible = false;
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

            string query_string = $"insert into Users (Login, Password, isAdmin) values ('{LoginUser}', '{PassUser}', 0)";

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

            String querystring = $"select Login, Password, isAdmin from Users where Login = '{login_user}' and Password = '{pass_user}'";

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
            MessageBox.Show("Введите логин");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Введите пароль");
        }

        private void loginbox_TextChanged(object sender, EventArgs e)
        {
            if(loginbox.Text.Length > 0 & passbox.Text.Length > 0)
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
            if(passbox.Text.Length > 0 & loginbox.Text.Length > 0)
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

        private void loginbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (int)Keys.Space)
                e.KeyChar = '\0';
        }

        private void passbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (int)Keys.Space)
                e.KeyChar = '\0';
        }

        private void pictureclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
