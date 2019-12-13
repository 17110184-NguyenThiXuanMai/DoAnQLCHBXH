------------------------------TẠO "ShowroomAudi" DATABASE------------------------------
USE master;
--Nếu có tên database trong máy chủ, xóa nó
IF DB_ID(N'ShowroomAudi') IS NOT NULL DROP DATABASE ShowroomAudi; 
--Nếu database đó không được tạo do đang có kết nối, hủy nó
IF @@ERROR = 3702 
	RAISERROR(N'Database cannot be dropped because there are still open connections.', 127, 127) WITH NOWAIT, LOG;


------------------------------TẠO DATABASE------------------------------
CREATE DATABASE ShowroomAudi;
GO

USE ShowroomAudi;
GO


------------------------------TẠO SCHEMAS------------------------------
CREATE SCHEMA Employee AUTHORIZATION dbo;
GO
CREATE SCHEMA Production AUTHORIZATION dbo;
GO
CREATE SCHEMA Sales AUTHORIZATION dbo;
GO

------------------------------TẠO TABLE------------------------------
/*----------Table Nhân sự----------*/
CREATE TABLE Employee.NhanSu
(
	MaNV		nvarchar(10)	not null PRIMARY KEY,
	HoTen		nvarchar(60)	not null,
	HinhAnh		nvarchar(100)	null,
	GioiTinh	nvarchar(4)		not null,
	ChucVu		nvarchar(20)	not null,
	NgaySinh	date			not null,
	DiaChi		nvarchar(60)	not null,
	SDT			nvarchar(10)	not null,
	Luong		money			not null,
);
GO
/*----------Table Phân công----------*/
CREATE TABLE Employee.PhanCong
(
	MaNV				nvarchar(10)	not null,
	NgayBatDauLam		datetime		not null,
	NgayKetThuc			datetime		not null,
	CaLam				nvarchar(10)	not null,
	CONSTRAINT PK_PhanCong PRIMARY KEY(MaNV, NgayBatDauLam, NgayKetThuc)
);
GO
/*----------Table Đăng nhập----------*/
CREATE TABLE Employee.DangNhap
(
	UserName	nvarchar(10)	unique not null,
	Pass		nvarchar(20)	not null,
	ChucVu		nvarchar(20)	not null,
);
GO
/*----------Table Xe----------*/
CREATE TABLE Production.Xe
(
	MaXe			nvarchar(10)	not null PRIMARY KEY,
	KieuXe			nvarchar(60)	not null,
	TenXe			nvarchar(60)	not null,
	HinhAnh			nvarchar(100)	null,
	SoLuong			int				not null,
	Mau				nvarchar(20)	not null,
	LoaiDongCo		nvarchar(60)	not null,
	MaLuc			int				not null,
	MomenXoan		int				not null,
	TocDoToiDa		nvarchar(60)	not null,
	SuTangToc		nvarchar(20)	not null,
	NgayNhap		date			not null,
	GiaXe			money			not null,
	MaGiamGia		nvarchar(10)	null,
);
GO
/*----------Table Kho xe----------*/
CREATE TABLE Production.KhoXe
(
	MaChiec		nvarchar(10)	not null PRIMARY KEY,
	MaXe		nvarchar(10)	not null,
	DaBan		nvarchar(10)	null,
);
GO
/*----------Table Phụ tùng----------*/
CREATE TABLE Production.PhuTung
(
	MaPhuTung		nvarchar(10)	not null PRIMARY KEY,
	LoaiPhuTung		nvarchar(100)	not null,
	TenPhuTung		nvarchar(100)	not null,
	SoLuong			int				not null,
	GiaPhuTung		money			not null,
);
GO
/*----------Table Khách hàng----------*/
CREATE TABLE Sales.KhachHang
(
	MaKH		int IDENTITY	not null PRIMARY KEY,
	HoTen		nvarchar(60)	not null,
	NgaySinh	date			not null,
	SoCMND		nvarchar(12)	not null,
	SDT			nvarchar(10)	not null,
	DiaChi		nvarchar(60)	not null,
);
GO
/*----------Table Bảo hiểm----------*/
CREATE TABLE Sales.BaoHiem
(
	MaBH				nvarchar(10)	not null PRIMARY KEY,
	GoiBaoHiem			nvarchar(60)	not null,
	GiaBaoHiem			money			not null,
);
GO
/*----------Table Hợp đồng----------*/
CREATE TABLE Sales.HopDong
(
	MaHD		nvarchar(10)	not null PRIMARY KEY,
	MaKH		int				not null,
	MaNV		nvarchar(10)	not null,
	TongGiaTien	money			not null,
	NgayLapHD	date			not null,
	NgayHetHan  date			null,
);
GO
/*----------Table Chi tiết hợp đồng----------*/
CREATE TABLE Sales.ChiTietHopDong
(
	MaHD			nvarchar(10)	not null,
	MaChiec			nvarchar(10)	not null,
	MaBH			nvarchar(10)	not null,
	ThoiHanBaoHiem	nvarchar(10)	not null,
	MaBaoTri		nvarchar(10)	null,
	CONSTRAINT PK_ChiTietHopDong PRIMARY KEY(MaHD, MaChiec, MaBH),
);
GO
/*----------Table Giảm giá----------*/
CREATE TABLE Sales.GiamGia
(
	MaGiamGia		nvarchar(10)	not null PRIMARY KEY,
	PhanTramGiam	decimal			not null,
	NgayBatDau		date			not null,
	NgayKetThuc		date			not null,
);
GO
/*----------Table Hóa đơn----------*/
CREATE TABLE Sales.HoaDon
(
	MaHoaDon	nvarchar(10)	not null PRIMARY KEY,
	MaHD		nvarchar(10)	not null,
	ThanhTien	money			not null,
);
GO
/*----------Table Bảo trì----------*/
CREATE TABLE Sales.BaoTri
(
	MaBaoTri			nvarchar(10)	not null PRIMARY KEY,
	MaPhuTung			nvarchar(10)	null,
	DongCo				nvarchar(5)		null,
	HeThongDanhLua		nvarchar(5)		null,
	GamVaThanXe			nvarchar(5)		null,
	CapDo				int				null,
	ThoiGianHenLay		date			null,
);
GO
/*----------Table Xe bảo trì----------*/
CREATE TABLE Sales.XeBaoTri
(
	MaBaoTri	nvarchar(10)	unique not null,
	MaChiec		nvarchar(10)	not null,
	MaKH		int				not null,
);
GO

