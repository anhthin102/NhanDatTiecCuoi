using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NhanDatTiecCuoi.Data
{
    class CTDATBAN
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
        private string _MaMonAn = "";
        public string MaMonAn
        {
            get
            {
                return _MaMonAn;
            }
            set
            {
                _MaMonAn = value;
            }
        }
        public int SoLuong { get; set; }
        public int DonGia { get; set; }
        public string GhiChu { get; set; }
    }
}
