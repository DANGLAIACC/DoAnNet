using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BUL
{
    public class BLL_HoaDon
    {
        public static List<DTO_HoaDon> LoadHoaDon()
        {
            return DAL_HoaDon.LoadHoaDon();
        }
    }
}
