using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace DoAnNet.Forms
{
    public partial class frmNhapKhachHang : Form
    {
        public frmNhapKhachHang()
        {
            InitializeComponent();

            #region Add Event for textbox
            eventTextbox(txtDT1);
            eventTextbox(txtTenKH1);
            eventTextbox(txtDiaChi1);
            eventTextbox(txtNgayMua);
            eventTextbox(txtDT2);
            eventTextbox(txtTenKH2);
            eventTextbox(txtDiaChi2);
            eventTextbox(txtNgayNhan);
            #endregion

        }

        private void eventTextbox(Guna2TextBox txt)
        {
            txt.Enter += (o, e) =>
            {
                txt.BorderThickness = 3;
                txt.BorderColor = Color.FromArgb(128, 189, 255);
            };
            txt.Leave += (o, e) =>
            {
                txt.BorderThickness = 1;
                txt.BorderColor = Color.FromArgb(117, 117, 117);
            };
        }

        private void frmNhapKhachHang_Load(object sender, EventArgs e)
        {

        }
    }
}
