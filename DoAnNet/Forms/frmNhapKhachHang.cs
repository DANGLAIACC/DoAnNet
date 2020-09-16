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
using DoAnNet.Reports;
using DoAnNet.UserControls;

#pragma warning disable 0436

namespace DoAnNet.Forms
{
    public partial class frmNhapKhachHang : Form
    {
        private List<Customers_DTO> lstCustomer;
        private List<Agencies_DTO> lstAgencies;
        private string st_id, ag_id;

        public frmNhapKhachHang(string soHoaDon, string tenNhanVien, string ngayLap, string ag_address, string st_id, string ag_id)
        {
            InitializeComponent();
            this.st_id = st_id;
            this.ag_id = ag_id;

            lblSoHoaDon.Text = soHoaDon;
            lblTenNhanVien.Text = tenNhanVien;
            lblTime.Text = ngayLap;

            btnRefresh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;

            loadAutocompleKhachHang();
            loadCboChiNhanh(ag_address);

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
        private void btnCopyCheckTrue()
        {

            txtDT1.TextChanged += txtDT1_TextChanged;
            txtDiaChi1.TextChanged += txtDiaChi1_TextChanged;
            txtTenKH1.TextChanged += txtTenKH1_TextChanged;
            txtNgayMua.TextChanged += txtNgayMua_TextChanged;

            txtTenKH2.Enabled = txtDiaChi2.Enabled = txtDT2.Enabled
            = txtNgayNhan.Enabled = false;

        }
        private void loadAutocompleKhachHang()
        {
            lstCustomer = Customer_BLL.LoadCustomers();
            AutoCompleteStringCollection autoCollection = new AutoCompleteStringCollection();
            foreach (Customers_DTO d in lstCustomer)
                autoCollection.Add(d.Ct_phone);
            txtDT1.AutoCompleteCustomSource = autoCollection;
        }
        private void loadCboChiNhanh(string tenChiNhanh)
        {
            lstAgencies = Agencies_BLL.LoadAgencies();
            cboChiNhanh.DataSource = lstAgencies;
            cboChiNhanh.DisplayMember = "Ag_address";

            for (int i = 0; i < lstAgencies.Count; i++)
            {
                if (lstAgencies[i].Ag_address == tenChiNhanh)
                {
                    cboChiNhanh.SelectedIndex = i;
                    return;
                }
            }
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
        private void btnCopy_CheckedChanged(object sender, EventArgs e)
        {
            if (btnCopy.Checked)
            {
                btnCopyCheckTrue();
            }
            else
            {
                txtDT1.TextChanged -= txtDT1_TextChanged;
                txtDiaChi1.TextChanged -= txtDiaChi1_TextChanged;
                txtTenKH1.TextChanged -= txtTenKH1_TextChanged;
                txtNgayMua.TextChanged -= txtNgayMua_TextChanged;

                txtTenKH2.Enabled = txtDiaChi2.Enabled = txtDT2.Enabled
                = txtNgayNhan.Enabled = true;

            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtTenKH1.Text = txtDiaChi1.Text = txtDT1.Text = txtNgayMua.Text = txtDT2.Text = txtTenKH2.Text = txtNgayNhan.Text = txtDiaChi2.Text = "";
            txtDT1.Focus();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtNgayMua.Text = DateTime.Now.ToString("hh:mm:ss dd/MM/yyyy");
        }

        private void btnRefresh_MouseHover(object sender, EventArgs e)
        {
            btnRefresh.BackColor = Color.White;
        }

        private void txtTenKH1_TextChanged(object sender, EventArgs e)
        {
            txtTenKH2.Text = txtTenKH1.Text;
        }

        private void txtDiaChi1_TextChanged(object sender, EventArgs e)
        {
            txtDiaChi2.Text = txtDiaChi1.Text;
        }

        private void txtNgayMua_TextChanged(object sender, EventArgs e)
        {
            txtNgayNhan.Text = txtNgayMua.Text;
        }

        private void frmNhapKhachHang_Load(object sender, EventArgs e)
        {
            btnCopyCheckTrue();
            txtNgayMua.Text = DateTime.Now.ToString("hh:mm:ss dd/MM/yyyy");
            timer1.Start();
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            // Thêm vào database

            string od_id = lblSoHoaDon.Text,
            od_dateDelivery = lblTime.Text,
            od_status = "0",
            od_address = txtDiaChi2.Text,
            od_payment = "Tiền mặt",
            ct_id = "0000000",
            pd_id = "";

            int cartCount = Temp.cart.Count;

            for (int i = 0; i < cartCount; i++)
            {
                Temp.cart[i].
            }

            frmRptCart f = new frmRptCart(
                cboChiNhanh.Text,
                txtNgayMua.Text,
                lblSoHoaDon.Text,
                lblTenNhanVien.Text,
                txtTenKH1.Text,
                txtDiaChi1.Text,
                txtDT1.Text,
                txtTenKH2.Text,
                txtDiaChi2.Text,
                txtDT2.Text,
                txtNgayNhan.Text,
                Temp.cart
                );

            f.ShowDialog();
        }
        private void txtDT1_TextChanged(object sender, EventArgs e)
        {
            txtDT2.Text = txtDT1.Text;

            if (txtDT1.Text.Length == 10)
            {
                string text = txtDT1.Text;
                foreach (Customers_DTO c in lstCustomer)
                {
                    if (c.Ct_phone == text)
                    {
                        txtTenKH1.Text = c.Ct_firstName + " " + c.Ct_lastName;
                        txtDiaChi1.Text = c.Ct_address;
                        txtNgayMua.Text = lblTime.Text;
                        return;
                    }
                }
            }
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("hh:mm:ss dd/MM/yyyy");
        }

        private void txtDT1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar);
        }
    }
}
