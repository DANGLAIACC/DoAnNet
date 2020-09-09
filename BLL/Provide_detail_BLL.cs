using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class Provide_detail_BLL
    {
        public static List<Provide_detail_DTO> LoadProvideDetail()
        {
            return Provide_detail_DAL.LoadProvideDetail();
        }
    }
}
