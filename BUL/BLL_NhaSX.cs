using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
namespace BLL
{
    public class BLL_NhaSX
    {
        public static List<DTO_NhaSX> LoadNhaSX()
        {
            return DAL_NhaSX.LoadNhaSX();
        }
    }
}
