using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class Suppliers_BLL
    {
        public static List<Suppliers_DTO> LoadSuppliers()
        {
            return Suppliers_DAL.LoadSuppliers();
        }
    }
}
