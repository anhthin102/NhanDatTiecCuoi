using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NhanDatTiecCuoi.Data
{
    public class CTBAOCAO
    {
        public CTBAOCAO()
        {

        }
        private string _MaBaoCao = "";
        public string MaBaoCao
        {
            get { return _MaBaoCao; }
            set { _MaBaoCao = value; }
        }
        private DateTime _Ngay = DateTime.Now;
        public DateTime Ngay
        {
            get { return _Ngay; }
            set { _Ngay = value; }
        }
        public int SLTiecCuoi { get; set; }
        public int DoanhThu { get; set; }
        public float TiLe { get; set; }
    }
}
