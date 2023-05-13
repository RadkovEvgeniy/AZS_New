using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using System.Data.SqlClient;

namespace AZS_New
{
    public partial class Main_form : Form
    {
        Database_connection DataBase = new Database_connection();

        private readonly checkUser _user;

        private IconButton currentBtn;
        private Panel leftborderBtn;

        public Main_form(checkUser user)
        {
            InitializeComponent();
            sizeandlocation();
            visisbleelements();
            _user = user;
            IsAdmin();
            label1.Text = $"{_user.Login} ({_user.Status})";
            leftborderBtn = new Panel();
            leftborderBtn.Size = new Size(10, 85);
            panelleft.Controls.Add(leftborderBtn);
            iconPictureBox1.IconChar = IconChar.Home;
            createcolumnsAdmin();
            refreshdatagridAdmin(dataGridView3);
        }

        private void visisbleelements()
        {
            homePanel.Visible = true;
            salePanel.Visible = false;
            typePanel.Visible = false;
            managementPanel.Visible = false;
            pictureplus1.Visible = true;
            pictureplus2.Visible = false;
            pictureplus3.Visible = false;
            pictureplus4.Visible = false;
            pictureminus1.Visible = false;
            pictureminus2.Visible = false;
            pictureminus3.Visible = false;
            pictureminus4.Visible = false;
            comboBox1.Visible = true;
            comboBox2.Visible = false;
            comboBox3.Visible = false;
            comboBox4.Visible = false;
            comboBox5.Visible = false;
            numericUpDown1.Visible = true;
            numericUpDown2.Visible = false;
            numericUpDown3.Visible = false;
            numericUpDown4.Visible = false;
            numericUpDown5.Visible = false;
            textcost1.Visible = true;
            textcost2.Visible = false;
            textcost3.Visible = false;
            textcost4.Visible = false;
            textcost5.Visible = false;
        }
        
        private void sizeandlocation()
        {
            this.Size = new System.Drawing.Size(1615, 1000);
            panelleft.Size = new System.Drawing.Size(330, 944);
            paneltop.Size = new System.Drawing.Size(330, 200);
            paneltitle.Size = new System.Drawing.Size(1263, 120);
            panellogin.Size = new System.Drawing.Size(1253, 74);
            saleButton.Size = new System.Drawing.Size(330, 85);
            typeButton.Size = new System.Drawing.Size(330, 85);
            managementButton.Size = new System.Drawing.Size(330, 85);
            exitButton.Size = new System.Drawing.Size(330, 85);
            iconPictureBox1.Size = new System.Drawing.Size(45, 45);
            iconPictureBox1.IconSize = 45;
            iconPictureBox1.Location = new System.Drawing.Point(6, 0);
            label2.Location = new System.Drawing.Point(62, 0);
            dataGridView3.Size = new System.Drawing.Size(696, 415);
            dataGridView3.Location = new System.Drawing.Point(133, 80);
            saveButton3.Size = new System.Drawing.Size(291, 65);
            saveButton3.Location = new System.Drawing.Point(133, 730);
            deleteButton3.Size = new System.Drawing.Size(291, 65);
            deleteButton3.Location = new System.Drawing.Point(538, 730);
            label_name_t.Location = new System.Drawing.Point(34, 50);
            label_quantity.Location = new System.Drawing.Point(342, 50);
            labelcost.Location = new System.Drawing.Point(552, 50);
            comboBox1.Size = new System.Drawing.Size(273, 39);
            comboBox1.Location = new System.Drawing.Point(39, 80);
            comboBox2.Size = new System.Drawing.Size(273, 35);
            comboBox2.Location = new System.Drawing.Point(39, 121);
            comboBox3.Size = new System.Drawing.Size(273, 35);
            comboBox3.Location = new System.Drawing.Point(39, 162);
            comboBox4.Size = new System.Drawing.Size(273, 35);
            comboBox4.Location = new System.Drawing.Point(39, 203);
            comboBox5.Size = new System.Drawing.Size(273, 35);
            comboBox5.Location = new System.Drawing.Point(39, 244);
            numericUpDown1.Size = new System.Drawing.Size(175, 35);
            numericUpDown1.Location = new System.Drawing.Point(347, 80);
            numericUpDown2.Size = new System.Drawing.Size(175, 35);
            numericUpDown2.Location = new System.Drawing.Point(347, 121);
            numericUpDown3.Size = new System.Drawing.Size(175, 35);
            numericUpDown3.Location = new System.Drawing.Point(347, 162);
            numericUpDown4.Size = new System.Drawing.Size(175, 35);
            numericUpDown4.Location = new System.Drawing.Point(347, 203);
            numericUpDown5.Size = new System.Drawing.Size(175, 35);
            numericUpDown5.Location = new System.Drawing.Point(347, 244);
            textcost1.Size = new System.Drawing.Size(119, 35);
            textcost1.Location = new System.Drawing.Point(557, 80);
            textcost2.Size = new System.Drawing.Size(119, 35);
            textcost2.Location = new System.Drawing.Point(557, 120);
            textcost3.Size = new System.Drawing.Size(119, 35);
            textcost3.Location = new System.Drawing.Point(557, 161);
            textcost4.Size = new System.Drawing.Size(119, 35);
            textcost4.Location = new System.Drawing.Point(557, 202);
            textcost5.Size = new System.Drawing.Size(119, 35);
            textcost5.Location = new System.Drawing.Point(557, 243);
            pictureplus1.Size = new System.Drawing.Size(39, 39);
            pictureplus1.Location = new System.Drawing.Point(39, 121);
            pictureplus2.Size = new System.Drawing.Size(39, 39);
            pictureplus2.Location = new System.Drawing.Point(39, 162);
            pictureplus3.Size = new System.Drawing.Size(39, 39);
            pictureplus3.Location = new System.Drawing.Point(39, 203);
            pictureplus4.Size = new System.Drawing.Size(39, 39);
            pictureplus4.Location = new System.Drawing.Point(39, 244);
            pictureminus1.Size = new System.Drawing.Size(39, 39);
            pictureminus1.Location = new System.Drawing.Point(682, 117);
            pictureminus2.Size = new System.Drawing.Size(39, 39);
            pictureminus2.Location = new System.Drawing.Point(682, 158);
            pictureminus3.Size = new System.Drawing.Size(39, 39);
            pictureminus3.Location = new System.Drawing.Point(682, 199);
            pictureminus4.Size = new System.Drawing.Size(39, 39);
            pictureminus4.Location = new System.Drawing.Point(682, 240);
            homePanel.Dock = DockStyle.Fill;
            salePanel.Dock = DockStyle.Fill;
            typePanel.Dock = DockStyle.Fill;
            managementPanel.Dock = DockStyle.Fill;
        }

