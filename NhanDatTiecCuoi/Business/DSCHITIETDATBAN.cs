using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NhanDatTiecCuoi.Data;
using NhanDatTiecCuoi.Interface;

namespace NhanDatTiecCuoi.Business
{
    public class DSCHITIETDATBAN : IDanhSach<CTDATBAN>
    {
        private List<CTDATBAN> _cTDATBANs = new List<CTDATBAN>();
        private void TaoDuLieuBanDau()
        {

            List<CTDATBAN> cTDATBANs = new List<CTDATBAN>()
            {
                new CTDATBAN("1","1",1,200000,""),
                new CTDATBAN("1","2",2,140000,""),
                new CTDATBAN("2","1",1,200000,""),
                new CTDATBAN("2","2",3,140000,""),
                new CTDATBAN("3","1",1,200000,""),
                new CTDATBAN("3","3",2,250000,""),
            };
            _cTDATBANs = cTDATBANs;
        }
        public bool CapNhatThongTin(CTDATBAN ds)
        {
            for(int i=0; i<_cTDATBANs.Count; i++)
            {
                if ((ds.MaTiecCuoi == _cTDATBANs[i].MaTiecCuoi) && (ds.MaMonAn == _cTDATBANs[i].MaMonAn))
                {
                    _cTDATBANs[i] = ds;
                    return true;
                }
            }
            return false;
        }

        public List<CTDATBAN> LayDS()
        {
            if (_cTDATBANs.Count == 0)
            {
                TaoDuLieuBanDau();
            }
            return _cTDATBANs;
        }

        public int LayMaMoi()
        {
            throw new NotImplementedException();
        }

        public CTDATBAN LayThongTinTheoMa(string ma)
        {
            throw new NotImplementedException();
        }
        public List<CTDATBAN> LayDSTheoMa(string ma)
        {
            List<CTDATBAN> cTDATBANs = new List<CTDATBAN>();
            foreach(CTDATBAN  c in _cTDATBANs)
            {
                if (ma == c.MaTiecCuoi)
                {
                    cTDATBANs.Add(c);
                }
            }
            return cTDATBANs;
        }
        public void ThemMaMoi()
        {
            throw new NotImplementedException();
        }

        public bool ThemMoi(CTDATBAN ds)
        {
            if (ds != null)
            {
                _cTDATBANs.Add(ds);
                return true;
            }
            return false;
        }

        public bool Xoa(CTDATBAN ds)
        {
            if (ds != null)
            {
                _cTDATBANs.Remove(ds);
                return true;
            }
            return false;
        }
    }
}
