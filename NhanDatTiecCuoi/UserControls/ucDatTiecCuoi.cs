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
            txtSoBanDuTru.Text = "0";
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
        }
        private void HienThi()
        {
            HienThiDanhSachSanh();
            HienThiDanhSachCacLoaiCa();
            HienThiDanhSachTiecCuoi();
            HienThiDanhSachChiTietDatBan("");
            HienThiDanhSachChiTietDichVu("");
            ReLoadMa();
        }
        private void label1_Click(object sender, EventArgs e)
        {
                    }

        private void ucDatTiecCuoi_Load(object sender, EventArgs e)
        {
            HienThi();

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView5_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void flowLayoutPanel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel5_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView4_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            ucThongTinChiTietDatBan uc = new ucThongTinChiTietDatBan();
            this.Controls.Add(uc);
            uc.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            ucThongTinChiTietDatDichVu uc = new ucThongTinChiTietDatDichVu();
            this.Controls.Add(uc);
            uc.BringToFront();
        }

        private void dataGridView6_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
                cboMaSanh.SelectedItem = tc.MaSanh;
            }
            string a = dgvTiecCuoi.Rows[e.RowIndex].Cells[1].Value.ToString();
            HienThiDanhSachChiTietDatBan(a);
            HienThiDanhSachChiTietDichVu(a);
        }
    }
}
