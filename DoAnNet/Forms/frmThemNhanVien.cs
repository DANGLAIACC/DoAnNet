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

namespace DoAnNet.Forms
{
    public partial class frmThemNhanVien : Form
    { 
        private int lstCount;
        public frmThemNhanVien()
        {
            InitializeComponent();
            lstCount = localVariable.lstStaff.Count;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtSt_id.Text==""||txtSt_firstName.Text == "" || txtSt_lastName.Text == ""
                || txtSt_phone.Text == "" || txtSt_email.Text == "")
            {
                frmAlert frm = new frmAlert();
                frm.showAlert("Thông tin không hợp lệ.",
                    frmAlert.enmType.Error);
                return;
            }
            Staffs_DTO staff = new Staffs_DTO();

            staff.St_id = txtSt_id.Text;
            staff.St_firstName = txtSt_firstName.Text;
            staff.St_lastName = txtSt_lastName.Text;
            staff.St_phone = txtSt_phone.Text;
            staff.St_email = txtSt_email.Text;
            staff.St_gender = btnGioiTinh.Checked;

            if (Staffs_BLL.addStaff(staff))
            {
                new frmAlert().showAlert("Thêm thành công.",
                    frmAlert.enmType.Success);
                localVariable.lstStaff.Add(staff);

                Close();
            }
            else
            {
                new frmAlert().showAlert("Thêm thất bại.",
                    frmAlert.enmType.Error);
            }
        }

        private void btnGioiTinh_CheckedChanged(object sender, EventArgs e)
        {
            lblGioiTinh.Text = btnGioiTinh.Checked ? "Nam" : "Nữ";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtSt_firstName.Text = "";
            txtSt_lastName.Text = "";
            txtSt_phone.Text = "";
            txtSt_email.Text = "";
            btnGioiTinh.Checked = true;
            lblGioiTinh.Text = "Nam";

            btnThem.Enabled = false;
        }

        private void txtSt_id_TextChanged(object sender, EventArgs e)
        {
            string st_id = txtSt_id.Text;
            if(st_id == "")
            {
                err.SetError(txtSt_id, "Tài khoản không được để trống");
                btnThem.Enabled = false;
            }
            else
            {
                for(int i = 0; i < lstCount; i++)
                {
                    if (localVariable.lstStaff[i].St_id == st_id)
                    {
                        err.SetError(txtSt_id, "Tài khoản đã tồn tại.");
                        btnThem.Enabled = false;
                        return;
                    }else
                    {
                        err.SetError(txtSt_id, "");
                        btnThem.Enabled = true;
                    }
                }
            }
        }
    }
}
