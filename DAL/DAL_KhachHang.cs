using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;

namespace DAL
{
    public class DAL_KhachHang
    {
        public static List<DTO_KhachHang> LoadKhachHang()
        {
            string query = @"select * from khachhang";
            DataTable table = new DataTable();
            table = DataProvider.Execute(query);
            int count = table.Rows.Count;
            if (table != null && count > 0)
            {
                List<DTO_KhachHang> lstKhachHang = new List<DTO_KhachHang>();
                DTO_KhachHang k;
                for (int i = 0; i < count; i++)
                {
                    k = new DTO_KhachHang();
                    k.Ma_kh = Int32.Parse(table.Rows[i]["Ma_kh"].ToString());
                    k.Ten_kh = table.Rows[i]["Ten_kh"].ToString();
                    k.Dien_thoai= table.Rows[i]["Dien_thoai"].ToString();
                    k.Email= table.Rows[i]["Email"].ToString();
                    k.Dia_chi = table.Rows[i]["Dia_chi"].ToString();
                    lstKhachHang.Add(k);
                }
                return lstKhachHang;
            }
            return null;
        }
    }
}
