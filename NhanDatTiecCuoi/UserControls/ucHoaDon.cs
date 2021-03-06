using NhanDatTiecCuoi.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace NhanDatTiecCuoi.UserControls
{
    public partial class ucHoaDon : UserControl
    {
        private string _MaTiecCuoi = "";
        public string MaTiecCuoi
        {
            get { return _MaTiecCuoi; }
            set { _MaTiecCuoi = value; }
        }
        public ucHoaDon()
        {
            InitializeComponent();
        }
        private void HienThi()
        {
            HienThiDanhSachTiecCuoi();
            HienThiDanhSachChiTietDichVu("");
        }
        private void HienThiDanhSachTiecCuoi()
        {
            List<TIECCUOI> tIECCUOIs = DataProvider.dSTIECCUOI.LayDS();
            Converter converter = new Converter();
            DataTable dt = converter.ToDataTable(tIECCUOIs);
            DataTable data = converter.AutoNumberedTable(dt);
            dgvTiecCuoi.DataSource = null;
            dgvTiecCuoi.DataSource = data;
            converter.ChangeGridTiecCuoiColor(dgvTiecCuoi);
            if (!string.IsNullOrEmpty(_MaTiecCuoi))
            {
                int index = 0;
                for (int i = 0; i < tIECCUOIs.Count; i++)
                {
                    if (tIECCUOIs[i].MaTiecCuoi == _MaTiecCuoi)
                    {
                        index = i;
                        break;
                    }
                }
                if (index >= 0 && index < dgvTiecCuoi.RowCount - 1)
                {
                    txtMaTiecCuoi.Text = dgvTiecCuoi.Rows[index].Cells[1].Value.ToString();
                    TIECCUOI tc = DataProvider.dSTIECCUOI.LayThongTinTheoMa(txtMaTiecCuoi.Text);
                    txtMaTiecCuoi.Text = tc.MaTiecCuoi;
                    txtTenChuRe.Text = tc.TenChuRe;
                    txtTenCoDau.Text = tc.TenCoDau;
                    nupSoLuongBan.Value = tc.SoLuongBan;
                    txtDonGiaBan.Text = tc.DonGiaBan.ToString();
                    txtTongTienBan.Text = (tc.DonGiaBan * tc.SoLuongBan).ToString();
                    List<CTDATDICHVU> dv = DataProvider.dSCHITIETDATDICHVU.LayDSTheoMa(_MaTiecCuoi);
                    int TongTienDichVu = 0;
                    if (dv.Count != 0)
                    {
                        foreach (CTDATDICHVU d in dv)
                        {
                            TongTienDichVu = TongTienDichVu + d.DonGia * d.SoLuong;
                        }
                    }
                    txtTongTienDichVu.Text = TongTienDichVu.ToString();
                    txtTongTienHoaDon.Text = (tc.DonGiaBan * tc.SoLuongBan + TongTienDichVu).ToString();
                    txtTienDatCoc.Text = tc.TienDatCoc.ToString();
                    txtConLai.Text = (tc.DonGiaBan * tc.SoLuongBan + TongTienDichVu - tc.TienDatCoc).ToString();
                    string a = dgvTiecCuoi.Rows[index].Cells[1].Value.ToString();
                    HienThiDanhSachChiTietDichVu(a);
                }
            }

        }
        private void HienThiDanhSachChiTietDichVu(string a)
        {
            if (string.IsNullOrEmpty(a))
            {
                List<CTDATDICHVU> cTDATDICHVUs = DataProvider.dSCHITIETDATDICHVU.LayDS();
                Converter converter = new Converter();
                DataTable dt = converter.ToDataTable(cTDATDICHVUs);
                DataTable data = converter.AutoNumberedTable(dt);
                dgvDichVu.DataSource = null;
                dgvDichVu.DataSource = data;
            }
            else
            {
                List<CTDATDICHVU> cTDATDICHVUs = DataProvider.dSCHITIETDATDICHVU.LayDS();
                List<CTDATDICHVU> cTDATDICHVUs1 = new List<CTDATDICHVU>();
                foreach (CTDATDICHVU ct in cTDATDICHVUs)
                {
                    if (ct.MaTiecCuoi == a)
                    {
                        cTDATDICHVUs1.Add(ct);
                    }
                }
                Converter converter = new Converter();
                DataTable dt = converter.ToDataTable(cTDATDICHVUs1);
                DataTable data = converter.AutoNumberedTable(dt);
                dgvDichVu.DataSource = null;
                dgvDichVu.DataSource = data;
            }

        }

        private void ucHoaDon_Load(object sender, EventArgs e)
        {
            HienThi();
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnChinhSua_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            ucThongTinChiTietDatDichVu uc = new ucThongTinChiTietDatDichVu();
            uc.MaTiecCuoi = dgvTiecCuoi.CurrentRow.Cells[1].Value.ToString();
            this.Controls.Add(uc);
            uc.BringToFront();
        }

        private void dgvTiecCuoi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvTiecCuoi.RowCount - 1)
            {
                txtMaTiecCuoi.Text = dgvTiecCuoi.Rows[e.RowIndex].Cells[1].Value.ToString();
                TIECCUOI tc = DataProvider.dSTIECCUOI.LayThongTinTheoMa(txtMaTiecCuoi.Text);
                txtMaTiecCuoi.Text = tc.MaTiecCuoi;
                txtTenChuRe.Text = tc.TenChuRe;
                txtTenCoDau.Text = tc.TenCoDau;
                HOADON hOADON = DataProvider.dSHOADON.LayThongTinTheoMa(txtMaTiecCuoi.Text);
                if (hOADON != null)
                {
                    dtpNgayThanhToan.Value = hOADON.NgayThanhToan;
                }
                else
                {
                    dtpNgayThanhToan.Value = DateTime.Now;
                }
                nupSoLuongBan.Value = tc.SoLuongBan;
                txtDonGiaBan.Text = tc.DonGiaBan.ToString();
                txtTongTienBan.Text = (tc.DonGiaBan * tc.SoLuongBan).ToString();
                List<CTDATDICHVU> dv = DataProvider.dSCHITIETDATDICHVU.LayDSTheoMa(txtMaTiecCuoi.Text);
                int TongTienDichVu = 0;
                if (dv.Count != 0)
                {
                    foreach (CTDATDICHVU d in dv)
                    {
                        TongTienDichVu = TongTienDichVu + d.DonGia * d.SoLuong;
                    }
                }
                txtTongTienDichVu.Text = TongTienDichVu.ToString();
                txtTongTienHoaDon.Text = (tc.DonGiaBan * tc.SoLuongBan + TongTienDichVu).ToString();
                txtTienDatCoc.Text = tc.TienDatCoc.ToString();
                txtConLai.Text = (tc.DonGiaBan * tc.SoLuongBan + TongTienDichVu - tc.TienDatCoc).ToString();
                string a = dgvTiecCuoi.Rows[e.RowIndex].Cells[1].Value.ToString();
                HienThiDanhSachChiTietDichVu(a);
                _MaTiecCuoi = txtMaTiecCuoi.Text;
            }
        }
        private bool InputValidate()
        {
            int err = 0;
            if (string.IsNullOrEmpty(txtMaTiecCuoi.Text))
            {
                epMaTiecCuoi.SetError(txtMaTiecCuoi, "Vui lòng chọn");
                err++;
            }
            else
            {
                epMaTiecCuoi.SetError(txtMaTiecCuoi, "");
            }
            //if (DataProvider.StringToInt(txtThanhToan, epThanhToan) == 0)
            //{
            //    err++;
            //}
            //else
            //{
                
            //    if(DataProvider.StringToInt(txtThanhToan, epThanhToan) > Convert.ToInt32(txtConLai.Text))
            //    {
            //        epThanhToan.SetError(txtThanhToan, "Số tiền thanh toán lớn hơn số tiền còn lại");
            //        err++;
            //    }
            //    else
            //    {
            //        epThanhToan.SetError(txtThanhToan, "");
            //    }
            //}
            if (err == 0)
            {
                return true;
            }
            return false;
        }
            private void flowLayoutPanel4_Click(object sender, EventArgs e)
        {
            HienThi();
        }

        private void flowLayoutPanel2_Click(object sender, EventArgs e)
        {
            HienThi();
        }

        private void flowLayoutPanel3_Click(object sender, EventArgs e)
        {
            HienThi();
        }

        private void ucHoaDon_Click(object sender, EventArgs e)
        {
            HienThi();
        }

        private void btnTiecCuoi_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            ucDatTiecCuoi uc = new ucDatTiecCuoi();
            uc.MaTiecCuoi = txtMaTiecCuoi.Text;
            this.Controls.Add(uc);
            uc.BringToFront();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            
            if (InputValidate() == true)
            {
                if (DataProvider.StringToInt(txtThanhToan, epThanhToan) > Convert.ToInt32(txtConLai.Text))
                {
                    epThanhToan.SetError(txtThanhToan, "Số tiền thanh toán lớn hơn số tiền còn lại");
                }
                else
                {
                    epThanhToan.SetError(txtThanhToan, "");
                }
                HOADON hOADON = new HOADON();
                hOADON.MaHoaDon = txtMaTiecCuoi.Text;
                hOADON.MaTiecCuoi = txtMaTiecCuoi.Text;
                hOADON.NgayThanhToan = dtpNgayThanhToan.Value;
                hOADON.SoLuongBan = (int)nupSoLuongBan.Value;
                hOADON.TongTienBan = Convert.ToInt32(txtTongTienBan.Text);
                hOADON.TongTienDichVu = Convert.ToInt32(txtTongTienDichVu.Text);
                hOADON.TongTienHoaDon = Convert.ToInt32(txtTongTienHoaDon.Text);
                int conlai = Convert.ToInt32(txtConLai.Text);
                hOADON.ConLai = conlai - DataProvider.StringToInt(txtThanhToan, epThanhToan);
                int tiendatcoc = Convert.ToInt32(txtTienDatCoc.Text)+ DataProvider.StringToInt(txtThanhToan, epThanhToan);
                TIECCUOI tIECCUOI = DataProvider.dSTIECCUOI.LayThongTinTheoMa(txtMaTiecCuoi.Text);
                tIECCUOI.TienDatCoc = tiendatcoc;
                DataProvider.dSTIECCUOI.CapNhatThongTin(tIECCUOI);
                epThanhToan.SetError(txtThanhToan, "");
                HOADON kt = DataProvider.dSHOADON.LayThongTinTheoMa(hOADON.MaHoaDon);
                if(kt == null)
                {
                    bool kq = DataProvider.dSHOADON.ThemMoi(hOADON);
                    if (kq == true)
                    {
                        MessageBox.Show("Thêm mới hóa đơn " + txtMaTiecCuoi.Text + " thành công");
                    }
                    HienThiDanhSachTiecCuoi();
                }
                else
                {
                    bool kq = DataProvider.dSHOADON.CapNhatThongTin(hOADON);
                    if (kq == true)
                    {
                        MessageBox.Show("Cập nhật hóa đơn " + txtMaTiecCuoi.Text + " thành công");
                    }
                    HienThiDanhSachTiecCuoi();
                }
            }
        }
    }
}
