using QLCHBXH.Data_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCHBXH.BSL_Layer
{
    class BSL_QuanLyNhanVien
    {
        DL_QuanLyNhanVien nv;
        public BSL_QuanLyNhanVien()
        {
            nv = new DL_QuanLyNhanVien();
        }

        #region Quản lý nhân viên
        public List<NhanSu> LayNhanVien()
        {
            return nv.LayNhanVien();
        }
        public void ThemNhanVien(string manv, string hoten, string hinhanh, string gioitinh, string chucvu,
                                  DateTime ngaysinh, string diachi, string sdt, Decimal luongnv)
        {
            NhanSu ns = new NhanSu();
            ns.MaNV = manv;
            ns.HoTen = hoten;
            ns.HinhAnh = hinhanh;
            ns.GioiTinh = gioitinh;
            ns.ChucVu = chucvu;
            ns.NgaySinh = ngaysinh;
            ns.DiaChi = diachi;
            ns.SDT = sdt;
            ns.Luong = luongnv;
            nv.ThemNhanVien(ns);
        }
        public void SuaNhanVien(string manv, string hoten, string hinhanh, string gioitinh, string chucvu,
                                  DateTime ngaysinh, string diachi, string sdt, Decimal luongnv)
        {
            NhanSu ns = new NhanSu();
            ns.MaNV = manv;
            ns.HoTen = hoten;
            ns.HinhAnh = hinhanh;
            ns.GioiTinh = gioitinh;
            ns.ChucVu = chucvu;
            ns.NgaySinh = ngaysinh;
            ns.DiaChi = diachi;
            ns.SDT = sdt;
            ns.Luong = luongnv;
            nv.SuaNhanVien(ns);
        }
        public void XoaNhanVien(string manv)
        {
            nv.XoaNhanVien(manv);
        }
        public List<NhanSu> LayTenNhanVien(string tennv)
        {
            string TenNV = tennv + "%test%";
            return nv.LayTenNhanVien(tennv);
        }
        public List<NhanSu> LayMaNhanVien(string manv)
        {
            return nv.LayMaNhanVien(manv);
        }    
        #endregion

        #region Lịch làm việc
        public List<PhanCong> LayLichLam()
        {
            return nv.LayLichLam();
        }
        public void ThemLichLam(string manv, DateTime ngaybatdaulam, DateTime ngayketthuc, string calam)
        {
            PhanCong pc = new PhanCong();
            pc.MaNV = manv;
            pc.NgayBatDauLam = ngaybatdaulam;
            pc.NgayKetThuc = ngayketthuc;
            pc.CaLam = calam;
            nv.ThemLichLam(pc);
        }
        public int ChonLichLam(string manv, DateTime ngaybatdaulam, DateTime ngayketthuc, string calam)
        {
            bool chon = nv.ChonLichLam(manv, ngaybatdaulam, ngayketthuc, calam);
            if (chon)
            {
                if (calam == "Ca 1") return 1;
                else if (calam == "Ca 2") return 2;
                else return 3;
            }
            return -1;
        }
        public void SuaLichLam(string manv, DateTime ngaybatdaulam, DateTime ngayketthuc, string calam)
        {
            PhanCong pc = new PhanCong();
            pc.MaNV = manv;
            pc.NgayBatDauLam = ngaybatdaulam;
            pc.NgayKetThuc = ngayketthuc;
            pc.CaLam = calam;
            nv.SuaLichLam(pc);
        }
        public void XoaLichLam(string manv, DateTime ngaybatdaulam, DateTime ngayketthuc)
        {
            nv.XoaLichLam(manv, ngaybatdaulam, ngayketthuc);
        }
        public List<PhanCong> LayMaNhanVienTrongLichLam(string manv)
        {
            return nv.LayMaNhanVienTrongLichLam(manv);
        }
        #endregion
    }
}
