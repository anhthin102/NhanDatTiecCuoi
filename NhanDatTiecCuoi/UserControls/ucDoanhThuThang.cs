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
    public partial class ucDoanhThuThang : UserControl
    {
        public ucDoanhThuThang()
        {
            InitializeComponent();
        }
        private int HienThi(int thang, int nam)
        {
            List<CTBAOCAO> cTBAOCAOs = new List<CTBAOCAO>();
            if (thang ==0 & nam == 0)
            {
                List<HOADON> hOADONs = DataProvider.dSHOADON.LayDS();
                int tongdoanhthu = HienThiDanhSach(hOADONs, cTBAOCAOs);
                return tongdoanhthu;
            }
            else
            {
                List<HOADON> hOADONs = DataProvider.dSHOADON.LayDanhSachTheoThoiGian(thang, nam);
                int tongdoanhthu = HienThiDanhSach(hOADONs, cTBAOCAOs);
                return tongdoanhthu;
            }
        }
        private int HienThiDanhSach(List<HOADON> hOADONs, List<CTBAOCAO> cTBAOCAOs)
        {
            int ma = 0;
            foreach (HOADON h in hOADONs)
            {
                if (cTBAOCAOs.Count == 0)
                {
                    ma = ma + 1;
                    CTBAOCAO c = new CTBAOCAO();
                    c.MaBaoCao = ma.ToString();
                    c.Ngay = h.NgayThanhToan;
                    c.SLTiecCuoi = 1;
                    c.DoanhThu = h.TongTienHoaDon;
                    cTBAOCAOs.Add(c);
                }
                else
                {
                    bool tim = false;
                    for (int i = 0; i < cTBAOCAOs.Count; i++)
                    {
                        if (h.NgayThanhToan == cTBAOCAOs[i].Ngay)
                        {
                            cTBAOCAOs[i].SLTiecCuoi++;
                            cTBAOCAOs[i].DoanhThu += h.TongTienHoaDon;
                            tim = true;
                            break;
                        }
                    }
                    if (tim == false)
                    {
                        ma = ma + 1;
                        CTBAOCAO c = new CTBAOCAO();
                        c.MaBaoCao = ma.ToString();
                        c.Ngay = h.NgayThanhToan;
                        c.SLTiecCuoi = 1;
                        c.DoanhThu = h.TongTienHoaDon;
                        cTBAOCAOs.Add(c);
                    }
                }
            }
            float tongdoanhthu = 0;
            foreach (CTBAOCAO c in cTBAOCAOs)
            {
                tongdoanhthu += (float)c.DoanhThu;
            }
            foreach (CTBAOCAO c in cTBAOCAOs)
            {
                c.TiLe = (float)Math.Round(c.DoanhThu / tongdoanhthu, 2);
            }
            Converter converter = new Converter();
            DataTable dt = converter.ToDataTable(cTBAOCAOs);
            DataTable data = converter.AutoNumberedTable(dt);
            dgvDoanhthu.DataSource = null;
            dgvDoanhthu.DataSource = data;
            return (int)tongdoanhthu;
        }
        private bool InputValidate()
        {
            int err = 0;
            if (DataProvider.StringToInt(txtThang, epThang) <= 0 && DataProvider.StringToInt(txtThang, epThang)>12)
            {
                err++;
            }
            else
            {
                epThang.SetError(txtThang, "");
            }
            if (DataProvider.StringToInt(txtNam, epNam) <= 2021 && DataProvider.StringToInt(txtNam, epNam) > 2100)
            {
                err++;
            }
            else
            {
                epNam.SetError(txtNam, "");
            }

            if (err == 0)
            {
                return true;
            }
            return false;
        }
        private void ucDoanhThuThang_Load(object sender, EventArgs e)
        {
            HienThi(0,0);
        }

        private void ucDoanhThuThang_Click(object sender, EventArgs e)
        {
            HienThi(0,0);
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (InputValidate() == true)
            {
                int thu=HienThi(Convert.ToInt32(txtThang.Text), Convert.ToInt32(txtNam.Text));
                txtTongDoanhThu.Text = thu.ToString();
            }
        }
    }
}
