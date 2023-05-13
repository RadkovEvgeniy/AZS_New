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
            sizeandlocation();
        }

        private void sizeandlocation()
        {
            StartPosition = FormStartPosition.CenterScreen;
            this.Size = new System.Drawing.Size(778, 881);
            label1.Location = new System.Drawing.Point(5, 72);
            panel2.Size = new System.Drawing.Size(593, 646);
            panel2.Location = new System.Drawing.Point(163, 179);
            loginbox.Size = new System.Drawing.Size(410, 50);
            loginbox.Location = new System.Drawing.Point(93, 53);
            passbox.Size = new System.Drawing.Size(410, 50);
            passbox.Location = new System.Drawing.Point(93, 177);
            captchabox.Size = new System.Drawing.Size(410, 50);
            captchabox.Location = new System.Drawing.Point(93, 416);
            enter.Size = new System.Drawing.Size(346, 63);
            enter.Location = new System.Drawing.Point(93, 535);
            resetbox.Size = new System.Drawing.Size(176, 81);
            resetbox.Location = new System.Drawing.Point(327, 288);
            captchapic.Size = new System.Drawing.Size(194, 62);
            captchapic.Location = new System.Drawing.Point(93, 307);
            eyes1.Size = new System.Drawing.Size(48, 48);
            eyes1.Location = new System.Drawing.Point(455, 177);
            eyes2.Size = new System.Drawing.Size(48, 48);
            eyes2.Location = new System.Drawing.Point(455, 177);
            pictureBox1.Size = new System.Drawing.Size(120, 120);
            pictureBox1.Location = new System.Drawing.Point(12, 191);
            pictureBox2.Size = new System.Drawing.Size(120, 120);
            pictureBox2.Location = new System.Drawing.Point(12, 320);
            pictureBox3.Size = new System.Drawing.Size(120, 120);
            pictureBox3.Location = new System.Drawing.Point(12, 501);
            infobox.Size = new System.Drawing.Size(45, 45);
            infobox.Location = new System.Drawing.Point(445, 544);
            iconButton1.Visible = false;
        }

        int nmb = 0;

        private void captchaload()
        {
            Random rnd = new Random();
            nmb = rnd.Next(1000, 10000);
            var img = new Bitmap(this.captchapic.Width, this.captchapic.Height);
            var font = new Font("CourierNew", 42, FontStyle.Strikeout, GraphicsUnit.Pixel);
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
    }
}
