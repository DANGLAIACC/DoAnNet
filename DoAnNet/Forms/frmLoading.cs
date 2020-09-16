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
            backgroundWorker1.RunWorkerAsync();

        }
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            List<Customers_DTO> lstKhachHang = Customer_BLL.LoadCustomers();
        }
    }
}
