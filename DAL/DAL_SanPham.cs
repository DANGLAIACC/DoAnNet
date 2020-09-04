using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class DAL_SanPham
    {
        public static List<DTO_SanPham> LoadSanPham()
        {
            string query = @"select * from sanpham";
            DataTable table = new DataTable();
            table = DataProvider.Execute(query);
            int count = table.Rows.Count;
            if (table != null && count > 0)
            {
                List<DTO_SanPham> lstSanPham = new List<DTO_SanPham>();
                DTO_SanPham sp;
                for (int i = 0; i < count; i++)
                {
                    sp = new DTO_SanPham();
                    sp.Ma_sp = Int32.Parse(table.Rows[i]["Ma_sp"].ToString());
                    sp.Ten_sp = table.Rows[i]["Ten_sp"].ToString();
                    sp.Gia_nhap = Decimal.Parse( table.Rows[i]["Gia_nhap"].ToString());
                    sp.Don_gia= Decimal.Parse(table.Rows[i]["Don_gia"].ToString());
                    sp.Hinh_dang_mat = table.Rows[i]["Hinh_dang_mat"].ToString();
                    sp.Kich_thuoc = table.Rows[i]["Kich_thuoc"].ToString();
                    sp.Chat_lieu= table.Rows[i]["Chat_lieu"].ToString();
                    sp.Nang_luong = table.Rows[i]["Nang_luong"].ToString();
                    sp.Mau_sac = table.Rows[i]["Mau_sac"].ToString();
                    sp.Bao_hanh= Int32.Parse(table.Rows[i]["Bao_hanh"].ToString());
                    sp.So_luong= Int32.Parse(table.Rows[i]["So_luong"].ToString());
                    sp.Ma_nsx = Int32.Parse(table.Rows[i]["Ma_nsx"].ToString());
                    lstSanPham.Add(sp);
                }
                return lstSanPham;
            }
            return null;
        }
    }
}
