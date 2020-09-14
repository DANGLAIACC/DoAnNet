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
            new Temp();
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

        public Delegate userFunctionPointer;

        private void btn_Click(object sender, EventArgs e)
        {
            userFunctionPointer.DynamicInvoke(1);
            Order_detail_DTO item = new Order_detail_DTO(_img, _name, _price);
            //Console.WriteLine("Thêm sản phẩm: "+item);
            bool notExists = true;
            for (int i = 0; i < Temp.cart.Count; i++)
                if (Temp.cart[i].Pd_id == _img)
                {
                    notExists = false;
                    Temp.cart[i].Od_quantity++;
                    break;
                }
            if(notExists) Temp.cart.Add(item);
        }
    }
}
