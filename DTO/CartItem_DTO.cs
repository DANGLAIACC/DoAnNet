using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class CartItem_DTO
    {
        private string maSP, tenSP;

        public string TenSP
        {
            get { return tenSP; }
            set { tenSP = value; }
        }

        public string MaSP
        {
            get { return maSP; }
            set { maSP = value; }
        }
        private decimal gia;

        public decimal Gia
        {
            get { return gia; }
            set { gia = value; }
        }
        private int soLuong;

        public int SoLuong
        {
            get { return soLuong; }
            set { soLuong = value; }
        }
        public CartItem_DTO(string maSP, string tenSP, decimal gia)
        {
            this.maSP = maSP;
            this.tenSP = tenSP;
            this.gia = gia;
            this.soLuong = 1;
        }
    }
}
