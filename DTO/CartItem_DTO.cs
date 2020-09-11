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
        private decimal gia;
        private int soLuong;

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

        public decimal Gia
        {
            get { return gia; }
            set { gia = value; }
        }

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
        public override string ToString()
        {
            return maSP + " - " + tenSP + " - " + gia.ToString("#,##0");
        }
    }
}
