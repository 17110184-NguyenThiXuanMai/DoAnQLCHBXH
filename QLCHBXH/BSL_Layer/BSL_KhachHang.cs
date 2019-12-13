using QLCHBXH.Data_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCHBXH.BSL_Layer
{
    public class BSL_KhachHang
    {
        DL_KhachHang khachhang;
        public BSL_KhachHang()
        {
            khachhang = new DL_KhachHang();
        }
        public List<KhachHang> LayKhachHang()
        {
            return khachhang.LayKhachHang();
        }
        public List<KhachHang> LayKhachHangTheoSDT(string sdt)
        {
            return khachhang.LayKhachHangTheoSDT(sdt);
        }
        public void ThemKhachHang(string hoTen, DateTime ngaySinh, string soCMND, string sdt, string diaChi)
        {
            KhachHang kh = new KhachHang();
            kh.HoTen = hoTen;
            kh.NgaySinh = ngaySinh;
            kh.SoCMND = soCMND;
            kh.SDT = sdt;
            kh.DiaChi = diaChi;
            khachhang.ThemKhachHang(kh);
        }
        public void CapNhatKhachHang(int maKH, string hoTen, DateTime ngaySinh, string soCMND, string sdt, string diaChi)
        {
            KhachHang kh = new KhachHang();
            kh.MaKH = maKH;
            kh.HoTen = hoTen;
            kh.NgaySinh = ngaySinh;
            kh.SoCMND = soCMND;
            kh.SDT = sdt;
            kh.DiaChi = diaChi;
            khachhang.CapNhatKhachHang(kh);
        }
        public void XoaKhachHang(int maKH)
        {
            khachhang.XoaKhachHang(maKH);
        }
    }
}
