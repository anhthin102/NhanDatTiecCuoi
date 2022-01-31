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
    public partial class ucThongTinChiTietDatDichVu : UserControl
    {
        private string _MaTiecCuoi = "";
        public string MaTiecCuoi
        {
            get { return _MaTiecCuoi; }
            set { _MaTiecCuoi = value; }
        }
        public ucThongTinChiTietDatDichVu()
        {
            InitializeComponent();
        }
        private void HienThi()
        {
            HienThiDanhSachDichVu();
            HienThiDanhSachChiTietDatDichVu();
            ReLoadMa();
        }

        private void ReLoadMa()
        {
            txtMaTiecCuoi.Text = _MaTiecCuoi;
            List<CTDATDICHVU> cTDATDICHVUs = DataProvider.dSCHITIETDATDICHVU.LayDSTheoMa(_MaTiecCuoi);
            List<DICHVU> ds = DataProvider.dSDICHVU.LayDS();
            cboMaDichVu.Items.Clear();
            foreach (DICHVU m in ds)
            {
                cboMaDichVu.Items.Add(m.MaDichVu);
            }
            cboMaDichVu.Text = "";
            txtDonGia.Text = "";
            nupSoLuong.Value = 0;
            txtGhiChu.Text = "";
        }

        private void HienThiDanhSachChiTietDatDichVu()
        {
            if (string.IsNullOrEmpty(_MaTiecCuoi))
            {
                List<CTDATDICHVU> CTDATDICHVUs = DataProvider.dSCHITIETDATDICHVU.LayDS();
                Converter converter = new Converter();
                DataTable dt = converter.ToDataTable(CTDATDICHVUs);
                DataTable data = converter.AutoNumberedTable(dt);
                dgvDichVu.DataSource = null;
                dgvDichVu.DataSource = data;
                dgvDichVu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            else
            {
                List<CTDATDICHVU> CTDATDICHVUs = DataProvider.dSCHITIETDATDICHVU.LayDS();
                List<CTDATDICHVU> CTDATDICHVUs1 = new List<CTDATDICHVU>();
                foreach (CTDATDICHVU ct in CTDATDICHVUs)
                {
                    if (ct.MaTiecCuoi == _MaTiecCuoi)
                    {
                        CTDATDICHVUs1.Add(ct);
                    }
                }
                Converter converter = new Converter();
                DataTable dt = converter.ToDataTable(CTDATDICHVUs1);
                DataTable data = converter.AutoNumberedTable(dt);
                dgvDichVu.DataSource = null;
                dgvDichVu.DataSource = data;
                dgvDichVu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
        }
        private void HienThiDanhSachDichVu()
        {
            List<DICHVU> mon = DataProvider.dSDICHVU.LayDS();
            Converter converter = new Converter();
            DataTable dt = converter.ToDataTable(mon);
            DataTable data = converter.AutoNumberedTable(dt);
            dgvDanhSachDV.DataSource = null;
            dgvDanhSachDV.DataSource = data;
            dgvDanhSachDV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDanhSachDV.Columns[1].HeaderText = "Mã Dịch Vụ";
            dgvDanhSachDV.Columns[2].HeaderText = "Tên Dịch vụ";
            dgvDanhSachDV.Columns[3].HeaderText = "Đơn Giá";
            dgvDanhSachDV.Columns[4].HeaderText = "Ghi Chú";
        }
        private bool InputValidate()
        {
            int err = 0;
            if (string.IsNullOrEmpty(cboMaDichVu.Text))
            {
                err++;
                epMaDichVu.SetError(cboMaDichVu, "Vui lòng chọn mã dịch vụ");
            }
            else
            {
                epMaDichVu.SetError(cboMaDichVu, "");
            }
            if (nupSoLuong.Value == 0)
            {
                err++;
                epSoLuong.SetError(nupSoLuong, "Vui lòng chọn số lượng");
            }
            else
            {
                epSoLuong.SetError(nupSoLuong, "");
            }
            if (err == 0)
            {
                return true;
            }
            return false;
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
            ucDatTiecCuoi uc = new ucDatTiecCuoi();
            uc.MaTiecCuoi = txtMaTiecCuoi.Text;
            this.Controls.Add(uc);
            uc.BringToFront();
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            if (InputValidate() == true)
            {
                List<CTDATDICHVU> cTDATDICHVUs = DataProvider.dSCHITIETDATDICHVU.LayDSTheoMa(txtMaTiecCuoi.Text);
                if (cTDATDICHVUs.Count != 0)
                {
                    for (int i = 0; i < cTDATDICHVUs.Count; i++)
                    {
                        if (cboMaDichVu.Text == cTDATDICHVUs[i].MaDichVu)
                        {
                            epMaDichVu.SetError(cboMaDichVu, "Dịch vụ đã có không thể thêm mới, hãy cập nhật");
                            return;
                        }
                        else
                        {
                            epMaDichVu.SetError(cboMaDichVu, "");
                        }
                    }
                }
                CTDATDICHVU cTDATDICHVU = new CTDATDICHVU();
                cTDATDICHVU.MaTiecCuoi = txtMaTiecCuoi.Text;
                cTDATDICHVU.MaDichVu = cboMaDichVu.Text;
                cTDATDICHVU.SoLuong = (int)nupSoLuong.Value;
                cTDATDICHVU.GhiChu = txtGhiChu.Text;
                cTDATDICHVU.DonGia = Convert.ToInt32(txtDonGia.Text);
                bool kq = DataProvider.dSCHITIETDATDICHVU.ThemMoi(cTDATDICHVU);
                if (kq == true)
                {
                    MessageBox.Show("Thêm mới chi tiết dịch vụ thành công");
                    HienThiDanhSachChiTietDatDichVu();
                    ReLoadMa();

                }
            }
        }



        private void ucThongTinChiTietDatDichVu_Load(object sender, EventArgs e)
        {
            HienThi();
        }

        private void ucThongTinChiTietDatDichVu_Click(object sender, EventArgs e)
        {
            HienThi();
        }

        private void flowLayoutPanel3_Click(object sender, EventArgs e)
        {
            HienThi();
        }

        private void flowLayoutPanel4_Click(object sender, EventArgs e)
        {
            HienThi();
        }

        private void flowLayoutPanel1_Click(object sender, EventArgs e)
        {
            HienThi();
        }

        private void dgvDichVu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvDichVu.RowCount - 1)
            {
                txtMaTiecCuoi.Text = dgvDichVu.Rows[e.RowIndex].Cells[1].Value.ToString();
                List<CTDATDICHVU> cTDATDICHVUs = DataProvider.dSCHITIETDATDICHVU.LayDSTheoMa(txtMaTiecCuoi.Text);
                for (int i = 0; i < cTDATDICHVUs.Count; i++)
                {
                    if (cTDATDICHVUs[i].MaDichVu == dgvDichVu.Rows[e.RowIndex].Cells[2].Value.ToString())
                    {
                        cboMaDichVu.SelectedItem = cTDATDICHVUs[i].MaDichVu;
                        txtDonGia.Text = cTDATDICHVUs[i].DonGia.ToString();
                        nupSoLuong.Value = cTDATDICHVUs[i].SoLuong;
                        txtGhiChu.Text = cTDATDICHVUs[i].GhiChu;
                        break;
                    }
                }
            }
        }

        private void cboMaDichVu_SelectedIndexChanged(object sender, EventArgs e)
        {

            DICHVU dICHVU = DataProvider.dSDICHVU.LayThongTinTheoMa(cboMaDichVu.Text);
            txtDonGia.Text = dICHVU.DonGia.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (InputValidate() == true)
            {
                List<CTDATDICHVU> cTDATDICHVUs = DataProvider.dSCHITIETDATDICHVU.LayDSTheoMa(txtMaTiecCuoi.Text);
                if (cTDATDICHVUs.Count == 0)
                {
                    epMaDichVu.SetError(cboMaDichVu, "dịch vụ chưa có hãy thêm mới");
                    return;
                }
                else
                {
                    bool tim = false;
                    for (int i = 0; i < cTDATDICHVUs.Count; i++)
                    {
                        if (cboMaDichVu.Text == cTDATDICHVUs[i].MaDichVu)
                        {
                            tim = true;
                            break;
                        }

                    }
                    if (tim == false)
                    {
                        epMaDichVu.SetError(cboMaDichVu, "Dịch vụ này chưa có hãy thêm mới");
                        return;
                    }
                    else
                    {
                        epMaDichVu.SetError(cboMaDichVu, "");
                    }

                }
                CTDATDICHVU cTDATDICHVU = new CTDATDICHVU();
                cTDATDICHVU.MaTiecCuoi = txtMaTiecCuoi.Text;
                cTDATDICHVU.MaDichVu = cboMaDichVu.Text;
                cTDATDICHVU.SoLuong = (int)nupSoLuong.Value;
                cTDATDICHVU.GhiChu = txtGhiChu.Text;
                cTDATDICHVU.DonGia = Convert.ToInt32(txtDonGia.Text);
                bool kq = DataProvider.dSCHITIETDATDICHVU.CapNhatThongTin(cTDATDICHVU);
                if (kq == true)
                {
                    MessageBox.Show("Cập nhật chi tiết dịch vụ thành công");
                    HienThiDanhSachChiTietDatDichVu();
                    ReLoadMa();

                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (InputValidate() == true)
            {
                List<CTDATDICHVU> cTDATDICHVUs = DataProvider.dSCHITIETDATDICHVU.LayDSTheoMa(txtMaTiecCuoi.Text);
                if (cTDATDICHVUs.Count == 0)
                {
                    epMaDichVu.SetError(cboMaDichVu, "Dịch vụ này chưa có không cần xóa");
                    return;
                }
                else
                {
                    bool tim = false;
                    for (int i = 0; i < cTDATDICHVUs.Count; i++)
                    {
                        if (cboMaDichVu.Text == cTDATDICHVUs[i].MaDichVu)
                        {
                            tim = true;
                            break;
                        }

                    }
                    if (tim == false)
                    {
                        epMaDichVu.SetError(cboMaDichVu, "Dịch vụ này chưa có không cần xóa");
                        return;
                    }
                    else
                    {
                        epMaDichVu.SetError(cboMaDichVu, "");
                    }

                }
                CTDATDICHVU cTDATDICHVU = new CTDATDICHVU();
                cTDATDICHVU.MaTiecCuoi = txtMaTiecCuoi.Text;
                cTDATDICHVU.MaDichVu = cboMaDichVu.Text;
                cTDATDICHVU.SoLuong = (int)nupSoLuong.Value;
                cTDATDICHVU.GhiChu = txtGhiChu.Text;
                cTDATDICHVU.DonGia = Convert.ToInt32(txtDonGia.Text);
                bool kq = DataProvider.dSCHITIETDATDICHVU.Xoa(cTDATDICHVU);
                if (kq == true)
                {
                    MessageBox.Show("Xóa chi tiết dịch vụ thành công");
                    HienThiDanhSachChiTietDatDichVu();
                    ReLoadMa();

                }
            }
        }
    }
}
