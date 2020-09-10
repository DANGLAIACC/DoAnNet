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

namespace DoAnNet.UserControls
{
    public partial class UC_SanPham_item : UserControl
    {
        public UC_SanPham_item()
        {
            InitializeComponent();
        }
        #region Properties
        private string _name,_img;
        private decimal _price;

        [Category("Custom Props")]
        public string Pname
        {
            get { return _name; }
            set { _name = value; lbl.Text = value; }
        }

        [Category("Custom Props")]
        public decimal Price
        {
            get { return _price; }
            set
            {
                _price = value;
                lblGia.Text = _price.ToString("#,##0")+"đ";
            }
        }
        [Category("Custom Props")]
        public string Img
        {
            get { return _img; }
            set {
                _img = value;
                //Console.WriteLine(System.IO.Directory.GetCurrentDirectory());
                //Console.WriteLine("path: "+path); 

                string path = @"/image/" + _img + ".jpg";
                //if(System.IO.File.Exists(path))
                //    ptb.Image = Image.FromFile(@"image/" + _img + ".jpg");
                //else
                    ptb.Image = Image.FromFile(@"image/" + _img + ".jpg");

            }
        }

        #endregion

        public Delegate TongSanPham;

        private void btn_Click(object sender, EventArgs e)
        { 
            CartItem_DTO item = new CartItem_DTO(_img, _name, _price);
            Console.WriteLine("Thêm sản phẩm: "+item);
            int tongSanPham = 0;
            bool isExists = true;
            for (int i = 0; i < Cart.cart.Count; i++)
            {
                tongSanPham += Cart.cart[i].SoLuong;
                if (Cart.cart[i].MaSP == _img)
                {
                    Cart.cart[i].SoLuong++;
                    isExists = false;
                }
            }
            if(isExists) Cart.cart.Add(item);
            tongSanPham++;
            frmMain.count = tongSanPham;
            Console.WriteLine(frmMain.count);

            TongSanPham.DynamicInvoke(tongSanPham);

        }
    }
}
