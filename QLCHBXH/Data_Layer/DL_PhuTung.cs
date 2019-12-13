using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCHBXH.Data_Layer
{
    public class DL_PhuTung
    {
        private DbDataContext db;
        public DL_PhuTung()
        {
            db = new DbDataContext();
        }
        public List<PhuTung> LayPhuTung()
        {
            List<PhuTung> listPhuTung = new List<PhuTung>();
            var lstPhuTung = db.spPhuTung_SelectAll().ToList();
            foreach(var n in lstPhuTung)
            {
                PhuTung p = new PhuTung()
                {
                    MaPhuTung = n.MaPhuTung,
                    LoaiPhuTung = n.LoaiPhuTung,
                    TenPhuTung = n.TenPhuTung,
                    SoLuong = n.SoLuong,
                    GiaPhuTung = n.GiaPhuTung
                };
                listPhuTung.Add(p);
            }
            return listPhuTung;
        } 
        public void ThemPhuTung(PhuTung p)
        {
            db.spPhuTung_Insert(p.MaPhuTung, p.LoaiPhuTung, p.TenPhuTung, p.SoLuong, p.GiaPhuTung);
        }
        public void CapNhatPhuTung(PhuTung p)
        {
            db.spPhuTung_Update(p.MaPhuTung, p.LoaiPhuTung, p.TenPhuTung, p.SoLuong, p.GiaPhuTung);
        }
        public void XoaPhuTung(string maPhuTung)
        {
            db.spPhuTung_Delete(maPhuTung);
        }
    }
}
