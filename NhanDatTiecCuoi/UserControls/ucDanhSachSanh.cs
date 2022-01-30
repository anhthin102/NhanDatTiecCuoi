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
    public partial class ucDanhSachSanh : UserControl
    {
        public ucDanhSachSanh()
        {
            InitializeComponent();
        }


        public void HienThiDanhSachLoaiSanh()
        {
            List<LOAISANH> dsSanh = DataProvider.SLOAISANH.LayDS();
            Converter converter = new Converter();
            DataTable dt = converter.ToDataTable(dsSanh);
            DataTable data = converter.AutoNumberedTable(dt);
            dgvLoaiSanh.DataSource = null;
            dgvLoaiSanh.DataSource = data;
            dgvLoaiSanh.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvLoaiSanh.Columns[1].HeaderText = "Mã Loại Sảnh";
            dgvLoaiSanh.Columns[2].HeaderText = "Tên Loại Sảnh";
            dgvLoaiSanh.Columns[3].HeaderText = "Đơn giá bàn Tối thiểu";

        }
        private void HienThiDanhSach()
        {
            List<SANH> dsSanh = DataProvider.SANHs.LayDS();
            Converter converter = new Converter();
            DataTable dt = converter.ToDataTable(dsSanh);
            dt.Columns.Add("Đơn giá bán tối thiểu").SetOrdinal(3);
            DataTable data = converter.AutoNumberedTable(dt);
            dgvSanh.DataSource = null;
            dgvSanh.DataSource = data;
            dgvSanh.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            List<LOAISANH> dsLoaiSanh = DataProvider.SLOAISANH.LayDS();
            for (int i = 0; i < dsSanh.Count; i++)
            {
                for (int j = 0; j < dsLoaiSanh.Count; j++)
                {
                    if (dsSanh[i].MaLoaiSanh == dsLoaiSanh[j].MaLoaiSanh)
                    {
                        dgvSanh.Rows[i].Cells[4].Value = dgvLoaiSanh.Rows[j].Cells[3].Value;
                        break;
                    }
                }
            }

        }
        private void ReLoadMa()
        {
            txtMaSanh.Text = DataProvider.SANHs.LayMaMoi().ToString();
            List<LOAISANH> dsLoaiSanh = DataProvider.SLOAISANH.LayDS();
            cbMaLoaiSanh.Items.Clear();
            foreach (LOAISANH ls in dsLoaiSanh)
            {
                cbMaLoaiSanh.Items.Add(ls.MaLoaiSanh);
            }
            cbMaLoaiSanh.Text = cbMaLoaiSanh.Items[0].ToString();

        }
        private void ucDanhSachSanh_Load(object sender, EventArgs e)
        {
            HienThiDanhSachLoaiSanh();
            HienThiDanhSach();
            ReLoadMa();
        }
        private bool InputValidate()
        {
            int err = 0;
            if (string.IsNullOrEmpty(txtTenSanh.Text))
            {
                epTenSanh.SetError(txtTenSanh, "Vui Lòng nhập tên sảnh");
                err++;
            }
            else
            {
                epTenSanh.SetError(txtTenSanh, "");
            }
            if (nupSoLuongBanMax.Value == 0)
            {
                epSoLuongBanToiDa.SetError(nupSoLuongBanMax, "Vui lòng nhập số lượng bàn tối đa");
                err++;
            }
            else
            {
                epSoLuongBanToiDa.SetError(nupSoLuongBanMax, "");
            }
            if (err == 0)
            {
                return true;
            }
            return false;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ucDanhSachSanh_Click(object sender, EventArgs e)
        {
            HienThiDanhSachLoaiSanh();
            ReLoadMa();
            HienThiDanhSach();
        }

        private void flowLayoutPanel4_Click(object sender, EventArgs e)
        {
            HienThiDanhSachLoaiSanh();
            ReLoadMa();
            HienThiDanhSach();
        }

        private void flowLayoutPanel3_Click(object sender, EventArgs e)
        {
            HienThiDanhSachLoaiSanh();
            ReLoadMa();
            HienThiDanhSach();
        }

        private void flowLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {
            HienThiDanhSachLoaiSanh();
            ReLoadMa();
            HienThiDanhSach();
        }

        private void dgvSanh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvSanh.RowCount - 1)
            {
                txtMaSanh.Text = dgvSanh.Rows[e.RowIndex].Cells[1].Value.ToString();
                SANH dv = DataProvider.SANHs.LayThongTinTheoMa(txtMaSanh.Text);
                txtTenSanh.Text = dv.TenSanh;
                cbMaLoaiSanh.SelectedItem = dv.MaLoaiSanh;
                nupSoLuongBanMax.Value = dv.SLBanToiDa;
                txtGhiChu.Text = dv.GhiChu;
            }
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtMaSanh.Text) != DataProvider.SANHs.LayMaMoi())
            {
                epMaSanh.SetError(txtMaSanh, "Nhấn vào form để load lại mã sảnh mới");
                return;
            }
            else
            {
                epMaSanh.SetError(txtMaSanh, "");
            }
            if (InputValidate() == true)
            {
                SANH s = new SANH();
                s.MaSanh = txtMaSanh.Text;
                s.TenSanh = txtTenSanh.Text;
                s.MaLoaiSanh = cbMaLoaiSanh.Text;
                s.SLBanToiDa = Convert.ToInt32(nupSoLuongBanMax.Value);
                s.GhiChu = txtGhiChu.Text;
                bool kq = DataProvider.SANHs.ThemMoi(s);
                if (kq == true)
                {
                    MessageBox.Show("Thêm mới sảnh thành công");
                    DataProvider.SANHs.ThemMaMoi();
                }
                HienThiDanhSach();
                ReLoadMa();
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtMaSanh.Text) == DataProvider.SANHs.LayMaMoi())
            {
                epMaSanh.SetError(txtMaSanh, "Nhấn vào Bảng để chọn sảnh cần sửa");
                return;
            }
            else
            {
                epMaSanh.SetError(txtMaSanh, "");
            }
            if (InputValidate() == true)
            {
                SANH s = new SANH();
                s.MaSanh = txtMaSanh.Text;
                s.TenSanh = txtTenSanh.Text;
                s.MaLoaiSanh = cbMaLoaiSanh.Text;
                s.SLBanToiDa = Convert.ToInt32(nupSoLuongBanMax.Value);
                s.GhiChu = txtGhiChu.Text;
                bool kq = DataProvider.SANHs.CapNhatThongTin(s);
                if (kq == true)
                {
                    MessageBox.Show("Cập nhật sảnh " + txtMaSanh.Text + " thành công");
                }
                HienThiDanhSach();
                ReLoadMa();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtMaSanh.Text) == DataProvider.SANHs.LayMaMoi())
            {
                epMaSanh.SetError(txtMaSanh, "Nhấn vào Bảng để chọn loại sảnh cần xóa");
                return;
            }
            else
            {
                epMaSanh.SetError(txtMaSanh, "");
            }
            if (InputValidate() == true)
            {
                SANH dv = DataProvider.SANHs.LayThongTinTheoMa(txtMaSanh.Text);
                if (MessageBox.Show("Bạn có muốn xóa sảnh " + txtMaSanh.Text + " hay không?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    bool kq = DataProvider.SANHs.Xoa(dv);
                    if (kq == true)
                    {
                        MessageBox.Show("Xóa loại sảnh " + txtMaSanh.Text + " thành công");
                    }
                    HienThiDanhSach();
                    ReLoadMa();
                }

            }
        }
    }
}