SET NOCOUNT ON; --Không hiện message (X row(s) affected) khi execute
GO

------------------------------CHÈN DỮ LIỆU------------------------------
/*----------Chèn dữ liệu vào bảng Employee.NhanSu----------*/
INSERT INTO Employee.NhanSu VALUES(17110184, N'Nguyễn Thị Xuân Mai', null, N'Nữ', N'Quản lý', '19990623', N'30B Đường Số 3 Quận Thủ Đức', N'0817882173', 50000000);
INSERT INTO Employee.NhanSu VALUES(17110124, N'Nguyễn Thể Đoàn', null, N'Nam', N'Nhân viên bán hàng', '19990529', N'15A Đường Đặng Văn Bi Quận Thủ Đức', N'0813424859', 30000000);
INSERT INTO Employee.NhanSu VALUES(17110214, N'Tôn Nữ Như Quỳnh', null, N'Nữ', N'Nhân viên bán hàng', '19990612', N'60A Lý Chính Thắng Quận Quận 3', N'0167463871', 30000000);
INSERT INTO Employee.NhanSu VALUES(17110134, N'Võ Nguyễn Minh Hiền', null, N'Nữ', N'Lễ tân', '19990524', N'325 Đường Trường Chinh Quận 12', N'0261739428', 20000000);
INSERT INTO Employee.NhanSu VALUES(17110160, N'Lâm Gia Khánh', null, N'Nam', N'Cố vấn dịch vụ', '19991227', N'16D Đường Nguyễn Thị Huỳnh Quận Phú Nhuận', N'0856681237', 25000000);
INSERT INTO Employee.NhanSu VALUES(17110164, N'Nguyễn Hữu Huân', null, N'Nam', N'Kỹ thuật viên', '19990319', N'67 Đường Linh Trung Quận Thủ Đức', N'0283119248', 50000000);
INSERT INTO Employee.NhanSu VALUES(17110105, N'Trần Bình Cơ', null, N'Nam', N'Kỹ thuật viên', '19990716', N'35 Đường Đặng Văn Bi Quận Thủ Đức', N'0340389422', 50000000);
INSERT INTO Employee.NhanSu VALUES(17110227, N'Nguyễn Thái Phương Thảo', null, N'Nữ', N'Kế toán', '19990810', N'168 Đường Đặng Văn Bi Quận Thủ Đức', N'0374297781', 15000000);
INSERT INTO Employee.NhanSu VALUES(17110114, N'Nguyễn Văn Khoa', null, N'Nam', N'Quản lý kho', '19990101', N'45A Đường Số 8 Quận Thủ Đức', N'0814482349', 20000000);
INSERT INTO Employee.NhanSu VALUES(17110189, N'Đoàn Hữu Hùng', null, N'Nam', N'Bảo vệ', '19990201', N'78C Đường Số 6 Quận Thủ Đức', N'0167038459', 10000000);

/*----------Chèn dữ liệu vào bảng Employee.PhanCong----------*/
INSERT INTO Employee.PhanCong VALUES(17110124, '20191013', '20191020', N'Ca 1');
INSERT INTO Employee.PhanCong VALUES(17110214, '20191013', '20191020', N'Ca 2');
INSERT INTO Employee.PhanCong VALUES(17110134, '20191013', '20191020', N'Full');
INSERT INTO Employee.PhanCong VALUES(17110160, '20191013', '20191020', N'Full');
INSERT INTO Employee.PhanCong VALUES(17110164, '20191013', '20191020', N'Ca 1');
INSERT INTO Employee.PhanCong VALUES(17110105, '20191013', '20191020', N'Ca 2');
INSERT INTO Employee.PhanCong VALUES(17110227, '20191013', '20191020', N'Full');
INSERT INTO Employee.PhanCong VALUES(17110114, '20191013', '20191020', N'Full');
INSERT INTO Employee.PhanCong VALUES(17110189, '20191013', '20191020', N'Full');

/*----------Chèn dữ liệu vào bảng Employee.DangNhap----------*/
INSERT INTO Employee.DangNhap VALUES(17110184, N'QL1234', N'Quản lý');
INSERT INTO Employee.DangNhap VALUES(17110124, N'NV1234', N'Nhân viên bán hàng');
INSERT INTO Employee.DangNhap VALUES(17110214, N'NV1234', N'Nhân viên bán hàng');
INSERT INTO Employee.DangNhap VALUES(17110134, N'NV1234', N'Lễ tân');
INSERT INTO Employee.DangNhap VALUES(17110160, N'NV1234', N'Cố vấn dịch vụ');
INSERT INTO Employee.DangNhap VALUES(17110164, N'NV1234', N'Kỹ thuật viên');
INSERT INTO Employee.DangNhap VALUES(17110105, N'NV1234', N'Kỹ thuật viên');
INSERT INTO Employee.DangNhap VALUES(17110227, N'NV1234', N'Kế toán');
INSERT INTO Employee.DangNhap VALUES(17110114, N'NV1234', N'Quản lý kho');

