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
using BLL;
using DoAnNet.Reports;

namespace DoAnNet.UserControls
{
    public partial class UC_DanhSachKhachHang : UserControl
    {
        private List<Customers_DTO> lst;
        public UC_DanhSachKhachHang(List<Customers_DTO> lst)
        {
            InitializeComponent();
            this.lst = lst;
            foreach (Customers_DTO c in lst)
            {
                grvKhachHang.Rows.Add(new string[]
                {
                    string.Format("{0:0000000}", c.Ct_id),
                    c.Ct_firstName+" "+c.Ct_lastName,
                    c.Ct_phone,
                    c.Ct_address
                });
                //grvHoaDon.Rows.Add(new string[] { string.Format("{0:000000000000}", o.Od_id), o.CName, o.NgayMua, o.NgayNhan, o.Total});
            }
        }

        private void guna2DataGridView1_DoubleClick(object sender, EventArgs e)
        {

        }
    }
}
