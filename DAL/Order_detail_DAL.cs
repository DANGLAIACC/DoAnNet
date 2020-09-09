using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;

namespace DAL
{
    public class Order_detail_DAL
    {
        public static List<Order_detail_DTO> LoadOrderDetail()
        {
            DataTable table = new DataTable();
            table = DataProvider.Execute("select * from Order_detail");
            int count = table.Rows.Count;
            if (table != null && count > 0)
            {
                List<Order_detail_DTO> lst = new List<Order_detail_DTO>();
                Order_detail_DTO l;
                for (int i = 0; i < count; i++)
                {
                    l = new Order_detail_DTO();
                    l.Od_id = table.Rows[i]["Od_id"].ToString();
                    l.Pd_id = table.Rows[i]["Pd_id"].ToString();
                    l.Od_quantity = Int32.Parse(table.Rows[i]["Ct_id"].ToString());
                    l.Od_price= Decimal.Parse(table.Rows[i]["Ct_id"].ToString());
                    
                    lst.Add(l);
                }
                return lst;
            }
            return null;

        }
    }
}
