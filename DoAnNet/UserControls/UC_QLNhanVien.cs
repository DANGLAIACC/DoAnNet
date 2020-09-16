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

namespace DoAnNet
{
    public partial class UC_QLNhanVien : UserControl
    {
        private List<Staffs_DTO> lst;
        public UC_QLNhanVien(List<Staffs_DTO> lst)
        {
            this.lst = lst;
            InitializeComponent();
        }

        private void UC_QLNhanVien_Load(object sender, EventArgs e)
        {
            foreach (Staffs_DTO s in lst)
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

        }

        private void btnSua_Click(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

        }
    }
}
