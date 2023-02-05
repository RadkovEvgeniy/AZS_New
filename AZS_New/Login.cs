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
            enter.Enabled = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            button1.Visible = false;
        }

        private int count;
        int i = 30; //Длительность таймера

        private void enter_Click(object sender, EventArgs e)
        {
            var LoginUser = loginbox.Text;
            var PassUser = passbox.Text;

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            String querystring = $"select Login_Users, Password_Users, Surname, Secret_words from Users where Login_Users = '{LoginUser}' and Password_Users = '{PassUser}'";

            SqlCommand command = new SqlCommand(querystring, DataBase.getConnection());
            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count == 1)
            {
                MessageBox.Show("Вход выполнен успешно");
                Hello hello = new Hello();
                this.Hide();
                hello.ShowDialog();
                loginbox.Text = "";
                passbox.Text = "";
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль");

                if (count++ == 2) //Попытки входа
                {
                    passbox.Visible = false;
                    loginbox.Visible = false;
                    enter.Visible = false;
                    pictureBox1.Visible = false;
                    pictureBox2.Visible = false;
                    eyes1.Visible = false;
                    eyes2.Visible = false;
                    infobox.Visible = false;
                    create.Visible = false;
                    timer1.Tick += new EventHandler(timer1_Tick);
                    timer1.Interval = 1500;
                    timer1.Start();
                    label2.Visible = true;
                    label3.Visible = true;
                    label4.Visible = true;
                    label5.Visible = true;
                    button1.Visible = true;

                }
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            label5.Text = string.Format("{0}", i--);
            if (i == 0)
            {
                timer1.Stop();
                label2.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                label5.Visible = false;
                button1.Visible = false;
                passbox.Visible = true;
                loginbox.Visible = true;
                enter.Visible = true;
                pictureBox1.Visible = true;
                pictureBox2.Visible = true;
                eyes1.Visible = true;
                eyes2.Visible = true;
                infobox.Visible = true;
                create.Visible = true;
                loginbox.Text = "";
                passbox.Text = "";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Pass_lock pas = new Pass_lock();
            pas.ShowDialog();
        }
    }
}
