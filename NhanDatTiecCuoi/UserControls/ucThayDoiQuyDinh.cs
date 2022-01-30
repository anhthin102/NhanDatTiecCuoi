using NhanDatTiecCuoi.Data;
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
    public partial class ucThayDoiQuyDinh : UserControl
    {
        public ucThayDoiQuyDinh()
        {
            InitializeComponent();
           
        }

        private void ucThayDoiQuyDinh_Load(object sender, EventArgs e)
        {
            HienThi();
        }
        private void HienThi()
        {
            if (DataProvider.tHAMSO.ApDungQDPhat == true)
            {
                rbYes.Checked = true;
                rbNo.Checked = false;
            }
            else
            {
                rbYes.Checked = false;
                rbNo.Checked = true;
            }
            txtTiLePhat.Text = DataProvider.tHAMSO.TiLePhat.ToString();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            DataProvider.tHAMSO.TiLePhat = Convert.ToInt32(txtTiLePhat.Text);
            if (rbYes.Checked == true || rbNo.Checked==false)
            {
                DataProvider.tHAMSO.ApDungQDPhat = true;
            }
            else
            {
                DataProvider.tHAMSO.ApDungQDPhat = false;
            }
        }

        private void ucThayDoiQuyDinh_VisibleChanged(object sender, EventArgs e)
        {
            HienThi();
        }





        private void flowLayoutPanel1_Click(object sender, EventArgs e)
        {
            HienThi();
        }

        private void ucThayDoiQuyDinh_Click(object sender, EventArgs e)
        {
            HienThi();
        }
    }
}
