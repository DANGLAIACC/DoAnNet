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
    public partial class frmNhapKhachHang : Form
    {
        private List<Customers_DTO> lstCustomer;
        private List<Agencies_DTO> lstAgencies;
        public frmNhapKhachHang(string soHoaDon, string tenNhanVien, string ngayLap)
        {
            InitializeComponent();
            lblSoHoaDon.Text = soHoaDon;
            lblTenNhanVien.Text = tenNhanVien;
            lblTime.Text = ngayLap;
        }
        private Orders2_DTO o;
        public frmNhapKhachHang(string orderId)
        {
            InitializeComponent(); 
            txtDT1.TextChanged -= txtDT1_TextChanged;

            o = Orders_BLL.LoadOrderByOdId(orderId);

            lblSoHoaDon.Text = o.Od_id;
            lblTenNhanVien.Text = o.SName;
            lblTime.Text = o.NgayMua;
            txtDT1.Text = o.Ct_phone;
            txtDT2.Text = o.Ct_phone;
            txtTenKH1.Text = o.CName;
            txtTenKH2.Text = o.CName;
            txtDiaChi1.Text = o.Ct_address;
            txtDiaChi2.Text = o.Ct_address;
            txtNgayMua.Text = o.NgayMua;
            txtNgayNhan.Text = o.NgayNhan;
            cboChiNhanh.DataSource = o.Ag_address;

            txtDT1.Enabled = false;
            txtTenKH1.Enabled = false;
            txtDiaChi1.Enabled = false;
            txtNgayMua.Enabled = false;
            txtDT2.Enabled = false;
            txtTenKH2.Enabled = false;
            txtDiaChi2.Enabled = false;
            txtNgayNhan.Enabled = false;
            btnCopy.Enabled = false;
            btnReset.Enabled = false;
            btnRefresh.Enabled = false;
            cboChiNhanh.Enabled = false;
            
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

            for(int i=0;i<lstAgencies.Count;i++)
            {
                if(lstAgencies[i].Ag_address==tenChiNhanh)
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
        private void firstLoad()
        {
            btnRefresh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;

            loadAutocompleKhachHang();
            loadCboChiNhanh(o.Ag_address);

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
        private void transferTextbox(Guna2TextBox txt1, Guna2TextBox txt2)
        {
            txt2.Enabled = false;
            txt2.Text = txt1.Text;

            txt1.TextChanged += (o, e) =>
            {
                txt2.Text = txt1.Text;
            };
        }
        private void btnCopy_CheckedChanged(object sender, EventArgs e)
        {
            if (btnCopy.Checked)
            {
                transferTextbox(txtDiaChi1, txtDiaChi2);
                transferTextbox(txtTenKH1, txtTenKH2);
                transferTextbox(txtDT1, txtDT2);
                transferTextbox(txtNgayMua, txtNgayNhan);
            }
            else
            {
                txtTenKH2.Enabled = true;
                txtDiaChi2.Enabled = true;
                txtDT2.Enabled = true;
                txtNgayNhan.Enabled = true;
            }
        }

        private void txtDT1_TextChanged(object sender, EventArgs e)
        {
            if (txtDT1.Text.Length == 10)
            {
                string text = txtDT1.Text;
                foreach (Customers_DTO c in lstCustomer)
                {
                    if (c.Ct_phone == text)
                    {
                        txtTenKH1.Text = c.Ct_firstName + " " + c.Ct_lastName;
                        txtDiaChi1.Text = c.Ct_address;
                        txtNgayMua.Text = DateTime.Now.ToString("hh:mm:ss dd/MM/yyyy");
                        return;
                    }
                }
            }
        }

        private void txtDT1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtTenKH1.Text = txtDiaChi1.Text = txtDT1.Text = txtNgayMua.Text = txtDT2.Text = txtTenKH2.Text = txtNgayNhan.Text = txtDiaChi2.Text = "";
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtNgayMua.Text = DateTime.Now.ToString("hh:mm:ss dd/MM/yyyy");
        }

        private void btnRefresh_MouseHover(object sender, EventArgs e)
        {
            btnRefresh.BackColor = Color.White;
        }
    }
}
