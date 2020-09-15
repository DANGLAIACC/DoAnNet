using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoAnNet.Reports;
using DoAnNet.Forms;

namespace DoAnNet
{
    static class Program
    { 
        [STAThread]
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new frmMain());
            //Application.Run(new frmAlert());
            //Application.Run(new frmNhapKhachHang("012345678912", "Đặng Quốc Lai", "10:30:28 14/09/2020", "123 Nguyễn Hữu Cảnh, Q. Bình Thạnh, TP. Hồ Chí Minh"));
            //Application.Run(new frmNhapKhachHang("000000000000"));
            //Application.Run(new frmRptCart("606 Quốc lộ 13 nè", "12:56:00 14/09/2020", "012345678912", "Đặng Quốc Lai", "Huỳnh Thị Thúy Kiều", "222 Nguyễn Thị Minh Khai", "0772470922", "Huỳnh Thị Thúy Kiều", "888 Võ Văn Tần", "0772490922", "13:20:00 14/09/2020"));

            Application.Run(new frmLogin());

            //Application.Run(new frmDoiMatKhau(true,"admin"));

        }
    }
}
