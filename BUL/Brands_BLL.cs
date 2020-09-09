using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BUL
{
    public class Brands_BLL
    {
        public static List<Brands_DTO> LoadBrands()
        {
            return Brands_DAL.LoadBrands();
        }
    }
}
