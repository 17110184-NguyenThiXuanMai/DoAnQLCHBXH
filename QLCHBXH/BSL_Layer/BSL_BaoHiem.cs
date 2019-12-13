using QLCHBXH.Data_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCHBXH.BSL_Layer
{
    public class BSL_BaoHiem
    {
        DL_BaoHiem baohiem;
        public BSL_BaoHiem()
        {
            baohiem = new DL_BaoHiem();
        }
        public List<BaoHiem> LayBaoHiem()
        {
            return baohiem.LayBaoHiem();
        }
        public void ThemBaoHiem(string maBH, string goiBH, decimal giaBH)
        {
            BaoHiem bh = new BaoHiem();
            bh.MaBH = maBH;
            bh.GoiBaoHiem = goiBH;
            bh.GiaBaoHiem = giaBH;
            baohiem.ThemBaoHiem(bh);
        }
        public void CapNhatBaoHiem(string maBH, string goiBH, decimal giaBH)
        {
            BaoHiem bh = new BaoHiem();
            bh.MaBH = maBH;
            bh.GoiBaoHiem = goiBH;
            bh.GiaBaoHiem = giaBH;
            baohiem.CapNhatBaoHiem(bh);
        }
        public void XoaBaoHiem(string maBH)
        {
            baohiem.XoaBaoHiem(maBH);
        }
    }
}
