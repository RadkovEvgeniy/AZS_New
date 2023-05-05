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
    public partial class Pass_lock : Form
    {
        Database_connection DataBase = new Database_connection();

        public Pass_lock()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        int nmb = 0;

        private void captchaload()
        {
            Random rnd = new Random();
            nmb = rnd.Next(1000, 10000);
            var img = new Bitmap(this.captchapic.Width, this.captchapic.Height);
            var font = new Font("TimesNewRoman", 25, FontStyle.Strikeout, GraphicsUnit.Pixel);
            var graphics = Graphics.FromImage(img);
            graphics.DrawString(nmb.ToString(), font, Brushes.Red, new Point(0, 0));
            captchapic.Image = img;
        }

        private void Pass_lock_Load(object sender, EventArgs e)
        {
            passbox.PasswordChar = '*';
            captchaload();
            enter.Enabled = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Введите свой логин");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Придумайте новый пароль");
        }

        private void enter_Click(object sender, EventArgs e)
        {
            DataBase.OpenConnection();
            var login = loginbox.Text;
            var password = passbox.Text;

            var changequery = $"update Users set Password = '{password}' where Login = '{login}'";

            var command = new SqlCommand(changequery, DataBase.getConnection());

            if (command.ExecuteNonQuery() == 1 & captchabox.Text == nmb.ToString() )
            {
                MessageBox.Show("Вы успешно изменили пароль");
                Login hi = new Login();
                this.Hide();
                hi.ShowDialog();
                loginbox.Text = "";
                passbox.Text = "";
            }
            else
            {
                captchaload();
                MessageBox.Show("Произошла ошибка");
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

        private void resetbox_Click(object sender, EventArgs e)
        {
            captchaload();
        }

        private void infobox_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Все поля должны быть заполнены");
        }

        private void surnamebox_TextChanged(object sender, EventArgs e)
        {
            if (loginbox.Text.Length > 0 & passbox.Text.Length > 0 & captchabox.Text.Length > 0)
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
            if (loginbox.Text.Length > 0 & passbox.Text.Length > 0 & captchabox.Text.Length > 0)
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

        private void captchabox_TextChanged(object sender, EventArgs e)
        {
            if (loginbox.Text.Length > 0 & passbox.Text.Length > 0 & captchabox.Text.Length > 0)
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

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Подтвердите, что вы не робот");
        }

        private void surnamebox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (int)Keys.Space)
                e.KeyChar = '\0';
        }

        private void secretbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (int)Keys.Space)
                e.KeyChar = '\0';
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Для дополнительной информации нажмите на иконки возле полей");
        }
    }
}
