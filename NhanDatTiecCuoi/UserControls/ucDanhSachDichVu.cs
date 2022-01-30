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
    public partial class ucDanhSachDichVu : UserControl
    {
        public ucDanhSachDichVu()
        {
            InitializeComponent();
        }

        private void ucDanhSachDichVu_Load(object sender, EventArgs e)
        {
            HienThiDanhSach();
            ReLoadMa();
        }
        public void HienThiDanhSach()
        {
            List<DICHVU> dv = DataProvider.dSDICHVU.LayDS();
            Converter converter = new Converter();
            DataTable dt = converter.ToDataTable(dv);
            DataTable data = converter.AutoNumberedTable(dt);
            dgvDichVu.DataSource = null;
            dgvDichVu.DataSource = data;
            dgvDichVu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDichVu.Columns[1].HeaderText = "Mã Dịch Vụ";
            dgvDichVu.Columns[2].HeaderText = "Tên Dịch Vụ";
            dgvDichVu.Columns[3].HeaderText = "Đơn Giá";
            dgvDichVu.Columns[4].HeaderText = "Ghi Chú";
        }
        private void ReLoadMa()
        {
            txtMaDichVu.Text = DataProvider.dSDICHVU.LayMaMoi().ToString();
        }
        private bool InputValidate()
        {
            int err = 0;
            if (string.IsNullOrEmpty(txtTenDichVu.Text))
            {
                epTenDichVu.SetError(txtTenDichVu, "Vui Lòng nhập tên dịch vụ");
                err++;
            }
            else
            {
                epTenDichVu.SetError(txtTenDichVu, "");
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
        private void ucDanhSachDichVu_Click(object sender, EventArgs e)
        {
            ReLoadMa();
        }
        private void dgvDichVu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvDichVu.RowCount - 1)
            {
                txtMaDichVu.Text = dgvDichVu.Rows[e.RowIndex].Cells[1].Value.ToString();
                DICHVU dv = DataProvider.dSDICHVU.LayThongTinTheoMa(txtMaDichVu.Text);
                txtTenDichVu.Text = dv.TenDichVu;
                txtDonGia.Text = dv.DonGia.ToString();
                txtGhiChu.Text = dv.GhiChu;
            }
                
        }
        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtMaDichVu.Text) != DataProvider.dSDICHVU.LayMaMoi())
            {
                epMaDichVu.SetError(txtMaDichVu, "Nhấn vào form để load lại mã dịch vụ mới");
                return;
            }
            else
            {
                epMaDichVu.SetError(txtMaDichVu, "");
            }
            if (InputValidate() == true)
            {
                DICHVU dv = new DICHVU();
                dv.MaDichVu = txtMaDichVu.Text;
                dv.TenDichVu = txtTenDichVu.Text;
                dv.DonGia = Convert.ToInt32(txtDonGia.Text);
                dv.GhiChu = txtGhiChu.Text;
                bool kq = DataProvider.dSDICHVU.ThemMoi(dv);
                if (kq == true)
                {
                    MessageBox.Show("Thêm mới dịch vụ thành công");
                    DataProvider.dSDICHVU.ThemMaMoi();
                }
                HienThiDanhSach();
                ReLoadMa();
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtMaDichVu.Text) == DataProvider.dSDICHVU.LayMaMoi())
            {
                epMaDichVu.SetError(txtMaDichVu, "Nhấn vào Bảng để chọn dịch vụ cần sửa");
                return;
            }
            else
            {
                epMaDichVu.SetError(txtMaDichVu, "");
            }
            if (InputValidate() == true)
            {
                DICHVU dv = new DICHVU();
                dv.MaDichVu = txtMaDichVu.Text;
                dv.TenDichVu = txtTenDichVu.Text;
                dv.DonGia = Convert.ToInt32(txtDonGia.Text);
                dv.GhiChu = txtGhiChu.Text;
                bool kq = DataProvider.dSDICHVU.CapNhatThongTin(dv);
                if (kq == true)
                {
                    MessageBox.Show("Cập nhật dịch vụ " + txtMaDichVu.Text + " thành công");
                }
                HienThiDanhSach();
                ReLoadMa();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtMaDichVu.Text) == DataProvider.dSDICHVU.LayMaMoi())
            {
                epMaDichVu.SetError(txtMaDichVu, "Nhấn vào Bảng để chọn loại dịch vụ cần xóa");
                return;
            }
            else
            {
                epMaDichVu.SetError(txtMaDichVu, "");
            }
            if (InputValidate() == true)
            {
                DICHVU dv = DataProvider.dSDICHVU.LayThongTinTheoMa(txtMaDichVu.Text);
                if (MessageBox.Show("Bạn có muốn xóa loại dịch vụ " + txtMaDichVu.Text + " hay không?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    bool kq = DataProvider.dSDICHVU.Xoa(dv);
                    if (kq == true)
                    {
                        MessageBox.Show("Xóa loại dịch vụ " + txtMaDichVu.Text + " thành công");
                    }
                    HienThiDanhSach();
                    ReLoadMa();
                }

            }
        }
    }
}
