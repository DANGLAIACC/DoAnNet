using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoAnNet.UserControls;
using BLL;

namespace DoAnNet.Reports
{
    public partial class frmRptCart2 : Form
    {
        public frmRptCart2()
        {
            InitializeComponent();
        }

        private void frmRptCart2_Load(object sender, EventArgs e)
        {
            new Temp();
            
            crptCart c = new crptCart();
            c.SetDataSource(Temp.cart);

            c.SetParameterValue("storeAddress", "606 Quốc lộ 13, P. HBP, Q. Thủ Đức, TP. HCM");
            c.SetParameterValue("ngayLap", "22:55:00 22/12/2020");
            c.SetParameterValue("soHoaDon", "012345678912");
            c.SetParameterValue("tenNhanVien", "Đặng Quốc Lai");
            c.SetParameterValue("TenKH1", "Huỳnh Thị Thúy Kiều");
            c.SetParameterValue("DiaChi1", "123 Nguyễn Thị Minh Khai");
            c.SetParameterValue("DienThoai1", "9876543210");
            c.SetParameterValue("NgayMua", "22:55:00 22/12/2020");
            c.SetParameterValue("TenKH2", "Huỳnh Thị Thúy Kiều");
            c.SetParameterValue("DiaChi2", "228 Võ Văn Tần, Q.3, TP. HCM");
            c.SetParameterValue("DienThoai2", "8765432109");
            c.SetParameterValue("NgayGiao", "22:55:00 22/12/2020");

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
            this.ClientSize = new System.Drawing.Size(858, 419);
            this.Controls.Add(this.crystalReportViewer1);
            this.Name = "frmRptCart2";
            this.Load += new System.EventHandler(this.frmRptCart2_Load);
            this.ResumeLayout(false);

        }
    }
}
