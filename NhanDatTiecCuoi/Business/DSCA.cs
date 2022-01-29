using NhanDatTiecCuoi.Data;
using NhanDatTiecCuoi.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NhanDatTiecCuoi.Business
{
    public class DSCA : IDanhSach<CA>
    {
        private List<CA> cAs = new List<CA>();
        int ma = 3;
        private void TaoDuLieuBanDau()
        {

        }
        public bool CapNhatThongTin(CA ds)
        {
            throw new NotImplementedException();
        }

        public List<CA> LayDS()
        {
            throw new NotImplementedException();
        }

        public int LayMaMoi()
        {
            throw new NotImplementedException();
        }

        public CA LayThongTinTheoMa(string ma)
        {
            throw new NotImplementedException();
        }

        public void ThemMaMoi()
        {
            throw new NotImplementedException();
        }

        public bool ThemMoi(CA ds)
        {
            throw new NotImplementedException();
        }

        public bool Xoa(CA ds)
        {
            throw new NotImplementedException();
        }
    }
}
