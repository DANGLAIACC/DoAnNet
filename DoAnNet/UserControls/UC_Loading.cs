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
    public partial class UC_Loading : UserControl
    {
        public UC_Loading()
        {
            InitializeComponent();
            timer1.Start();
            pgbLoading.Value = 0;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pgbLoading.Increment(1);
        }
    }
}