        private struct RGBColors
        {
            public static Color color = Color.FromArgb(255, 248, 200);
        }

        private void ActivateButton(object senderBtn, Color color)
        {
            if(senderBtn != null)
            {
                DisableButton();                                                 
                                                                                 
                currentBtn = (IconButton)senderBtn;                              
                currentBtn.BackColor = Color.FromArgb(5, 152, 169);              
                currentBtn.ForeColor = color;    
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;            
                currentBtn.IconColor = color;                                    
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;            

                leftborderBtn.BackColor = color;
                leftborderBtn.Location = new Point(0,currentBtn.Location.Y);
                leftborderBtn.Visible = true;
                leftborderBtn.BringToFront();
            }
        }

        private void DisableButton()
        {
            if(currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(6, 196, 175);
                currentBtn.ForeColor = Color.Black;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Black;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void IsAdmin()
        {
            managementButton.Enabled = _user.IsAdmin;
        }

        private void createcolumnsAdmin()
        {
            dataGridView3.Columns.Add("ID", "Номер пользователя");
            dataGridView3.Columns.Add("Login", "Логин");
            dataGridView3.Columns.Add("Password", "Пароль");
            var checkColumn = new DataGridViewCheckBoxColumn();
            checkColumn.HeaderText = "Доступ администратора";
            dataGridView3.Columns.Add(checkColumn);
            dataGridView3.Columns[0].Width = 140;
            dataGridView3.Columns[1].Width = 130;
            dataGridView3.Columns[2].Width = 130;
            dataGridView3.Columns[3].Width = 170;
        }

        private void readsinglerowAdmin(DataGridView dgw, IDataRecord rec)
        {
            dgw.Rows.Add(rec.GetInt32(0), rec.GetString(1), rec.GetString(2), rec.GetBoolean(3));
        }

        private void refreshdatagridAdmin(DataGridView dgw)
        {
            dgw.Rows.Clear();

            string query = $"select * from Users";

            SqlCommand com = new SqlCommand(query, DataBase.getConnection());

            DataBase.OpenConnection();

            SqlDataReader read = com.ExecuteReader();

            while (read.Read())
            {
                readsinglerowAdmin(dgw, read);
            }
            read.Close();
            DataBase.CloseConnection();
        }

        private void saleButton_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color);
            iconPictureBox1.IconChar = IconChar.CashRegister;
            label2.Text = "Продажа топлива";
            homePanel.Visible = false;
            salePanel.Visible = true;
            typePanel.Visible = false;
            managementPanel.Visible = false;
        }

