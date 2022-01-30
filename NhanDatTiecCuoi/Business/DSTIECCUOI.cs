using NhanDatTiecCuoi.Data;
using NhanDatTiecCuoi.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NhanDatTiecCuoi.Business
{
    public class DSTIECCUOI : IDanhSach<TIECCUOI>
    {
        private List<TIECCUOI> _tIECCUOIs = new List<TIECCUOI>();
        int ma = 3;
        private void TaoDuLieuBanDau()
        {
            List<TIECCUOI> tIECCUOIs = new List<TIECCUOI>()
            {

                new TIECCUOI("1", "Xuân", "Cúc", "09875745765", new DateTime(2022, 1, 29), new DateTime(2022,2, 28),1000000,20,1,480000,"3","1"),
                new TIECCUOI("2", "Trúc", "Mai", "09876987030", new DateTime(2022, 1, 29), new DateTime(2022,2,28),1000000,30,1,620000,"2","2"),
                new TIECCUOI("3", "Hồng", "Hương", "09876765908", new DateTime(2022, 1, 29), new DateTime(2022,2,27),1000000,30,2,700000,"2","2")
            };
            _tIECCUOIs = tIECCUOIs;
        }
        public bool CapNhatThongTin(TIECCUOI ds)
        {
            throw new NotImplementedException();
        }

        public List<TIECCUOI> LayDS()
        {
            if (_tIECCUOIs.Count == 0)
            {
                TaoDuLieuBanDau();
            }
            return _tIECCUOIs;
        }

        public int LayMaMoi()
        {
            return ma + 1;
        }

        public TIECCUOI LayThongTinTheoMa(string ma)
        {
            TIECCUOI tIECCUOI = null;
            foreach(TIECCUOI t in _tIECCUOIs)
            {
                if (ma == t.MaTiecCuoi)
                {
                    tIECCUOI = t;
                    break;
                }
            }
            return tIECCUOI;
        }

        public void ThemMaMoi()
        {
            ma = ma + 1;
        }

        public bool ThemMoi(TIECCUOI ds)
        {
            throw new NotImplementedException();
        }

        public bool Xoa(TIECCUOI ds)
        {
            throw new NotImplementedException();
        }
    }
}
