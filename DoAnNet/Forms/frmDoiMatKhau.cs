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

namespace DoAnNet.Forms
{
    public partial class frmDoiMatKhau : Form
    {
        /// <summary>
        /// Hộp thoại yêu cầu nhập mật khẩu
        /// Hiện lúc thay đổi thông tin và lúc thay đổi mật khẩu
        /// </summary>
        /// <param name="requestPassword">Yêu cầu mật khẩu khi thay đổi thông tin</param>
        public frmDoiMatKhau(bool requestPassword, Staffs_DTO staff)
        {
            InitializeComponent();
            if (requestPassword)
            {
                pnMain.Visible = false;
                lblCurrentPassword.Text = "Nhập mật khẩu";
                this.Height = 100;
                txtCurrentPassword.KeyPress += (o, e) =>
                {
                    if (e.KeyChar == (char)13)
                    {
                        if (txtCurrentPassword.Text == staff.St_password)
                            Console.WriteLine("Mật khẩu đúng");
                        else
                            Console.WriteLine("Mật khẩu sai");
                    }
                };
            }
            txtCurrentPassword.Focus();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

    }
}
