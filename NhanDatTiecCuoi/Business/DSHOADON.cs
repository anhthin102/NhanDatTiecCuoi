using NhanDatTiecCuoi.Data;
using NhanDatTiecCuoi.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NhanDatTiecCuoi.Business
{
    public class DSHOADON : IDanhSach<HOADON>
    {
        private List<HOADON> _hOADONs = new List<HOADON>();
        public bool CapNhatThongTin(HOADON ds)
        {
            for(int i=0; i < _hOADONs.Count; i++)
            {
                if (ds.MaHoaDon == _hOADONs[i].MaHoaDon)
                {
                    _hOADONs[i] = ds;
                    return true;
                }
            }
            return false;
        }

        public List<HOADON> LayDS()
        {
            return _hOADONs;
        }

        public int LayMaMoi()
        {
            throw new NotImplementedException();
        }

        public HOADON LayThongTinTheoMa(string ma)
        {
            HOADON hOADON = null;
            foreach(HOADON h in _hOADONs)
            {
                if (ma == h.MaHoaDon)
                {
                    hOADON = h;
                    break;
                }
            }
            return hOADON;
        }
        public List<HOADON> LayDanhSachTheoThoiGian(int thang, int nam)
        {
            List<HOADON> hOADONs = new List<HOADON>();
            foreach (HOADON h in _hOADONs)
            {
                if (thang == h.NgayThanhToan.Month && nam == h.NgayThanhToan.Year)
                {
                    hOADONs.Add(h);
                }
            }
            return hOADONs;
        }
        public void ThemMaMoi()
        {
            throw new NotImplementedException();
        }

        public bool ThemMoi(HOADON ds)
        {
            if (ds != null)
            {
                _hOADONs.Add(ds);
                return true;
            }
            return false;
        }

        public bool Xoa(HOADON ds)
        {
            if (ds != null)
            {
                _hOADONs.Remove(ds);
                return true;
            }
            return false;
        }
    }
}
