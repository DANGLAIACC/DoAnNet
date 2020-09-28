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
namespace DoAnNet.Reports
{
    public partial class frmRptCart : Form
    {
        public string StoreAddress { get; set; }
        public string NgayLap { get; set; }
        public string SoHoaDon { get; set; }
        public string TenNhanVien { get; set; }
        public string TenKH1 { get; set; }
        public string DiaChi1 { get; set; }
        public string DienThoai1 { get; set; }
        public string NgayMua { get; set; }
        public string TenKH2 { get; set; }
        public string DiaChi2 { get; set; }
        public string DienThoai2 { get; set; }
        public string NgayGiao { get; set; }

        private crptCart c;

        public frmRptCart()
        {
            InitializeComponent();
            ShowInTaskbar = false;
        }

        public frmRptCart(string storeAddress, string ngayLap, string soHoaDon, string tenNhanVien, string tenKH1, string diaChi1, string dienThoai1 , string tenKH2, string diaChi2, string dienThoai2, string ngayGiao, List<Order_detail_DTO> lst)
        {
            InitializeComponent();

            StoreAddress = storeAddress;
            NgayLap = ngayLap;
            SoHoaDon = soHoaDon;
            TenNhanVien = tenNhanVien;
            TenKH1 = tenKH1;
            DiaChi1 = diaChi1;
            DienThoai1 = dienThoai1; 
            TenKH2 = tenKH2;
            DiaChi2 = diaChi2;
            DienThoai2 = dienThoai2;
            NgayGiao = ngayGiao;

            c = new crptCart();
            c.SetDataSource(lst);

        }

        private void frmRptCart2_Load(object sender, EventArgs e)
        { 
            c.SetParameterValue("storeAddress", StoreAddress);
            c.SetParameterValue("ngayLap", NgayLap);
            c.SetParameterValue("soHoaDon", SoHoaDon);
            c.SetParameterValue("tenNhanVien", TenNhanVien);
            c.SetParameterValue("TenKH1", TenKH1);
            c.SetParameterValue("DiaChi1", DiaChi1);
            c.SetParameterValue("DienThoai1", DienThoai1);
            c.SetParameterValue("NgayMua", NgayLap);
            c.SetParameterValue("TenKH2", TenKH2);
            c.SetParameterValue("DiaChi2", DiaChi2);
            c.SetParameterValue("DienThoai2", DienThoai2);
            c.SetParameterValue("NgayGiao", NgayGiao);

            crystalReportViewer1.ReportSource = c;

        }

        private void InitializeComponent()
        {
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(858, 419);
            this.crystalReportViewer1.TabIndex = 0;
            this.crystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // frmRptCart2
            // 
            this.ClientSize = new System.Drawing.Size(1096, 708);
            this.Controls.Add(this.crystalReportViewer1);
            this.Name = "frmRptCart2";
            this.Load += new System.EventHandler(this.frmRptCart2_Load);
            this.ResumeLayout(false);

        }
    }
}
