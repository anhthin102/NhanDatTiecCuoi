using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NhanDatTiecCuoi.Data
{
    public class HOADON
    {
        private string _MaHoaDon = "";
        public string MaHoaDon
        {
            get
            {
                return _MaHoaDon;
            }
            set
            {
                _MaHoaDon = value;
            }
        }
        public string MaTiecCuoi { get; set; }
        public DateTime NgayThanhToan { get; set; }
        public int SoLuongBan { get; set; }
        public int TongTienBan { get; set; }
        public int TongTienDichVu { get; set; }
        public int TongTienHoaDon { get; set; }
        public int ConLai { get; set; }
    }
}
