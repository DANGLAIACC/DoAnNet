using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class Order_detail_BLL
    {
        public static List<Order_detail_DTO> LoadOrderDetail()
        {
            return Order_detail_DAL.LoadOrderDetail();
        }
        public static List<Order_detail_DTO> getOrderDetailById(string orderId)
        {
            return Order_detail_DAL.getOrderDetailById(orderId);
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
           string pd_quantity
           )
        {
            return Order_detail_DAL.addOrder(
                od_id,
                od_dateDelivery,
                od_status,
                od_address,
                od_payment,
                st_id,
                ct_id,
                ag_id,
                pd_id,
                pd_quantity
                );
        }
    }
}
