using QLCHBXH.Data_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCHBXH.BSL_Layer
{
    public class BSL_PhuTung
    {
        DL_PhuTung phutung;
        public BSL_PhuTung()
        {
            phutung = new DL_PhuTung();
        }
        public List<PhuTung> LayPhuTung()
        {
            return phutung.LayPhuTung();
        }
        public void ThemPhuTung(string maPhuTung, string loaiPhuTung, string tenPhuTung, int soLuong, decimal giaPhuTung)
        {
            PhuTung p = new PhuTung();
            p.MaPhuTung = maPhuTung;
            p.LoaiPhuTung = loaiPhuTung;
            p.TenPhuTung = tenPhuTung;
            p.SoLuong = soLuong;
            p.GiaPhuTung = giaPhuTung;
            phutung.ThemPhuTung(p);
        }
        public void CapNhatPhuTung(string maPhuTung, string loaiPhuTung, string tenPhuTung, int soLuong, decimal giaPhuTung)
        {
            PhuTung p = new PhuTung();
            p.MaPhuTung = maPhuTung;
            p.LoaiPhuTung = loaiPhuTung;
            p.TenPhuTung = tenPhuTung;
            p.SoLuong = soLuong;
            p.GiaPhuTung = giaPhuTung;
            phutung.CapNhatPhuTung(p);
        }
        public void XoaPhuTung(string maPhuTung)
        {
            phutung.XoaPhuTung(maPhuTung);
        }
    }
}
