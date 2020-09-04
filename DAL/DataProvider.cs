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
        public static SqlConnection KetNoi()
        {
            string strConnection = @"Data Source = (local);Initial Catalog=QL_Dong_Ho;Intergrated Security=True";
            SqlConnection connection = new SqlConnection(strConnection);
            connection.Open();
            return connection;
        }

        public static DataTable Execute(string query)
        {
            DataTable table = new DataTable();
            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, KetNoi());
                adapter.Fill(table);
            }
            catch
            {
                table = null;
            }
            KetNoi().Close();
            return table;
        }

        public static bool ExecuteNonQuery(string query)
        {
            int result;
            try
            {
                SqlCommand command = new SqlCommand(query, KetNoi());
                result = command.ExecuteNonQuery();
            }
            catch
            {
                result = 0;
            }
            KetNoi().Close();
            return result > 0;
        }
    }
}
