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
            string strConnection = @"server=DANGLAI_PC\DANGLAI_PC;"
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
        
        public static bool addOrder(
            string od_id,
            string od_dateDelivery,
            string od_status,
            string od_address,
            string od_payment,
            string st_id,
            string ct_id,
            string ag_id,
            string pd_id,
            string od_quantity,
            string od_price
            )
        {
            SqlCommand command = new SqlCommand();
            SqlConnection connection = OpenConnection();
            command.Connection = connection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "addOrder";
            command.Parameters.Add(new SqlParameter("@od_id", SqlDbType.Char)).Value = od_id;
            command.Parameters.Add(new SqlParameter("@od_dateDelivery", SqlDbType.DateTime)).Value = od_dateDelivery;
            command.Parameters.Add(new SqlParameter("@od_status", SqlDbType.Bit)).Value = int.Parse(od_status);
            command.Parameters.Add(new SqlParameter("@od_address", SqlDbType.NVarChar)).Value = od_address;
            command.Parameters.Add(new SqlParameter("@od_payment", SqlDbType.NVarChar)).Value = "Tiền mặt";
            command.Parameters.Add(new SqlParameter("@st_id", SqlDbType.VarChar)).Value = st_id;
            command.Parameters.Add(new SqlParameter("@ct_id", SqlDbType.Char)).Value = ct_id;

            command.Parameters.Add(new SqlParameter("@ag_id", SqlDbType.Char)).Value = ag_id;
            command.Parameters.Add(new SqlParameter("@pd_id", SqlDbType.Char)).Value = pd_id;
            command.Parameters.Add(new SqlParameter("@od_quantity", SqlDbType.Int)).Value = int.Parse(od_quantity);
            Decimal x = Decimal.Parse(od_price);
            command.Parameters.Add(new SqlParameter("@od_price", SqlDbType.Money)).Value = x;

            int result = command.ExecuteNonQuery();
            CloseConnection(connection);
            return result > 0;
        }
    }
}
