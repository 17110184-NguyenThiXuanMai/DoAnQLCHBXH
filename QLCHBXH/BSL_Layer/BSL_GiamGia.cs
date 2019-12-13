using QLCHBXH.Data_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCHBXH.BSL_Layer
{
    class BSL_GiamGia
    {
        DL_GiamGia gg;
        public BSL_GiamGia()
        {
            gg = new DL_GiamGia();
        }
        public List<GiamGia> LayGiamGia()
        {
            return gg.LayGiamGia();
        }
        public void ThemGiamGia(string magg, Decimal phantramgiam, DateTime ngaybatdau, DateTime ngayketthuc)
        {
            GiamGia ns = new GiamGia();
            ns.MaGiamGia = magg;
            ns.PhanTramGiam = phantramgiam;
            ns.NgayBatDau = ngaybatdau;
            ns.NgayKetThuc = ngayketthuc;
            gg.ThemGiamGia(ns);
        }
        public void SuaGiamGia(string magg, Decimal phantramgiam, DateTime ngaybatdau, DateTime ngayketthuc)
        {
            GiamGia ns = new GiamGia();
            ns.MaGiamGia = magg;
            ns.PhanTramGiam = phantramgiam;
            ns.NgayBatDau = ngaybatdau;
            ns.NgayKetThuc = ngayketthuc;
            gg.SuaGiamGia(ns);
        }
        public void XoaGiamGia(string magg)
        {
            gg.XoaGiamGia(magg);
        }
    }
}
