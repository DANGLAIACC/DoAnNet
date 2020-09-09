using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;

namespace DAL
{
    public class Products_DAL
    {
        public static List<Products_DTO> LoadProducts()
        {
            DataTable table = new DataTable();
            table = DataProvider.Execute("select * from Products");
            int count = table.Rows.Count;
            if (table != null && count > 0)
            {
                List<Products_DTO> lst = new List<Products_DTO>();
                Products_DTO l;
                for (int i = 0; i < count; i++)
                {
                    l = new Products_DTO();

                    l.Pd_id = table.Rows[i]["Pd_id"].ToString();
                    l.Pd_name = table.Rows[i]["Pd_name"].ToString();
                    l.Pd_retail= Decimal.Parse(table.Rows[i]["Pd_retail"].ToString());
                    l.Pd_unit = table.Rows[i]["Pd_unit"].ToString();
                    l.Br_id = table.Rows[i]["Br_id"].ToString(); 

                    lst.Add(l);
                }
                return lst;
            }
            return null;
        }
    }
}
