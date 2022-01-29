using NhanDatTiecCuoi.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NhanDatTiecCuoi
{
    public class DataProvider
    {
        private static DSLOAISANH _dSLOAISANH = null;
        public static DSLOAISANH SLOAISANH
        {
            get
            {
                if (_dSLOAISANH == null)
                {
                    _dSLOAISANH = new DSLOAISANH();
                }
                return _dSLOAISANH;
            }
        }
    }
}
