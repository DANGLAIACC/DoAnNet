using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BLL;

namespace DoAnNet.UserControls
{
    public partial class UC_SanPham : UserControl
    {
        public UC_SanPham()
        {
            InitializeComponent();
        }
        public int TongSoLuong
        {
            get
            {
                int t = 0;
                for (int i = 0; i < Cart.cart.Count; i++)
                    t += Cart.cart[i].SoLuong;
                return t;
            }
        }
        private void UC_SanPham_Load(object sender, EventArgs e)
        {
            List<Products_DTO> lstProduct = Products_BLL
                .LoadProducts();
            int count = lstProduct.Count;
            //Console.WriteLine("count: " + count);
            if (count > 0)
            {
                UC_SanPham_item[] lstItem = new UC_SanPham_item[count];
                for (int i = 0; i < count; i++)
                {
                    lstItem[i] = new UC_SanPham_item();
                    lstItem[i].Pname = lstProduct[i].Pd_name;
                    lstItem[i].Price = lstProduct[i].Pd_retail;
                    lstItem[i].Img = lstProduct[i].Pd_id;

                    flpSanPham.Controls.Add(lstItem[i]);
                }
            }
        }
    }
}
