using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;

namespace DAL
{
    public class Provide_detail_DAL
    {
        public static List<Provide_detail_DTO> LoadProvideDetail()
        {
            DataTable table = new DataTable();
            table = DataProvider.Execute("select * from provide_detail");
            int count = table.Rows.Count;
            if (table != null && count > 0)
            {
                List<Provide_detail_DTO> lst = new List<Provide_detail_DTO>();
                Provide_detail_DTO l;
                for (int i = 0; i < count; i++)
                {
                    l = new Provide_detail_DTO();

                    l.Pr_id = table.Rows[i]["Pr_id"].ToString();
                    l.Pd_id = table.Rows[i]["Pd_id"].ToString();
                    l.Prd_quantity = Int32.Parse(table.Rows[i]["Prd_quantity"].ToString());
                    l.Prd_purchase = Decimal.Parse(table.Rows[i]["Prd_purchase"].ToString());

                    lst.Add(l);
                }
                return lst;
            }
            return null;
        }
    }
}
