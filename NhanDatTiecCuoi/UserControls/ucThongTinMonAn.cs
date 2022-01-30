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
    public partial class ucThongTinMonAn : UserControl
    {
        public ucThongTinMonAn()
        {
            InitializeComponent();
        }
        public void HienThiDanhSach()
        {
            List<MONAN> mon = DataProvider.dSMONAN.LayDS();
            Converter converter = new Converter();
            DataTable dt = converter.ToDataTable(mon);
            DataTable data = converter.AutoNumberedTable(dt);
            dgvMonAn.DataSource = null;
            dgvMonAn.DataSource = data;
            dgvMonAn.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMonAn.Columns[1].HeaderText = "Mã Món Ăn";
            dgvMonAn.Columns[2].HeaderText = "Tên Món Ăn";
            dgvMonAn.Columns[3].HeaderText = "Đơn Giá";
            dgvMonAn.Columns[4].HeaderText = "Ghi Chú";
        }
        private void ReLoadMa()
        {
            txtMaMonAn.Text = DataProvider.dSMONAN.LayMaMoi().ToString();
        }

        private void ucThongTinMonAn_Load(object sender, EventArgs e)
        {
            HienThiDanhSach();
            ReLoadMa();
        }
        private bool InputValidate()
        {
            int err = 0;
            if (string.IsNullOrEmpty(txtTenMonAn.Text))
            {
                epTenMonAn.SetError(txtTenMonAn, "Vui Lòng nhập tên món ăn");
                err++;
            }
            else
            {
                epTenMonAn.SetError(txtTenMonAn, "");
            }
            if (DataProvider.StringToInt(txtDonGia, epDonGia) == 0)
            {
                err++;
            }
            else
            {
                epDonGia.SetError(txtDonGia, "");
            }

            if (err == 0)
            {
                return true;
            }
            return false;
        }

        private void dgvMonAn_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvMonAn.RowCount - 1)
            {
                txtMaMonAn.Text = dgvMonAn.Rows[e.RowIndex].Cells[1].Value.ToString();
                MONAN dv = DataProvider.dSMONAN.LayThongTinTheoMa(txtMaMonAn.Text);
                txtTenMonAn.Text = dv.TenMonAn;
                txtDonGia.Text = dv.DonGia.ToString();
                txtGhiChu.Text = dv.GhiChu;
            }
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtMaMonAn.Text) != DataProvider.dSMONAN.LayMaMoi())
            {
                epMaMonAn.SetError(txtMaMonAn, "Nhấn vào form để load lại mã món ăn mới");
                return;
            }
            else
            {
                epMaMonAn.SetError(txtMaMonAn, "");
            }
            if (InputValidate() == true)
            {
                MONAN dv = new MONAN();
                dv.MaMonAn = txtMaMonAn.Text;
                dv.TenMonAn = txtTenMonAn.Text;
                dv.DonGia = Convert.ToInt32(txtDonGia.Text);
                dv.GhiChu = txtGhiChu.Text;
                bool kq = DataProvider.dSMONAN.ThemMoi(dv);
                if (kq == true)
                {
                    MessageBox.Show("Thêm mới món ăn thành công");
                    DataProvider.dSMONAN.ThemMaMoi();
                }
                HienThiDanhSach();
                ReLoadMa();
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtMaMonAn.Text) == DataProvider.dSMONAN.LayMaMoi())
            {
                epMaMonAn.SetError(txtMaMonAn, "Nhấn vào Bảng để chọn món ăn cần sửa");
                return;
            }
            else
            {
                epMaMonAn.SetError(txtMaMonAn, "");
            }
            if (InputValidate() == true)
            {
                MONAN dv = new MONAN();
                dv.MaMonAn = txtMaMonAn.Text;
                dv.TenMonAn = txtTenMonAn.Text;
                dv.DonGia = Convert.ToInt32(txtDonGia.Text);
                dv.GhiChu = txtGhiChu.Text;
                bool kq = DataProvider.dSMONAN.CapNhatThongTin(dv);
                if (kq == true)
                {
                    MessageBox.Show("Cập nhật món ăn " + txtMaMonAn.Text + " thành công");
                }
                HienThiDanhSach();
                ReLoadMa();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtMaMonAn.Text) == DataProvider.dSMONAN.LayMaMoi())
            {
                epMaMonAn.SetError(txtMaMonAn, "Nhấn vào Bảng để chọn loại món ăn cần xóa");
                return;
            }
            else
            {
                epMaMonAn.SetError(txtMaMonAn, "");
            }
            if (InputValidate() == true)
            {
                MONAN dv = DataProvider.dSMONAN.LayThongTinTheoMa(txtMaMonAn.Text);
                if (MessageBox.Show("Bạn có muốn xóa loại món ăn " + txtMaMonAn.Text + " hay không?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    bool kq = DataProvider.dSMONAN.Xoa(dv);
                    if (kq == true)
                    {
                        MessageBox.Show("Xóa loại món ăn " + txtMaMonAn.Text + " thành công");
                    }
                    HienThiDanhSach();
                    ReLoadMa();
                }

            }
        }

        private void ucThongTinMonAn_Click(object sender, EventArgs e)
        {
            ReLoadMa();
        }

        private void flowLayoutPanel3_Click(object sender, EventArgs e)
        {
            ReLoadMa();
        }

        private void flowLayoutPanel1_Click(object sender, EventArgs e)
        {
            ReLoadMa();
        }
    }
}
