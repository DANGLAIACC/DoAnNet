using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DataProvider
    {
        public static SqlConnection OpenConnection()
        {
            string strConnection = @"Data Source = (local);Initial Catalog=QL_Dong_Ho;Intergrated Security=True";
            SqlConnection connection = new SqlConnection(strConnection);
            connection.Open();
            return connection;
        }

        public static void CloseConnection(SqlConnection connection)
        {
            connection.Close();
        }
        public static DataTable Execute(string query)
        {
            SqlConnection connection = OpenConnection();
            DataTable table = new DataTable();
            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.Fill(table);
            }
            catch
            {
                table = null;
            }
            CloseConnection(connection);
            return table;
        }

        public static bool ExecuteNonQuery(string query)
        {
            SqlConnection connection = OpenConnection();
            int result;
            try
            {
                SqlCommand command = new SqlCommand(query, connection);
                result = command.ExecuteNonQuery();
            }
            catch
            {
                result = 0;
            }
            CloseConnection(connection);
            return result > 0;
        }
    }
}
