using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCHBXH.Data_Layer
{
    class DL_KhoXe
    {
        private DbDataContext db;
        public DL_KhoXe()
        {
            db = new DbDataContext();
        }
        public List<Xe> LayXe()
        {
            List<Xe> listXe = new List<Xe>();
            var lstXe = db.spXe_SelectAll().ToList();
            foreach (var n in lstXe)
            {
                Xe e = new Xe()
                {
                    MaXe = n.MaXe,
                    KieuXe = n.KieuXe,
                    TenXe = n.TenXe,
                    HinhAnh = n.HinhAnh,
                    SoLuong = n.SoLuong,
                    Mau = n.Mau, 
                    LoaiDongCo = n.LoaiDongCo,
                    MaLuc = n.MaLuc,
                    MomenXoan = n.MomenXoan,
                    TocDoToiDa = n.TocDoToiDa,
                    SuTangToc = n.SuTangToc,
                    NgayNhap = n.NgayNhap,
                    GiaXe = n.GiaXe,
                    MaGiamGia = n.MaGiamGia
                };
                listXe.Add(e);
            }
            return listXe;
        }
        public void ThemXe(Xe xe)
        {
            db.spXe_Insert(xe.MaXe, xe.KieuXe, xe.TenXe, xe.HinhAnh, xe.SoLuong, xe.Mau, xe.LoaiDongCo, xe.MaLuc, xe.MomenXoan, xe.TocDoToiDa,
                xe.SuTangToc, xe.NgayNhap, xe.GiaXe, xe.MaGiamGia);
        }
        public void CapNhatXe(Xe xe)
        {
            if (xe.MaGiamGia == "") db.spXe_Update(xe.MaXe, xe.KieuXe, xe.TenXe, xe.HinhAnh, xe.SoLuong, xe.Mau, xe.LoaiDongCo, xe.MaLuc, xe.MomenXoan, xe.TocDoToiDa,
                 xe.SuTangToc, xe.NgayNhap, xe.GiaXe, null);
            else db.spXe_Update(xe.MaXe, xe.KieuXe, xe.TenXe, xe.HinhAnh, xe.SoLuong, xe.Mau, xe.LoaiDongCo, xe.MaLuc, xe.MomenXoan, xe.TocDoToiDa,
                xe.SuTangToc, xe.NgayNhap, xe.GiaXe, xe.MaGiamGia);
        }
        public List<Xe> LayMaXe(string manv)
        {
            List<Xe> listXe = new List<Xe>();
            var lstXe = db.spXe_SelectName(manv).ToList();
            foreach (var n in lstXe)
            {
                Xe xe = new Xe()
                {
                    MaXe = n.MaXe,
                    KieuXe = n.KieuXe,
                    TenXe = n.TenXe,
                    HinhAnh = n.HinhAnh,
                    SoLuong = n.SoLuong,
                    Mau = n.Mau,
                    LoaiDongCo = n.LoaiDongCo,
                    MaLuc = n.MaLuc,
                    MomenXoan = n.MomenXoan,
                    TocDoToiDa = n.TocDoToiDa,
                    SuTangToc = n.SuTangToc,
                    NgayNhap = n.NgayNhap,
                    GiaXe = n.GiaXe,
                    MaGiamGia = n.MaGiamGia
                };
                listXe.Add(xe);
            }
            return listXe;
        }
        public List<KhoXe> LayKhoXe()
        {
            List<KhoXe> listKhoXe = new List<KhoXe>();
            var lstKhoXe = db.spKhoXe_SelectAll().ToList();
            foreach (var n in lstKhoXe)
            {
                KhoXe e = new KhoXe()
                {
                    MaChiec = n.MaChiec,
                    MaXe = n.MaXe,
                    DaBan = n.DaBan
                };
                listKhoXe.Add(e);
            }
            return listKhoXe;
        }
        public void ThemXeVaoKho(KhoXe khoxe)
        {
            db.spKhoXe_Insert(khoxe.MaChiec, khoxe.MaXe, khoxe.DaBan);
        }
        public void XoaXe(string maXe)
        {
            db.spXe_Delete(maXe);
        }
        public void XoaXeTrongKho(string machiec)
        {
            db.spKhoXe_Delete(machiec);
        }
        public void CapNhatKhoXe(KhoXe khoxe)
        {
            db.spKhoXe_Update(khoxe.MaChiec, khoxe.MaXe);
        }
    }
}
