using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NhanDatTiecCuoi.Data
{
    public class MONAN
    {
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
        public string TenMonAn { get; set; }

        public int DonGia { get; set; }
        public string GhiChu { get; set; }
    }
}
