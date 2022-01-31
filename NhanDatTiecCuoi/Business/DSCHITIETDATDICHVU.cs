using NhanDatTiecCuoi.Data;
using NhanDatTiecCuoi.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NhanDatTiecCuoi.Business
{
    public class DSCHITIETDATDICHVU : IDanhSach<CTDATDICHVU>
    {
        private List<CTDATDICHVU> _cTDATDICHVUs = new List<CTDATDICHVU>();
        private void TaoDuLieuBanDau()
        {
            List<CTDATDICHVU> cTDATDICHVUs = new List<CTDATDICHVU>()
            {
                new CTDATDICHVU("1","1",1,500000,""),
                new CTDATDICHVU("2","1",1,500000,""),
                new CTDATDICHVU("3","1",1,500000,"")
            };
            _cTDATDICHVUs = cTDATDICHVUs;
        }
        public bool CapNhatThongTin(CTDATDICHVU ds)
        {
            for (int i = 0; i < _cTDATDICHVUs.Count; i++)
            {
                if ((ds.MaTiecCuoi == _cTDATDICHVUs[i].MaTiecCuoi) && (ds.MaDichVu == _cTDATDICHVUs[i].MaDichVu))
                {
                    _cTDATDICHVUs[i] = ds;
                    return true;
                }
            }
            return false;
        }

        public List<CTDATDICHVU> LayDS()
        {
            if (_cTDATDICHVUs.Count == 0)
            {
                TaoDuLieuBanDau();
            }
            return _cTDATDICHVUs;
        }

        public int LayMaMoi()
        {
            throw new NotImplementedException();
        }

        public CTDATDICHVU LayThongTinTheoMa(string ma)
        {
            throw new NotImplementedException();
        }
        public List<CTDATDICHVU> LayDSTheoMa(string ma)
        {
            List<CTDATDICHVU> cTDATDICHVUs = new List<CTDATDICHVU>();
            foreach (CTDATDICHVU c in _cTDATDICHVUs)
            {
                if (ma == c.MaTiecCuoi)
                {
                    cTDATDICHVUs.Add(c);
                }
            }
            return cTDATDICHVUs;
        }
        public void ThemMaMoi()
        {
            throw new NotImplementedException();
        }

        public bool ThemMoi(CTDATDICHVU ds)
        {
            if (ds != null)
            {
                _cTDATDICHVUs.Add(ds);
                return true;
            }
            return false;
        }

        public bool Xoa(CTDATDICHVU ds)
        {
            if (ds != null)
            {
                _cTDATDICHVUs.Remove(ds);
                return true;
            }
            return false;
        }
    }
}
