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
using BLL;

namespace DoAnNet
{
    public partial class UC_NhanVien : UserControl
    {
        private Staffs_DTO staff;
        public UC_NhanVien(Staffs_DTO staff)
        {
            this.staff = staff;
            InitializeComponent();
        }

        private void UC_NhanVien_Load(object sender, EventArgs e)
        {
            lblHeader.Text = ("Xin chào " + staff.St_firstName + " " + staff.St_lastName).ToUpper();

            txtSt_id.Text = staff.St_id;
            lblSt_workdays.Text = staff.St_workdays.ToString();
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

            btnLuu.Enabled = false;
        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            frmDoiMatKhau f = new frmDoiMatKhau(false, staff);
            f.ShowDialog();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtSt_firstName.Text == "" || txtSt_lastName.Text==""
                || txtSt_phone.Text == "" || txtSt_email.Text == "")
            {
                frmAlert frm = new frmAlert();
                frm.showAlert("Thông tin không hợp lệ.",
                    frmAlert.enmType.Error);
                return;
            }
            staff.St_firstName = txtSt_firstName.Text;
            staff.St_lastName = txtSt_lastName.Text;
            staff.St_phone = txtSt_phone.Text;
            staff.St_email = txtSt_email.Text;
            staff.St_gender = btnGioiTinh.Checked;

            frmDoiMatKhau f = new frmDoiMatKhau(true, staff);
            f.ShowDialog();
        }

        private void txtSt_phone_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar);
        }

        private void btnGioiTinh_CheckedChanged(object sender, EventArgs e)
        {
            lblGioiTinh.Text = btnGioiTinh.Checked ? "Nam" : "Nữ";
        }
    }
}
