using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NhanDatTiecCuoi.Data
{
    public class BAOCAO
    {
        private string _MaBaoCao = "";
        public string MaBaoCao {
            get { return _MaBaoCao; }
            set { _MaBaoCao = value; } 
        }
        public int Thang { get; set; }
        public int Nam { get; set; }
        public int TongDoanhThu { get; set; }
    }
}
