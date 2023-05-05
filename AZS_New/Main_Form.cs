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
    public partial class Main_form : Form
    {
        private readonly checkUser _user;

        public Main_form(checkUser user)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            _user = user;
            IsAdmin();
            label1.Text = $"{_user.Login} ({_user.Status})";
        }

        private void IsAdmin()
        {
            упрпавлениеToolStripMenuItem.Enabled = _user.IsAdmin;
        }

        private void упрпавлениеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Admin().Show();
        }
    }
}
