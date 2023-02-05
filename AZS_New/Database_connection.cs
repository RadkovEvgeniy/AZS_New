using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace AZS_New
{
    internal class Database_connection
    {
        SqlConnection SqlConnection = new SqlConnection(@"Data Source = ZHEKA-PC\SQLEXPRESS; Initial Catalog = AZS_new; Integrated Security = True");

        public void OpenConnection()
        {
            if (SqlConnection.State == System.Data.ConnectionState.Closed)
            {
                SqlConnection.Open();
            }
        }

        public void CloseConnection()
        {
            if (SqlConnection.State == System.Data.ConnectionState.Open)
            {
                SqlConnection.Close();
            }
        }
        public SqlConnection getConnection()
        {
            return SqlConnection;
        }
    }
}
