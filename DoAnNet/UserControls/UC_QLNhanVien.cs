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
using DoAnNet.Forms;

namespace DoAnNet
{
    public partial class UC_QLNhanVien : UserControl
    {
        public UC_QLNhanVien()
        {
            InitializeComponent();
        }

        private void UC_QLNhanVien_Load(object sender, EventArgs e)
        {
            loadGridView();
        }
        private void loadGridView()
        { 
            grvNhanVien.Rows.Clear();
            foreach (Staffs_DTO s in localVariable.lstStaff)
            {
                grvNhanVien.Rows.Add(new string[]
                {
                    s.St_id,
                    s.St_firstName+" "+s.St_lastName,
                    s.Ag_id,
                    s.St_workdays.ToString(),
                    s.St_salary.ToString("#,##0"),
                    (s.St_workdays*s.St_salary)
                    .ToString("#,##0")
                });
            }
        }

        private void grvNhanVien_DoubleClick(object sender, EventArgs e)
        {

        }

        private void btnIn_Click(object sender, EventArgs e)
        {
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            frmThemNhanVien f = new frmThemNhanVien();
            f.ShowDialog();

            Console.WriteLine("Chưa vào form closed");

            f.FormClosed +=  (o, er) =>
            {
                loadGridView();
            };
        }

        private void btnSua_Click(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

        }
    }
}
