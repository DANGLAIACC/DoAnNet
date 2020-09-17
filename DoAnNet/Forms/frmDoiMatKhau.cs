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
using DoAnNet.Forms;
using BLL;

namespace DoAnNet.Forms
{
    public partial class frmDoiMatKhau : Form
    {
        private bool isUpdateAll;
        private Staffs_DTO staff;
        /// <summary>
        /// Hộp thoại yêu cầu nhập mật khẩu
        /// Hiện lúc thay đổi thông tin và lúc thay đổi mật khẩu
        /// </summary>
        /// <param name="isUpdateAll">Yêu cầu mật khẩu khi cập nhật nhân viên</param>
        public frmDoiMatKhau(bool isUpdateAll, Staffs_DTO staff)
        {
            InitializeComponent();
            this.staff = staff;
            this.isUpdateAll = isUpdateAll;
            if (isUpdateAll)
            {
                this.Text = "Xác nhận danh tính";
                pnMain.Visible = false;
                lblCurrentPassword.Text = "Nhập mật khẩu";
                this.Height = 180;
                txtCurrentPassword.KeyPress += (o, e) =>
                {
                    if (e.KeyChar == (char)13)
                    {
                        btnLuu.PerformClick();
                    }
                };
            }
            txtCurrentPassword.Focus();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            frmAlert f = new frmAlert();

            if (txtCurrentPassword.Text == staff.St_password)
            {
                if (!isUpdateAll) // chỉ cập nhật mật khẩu
                {
                    // gán lại mật khẩu trong đối tượng staff
                    if (txtNewPassword.Text != txtNewPassword2.Text)
                    {
                        f.showAlert("Mật khẩu không trùng nhau.", frmAlert.enmType.Error);
                    }
                    else
                    {
                        staff.St_password = txtNewPassword.Text;
                    }
                }

                // cập nhật vào database
                frmAlert frm = new frmAlert();
                if (Staffs_BLL.updateStaff(staff))
                {
                    frm.showAlert("Cập nhật thành công.", frmAlert.enmType.Success);
                    this.Close();
                }
                else
                    frm.showAlert("Cập nhật thất bại.", frmAlert.enmType.Warning);
            }
            else
            {
                f.showAlert("Mật khẩu sai.", frmAlert.enmType.Error);
                txtCurrentPassword.Text = txtNewPassword.Text = txtNewPassword2.Text = "";
                txtCurrentPassword.Focus();
            }
        } 

    }
}
