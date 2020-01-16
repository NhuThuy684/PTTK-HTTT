use master
go

IF DB_ID ('QL_SieuThi_DienThoai') IS NOT NULL
	DROP DATABASE QL_SieuThi_DienThoai
GO

CREATE DATABASE QL_SieuThi_DienThoai
GO

use QL_SieuThi_DienThoai
GO

--Tạo Bảng
CREATE TABLE NhaCungCap
(
	MaNCC int identity,
	TenNCC nvarchar(50),
	DiaChi nvarchar(100),
	SoFax int,
	CONSTRAINT PK_NhaCungCap PRIMARY KEY (MaNCC)
)


CREATE TABLE SP_NCC
(
	MaNCC int,
	MaSP int
	CONSTRAINT PK_SP_NCC PRIMARY KEY(MaNCC, MaSP)
)

CREATE TABLE SDT_NCC
(
	MaNCC int,
	SoDT int
	CONSTRAINT PK_SDT_NCC PRIMARY KEY(MaNCC, SoDT)
)

CREATE TABLE DonBaoHanh
(
	MaDBH int identity(3001,1),
	MaSP int,
	MaKH int,
	HinhThucBH nvarchar(5),
	TinhTrang nvarchar(100),
	MaNCC int,
	NgayBaoHanh date,
	CONSTRAINT PK_DonBH PRIMARY KEY(MaDBH)
)

CREATE TABLE SanPham
(
	MaSP int identity(1001,1),
	TenSP nvarchar(50),
	Gia int,
	HangSX int,
	XuatXu nvarchar(20),
	ThoiGianBaoHanh nvarchar(10),
	LoaiSP nvarchar(20),
	KichThuoc varchar(10),
	TrongLuong varchar(10),
	HeDieuHanh varchar(10),
	MoTaThem nvarchar(100),
	CONSTRAINT PK_DienThoai PRIMARY KEY(MaSP)
)


CREATE TABLE HangSX
(
	MaHangSX int identity (111,1),
	TenHangSX nvarchar(50),
	CONSTRAINT PK_HangSX PRIMARY KEY(MaHangSX)
)

CREATE TABLE Kho
(
	MaSP int,
	NgayKiemKho date,
	SLTon int
	CONSTRAINT PK_Kho PRIMARY KEY(MaSP, NgayKiemKho)
)

CREATE TABLE DonDatHang
(
	MaDDH int identity(4001,1),
	MaSP int,
	SoLuongMua int
	CONSTRAINT PK_DonDatHang PRIMARY KEY(MaDDH)
)

CREATE TABLE KhachHang
(
	MaKH int identity(2001,1),
	HoTen nvarchar(50),
	DiaChi nvarchar(100),
	LoaiKH nvarchar(10),
	TenCongTy nvarchar(50),
	DiaChiCongTy nvarchar(100),
	TenNguoiDaiDien nvarchar(50)
	CONSTRAINT PK_KhachHang_CaNhan PRIMARY KEY(MaKH)
)


CREATE TABLE SDT_KhachHang
(
	MaKH int,
	SDT int
	CONSTRAINT PK_SDT_CongTy PRIMARY KEY(MaKH, SDT)
)

CREATE TABLE TheKH
(
	MaThe int identity(5001, 1),
	MaKH int,
	DiemTichLuy int,
	LoaiKH bit,
	CapDo int
	CONSTRAINT PK_TheKH PRIMARY KEY(MaThe)
)

CREATE TABLE ChiTietHoaDon
(
	MaHD int,
	MaSP int,
	SoLuong int,
	DonGia int,
	Tien int,
	CONSTRAINT PK_ChiTietHoaDon PRIMARY KEY(MaHD, MaSP)
)

CREATE TABLE HoaDon
(
	MaHD int identity(6001,1),
	MaKH int,
	TongTien float,
	NgayLapHD date,
	LoaiHD nvarchar(2),
	TiLeGiamGia float
	CONSTRAINT PK_HoaDon_Le PRIMARY KEY(MaHD)
)

