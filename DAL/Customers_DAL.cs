using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;

namespace DAL
{
    public class Customers_DAL
    {
        public static List<Customers_DTO> LoadCustomers()
        {
            DataTable table = new DataTable();
            table = DataProvider.Execute("select * from Customers");
            int count = table.Rows.Count;
            if (table != null && count > 0)
            {
                List<Customers_DTO> lst = new List<Customers_DTO>();
                Customers_DTO l;
                for (int i = 0; i < count; i++)
                {
                    l = new Customers_DTO();
                    l.Ct_id = table.Rows[i]["Ct_id"].ToString();
                    l.Ct_firstName = table.Rows[i]["Ct_firstName"].ToString();
                    l.Ct_lastName = table.Rows[i]["Ct_lastName"].ToString();
                    l.Ct_address = table.Rows[i]["Ct_address"].ToString();
                    l.Ct_phone = table.Rows[i]["Ct_phone"].ToString();
                    l.Ct_email = table.Rows[i]["Ct_phone"].ToString();
                    l.Ct_gender = table.Rows[i]["Ct_gender"].ToString() == "1";
                    l.Cp_tin = table.Rows[i]["Cp_tin"].ToString();

                    lst.Add(l); 
                }
                return lst;
            }
            return null;
        } 
    }
}
