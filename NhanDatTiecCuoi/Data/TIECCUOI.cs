using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NhanDatTiecCuoi.Data
{
    public class TIECCUOI
    {
        private string _MaTiecCuoi = "";
        public string MaTiecCuoi
        {
            get { return _MaTiecCuoi; }
            set { _MaTiecCuoi = value; }
        }
        public string TenChuRe { get; set; }
        public string TenCoDau { get; set; }
        public string SĐT { get; set; }
        public  DateTime NgayDatTiec { get; set; }
        public DateTime NgayDaiTiec { get; set; }
        public int TienDatCoc { get; set; }
        public int SoLuongBan { get; set; }
        public int SoBanDuTru { get; set; }
        public int DonGia { get; set; }
        public string MaCa { get; set; }
        public string MaSanh { get; set; }
    }
}