CREATE TABLE Coupon
(
	Loai_Coupon nvarchar(2),
	Ten_Coupon nvarchar(50),
	LoaiSD nvarchar(10),
	NgayBD date,
	NgayKT date
	CONSTRAINT PK_Coupon PRIMARY KEY(Loai_Coupon)
)

CREATE TABLE GiaCuoc
(
	LoaiCuoc varchar(2),
	KhoangCach int,
	TienCuoc int
	CONSTRAINT PK_GiaCuoc PRIMARY KEY(LoaiCuoc)
)

CREATE TABLE PhieuGiaoHang
(
	MaHD int ,
	NgayGiaoHang date,
	DiaDiemGiao nvarchar(100),
	LoaiCuoc varchar(2)
)

------------------------------------------------------------------------------------------
------------------------------------------------------------------------------------------
----Tạo Khóa ngoại:
--Bảng SDT_NCC
ALTER TABLE SDT_NCC
ADD 
	CONSTRAINT FK_SDT_NCC_NhaCungCap 
	FOREIGN KEY (MaNCC)
	REFERENCES NhaCungCap(MaNCC)
GO

--Bảng Sp_NCC
ALTER TABLE SP_NCC
ADD
	CONSTRAINT FK_SP_NCC_NhaCungCap
	FOREIGN KEY (MaNCC)
	REFERENCES NhaCungCap(MaNCC)
GO

ALTER TABLE SP_NCC
ADD
	CONSTRAINT FK_SP_NCC_SanPham
	FOREIGN KEY (MaSP)
	REFERENCES SanPham(MaSP)
GO

--Bảng DonBaoHanh
ALTER TABLE DonBaoHanh
ADD
	CONSTRAINT FK_DonBaoHanh_NhaCungCap
	FOREIGN KEY (MaNCC)
	REFERENCES NhaCungCap(MaNCC)
GO

ALTER TABLE DonBaoHanh
ADD
	CONSTRAINT FK_DonBaoHanh_KhachHang
	FOREIGN KEY (MaKH)
	REFERENCES KhachHang(MaKH)
GO

ALTER TABLE DonBaoHanh
ADD
	CONSTRAINT FK_DonBaoHanh_SanPham
	FOREIGN KEY (MaSP)
	REFERENCES SanPham(MaSP)
GO

--Bảng SanPham
ALTER TABLE SanPham
ADD
	CONSTRAINT FK_SanPham_HangSX
	FOREIGN KEY (HangSX)
	REFERENCES HangSX (MaHangSX)
GO

--Bảng DonDatHang
ALTER TABLE DonDatHang
ADD
	CONSTRAINT FK_DonDatHang_SanPham
	FOREIGN KEY (MaSP)
	REFERENCES SanPham (MaSP)
GO

--Bảng Kho
ALTER TABLE Kho
ADD
	CONSTRAINT FK_Kho_SanPham
	FOREIGN KEY (MaSP)
	REFERENCES SanPham (MaSP)
GO

--Bảng SDT_KhachHang
ALTER TABLE SDT_KhachHang
ADD
	CONSTRAINT FK_SDT_KhachHang_KhachHang
	FOREIGN KEY (MaKH)
	REFERENCES KhachHang(MaKH)
GO

--Bảng TheKH
ALTER TABLE TheKH
ADD
	CONSTRAINT FK_TheKH_KhachHang
	FOREIGN KEY (MaKH)
	REFERENCES KhachHang (MaKH)
GO

--Bảng ChiTietHoaDon
ALTER TABLE ChiTietHoaDon
ADD
	CONSTRAINT FK_ChiTietHoaDon_SanPham
	FOREIGN KEY (MaSP)
	REFERENCES SanPham(MaSP)
GO

