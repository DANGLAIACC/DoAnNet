using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;
namespace DAL
{
    public class DAL_CTHoaDon
    {
        public static List<DTO_CTHoaDon> LoadCTHoaDon()
        {
            string query = @"select * from cthoadon";
            DataTable table = new DataTable();
            table = DataProvider.Execute(query);
            int count = table.Rows.Count;
            if (table != null && count > 0)
            {
                List<DTO_CTHoaDon> lstCtHoaDon = new List<DTO_CTHoaDon>();
                DTO_CTHoaDon c;
                for (int i = 0; i < count; i++)
                {
                    c = new DTO_CTHoaDon();
                    c.Ma_hd = Int32.Parse(table.Rows[i]["Ma_hd"].ToString());
                    c.Ma_sp = Int32.Parse(table.Rows[i]["Ma_sp"].ToString());
                    c.So_luong = Int32.Parse(table.Rows[i]["So_luong"].ToString());
                    c.Gia_ban = Decimal.Parse(table.Rows[i]["gia_ban"].ToString());
                    lstCtHoaDon.Add(c);
                }
                return lstCtHoaDon;
            }
            return null;
        }
    }
}
