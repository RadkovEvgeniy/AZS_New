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
using System.Net;
using System.Net.Mail;

namespace AZS_New
{
    enum rowstate
    {
        Existed,
        New,
        Modified,
        ModifiedNew,
        Deleted
    }

    public partial class Main_form : Form
    {
        Database_connection DataBase = new Database_connection();

        DataTable type_of_fuel = new DataTable();

        int selectedrow;

        private static string file;

        private readonly checkUser _user;

        private IconButton currentBtn;
        private Panel leftborderBtn;

        Image img;
        string title, title2, title3, title4, title5;
        string quantity, quantity2, quantity3, quantity4, quantity5;
        string cost, cost2, cost3, cost4, cost5;
        float sum, sum2, sum3, sum4, sum5;
        float sumAll;

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
            createcolumnsType();
            refreshdatagridAdmin(dataGridView3);
            refreshdatagridType(dataGridView2);
            buttonemail.Enabled = false;
        }

        private void visisbleelements()
        {
            homePanel.Visible = true;
            salePanel.Visible = false;
            typePanel.Visible = false;
            panelnewrec.Visible = false;
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
            textemail.Visible = false;
            labelemail.Visible = false;
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
            dataGridView3.Size = new System.Drawing.Size(780, 415);
            dataGridView3.Location = new System.Drawing.Point(133, 80);
            saveButton3.Size = new System.Drawing.Size(291, 65);
            saveButton3.Location = new System.Drawing.Point(133, 730);
            deleteButton3.Size = new System.Drawing.Size(291, 65);
            deleteButton3.Location = new System.Drawing.Point(622, 730);
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
            picturereceipt.Size = new System.Drawing.Size(1051, 781);
            picturereceipt.Location = new System.Drawing.Point(797, 50);
            buttonCreateReceipt.Size = new System.Drawing.Size(637, 72);
            buttonCreateReceipt.Location = new System.Drawing.Point(39, 324);
            buttonprint.Size = new System.Drawing.Size(637, 72);
            buttonprint.Location = new System.Drawing.Point(39, 400);
            buttonsave.Size = new System.Drawing.Size(637, 72);
            buttonsave.Location = new System.Drawing.Point(39, 476);
            buttonemail.Size = new System.Drawing.Size(637, 72);
            buttonemail.Location = new System.Drawing.Point(39, 634);
            textemail.Size = new System.Drawing.Size(637, 32);
            textemail.Location = new System.Drawing.Point(39, 596);
            labelemail.Location = new System.Drawing.Point(39, 565);
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

        private void UpdateDataType()
        {
            type_of_fuel.Clear();

            comboBox1.Items.Clear();
            comboBox2.Items.Clear();
            comboBox3.Items.Clear();
            comboBox4.Items.Clear();
            comboBox5.Items.Clear();

            DataBase.OpenConnection();

            type_of_fuel.Load(new SqlCommand($"select * from Type_of_fuel", DataBase.getConnection()).ExecuteReader());

            string fuel = "";

            foreach(DataRow dr in type_of_fuel.Rows)
            {
                fuel = "";
                fuel += dr.ItemArray[1].ToString();
                comboBox1.Items.Add(fuel);
                comboBox2.Items.Add(fuel);
                comboBox3.Items.Add(fuel);
                comboBox4.Items.Add(fuel);
                comboBox5.Items.Add(fuel);
            }
            DataBase.CloseConnection();
        }

        private void createcolumnsType()
        {
            dataGridView2.Columns.Add("id", "id");
            dataGridView2.Columns.Add("Title", "Наименование");
            dataGridView2.Columns.Add("Oktane", "Октановое число");
            dataGridView2.Columns.Add("Quantity", "Количество");
            dataGridView2.Columns.Add("Cost", "Цена");
            dataGridView2.Columns.Add("New", String.Empty);
            dataGridView2.Columns[0].Visible = false;
            dataGridView2.Columns[5].Visible = false;
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void readsinglerowType(DataGridView dgw, IDataRecord rec)
        {
            dgw.Rows.Add(rec.GetInt32(0), rec.GetString(1), rec.GetString(2), rec.GetInt32(3), rec.GetDecimal(4), rowstate.ModifiedNew);
        }

        private void refreshdatagridType(DataGridView dgw)
        {
            dgw.Rows.Clear();

            string query = $"select * from Type_of_fuel";

            SqlCommand com = new SqlCommand(query, DataBase.getConnection());

            DataBase.OpenConnection();

            SqlDataReader read = com.ExecuteReader();

            while(read.Read())
            {
                readsinglerowType(dgw, read);
            }
            read.Close();
            DataBase.CloseConnection();
        }

        private void deleteType()
        {
            int index = dataGridView2.CurrentCell.RowIndex;

            dataGridView2.Rows[index].Visible = false;

            if (dataGridView2.Rows[index].Cells[0].Value.ToString() == String.Empty)
            {
                dataGridView2.Rows[index].Cells[5].Value = rowstate.Deleted;
                return;
            }
            dataGridView2.Rows[index].Cells[5].Value = rowstate.Deleted;
        }

        private void saveType()
        {
            DataBase.OpenConnection();

            for (int index = 0; index < dataGridView2.Rows.Count; index++)
            {
                var row = (rowstate)dataGridView2.Rows[index].Cells[5].Value;

                if (row == rowstate.Existed)
                    continue;

                if (row == rowstate.Deleted)
                {
                    var id = Convert.ToInt32(dataGridView2.Rows[index].Cells[0].Value);
                    var deletequery = $"delete from Type_of_fuel where ID = {id}";

                    var command = new SqlCommand(deletequery, DataBase.getConnection());
                    command.ExecuteNonQuery();
                }

                if (row == rowstate.Modified)
                {
                    var id = dataGridView2.Rows[index].Cells[0].Value.ToString();
                    var title = dataGridView2.Rows[index].Cells[1].Value.ToString();
                    var oktane = dataGridView2.Rows[index].Cells[2].Value.ToString();
                    var quantity = dataGridView2.Rows[index].Cells[3].Value.ToString();
                    var cost = dataGridView2.Rows[index].Cells[4].Value.ToString();

                    var changequery = $"update Type_of_fuel set Title = '{title}', Oktane = '{oktane}', Quantity = '{quantity}', Cost = '{cost}' where Id = '{id}'";

                    var command = new SqlCommand(changequery, DataBase.getConnection());
                    command.ExecuteNonQuery();
                }

            }
            DataBase.CloseConnection();
        }

        private void changeType()
        {
            var selectedrowindex = dataGridView2.CurrentCell.RowIndex;

            var id = textBox1.Text;
            var title = textBoxtitle.Text;
            var oktane = textBoxoktane.Text;
            var quantity = textBoxquantity.Text;
            var cost = textBoxcost.Text;

            if (dataGridView2.Rows[selectedrowindex].Cells[0].Value.ToString() != string.Empty) ;
            {
                dataGridView2.Rows[selectedrowindex].SetValues(id, title, oktane, quantity, cost);
                dataGridView2.Rows[selectedrowindex].Cells[5].Value = rowstate.Modified;
            }
        }

        private void clearType()
        {
            textBoxtitle.Text = "";
            textBoxoktane.Text = "";
            textBoxquantity.Text = "";
            textBoxcost.Text = "";
        }

        private void createcolumnsAdmin()
        {
            dataGridView3.Columns.Add("ID", "Номер пользователя");
            dataGridView3.Columns.Add("Login", "Логин");
            dataGridView3.Columns.Add("Password", "Пароль");
            var checkColumn = new DataGridViewCheckBoxColumn();
            checkColumn.HeaderText = "Доступ администратора";
            dataGridView3.Columns.Add(checkColumn);
            dataGridView3.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

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
            UpdateDataType();
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

        private void buttonCreateReceipt_Click(object sender, EventArgs e)
        {
            title = comboBox1.Text;
            title2 = comboBox2.Text;
            title3 = comboBox3.Text;
            title4 = comboBox4.Text;
            title5 = comboBox5.Text;
            quantity = numericUpDown1.Text;
            quantity2 = numericUpDown2.Text;
            quantity3 = numericUpDown3.Text;
            quantity4 = numericUpDown4.Text;
            quantity5 = numericUpDown5.Text;
            cost = textcost1.Text;
            cost2 = textcost2.Text;
            cost3 = textcost3.Text;
            cost4 = textcost4.Text;
            cost5 = textcost5.Text;

            //Расчет суммы
            if(textcost1.TextLength >= 1)
            {
                float a = float.Parse(numericUpDown1.Text);
                float b = float.Parse(textcost1.Text);
                sum = a * b;
                sum.ToString();
            }
            if(textcost2.TextLength >= 1)
            {
                float a2 = float.Parse(numericUpDown2.Text);
                float b2 = float.Parse(textcost2.Text);
                sum2 = a2 * b2;
                sum2.ToString();
            }
            if (textcost3.TextLength >= 1)
            {
                float a3 = float.Parse(numericUpDown3.Text);
                float b3 = float.Parse(textcost3.Text);
                sum3 = a3 * b3;
                sum3.ToString();
            }
            if (textcost4.TextLength >= 1)
            {
                float a4 = float.Parse(numericUpDown4.Text);
                float b4 = float.Parse(textcost4.Text);
                sum4 = a4 * b4;
                sum4.ToString();
            }
            if (textcost5.TextLength >= 1)
            {
                float a5 = float.Parse(numericUpDown5.Text);
                float b5 = float.Parse(textcost5.Text);
                sum5 = a5 * b5;
                sum5.ToString();
            }

            //Общая сумма
            sumAll = sum + sum2 + sum3 + sum4 + sum5;
            sumAll.ToString();

            img = DrawKvit(title, title2, title3, title4, title5,
                quantity, quantity2, quantity3, quantity4, quantity5,
                cost, cost2, cost3, cost4, cost5,
                sum, sum2, sum3, sum4, sum5,
                sumAll);
            picturereceipt.Image = img;
        }

        private void buttonemail_Click(object sender, EventArgs e)
        {
            OpenFileDialog OFD = new OpenFileDialog();
            OFD.ShowDialog();
            file = OFD.FileName;

            try
            {
                MailMessage mes = new MailMessage();
                mes.From = new MailAddress("boss.radkov2000@list.ru");
                mes.To.Add(new MailAddress(textemail.Text));
                mes.Subject = "Электронный чек";
                mes.Body = $"Вы получили электронный чек на сумму: {sumAll} ₽";
                Attachment sendfile = new Attachment(file);
                mes.Attachments.Add(sendfile);

                SmtpClient client = new SmtpClient();
                client.Host = "smtp.mail.ru";
                client.Port = 587;
                client.EnableSsl = true;
                client.Credentials = new NetworkCredential("boss.radkov2000@list.ru", "z4tLFWH3hcRhydMeArm0");

                client.Send(mes);
                MessageBox.Show("Письмо успешно отправлено!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }  
        }   

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(img, 30, 50);
        }

        private void buttonprint_Click(object sender, EventArgs e)
        {
            if (printDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void textemail_TextChanged(object sender, EventArgs e)
        {
            if(textemail.TextLength >= 1)
            {
                buttonemail.Enabled = true;
            }
        }

        private void buttonnewrec_Click(object sender, EventArgs e)
        {
            panelnewrec.Visible = true;
        }

        private void buttondelrec_Click(object sender, EventArgs e)
        {
            deleteType();
            clearType();
        }

        private void buttonsaverec_Click(object sender, EventArgs e)
        {
            saveType();
            refreshdatagridType(dataGridView2);
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedrow = e.RowIndex;
            if (e.ColumnIndex >= 0)
            {
                DataGridViewRow row = dataGridView2.Rows[selectedrow];

                textBox1.Text = row.Cells[0].Value.ToString();
                textBoxtitle.Text = row.Cells[1].Value.ToString();
                textBoxoktane.Text = row.Cells[2].Value.ToString();
                textBoxquantity.Text = row.Cells[3].Value.ToString();
                textBoxcost.Text = row.Cells[4].Value.ToString();
            }
        }

        private void buttonchangerec_Click(object sender, EventArgs e)
        {
            changeType();
        }

        private void buttoncreaterec_Click(object sender, EventArgs e)
        {
            DataBase.OpenConnection();

            var titlenew = textBoxtitleNEW.Text;
            var oktanenew = textBoxoktaneNEW.Text;
            var quantitynew = textBoxquantityNEW.Text;
            var costnew = textBoxcostNEW.Text;


            var addquery = $"insert into Type_of_fuel (Title, Oktane, Quantity, Cost) values ('{titlenew}','{oktanenew}', '{quantitynew}', '{costnew}')";

            var command = new SqlCommand(addquery, DataBase.getConnection());

            if(command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Запись успешно создана.");
                panelnewrec.Visible = false;
                textBoxtitleNEW.Text = "";
                textBoxoktaneNEW.Text = "";
                textBoxquantityNEW.Text = "";
                textBoxcostNEW.Text = "";
                refreshdatagridType(dataGridView2);
            }
            else
            {
                MessageBox.Show("Произошла ошибка" +
                    "Попробуйте еще раз");
                panelnewrec.Visible = false;
                panelnewrec.Visible = false;
                textBoxtitleNEW.Text = "";
                textBoxoktaneNEW.Text = "";
                textBoxquantityNEW.Text = "";
                textBoxcostNEW.Text = "";
            }
            
            DataBase.CloseConnection();
        }

        private void buttonsave_Click(object sender, EventArgs e)
        {
            {
                if (this.saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    this.picturereceipt.Image.Save(this.saveFileDialog1.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);
            }
            labelemail.Visible = true;
            textemail.Visible = true;
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
            comboBox2.Text = "";
            numericUpDown2.Value = 0;
            textcost2.Text = "";
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
            comboBox3.Text = "";
            numericUpDown3.Value = 0;
            textcost3.Text = "";
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
            comboBox4.Text = "";
            numericUpDown4.Value = 0;
            textcost4.Text = "";
        }

        private void pictureminus4_Click(object sender, EventArgs e)
        {
            pictureminus4.Visible = false;
            comboBox5.Visible = false;
            numericUpDown5.Visible = false;
            textcost5.Visible = false;
            pictureplus4.Visible = true;
            pictureminus3.Visible = true;
            comboBox5.Text = "";
            numericUpDown5.Value = 0;
            textcost5.Text = "";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataBase.OpenConnection();
            type_of_fuel.Load(new SqlCommand($"select * from Type_of_fuel where Title = '{comboBox1.SelectedItem.ToString()}'", DataBase.getConnection()).ExecuteReader());

            string cost = "";

            foreach (DataRow dr in type_of_fuel.Rows)
            {
                cost = "";
                cost += dr.ItemArray[4].ToString();
                if (comboBox1.SelectedIndex == 0)
                {
                    textcost1.Text = cost;
                }
                if (comboBox1.SelectedIndex == 1)
                {
                    textcost1.Text = cost;
                }

                if (comboBox1.SelectedIndex == 2)
                {
                    textcost1.Text = cost;
                }
                if (comboBox1.SelectedIndex == 3)
                {
                    textcost1.Text = cost;
                }
                if (comboBox1.SelectedIndex == 4)
                {
                    textcost1.Text = cost;
                }
                if (comboBox1.SelectedIndex == 5)
                {
                    textcost1.Text = cost;
                }
            }

            DataBase.CloseConnection();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataBase.OpenConnection();
            type_of_fuel.Load(new SqlCommand($"select * from Type_of_fuel where Title = '{comboBox2.SelectedItem.ToString()}'", DataBase.getConnection()).ExecuteReader());

            string cost = "";

            foreach (DataRow dr in type_of_fuel.Rows)
            {
                cost = "";
                cost += dr.ItemArray[4].ToString();
                if (comboBox2.SelectedIndex == 0)
                {
                    textcost2.Text = cost;
                }
                if (comboBox2.SelectedIndex == 1)
                {
                    textcost2.Text = cost;
                }

                if (comboBox2.SelectedIndex == 2)
                {
                    textcost2.Text = cost;
                }
                if (comboBox2.SelectedIndex == 3)
                {
                    textcost2.Text = cost;
                }
                if (comboBox2.SelectedIndex == 4)
                {
                    textcost2.Text = cost;
                }
                if (comboBox2.SelectedIndex == 5)
                {
                    textcost2.Text = cost;
                }
            }

            DataBase.CloseConnection();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataBase.OpenConnection();
            type_of_fuel.Load(new SqlCommand($"select * from Type_of_fuel where Title = '{comboBox3.SelectedItem.ToString()}'", DataBase.getConnection()).ExecuteReader());

            string cost = "";

            foreach (DataRow dr in type_of_fuel.Rows)
            {
                cost = "";
                cost += dr.ItemArray[4].ToString();
                if (comboBox3.SelectedIndex == 0)
                {
                    textcost3.Text = cost;
                }
                if (comboBox3.SelectedIndex == 1)
                {
                    textcost3.Text = cost;
                }

                if (comboBox3.SelectedIndex == 2)
                {
                    textcost3.Text = cost;
                }
                if (comboBox3.SelectedIndex == 3)
                {
                    textcost3.Text = cost;
                }
                if (comboBox3.SelectedIndex == 4)
                {
                    textcost3.Text = cost;
                }
                if (comboBox3.SelectedIndex == 5)
                {
                    textcost3.Text = cost;
                }
            }

            DataBase.CloseConnection();
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataBase.OpenConnection();
            type_of_fuel.Load(new SqlCommand($"select * from Type_of_fuel where Title = '{comboBox4.SelectedItem.ToString()}'", DataBase.getConnection()).ExecuteReader());

            string cost = "";

            foreach (DataRow dr in type_of_fuel.Rows)
            {
                cost = "";
                cost += dr.ItemArray[4].ToString();
                if (comboBox1.SelectedIndex == 0)
                {
                    textcost4.Text = cost;
                }
                if (comboBox4.SelectedIndex == 1)
                {
                    textcost4.Text = cost;
                }

                if (comboBox4.SelectedIndex == 2)
                {
                    textcost4.Text = cost;
                }
                if (comboBox4.SelectedIndex == 3)
                {
                    textcost4.Text = cost;
                }
                if (comboBox4.SelectedIndex == 4)
                {
                    textcost4.Text = cost;
                }
                if (comboBox4.SelectedIndex == 5)
                {
                    textcost4.Text = cost;
                }
            }

            DataBase.CloseConnection();
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataBase.OpenConnection();
            type_of_fuel.Load(new SqlCommand($"select * from Type_of_fuel where Title = '{comboBox5.SelectedItem.ToString()}'", DataBase.getConnection()).ExecuteReader());

            string cost = "";

            foreach (DataRow dr in type_of_fuel.Rows)
            {
                cost = "";
                cost += dr.ItemArray[4].ToString();
                if (comboBox5.SelectedIndex == 0)
                {
                    textcost5.Text = cost;
                }
                if (comboBox5.SelectedIndex == 1)
                {
                    textcost5.Text = cost;
                }

                if (comboBox5.SelectedIndex == 2)
                {
                    textcost5.Text = cost;
                }
                if (comboBox5.SelectedIndex == 3)
                {
                    textcost5.Text = cost;
                }
                if (comboBox5.SelectedIndex == 4)
                {
                    textcost5.Text = cost;
                }
                if (comboBox5.SelectedIndex == 5)
                {
                    textcost5.Text = cost;
                }
            }

            DataBase.CloseConnection();
        }

        public Bitmap DrawKvit(string title, string title2, string title3, string title4, string title5,
           string quntity, string quntity2, string quntity3, string quntity4, string quntity5,
           string cost, string cost2, string cost3, string cost4, string cost5,
           float sum, float sum2, float sum3, float sum4, float sum5,
           float sumAll)
        {
            Bitmap bmp = new Bitmap(picturereceipt.Width, picturereceipt.Height);
            Graphics graphics = Graphics.FromImage(bmp);
            graphics.Clear(Color.White);
            Font font = new Font("Times New Roman", 20);
            Font font2 = new Font("Times New Roman", 16);
            Font sfont = new Font("Times New Roman", 10);
            graphics.DrawRectangle(new Pen(Brushes.Black), 0, 0, 1050, 780);
            graphics.DrawString("Товарный чек", font, Brushes.Black, 375, 45);

            //Строки
            graphics.DrawRectangle(new Pen(Brushes.Black), 75, 135, 900, 60);
            graphics.DrawRectangle(new Pen(Brushes.Black), 75, 195, 900, 60);
            graphics.DrawRectangle(new Pen(Brushes.Black), 75, 255, 900, 60);
            graphics.DrawRectangle(new Pen(Brushes.Black), 75, 315, 900, 60);
            graphics.DrawRectangle(new Pen(Brushes.Black), 75, 375, 900, 60);
            graphics.DrawRectangle(new Pen(Brushes.Black), 75, 435, 900, 60);

            //Столбцы
            graphics.DrawRectangle(new Pen(Brushes.Black), 75, 135, 315, 360);
            graphics.DrawRectangle(new Pen(Brushes.Black), 390, 135, 180, 360);
            graphics.DrawRectangle(new Pen(Brushes.Black), 570, 135, 150, 360);

            //Наименование
            graphics.DrawString("Наименование", font2, Brushes.Black, 120, 150);

            graphics.DrawString($"{title}", font2, Brushes.Black, 165, 210);
            graphics.DrawString($"{title2}", font2, Brushes.Black, 165, 270);
            graphics.DrawString($"{title3}", font2, Brushes.Black, 165, 330);
            graphics.DrawString($"{title4}", font2, Brushes.Black, 165, 390);
            graphics.DrawString($"{title5}", font2, Brushes.Black, 165, 450);

            //Количество
            graphics.DrawString("Кол-во/л", font2, Brushes.Black, 412, 150);

            if (numericUpDown1.Value >= 1)
            {
                graphics.DrawString($"{quantity}", font2, Brushes.Black, 457, 210);
            }
            if(numericUpDown2.Value >= 1)
            {
                graphics.DrawString($"{quantity2}", font2, Brushes.Black, 457, 270);
            }
            if (numericUpDown3.Value >= 1)
            {
                graphics.DrawString($"{quantity3}", font2, Brushes.Black, 457, 330);
            }
            if (numericUpDown4.Value >= 1)
            {
                graphics.DrawString($"{quantity4}", font2, Brushes.Black, 457, 390);
            }
            if (numericUpDown5.Value >= 1)
            {
                graphics.DrawString($"{quantity5}", font2, Brushes.Black, 457, 450);
            }
            
            //Цена
            graphics.DrawString("Цена/руб", font2, Brushes.Black, 577, 150);

            graphics.DrawString($"{cost}", font2, Brushes.Black, 603, 210);
            graphics.DrawString($"{cost2}", font2, Brushes.Black, 603, 270);
            graphics.DrawString($"{cost3}", font2, Brushes.Black, 603, 330);
            graphics.DrawString($"{cost4}", font2, Brushes.Black, 603, 390);
            graphics.DrawString($"{cost5}", font2, Brushes.Black, 603, 450);

            //Сумма
            graphics.DrawString("Сумма", font2, Brushes.Black, 787, 150);

            if (numericUpDown1.Value >= 1)
            {
                graphics.DrawString($"{sum}", font2, Brushes.Black, 795, 210);
            }
            if (numericUpDown2.Value >= 1)
            {
                graphics.DrawString($"{sum2}", font2, Brushes.Black, 795, 270);
            }
            if (numericUpDown3.Value >= 1)
            {
                graphics.DrawString($"{sum3}", font2, Brushes.Black, 795, 330);
            }
            if (numericUpDown4.Value >= 1)
            {
                graphics.DrawString($"{sum4}", font2, Brushes.Black, 795, 390);
            }
            if (numericUpDown5.Value >= 1)
            {
                graphics.DrawString($"{sum5}", font2, Brushes.Black, 795, 450);
            }

            //Подытог
            graphics.DrawString($"Итого: {sumAll} ₽", font, Brushes.Black, 75, 525);
            graphics.DrawString($"Продавец: {_user.Login} ", font, Brushes.Black, 75, 645);


            return bmp;
        }
    }
}
