using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class Provide_BLL
    {
        public static List<Provide_DTO> LoadProvide()
        {
            return Provide_DAL.LoadProvide();
        }
    }
}