/*----------Chèn dữ liệu vào bảng Production.Xe----------*/
INSERT INTO Production.Xe VALUES(N'SSA3B', N'Sedans & Sportbacks', N'A3 Sedan', null, 2, N'Black', N'2.0-liter four-cylinder', 184, 222, N'130 mph8', N'6.6 seconds', '20180501', 772720405, null);
INSERT INTO Production.Xe VALUES(N'SSA4B', N'Sedans & Sportbacks', N'A4', null, 2, N'Black', N'2.0-liter four-cylinder', 188, 236, N'130 mph6', N'7.1 seconds', '20180502', 909628825, null);
INSERT INTO Production.Xe VALUES(N'SSRS5B', N'Sedans & Sportbacks', N'RS 5 Sportback', null, 2, N'Black', N'2.9-liter six-cylinder', 444, 443, N'155 mph/Optional 174 mph8', N'3.8 seconds', '20180503', 1721797420, null);
INSERT INTO Production.Xe VALUES(N'SSA8B', N'Sedans & Sportbacks', N'A8', null, 2, N'Black', N'3.0-liter six-cylinder', 335, 369, N'130 mph15', N'5.6 seconds', '20180504', 1944563663, null);
INSERT INTO Production.Xe VALUES(N'SWA4B', N'SUVs & Wagons', N'A4 allroad', null, 2, N'Black', N'2.0-liter four-cylinder', 248, 273, N'130 mph8', N'5.9 seconds', '20180505', 1060460136, null);
INSERT INTO Production.Xe VALUES(N'SWSQ5B', N'SUVs & Wagons', N'SQ5', null, 2, N'Black', N'3.0-liter six-cylinder', 349, 369, N'155 mph2', N'5.1 seconds', '20180506', 1215932410, null);
INSERT INTO Production.Xe VALUES(N'SWQ7B', N'SUVs & Wagons', N'Q7', null, 2, N'Black', N'3.0-liter six-cylinder', 329, 325, N'130 mph2', N'5.7 seconds', '20180507', 1215932410, null);
INSERT INTO Production.Xe VALUES(N'CCA3B', N'Coupes & Convertibles', N'A3 Cabriolet', null, 2, N'Black', N'2.0-liter four-cylinder', 184, 221, N'130 mph2', N'6.9 seconds', '20180508', 902667380, null);
INSERT INTO Production.Xe VALUES(N'CCTTSB', N'Coupes & Convertibles', N'TTS Coupe', null, 2, N'Black', N'2.0-liter four-cylinder', 288, 280, N'155 mph6', N'4.4 seconds', '20180509', 1248419153, null);

/*----------Chèn dữ liệu vào bảng Production.KhoXe----------*/
INSERT INTO Production.KhoXe VALUES(N'SSA3B1', N'SSA3B', null);
INSERT INTO Production.KhoXe VALUES(N'SSA3B2', N'SSA3B', null);
INSERT INTO Production.KhoXe VALUES(N'SSA4B1', N'SSA4B', null);
INSERT INTO Production.KhoXe VALUES(N'SSA4B2', N'SSA4B', null);
INSERT INTO Production.KhoXe VALUES(N'SSRS5B1', N'SSRS5B', null);
INSERT INTO Production.KhoXe VALUES(N'SSRS5B2', N'SSRS5B', null);

/*----------Chèn dữ liệu vào bảng Production.PhuTung----------*/
INSERT INTO Production.PhuTung VALUES(N'BN', N'Hệ thống làm mát, nhiên liệu', N'Bơm nước', 5, 2000000);
INSERT INTO Production.PhuTung VALUES(N'MB', N'Hệ thống động cơ, hộp số', N'Mô bin', 10, 5000000);
INSERT INTO Production.PhuTung VALUES(N'CX', N'Hệ thống gầm, phanh', N'Càng', 3, 500000);
INSERT INTO Production.PhuTung VALUES(N'CB', N'Hệ thống điện, điều hòa', N'Cảm biến', 6, 3000000);

/*----------Chèn dữ liệu vào bảng Sales.BaoHiem----------*/
INSERT INTO Sales.BaoHiem VALUES(N'PBH', N'Phí bảo hiểm', 5000000);
INSERT INTO Sales.BaoHiem VALUES(N'PBTDB', N'Phí bảo trì đường bộ',30000000);
INSERT INTO Sales.BaoHiem VALUES(N'BHXH', N'Bảo hiểm xe hơi',50000000);
INSERT INTO Sales.BaoHiem VALUES(N'BHTNDS', N'Bảo hiểm trách nhiệm dân sự',30000000);


------------------------------FOREIGN KEY------------------------------
USE ShowroomAudi;
ALTER TABLE Employee.PhanCong ADD CONSTRAINT FK_PhanCong_NhanVien FOREIGN KEY(MaNV) REFERENCES Employee.NhanSu(MaNV);

ALTER TABLE Employee.DangNhap ADD CONSTRAINT FK_DangNhap_NhanSu FOREIGN KEY(UserName) REFERENCES Employee.NhanSu(MaNV);

ALTER TABLE Production.Xe ADD CONSTRAINT FK_Xe_GiamGia FOREIGN KEY(MaGiamGia) REFERENCES Sales.GiamGia(MaGiamGia);

ALTER TABLE Production.KhoXe ADD CONSTRAINT FK_KhoXe_Xe FOREIGN KEY(MaXe) REFERENCES Production.Xe(MaXe);

