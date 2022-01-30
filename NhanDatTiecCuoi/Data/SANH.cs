using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NhanDatTiecCuoi.Data
{
    public class SANH
    {
        public SANH()
        {

        }
        public SANH(string MaSanh, string TenSanh, string MaLoaiSanh, int SLBanToiDa, string GhiChu)
        {
            this.MaSanh = MaSanh;
            this.TenSanh = TenSanh;
            this.MaLoaiSanh = MaLoaiSanh;
            this.SLBanToiDa = SLBanToiDa;
            this.GhiChu = GhiChu;
        }
        
        private string _MaSanh = "";
        public string MaSanh
        {
            get
            {
                return _MaSanh;
            }
            set
            {
                _MaSanh = value;
            }
        }
        public string TenSanh { get; set; }
        public string MaLoaiSanh { get; set; }
        public int SLBanToiDa { get; set; }
        public string GhiChu { get; set; }

    }
}
