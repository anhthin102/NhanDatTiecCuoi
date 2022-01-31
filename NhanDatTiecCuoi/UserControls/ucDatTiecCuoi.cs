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
    public partial class ucDatTiecCuoi : UserControl
    {
        private string _MaTiecCuoi = "";
        public string MaTiecCuoi
        {
            get { return _MaTiecCuoi; }
            set { _MaTiecCuoi = value; }
        }
        public ucDatTiecCuoi()
        {
            InitializeComponent();
            
        }
        public void HienThiDanhSachSanh()
        {
            List<SANH> dsSanh = DataProvider.SANHs.LayDS();
            Converter converter = new Converter();
            DataTable dt = converter.ToDataTable(dsSanh);
            dt.Columns.RemoveAt(2);
            dt.Columns.Add("Tên Mã Loại Sảnh").SetOrdinal(2);
            dt.Columns.Add("Đơn giá bàn tối thiểu").SetOrdinal(3);
            DataTable data = converter.AutoNumberedTable(dt);
            dgvSanh.DataSource = null;
            dgvSanh.DataSource = data;
            //dgvSanh.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            List<LOAISANH> dsLoaiSanh = DataProvider.SLOAISANH.LayDS();
            for (int i = 0; i < dsSanh.Count; i++)
            {
                for (int j = 0; j < dsLoaiSanh.Count; j++)
                {
                    if (dsSanh[i].MaLoaiSanh == dsLoaiSanh[j].MaLoaiSanh)
                    {
                        dgvSanh.Rows[i].Cells[4].Value = dsLoaiSanh[j].DonGiaBanToiThieu.ToString();
                        dgvSanh.Rows[i].Cells[3].Value = dsLoaiSanh[j].TenLoaiSanh;
                        break;
                    }
                }
            }
           
            
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
        private void HienThiDanhSachTiecCuoi()
        {
            List<TIECCUOI> tIECCUOIs = DataProvider.dSTIECCUOI.LayDS();
            Converter converter = new Converter();
            DataTable dt = converter.ToDataTable(tIECCUOIs);
            DataTable data = converter.AutoNumberedTable(dt);
            dgvTiecCuoi.DataSource = null;
            dgvTiecCuoi.DataSource = data;
            //dgvTiecCuoi.Columns[5].DefaultCellStyle.Format = "dd/MM/yyyy";
            if (!string.IsNullOrEmpty(_MaTiecCuoi))
            {
                int index = 0;
                for (int i = 0; i <tIECCUOIs.Count; i++)
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
                        txtSDT.Text = tc.SDT;
                        dtpNgayDatTiec.Value = tc.NgayDatTiec;
                        dtpNgayDaiTiec.Value = tc.NgayDaiTiec;
                        txtTienDatCoc.Text = tc.TienDatCoc.ToString();
                        txtSoLuongBan.Text = tc.SoLuongBan.ToString();
                        txtSoBanDuTru.Text = tc.SoBanDuTru.ToString();
                        txtDonGiaBan.Text = tc.DonGiaBan.ToString();
                        cboMaCa.SelectedItem = tc.MaCa;
                        HienThiMaSanh();
                        cboMaSanh.Items.Add(tc.MaSanh);
                        cboMaSanh.SelectedItem = tc.MaSanh;
                        string a = dgvTiecCuoi.Rows[index].Cells[1].Value.ToString();
                        HienThiDanhSachChiTietDatBan(a);
                        HienThiDanhSachChiTietDichVu(a);
                    }
            }

        }
        private void HienThiDanhSachChiTietDatBan(string a)
        {
            if (string.IsNullOrEmpty(a))
            {
                List<CTDATBAN> cTDATBANs = DataProvider.dSCHITIETDATBAN.LayDS();
                Converter converter = new Converter();
                DataTable dt = converter.ToDataTable(cTDATBANs);
                DataTable data = converter.AutoNumberedTable(dt);
                dgvDatBan.DataSource = null;
                dgvDatBan.DataSource = data;
                //dgvDatBan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            else
            {
                List<CTDATBAN> cTDATBANs = DataProvider.dSCHITIETDATBAN.LayDS();
                List<CTDATBAN> cTDATBANs1 = new List<CTDATBAN>();
                foreach(CTDATBAN ct in cTDATBANs)
                {
                    if (ct.MaTiecCuoi == a)
                    {
                        cTDATBANs1.Add(ct);
                    }
                }
                Converter converter = new Converter();
                DataTable dt = converter.ToDataTable(cTDATBANs1);
                DataTable data = converter.AutoNumberedTable(dt);
                dgvDatBan.DataSource = null;
                dgvDatBan.DataSource = data;
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
                dgvDatDichVu.DataSource = null;
                dgvDatDichVu.DataSource = data;
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
                dgvDatDichVu.DataSource = null;
                dgvDatDichVu.DataSource = data;
            }

        }
        private void ReLoadMa()
        {
            txtSoBanDuTru.Text = "1";
            txtMaTiecCuoi.Text = DataProvider.dSTIECCUOI.LayMaMoi().ToString();
            List<CA> cAs = DataProvider.SCA.LayDS();
            cboMaCa.Items.Clear();
            foreach (CA c in cAs)
            {
                cboMaCa.Items.Add(c.MaCa);
            }
            cboMaCa.Text = cboMaCa.Items[0].ToString();
            List<SANH> dsSanh = DataProvider.SANHs.LayDS();
            cboMaSanh.Items.Clear();
            foreach (SANH s in dsSanh)
            {
                cboMaSanh.Items.Add(s.MaSanh);
            }
            cboMaSanh.Text = cboMaSanh.Items[0].ToString();
            txtTienDatCoc.Text = "1000000";
            txtDonGiaBan.Text = "0";
            List<TIECCUOI> tieccuois = DataProvider.dSTIECCUOI.LayDS();
            HienThiMaSanh();
            
        }
        private void HienThiMaSanh()
        {
            List<SANH> dsSanh = DataProvider.SANHs.LayDS();
            cboMaSanh.Items.Clear();
            foreach (SANH s in dsSanh)
            {
                cboMaSanh.Items.Add(s.MaSanh);
            }
            cboMaSanh.Text = cboMaSanh.Items[0].ToString();
            List<TIECCUOI> tieccuois = DataProvider.dSTIECCUOI.LayDS();
            foreach (TIECCUOI tc in tieccuois)
            {
                if ((DateTime.Compare(tc.NgayDaiTiec, dtpNgayDaiTiec.Value) == 0) && (tc.MaCa == cboMaCa.Text))
                {
                    cboMaSanh.Items.Remove(tc.MaSanh);

                }
            }
            if (cboMaSanh.Items.Count > 0)
            {
                cboMaSanh.Text = cboMaSanh.Items[0].ToString();
            }
            else { cboMaSanh.Text = "vui lòng chọn lại"; }
        }
        private void HienThi()
        {
            HienThiDanhSachSanh();
            HienThiDanhSachCacLoaiCa();
            HienThiDanhSachChiTietDatBan("");
            HienThiDanhSachChiTietDichVu("");
            ReLoadMa();
            HienThiDanhSachTiecCuoi();
        }
        private bool InputValidate()
        {
            int err = 0;
            if (string.IsNullOrEmpty(txtTenChuRe.Text))
            {
                epTenChuRe.SetError(txtTenChuRe, "Vui Lòng nhập tên chú rể");
                err++;
            }
            else
            {
                epTenChuRe.SetError(txtTenChuRe, "");
            }
            if (string.IsNullOrEmpty(txtTenCoDau.Text))
            {
                epTenCoDau.SetError(txtTenCoDau, "Vui Lòng nhập tên cô dâu");
                err++;
            }
            else
            {
                epTenCoDau.SetError(txtTenCoDau, "");
            }
            if (string.IsNullOrEmpty(txtSDT.Text))
            {
                epSDT.SetError(txtSDT, "Vui Lòng nhập số điện thoại");
                err++;
            }
            else
            {
                epSDT.SetError(txtSDT, "");
            }
            if (DataProvider.StringToInt(txtTienDatCoc, epTienDatCoc) == 0)
            {
                err++;
            }
            else
            {
                epTienDatCoc.SetError(txtTienDatCoc, "");
            }
            if (DataProvider.StringToInt(txtSoBanDuTru, epSoBanDuTru) == 0)
            {
                err++;
            }
            else
            {
                epSoBanDuTru.SetError(txtSoBanDuTru, "");
            }
            if (DataProvider.StringToInt(txtSoLuongBan, epSoLuongBan) == 0)
            {
                err++;
            }
            else
            {
                epSoLuongBan.SetError(txtSoLuongBan, "");
                SANH s = DataProvider.SANHs.LayThongTinTheoMa(cboMaSanh.Text);
                if ((DataProvider.StringToInt(txtSoLuongBan, epSoLuongBan) > s.SLBanToiDa))
                {
                    epSoLuongBan.SetError(txtSoLuongBan, "Vượt quá số lượng bàn tối đa của sảnh");
                    err++;
                }
            }
            
            if (err == 0)
            {
                return true;
            }
            return false;
        }


        private void ucDatTiecCuoi_Load(object sender, EventArgs e)
        {
            HienThi();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            ucThongTinChiTietDatBan uc = new ucThongTinChiTietDatBan();
            uc.MaTiecCuoi = dgvTiecCuoi.CurrentRow.Cells[1].Value.ToString();
            this.Controls.Add(uc);
            uc.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            ucThongTinChiTietDatDichVu uc = new ucThongTinChiTietDatDichVu();
            uc.MaTiecCuoi = dgvTiecCuoi.CurrentRow.Cells[1].Value.ToString();
            this.Controls.Add(uc);
            uc.BringToFront();
        }


        private void ucDatTiecCuoi_Click(object sender, EventArgs e)
        {
            HienThi();
        }

        private void flowLayoutPanel4_Click(object sender, EventArgs e)
        {
            HienThi();
        }

        private void flowLayoutPanel3_Click(object sender, EventArgs e)
        {
            HienThi();
        }

        private void flowLayoutPanel2_Click(object sender, EventArgs e)
        {
            HienThi();
        }

        private void flowLayoutPanel1_Click(object sender, EventArgs e)
        {
            HienThi();
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
                txtSDT.Text = tc.SDT;
                dtpNgayDatTiec.Value = tc.NgayDatTiec;
                dtpNgayDaiTiec.Value = tc.NgayDaiTiec;
                txtTienDatCoc.Text = tc.TienDatCoc.ToString();
                txtSoLuongBan.Text = tc.SoLuongBan.ToString();
                txtSoBanDuTru.Text = tc.SoBanDuTru.ToString();
                txtDonGiaBan.Text = tc.DonGiaBan.ToString();
                cboMaCa.SelectedItem = tc.MaCa;
                HienThiMaSanh();
                cboMaSanh.Items.Add(tc.MaSanh);
                cboMaSanh.SelectedItem = tc.MaSanh;
                string a = dgvTiecCuoi.Rows[e.RowIndex].Cells[1].Value.ToString();
                HienThiDanhSachChiTietDatBan(a);
                HienThiDanhSachChiTietDichVu(a);
            }
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtMaTiecCuoi.Text) != DataProvider.dSTIECCUOI.LayMaMoi())
            {
                epMaTiecCuoi.SetError(txtMaTiecCuoi, "Nhấn vào form để load lại mã tiệc cưới mới");
                return;
            }
            else
            {
                epMaTiecCuoi.SetError(txtMaTiecCuoi, "");
            }
            if (InputValidate() == true)
            {
                TIECCUOI s = new TIECCUOI();
                s.MaTiecCuoi = txtMaTiecCuoi.Text;
                s.TenChuRe = txtTenChuRe.Text;
                s.TenCoDau = txtTenCoDau.Text;
                s.SDT = txtSDT.Text;
                s.NgayDaiTiec = dtpNgayDaiTiec.Value;
                s.NgayDatTiec = dtpNgayDatTiec.Value;
                s.TienDatCoc = Convert.ToInt32(txtTienDatCoc.Text);
                s.SoLuongBan = Convert.ToInt32(txtSoLuongBan.Text);
                s.SoBanDuTru = Convert.ToInt32(txtSoBanDuTru.Text);
                s.DonGiaBan = Convert.ToInt32(txtDonGiaBan.Text);
                s.MaCa = cboMaCa.Text;
                s.MaSanh = cboMaSanh.Text;
                bool kq = DataProvider.dSTIECCUOI.ThemMoi(s);
                if (kq == true)
                {
                    MessageBox.Show("Thêm mới tiệc cưới thành công");
                    DataProvider.dSTIECCUOI.ThemMaMoi();
                    HienThiDanhSachTiecCuoi();
                    ReLoadMa();
                }
                
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtMaTiecCuoi.Text) == DataProvider.dSTIECCUOI.LayMaMoi())
            {
                epMaTiecCuoi.SetError(txtMaTiecCuoi, "Nhấn vào Bảng để chọn tiệc cưới cần sửa");
                return;
            }
            else
            {
                epMaTiecCuoi.SetError(txtMaTiecCuoi, "");
            }
            if (InputValidate() == true)
            {
                TIECCUOI s = new TIECCUOI();
                s.MaTiecCuoi = txtMaTiecCuoi.Text;
                s.TenChuRe = txtTenChuRe.Text;
                s.TenCoDau = txtTenCoDau.Text;
                s.SDT = txtSDT.Text;
                s.NgayDaiTiec = dtpNgayDaiTiec.Value;
                s.NgayDatTiec = dtpNgayDatTiec.Value;
                s.TienDatCoc = Convert.ToInt32(txtTienDatCoc.Text);
                s.SoLuongBan = Convert.ToInt32(txtSoLuongBan.Text);
                s.SoBanDuTru = Convert.ToInt32(txtSoBanDuTru.Text);
                s.DonGiaBan = Convert.ToInt32(txtDonGiaBan.Text);
                s.MaCa = cboMaCa.Text;
                s.MaSanh = cboMaSanh.Text;
                bool kq = DataProvider.dSTIECCUOI.CapNhatThongTin(s);
                if (kq == true)
                {
                    MessageBox.Show("Cập nhật tiệc cưới " + txtMaTiecCuoi.Text + " thành công");
                }
                HienThiDanhSachTiecCuoi();
                ReLoadMa();
            }
        }

       

        private void cboMaCa_DropDown(object sender, EventArgs e)
        {
            //HienThiMaSanh();
            //if (Convert.ToInt32(txtMaTiecCuoi.Text) != DataProvider.dSTIECCUOI.LayMaMoi())
            //{
            //    TIECCUOI tc = DataProvider.dSTIECCUOI.LayThongTinTheoMa(txtMaTiecCuoi.Text);
            //    if (tc.MaCa == cboMaCa.Text)
            //    {
            //        cboMaSanh.Items.Add(tc.MaSanh);
            //    }
            //}
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

            if (Convert.ToInt32(txtMaTiecCuoi.Text) == DataProvider.dSTIECCUOI.LayMaMoi())
            {
                epMaTiecCuoi.SetError(txtMaTiecCuoi, "Nhấn vào Bảng để chọn tiệc cưới cần xóa");
                return;
            }
            else
            {
                epMaTiecCuoi.SetError(txtMaTiecCuoi, "");
            }
            if (InputValidate() == true)
            {
                TIECCUOI tc = DataProvider.dSTIECCUOI.LayThongTinTheoMa(txtMaTiecCuoi.Text);
                
                if (MessageBox.Show("Bạn có muốn xóa tiệc cưới " + txtMaTiecCuoi.Text + " hay không?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    bool kq = DataProvider.dSTIECCUOI.Xoa(tc);

                    if (kq == true)
                    {
                        List<CTDATBAN> cTDATBAN = DataProvider.dSCHITIETDATBAN.LayDSTheoMa(tc.MaTiecCuoi);
                        if (cTDATBAN.Count != 0)
                        {
                            for (int i = 0; i < cTDATBAN.Count; i++)
                            {
                                DataProvider.dSCHITIETDATBAN.Xoa(cTDATBAN[i]);
                            }
                        }
                        List<CTDATDICHVU> cTDATDICHVUs = DataProvider.dSCHITIETDATDICHVU.LayDSTheoMa(tc.MaTiecCuoi);
                        if (cTDATDICHVUs.Count != 0)
                        {
                            for (int i = 0; i < cTDATDICHVUs.Count; i++)
                            {
                                DataProvider.dSCHITIETDATDICHVU.Xoa(cTDATDICHVUs[i]);
                            }
                        }
                        MessageBox.Show("Xóa tiệc cưới " + txtMaTiecCuoi.Text + " thành công");
                    }
                    HienThiDanhSachTiecCuoi();
                    HienThiDanhSachChiTietDatBan("");
                    HienThiDanhSachChiTietDichVu("");
                    ReLoadMa();
                }

            }
        }

        private void flowLayoutPanel5_Click(object sender, EventArgs e)
        {
            HienThi();
        }

        private void flowLayoutPanel7_Click(object sender, EventArgs e)
        {
            HienThi();
        }

        private void lblDanhSachTiecCuoi_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            ucDanhSachTiecCuoi uc = new ucDanhSachTiecCuoi();
            this.Controls.Add(uc);
            uc.BringToFront();
        }

        private void cboMaCa_SelectedIndexChanged(object sender, EventArgs e)
        {
            HienThiMaSanh();
            if (Convert.ToInt32(txtMaTiecCuoi.Text) != DataProvider.dSTIECCUOI.LayMaMoi())
            {
                TIECCUOI tc = DataProvider.dSTIECCUOI.LayThongTinTheoMa(txtMaTiecCuoi.Text);
                if (tc.MaCa == cboMaCa.Text)
                {
                    cboMaSanh.Items.Add(tc.MaSanh);
                }
            }
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            ucHoaDon uc = new ucHoaDon();
            uc.MaTiecCuoi = dgvTiecCuoi.CurrentRow.Cells[1].Value.ToString();
            this.Controls.Add(uc);
            uc.BringToFront();
        }
    }
}