ALTER TABLE Sales.HopDong ADD CONSTRAINT FK_HopDong_KhachHang FOREIGN KEY(MaKH) REFERENCES Sales.KhachHang(MaKH);
ALTER TABLE Sales.HopDong ADD CONSTRAINT FK_HopDong_NhanSu FOREIGN KEY(MaNV) REFERENCES Employee.NhanSu(MaNV);

ALTER TABLE Sales.ChiTietHopDong ADD CONSTRAINT FK_ChiTietHopDong_HopDong FOREIGN KEY(MaHD) REFERENCES Sales.HopDong(MaHD);
ALTER TABLE Sales.ChiTietHopDong ADD CONSTRAINT FK_ChiTietHopDong_KhoXe FOREIGN KEY(MaChiec) REFERENCES Production.KhoXe(MaChiec);
ALTER TABLE Sales.ChiTietHopDong ADD CONSTRAINT FK_ChiTietHopDong_BaoHiem FOREIGN KEY(MaBH) REFERENCES Sales.BaoHiem(MaBH);
ALTER TABLE Sales.ChiTietHopDong ADD CONSTRAINT FK_ChiTietHopDong_BaoTri FOREIGN KEY(MaBaoTri) REFERENCES Sales.BaoTri(MaBaoTri);

ALTER TABLE Sales.HoaDon ADD CONSTRAINT FK_HoaDon_HopDong FOREIGN KEY(MaHD) REFERENCES Sales.HopDong(MaHD);

ALTER TABLE Sales.BaoTri ADD CONSTRAINT FK_BaoTri_PhuTung FOREIGN KEY(MaPhuTung) REFERENCES Production.PhuTung(MaPhuTung);

ALTER TABLE Sales.XeBaoTri ADD CONSTRAINT FK_XeBaoTri_BaoTri FOREIGN KEY(MaBaoTri) REFERENCES Sales.BaoTri(MaBaoTri);
ALTER TABLE Sales.XeBaoTri ADD CONSTRAINT FK_XeBaoTri_KhachHang FOREIGN KEY(MaKH) REFERENCES Sales.KhachHang(MaKH);
GO


------------------------------STORE PROCEDURE------------------------------
/*----------Lấy chức vụ----------*/
CREATE PROC spLogin
	@username NVARCHAR(10),
	@pass NVARCHAR (20)
AS
	SELECT ChucVu
	FROM Employee.DangNhap
	WHERE UserName = @username and Pass = @pass;
GO

/*----------Lấy danh sách nhân viên----------*/
CREATE PROC spNhanSu_SelectAll
AS
	SELECT * FROM Employee.NhanSu
GO

/*----------Lấy danh sách nhân viên theo ID----------*/
CREATE PROC spNhanSu_SelectID
	@manv nvarchar(10)
AS
	SELECT * FROM Employee.NhanSu WHERE MaNV = @manv;
GO

/*----------Lấy danh sách nhân sự theo tên----------*/
CREATE PROC spNhanSu_SelectName
	@tennv nvarchar(60)
AS
	SELECT * FROM Employee.NhanSu WHERE HoTen LIKE @tennv + N'%';
GO

/*----------Thêm nhân viên---------*/
CREATE PROC spNhanSu_Insert
	@manv nvarchar(10),
	@hoten nvarchar(60),
	@hinhanh nvarchar(100),
	@gioitinh nvarchar(4),
	@chucvu nvarchar(20),
	@ngaysinh date,
	@diachi nvarchar(60),
	@sdt nvarchar(10),
	@luong money
AS
	INSERT INTO Employee.NhanSu(MaNV, HoTen, HinhAnh, GioiTinh, ChucVu, NgaySinh, DiaChi, SDT, Luong)
	VALUES (@manv, @hoten, @hinhanh, @gioitinh, @chucvu, @ngaysinh, @diachi, @sdt, @luong);
GO

/*----------Xóa nhân viên đã nghỉ làm----------*/
CREATE PROC spNhanSu_Delete
	@manv nvarchar(10)
AS
	DELETE Employee.NhanSu WHERE MaNV = @manv;
GO

/*----------Sửa thông tin nhân viên----------*/
CREATE PROC spNhanSu_Update
	@manv nvarchar(10),
	@hoten nvarchar(60),
	@hinhanh nvarchar(100),
	@gioitinh nvarchar(4),
	@chucvu nvarchar(20),
	@ngaysinh date,
	@diachi nvarchar(60),
	@sdt nvarchar(10),
	@luong money
AS
	UPDATE Employee.NhanSu SET HoTen = @hoten, HinhAnh = @hinhanh, GioiTinh = @gioitinh, ChucVu = @chucvu, NgaySinh = @ngaysinh, DiaChi = @diachi,
		SDT = @sdt, Luong = @luong
	WHERE MaNV = @manv;
GO

/*----------Lấy lịch làm việc---------*/
CREATE PROC spPhanCong_SelectAll
AS
	SELECT * FROM Employee.PhanCong
GO

/*----------Lấy lịch làm theo ID---------*/
CREATE PROC spPhanCong_SelectID
	@manv nvarchar(10)
AS
	SELECT * FROM Employee.PhanCong WHERE MaNV = @manv;
GO

/*----------Chọn lịch làm việc theo ca---------*/
CREATE PROC spPhanCong_SelectShift
	@manv nvarchar(10),
	@ngaybatdaulam datetime,
	@ngayketthuc datetime,
	@calam nvarchar(10)
AS
	SELECT * FROM Employee.PhanCong WHERE MaNV = @manv AND NgayBatDauLam = @ngaybatdaulam AND NgayKetThuc = @ngayketthuc AND CaLam = @calam;
