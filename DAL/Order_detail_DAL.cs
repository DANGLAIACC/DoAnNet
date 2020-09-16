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
            table = DataProvider.Execute("select a.*,pd_name from order_detail a inner join products b on a.pd_id= b.pd_id");
            int count = table.Rows.Count;
            if (table != null && count > 0)
            {
                List<Order_detail_DTO> lst = new List<Order_detail_DTO>();
                Order_detail_DTO l;
                for (int i = 0; i < count; i++)
                {
                    l = new Order_detail_DTO(
                        table.Rows[i]["Pd_id"].ToString(),
                        table.Rows[i]["Pd_name"].ToString(),
                        Decimal.Parse(
                            table.Rows[i]["Od_price"].ToString())
                        );

                    l.Od_id = table.Rows[i]["Od_id"].ToString(); 

                    l.Od_quantity = Int32.Parse(table.Rows[i]["Od_quantity"].ToString());

                    lst.Add(l);
                }
                return lst;
            }
            return null;

        }

        public static List<Order_detail_DTO> getOrderDetailById(string orderId)
        {
            DataTable table = new DataTable();
            string query = string.Format(
                "select a.*, pd_name "
                + "from order_detail a "
                + "inner join products b on a.pd_id = b.pd_id "
                + "inner join orders c on a.od_id = c.od_id "
                + "where a.od_id = '{0}'", orderId); 

            table = DataProvider.Execute(query);
            int count = table.Rows.Count;
            if (table != null && count > 0)
            {
                List<Order_detail_DTO> lst = new List<Order_detail_DTO>();
                Order_detail_DTO l;
                for (int i = 0; i < count; i++)
                {
                    l = new Order_detail_DTO(
                        table.Rows[i]["Pd_id"].ToString(),
                        table.Rows[i]["Pd_name"].ToString(),
                        Decimal.Parse(
                            table.Rows[i]["Od_price"].ToString())
                        );

                    l.Od_id = table.Rows[i]["Od_id"].ToString();

                    l.Od_quantity = Int32.Parse(table.Rows[i]["Od_quantity"].ToString());

                    lst.Add(l);
                }
                return lst;
            }
            return null;
        }

        public static bool addOrder(
            string od_id,
            string od_dateDelivery,
            string od_status,
            string od_address,
            string od_payment,
            string st_id,
            string ct_id,
            string ag_id,
            string pd_id,
            string od_quantity,
            string od_price
            )
        {
            return DataProvider.addOrder(
                od_id,
                od_dateDelivery,
                od_status,
                od_address,
                od_payment,
                st_id,
                ct_id,
                ag_id,
                pd_id,
                od_quantity,
                od_price
                ); 
        }

    }
}