ALTER TABLE ChiTietHoaDon
ADD
	CONSTRAINT FK_ChiTietHoaDon_HoaDon
	FOREIGN KEY (MaHD)
	REFERENCES HoaDon(MaHD)
GO

--Bảng HoaDon
ALTER TABLE HoaDon
ADD
	CONSTRAINT FK_HoaDon_KhachHang
	FOREIGN KEY (MaKH)
	REFERENCES KhachHang(MaKH)
GO

--Bảng PhieuGiaoHang
ALTER TABLE PhieuGiaoHang
ADD
	CONSTRAINT FK_PhieuGiaoHang_HoaDon
	FOREIGN KEY (MaHD)
	REFERENCES HoaDon(MaHD)
GO

ALTER TABLE PhieuGiaoHang
ADD
	CONSTRAINT FK_PhieuGiaoHang_GiaCuoc
	FOREIGN KEY (LoaiCuoc)
	REFERENCES GiaCuoc(LoaiCuoc)
GO

-----------------------------------------------------------------------------------------------
-----------------------------------------------------------------------------------------------
--Insert dữ liệu:
--Bảng KhachHang_CaNhan 
INSERT INTO KhachHang
VALUES (N'Nguyễn Thị Mai Lan', N'172 Trần Bình Trọng, quận 5, TP.HCM', N'Cá nhân', NULL, NULL, NULL)
INSERT INTO KhachHang 
VALUES (N'Trần Văn Bình', N'123 Trần Hưng, quận 1, TP.HCM', N'Cá nhân', NULL, NULL, NULL)
INSERT INTO KhachHang
VALUES (N'Nguyễn Lan Hương', N'24, Nguyễn Bỉnh Khiêm, quận 1, TP.HCM', N'Cá nhân', NULL, NULL, NULL)
INSERT INTO KhachHang 
VALUES ( N'Phạm Thị Tú Anh', N'145 Trần Hưng Đạo, phường Ninh Kiều, Cần Thơ ', N'Cá nhân', NULL, NULL,NULL)
INSERT INTO KhachHang 
VALUES (N'Mai Quang Huy', N'177, ấp Tân Bình, xã An Phước Tây, tỉnh Đồng Tháp', N'Cá nhân', NULL, NULL, NULL)
INSERT INTO KhachHang
VALUES (N'Vũ Thị Mai',NULL, N'Công ty', N'Công ty ABC', N'384 Kha Vạn Cân, quận Thủ Đức, TP.HCM', N'Vũ Thị Mai')
INSERT INTO KhachHang
VALUES (N'Trịnh Việt Hưng',NULL, N'Công ty',  N'Công ty VH', N'184 đường Huỳnh Mẫn Đạt, quận 5, TP.HCM', N'Nguyễn Anh Hoàng')
INSERT INTO KhachHang
VALUES (N'Nguyễn Tiến Dũng',NULL, N'Công ty', N'Công ty điện thoại MCT', N'98 Cai Lậy, Tiền Giang', N'Vũ Thế Anh')
INSERT INTO KhachHang
VALUES (N'Nguyễn Vũ Ngọc Lan',NULL, N'Công ty', N'Công ty điện thoại Anh Tâm', N'198 An Bình, quận 5, TP.HCM', N'Nguyễn Vũ Anh Tài')
INSERT INTO KhachHang
VALUES (N'Hồ Mỹ Anh',NULL, N'Công ty', N'Công ty Anh Vũ Hoàng', N'xã Quảng Phú, Quảng Điền, Thừa Thiên- Huế', N'Hồ Mỹ Anh')

