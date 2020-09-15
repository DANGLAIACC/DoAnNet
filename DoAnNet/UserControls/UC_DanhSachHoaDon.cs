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
    public partial class UC_DanhSachHoaDon : UserControl
    {
        private List<Orders2_DTO> lst;
        public UC_DanhSachHoaDon(List<Orders2_DTO> lst)
        {
            InitializeComponent();
            this.lst = lst;
            foreach (Orders2_DTO o in lst)
            {
                grvHoaDon.Rows.Add(new string[] { string.Format("{0:000000000000}", o.Od_id), o.CName, o.NgayMua, o.NgayNhan, o.Total});
            }
        }

        private void guna2DataGridView1_DoubleClick(object sender, EventArgs e)
        {
            string id = grvHoaDon.SelectedRows[0].Cells["od_id"].Value.ToString();
            Console.WriteLine("selected od_id: " + id);

            foreach (Orders2_DTO o in lst)
            {
                if(o.Od_id == id)
                {
                    List<Order_detail_DTO> lst2 = Order_detail_BLL.getOrderDetailById(id);

                    frmRptCart f = new frmRptCart(
                        o.Ag_address,
                        o.NgayMua,
                        o.Od_id,
                        o.SName,
                        o.CName,
                        o.Ct_address,
                        o.Ct_phone,
                        o.CName,
                        o.Ct_address,
                        o.Ct_phone,
                        o.NgayNhan,
                        lst2
                        );

                    f.ShowDialog();
                    return;
                }
            }
        }
    }
}
