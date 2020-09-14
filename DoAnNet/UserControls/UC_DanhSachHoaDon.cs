using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnNet.UserControls
{
    public partial class UC_DanhSachHoaDon : UserControl
    {
        public UC_DanhSachHoaDon()
        {
            InitializeComponent();
        }

        private void UC_DanhSachHoaDon_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 20; i++)
            {
                guna2DataGridView1.Rows.Add(new string[] { string.Format("{0:000000000000}",(i+1)), "Huỳnh Thị Thúy Kiều", "23:00:00 23/11/2020", "23:00:00 23/11/2020","17.300.000" });
            }

        }

        private void guna2DataGridView1_DoubleClick(object sender, EventArgs e)
        {
            string str = guna2DataGridView1.SelectedRows[0].Cells["od_id"].Value.ToString();
            Console.WriteLine("datagridview selected od_id: " + str);
        }
    }
}
