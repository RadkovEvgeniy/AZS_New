using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AZS_New
{
    public partial class Hello : Form
    {
        private readonly checkUser _user;

        public Hello(checkUser user)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            this.Size = new System.Drawing.Size(1335, 727);
            _user = user;
            label1.Text = $"Добро пожаловать " +
                $"{_user.Login}!";
        }

        private void Hello_Load(object sender, EventArgs e)
        {
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Interval = 500;
            timer1.Start();
        }

        int i = 20;

        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = string.Format("", i--);
            if (i == 0)
            {
                timer1.Stop();
                Main_form main = new Main_form(_user);
                this.Hide();
                main.ShowDialog();
            }
        }
    }
}
