using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BUL
{
    public class BLL_CTHoaDon
    {
        public static List<DTO_CTHoaDon> LoadCTHoaDon()
        {
            return DAL_CTHoaDon.LoadCTHoaDon();
        }
    }
}
