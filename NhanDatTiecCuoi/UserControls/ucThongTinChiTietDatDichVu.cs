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
    public partial class ucThongTinChiTietDatDichVu : UserControl
    {
        public ucThongTinChiTietDatDichVu()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            ucDatTiecCuoi datTiecCuoi = new ucDatTiecCuoi();
            this.Controls.Add(datTiecCuoi);
            datTiecCuoi.BringToFront();
        }
    }
}
