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
            ReLoadMaLoaiSanh();
        }
        private void ReLoadMaLoaiSanh()
        {
            txtMaLoaiSanh.Text = DataProvider.SLOAISANH.LayMaMoi().ToString();

        }
        private void HienThiDanhSachCacLoaiSanh()
        {
            List<LOAISANH> dsSanh = DataProvider.SLOAISANH.LayDS();
            Converter converter = new Converter();
            DataTable dt = converter.ToDataTable(dsSanh);
            DataTable data = converter.AutoNumberedTable(dt);
            dgvSanh.DataSource = null;
            dgvSanh.DataSource = data;
            dgvSanh.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSanh.Columns[1].HeaderText = "Mã Loại Sảnh";
            dgvSanh.Columns[2].HeaderText = "Tên Loại Sảnh";
            dgvSanh.Columns[3].HeaderText = "Đơn giá bàn Tối thiểu";
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            if(Convert.ToInt32(txtMaLoaiSanh.Text) != DataProvider.SLOAISANH.LayMaMoi())
            {
                epMaLoaiSanh.SetError(txtMaLoaiSanh, "Nhấn vào form để load lại mã loại sảnh mới");
                return;
            }
            else
            {
                epMaLoaiSanh.SetError(txtMaLoaiSanh, "");
            }
            if (InputValidate()==true)
            {
                LOAISANH ls = new LOAISANH();
                ls.MaLoaiSanh = txtMaLoaiSanh.Text;
                ls.TenLoaiSanh = txtTenLoaiSanh.Text;
                ls.DonGiaBanToiThieu = Convert.ToInt32(txtDonGiaBanToiThieu.Text);
                bool kq = DataProvider.SLOAISANH.ThemMoi(ls);
                if (kq == true)
                {
                    MessageBox.Show("Thêm mới loại sảnh thành công");
                    DataProvider.SLOAISANH.ThemMaMoi();
                }
                HienThiDanhSachCacLoaiSanh();
                ReLoadMaLoaiSanh();

            }
        }
        private bool InputValidate()
        {
            int err = 0;
            if (string.IsNullOrEmpty(txtTenLoaiSanh.Text))
            {
                epTenLoaiSanh.SetError(txtTenLoaiSanh, "Vui Lòng nhập tên loại sảnh");
                err++;
            }
            else
            {
                epTenLoaiSanh.SetError(txtTenLoaiSanh, "");
            }
            if(DataProvider.StringToInt(txtDonGiaBanToiThieu, epDonGiaBanToiThieu) ==0)
            {
                err++;
            }
            else
            {
                epDonGiaBanToiThieu.SetError(txtDonGiaBanToiThieu, "");
            }
            if (err == 0)
            {
                return true;
            }
            return false;
        }

        private void ucDanhSachCacLoaiSanh_Click(object sender, EventArgs e)
        {
            ReLoadMaLoaiSanh();
        }

        private void dgvSanh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvSanh.RowCount - 1)
            {
                txtMaLoaiSanh.Text = dgvSanh.Rows[e.RowIndex].Cells[1].Value.ToString();
                LOAISANH ls = DataProvider.SLOAISANH.LayThongTinTheoMa(txtMaLoaiSanh.Text);
                txtTenLoaiSanh.Text = ls.TenLoaiSanh;
                txtDonGiaBanToiThieu.Text = ls.DonGiaBanToiThieu.ToString();
            }
                
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtMaLoaiSanh.Text) == DataProvider.SLOAISANH.LayMaMoi())
            {
                epMaLoaiSanh.SetError(txtMaLoaiSanh, "Nhấn vào Bảng để chọn loại sảnh cần sửa");
                return;
            }
            else
            {
                epMaLoaiSanh.SetError(txtMaLoaiSanh, "");
            }
            if (InputValidate() == true)
            {
                LOAISANH ls = new LOAISANH();
                ls.MaLoaiSanh = txtMaLoaiSanh.Text;
                ls.TenLoaiSanh = txtTenLoaiSanh.Text;
                ls.DonGiaBanToiThieu = Convert.ToInt32(txtDonGiaBanToiThieu.Text);
                bool kq = DataProvider.SLOAISANH.CapNhatThongTin(ls);
                if (kq == true)
                {
                    MessageBox.Show("Cập nhật loại sảnh "+txtMaLoaiSanh.Text+" thành công");
                }
                HienThiDanhSachCacLoaiSanh();
                ReLoadMaLoaiSanh();
            }
            
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtMaLoaiSanh.Text) == DataProvider.SLOAISANH.LayMaMoi())
            {
                epMaLoaiSanh.SetError(txtMaLoaiSanh, "Nhấn vào Bảng để chọn loại sảnh cần xóa");
                return;
            }
            else
            {
                epMaLoaiSanh.SetError(txtMaLoaiSanh, "");
            }
            if (InputValidate() == true)
            {
                LOAISANH ls = DataProvider.SLOAISANH.LayThongTinTheoMa(txtMaLoaiSanh.Text);
                if (MessageBox.Show("Bạn có muốn xóa loại sảnh " + txtMaLoaiSanh.Text + " hay không?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    bool kq = DataProvider.SLOAISANH.Xoa(ls);
                    if (kq == true)
                    {
                        MessageBox.Show("Xóa loại sảnh " + txtMaLoaiSanh.Text + " thành công");
                    }
                    HienThiDanhSachCacLoaiSanh();
                    ReLoadMaLoaiSanh();
                }
                
            }
        }
    }
}
