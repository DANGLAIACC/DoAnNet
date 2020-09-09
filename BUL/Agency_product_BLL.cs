using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BUL
{
    public class Agency_product_BLL
    {
        public static List<Agency_product_DTO> LoadAgencyProduct()
        {
            return Agency_product_DAL.LoadAgencyProduct();
        }
    }
}
