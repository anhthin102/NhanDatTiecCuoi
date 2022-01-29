using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NhanDatTiecCuoi.Data
{
    public class CTDATDICHVU
    {
        private string _MaTiecCuoi = "";
        public string MaTiecCuoi
        {
            get
            {
                return _MaTiecCuoi;
            }
            set
            {
                MaTiecCuoi = value;
            }
        }
        private string _MaDichVu = "";
        public string MaDichVu
        {
            get
            {
                return _MaDichVu;
            }
            set
            {
                _MaDichVu = value;
            }
        }
        public int SoLuong { get; set; }
        public int DonGia { get; set; }
        public string GhiChu { get; set; }
    }
}
