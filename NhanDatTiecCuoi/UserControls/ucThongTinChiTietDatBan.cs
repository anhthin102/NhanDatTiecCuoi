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
    public partial class ucThongTinChiTietDatBan : UserControl
    {
        private string _MaTiecCuoi = "";
        public string MaTiecCuoi
        {
            get { return _MaTiecCuoi; }
            set { _MaTiecCuoi = value; }
        }
        public ucThongTinChiTietDatBan()
        {
            InitializeComponent();
        }
        private void HienThi()
        {
            HienThiDanhSachMonAn();
            HienThiDanhSachChiTietDatBan();
            ReLoadMa();
        }
        private void ReLoadMa()
        {
            txtMaTiecCuoi.Text = _MaTiecCuoi;
            List<CTDATBAN> cTDATBANs = DataProvider.dSCHITIETDATBAN.LayDSTheoMa(_MaTiecCuoi);
            List<MONAN> mONANs = DataProvider.dSMONAN.LayDS();
            cboMaMonAn.Items.Clear();
            foreach (MONAN m in mONANs)
            {
                cboMaMonAn.Items.Add(m.MaMonAn);
            }
            cboMaMonAn.Text = "";
            txtDonGia.Text = "";
            nupSoLuong.Value = 0;
            txtGhiChu.Text = "";
        }
        private void HienThiDanhSachChiTietDatBan()
        {
            if (string.IsNullOrEmpty(_MaTiecCuoi))
            {
                List<CTDATBAN> cTDATBANs = DataProvider.dSCHITIETDATBAN.LayDS();
                Converter converter = new Converter();
                DataTable dt = converter.ToDataTable(cTDATBANs);
                DataTable data = converter.AutoNumberedTable(dt);
                dgvDatBan.DataSource = null;
                dgvDatBan.DataSource = data;
                dgvDatBan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            else
            {
                List<CTDATBAN> cTDATBANs = DataProvider.dSCHITIETDATBAN.LayDS();
                List<CTDATBAN> cTDATBANs1 = new List<CTDATBAN>();
                foreach (CTDATBAN ct in cTDATBANs)
                {
                    if (ct.MaTiecCuoi == _MaTiecCuoi)
                    {
                        cTDATBANs1.Add(ct);
                    }
                }
                Converter converter = new Converter();
                DataTable dt = converter.ToDataTable(cTDATBANs1);
                DataTable data = converter.AutoNumberedTable(dt);
                dgvDatBan.DataSource = null;
                dgvDatBan.DataSource = data;
                dgvDatBan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
        }
        private void HienThiDanhSachMonAn()
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


        private void button2_Click(object sender, EventArgs e)
        {
            List<CTDATBAN> cs = DataProvider.dSCHITIETDATBAN.LayDSTheoMa(_MaTiecCuoi);
            TIECCUOI tc = DataProvider.dSTIECCUOI.LayThongTinTheoMa(_MaTiecCuoi);
            tc.DonGiaBan = 0;
            if (cs.Count != 0)
            {
                foreach (CTDATBAN d in cs)
                {
                    tc.DonGiaBan = tc.DonGiaBan + d.DonGia * d.SoLuong;
                }
            }

            DataProvider.dSTIECCUOI.CapNhatThongTin(tc);
            this.Controls.Clear();
            ucDatTiecCuoi uc = new ucDatTiecCuoi();
            uc.MaTiecCuoi = txtMaTiecCuoi.Text;
            this.Controls.Add(uc);
            uc.BringToFront();
        }

        private void ucThongTinChiTietDatBan_Load(object sender, EventArgs e)
        {
            HienThi();
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            if (InputValidate() == true)
            {
                List<CTDATBAN> cTDATBANs = DataProvider.dSCHITIETDATBAN.LayDSTheoMa(txtMaTiecCuoi.Text);
                if (cTDATBANs.Count != 0)
                {
                    for (int i = 0; i < cTDATBANs.Count; i++)
                    {
                        if (cboMaMonAn.Text == cTDATBANs[i].MaMonAn)
                        {
                            epMaMonAn.SetError(cboMaMonAn, "Món ăn đã có không thể thêm mới, hãy cập nhật");
                            return;
                        }
                        else
                        {
                            epMaMonAn.SetError(cboMaMonAn, "");
                        }
                    }
                }
                CTDATBAN cTDATBAN = new CTDATBAN();
                cTDATBAN.MaTiecCuoi = txtMaTiecCuoi.Text;
                cTDATBAN.MaMonAn = cboMaMonAn.Text;
                cTDATBAN.SoLuong = (int)nupSoLuong.Value;
                cTDATBAN.GhiChu = txtGhiChu.Text;
                cTDATBAN.DonGia = Convert.ToInt32(txtDonGia.Text);
                bool kq = DataProvider.dSCHITIETDATBAN.ThemMoi(cTDATBAN);
                if (kq == true)
                {
                    MessageBox.Show("Thêm mới CTDB thành công");
                    HienThiDanhSachChiTietDatBan();
                    ReLoadMa();

                }
            }


        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (InputValidate() == true)
            {
                List<CTDATBAN> cTDATBANs = DataProvider.dSCHITIETDATBAN.LayDSTheoMa(txtMaTiecCuoi.Text);
                if (cTDATBANs.Count == 0)
                {
                    epMaMonAn.SetError(cboMaMonAn, "Món ăn chưa có hãy thêm mới");
                    return;
                }
                else
                {
                    bool tim = false;
                    for (int i = 0; i < cTDATBANs.Count; i++)
                    {
                        if (cboMaMonAn.Text == cTDATBANs[i].MaMonAn)
                        {
                            tim = true;
                            break;
                        }

                    }
                    if (tim == false)
                    {
                        epMaMonAn.SetError(cboMaMonAn, "Món ăn chưa có hãy thêm mới");
                        return;
                    }
                    else
                    {
                        epMaMonAn.SetError(cboMaMonAn, "");
                    }

                }
                CTDATBAN cTDATBAN = new CTDATBAN();
                cTDATBAN.MaTiecCuoi = txtMaTiecCuoi.Text;
                cTDATBAN.MaMonAn = cboMaMonAn.Text;
                cTDATBAN.SoLuong = (int)nupSoLuong.Value;
                cTDATBAN.GhiChu = txtGhiChu.Text;
                cTDATBAN.DonGia = Convert.ToInt32(txtDonGia.Text);
                bool kq = DataProvider.dSCHITIETDATBAN.CapNhatThongTin(cTDATBAN);
                if (kq == true)
                {
                    MessageBox.Show("Cập nhật CTDB thành công");
                    HienThiDanhSachChiTietDatBan();
                    ReLoadMa();

                }
            }
        }

        private void dgvDatBan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvDatBan.RowCount - 1)
            {
                txtMaTiecCuoi.Text = dgvDatBan.Rows[e.RowIndex].Cells[1].Value.ToString();
                List<CTDATBAN> cTDATBANs = DataProvider.dSCHITIETDATBAN.LayDSTheoMa(txtMaTiecCuoi.Text);
                for (int i = 0; i < cTDATBANs.Count; i++)
                {
                    if (cTDATBANs[i].MaMonAn == dgvDatBan.Rows[e.RowIndex].Cells[2].Value.ToString())
                    {
                        cboMaMonAn.SelectedItem = cTDATBANs[i].MaMonAn;
                        txtDonGia.Text = cTDATBANs[i].DonGia.ToString();
                        nupSoLuong.Value = cTDATBANs[i].SoLuong;
                        txtGhiChu.Text = cTDATBANs[i].GhiChu;
                        break;
                    }
                }
            }
        }
        private bool InputValidate()
        {
            int err = 0;
            if (string.IsNullOrEmpty(cboMaMonAn.Text))
            {
                err++;
                epMaMonAn.SetError(cboMaMonAn, "Vui lòng chọn mã món ăn");
            }
            else
            {
                epMaMonAn.SetError(cboMaMonAn, "");
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
        private void ucThongTinChiTietDatBan_Click(object sender, EventArgs e)
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

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            HienThi();
        }

        private void cboMaMonAn_SelectedIndexChanged(object sender, EventArgs e)
        {
            MONAN mONAN = DataProvider.dSMONAN.LayThongTinTheoMa(cboMaMonAn.Text);
            txtDonGia.Text = mONAN.DonGia.ToString();
        }

        private void txtGhiChu_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (InputValidate() == true)
            {
                List<CTDATBAN> cTDATBANs = DataProvider.dSCHITIETDATBAN.LayDSTheoMa(txtMaTiecCuoi.Text);
                if (cTDATBANs.Count == 0)
                {
                    epMaMonAn.SetError(cboMaMonAn, "Món ăn chưa có không cần xóa");
                    return;
                }
                else
                {
                    bool tim = false;
                    for (int i = 0; i < cTDATBANs.Count; i++)
                    {
                        if (cboMaMonAn.Text == cTDATBANs[i].MaMonAn)
                        {
                            tim = true;
                            break;
                        }

                    }
                    if (tim == false)
                    {
                        epMaMonAn.SetError(cboMaMonAn, "Món ăn chưa có không cần xóa");
                        return;
                    }
                    else
                    {
                        epMaMonAn.SetError(cboMaMonAn, "");
                    }

                }
                CTDATBAN cTDATBAN = new CTDATBAN();
                cTDATBAN.MaTiecCuoi = txtMaTiecCuoi.Text;
                cTDATBAN.MaMonAn = cboMaMonAn.Text;
                cTDATBAN.SoLuong = (int)nupSoLuong.Value;
                cTDATBAN.GhiChu = txtGhiChu.Text;
                cTDATBAN.DonGia = Convert.ToInt32(txtDonGia.Text);
                bool kq = DataProvider.dSCHITIETDATBAN.Xoa(cTDATBAN);
                if (kq == true)
                {
                    MessageBox.Show("Xóa CTDB thành công");
                    HienThiDanhSachChiTietDatBan();
                    ReLoadMa();

                }
            }
        }
    }
}

