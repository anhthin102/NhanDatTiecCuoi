using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NhanDatTiecCuoi.UserControls
{
    public partial class ucThongTinChiTietDatBan : UserControl
    {
        public ucThongTinChiTietDatBan()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            ucDatTiecCuoi uc = new ucDatTiecCuoi();
            this.Controls.Add(uc);
            uc.BringToFront();
        }
    }
}
