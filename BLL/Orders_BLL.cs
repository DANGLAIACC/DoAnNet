using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class Orders_BLL
    {
        public static List<Orders_DTO> LoadOrders()
        {
            return Orders_DAL.LoadOrders();
        }
        public static Orders2_DTO LoadOrderByOdId(string orderId)
        {
            return Orders_DAL.LoadOrderByOdId(orderId);
        }
        public static List<Orders2_DTO> LoadAllOrder()
        {
            return Orders_DAL.LoadAllOrder();
        }
    }
}
