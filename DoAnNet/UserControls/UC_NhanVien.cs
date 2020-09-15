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
using DoAnNet.Forms;

namespace DoAnNet.UserControls
{
    public partial class UC_NhanVien : UserControl
    { 
        private Staffs_DTO staff;
        public UC_NhanVien(Staffs_DTO staff)
        {
            InitializeComponent();

            this.staff = staff;
        }

        private void UC_NhanVien_Load(object sender, EventArgs e)
        {
            lblHeader.Text = ("Xin chào " + staff.St_firstName + " " + staff.St_lastName).ToUpper();

            txtSt_firstName.Text = staff.St_firstName;
            txtSt_lastName.Text = staff.St_lastName;
            txtSt_phone.Text = staff.St_phone;
            txtSt_email.Text = staff.St_email;
            btnGioiTinh.Checked = staff.St_gender;
            lblGioiTinh.Text = staff.St_gender ? "Nam" : "Nữ";
        }
        
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtSt_firstName.Text = "";
            txtSt_lastName.Text = "";
            txtSt_phone.Text = "";
            txtSt_email.Text = "";
            btnGioiTinh.Checked = true;
            lblGioiTinh.Text = "Nam";
        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            frmDoiMatKhau f = new frmDoiMatKhau(false, staff);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            frmDoiMatKhau f = new frmDoiMatKhau(true, staff);
        }
    }
}
