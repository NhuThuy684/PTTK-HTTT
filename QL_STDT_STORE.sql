USE QL_SieuThi_DienThoai
GO


-- Tìm kiếm sản phẩm theo tên sản phẩm/ loại sản phẩm

CREATE PROC SP_TIMKIEMSANPHAM(@TENSP NVARCHAR(50), @LOAISP NVARCHAR(20))
AS
BEGIN
	SELECT s.MaSP, s.TenSP, s.Gia, s.XuatXu, s.LoaiSP FROM SanPham S WHERE S.TenSP LIKE  N'%'+@TENSP+'%' AND S.LoaiSP LIKE N'%'+@LOAISP+'%'
END
GO

--KIỂM TRA HẠN SỬ DỤNG CỦA COUPON
CREATE PROC SP_KIEMTRACOUPON (@LOAICOUPON NVARCHAR(2))
AS
BEGIN
	DECLARE @DATE DATE; SET @DATE=GETDATE();
	IF EXISTS(SELECT * FROM COUPON C WHERE C.Loai_Coupon=@LOAICOUPON AND @DATE BETWEEN C.NgayBD AND C.NgayKT)
	RETURN 1;
	ELSE RETURN 0;
END
GO

--Kiểm tra loại khách hàng dựa vào điểm tích lũy
create proc sp_ktLoaiKH @maKH int
as
begin
select t.diemtichluy, case
	when t.DiemTichLuy < 150 then N'Bình thường' 
	else N'Thân thiết' 
	end as loaiKH
from TheKH t
where t.MaKH=@maKH
end
GO

--tỉ lệ giảm giá theo cấp độ cho mua sỉ

--ALTER 
CREATE proc sp_tiLecapDoGG @maKH int
as
begin 
return (select case
	when t.DiemTichLuy < 150 then '0' 
	when t.DiemTichLuy < 300 then '1' 
	when t.DiemTichLuy < 500 then '2'
	when t.DiemTichLuy < 800 then '3' 
	when t.DiemTichLuy < 1000 then '4'  
	else '5' 
	end 
from TheKH t
where t.MaKH=@maKH )
end

go


--alter 
CREATE proc sp_KiemTraVaKM(@makh int, @maCoupon Nvarchar(2), @loaiMua nvarchar(20))
as
begin
	declare @tong int; set @tong=0;
	declare @temp int;
	declare @temp2 int;
	exec @temp2=sp_tiLecapDoGG @maKH
	--Ki?m tra coupon 
	exec @temp= SP_KIEMTRACOUPON @maCoupon; 
	if @temp!=0--có coupon
	begin
	--Ki?m tra lo?i mua
		
		if @loaiMua= N'Lẻ'
		begin
			--ch? tính t? l? cho lo?i coupon gi?m giá
			
			set @tong= @tong + (select c.Ten_Coupon from Coupon c where c.Loai_Coupon=@maCoupon and c.LoaiSD=N'GIẢM GIÁ')
			select @tong
			
		end
		else --mua s?
		begin
			set @tong= @tong + (select c.Ten_Coupon from Coupon c where c.Loai_Coupon=@maCoupon and c.LoaiSD=N'Giảm giá')
			
			set @tong=@tong+@temp2
			
		end
		
	end
	else --Không có coupon
	begin 
		if @loaimua=N'Sỉ'
		begin
			
			select @tong=@tong+@temp2
			print @tong
	

		end
		else
		print @tong


	end
			select @tong as tilekm, case @temp when 0 then N'Không hợp lệ' else N'Hợp lệ' end as tinhtrang, t.diemtichluy, case
	when t.DiemTichLuy < 150 then N'Bình thường' 
	else N'Thân thiết' 
	end as loaiKH
from TheKH t
where t.MaKH=@maKH	
end
GO

--ALTER
CREATE proc sp_LapHoaDon (@MaKH int, @LoaiHD Nvarchar (20), @TileGG float)
as
begin
	declare @date date; set @date=getdate();
	Insert into HoaDon (makh, NgayLapHD, LoaiHD, TiLeGiamGia)
	values (@makh,@date, @LoaiHD, @TileGG )
	select @@IDENTITY as MaHD
end
GO

--drop proc sp_LapChiTietHoaDon
--ALTER 
CREATE proc sp_LapChiTietHoaDon (@MaHD int, @masp int, @soluong int, @dongia int, @tongtien float)
as
begin
	insert into ChiTietHoaDon (mahd, masp, soluong, dongia, tien)
	values (@mahd, @masp, @soluong, @dongia, @tongtien)
end
select * from ChiTietHoaDon

--KIỂM TRA TỒN KHO
CREATE PROCEDURE KT_TonKho
( @MaSP INT,
  @NgayKiemKho date,
  @SLTon int
 )
AS
BEGIN TRAN
 IF(@MaSP IS NOT NULL)
 BEGIN 
 SELECT *
 FROM dbo.Kho
 WHERE @MaSP=MaSP AND @NgayKiemKho=NgayKiemKho
 END
 COMMIT TRAN
 GO

 --THỐNG KÊ SẢN PHẨM BẢO HÀNH:
CREATE
 --ALTER 
 PROCEDURE ThongKe_SP_BaoHanh @NgayBaoHanh datetime
 AS
 BEGIN 
	SELECT *
	FROM DonBaoHanh
	WHERE convert(date,@NgayBaoHanh)= NgayBaoHanh -- @MaSP=MaSP AND @MaNCC= MaNCC
 END
 GO

--THÊM SẨN PHẨM BẢO HÀNH:
 CREATE
 --ALTER 
 PROCEDURE Them_san_pham_bao_hanh
 ( @MaSP int,
   @MaKH int,
   @TinhTrang nvarchar(100),
   @MaNCC int,
   @NgayBaoHanh datetime,
   @HinhThucBH nvarchar(5)
   )
 AS
 BEGIN
	INSERT INTO DonBaoHanh (MaSP, MaKH, TinhTrang, MaNCC, NgayBaoHanh, HinhThucBH)
	VALUES (@MaSP, @MaKH, @TinhTrang, @MaNCC, convert(date,@NgayBaoHanh), @HinhThucBH)
 END
 GO

 --LOAD DANH SÁCH SẢN PHẨM SỬA CHỬA
 CREATE PROCEDURE DS_SP_SuaChua
 (@HinhThucBH nvarchar(5))
 AS
 BEGIN
 SELECT *
 FROM DonBaoHanh
 WHERE @HinhThucBH=HinhThucBH
 END
 GO

 --Load Danh sách sản phẩm:
CREATE PROC Load_DanhSach_SanPham
AS
BEGIN
	SELECT* FROM SanPham
END
GO

--Load Danh sách Hóa đơn:
CREATE PROC Load_DanhSach_HoaDon
AS
BEGIN
	SELECT* FROM HoaDon
END
GO

--Load Danh sách Hóa đơn:
CREATE PROC Load_DanhSach_ChiTietHoaDon
AS
BEGIN
	SELECT* FROM ChiTietHoaDon
END
GO

--Store báo cáo doanh thu theo tháng:
----------------Doanh thu tổng hợp-----------------
CREATE
--ALTER
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
GO

-----------------Doanh thu theo từng mặt hàng-----------------
CREATE 
--ALTER 
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
GO

------------------Doanh thu theo 1 mặt hàng-------------------------
CREATE
--ALTER
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
GO

