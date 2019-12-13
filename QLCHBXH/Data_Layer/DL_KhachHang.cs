using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCHBXH.Data_Layer
{
    public class DL_KhachHang
    {
        private DbDataContext db;
        public DL_KhachHang()
        {
            db = new DbDataContext();
        }
        public List<KhachHang> LayKhachHang()
        {
            List<KhachHang> listKH = new List<KhachHang>();
            var lstKH = db.spKhachHang_SelectAll().ToList();
            foreach(var n in lstKH)
            {
                KhachHang kh = new KhachHang()
                {
                    MaKH = n.MaKH,
                    HoTen = n.HoTen,
                    NgaySinh = n.NgaySinh,
                    SoCMND = n.SoCMND,
                    SDT = n.SDT,
                    DiaChi = n.DiaChi
                };
                listKH.Add(kh);
            }
            return listKH;
        }
        public List<KhachHang> LayKhachHangTheoSDT(string sdt)
        {
            List<KhachHang> listKHSDT = new List<KhachHang>();
            var lstKH = db.spKhachHang_SelectPhone(sdt).ToList();
            foreach (var n in lstKH)
            {
                KhachHang kh = new KhachHang()
                {
                    MaKH = n.MaKH,
                    HoTen = n.HoTen,
                    NgaySinh = n.NgaySinh,
                    SoCMND = n.SoCMND,
                    SDT = n.SDT,
                    DiaChi = n.DiaChi
                };
                listKHSDT.Add(kh);
            }
            return listKHSDT;
        }
        public void ThemKhachHang(KhachHang kh)
        {
            db.spKhachHang_Insert(kh.HoTen, kh.NgaySinh, kh.SoCMND, kh.SDT, kh.DiaChi);
        }
        public void CapNhatKhachHang(KhachHang kh)
        {
            db.spKhachHang_Update(kh.MaKH, kh.HoTen, kh.NgaySinh, kh.SoCMND, kh.SDT, kh.DiaChi);
        }
        public void XoaKhachHang(int maKH)
        {
            db.spKhachHang_Delete(maKH);
        }
    }
}
