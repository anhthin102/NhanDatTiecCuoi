using NhanDatTiecCuoi.Data;
using NhanDatTiecCuoi.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NhanDatTiecCuoi.Business
{
    public class DSLOAISANH: IDanhSach<LOAISANH>
    {
        private List<LOAISANH> LOAISANHs = new List<LOAISANH>();
        private int ma = 2;
        public int LayMaMoi()
        {
            return ma + 1;
        }
        public void ThemMaMoi()
        {
            ma = ma + 1;
        }
        public List<LOAISANH> LayDS()
        {
            if (LOAISANHs.Count == 0)
            {
                TaoDuLieuBanDau();
            }
            return LOAISANHs;
        }
        private void TaoDuLieuBanDau()
        {
            List<LOAISANH> ls = new List<LOAISANH>() {
                new LOAISANH("1","Loại sảnh A", 1000000),
                new LOAISANH("2","Loại sảnh B", 1200000)
            };
            LOAISANHs = ls;
        }
        public bool ThemMoi(LOAISANH ls) {
            if (ls != null)
            {
                LOAISANHs.Add(ls);
                return true;
            }
            return false;
        }
        
        public bool CapNhatThongTin(LOAISANH ls)
        {
            for(int i=0; i<LOAISANHs.Count; i++)
            {
                if (ls.MaLoaiSanh == LOAISANHs[i].MaLoaiSanh)
                {
                    LOAISANHs[i] = ls;
                    return true;
                }
            }
            return false;
        }
        public bool Xoa(LOAISANH ls)
        {
            if (ls != null)
            {
                LOAISANHs.Remove(ls);
                return true;
            }
            return false;
        }

        public LOAISANH LayThongTinTheoMa(string ma)
        {
            LOAISANH ls = null;
            foreach (LOAISANH lOAISANH in LOAISANHs)
            {
                if (ma == lOAISANH.MaLoaiSanh)
                {
                    ls = lOAISANH;
                    break;
                }
            }
            return ls;
        }
    }
}
