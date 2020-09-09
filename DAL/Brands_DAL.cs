using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;

namespace DAL
{
    public class Brands_DAL
    {
        public static List<Brands_DTO> LoadBrands()
        {
            DataTable table = new DataTable();
            table = DataProvider.Execute("select * from brands");
            int count = table.Rows.Count;
            if (table != null && count > 0)
            {
                List<Brands_DTO> lst = new List<Brands_DTO>();
                Brands_DTO l;
                for (int i = 0; i < count; i++)
                {
                    l = new Brands_DTO();
                    l.Br_id = table.Rows[i]["Br_id"].ToString();
                    l.Br_country= table.Rows[i]["Br_country"].ToString(); 

                    lst.Add(l);
                }
                return lst;
            }
            return null;
        }
    }
}