--Bảng SDT_CongTy:
INSERT INTO SDT_KhachHang
VALUES (2006, 0861723123)
INSERT INTO SDT_KhachHang
VALUES (2006, 0351723645)
INSERT INTO SDT_KhachHang
VALUES (2007, 0362197463)
INSERT INTO SDT_KhachHang
VALUES (2008, 0352198333)
INSERT INTO SDT_KhachHang
VALUES (2008, 0862997763)
INSERT INTO SDT_KhachHang
VALUES (2009, 0309187365)
INSERT INTO SDT_KhachHang
VALUES (2010, 0382134521)
INSERT INTO SDT_KhachHang
VALUES (2010, 0395632006)
INSERT INTO SDT_KhachHang
VALUES (2001, 0257505895)
INSERT INTO SDT_KhachHang
VALUES (2002, 0263849342)
INSERT INTO SDT_KhachHang
VALUES (2003, 0647811900)
INSERT INTO SDT_KhachHang
VALUES (2004, 0657282529)
INSERT INTO SDT_KhachHang
VALUES (2005, 0247489400)


--Bảng HangSX:
INSERT INTO HangSX
VALUES ('SamSung')
INSERT INTO HangSX
VALUES ('Oppo')
INSERT INTO HangSX
VALUES ('Iphone')
INSERT INTO HangSX
VALUES ('Sony')
INSERT INTO HangSX
VALUES ('XaoMi')

--Bảng DienThoai:
INSERT INTO SanPham
VALUES ( N'SamSung Galaxy S9', 15800000, 111, N'Hàn Quốc', N'1 năm', N'ĐTDĐ','148x69x8mm','163 gam', 'Android',N'Màu sắc: Gold, Black, While')
INSERT INTO SanPham
VALUES ( N'SamSung Galaxy J7', 3790000, 111, N'Hàn Quốc', N'1 năm', N'ĐTDĐ', '140x63x9mm','161 gam', 'Android',N'Màu sắc: Gold, Black, While')
INSERT INTO SanPham
VALUES (N'SamSung Galaxy A7', 6690000, 111, N'Hàn Quốc', N'1 năm', N'ĐTDĐ', '140x63x8mm','165 gam', 'Android',N'Màu sắc: Gold, Black, While')
INSERT INTO SanPham
VALUES (N'OPPO F1s', 4989000, 112, N'Trung Quốc', N'1 năm', N'ĐTDĐ', '148x69x8mm','163 gam', 'Android',N'Màu sắc: Pink, Black, While')
INSERT INTO SanPham
VALUES (N'IPhone X', 19990000, 113, N'Mỹ', N'2 năm', N'ĐTDĐ', '158x76x8mm','160 gam', 'iOS',N'Màu sắc: Pink, Black, While')
INSERT INTO SanPham
VALUES ( N'IPhone 8', 14600000, 113, N'Mỹ', N'2 năm', N'ĐTDĐ', '148x69x8mm','160 gam', 'iOS',N'Màu sắc: Gold, Black, While')
INSERT INTO SanPham
VALUES (N'Tai nghe Sony WH', 7046000, 114, N'Nhật Bản', N'1 năm',N'Phụ kiện', NULL, NULL, NULL, NULL)
INSERT INTO SanPham
VALUES (N'Tai nghe Sony cao cấp Z1R', 15046000, 114, N'Nhật Bản', N'2 năm', N'Phụ kiện', NULL, NULL, NULL, NULL)
INSERT INTO SanPham
VALUES (N'Sạc dự phòng Mi', 860000, 115, N'Trung Quốc', N'1 năm', N'Phụ kiện', NULL, NULL, NULL, NULL)
INSERT INTO SanPham
VALUES (N'Thẻ nhớ AZF1', 450000, 114, N'Trung Quốc', N'1 năm', N'Phụ kiện', NULL, NULL, NULL, NULL)
INSERT INTO SanPham
VALUES (N'Sạc dự phòng Sony A43', 1250000, 113, N'Nhật Bản', N'1 năm', N'Phụ kiện', NULL, NULL, NULL, NULL)

--Bảng TheKH:
--LoaiKH: 0(Khách hàng bình thường), 1(Khách hàng thân thiết)
 
