using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_SanPham
    {
        public int Ma_sp { get; set; }
        public string Ten_sp { get; set; }
        public decimal Gia_nhap { get; set; }
        public decimal Don_gia { get; set; }
        public string Hinh_dang_mat { get; set; }
        public string Kich_thuoc { get; set; }
        public string Chat_lieu { get; set; }
        public string Nang_luong { get; set; }
        public string Mau_sac { get; set; }
        public int Bao_hanh { get; set; }
        public int So_luong { get; set; }
        public int Ma_nsx { get; set; }
    }
}
