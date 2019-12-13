using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCHBXH.Data_Layer
{
    public class DL_BaoHiem
    {
        private DbDataContext db;
        public DL_BaoHiem()
        {
            db = new DbDataContext();
        }
        public List<BaoHiem> LayBaoHiem()
        {
            List<BaoHiem> listBaoHiem = new List<BaoHiem>();
            var lstBaoHiem = db.spBaoHiem_SelectAll().ToList();
            foreach(var n in lstBaoHiem)
            {
                BaoHiem bh = new BaoHiem()
                {
                    MaBH = n.MaBH,
                    GoiBaoHiem = n.GoiBaoHiem,
                    GiaBaoHiem = n.GiaBaoHiem
                };
                listBaoHiem.Add(bh);
            }
            return listBaoHiem;
        }
        public void ThemBaoHiem(BaoHiem bh)
        {
            db.spBaoHiem_Insert(bh.MaBH, bh.GoiBaoHiem, bh.GiaBaoHiem);
        }
        public void CapNhatBaoHiem(BaoHiem bh)
        {
            db.spBaoHiem_Update(bh.MaBH, bh.GoiBaoHiem, bh.GiaBaoHiem);
        }
        public void XoaBaoHiem(string maBH)
        {
            db.spBaoHiem_Delete(maBH);
        }
    }
}