GO

/*----------Thêm lịch làm việc---------*/
CREATE PROC spPhanCong_Insert
	@manv nvarchar(10),
	@ngaybatdaulam datetime,
	@ngayketthuc datetime,
	@calam nvarchar(10)
AS
	INSERT INTO Employee.PhanCong(MaNV, NgayBatDauLam, NgayKetThuc, CaLam)
	VALUES(@manv, @ngaybatdaulam, @ngayketthuc, @calam);
GO

/*----------Sửa lịch làm việc---------*/
CREATE PROC spPhanCong_Update
	@manv nvarchar(10),
	@ngaybatdaulam datetime,
	@ngayketthuc datetime,
	@calam nvarchar(10)
AS
	UPDATE Employee.PhanCong SET MaNV = @manv, NgayBatDauLam = @ngaybatdaulam, NgayKetThuc = @ngayketthuc, CaLam = @calam
	WHERE MaNV = @manv;
GO

/*----------Xóa lịch làm việc---------*/
CREATE PROC spPhanCong_Delete
	@manv nvarchar(10),
	@ngaybatdaulam datetime,
	@ngayketthuc datetime
AS
	DELETE Employee.PhanCong WHERE MaNV = @manv AND NgayBatDauLam = @ngaybatdaulam AND NgayKetThuc = @ngayketthuc;
GO

/*----------Lấy Username---------*/
CREATE PROC spLogin_SelectUser
	@username NVARCHAR(10)
AS
	SELECT * FROM Employee.DangNhap WHERE UserName = @username;
GO

/*----------Sửa Pass---------*/
CREATE PROC spLogin_Update
	@username NVARCHAR(10),
	@pass NVARCHAR (20)
AS
	UPDATE Employee.DangNhap SET Pass = @pass WHERE UserName = @username;
GO

/*----------Thêm tài khoản đăng nhập---------*/
CREATE PROC spLogin_Insert
	@username nvarchar(10),
	@pass nvarchar(20),
	@chucvu nvarchar(20)
AS
	INSERT INTO Employee.DangNhap(UserName, Pass, ChucVu)
	VALUES (@username, @pass, @chucvu);
GO

/*----------In danh sách xe----------*/
CREATE PROC spXe_SelectAll
AS
	SELECT * FROM Production.Xe
GO

/*----------In danh sách xe theo ID----------*/
CREATE PROC spXe_SelectID
	@maxe nvarchar(10)
AS
	SELECT * FROM Production.Xe WHERE MaXe = @maxe;
GO

/*----------In danh sách xe theo tên----------*/
CREATE PROC spXe_SelectName
	@tenxe nvarchar(60)
AS
	SELECT * FROM Production.Xe WHERE TenXe LIKE @tenxe + N'%';
GO

/*----------Thêm xe----------*/
CREATE PROC spXe_Insert
	@maxe nvarchar(10),
	@kieuxe nvarchar(60),
	@tenxe nvarchar(60),
	@hinhanh nvarchar(100),
	@soluong int,
	@mau nvarchar(20),
	@loaidongco nvarchar(60),
	@maluc int,
	@momenxoan int,
	@tocdotoida nvarchar(60),
	@sutangtoc nvarchar(20),
	@ngaynhap date,
	@giaxe money,
	@magiamgia nvarchar(10)
AS
	INSERT INTO Production.Xe(MaXe, KieuXe, TenXe, HinhAnh, SoLuong, Mau, LoaiDongCo, MaLuc, MomenXoan, TocDoToiDa, SuTangToc, NgayNhap, GiaXe, MaGiamGia)
		VALUES(@maxe, @kieuxe, @tenxe, @hinhanh, @soluong, @mau, @loaidongco, @maluc, @momenxoan, @tocdotoida, @sutangtoc, @ngaynhap, @giaxe, @magiamgia);
GO

/*----------Xóa xe----------*/
CREATE PROC spXe_Delete
	@maxe nvarchar(10)
AS
	DELETE Production.Xe WHERE MaXe = @maxe;
GO

/*----------Sửa thông tin xe----------*/
CREATE PROC spXe_Update
	@maxe nvarchar(10),
	@kieuxe nvarchar(60),
	@tenxe nvarchar(60),
	@hinhanh nvarchar(100),
	@soluong int,
	@mau nvarchar(20),
	@loaidongco nvarchar(60),
	@maluc int,
	@momenxoan int,
	@tocdotoida nvarchar(60),
	@sutangtoc nvarchar(20),
	@ngaynhap date,
	@giaxe money,
	@magiamgia nvarchar(10)
AS
	UPDATE Production.Xe SET KieuXe = @kieuxe, TenXe = @kieuxe, HinhAnh = @hinhanh, SoLuong = @soluong, Mau = @mau, LoaiDongCo = @loaidongco,
						MaLuc = @maluc, MomenXoan = @momenxoan, TocDoToiDa = @tocdotoida, SuTangToc = @sutangtoc, NgayNhap = @ngaynhap, GiaXe = @giaxe, MaGiamGia = @magiamgia
	WHERE MaXe = @maxe;
GO

/*----------Lấy kho xe----------*/
CREATE PROC spKhoXe_SelectAll
AS
	SELECT * FROM Production.KhoXe
GO

/*----------Thêm xe vào kho----------*/
CREATE PROC spKhoXe_Insert
	@machiec nvarchar(10),
	@maxe nvarchar(10)
AS
	INSERT INTO Production.KhoXe(MaChiec, MaXe) VALUES(@machiec, @maxe);
GO

/*----------Xóa xe trong kho----------*/
CREATE PROC spKhoXe_Delete
	@machiec nvarchar(10)
