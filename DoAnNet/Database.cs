using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DoAnNet.Controllers
{
    class Database
    {
        public static SqlConnection connection;

        private static string strConnection = string.Format("server={0};database={1};Integrated Security = true", "DANGLAI_PC\\DANGLAI_PC", "QL_DONG_HO");

        //private static string strConnection = string.Format("server={0};uid={1};pwd='';database={2}", "DANGLAI_PC\\DANGLAI_PC","sa", "QL_DONG_HO");

        SqlDataAdapter adapter;
        public Database(string server, string database, bool inter, string user, string pass)
        {
            string strConnection;
            if (inter)
            {
                strConnection = string.Format("server={0};database={1};Integrated Security = true", server, database);
            }
            else
            {
                strConnection = string.Format("server={0};uid={1};pwd={2};database={3}", server, user, "", database);
            }
            connection = new SqlConnection(strConnection);
        }

        public static DataTable Execute(string query)
        {
            try
            {
                SqlConnection connection = new SqlConnection(strConnection);
                SqlDataAdapter adapter = new SqlDataAdapter(query, strConnection);
                DataTable table = new DataTable();
                adapter.Fill(table);
                return table;
            }
            catch
            {
                return null;
            }
        }
        public static bool ExecuteNonQuery(string query)
        {
            try
            {
                SqlConnection connection = new SqlConnection(strConnection);
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }
        //public void Update(string query, DataTable table)
        //{
        //    adapter = new SqlDataAdapter(query, connection);
        //    SqlCommandBuilder commandBuilder = new SqlCommandBuilder();
        //    adapter.Update(table);
        //}
    }
}