        private void typeButton_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color);
            iconPictureBox1.IconChar = IconChar.DollyFlatbed;
            label2.Text = "Учет топлива";
            homePanel.Visible = false;
            salePanel.Visible = false;
            typePanel.Visible = true;
            managementPanel.Visible = false;
        }

        private void managementButton_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color);
            iconPictureBox1.IconChar = IconChar.ListCheck;
            label2.Text = "Управление";
            homePanel.Visible = false;
            salePanel.Visible = false;
            typePanel.Visible = false;
            managementPanel.Visible = true;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color);
            Login login = new Login();
            this.Hide();
            login.ShowDialog();
        }

        private void saveButton3_Click(object sender, EventArgs e)
        {
            DataBase.OpenConnection();

            for (int index = 0; index < dataGridView3.Rows.Count; index++)
            {
                var id = dataGridView3.Rows[index].Cells[0].Value.ToString();
                var isAdmin = dataGridView3.Rows[index].Cells[3].Value.ToString();

                var query = $"update Users set isAdmin = '{isAdmin}' where ID = '{id}'";

                var command = new SqlCommand(query, DataBase.getConnection());
                command.ExecuteNonQuery();
            }
            DataBase.CloseConnection();
            refreshdatagridAdmin(dataGridView3);
        }

        private void deleteButton3_Click(object sender, EventArgs e)
        {
            DataBase.OpenConnection();

            var selectedrowindex = dataGridView3.CurrentCell.RowIndex;
            var id = Convert.ToInt32(dataGridView3.Rows[selectedrowindex].Cells[0].Value);

            var query = $"delete from User where ID = '{id}'";

            var command = new SqlCommand(query, DataBase.getConnection());
            command.ExecuteNonQuery();

            DataBase.CloseConnection();
            refreshdatagridAdmin(dataGridView3);
        }

        private void pictureplus1_Click(object sender, EventArgs e)
        {
            pictureplus1.Visible = false;
            pictureplus2.Visible = true;
            pictureminus1.Visible = true;
            comboBox2.Visible = true;
            numericUpDown2.Visible = true;
            textcost2.Visible = true;
        }

        private void pictureplus2_Click(object sender, EventArgs e)
        {
            pictureplus2.Visible = false;
            pictureplus3.Visible = true;
            pictureminus1.Visible = false;
            pictureminus2.Visible = true;
            comboBox3.Visible = true;
            numericUpDown3.Visible = true;
            textcost3.Visible = true;
        }

        private void pictureplus3_Click(object sender, EventArgs e)
        {
            pictureplus3.Visible = false;
            pictureplus4.Visible = true;
            pictureminus2.Visible = false;
            pictureminus3.Visible = true;
            comboBox4.Visible = true;
            numericUpDown4.Visible = true;
            textcost4.Visible = true;
        }

        private void pictureplus4_Click(object sender, EventArgs e)
        {
            pictureplus4.Visible = false;
            comboBox5.Visible = true;
            pictureminus3.Visible = false;
            pictureminus4.Visible = true;
            numericUpDown5.Visible = true;
            textcost5.Visible = true;
        }

        private void pictureminus1_Click(object sender, EventArgs e)
        {
            pictureminus1.Visible = false;
            pictureplus2.Visible = false;
            comboBox2.Visible = false;
            numericUpDown2.Visible = false;
            textcost2.Visible = false;
            pictureplus1.Visible = true;
        }

        private void pictureminus2_Click(object sender, EventArgs e)
        {
            pictureminus2.Visible = false;
            pictureplus3.Visible = false;
            comboBox3.Visible = false;
            numericUpDown3.Visible = false;
            textcost3.Visible = false;
            pictureplus2.Visible = true;
            pictureminus1.Visible = true;
        }

        private void pictureminus3_Click(object sender, EventArgs e)
        {
            pictureminus3.Visible = false;
            pictureplus4.Visible = false;
            comboBox4.Visible = false;
            numericUpDown4.Visible = false;
            textcost4.Visible = false;
            pictureplus3.Visible = true;
            pictureminus2.Visible = true;
        }

        private void pictureminus4_Click(object sender, EventArgs e)
        {
            pictureminus4.Visible = false;
            comboBox5.Visible = false;
            numericUpDown5.Visible = false;
            textcost5.Visible = false;
            pictureplus4.Visible = true;
            pictureminus3.Visible = true;
        }
    }
}
