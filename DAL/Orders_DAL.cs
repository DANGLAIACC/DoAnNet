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
                    l.Od_dateOrder = table.Rows[i]["Od_dateOrder"].ToString();
                    l.Od_dateDelivery = table.Rows[i]["Od_dateDelivery"].ToString();
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
        public static List<Orders2_DTO> LoadAllOrder()
        { 
            string query = string.Format(
                " select o1.od_id, (s.st_firstName+' ' "
                + "+s.st_lastName) as SName,(c.ct_firstName+' '"
                + " +c.ct_lastName) as CName,"
                + " od_dateDelivery,od_dateOrder, ag_address," 
                + " c.Ct_address,c.ct_phone,"
                + " sum(od_quantity * od_price) as total"

                + " from orders o1 inner join order_detail"
                + " o2 on o1.od_id=o2.od_id"
                + " inner join staffs s on o1.st_id = s.st_id"
                + " inner join agencies a on o1.ag_id = a.ag_id"
                + " inner join customers c on o1.ct_id = c.ct_id"
                + " group by o1.od_id, (s.st_firstName+' '" 
                + " +s.st_lastName), (c.ct_firstName+' ' "
                + " +c.ct_lastName), od_dateDelivery,"
                + " od_dateOrder, ag_address, c.Ct_address," 
                + " c.ct_phone");

            DataTable table = DataProvider.Execute(query);

            int count = table.Rows.Count;
            if (table != null && count > 0)
            {
                List<Orders2_DTO> lst = new List<Orders2_DTO>();
                Orders2_DTO o;
                for (int i = 0; i < count; i++)
                {
                    o = new Orders2_DTO();

                    o.Od_id = table.Rows[i]["Od_id"].ToString();
                    o.Ag_address = table.Rows[i]["Ag_address"].ToString();
                    o.SName = table.Rows[i]["SName"].ToString();
                    o.AName = table.Rows[i]["ag_address"].ToString();
                    o.NgayMua = table.Rows[i]["od_dateOrder"].ToString();
                    o.NgayNhan = table.Rows[i]["od_dateDelivery"].ToString();
                    o.Ct_address = table.Rows[i]["Ct_address"].ToString();
                    o.Ct_phone = table.Rows[i]["Ct_phone"].ToString();
                    o.CName = table.Rows[i]["CName"].ToString();

                    o.Total = Decimal.Parse(table.Rows[i]["Total"].ToString()).ToString("#,##0");

                    lst.Add(o);
                }
                return lst;
            }
            return null;
        }

        public static Orders2_DTO LoadOrderByOdId(string orderId)
        {
            Orders2_DTO o = new Orders2_DTO();
            string query = string.Format(
                " select distinct (s.st_firstName+' ' "
                +" +s.st_lastName) as SName,(c.ct_firstName+' '"
                + " +c.ct_lastName) as CName,"
                + " od_dateDelivery,od_dateOrder, ag_address,"
                + " c.Ct_address,c.ct_phone"

                + " from orders o1 inner join order_detail"
                + " o2 on o1.od_id=o2.od_id"
                + " inner join staffs s on o1.st_id = s.st_id"
                + " inner join agencies a on o1.ag_id = a.ag_id"
                + " inner join customers c on o1.ct_id = c.ct_id"

                + " where o1.od_id = '{0}'",orderId);

            Console.WriteLine(query);

            DataTable table = DataProvider.Execute(query);

            o.Od_id = orderId;
            o.Ag_address = table.Rows[0]["ag_address"].ToString();
            o.SName = table.Rows[0]["SName"].ToString();
            o.AName = table.Rows[0]["ag_address"].ToString();
            o.NgayMua = table.Rows[0]["od_dateOrder"].ToString();
            o.NgayNhan = table.Rows[0]["od_dateDelivery"].ToString();
            o.Ct_address = table.Rows[0]["Ct_address"].ToString();
            o.Ct_phone = table.Rows[0]["Ct_phone"].ToString();
            o.CName = table.Rows[0]["CName"].ToString(); 

            return o;
        }

    }
}
