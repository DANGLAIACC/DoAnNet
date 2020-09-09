using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;

namespace DAL
{
    public class Provide_DAL
    {
        public static List<Provide_DTO> LoadProvide()
        {
            DataTable table = new DataTable();
            table = DataProvider.Execute("select * from Provide");
            int count = table.Rows.Count;
            if (table != null && count > 0)
            {
                List<Provide_DTO> lst = new List<Provide_DTO>();
                Provide_DTO l;
                for (int i = 0; i < count; i++)
                {
                    l = new Provide_DTO();

                    l.Pr_id = table.Rows[i]["Pr_id"].ToString();
                    l.Sp_id = table.Rows[i]["Sp_id"].ToString();
                    l.Ag_id = table.Rows[i]["Ag_id"].ToString();
                    l.Pr_date = DateTime.Parse(table.Rows[i]["Pr_date"].ToString());
                    l.Pr_deliveryCost = Decimal.Parse(table.Rows[i]["Pr_deliveryCost"].ToString());

                    lst.Add(l);
                }
                return lst;
            }
            return null;
        }
    }
}
