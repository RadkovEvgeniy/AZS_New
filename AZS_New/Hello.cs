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
        public Hello()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
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
            label3.Text = string.Format("", i--);
            if (i == 0)
            {
                timer1.Stop();
                Main_Form main = new Main_Form();
                this.Hide();
                main.ShowDialog();
            }
        }
    }
}
