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
            List<DICHVU> dv = new List<DICHVU>()
            {
                new DICHVU("1","MC",500000,"all"),
                new DICHVU("2", "Vip1",2000000,"MC, ban nhạc, đội nhảy"),
                new DICHVU("3", "Vip2",10000000, "MC vip, ban nhạc, ca sĩ, đội múa")
            };
            dICHVUs = dv;
        }
        public bool CapNhatThongTin(DICHVU ds)
        {
            for(int i=0; i<dICHVUs.Count; i++)
            {
                if (ds.MaDichVu == dICHVUs[i].MaDichVu)
                {
                    dICHVUs[i] = ds;
                    return true;
                }
            }
            return false;
        }

        public List<DICHVU> LayDS()
        {
            if (dICHVUs.Count == 0)
            {
                TaoDuLieuBanDau();
            }
            return dICHVUs;
        }

        public int LayMaMoi()
        {
            return ma + 1;
        }

        public DICHVU LayThongTinTheoMa(string ma)
        {
            DICHVU dv = null;
            foreach(DICHVU d in dICHVUs)
            {
                if (ma == d.MaDichVu)
                {
                    dv = d;
                    break;
                }
            }
            return dv;
        }

        public void ThemMaMoi()
        {
            ma = ma + 1;
        }

        public bool ThemMoi(DICHVU ds)
        {
            if (ds != null)
            {
                dICHVUs.Add(ds);
                return true;
            }
            return false;
        }

        public bool Xoa(DICHVU ds)
        {
            if (ds != null)
            {
                dICHVUs.Remove(ds);
                return true;
            }
            return false;
        }
    }
}
