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
    public partial class Login : Form
    {
        Database_connection DataBase = new Database_connection();

        public Login()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void Login_Load(object sender, EventArgs e)
        {
            passbox.PasswordChar = '*';
            eyes1.Visible = false;
        }

        private void enter_Click(object sender, EventArgs e)
        {
            var LoginUser = loginbox.Text;
            var PassUser = passbox.Text;

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            String querystring = $"select Login_Users, Password_Users from Users where Login_Users = '{LoginUser}' and Password_Users = '{PassUser}'";

            SqlCommand command = new SqlCommand(querystring, DataBase.getConnection());
            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count == 1)
            {
                MessageBox.Show("Вход выполнен успешно");
                Main_Form db = new Main_Form();
                this.Hide();
                db.ShowDialog();
                this.Show();
                loginbox.Text = "";
                passbox.Text = "";
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль");
            }
        }

        private void create_Click(object sender, EventArgs e)
        {
            Registration reg = new Registration();
            this.Hide();
            reg.ShowDialog();
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
    }
}
