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
        }

        private void enter_Click(object sender, EventArgs e)
        {
            var LoginUser = loginbox.Text;
            var PassUser = passbox.Text;

            string query_string = $"insert into Users (Login_Users, Password_Users) values ('{LoginUser}', '{PassUser}')";

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

            String querystring = $"select * from Users where Login_Users = '{login_user}' and Password_Users = '{pass_user}'";

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
    }
}
