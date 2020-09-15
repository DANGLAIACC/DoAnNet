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
using BLL;
using DTO;

namespace DoAnNet.Forms
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            txtUsername.Focus();
        }

        private void btnPassword_Click(object sender, EventArgs e)
        {
            Application.Exit();
        } 

        private void btnLogin_Click(object sender, EventArgs e)
        {
            frmAlert frmAlert = new frmAlert();
            if (txtNotEmpty(txtUsername, "Tên đăng nhập") &
                txtNotEmpty(txtPassword,"Mật khẩu"))
            {
                // cả 2 ô nhập vào đều có dữ liệu
                string username = txtUsername.Text.Trim(),
                    password = txtPassword.Text.Trim();
                Staffs_DTO s = Staffs_BLL.GetStaffByLogin(username, password);

                if(s == null) // đăng nhập sai
                {
                    frmAlert.showAlert(
                        "Thông tin sai.",
                        frmAlert.enmType.Error);
                    txtUsername.Text = "";
                    txtPassword.Text = "";
                    txtUsername.Focus();
                }else
                {
                    frmAlert.showAlert(
                        "Xin chào "+s.St_firstName+" "+s.St_lastName, 
                        frmAlert.enmType.Success);

                }
            }

        }
        private bool txtNotEmpty(Guna2TextBox txt, string strError)
        {
            if (txt.Text.Trim() == "")
            {
                err.SetError(txt, strError+" không được để trống.");
                txt.Focus();
                return false;
            }
            else
            {
                err.SetError(txt, "");
                return true;
            }
        }
    }
}
