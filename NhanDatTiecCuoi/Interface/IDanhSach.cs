using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NhanDatTiecCuoi.Interface
{
   public interface IDanhSach<T>
    {
        int LayMaMoi();
        void ThemMaMoi();
        List<T> LayDS();
        bool ThemMoi(T ds);
        T LayThongTinTheoMa(string ma);
        bool CapNhatThongTin(T ds);
        bool Xoa(T ds);

    }
}
