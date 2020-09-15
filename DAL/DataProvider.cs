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
            //string strConnection = @"Data Source = (local); Initial Catalog=WATCH_STORE;Intergrated Security=True" // DANGLAI_PC\DANGLAI_PC;
            string strConnection = @"server=TTTVT2-13;"
                + "database=WATCH_STORE;Integrated Security=True;"
                +"Trusted_Connection=true";
            SqlConnection connection = new SqlConnection(strConnection);
            connection.Open();
            return connection;
        }

        private static void CloseConnection(SqlConnection connection)
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
