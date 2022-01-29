using NhanDatTiecCuoi.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        private static DSCA _SCA = null;
        public static DSCA SCA
        {
            get
            {
                if (_SCA == null)
                {
                    _SCA = new DSCA();
                }
                return _SCA;
            }
        }
        private static DSDICHVU _dSDICHVU = null;
        public static DSDICHVU dSDICHVU
        {
            get
            {
                if (_dSDICHVU == null)
                {
                    _dSDICHVU = new DSDICHVU();
                }
                return _dSDICHVU;
            }
        }
        private static int _StringToInt = 0;
        public static int StringToInt(TextBox textBox, ErrorProvider ep)
        {
            try
            {
                _StringToInt = int.Parse(textBox.Text);
            }
            // Ngoại lệ ArgumentNullException xảy ra khi người dùng không nhập dữ liệu
            catch (Exception ex)
            {
                if (ex is ArgumentNullException)
                    ep.SetError(textBox, "Your string is null, " + ex.ToString());
                else if (ex is ArgumentNullException)
                    ep.SetError(textBox, "Your string is not in the correct format. , " + ex.ToString());
                else if (ex is OverflowException)
                    ep.SetError(textBox, "Your string represents a number less than MinValue or greater than MaxValue. , " + ex.ToString());
                else
                    ep.SetError(textBox, "Your string is invalid, " + ex.ToString());
            }
            return _StringToInt;
        }
    }
}
