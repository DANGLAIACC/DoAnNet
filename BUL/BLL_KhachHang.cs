using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BUL
{
    public class BLL_KhachHang
    {
        public static List<DTO_KhachHang> LoadKhachHang()
        {
            return DAL_KhachHang.LoadKhachHang();
        }
    }
}
