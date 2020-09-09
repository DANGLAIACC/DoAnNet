using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class Customer_BLL
    {
        public static List<Customers_DTO> LoadCustomers()
        {
            return Customers_DAL.LoadCustomers();
        }
    }
}
