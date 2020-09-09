using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;

namespace DAL
{
    public class Suppliers_DAL
    {
        public static List<Suppliers_DTO> LoadSuppliers()
        {
            DataTable table = new DataTable();
            table = DataProvider.Execute("select * from Suppliers");
            int count = table.Rows.Count;
            if (table != null && count > 0)
            {
                List<Suppliers_DTO> lst = new List<Suppliers_DTO>();
                Suppliers_DTO l;
                for (int i = 0; i < count; i++)
                {
                    l = new Suppliers_DTO();

                    l.Sp_id = table.Rows[i]["Sp_id"].ToString();
                    l.Sp_name = table.Rows[i]["Sp_name"].ToString();
                    l.Sp_tin = table.Rows[i]["Sp_tin"].ToString();
                    l.Sp_address = table.Rows[i]["Sp_address"].ToString();
                    l.Sp_phone = table.Rows[i]["Sp_phone"].ToString();

                    lst.Add(l);
                }
                return lst;
            }
            return null;

        }
    }
}
