using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;

namespace DAL
{
    public class Agencies_DAL
    {
        public static List<Agencies_DTO> LoadAgencies()
        {
            DataTable table = new DataTable();
            table = DataProvider.Execute("select * from agencies");
            int count = table.Rows.Count;
            if (table != null && count > 0)
            {
                List<Agencies_DTO> lst = new List<Agencies_DTO>();
                Agencies_DTO l;
                for (int i = 0; i < count; i++)
                {
                    l = new Agencies_DTO();
                    l.Ag_id = table.Rows[i]["ag_id"].ToString();
                    l.Ag_address = table.Rows[i]["ag_address"].ToString();
                    l.Ag_phone = table.Rows[i]["ag_phone"].ToString();

                    lst.Add(l);
                }
                return lst;
            }
            return null;
        }
    }
}
