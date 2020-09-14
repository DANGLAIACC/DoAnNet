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
            //Application.Run(new frmNhapKhachHang("012345678912","Đặng Quốc Lai","10:30:28 14/09/2020"));
            Application.Run(new frmNhapKhachHang("000000000000"));
        }
    }
}
