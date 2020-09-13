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
        }
        
        private void textbox_Enter(object o,EventArgs e)
        {
            Guna2TextBox txt = (Guna2TextBox) o;
            txt.BorderThickness = 3;
            txt.BorderColor = Color.Red;
            Console.WriteLine("Enter");
        }
        private void textbox_Leave(object o, EventArgs e)
        {
            Guna2TextBox txt = (Guna2TextBox)o;
            txt.BorderThickness = 1;
            txt.BorderColor = Color.FromArgb(117,117,117);
            Console.WriteLine("Leave");
        }

        private void frmNhapKhachHang_Load(object sender, EventArgs e)
        {

        }
    }
}
