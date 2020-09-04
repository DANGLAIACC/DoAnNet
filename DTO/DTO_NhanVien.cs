using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_NhanVien
    {
        public int Ma_nv { get; set; }
        public string Ten_nv { get; set; }
        public string Dien_thoai { get; set; }
        public string Email { get; set; }
        public string Dia_chi { get; set; }
        public float So_ngay_cong { get; set; }
        public decimal Luong_cb { get; set; }
    }
}
