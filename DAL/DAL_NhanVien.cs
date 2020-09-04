using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;

namespace DAL
{
    public class DAL_NhanVien
    {
        public static List<DTO_NhanVien> LoadNhanVien()
        {
            string query = @"select * from nhanvien";
            DataTable table = new DataTable();
            table = DataProvider.Execute(query);
            int count = table.Rows.Count;
            if (table != null && count > 0)
            {
                List<DTO_NhanVien> lstNhanVien= new List<DTO_NhanVien>();
                DTO_NhanVien n;
                for (int i = 0; i < count; i++)
                {
                    n = new DTO_NhanVien();
                    n.Ma_nv = Int32.Parse(table.Rows[i]["Ma_nv"].ToString());
                    n.Ten_nv = table.Rows[i]["Ten_nv"].ToString();
                    n.Dien_thoai= table.Rows[i]["Dien_thoai"].ToString();
                    n.Email= table.Rows[i]["Email"].ToString();
                    n.Dia_chi = table.Rows[i]["Dia_chi"].ToString();
                    n.So_ngay_cong = Int32.Parse(table.Rows[i]["So_ngay_cong"].ToString());
                    n.Luong_cb = Decimal.Parse(table.Rows[i]["Luong_cb"].ToString());
                    lstNhanVien.Add(n);
                }
                return lstNhanVien;
            }
            return null;
        }
    }
}
