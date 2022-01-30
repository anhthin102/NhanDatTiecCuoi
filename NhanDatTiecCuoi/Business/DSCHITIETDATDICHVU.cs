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
            throw new NotImplementedException();
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

        public void ThemMaMoi()
        {
            throw new NotImplementedException();
        }

        public bool ThemMoi(CTDATDICHVU ds)
        {
            throw new NotImplementedException();
        }

        public bool Xoa(CTDATDICHVU ds)
        {
            throw new NotImplementedException();
        }
    }
}
