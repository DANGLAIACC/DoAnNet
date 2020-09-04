using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BUL
{
    public class BLL_NhanVien
    {
        public static List<DTO_NhanVien> LoadNhanVien()
        {
            return DAL_NhanVien.LoadNhanVien();
        }
    }
}
