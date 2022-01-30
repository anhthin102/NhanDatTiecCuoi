using NhanDatTiecCuoi.Data;
using NhanDatTiecCuoi.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NhanDatTiecCuoi.Business
{
    public class DSSANH : IDanhSach<SANH>
    {
        private List<SANH> _sANHs = new List<SANH>();
        int ma = 2;
        private void TaoDuLieuBanDau()
        {
            List<SANH> sANHs = new List<SANH>()
            {
                new SANH("1", "Sảnh A", "1", 30, "Phía Bắc"),
                new SANH("2", "Sảnh B", "2", 40, "1"),
            };
            _sANHs = sANHs;
        }
        public bool CapNhatThongTin(SANH ds)
        {
            for(int i=0; i<_sANHs.Count; i++)
            {
                if (ds.MaSanh == _sANHs[i].MaSanh)
                {
                    _sANHs[i] = ds;
                    return true;
                }
            }
            return false;
        }

        public List<SANH> LayDS()
        {
            if (_sANHs.Count == 0)
            {
                TaoDuLieuBanDau();
            }
            return _sANHs;
        }

        public int LayMaMoi()
        {
            return ma + 1;
        }

        public SANH LayThongTinTheoMa(string ma)
        {
            SANH sANH = null;
            foreach(SANH s in _sANHs)
            {
                if (s.MaSanh == ma)
                {
                    sANH = s;
                    break;
                }
            }
            return sANH;
        }

        public void ThemMaMoi()
        {
            ma = ma + 1;
        }

        public bool ThemMoi(SANH ds)
        {
            if (ds != null)
            {
                _sANHs.Add(ds);
                return true;
            }
            return false;
        }

        public bool Xoa(SANH ds)
        {
            if (ds != null)
            {
                _sANHs.Remove(ds);
                return true;
            }
            return false;
        }
    }
}