AS
	DELETE Production.KhoXe WHERE MaChiec = @machiec;
GO

/*----------Sửa xe trong kho----------*/
CREATE PROC spKhoXe_Update
	@machiec nvarchar(10),
	@maxe nvarchar(10)
AS
	UPDATE Production.KhoXe SET MaChiec = @machiec, MaXe = @maxe WHERE MaChiec = @machiec;
GO

/*----------Lấy hóa đơn----------*/
CREATE PROC spHoaDon_SelectAll
AS
	SELECT * FROM Sales.HoaDon
GO

/*----------Lấy thông tin giảm giá----------*/
CREATE PROC spGiamGia_SelectAll
AS
	SELECT * FROM Sales.GiamGia
GO

/*----------Thêm thông tin giảm giá----------*/
CREATE PROC spGiamGia_Insert
	@magg nvarchar(10),
	@phantramgiam decimal,
	@ngaybatdau date,
	@ngayketthuc date
AS
	INSERT INTO Sales.GiamGia(MaGiamGia, PhanTramGiam, NgayBatDau, NgayKetThuc)
	VALUES(@magg, @phantramgiam, @ngaybatdau, @ngayketthuc);
GO

/*----------Xóa thông tin giảm giá----------*/
CREATE PROC spGiamGia_Delete
	@magg nvarchar(10)
AS 
	DELETE Sales.GiamGia WHERE MaGiamGia = @magg;
GO

/*----------Sửa thông tin giảm giá----------*/
CREATE PROC spGiamGia_Update
	@magg nvarchar(10),
	@phantramgiam decimal,
	@ngaybatdau date,
	@ngayketthuc date
AS
	UPDATE Sales.GiamGia SET MaGiamGia = @magg, PhanTramGiam = @phantramgiam, NgayBatDau = @ngaybatdau, NgayKetThuc = @ngayketthuc
	WHERE MaGiamGia = @magg;
GO

/*----------Lấy danh sách phụ tùng----------*/
CREATE PROC spPhuTung_SelectAll
AS
	SELECT * FROM Production.PhuTung
GO

/*----------Thêm phụ tùng----------*/
CREATE PROC spPhuTung_Insert
	@maphutung nvarchar(10),
	@loaiphutung nvarchar(100),
	@tenphutung nvarchar(100),
	@soluong int,
	@giaphutung money
AS
	INSERT INTO Production.PhuTung(MaPhuTung, LoaiPhuTung, TenPhuTung, SoLuong, GiaPhuTung)
		VALUES(@maphutung, @loaiphutung, @tenphutung, @soluong, @giaphutung);
GO

/*----------Sửa thông tin phụ tùng----------*/
CREATE PROC spPhuTung_Update
	@maphutung nvarchar(10),
	@loaiphutung nvarchar(100),
	@tenphutung nvarchar(100),
	@soluong int,
	@giaphutung money
AS
	UPDATE Production.PhuTung SET LoaiPhuTung = @loaiphutung, TenPhuTung = @tenphutung, SoLuong = @soluong, GiaPhuTung = @giaphutung
	WHERE MaPhuTung = @maphutung;
GO

/*----------Xóa phụ tùng----------*/
CREATE PROC spPhuTung_Delete
	@maphutung nvarchar(10)
AS
	DELETE Production.PhuTung WHERE MaPhuTung = @maphutung;
GO

/*----------Lấy danh sách khách hàng----------*/
CREATE PROC spKhachHang_SelectAll
AS
	SELECT * FROM Sales.KhachHang
GO

/*----------Lấy danh sách khách hàng theo SDT----------*/
CREATE PROC spKhachHang_SelectPhone
	@sdt nvarchar(10)
AS
	SELECT * FROM Sales.KhachHang WHERE SDT = @sdt;
GO

/*----------Thêm khách hàng----------*/
CREATE PROC spKhachHang_Insert
	@tenkhachhang nvarchar(60),
	@ngaysinh date,
	@socmnd nvarchar(12),
	@sdt nvarchar(10),
	@diachi nvarchar(60)
AS
	INSERT INTO Sales.KhachHang(HoTen, NgaySinh, SoCMND, SDT, DiaChi)
		VALUES(@tenkhachhang, @ngaysinh, @socmnd, @sdt, @diachi);
GO

/*----------Sửa thông tin khách hàng----------*/
CREATE PROC spKhachHang_Update
	@makhachhang int,
	@tenkhachhang nvarchar(60),
	@ngaysinh date,
	@socmnd nvarchar(12),
	@sdt nvarchar(10),
	@diachi nvarchar(60)
AS
	UPDATE Sales.KhachHang SET HoTen = @tenkhachhang, NgaySinh = @ngaysinh, SoCMND = @socmnd, SDT = @sdt, DiaChi = @diachi
	WHERE MaKH = @makhachhang;
GO

/*----------Xóa thông tin khách hàng----------*/
CREATE PROC spKhachHang_Delete
	@makhachhang int
AS
	DELETE Sales.KhachHang WHERE MaKH = @makhachhang;
GO

/*----------Lấy hợp đồng----------*/
CREATE PROC spHopDong_SelectAll
AS
	SELECT * FROM Sales.HopDong
GO

/*----------Thêm hợp đồng----------*/
CREATE PROC spHopDong_Insert
	@mahopdong nvarchar(10),
	@makhachhang int,
	@manhanvien nvarchar(10),
	@tonggiatien money,
	@ngaylaphd date,
	@ngayhethan date
