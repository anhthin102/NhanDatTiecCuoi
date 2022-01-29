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
    public partial class ucDanhSachCacLoaiSanh : UserControl
    {
        public ucDanhSachCacLoaiSanh()
        {
            InitializeComponent();
        }

       
        private void ucDanhSachCacLoaiSanh_Load(object sender, EventArgs e)
        {
            HienThiDanhSachCacLoaiSanh();
            txtMaLoaiSanh.Text = (DataProvider.SLOAISANH.LayDSLoaiSanh().Count + 1).ToString();
        }
        private void HienThiDanhSachCacLoaiSanh()
        {
            List<LOAISANH> dsSanh = DataProvider.SLOAISANH.LayDSLoaiSanh();
            dgvSanh.DataSource = null;
            dgvSanh.DataSource = dsSanh;
            dgvSanh.Columns[0].HeaderText = "Mã Loại Sảnh";
            dgvSanh.Columns[1].HeaderText = "Tên Loại Sảnh";
            dgvSanh.Columns[2].HeaderText = "Đơn giá bàn Tối thiểu";

        }
    }
}
