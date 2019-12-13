using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCHBXH.Data_Layer
{
    public class DL_QuanLyNhanVien
    {
        private DbDataContext db;
        public DL_QuanLyNhanVien()
        {
            db = new DbDataContext();
        }

        #region Quản lý nhân viên
        public List<NhanSu> LayNhanVien()
        {
            List<NhanSu> listemp = new List<NhanSu>();
            var lstemp = db.spNhanSu_SelectAll().ToList();
            foreach (var n in lstemp)
            {
                NhanSu e = new NhanSu() 
                { 
                    MaNV = n.MaNV, 
                    HoTen = n.HoTen,
                    HinhAnh=n.HinhAnh,
                    GioiTinh= n.GioiTinh, 
                    ChucVu = n.ChucVu, 
                    NgaySinh = n.NgaySinh, 
                    DiaChi = n.DiaChi, 
                    SDT = n.SDT, 
                    Luong = n.Luong
                };
                listemp.Add(e);
            }
            return listemp;
        }
        public void ThemNhanVien(NhanSu ns)
        {
            db.spNhanSu_Insert(ns.MaNV, ns.HoTen, ns.HinhAnh, ns.GioiTinh, ns.ChucVu, ns.NgaySinh, ns.DiaChi, ns.SDT, ns.Luong);
        }
        public void SuaNhanVien(NhanSu ns)
        {
            db.spNhanSu_Update(ns.MaNV, ns.HoTen, ns.HinhAnh, ns.GioiTinh, ns.ChucVu, ns.NgaySinh, ns.DiaChi, ns.SDT, ns.Luong);
        }
        public void XoaNhanVien(string manv)
        {
            db.spNhanSu_Delete(manv);
        }
        public List<NhanSu> LayTenNhanVien(string tennv)
        {
            List<NhanSu> listns = new List<NhanSu>();
            var lstns = db.spNhanSu_SelectName(tennv).ToList();
            foreach(var n in lstns)
            {
                NhanSu ns = new NhanSu()
                {
                    MaNV = n.MaNV,
                    HoTen = n.HoTen,
                    HinhAnh = n.HinhAnh,
                    GioiTinh = n.GioiTinh,
                    ChucVu = n.ChucVu,
                    NgaySinh = n.NgaySinh,
                    DiaChi = n.DiaChi,
                    SDT = n.SDT,
                    Luong = n.Luong
                };
                listns.Add(ns);
            }
            return listns;
        }
        public List<NhanSu> LayMaNhanVien(string manv)
        {
            List<NhanSu> listns = new List<NhanSu>();
            var lstns = db.spNhanSu_SelectID(manv).ToList();
            foreach (var n in lstns)
            {
                NhanSu ns = new NhanSu()
                {
                    MaNV = n.MaNV,
                    HoTen = n.HoTen,
                    HinhAnh = n.HinhAnh,
                    GioiTinh = n.GioiTinh,
                    ChucVu = n.ChucVu,
                    NgaySinh = n.NgaySinh,
                    DiaChi = n.DiaChi,
                    SDT = n.SDT,
                    Luong = n.Luong
                };
                listns.Add(ns);
            }
            return listns;
        }     
        #endregion

        #region Lịch làm việc
        public List<PhanCong> LayLichLam()
        {
            List<PhanCong> listpc = new List<PhanCong>();
            var lstpc = db.spPhanCong_SelectAll().ToList();
            foreach(var n in lstpc)
            {
                PhanCong pc = new PhanCong()
                {
                    MaNV = n.MaNV,
                    NgayBatDauLam = n.NgayBatDauLam,
                    NgayKetThuc = n.NgayKetThuc,
                    CaLam = n.CaLam
                };
                listpc.Add(pc);
            }
            return listpc;
        }
        public bool ChonLichLam(string manv,DateTime ngaybatdau, DateTime ngayketthuc, string calam)
        {
            var iqur = db.spPhanCong_SelectShift(manv, ngaybatdau, ngayketthuc, calam).SingleOrDefault();
            if (iqur != null) return true;
            return false;
        }
        public void ThemLichLam(PhanCong pc)
        {
            db.spPhanCong_Insert(pc.MaNV, pc.NgayBatDauLam, pc.NgayKetThuc, pc.CaLam);
        }
        public void SuaLichLam(PhanCong pc)
        {
            db.spPhanCong_Update(pc.MaNV, pc.NgayBatDauLam, pc.NgayKetThuc, pc.CaLam);
        }
        public void XoaLichLam(string manv, DateTime ngaybatdau, DateTime ngayketthuc)
        {
            db.spPhanCong_Delete(manv, ngaybatdau, ngayketthuc);
        }
        public List<PhanCong> LayMaNhanVienTrongLichLam(string manv)
        {
            List<PhanCong> listpc = new List<PhanCong>();
            var lstpc = db.spPhanCong_SelectID(manv).ToList();
            foreach (var n in lstpc)
            {
                PhanCong ns = new PhanCong()
                {
                   MaNV = n.MaNV,
                   NgayBatDauLam = n.NgayBatDauLam,
                   NgayKetThuc = n.NgayKetThuc,
                   CaLam = n.CaLam
                };
                listpc.Add(ns);
            }
            return listpc;
        }
        #endregion
    }
}

