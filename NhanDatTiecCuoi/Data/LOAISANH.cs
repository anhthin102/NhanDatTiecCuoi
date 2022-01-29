using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NhanDatTiecCuoi.Data
{
    public class LOAISANH
    {
        private string _MaLoaiSanh = "";
        public string MaLoaiSanh { 
            get { return _MaLoaiSanh; }
            set
            {
                _MaLoaiSanh = value;
            }
        }
        public string TenLoaiSanh { get; set; }
        public string DonGiaBanToiThieu { get; set; }

    }
}
