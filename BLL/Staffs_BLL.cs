using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class Staffs_BLL
    {
        public static List<Staffs_DTO> LoadStaffs()
        {
            return Staffs_DAL.LoadStaffs();
        }
        public static Staffs_DTO GetStaffByLogin(string username, string password)
        {
            return Staffs_DAL.GetStaffByLogin(username, password);
        }
        public static bool updateStaff(Staffs_DTO s)
        {
            return Staffs_DAL.updateStaff(s);
        }
        public static bool addStaff(Staffs_DTO s)
        {
            return Staffs_DAL.addStaff(s);
        } 
    }
}
