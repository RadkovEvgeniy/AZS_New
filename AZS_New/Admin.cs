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
    public partial class Admin : Form
    {
        Database_connection DataBase = new Database_connection();

        public Admin()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            createcolumns();
            refreshdatagrid(dataGridView1);
        }

        private void createcolumns()
        {
            dataGridView1.Columns.Add("ID", "Номер пользователя");
            dataGridView1.Columns.Add("Login", "Логин");
            dataGridView1.Columns.Add("Password", "Пароль");
            var checkColumn = new DataGridViewCheckBoxColumn();
            checkColumn.HeaderText = "Доступ администратора";
            dataGridView1.Columns.Add(checkColumn);
        }

        private void readsinglerow(DataGridView dgw, IDataRecord rec)
        {
            dgw.Rows.Add(rec.GetInt32(0), rec.GetString(1), rec.GetString(2), rec.GetBoolean(3));
        }

        private void refreshdatagrid(DataGridView dgw)
        {
            dgw.Rows.Clear();

            string query = $"select * from Users";

            SqlCommand com = new SqlCommand(query, DataBase.getConnection());

            DataBase.OpenConnection();

            SqlDataReader read = com.ExecuteReader();

            while(read.Read())
            {
                readsinglerow(dgw, read);
            }
            read.Close();
            DataBase.CloseConnection();
        }

        private void enter_Click(object sender, EventArgs e)
        {
            DataBase.OpenConnection();

            for(int index = 0; index < dataGridView1.Rows.Count; index ++)
            {
                var id = dataGridView1.Rows[index].Cells[0].Value.ToString();
                var isAdmin = dataGridView1.Rows[index].Cells[3].Value.ToString();

                var query = $"update Users set isAdmin = '{isAdmin}' where ID = '{id}'";

                var command = new SqlCommand(query, DataBase.getConnection());
                command.ExecuteNonQuery();
            }
            DataBase.CloseConnection();
            refreshdatagrid(dataGridView1);
        }

        private void delete_Click(object sender, EventArgs e)
        {
            DataBase.OpenConnection();

            var selectedrowindex = dataGridView1.CurrentCell.RowIndex;
            var id = Convert.ToInt32(dataGridView1.Rows[selectedrowindex].Cells[0].Value);

            var query = $"delete from User where ID = '{id}'";

            var command = new SqlCommand(query, DataBase.getConnection());
            command.ExecuteNonQuery();

            DataBase.CloseConnection();
            refreshdatagrid(dataGridView1);
        }
    }
}
