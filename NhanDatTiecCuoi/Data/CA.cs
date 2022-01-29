using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NhanDatTiecCuoi.Data
{
    public class CA
    {
        private string _MaCa = "";
        public string MaCa
        {
            get
            {
                return _MaCa;
            }
            set
            {
                _MaCa = value;
            }
        }
        public string LoaiCa { get; set; }
    }
}