INSERT INTO TheKH
VALUES (2001,150, 1, 1)
INSERT INTO TheKH
VALUES (2002, 50, 0, 0)
INSERT INTO TheKH
VALUES (2003, 500, 1, 3)
INSERT INTO TheKH
VALUES (2004, 80, 0, 0)
INSERT INTO TheKH
VALUES (2005, 120, 0, 0)
INSERT INTO TheKH
VALUES (2006, 1500, 1, 5)
INSERT INTO TheKH
VALUES (2007, 910, 1, 4)
INSERT INTO TheKH
VALUES (2008, 1200, 1, 4)
INSERT INTO TheKH
VALUES (2009, 650, 1, 3)
INSERT INTO TheKH
VALUES (2010, 450, 1, 2)

--Bảng Coupon:
INSERT INTO Coupon
VALUES ('X1', N'Giảm giá 10%', N'Giảm giá', '2011-09-01', '2011-12-31')
INSERT INTO Coupon
VALUES ('X2', N'Tặng 300.000 đ khi mua hàng từ 5.000.000đ trở lên', N'Tặng tiền', '2011-09-01', '2011-12-31')
INSERT INTO Coupon
VALUES ('X3', N'Giảm giá 15%', N'Giảm giá', '2011-09-01', '2011-12-31')

--Bảng HoaDon:
INSERT INTO HoaDon
VALUES (2001, 129000, '2010-10-23',  N'Lẻ', 0.01)
INSERT INTO HoaDon
VALUES (2007, 2800000, '2010-09-12',  N'Sỉ',0.04 )
INSERT INTO HoaDon
VALUES (2004, 3560000, '2011-10-28',  N'Lẻ', 0)
INSERT INTO HoaDon
VALUES (2004, 12700000, '2010-09-30',  N'Lẻ',0)
INSERT INTO HoaDon
VALUES (2009, 15203000, '2010-09-12',  N'Sỉ',0.03)
INSERT INTO HoaDon
VALUES (2009, 15030000, '2010-09-25',  N'Sỉ',0.03)
INSERT INTO HoaDon
VALUES (2002, 15030000, '2011-10-25',  N'Sỉ',0.02)
INSERT INTO HoaDon
VALUES (2001, 6100000, '2010-01-25',  N'Sỉ',0.02)
INSERT INTO HoaDon
VALUES (2008, 6100000, '2011-01-25',  N'Sỉ',0.02)

--Bảng ChiTietHD
INSERT INTO ChiTietHoaDon
VALUES (6001, 1006, 1,  129000, 129000)
INSERT INTO ChiTietHoaDon
VALUES (6002, 1006, 2,  2800000, 2800000)
INSERT INTO ChiTietHoaDon
VALUES (6003, 1002, 1,  3560000, 3560000)
INSERT INTO ChiTietHoaDon
VALUES (6004, 1006, 1,  150300, 150300)
INSERT INTO ChiTietHoaDon
VALUES (6005, 1003, 2,  2470000, 4970000)
INSERT INTO ChiTietHoaDon
VALUES (6006, 1005, 1,  150300, 150300)
INSERT INTO ChiTietHoaDon
VALUES (6007, 1005, 1,  150300, 150300)
INSERT INTO ChiTietHoaDon
VALUES (6009, 1005, 1,  6100000, 610000)

--Bảng GiaCuoc:
INSERT INTO GiaCuoc
VALUES ('C1', 200, 200000)
INSERT INTO GiaCuoc
VALUES ('C2', 300, 350000)
INSERT INTO GiaCuoc
VALUES ('C3', 600, 500000)
INSERT INTO GiaCuoc
VALUES ('C4', 1000, 600000)

--Bảng PhieuGiaoHang
INSERT INTO PhieuGiaoHang
VALUES (6001, '2010-09-12', N'187 Trần Hưng Đạo, quận 5, TP.HCM', 'C1')
INSERT INTO PhieuGiaoHang
VALUES (6002, '2011-10-28', N'384 Kha Vạn Cân, quận Thủ Đức, TP.HCM', 'C1')

