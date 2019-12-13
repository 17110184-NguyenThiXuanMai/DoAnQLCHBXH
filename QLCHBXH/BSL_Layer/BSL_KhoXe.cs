using QLCHBXH.Data_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCHBXH.BSL_Layer
{
    class BSL_KhoXe
    {
        DL_KhoXe xe;
        public BSL_KhoXe()
        {
            xe = new DL_KhoXe();
        }
        public List<Xe> LayXe()
        {
            return xe.LayXe();
        }
        public void ThemXe(string maXe, string kieuXe, string tenXe, string hinhAnh, int soLuong, string mauXe, string loaiDongCo,
           int maLuc, int momenXoan, string tocDoToiDa, string suTangToc, DateTime ngayNhap, decimal giaXe, string maGiamGia)
        {
            Xe x = new Xe();
            x.MaXe = maXe;
            x.KieuXe = kieuXe;
            x.TenXe = tenXe;
            x.HinhAnh = hinhAnh;
            x.SoLuong = soLuong;
            x.Mau = mauXe;
            x.LoaiDongCo = loaiDongCo;
            x.MaLuc = maLuc;
            x.MomenXoan = momenXoan;
            x.TocDoToiDa = tocDoToiDa;
            x.SuTangToc = suTangToc;
            x.NgayNhap = ngayNhap;
            x.GiaXe = giaXe;
            x.MaGiamGia = maGiamGia;
            xe.ThemXe(x);
        }
        public void CapNhatXe(string maXe, string kieuXe, string tenXe, string hinhAnh, int soLuong, string mauXe, string loaiDongCo,
           int maLuc, int momenXoan, string tocDoToiDa, string suTangToc, DateTime ngayNhap, decimal giaXe, string maGiamGia)
        {
            Xe x = new Xe();
            x.MaXe = maXe;
            x.KieuXe = kieuXe;
            x.TenXe = tenXe;
            x.HinhAnh = hinhAnh;
            x.SoLuong = soLuong;
            x.Mau = mauXe;
            x.LoaiDongCo = loaiDongCo;
            x.MaLuc = maLuc;
            x.MomenXoan = momenXoan;
            x.TocDoToiDa = tocDoToiDa;
            x.SuTangToc = suTangToc;
            x.NgayNhap = ngayNhap;
            x.GiaXe = giaXe;
            x.MaGiamGia = maGiamGia;
            xe.CapNhatXe(x);
        }
        public List<Xe> LayMaXe(string manv)
        {
            string MaNV = manv + "%";
            return xe.LayMaXe(manv);
        }
        public void XoaXe(string maXe)
        {
            xe.XoaXe(maXe);
        }
        public void XoaXeTrongKho(string machiec)
        {
            xe.XoaXeTrongKho(machiec);
        }
        public List<KhoXe> LayKhoXe()
        {
            return xe.LayKhoXe();
        }
        public void ThemXeVaoKho(string machiec, string maxe, string tinhTrang)
        {
            KhoXe x = new KhoXe();
            x.MaChiec = machiec;
            x.MaXe = maxe;
            x.DaBan = tinhTrang;
            xe.ThemXeVaoKho(x);
        }
        public void CapNhatKhoXe(string machiec, string maxe)
        {
            KhoXe x = new KhoXe();
            x.MaChiec = machiec;
            x.MaXe = maxe;
            xe.CapNhatKhoXe(x);
        }
    }
}
