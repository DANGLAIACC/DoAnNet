using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BLL;

namespace DoAnNet
{
    public partial class frmMain : Form
    {
        public static int count = 0;

        private UserControls.UC_SanPham ucSanPham = new UserControls.UC_SanPham();

        public frmMain()
        {
            InitializeComponent();
            //UC_Home uC_ = new UC_Home();
            addUserControl(ucSanPham);
            btnCartCount.Text = ucSanPham.TongSoLuong.ToString();
            //label1.Text = System.IO.Directory.GetCurrentDirectory();
        } 
        private void addUserControl(UserControl uc)
        {
            pnMain.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            uc.BringToFront();
            pnMain.Controls.Add(uc);
        } 

        private void button_CheckedChanged(object sender, EventArgs e)
        {
            Guna2Button b = (Guna2Button)sender;
            imgSlide.Location = new Point(b.Location.X + 24, b.Location.Y - 25);
            imgSlide.SendToBack();
        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            UC_Home uC_ = new UC_Home();
            addUserControl(uC_);
        }

        private void btnGioHang_Click(object sender, EventArgs e)
        {

        }

        //private void loadBtnCartCount()
        //{
        //    Console.WriteLine("cart.count: " + Cart.cart.Count.ToString());
        //    btnCartCount.Text = Cart.cart.Count.ToString();
        //}
        private void btnClose_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
         

        private void btnInHoaDon_Click(object sender, EventArgs e)
        {

        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }
    }
}
