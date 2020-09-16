using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;

namespace DAL
{
    public class Staffs_DAL
    {
        public static List<Staffs_DTO> LoadStaffs()
        {
            DataTable table = new DataTable();
            table = DataProvider.Execute("select * from Staffs");
            int count = table.Rows.Count;
            if (table != null && count > 0)
            {
                List<Staffs_DTO> lst = new List<Staffs_DTO>();
                Staffs_DTO l;
                for (int i = 0; i < count; i++)
                {
                    l = new Staffs_DTO();

                    l.St_id = table.Rows[i]["St_id"].ToString();
                    l.St_password = table.Rows[i]["St_password"].ToString();
                    l.St_lastName = table.Rows[i]["St_lastName"].ToString();
                    l.St_firstName = table.Rows[i]["St_firstName"].ToString();
                    l.St_phone = table.Rows[i]["St_phone"].ToString();
                    l.St_email = table.Rows[i]["St_email"].ToString();
                    l.St_gender = table.Rows[i]["St_gender"].ToString() == "1";
                    l.St_workdays = Int32.Parse(table.Rows[i]["St_workdays"].ToString());
                    l.St_birthday = DateTime.Parse(table.Rows[i]["St_birthday"].ToString());
                    l.St_salary = Decimal.Parse(table.Rows[i]["St_salary"].ToString());
                    l.St_role = Int32.Parse(table.Rows[i]["St_role"].ToString());
                    l.Ag_id = table.Rows[i]["Ag_id"].ToString();

                    lst.Add(l);
                }
                return lst;
            }
            return null;
        } 
        public static Staffs_DTO GetStaffByLogin(string username, string password)
        {
            DataTable table = new DataTable();
            string query = string.Format(
                "select st_firstName, st_lastName, "
                + "st_id, st_password, st_phone, st_email, "
                + "st_workdays, st_birthday, "
                + "st_role, ag_address "
                + "from staffs s inner join agencies a "
                + "on s.ag_id = a.ag_id "
                + "where st_id='{0}' and st_password='{1}'",
                username, password);

            table = DataProvider.Execute(query);
            if (table.Rows.Count==0) // username, pass sai
                return null;
            Staffs_DTO l = new Staffs_DTO();

            l.St_id = table.Rows[0]["St_id"].ToString();
            l.St_password = table.Rows[0]["St_password"].ToString();
            l.St_lastName = table.Rows[0]["St_lastName"].ToString();
            l.St_firstName = table.Rows[0]["St_firstName"].ToString();
            l.St_phone = table.Rows[0]["St_phone"].ToString();
            l.St_email = table.Rows[0]["St_email"].ToString();
            l.St_workdays = Int32.Parse(table.Rows[0]["St_workdays"].ToString());
            l.St_birthday = DateTime.Parse(table.Rows[0]["St_birthday"].ToString());
            l.St_role = Int32.Parse(table.Rows[0]["St_role"].ToString());
            l.Ag_address = table.Rows[0]["Ag_address"].ToString();

            return l;
        }

        public static bool updateStaff(Staffs_DTO s)
        {
            string query = string.Format(
                "update staffs "
                + "set "
                    + "st_password = '{1}', "
                    + "st_firstName = N'{2}', "
                    + "st_lastName = N'{3}', "
                    + "st_phone = '{4}', "
                    + "st_email = '{5}', "
                    + "st_gender = {6} "
                + "where st_id='{0}'",
                s.St_id, s.St_password, s.St_firstName, s.St_lastName, s.St_phone, s.St_email, s.St_gender ? 1 : 0
                );
            return DataProvider.ExecuteNonQuery(query);
        }
        public static bool addStaff(Staffs_DTO s)
        {
            string query = string.Format(
                " insert into staffs values"
                + " ("
                + " '{0}',"
                + " '{0}',"
                + " N'{1}',"
                + " N'{2}',"
                + " '{3}',"
                + " '{4}',"
                + " {5},"
                + " 0,"
                + " '12/22/2000',"
                + " 100000,"
                + " 1,"
                + " '000'"
                + " )",
                s.St_id, s.St_firstName, s.St_lastName, s.St_phone, s.St_email, s.St_gender ? 1 : 0
                );
            return DataProvider.ExecuteNonQuery(query);
        }
    }
}