AS
	INSERT INTO Sales.HopDong(MaHD, MaKH, MaNV, TongGiaTien, NgayLapHD, NgayHetHan)
		VALUES(@mahopdong, @makhachhang, @manhanvien, @tonggiatien, @ngaylaphd, @ngayhethan);
GO

/*----------Lấy chi tiết hợp đồng----------*/
CREATE PROC spChiTietHD_SelectAll
AS
	SELECT * FROM Sales.ChiTietHopDong
GO

/*----------Thêm chi tiết hợp đồng----------*/
CREATE PROC spChiTietHD_Insert
	@mahopdong nvarchar(10),
	@machiec nvarchar(10),
	@mabaohiem nvarchar(10),
	@thoihanbaohiem nvarchar(10),
	@mabaotri nvarchar(10)
AS
	INSERT INTO Sales.ChiTietHopDong(MaHD, MaChiec, MaBH, ThoiHanBaoHiem, MaBaoTri)
		VALUES(@mahopdong, @machiec, @mabaohiem, @thoihanbaohiem, @mabaotri);
GO

/*----------Lấy danh sách bảo hiểm----------*/
CREATE PROC spBaoHiem_SelectAll
AS
	SELECT * FROM Sales.BaoHiem
GO

/*----------Thêm bảo hiểm----------*/
CREATE PROC spBaoHiem_Insert
	@mabaohiem nvarchar(10),
	@goibaohiem nvarchar(60),
	@giabaohiem money
AS
	INSERT INTO Sales.BaoHiem(MaBH, GoiBaoHiem, GiaBaoHiem) VALUES(@mabaohiem, @goibaohiem, @giabaohiem);
GO

/*----------Sửa thông tin bảo hiểm----------*/
CREATE PROC spBaoHiem_Update
	@mabaohiem nvarchar(10),
	@goibaohiem nvarchar(60),
	@giabaohiem money
AS
	UPDATE Sales.BaoHiem SET GoiBaoHiem = @goibaohiem, GiaBaoHiem = @giabaohiem
	WHERE MaBH = @mabaohiem;
GO

/*----------Xóa bảo hiểm----------*/
CREATE PROC spBaoHiem_Delete
	@mabaohiem nvarchar(10)
AS
	DELETE Sales.BaoHiem WHERE MaBH = @mabaohiem;
GO

/*----------Lấy xe bảo trì----------*/
CREATE PROC spXeBaoTri_SelectAll
AS
	SELECT * FROM Sales.XeBaoTri
GO

/*----------Thêm xe bảo trì----------*/
CREATE PROC spXeBaoTri_Insert
	@mabaotri nvarchar(10),
	@machiec nvarchar(10),
	@makhachhang int
AS
	INSERT INTO Sales.XeBaoTri(MaBaoTri, MaChiec, MaKH) VALUES(@mabaotri, @machiec, @makhachhang);
GO

/*----------Lấy danh sách bảo trì----------*/
CREATE PROC spBaoTri_SelectAll
AS
	SELECT * FROM Sales.BaoTri
GO

/*----------Thêm mã bảo trì----------*/
CREATE PROC spBaoTri_InsertID
	@mabaotri nvarchar(10)
AS
	INSERT INTO Sales.BaoTri(MaBaoTri) VALUES(@mabaotri);
GO

/*----------Cập nhật mã bảo trì----------*/
CREATE PROC spBaoTri_Update
	@mabaotri nvarchar(10),
	@maphutung nvarchar(10),
	@dongco nvarchar(5),
	@hethongdanhlua nvarchar(5),
	@gamvathanxe nvarchar(5),
	@capdo int,
	@thoigianhenlay date
AS
	UPDATE Sales.BaoTri SET MaPhuTung = @maphutung, DongCo = @dongco, HeThongDanhLua = @hethongdanhlua, GamVaThanXe = @gamvathanxe, CapDo = @capdo, ThoiGianHenLay = @thoigianhenlay
	WHERE MaBaoTri = @mabaotri;
GO

/*----------Xóa bảo trì----------*/
CREATE PROC spBaoTri_Delete
	@mabaotri nvarchar(10)
AS
	DELETE Sales.BaoTri WHERE MaBaoTri = @mabaotri;
GO

/*----------Xóa mã bảo trì----------*/
CREATE TRIGGER tgXoaBaoTri ON Sales.BaoTri INSTEAD OF DELETE
AS
	DECLARE @mabaotri nvarchar(10);
	SELECT @mabaotri = MaBaoTri FROM deleted;
	DELETE Sales.XeBaoTri WHERE MaBaoTri = @mabaotri;
	DELETE Sales.BaoTri WHERE MaBaoTri = @mabaotri;
GO

/*----------Thêm hóa đơn----------*/
CREATE PROC spHoaDon_Insert
	@mahoadon nvarchar(10),
	@mahopdong nvarchar(10),
	@thanhtien money
AS
	INSERT INTO Sales.HoaDon(MaHoaDon, MaHD, ThanhTien)
		VALUES(@mahoadon, @mahopdong, @thanhtien);
GO
	


------------------------------BÁN HÀNG------------------------------
/*----------Lấy mã chiếc----------*/
CREATE FUNCTION fnLayMaChiec(@maxe nvarchar(10)) RETURNS nvarchar(10)
BEGIN
	RETURN (SELECT TOP 1 MaChiec
			FROM Production.KhoXe WHERE MaXe = @maxe AND DaBan = N'Còn hàng')
END;
GO

/*----------Lấy giá xe----------*/
CREATE FUNCTION fnLayGiaTienXe(@machiec nvarchar(10)) RETURNS money
BEGIN
	RETURN (SELECT TOP 1 GiaXe
			FROM Production.Xe AS x JOIN Production.KhoXe AS kx ON x.MaXe = kx.MaXe
			WHERE MaChiec = @machiec)
