using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCHBXH.Data_Layer
{
    public class DL_Xe
    {
        private DbDataContext db;
        public DL_Xe()
        {
            db = new DbDataContext();
        }

        #region Xe
        public List<Xe> LayXe()
        {
            List<Xe> listXe = new List<Xe>();
            var lstXe = db.spXe_SelectAll().ToList();
            foreach(var n in lstXe)
            {
                Xe x = new Xe()
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
                listXe.Add(x);
            }
            return listXe;
        }
        //public void ThemXe(Xe xe)
        //{
        //    db.spXe_Insert(xe.MaXe, xe.KieuXe, xe.TenXe, xe.HinhAnh, xe.SoLuong, xe.Mau, xe.LoaiDongCo, xe.MaLuc, xe.MomenXoan, xe.TocDoToiDa,
        //        xe.SuTangToc, xe.NgayNhap, xe.GiaXe, xe.MaGiamGia);
        //}
        //public void XoaXe(string maXe)
        //{
        //    db.spXe_Delete(maXe);
        //}
        //public void CapNhatXe(Xe xe)
        //{
        //    if(xe.MaGiamGia == "") db.spXe_Update(xe.MaXe, xe.KieuXe, xe.TenXe, xe.HinhAnh, xe.SoLuong, xe.Mau, xe.LoaiDongCo, xe.MaLuc, xe.MomenXoan, xe.TocDoToiDa,
        //        xe.SuTangToc, xe.NgayNhap, xe.GiaXe, null);
        //    else db.spXe_Update(xe.MaXe, xe.KieuXe, xe.TenXe, xe.HinhAnh, xe.SoLuong, xe.Mau, xe.LoaiDongCo, xe.MaLuc, xe.MomenXoan, xe.TocDoToiDa,
        //        xe.SuTangToc, xe.NgayNhap, xe.GiaXe, xe.MaGiamGia);
        //}
        #endregion

        #region Bán hàng
        public List<ChiTietHopDong> LayChiTietHopDong()
        {
            List<ChiTietHopDong> listCTHD = new List<ChiTietHopDong>();
            var lstCTHD = db.spChiTietHD_SelectAll().ToList();
            foreach(var n in lstCTHD)
            {
                ChiTietHopDong cthd = new ChiTietHopDong()
                {
                    MaHD = n.MaHD,
                    MaChiec = n.MaChiec,
                    MaBH = n.MaBH,
                    ThoiHanBaoHiem = n.ThoiHanBaoHiem,
                    MaBaoTri = n.MaBaoTri
                };
                listCTHD.Add(cthd);
            }
            return listCTHD;
        }
        public void ThemChiTietHopDong(ChiTietHopDong cthd)
        {
            db.spChiTietHD_Insert(cthd.MaHD, cthd.MaChiec, cthd.MaBH, cthd.ThoiHanBaoHiem, cthd.MaBaoTri);
        }
        public List<HopDong> LayHopDong()
        {
            List<HopDong> listHD = new List<HopDong>();
            var lstHD = db.spHopDong_SelectAll().ToList();
            foreach(var n in lstHD)
            {
                HopDong hd = new HopDong()
                {
                    MaHD = n.MaHD,
                    MaKH = n.MaKH,
                    MaNV = n.MaNV,
                    TongGiaTien = n.TongGiaTien,
                    NgayLapHD = n.NgayLapHD,
                    NgayHetHan = n.NgayHetHan
                };
                listHD.Add(hd);
            }
            return listHD;
        }
        public void ThemHopDong (HopDong hd)
        {
            db.spHopDong_Insert(hd.MaHD, hd.MaKH, hd.MaNV, hd.TongGiaTien, hd.NgayLapHD, hd.NgayHetHan);
        }
        public string LayMaChiec(string maXe)
        {
            return db.fnLayMaChiec(maXe);
        }
        public decimal LayGiaTienXe(string maChiec)
        {
            return (decimal)db.fnLayGiaTienXe(maChiec);
        }
        public decimal LayGiaTienBaoHiem(string maBaoHiem)
        {
            return (decimal)db.fnLayGiaBaoHiem(maBaoHiem);
        }
        public string LayTenSanPham(string maChiec)
        {
            return db.fnLayTenSanPham(maChiec);
        }
        public string LayTenGoiBaoHiem(string maBaoHiem)
        {
            return db.fnLayTenGoiBaoHiem(maBaoHiem);
        }
        public string LayTenNhanVien(string maNV)
        {
            return db.fnLayTenNhanVien(maNV);
        }
        public List<vBaoHiem> LayMaBaoHiem()
        {
            List<vBaoHiem> listBH = new List<vBaoHiem>();
            var lstBH = db.vBaoHiems.ToList();
            foreach(var n in lstBH)
            {
                vBaoHiem bh = new vBaoHiem()
                {
                    MaBH = n.MaBH,
                    GoiBaoHiem = n.GoiBaoHiem
                };
                listBH.Add(bh);
            }
            return listBH;
        }
        public List<vNhanSu> LayMaNhanSu()
        {
            List<vNhanSu> listNV = new List<vNhanSu>();
            var lstNV = db.vNhanSus.ToList();
            foreach (var n in lstNV)
            {
                vNhanSu nv = new vNhanSu()
                {
                    MaNV = n.MaNV,
                    HoTen = n.HoTen
                };
                listNV.Add(nv);
            }
            return listNV;
        }
        public void ThemXeBaoTri (XeBaoTri xbt)
        {
            db.spXeBaoTri_Insert(xbt.MaBaoTri, xbt.MaChiec, xbt.MaKH);
        }
        public void ThemMaBaoTri(BaoTri bt)
        {
            db.spBaoTri_InsertID(bt.MaBaoTri);
        }
        public void CheckSoLuongXe(string maXe)
        {
            db.spXe_CheckSoLuong(maXe);
        }
        public string LayMaXe(string maChiec)
        {
            return db.fnLayMaXe(maChiec);
        }
        #endregion

        #region Bảo trì
        public List<BaoTri> LayBaoTri()
        {
            List<BaoTri> listBaoTri = new List<BaoTri>();
            var lstBaoTri = db.spBaoTri_SelectAll().ToList();
            foreach(var n in lstBaoTri)
            {
                BaoTri bt = new BaoTri()
                {
                    MaBaoTri = n.MaBaoTri,
                    DongCo = n.DongCo,
                    HeThongDanhLua = n.HeThongDanhLua,
                    GamVaThanXe = n.GamVaThanXe,
                    CapDo = n.CapDo,
                    ThoiGianHenLay = n.ThoiGianHenLay
                };
                listBaoTri.Add(bt);
            }
            return listBaoTri;
        }
        public List<XeBaoTri> LayXeBaoTri()
        {
            List<XeBaoTri> listXeBaoTri = new List<XeBaoTri>();
            var lstXeBaoTri = db.spXeBaoTri_SelectAll().ToList();
            foreach (var n in lstXeBaoTri)
            {
                XeBaoTri xbt = new XeBaoTri()
                {
                    MaBaoTri = n.MaBaoTri,
                    MaChiec = n.MaChiec,
                    MaKH = n.MaKH
                };
                listXeBaoTri.Add(xbt);
            }
            return listXeBaoTri;
        }
        public void CapNhatBaoTri(BaoTri bt)
        {
            db.spBaoTri_Update(bt.MaPhuTung, bt.MaBaoTri, bt.DongCo, bt.HeThongDanhLua, bt.GamVaThanXe, bt.CapDo, bt.ThoiGianHenLay);
        }
        public void XoaBaoTri(string maBaoTri)
        {
            db.spBaoTri_Delete(maBaoTri);
        }
        #endregion

        #region Hóa đơn
        public void ThemHoaDon(HoaDon hd)
        {
            db.spHoaDon_Insert(hd.MaHoaDon, hd.MaHD, hd.ThanhTien);
        }
        #endregion
    }
}
