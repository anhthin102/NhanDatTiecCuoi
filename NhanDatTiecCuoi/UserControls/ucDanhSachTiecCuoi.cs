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
    public partial class ucDanhSachTiecCuoi : UserControl
    {
        public ucDanhSachTiecCuoi()
        {
            InitializeComponent();
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
        }
        private void ucDanhSachTiecCuoi_Load(object sender, EventArgs e)
        {
            HienThiDanhSachTiecCuoi();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            List<TIECCUOI> tIECCUOIs1 = DataProvider.dSTIECCUOI.LayDS();
            List<TIECCUOI> tIECCUOIs = new List<TIECCUOI>();
            foreach (TIECCUOI t in tIECCUOIs1)
            {
                if (((string.IsNullOrEmpty(txtMaTiecCuoi.Text)) || t.MaTiecCuoi == txtMaTiecCuoi.Text)
                    && ((string.IsNullOrEmpty(txtTenChuRe.Text)) || t.TenChuRe == txtTenChuRe.Text)
                    && ((string.IsNullOrEmpty(txtTenCoDau.Text)) || t.TenCoDau == txtTenCoDau.Text))
                {
                    tIECCUOIs.Add(t);
                }
            }
            Converter converter = new Converter();
            DataTable dt = converter.ToDataTable(tIECCUOIs);
            DataTable data = converter.AutoNumberedTable(dt);
            dgvTiecCuoi.DataSource = null;
            dgvTiecCuoi.DataSource = data;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtMaTiecCuoi.Text = dgvTiecCuoi.CurrentRow.Cells[1].Value.ToString();
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
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            ucDatTiecCuoi uc = new ucDatTiecCuoi();
            uc.MaTiecCuoi = dgvTiecCuoi.CurrentRow.Cells[1].Value.ToString();
            this.Controls.Add(uc);
            uc.BringToFront();
        }

        private void ucDanhSachTiecCuoi_Click(object sender, EventArgs e)
        {
            HienThiDanhSachTiecCuoi();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            HienThiDanhSachTiecCuoi();
        }
    }
}
