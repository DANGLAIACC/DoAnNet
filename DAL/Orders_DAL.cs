using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;

namespace DAL
{
    public class Orders_DAL
    {
        public static List<Orders_DTO> LoadOrders()
        {
            DataTable table = new DataTable();
            table = DataProvider.Execute("select * from Orders");
            int count = table.Rows.Count;
            if (table != null && count > 0)
            {
                List<Orders_DTO> lst = new List<Orders_DTO>();
                Orders_DTO l;
                for (int i = 0; i < count; i++)
                {
                    l = new Orders_DTO();

                    l.Od_id = table.Rows[i]["Od_id"].ToString();
                    l.Od_dateOrder = DateTime.Parse(table.Rows[i]["Od_dateOrder"].ToString());
                    l.Od_dateDelivery = DateTime.Parse(table.Rows[i]["Od_dateDelivery"].ToString());
                    l.Od_status = Int32.Parse(table.Rows[i]["Od_status"].ToString());
                    l.Od_address = table.Rows[i]["Od_address"].ToString();
                    l.Od_payment = table.Rows[i]["Od_payment"].ToString();
                    l.St_id = table.Rows[i]["St_id"].ToString();
                    l.Ct_id = table.Rows[i]["Ct_id"].ToString();
                    l.Ag_id = table.Rows[i]["Ag_id"].ToString(); 

                    lst.Add(l);
                }
                return lst;
            }
            return null;
        }
    }
}
