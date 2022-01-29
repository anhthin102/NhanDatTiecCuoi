using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NhanDatTiecCuoi.Data
{
    public class DICHVU
    {
        public DICHVU()
        {

        }
        public DICHVU(string MaDichVu, string TenDichVu, int DonGia, string GhiChu)
        {
            this.MaDichVu = MaDichVu;
            this.TenDichVu = TenDichVu;
            this.DonGia = DonGia;
            this.GhiChu = GhiChu;
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
        public string TenDichVu { get; set; }

        public int DonGia { get; set; }
        public string GhiChu { get; set; }
    }
}
