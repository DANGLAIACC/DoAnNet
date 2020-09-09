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
    }
}
