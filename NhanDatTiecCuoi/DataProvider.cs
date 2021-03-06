using NhanDatTiecCuoi.Business;
using NhanDatTiecCuoi.Data;
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
        private static DSHOADON _dSHOADON = null;
        public static DSHOADON dSHOADON
        {
            get
            {
                if (_dSHOADON == null)
                {
                    _dSHOADON = new DSHOADON();
                }
                return _dSHOADON;
            }
        }
        private static DSCHITIETDATDICHVU _dSCHITIETDATDICHVU = null;
        public static DSCHITIETDATDICHVU dSCHITIETDATDICHVU
        {
            get
            {
                if (_dSCHITIETDATDICHVU == null)
                {
                    _dSCHITIETDATDICHVU = new DSCHITIETDATDICHVU();
                }
                return _dSCHITIETDATDICHVU;
            }
        }
        private static DSCHITIETDATBAN _dSCHITIETDATBAN = null;
        public static DSCHITIETDATBAN dSCHITIETDATBAN
        {
            get
            {
                if (_dSCHITIETDATBAN == null)
                {
                    _dSCHITIETDATBAN = new DSCHITIETDATBAN();
                }
                return _dSCHITIETDATBAN;
            }
        }
        private static DSTIECCUOI _dSTIECCUOI = null;
        public static DSTIECCUOI dSTIECCUOI
        {
            get
            {
                if (_dSTIECCUOI == null)
                {
                    _dSTIECCUOI = new DSTIECCUOI();
                }
                return _dSTIECCUOI;
            }
        }
        private static DSSANH _sANH = null;
        public static DSSANH SANHs
        {
            get
            {
                if (_sANH == null)
                {
                    _sANH = new DSSANH();
                }
                return _sANH;
            }
        }
        private static THAMSO _tHAMSO = null;
        public static THAMSO tHAMSO
        {
            get
            {
                if (_tHAMSO == null)
                {
                    _tHAMSO = new THAMSO();
                }
                return _tHAMSO;
            }
        }
        private static DSMONAN _dSMONAN = null;
        public static DSMONAN dSMONAN
        {
            get
            {
                if (_dSMONAN == null)
                {
                    _dSMONAN = new DSMONAN();
                }
                return _dSMONAN;
            }
        }
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
