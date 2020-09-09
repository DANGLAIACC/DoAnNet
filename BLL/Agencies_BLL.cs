using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class Agencies_BLL
    {
        public static List<Agencies_DTO> LoadAgencies()
        {
            return Agencies_DAL.LoadAgencies();
        }
    }
}
