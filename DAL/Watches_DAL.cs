using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;

namespace DAL
{
    public class Watches_DAL
    {
        public static List<Watches_DTO> LoadWatches()
        {
            DataTable table = new DataTable();
            table = DataProvider.Execute("select * from Watches");
            int count = table.Rows.Count;
            if (table != null && count > 0)
            {
                List<Watches_DTO> lst = new List<Watches_DTO>();
                Watches_DTO l;
                for (int i = 0; i < count; i++)
                {
                    l = new Watches_DTO();

                    l.Pd_id = table.Rows[i]["Pd_id"].ToString();
                    l.W_shape = table.Rows[i]["W_shape"].ToString();
                    l.W_size = table.Rows[i]["W_size"].ToString();
                    l.W_energy= table.Rows[i]["W_energy"].ToString();
                    l.W_color= table.Rows[i]["W_color"].ToString();
                    l.W_guarantee= Int32.Parse(table.Rows[i]["W_guarantee"].ToString());

                    lst.Add(l);
                }
                return lst;
            }
            return null;
        }
        public static int GetTotalProducts()
        {
            DataTable table = DataProvider.Execute("select count(pd_id) total from watches");

            return int.Parse(table.Rows[0]["total"].ToString());
        }
    }
}
