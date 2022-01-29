using NhanDatTiecCuoi.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NhanDatTiecCuoi.Business
{
    public class DSLOAISANH
    {
        private List<LOAISANH> LOAISANHs = new List<LOAISANH>();
        public List<LOAISANH> LayDSLoaiSanh()
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
        public bool ThemMoiLoaiSanh(LOAISANH ls) {
            if (ls != null)
            {
                LOAISANHs.Add(ls);
                return true;
            }
            return false;
        }
        public LOAISANH LayThongTinLoaiSanhTheoMa(string ma)
        {
            LOAISANH ls = null;
            foreach(LOAISANH lOAISANH in LOAISANHs)
            {
                if (ma == lOAISANH.MaLoaiSanh)
                {
                    ls = lOAISANH;
                    break;
                }
            }
            return ls;
        }
        public bool CapNhatThongTinLoaiSanh(LOAISANH ls)
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
        public bool XoaLoaiSanh(LOAISANH ls)
        {
            if (ls != null)
            {
                LOAISANHs.Remove(ls);
                return true;
            }
            return false;
        }
    }
}
