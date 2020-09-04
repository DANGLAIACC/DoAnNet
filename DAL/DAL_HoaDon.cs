using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;

namespace DAL
{
    public class DAL_HoaDon
    {
        public static List<DTO_HoaDon> LoadHoaDon()
        {
            string query = @"select * from hoadon";
            DataTable table = new DataTable();
            table = DataProvider.Execute(query);
            int count = table.Rows.Count;
            if (table != null && count > 0)
            {
                List<DTO_HoaDon> lstHoaDon = new List<DTO_HoaDon>();
                DTO_HoaDon h;
                for (int i = 0; i < count; i++)
                {
                    h = new DTO_HoaDon();
                    h.Ma_hd = Int32.Parse(table.Rows[i]["Ma_hd"].ToString());
                    h.Ngay_lap_hd = DateTime.Parse(table.Rows[i]["Ngay_lap_hd"].ToString());
                    h.Ngay_giao = DateTime.Parse(table.Rows[i]["ngay_giao"].ToString());
                    h.Ma_nv = Int32.Parse(table.Rows[i]["ma_nv"].ToString());
                    h.Ma_kh = Int32.Parse(table.Rows[i]["ma_kh"].ToString());
                    lstHoaDon.Add(h);
                }
                return lstHoaDon;
            }
            return null;
        }
    }
}
