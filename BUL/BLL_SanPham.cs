using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
namespace BLL
{
    public class BLL_SanPham
    {
        public static List<DTO_SanPham> LoadSanPham()
        {
            return DAL_SanPham.LoadSanPham();
        }
    }
}
