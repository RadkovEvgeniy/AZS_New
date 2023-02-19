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
            secretbox.PasswordChar = '*';
            captchaload();
            enter.Enabled = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Введите свою Фамилию");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Введите секретное слово");
        }

        private void enter_Click(object sender, EventArgs e)
        {
            var SurnameUser = surnamebox.Text;
            var SecretUser = secretbox.Text;

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            String querystring = $"select Login_Users, Password_Users, Surname, Secret_words from Users where Surname = '{SurnameUser}' and Secret_words = '{SecretUser}'";

            SqlCommand command = new SqlCommand(querystring, DataBase.getConnection());
            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count == 1 & captchabox.Text == nmb.ToString() )
            {
                MessageBox.Show("Вход выполнен успешно");
                Hello hi = new Hello();
                this.Hide();
                hi.ShowDialog();
                surnamebox.Text = "";
                secretbox.Text = "";
            }
            else
            {
                captchaload();
                MessageBox.Show("Неверные данные");
            }
        }

        private void eyes1_Click(object sender, EventArgs e)
        {
            secretbox.UseSystemPasswordChar = false;
            eyes1.Visible = false;
            eyes2.Visible = true;
        }

        private void eyes2_Click(object sender, EventArgs e)
        {
            secretbox.UseSystemPasswordChar = true;
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
            if (surnamebox.Text.Length > 0 & secretbox.Text.Length > 0 & captchabox.Text.Length > 0)
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
            if (surnamebox.Text.Length > 0 & secretbox.Text.Length > 0 & captchabox.Text.Length > 0)
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
            if (surnamebox.Text.Length > 0 & secretbox.Text.Length > 0 & captchabox.Text.Length > 0)
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
    }
}
