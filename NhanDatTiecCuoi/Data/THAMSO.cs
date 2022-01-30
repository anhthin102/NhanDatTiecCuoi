using NhanDatTiecCuoi.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NhanDatTiecCuoi.Data
{
    public class THAMSO
    {
        private bool _apDungQuyDinhPhat = true;
        public bool ApDungQDPhat {
            get
            {
                return _apDungQuyDinhPhat;
            }
            set
            {
                _apDungQuyDinhPhat = value;
            }
        }
        private int _tiLePhat = 3;
        public int TiLePhat {
            get {
                return _tiLePhat; 
            }
            set
            {
                _tiLePhat = value;
            }
        }

       
    }
}
