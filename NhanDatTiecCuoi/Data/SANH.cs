using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NhanDatTiecCuoi.Data
{
    public class SANH
    {
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
