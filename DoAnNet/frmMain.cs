using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnNet
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        } 

        private void frmMain_Load(object sender, EventArgs e)
        {
            label1.SendToBack();
            label1.Invalidate();
        } 

        private void pnTreoTuong_MouseClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show("Nhaasn nef");
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
