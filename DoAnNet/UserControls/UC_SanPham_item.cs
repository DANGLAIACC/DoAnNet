using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
                
                //string path = @"/image/" + _img + ".jpg";
                //Console.WriteLine("path: "+path);

                ptb.Image = Image.FromFile(@"image/" + _img + ".jpg");
            }
        }

        #endregion
    }
}
