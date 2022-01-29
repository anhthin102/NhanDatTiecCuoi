using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NhanDatTiecCuoi.Data
{
    public class DICHVU
    {
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
