using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class Watches_BLL
    {
        public static List<Watches_DTO> LoadWatches()
        {
            return Watches_DAL.LoadWatches();
        }
    }
}
