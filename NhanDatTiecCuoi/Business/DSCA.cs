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
        private List<CA> Cas = new List<CA>();
        private int ma = 3;
        private void TaoDuLieuBanDau()
        {
            List<CA> ca = new List<CA>() {
                new CA("1","Sang1_9h"),
                new CA("2","Trua1_11h"),
                new CA("3","Trua2_12h")
            };
            Cas = ca;
        }
        public bool CapNhatThongTin(CA ds)
        {
            for(int i=0; i<Cas.Count; i++)
            {
                if (ds.MaCa == Cas[i].MaCa)
                {
                    Cas[i] = ds;
                    return true;
                }
            }
            return false;
        }

        public List<CA> LayDS()
        {
            if (Cas.Count == 0)
            {
                TaoDuLieuBanDau();
            }
            return Cas;
        }

        
        public CA LayThongTinTheoMa(string ma)
        {
            CA ca = null;
            foreach(CA c in Cas)
            {
                if (ma == c.MaCa)
                {
                    ca = c;
                    break;
                }
            }
            return ca;
        }

       

        public bool ThemMoi(CA ds)
        {
            if (ds != null)
            {
                Cas.Add(ds);
                return true;
            }
            return false;
        }

        public bool Xoa(CA ds)
        {
            if (ds != null)
            {
                Cas.Remove(ds);
                return true;
            }
            return false;
        }

        public int LayMaMoi()
        {
            return ma + 1;
        }

        public void ThemMaMoi()
        {
            ma = ma + 1;
        }
    }
}
