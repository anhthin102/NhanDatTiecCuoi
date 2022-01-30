using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NhanDatTiecCuoi.Data
{
    public class CTDATBAN
    {
        public CTDATBAN()
        {

        }
        public CTDATBAN(string MaTiecCuoi, string MaMonAn, int SoLuong,int DonGia, string GhiChu) 
        {
            this.MaTiecCuoi = MaTiecCuoi;
            this.MaMonAn = MaMonAn;
            this.SoLuong = SoLuong;
            this.DonGia = DonGia;
            this.GhiChu = GhiChu;
        }
        private string _MaTiecCuoi = "";
        public string MaTiecCuoi
        {
            get
            {
                return _MaTiecCuoi;
            }
            set
            {
                _MaTiecCuoi = value;
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
