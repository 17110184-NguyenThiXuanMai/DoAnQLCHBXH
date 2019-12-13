using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCHBXH.Data_Layer
{
    class DL_GiamGia
    {
        private DbDataContext db;
        public DL_GiamGia()
        {
            db = new DbDataContext();
        }
        public List<GiamGia> LayGiamGia()
        {
            List<GiamGia> listgg = new List<GiamGia>();
            var lstgg = db.spGiamGia_SelectAll().ToList();
            foreach (var n in lstgg)
            {
                GiamGia e = new GiamGia()
                {
                    MaGiamGia = n.MaGiamGia,
                    PhanTramGiam = n.PhanTramGiam,
                    NgayBatDau = n.NgayBatDau,
                    NgayKetThuc = n.NgayKetThuc
                };
                listgg.Add(e);
            }
            return listgg;
        }
        public void ThemGiamGia(GiamGia gg)
        {
            db.spGiamGia_Insert(gg.MaGiamGia, gg.PhanTramGiam, gg.NgayBatDau, gg.NgayKetThuc);
        }
        public void SuaGiamGia(GiamGia gg)
        {
            db.spGiamGia_Update(gg.MaGiamGia, gg.PhanTramGiam, gg.NgayBatDau, gg.NgayKetThuc);
        }
        public void XoaGiamGia(string magg)
        {
            db.spGiamGia_Delete(magg);
        }
    }
}
