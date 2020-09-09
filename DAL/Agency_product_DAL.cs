using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;

namespace DAL
{
    public class Agency_product_DAL
    {
        public static List<Agency_product_DTO> LoadAgencyProduct()
        {
            DataTable table = new DataTable();
            table = DataProvider.Execute("select * from Agency_product");
            int count = table.Rows.Count;
            if (table != null && count > 0)
            {
                List<Agency_product_DTO> lst = new List<Agency_product_DTO>();
                Agency_product_DTO l;
                for (int i = 0; i < count; i++)
                {
                    l = new Agency_product_DTO(); 

                    l.Ag_id = table.Rows[i]["Ag_id"].ToString();
                    l.Pd_id = table.Rows[i]["Pd_id"].ToString();
                    l.Pd_remain = Int32.Parse(table.Rows[i]["Pd_remain"].ToString());

                    lst.Add(l);
                }
                return lst;
            }
            return null;
        }
    }
}
