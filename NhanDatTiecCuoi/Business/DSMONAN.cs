using NhanDatTiecCuoi.Data;
using NhanDatTiecCuoi.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NhanDatTiecCuoi.Business
{
    public class DSMONAN : IDanhSach<MONAN>
    {
        private List<MONAN> _mONANs = new List<MONAN>();
        int ma = 4;
        private void TaoDuLieuBanDau()
        {
            List<MONAN> mONANs = new List<MONAN>()
            {
                new MONAN("1", "Gà hấp xả", 200000, "30 phút"),
                new MONAN("2", "Xôi gà", 140000, "Gà, hạt sen, nấm"),
                new MONAN("3", "Bò Bọc", 250000, "300gr"),
                new MONAN("4", "Bánh su cá hồi", 290000, "300gr")
            };
            _mONANs = mONANs;
        }
        public bool CapNhatThongTin(MONAN ds)
        {
            for(int i=0; i<_mONANs.Count; i++)
            {
                if (ds.MaMonAn == _mONANs[i].MaMonAn)
                {
                    _mONANs[i] = ds;
                    return true;
                }
            }
            return false;
        }

        public List<MONAN> LayDS()
        {
            if (_mONANs.Count == 0)
            {
                TaoDuLieuBanDau();
            }
            return _mONANs;
        }

        public int LayMaMoi()
        {
            return ma + 1;
        }

        public MONAN LayThongTinTheoMa(string ma)
        {
            MONAN mONAN1 = null;
            foreach (MONAN mONAN in _mONANs)
            {
                if (ma == mONAN.MaMonAn)
                {
                    mONAN1 = mONAN;
                    break;
                }
            }
            return mONAN1;
        }

        public void ThemMaMoi()
        {
            ma = ma + 1;
        }

        public bool ThemMoi(MONAN ds)
        {
            if (ds != null)
            {
                _mONANs.Add(ds);
                return true;
            }
            return false;
        }

        public bool Xoa(MONAN ds)
        {
            if (ds != null)
            {
                _mONANs.Remove(ds);
                return true;
            }
            return false;
        }
    }
}
