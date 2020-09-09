using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BUL
{
    public class Company_BLL
    {
        public static List<Company_DTO> LoadCompany()
        {
            return Company_DAL.LoadCompany();
        }
    }
}
