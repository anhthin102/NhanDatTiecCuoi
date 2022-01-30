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
    public partial class ucDanhSachCa : UserControl
    {
        public ucDanhSachCa()
        {
            InitializeComponent();
        }
        private void HienThiDanhSachCacLoaiCa()
        {
            List<CA> dsCa = DataProvider.SCA.LayDS();
            Converter converter = new Converter();
            DataTable dt = converter.ToDataTable(dsCa);
            DataTable data = converter.AutoNumberedTable(dt);
            dgvCa.DataSource = null;
            dgvCa.DataSource = data;
            dgvCa.Columns[1].HeaderText = "Mã ca";
            dgvCa.Columns[2].HeaderText = "Tên Loại ca";
            dgvCa.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void ucDanhSachCa_Load(object sender, EventArgs e)
        {
            HienThiDanhSachCacLoaiCa();
            ReloadMaCa();
        }
        private void ReloadMaCa()
        {
            txtMaCa.Text = DataProvider.SCA.LayMaMoi().ToString();
        }
        private bool InputValidate()
        {
            int err = 0;
            if (string.IsNullOrEmpty(txtLoaiCa.Text))
            {
                epTenLoaiCa.SetError(txtLoaiCa, "Vui Lòng nhập tên loại ca");
                err++;
            }
            else
            {
                epTenLoaiCa.SetError(txtLoaiCa, "");

            }
            if (err == 0)
            {
                return true;
            }
            return false;
        }

        private void dgvCa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvCa.RowCount - 1)
            {
                txtMaCa.Text = dgvCa.Rows[e.RowIndex].Cells[1].Value.ToString();
                CA ca = DataProvider.SCA.LayThongTinTheoMa(txtMaCa.Text);
                txtMaCa.Text = ca.MaCa;
                txtLoaiCa.Text = ca.LoaiCa;
            }
                
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtMaCa.Text) == DataProvider.SCA.LayMaMoi())
            {
                epMaCa.SetError(txtMaCa, "Nhấn vào Bảng để chọn loại ca cần sửa");
                return;
            }
            else
            {
                epMaCa.SetError(txtMaCa, "");
            }
            if (InputValidate() == true)
            {
                CA ca = new CA();
                ca.MaCa = txtMaCa.Text;
                ca.LoaiCa = txtLoaiCa.Text;
                bool kq = DataProvider.SCA.CapNhatThongTin(ca);
                if (kq == true)
                {
                    MessageBox.Show("Cập nhật ca " + txtMaCa.Text + " thành công");
                }
                HienThiDanhSachCacLoaiCa();
                ReloadMaCa();
           
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtMaCa.Text) == DataProvider.SCA.LayMaMoi())
            {
                epMaCa.SetError(txtMaCa, "Nhấn vào Bảng để chọn loại ca cần xóa");
                return;
            }
            else
            {
                epMaCa.SetError(txtMaCa, "");
            }
            if (InputValidate() == true)
            {
                CA ca = DataProvider.SCA.LayThongTinTheoMa(txtMaCa.Text);
                if (MessageBox.Show("Bạn có muốn xóa ca " + txtMaCa.Text + " hay không?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    bool kq = DataProvider.SCA.Xoa(ca);
                    if (kq == true)
                    {
                        MessageBox.Show("Xóa ca " + txtMaCa.Text + " thành công");
                    }
                    HienThiDanhSachCacLoaiCa();
                    ReloadMaCa();
                }

            }
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtMaCa.Text) != DataProvider.SCA.LayMaMoi())
            {
                epMaCa.SetError(txtMaCa, "Nhấn vào form để load lại mã ca mới");
                return;
            }
            else
            {
                epMaCa.SetError(txtMaCa, "");
            }
            if (InputValidate() == true)
            {
                CA ca = new CA();
                ca.MaCa = txtMaCa.Text;
                ca.LoaiCa = txtLoaiCa.Text;
                bool kq = DataProvider.SCA.ThemMoi(ca);
                if (kq == true)
                {
                    MessageBox.Show("Thêm mới ca thành công");
                    DataProvider.SCA.ThemMaMoi();
                }
                HienThiDanhSachCacLoaiCa();
                ReloadMaCa();

            }
        }

        private void ucDanhSachCa_Click(object sender, EventArgs e)
        {
            ReloadMaCa();
        }
    }
}
