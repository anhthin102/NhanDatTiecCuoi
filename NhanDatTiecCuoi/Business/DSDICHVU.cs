using NhanDatTiecCuoi.Data;
using NhanDatTiecCuoi.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NhanDatTiecCuoi.Business
{
    public class DSDICHVU : IDanhSach<DICHVU>
    {
        private List<DICHVU> dICHVUs = new List<DICHVU>();
        int ma = 3;
        private void TaoDuLieuBanDau()
        {

        }
        public bool CapNhatThongTin(DICHVU ds)
        {
            throw new NotImplementedException();
        }

        public List<DICHVU> LayDS()
        {
            throw new NotImplementedException();
        }

        public int LayMaMoi()
        {
            throw new NotImplementedException();
        }

        public DICHVU LayThongTinTheoMa(string ma)
        {
            throw new NotImplementedException();
        }

        public void ThemMaMoi()
        {
            throw new NotImplementedException();
        }

        public bool ThemMoi(DICHVU ds)
        {
            throw new NotImplementedException();
        }

        public bool Xoa(DICHVU ds)
        {
            throw new NotImplementedException();
        }
    }
}
