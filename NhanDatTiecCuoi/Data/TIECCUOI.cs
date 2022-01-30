using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NhanDatTiecCuoi.Data
{
    public class TIECCUOI
    {
        public TIECCUOI() { }
        public TIECCUOI(string MaTiecCuoi, string TenChuRe, string TenCoDau, string SDT, DateTime NgayDatTiec, DateTime NgayDaiTiec, int TienDatCoc, int SoLuongBan, int SoBanDuTru, int DonGiaBan, string MaCa, string MaSanh)
        {
            this.MaTiecCuoi = MaTiecCuoi;
            this.TenChuRe = TenChuRe;
            this.TenCoDau = TenCoDau;
            this.SDT = SDT;
            this.NgayDatTiec = NgayDatTiec;
            this.NgayDaiTiec = NgayDaiTiec;
            this.TienDatCoc = TienDatCoc;
            this.SoLuongBan = SoLuongBan;
            this.SoBanDuTru = SoBanDuTru;
            this.DonGiaBan = DonGiaBan;
            this.MaCa = MaCa;
            this.MaSanh = MaSanh;
        }
        private string _MaTiecCuoi = "";
        public string MaTiecCuoi
        {
            get { return _MaTiecCuoi; }
            set { _MaTiecCuoi = value; }
        }
        public string TenChuRe { get; set; }
        public string TenCoDau { get; set; }
        public string SDT { get; set; }
        public  DateTime NgayDatTiec { get; set; }
        public DateTime NgayDaiTiec { get; set; }
        public int TienDatCoc { get; set; }
        public int SoLuongBan { get; set; }
        public int SoBanDuTru { get; set; }
        public int DonGiaBan { get; set; }
        public string MaCa { get; set; }
        public string MaSanh { get; set; }
    }
}