END;
GO

/*----------Lấy thuộc tính mã bảo hiểm, tên bảo hiểm----------*/
CREATE VIEW vBaoHiem
AS
	SELECT MaBH, GoiBaoHiem
	FROM Sales.BaoHiem
GO

/*----------Lấy giá bảo hiểm----------*/
CREATE FUNCTION fnLayGiaBaoHiem(@mabaohiem nvarchar(10)) RETURNS money
BEGIN
	RETURN (SELECT GiaBaoHiem
			FROM Sales.BaoHiem WHERE MaBH = @mabaohiem)
END;
GO

/*----------Lấy tên sản phẩm----------*/
CREATE FUNCTION fnLayTenSanPham(@machiec nvarchar(10)) RETURNS nvarchar(60)
BEGIN
	RETURN (SELECT TenXe
			FROM Production.Xe AS x JOIN Production.KhoXe AS kx ON x.MaXe = kx.MaXe
			WHERE MaChiec = @machiec)
END;
GO

/*----------Lấy tên gói bảo hiểm----------*/
CREATE FUNCTION fnLayTenGoiBaoHiem(@mabaohiem nvarchar(10)) RETURNS nvarchar(60)
BEGIN
	RETURN (SELECT GoiBaoHiem
			FROM Sales.BaoHiem WHERE MaBH = @mabaohiem)
END;
GO

/*----------Lấy tên nhân viên----------*/
CREATE FUNCTION fnLayTenNhanVien(@manv nvarchar(10)) RETURNS nvarchar(60)
BEGIN
	RETURN (SELECT HoTen
			FROM Employee.NhanSu WHERE MaNV = @manv)
END;
GO

/*----------Lấy thuộc tính mã nhân viên, tên nhân viên----------*/
CREATE VIEW vNhanSu
AS
	SELECT MaNV, HoTen
	FROM Employee.NhanSu
GO

/*----------Lấy thuộc tính đã bán trong kho xe----------*/
CREATE FUNCTION fnLayDaBan(@machiec nvarchar(10)) RETURNS nvarchar(10)
BEGIN
	RETURN (SELECT DaBan
			FROM Production.KhoXe WHERE MaChiec = @machiec)
END;
GO

/*----------Check đã bán----------*/
CREATE PROC spKhoXe_Check
	@machiec nvarchar(10)
AS
	DECLARE @daban nvarchar(10);
	SELECT @daban = DaBan FROM Production.KhoXe;
	SET @daban = N'Đã bán';
	UPDATE Production.KhoXe SET DaBan = @daban WHERE MaChiec = @machiec;
GO

/*----------Lấy mã xe----------*/
CREATE FUNCTION fnLayMaXe(@machiec nvarchar(10)) RETURNS nvarchar(10)
BEGIN
	RETURN (SELECT MaXe
			FROM Production.KhoXe WHERE MaChiec = @machiec)
END;
GO

/*----------Trừ số lượng trong kho----------*/
CREATE PROC spXe_CheckSoLuong
	@maxe nvarchar(10)
AS
	UPDATE Production.Xe SET SoLuong = SoLuong - 1 WHERE MaXe = @maxe;
GO

/*----------Trừ số lượng trong kho----------*/
--CREATE TRIGGER tgTruSoLuongXe ON Sales.ChiTietHopDong AFTER INSERT
--AS
--	DECLARE @machiec nvarchar(10), @maxe nvarchar(10);
--	SET @machiec = (SELECT MaChiec FROM inserted);
--	SET @maxe = dbo.fnLayMaXe(@machiec);
--	UPDATE Production.Xe SET SoLuong = SoLuong - 1 WHERE MaXe = @maxe;
--GO

/*----------Trigger----------*/
/*----------Thêm tài khoản nhân viên----------*/
CREATE TRIGGER tgThemDN ON Employee.NhanSu AFTER INSERT
AS
	DECLARE @user nvarchar(10), @chucvu nvarchar(20);
	SELECT @user=MaNV, @chucvu=ChucVu FROM inserted;
	INSERT INTO Employee.DangNhap VALUES (@user, @user, @chucvu);
GO

/*----------Xóa tài khoản nhân viên(xóa luôn tài khoản, lịch làm)----------*/
CREATE TRIGGER tgXoaDN ON Employee.NhanSu INSTEAD OF DELETE
AS 
	DECLARE @user nvarchar(10);
	SELECT @user = MaNV FROM deleted;
	DELETE Employee.DangNhap WHERE UserName = @user;	
	DELETE Employee.NhanSu WHERE MaNV = @user;
GO

/*----------Xóa mã chiếc (xóa luôn trong chi tiết hợp đồng)----------*/
CREATE TRIGGER tgXoaMaChiec ON Production.KhoXe INSTEAD OF DELETE
AS
	DECLARE @mac nvarchar(10);
	SELECT @mac = MaChiec FROM deleted;
	DELETE Sales.ChiTietHopDong WHERE MaChiec = @mac;
	DELETE Production.KhoXe WHERE MaChiec = @mac;
GO

/*----------View----------*/

/*----------Index----------*/
/*----------Cho phép các trường trùng nhau----------*/
/*----------Tìm kiếm theo họ tên nhân viên----------*/
CREATE INDEX IndexNhanSu_SelectName ON Employee.NhanSu(HoTen)

/*----------Không cho phép các trường trùng nhau----------*/
/*----------Tìm kiếm theo mã nhân viên----------*/
CREATE UNIQUE INDEX IndexNhanSu_SelectID ON Employee.NhanSu(MaNV)



	










	










