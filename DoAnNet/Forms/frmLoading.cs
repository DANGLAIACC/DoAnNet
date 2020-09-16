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

namespace DoAnNet.Forms
{
    public partial class frmLoading : Form
    {
        public frmLoading()
        {
            InitializeComponent();
            ShowInTaskbar = false; 
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            if (localVariable.ucDanhSachKhachHang == null)
            {
                List<Customers_DTO> lstKhachHang = Customer_BLL.LoadCustomers();
                localVariable.ucDanhSachKhachHang = new UC_DanhSachKhachHang(lstKhachHang);
            }
        }
    }
}
