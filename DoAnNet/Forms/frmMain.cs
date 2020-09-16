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
using DoAnNet.UserControls;
using DoAnNet.Forms;
#pragma warning disable 0436

namespace DoAnNet
{
    public partial class frmMain : Form
    {
        private int count = 0;

        public delegate void functioncall(int i);
        private event functioncall formFunctionPointer;
        private Staffs_DTO staff;
        private List<Products_DTO> lstProduct;

        public frmMain()
        {
            InitializeComponent();
        }

        public frmMain(Staffs_DTO staff)
        {
            InitializeComponent();

            this.staff = staff;
        }
        private void loadSanPham()
        {
            lstProduct = Products_BLL
                .LoadProducts();
            int count = lstProduct.Count;
            if (count > 0)
            {
                UC_SanPham_item[] lstItem = new UC_SanPham_item[count];
                for (int i = 0; i < count; i++)
                {
                    lstItem[i] = new UC_SanPham_item();
                    lstItem[i].Pname = lstProduct[i].Pd_name;
                    lstItem[i].Price = lstProduct[i].Pd_retail;
                    lstItem[i].Img = lstProduct[i].Pd_id;

                    lstItem[i].userFunctionPointer = formFunctionPointer;

                    flpSanPham.Controls.Add(lstItem[i]);
                }
            }
        }

        private void increseCart(int i)
        {
            count += i;
            btnCartCount.Text = count.ToString();
        }

        private void addUserControl(UserControl uc)
        {
            panel0.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            uc.BringToFront();
            panel0.Controls.Add(uc);
        }

        private void button_CheckedChanged(object sender, EventArgs e)
        {
            Guna2Button b = (Guna2Button)sender;
            imgSlide.Location =
                new Point(b.Location.X + 24, b.Location.Y - 25);
            imgSlide.SendToBack();
        } 
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
            if (Temp.cart.Count > 0)
            {
                frmNhapKhachHang f = new frmNhapKhachHang(
                    "012345678912", "Đặng Quốc Lai", "13:12:00 14/09/2020", "123 Nguyễn Hữu Cảnh, Q. Bình Thạnh, TP. Hồ Chí Minh");

                f.ShowDialog();
            }
            else
            {
                Alert("Giỏ hàng đang trống.", frmAlert.enmType.Error);
                //Alert("Success Alert", frmAlert.enmType.Success);
                //Alert("Warning Alert", frmAlert.enmType.Warning);
                //Alert("Info Alert", frmAlert.enmType.Info);
                //MessageBox.Show("Giỏ hàng hiện đang trống.", "In đơn hàng");
            }
        }

        public void Alert(string msg, frmAlert.enmType type)
        {
            frmAlert frm = new frmAlert();
            frm.showAlert(msg, type);
        }

        private void btnSanPham_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "Danh sách sản phẩm";
            flpSanPham.Show();
            pnMain.Hide();
        }

        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            if (localVariable.ucDanhSachHoaDon == null)
            {
                List<Orders2_DTO> lstHoaDon = Orders_BLL.LoadAllOrder();
                localVariable.ucDanhSachHoaDon = new UC_DanhSachHoaDon(lstHoaDon);
            }
            addToPnMain(localVariable.ucDanhSachHoaDon,
                "Danh sách hóa đơn");
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            // Move to frmLoading

            if (localVariable.ucDanhSachKhachHang == null)
            {
                List<Customers_DTO> lstKhachHang = Customer_BLL.LoadCustomers();
                localVariable.ucDanhSachKhachHang = new UC_DanhSachKhachHang(lstKhachHang);
            }

            addToPnMain(localVariable.ucDanhSachKhachHang,
                "Danh sách khách hàng");

        }

        private void ptbUser_Click(object sender, EventArgs e)
        {
            //UC_NhanVien2 n = new UC_NhanVien2(staff);
            UC_NhanVien n = new UC_NhanVien(staff);

            addToPnMain(n, "Xem chi tiết nhân viên");
        }

        private void addToPnMain(UserControl uc, string title)
        {
            pnMain.Controls.Clear();
            pnMain.Controls.Add(uc);
            uc.Dock = DockStyle.Fill;

            lblTitle.Text = title;
            flpSanPham.Hide();
            pnMain.Show();
        } 
        private void frmMain_Load(object sender, EventArgs e)
        {
            btnCartCount.Text = "0";
            formFunctionPointer += new functioncall(increseCart);
            loadSanPham();
            flpSanPham.Show();
            pnMain.Hide();
        }

        private void btnThongBao_Click(object sender, EventArgs e)
        {
            frmAlert frm = new frmAlert();
            frm.showAlert("Đang phát triển.", frmAlert.enmType.Info);
        }
        //private void button1_Click(object sender, EventArgs e)
        //{
        //    pnMain.Controls.Clear();
        //}
    }
}
