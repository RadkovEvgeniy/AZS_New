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
            sizeandlocation();
        }

        private void sizeandlocation()
        {
            StartPosition = FormStartPosition.CenterScreen;
            this.Size = new System.Drawing.Size(675, 740);
            panel2.Size = new System.Drawing.Size(738, 768);
            panel2.Location = new System.Drawing.Point(163, 179);
            loginbox.Size = new System.Drawing.Size(410, 50);
            loginbox.Location = new System.Drawing.Point(35, 83);
            passbox.Size = new System.Drawing.Size(410, 50);
            passbox.Location = new System.Drawing.Point(35, 271);
            enter.Size = new System.Drawing.Size(346, 63);
            enter.Location = new System.Drawing.Point(35, 425);
            pictureBox1.Size = new System.Drawing.Size(120, 120);
            pictureBox1.Location = new System.Drawing.Point(12, 224);
            pictureBox2.Size = new System.Drawing.Size(120, 120);
            pictureBox2.Location = new System.Drawing.Point(12, 410);
            eyes1.Size = new System.Drawing.Size(48, 48);
            eyes1.Location = new System.Drawing.Point(396, 271);
            eyes2.Size = new System.Drawing.Size(48, 48);
            eyes2.Location = new System.Drawing.Point(396, 271);
            infobox.Size = new System.Drawing.Size(45, 45);
            infobox.Location = new System.Drawing.Point(387, 434);
            resetpass.Size = new System.Drawing.Size(346, 52);
            resetpass.Location = new System.Drawing.Point(35, 494);
            create.Size = new System.Drawing.Size(346, 52);
            create.Location = new System.Drawing.Point(35, 494);
            label1.Location = new System.Drawing.Point(5, 73);
            label2.Location = new System.Drawing.Point(3, 20);
            label3.Location = new System.Drawing.Point(3, 136);
            label4.Location = new System.Drawing.Point(3, 175);
            label5.Location = new System.Drawing.Point(158, 175);
            pictureclose.Size = new System.Drawing.Size(52, 52);
            pictureclose.Location = new System.Drawing.Point(613, 13);
            iconButton1.Visible = false;
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
            resetpass.Visible = false;
        }

        private int count;
        int i = 30; //Длительность таймера

        private void enter_Click(object sender, EventArgs e)
        {
            var LoginUser = loginbox.Text;
            var PassUser = passbox.Text;

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            String querystring = $"select Login, Password, isAdmin from Users where Login = '{LoginUser}' and Password = '{PassUser}'";

            SqlCommand command = new SqlCommand(querystring, DataBase.getConnection());
            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count == 1)
            {
                var user = new checkUser(table.Rows[0].ItemArray[0].ToString(), Convert.ToBoolean(table.Rows[0].ItemArray[2]));

                MessageBox.Show("Вход выполнен успешно");
                Hello hello = new Hello(user);
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

            if (loginbox.Text.Length > 0 & passbox.Text.Length > 0)
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
                resetpass.Visible = true;
                passbox.Visible = true;
                loginbox.Visible = true;
                enter.Visible = true;
                pictureBox1.Visible = true;
                pictureBox2.Visible = true;
                eyes1.Visible = true;
                eyes2.Visible = true;
                infobox.Visible = true;
                loginbox.Text = "";
                passbox.Text = "";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Pass_lock pas = new Pass_lock();
            this.Hide();
            pas.ShowDialog();
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Введите логин");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Введите пароль");
        }

        private void pictureclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
