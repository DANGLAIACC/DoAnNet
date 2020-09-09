using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class Products_BLL
    {
        public static List<Products_DTO> LoadProducts()
        {
            return Products_DAL.LoadProducts();
        }
    }
}