--Bảng NhaCungCap:
INSERT INTO NhaCungCap
VALUES (N'Thế giới di động', N'Đông Hòa, Dĩ An, Bình Dương', 58201678)
INSERT INTO NhaCungCap
VALUES (N'Điện máy xanh', N'1289 Trần Hưng Đạo, quận 5, TP.HCM', 26174852)
INSERT INTO NhaCungCap
VALUES (N'FPT Shop', N'123 Cầu Giấy, Hà Nội', 76838910)
INSERT INTO NhaCungCap
VALUES (N'Nguyễn Kim', N'763 Võ Văn Kiệt, quận 5, TP.HCM', 732841949)

--Bang SDT_NhaCungCap
INSERT INTO SDT_NCC
VALUES (1, 095367819)
INSERT INTO SDT_NCC
VALUES (2, 017638929)
INSERT INTO SDT_NCC
VALUES (3, 068825719)
INSERT INTO SDT_NCC
VALUES (4, 038654728)

--Bảng SP_NCC
INSERT INTO SP_NCC
VALUES (1, 1001)
INSERT INTO SP_NCC
VALUES (2, 1002)
INSERT INTO SP_NCC
VALUES (1, 1003)
INSERT INTO SP_NCC
VALUES (1, 1004)
INSERT INTO SP_NCC
VALUES (3, 1005)
INSERT INTO SP_NCC
VALUES (2, 1006)
INSERT INTO SP_NCC
VALUES (4, 1007)
INSERT INTO SP_NCC
VALUES (4, 1008)
INSERT INTO SP_NCC
VALUES (2, 1009)
INSERT INTO SP_NCC
VALUES (3, 1010)

--Bảng DonBaoHanh
INSERT INTO DonBaoHanh
VALUES (1001, 2001, N'Sửa',N'Hư màn hình cảm ứng', 1, '2012-03-28')
INSERT INTO DonBaoHanh
VALUES (1005, 2003, N'Đổi',N'Lỗi hệ thống', 3, '2012-12-12')
INSERT INTO DonBaoHanh
VALUES (1003, 2004, N'Sửa',N'Hỏng nút nguồn', 1, '2013-01-09')

--Bảng Kho
INSERT INTO Kho
VALUES (1001, '2011-12-25', 20)
INSERT INTO Kho
VALUES (1002, '2011-12-25', 10)
INSERT INTO Kho
VALUES (1003, '2011-12-25', 25)
INSERT INTO Kho
VALUES (1004, '2011-12-25', 20)
INSERT INTO Kho
VALUES (1005, '2011-12-25', 10)
INSERT INTO Kho
VALUES (1006, '2011-12-25', 100)
INSERT INTO Kho
VALUES (1007, '2011-12-25', 30)
INSERT INTO Kho
VALUES (1008, '2011-12-25', 50)
INSERT INTO Kho
VALUES (1009, '2011-12-25', 10)
INSERT INTO Kho
VALUES (1010, '2011-12-25', 25)

---------------------------------------
--Load Danh sách sản phẩm:
CREATE PROC Load_DanhSach_SanPham
AS
BEGIN
	SELECT* FROM SanPham
END

--Load Danh sách Hóa đơn:
CREATE PROC Load_DanhSach_HoaDon
AS
BEGIN
	SELECT* FROM HoaDon
END

--Load Danh sách Hóa đơn:
CREATE PROC Load_DanhSach_ChiTietHoaDon
AS
BEGIN
	SELECT* FROM ChiTietHoaDon
END
--Store báo cáo doanh thu theo tháng:
----------------Doanh thu tổng hợp-----------------
--CREATE
ALTER
PROC DoanhThu_Thang_TongHop 
	@NgayBD datetime,
	@NgayKT datetime
