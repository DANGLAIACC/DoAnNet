using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;

namespace DAL
{
    public class Company_DAL
    {
        public static List<Company_DTO> LoadCompany()
        {
            DataTable table = new DataTable();
            table = DataProvider.Execute("select * from Company");
            int count = table.Rows.Count;
            if (table != null && count > 0)
            {
                List<Company_DTO> lst = new List<Company_DTO>();
                Company_DTO l;
                for (int i = 0; i < count; i++)
                {
                    l = new Company_DTO();
                    l.Cp_tin = table.Rows[i]["Cp_tin"].ToString();
                    l.Cp_name = table.Rows[i]["Cp_name"].ToString();
                    l.Cp_address = table.Rows[i]["Cp_address"].ToString();
                    l.Cp_phone = table.Rows[i]["Cp_phone"].ToString();
                    l.Cp_email = table.Rows[i]["Cp_email"].ToString();

                    lst.Add(l);
                }
                return lst;
            }
            return null;
        }
    }
}
