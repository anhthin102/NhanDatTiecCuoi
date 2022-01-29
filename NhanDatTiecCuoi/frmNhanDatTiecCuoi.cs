using NhanDatTiecCuoi.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NhanDatTiecCuoi
{
    public partial class frnNhanDatTiecCuoi : Form
    {
        NavigationUserControl navigationUserControl;

        public frnNhanDatTiecCuoi()
        {
            InitializeComponent();
            InitiallizeNavigationControl();
            this.Size = new Size(850, 685);
        }
        private void InitiallizeNavigationControl()
        {
            List<UserControl> userControls = new List<UserControl>() {new ucDanhSachSanh(), new ucDanhSachCacLoaiSanh(), new ucDatTiecCuoi(), new ucDanhSachTiecCuoi(), new ucDanhSachCa(), new ucThongTinMonAn(), new ucDanhSachDichVu(), new ucHoaDon(), new ucDoanhThuThang(), new ucThayDoiQuyDinh()};
            navigationUserControl = new NavigationUserControl(pnPage, userControls);
            navigationUserControl.Display(0);
        }
        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frnNhanDatTiecCuoi_Load(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void pnPage_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tsmiDashboard_Click(object sender, EventArgs e)
        {
            navigationUserControl.Display(0);
        }

        private void tsmiDanhSachSanh_Click(object sender, EventArgs e)
        {
            navigationUserControl.Display(0);
        }

        private void tsmiDanhSachCacLoaiSanh_Click(object sender, EventArgs e)
        {
            navigationUserControl.Display(1);
        }

        private void tsmiDatTiecCuoi_Click(object sender, EventArgs e)
        {

            navigationUserControl.Display(2);


        }

        private void tsmiDanhSachDatTiecCuoi_Click(object sender, EventArgs e)
        {
            navigationUserControl.Display(3);
        }

        private void tsmiDanhSachCa_Click(object sender, EventArgs e)
        {
            navigationUserControl.Display(4);
        }

        private void tsmiThongTinMonAn_Click(object sender, EventArgs e)
        {
            navigationUserControl.Display(5);
        }

        private void tsmiDanhSachDichVu_Click(object sender, EventArgs e)
        {
            navigationUserControl.Display(6);
        }

        private void tsmiHoaDon_Click(object sender, EventArgs e)
        {
            navigationUserControl.Display(7);
        }

        private void tsmiDoanhThuThang_Click(object sender, EventArgs e)
        {
            navigationUserControl.Display(8);
        }

        private void tsmiThayDoiQuyDinh_Click(object sender, EventArgs e)
        {
            navigationUserControl.Display(9);
        }
    }
}