AS
BEGIN
	IF(DATEPART(YEAR, @NgayBD) = DATEPART(YEAR, @NgayKT))
	BEGIN
		SELECT DATEPART(MONTH, HD.NgayLapHD) AS N'THÁNG', SUM(CAST(HD.tongTien AS BIGINT)) AS N'DOANH THU THÁNG'
		FROM HoaDon HD
		WHERE HD.NgayLapHD>=CONVERT(DATE,@NgayBD) AND HD.NgayLapHD<=CONVERT(DATE,@NgayKT)
		GROUP BY DATEPART(MONTH, HD.NgayLapHD)
		ORDER BY DATEPART(MONTH, HD.NgayLapHD) ASC
	END
	BEGIN
		PRINT(N'Bạn vui lòng nhập ngày bắt đầu và ngày kết thuc trong cùng một năm.')
	END
END

--EXEC DoanhThu_Thang_TongHop '2010-01-01','2010-12-01'

-----------------Doanh thu theo từng mặt hàng-----------------
--CREATE 
ALTER 
PROC DoanhThu_Thang_TungMatHang
	@NgayBD datetime,
	@NgayKT datetime, 
	@MatHang nvarchar(10)
AS
BEGIN
	IF(DATEPART(YEAR, @NgayBD)=DATEPART(YEAR, @NgayKT))
	BEGIN
		SELECT DISTINCT DATEPART(MONTH, HD.NgayLapHD) AS N'THÁNG', SP.LoaiSP AS N'MẶT HÀNG', SUM(CAST(HD.TongTien AS BIGINT)) AS N'DOANH THU THÁNG'
		FROM HoaDon HD, ChiTietHoaDon CT, SanPham SP
		WHERE HD.MaHD=CT.MaHD AND CT.MaSP=SP.MaSP AND SP.LoaiSP=@MatHang
		AND (HD.NgayLapHD>=CONVERT(DATE, @NgayBD)) AND (HD.NgayLapHD<=CONVERT(DATE, @NgayKT))
		GROUP BY DATEPART(MONTH, HD.NgayLapHD), SP.LoaiSP
		ORDER BY DATEPART(MONTH, HD.NgayLapHD)
	END
	ELSE
	BEGIN
		PRINT(N'Bạn vui lòng nhập ngày bắt đầu và ngày kết thuc trong cùng một năm.')
	END
END

--EXEC DoanhThu_Thang_TungMatHang '2010-01-01','2010-12-01', N'ĐTDĐ'

------------------Doanh thu theo 1 mặt hàng-------------------------
--CREATE
ALTER
PROC DoanhThu_Thang_MotMatHang
	@NgayBD datetime,
	@NgayKT datetime, 
	@SanPham nvarchar(50)
AS
BEGIN
	IF(DATEPART(YEAR, @NgayBD)=DATEPART(YEAR, @NgayKT))
	BEGIN
		SELECT DATEPART(MONTH, HD.NgayLapHD) AS N'THÁNG', SP.TenSP AS N'MẶT HÀNG', SUM(CAST(HD.TongTien AS BIGINT)) AS N'DOANH THU THÁNG'
		FROM HoaDon HD, ChiTietHoaDon CT, SanPham SP
		WHERE HD.MaHD=CT.MaHD AND CT.MaSP=SP.MaSP AND SP.TenSP=@SanPham
		AND (HD.NgayLapHD>=CONVERT(DATE, @NgayBD)) AND (HD.NgayLapHD<=CONVERT(DATE, @NgayKT))
		GROUP BY DATEPART(MONTH, HD.NgayLapHD), SP.TenSP
		ORDER BY DATEPART(MONTH, HD.NgayLapHD)
	END
	ELSE
	BEGIN
		PRINT(N'Bạn vui lòng nhập ngày bắt đầu và ngày kết thuc trong cùng một năm.')

	END
END

--EXEC DoanhThu_Thang_MotMatHang '2010-01-01','2011-12-01', 'IPhone X'
