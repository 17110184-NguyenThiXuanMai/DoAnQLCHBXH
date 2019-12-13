using QLCHBXH.Data_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCHBXH.BSL_Layer
{
    public class BSL_Xe
    {
        DL_Xe xe;
        public BSL_Xe()
        {
            xe = new DL_Xe();
        }

        #region Xe
        //public List<Xe> LayXe()
        //{
        //    return xe.LayXe();
        //}
        //public void ThemXe(string maXe, string kieuXe, string tenXe, string hinhAnh, int soLuong, string mauXe, string loaiDongCo,
        //    int maLuc, int momenXoan, string tocDoToiDa, string suTangToc, DateTime ngayNhap, decimal giaXe, string maGiamGia)
        //{
        //    Xe x = new Xe();
        //    x.MaXe = maXe;
        //    x.KieuXe = kieuXe;
        //    x.TenXe = tenXe;
        //    x.HinhAnh = hinhAnh;
        //    x.SoLuong = soLuong;
        //    x.Mau = mauXe;
        //    x.LoaiDongCo = loaiDongCo;
        //    x.MaLuc = maLuc;
        //    x.MomenXoan = momenXoan;
        //    x.TocDoToiDa = tocDoToiDa;
        //    x.SuTangToc = suTangToc;
        //    x.NgayNhap = ngayNhap;
        //    x.GiaXe = giaXe;
        //    x.MaGiamGia = maGiamGia;
        //    xe.ThemXe(x);
        //}
        //public void XoaXe(string maXe)
        //{
        //    xe.XoaXe(maXe);
        //}
        //public void CapNhatXe(string maXe, string kieuXe, string tenXe, string hinhAnh, int soLuong, string mauXe, string loaiDongCo,
        //    int maLuc, int momenXoan, string tocDoToiDa, string suTangToc, DateTime ngayNhap, decimal giaXe, string maGiamGia)
        //{
        //    Xe x = new Xe();
        //    x.MaXe = maXe;
        //    x.KieuXe = kieuXe;
        //    x.TenXe = tenXe;
        //    x.HinhAnh = hinhAnh;
        //    x.SoLuong = soLuong;
        //    x.Mau = mauXe;
        //    x.LoaiDongCo = loaiDongCo;
        //    x.MaLuc = maLuc;
        //    x.MomenXoan = momenXoan;
        //    x.TocDoToiDa = tocDoToiDa;
        //    x.SuTangToc = suTangToc;
        //    x.NgayNhap = ngayNhap;
        //    x.GiaXe = giaXe;
        //    x.MaGiamGia = maGiamGia;
        //    xe.CapNhatXe(x);
        //}
        #endregion

        #region Bán hàng
        public List<ChiTietHopDong> LayChiTietHopDong()
        {
            return xe.LayChiTietHopDong();
        }
        public void ThemChiTietHopDong(string maHD, string maChiec, string maBH, string thoiHan, string maBaoTri)
        {
            ChiTietHopDong cthd = new ChiTietHopDong();
            cthd.MaHD = maHD;
            cthd.MaChiec = maChiec;
            cthd.MaBH = maBH;
            cthd.ThoiHanBaoHiem = thoiHan;
            cthd.MaBaoTri = maBaoTri;
            xe.ThemChiTietHopDong(cthd);
        }
        public List<HopDong> LayHopDong()
        {
            return xe.LayHopDong();
        }
        public void ThemHopDong(string maHD, int maKH, string maNV, decimal tongTien, DateTime ngayLap, DateTime ngayHet)
        {
            HopDong hd = new HopDong();
            hd.MaHD = maHD;
            hd.MaKH = maKH;
            hd.MaNV = maNV;
            hd.TongGiaTien = tongTien;
            hd.NgayLapHD = ngayLap;
            hd.NgayHetHan = ngayHet;
            xe.ThemHopDong(hd);
        }
        public string LayMaChiec(string maXe)
        {
            return xe.LayMaChiec(maXe);
        }
        public decimal LayGiaTienXe(string maChiec)
        {
            return xe.LayGiaTienXe(maChiec);
        }
        public decimal LayGiaTienBaoHiem(string maBaoHiem)
        {
            return xe.LayGiaTienBaoHiem(maBaoHiem);
        }
        public string LayTenSanPham(string maChiec)
        {
            return xe.LayTenSanPham(maChiec);
        }
        public string LayTenGoiBaoHiem(string maBaoHiem)
        {
            return xe.LayTenGoiBaoHiem(maBaoHiem);
        }
        public string LayTenNhanVien(string maNV)
        {
            return xe.LayTenNhanVien(maNV);
        }
        public List<vBaoHiem> LayMaBaoHiem()
        {
            return xe.LayMaBaoHiem();
        }
        public List<vNhanSu> LayMaNhanSu()
        {
            return xe.LayMaNhanSu();
        }
        public void ThemXeBaoTri(string maBaoTri, string maChiec, int maKH)
        {
            XeBaoTri xbt = new XeBaoTri();
            xbt.MaBaoTri = maBaoTri;
            xbt.MaChiec = maChiec;
            xbt.MaKH = maKH;
            xe.ThemXeBaoTri(xbt);
        }
        public void ThemMaBaoTri(string maBaoTri)
        {
            BaoTri bt = new BaoTri();
            bt.MaBaoTri = maBaoTri;
            xe.ThemMaBaoTri(bt);
        }
        public void CheckSoLuongXe(string maXe)
        {
            xe.CheckSoLuongXe(maXe);
        }
        public string LayMaXe(string maChiec)
        {
            return xe.LayMaXe(maChiec);
        }
        #endregion

        #region Bảo trì
        public List<BaoTri> LayBaoTri()
        {
            return xe.LayBaoTri();
        }
        public List<XeBaoTri> LayXeBaoTri()
        {
            return xe.LayXeBaoTri();
        }
        public void CapNhatBaoTri(string maBaoTri, string maPhutung, string dongCo, string heThongDanhLua, string gamVaThanXe, int CapDo, DateTime thoiGianHenLay)
        {
            BaoTri bt = new BaoTri();
            bt.MaBaoTri = maBaoTri;
            bt.MaPhuTung = maPhutung;
            bt.DongCo = dongCo;
            bt.HeThongDanhLua = heThongDanhLua;
            bt.GamVaThanXe = gamVaThanXe;
            bt.CapDo = CapDo;
            bt.ThoiGianHenLay = thoiGianHenLay;
            xe.CapNhatBaoTri(bt);
        }
        public void XoaBaoTri(string maBaoTri)
        {
            xe.XoaBaoTri(maBaoTri);
        }
        #endregion

        #region Hóa đơn
        public void ThemHoaDon(string maHoaDon, string maHopDong, decimal thanhTien)
        {
            HoaDon hd = new HoaDon();
            hd.MaHoaDon = maHoaDon;
            hd.MaHD = maHopDong;
            hd.ThanhTien = thanhTien;
            xe.ThemHoaDon(hd);
        }
        #endregion
    }
}
