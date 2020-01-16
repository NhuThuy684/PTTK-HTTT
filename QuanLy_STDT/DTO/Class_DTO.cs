using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NhaCungCap_DTO
    {
        public int MaNCC { get => maNCC; set => maNCC = value; }
        public string TenNCC { get => tenNCC; set => tenNCC = value; }
        public string Diachi { get => diachi; set => diachi = value; }
        public int SoFax { get => soFax; set => soFax = value; }
        private int maNCC;
        private string tenNCC;
        private string diachi;
        private int soFax;

        public NhaCungCap_DTO(string tenNCC, string diaChi, int soFax)
        {
            TenNCC = tenNCC;
            Diachi = diaChi;

            SoFax = soFax;
        }
    }
    public class SP_NCC_DTO
    {
        private int maNCC;
        private int maSP;
        public int MaNCC { get => maNCC; set => maNCC = value; }
        public int MaSP { get => maSP; set => maSP = value; }

        public SP_NCC_DTO(int maNCC, int maSP)
        {
            MaNCC = maNCC;
            MaSP = maSP;
        }
    }
    public class SDT_NCC_DTO
    {
        private int maNCC;
        private int soDT;
        public int MaNCC { get => maNCC; set => maNCC = value; }
        public int SoDT { get => soDT; set => soDT = value; }

        public SDT_NCC_DTO(int maNCC, int soDT)
        {
            MaNCC = maNCC;
            SoDT = soDT;

        }
    }
    public class DonBaoHanh_DTO
    {
        private int maDBH;
        private int maSP;
        private int maKH;
        private string tinhTrang;
        private int maNCC;

        public int MaNCC { get => maNCC; set => maNCC = value; }
        public string TinhTrang { get => tinhTrang; set => tinhTrang = value; }
        public int MaKH { get => maKH; set => maKH = value; }
        public int MaSP { get => maSP; set => maSP = value; }
        public int MaDBH { get => maDBH; set => maDBH = value; }

        public DonBaoHanh_DTO(int masp, int makh, string tinhtrang, int mancc)
        {
            MaSP = masp;
            MaKH = makh;
            TinhTrang = tinhtrang;
            MaNCC = mancc;
        }
    }
    public class kho_DTO
    {
        private int maSP;
        private string tenSP;
        private int gia;
        private string hangSX;
        private string xuatXu;
        private string thoiGianBaoHanh;
        private string kichThuoc;
        private string trongLuong;
        private string heDieuHanh;
        private string moTaThem;
        private string loaiSP;
        private int soluong;
        public int SoLuong { get => soluong; set => soluong = value; }
        public int MaSP { get => maSP; set => maSP = value; }
        public string TenSP { get => tenSP; set => tenSP = value; }
        public int Gia { get => gia; set => gia = value; }
        public string HangSX { get => hangSX; set => hangSX = value; }
        public string XuatXu { get => xuatXu; set => xuatXu = value; }
        public string ThoiGianBaoHanh { get => thoiGianBaoHanh; set => thoiGianBaoHanh = value; }
        public string KichThuoc { get => kichThuoc; set => kichThuoc = value; }
        public string TrongLuong { get => trongLuong; set => trongLuong = value; }
        public string HeDieuHanh { get => heDieuHanh; set => heDieuHanh = value; }
        public string MoTaThem { get => moTaThem; set => moTaThem = value; }
        public string LoaiSP { get => loaiSP; set => loaiSP = value; }

        //public kho_DTO(string tensp, int gia, int hangsx, string xuatxu, string thoigianbaohanh, string loaisp, string kichthuoc, string trongluong, string hedieuhanh, string motathem)
        //{
        //    TenSP = tensp;
        //    Gia = gia;
        //    HangSX = hangsx;
        //    XuatXu = xuatxu;
        //    ThoiGianBaoHanh = thoigianbaohanh;
        //    LoaiSP = loaisp;
        //    KichThuoc = kichthuoc;
        //    TrongLuong = trongluong;
        //    HeDieuHanh = hedieuhanh;
        //    MoTaThem = moTaThem;
        //}

        
    }

    public class HangSX_DTO
    {
        private int hangSX;
        private string tenHangSX;
        public int HangSX { get => hangSX; set => hangSX = value; }
        public string TenHangSX { get => tenHangSX; set => tenHangSX = value; }
        public HangSX_DTO(string tenhangSX)
        {
            TenHangSX = tenhangSX;
        }
    }
  

    }

    public class DonDatHang_DTO
    {
        private int maDDH;
        private int maSP;
        private int soLuongMua;

        public int MaDDH { get => maDDH; set => maDDH = value; }
        public int MaSP { get => maSP; set => maSP = value; }
        public int SoLuongMua { get => soLuongMua; set => soLuongMua = value; }
        public DonDatHang_DTO(int masp, int soluongmua)
        {
            MaSP = masp;
            SoLuongMua = soluongmua;
        }
    }
    public class KhachHang_DTO
    {
        private int maKH;
        private string hoTen;
        private string diaChi;
        private string loaiKH;
        private string tenCongTy;
        private string diaChiCongTy;
        private string tenNguoiDaiDien;
        public int MaKH { get => maKH; set => maKH = value; }
        public string HoTen { get => hoTen; set => hoTen = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string LoaiKH { get => loaiKH; set => loaiKH = value; }
        public string TenCongTy { get => tenCongTy; set => tenCongTy = value; }
        public string DiaChiCongTy { get => diaChiCongTy; set => diaChiCongTy = value; }
        public string TenNguoiDaiDien { get => tenNguoiDaiDien; set => tenNguoiDaiDien = value; }
        public KhachHang_DTO(string hoten, string diachi, string loaiKH, string tencongty, string diachicongty, string tennguoidaidien)
        {
            HoTen = hoten;
            DiaChi = diachi;
            LoaiKH = loaiKH;
            TenCongTy = tencongty;
            DiaChiCongTy = diachicongty;
            TenNguoiDaiDien = tennguoidaidien;

        }
    }

    public class SDT_KhachHang_DTO
    {
        private int maKH;
        private int sDT;

        public int MaKH { get => maKH; set => maKH = value; }
        public int SDT { get => sDT; set => sDT = value; }
        public SDT_KhachHang_DTO(int makh, int sdt)
        {
            MaKH = makh;
            SDT = sdt;
        }
    }
    public class TheKH_DTO
    {
        private int maThe;
        private int maKH;
        private int diemTichLuy;
        private int loaiKH;
        private int capDo;

        public int MaThe { get => maThe; set => maThe = value; }
        public int MaKH { get => maKH; set => maKH = value; }
        public int DiemTichLuy { get => diemTichLuy; set => diemTichLuy = value; }
        public int LoaiKH { get => loaiKH; set => loaiKH = value; }
        public int CapDo { get => capDo; set => capDo = value; }
        public TheKH_DTO(int makh, int diemtichluy, int loaikh, int capdo)
        {
            MaKH = makh;
            DiemTichLuy = diemtichluy;
            LoaiKH = loaikh;
            CapDo = capdo;
        }
    }
    public class ChiTietHoaDon_DTO
    {
        private int maHD;
        private int maSP;
        private int soLuong;
        private int donGia;
        private int tien;
        public int MaHD { get => maHD; set => maHD = value; }
        public int MaSP { get => maSP; set => maSP = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
        public int DonGia { get => donGia; set => donGia = value; }
        public int Tien { get => tien; set => tien = value; }
        public ChiTietHoaDon_DTO(int maHD, int maSP, int soLuong, int donGia, int tien)
        {
            MaHD = maHD;
            MaSP = maSP;
            SoLuong = soLuong;
            DonGia = donGia;
            Tien = tien;
        }
    }
    public class HoaDon_DTO
    {
        private int maHD;
        private int maKH;
        private float tongTien;
        private DateTime ngayLapHD;
        private string loaiHD;
        private float tiLeGiamGia;

        public int MaHD { get => maHD; set => maHD = value; }
        public int MaKH { get => maKH; set => maKH = value; }
        public DateTime NgayLapHD { get => ngayLapHD; set => ngayLapHD = value; }
        public float TongTien { get => tongTien; set => tongTien = value; }
        public string LoaiHD { get => loaiHD; set => loaiHD = value; }
        public float TiLeGiamGia { get => tiLeGiamGia; set => tiLeGiamGia = value; }
        public HoaDon_DTO(int maKH, float tongTien, DateTime ngayLapHD, string loaiHD, float tiLeGiamGia)
        {
            MaKH = maKH;
            TongTien = tongTien;
            NgayLapHD = ngayLapHD;
            LoaiHD = loaiHD;
            TiLeGiamGia = tiLeGiamGia;
        }
    }

    public class Coupon_DTO
    {
        private string loai_Coupon;
        private string ten_Coupon;
        private string loaiSD;
        private DateTime ngayBD;
        private DateTime ngayKT;

        public string Loai_Coupon { get => loai_Coupon; set => loai_Coupon = value; }
        public string Ten_Coupon { get => ten_Coupon; set => ten_Coupon = value; }
        public string LoaiSD { get => loaiSD; set => loaiSD = value; }
        public DateTime NgayBD { get => ngayBD; set => ngayBD = value; }
        public DateTime NgayKT { get => ngayKT; set => ngayKT = value; }
        public Coupon_DTO(string loai_Coupon, string ten_Coupon, string loaiSD, DateTime ngayBD, DateTime ngayKT)
        {
            Loai_Coupon = loai_Coupon;
            Ten_Coupon = ten_Coupon;
            LoaiSD = loaiSD;
            NgayBD = ngayBD;
            NgayKT = ngayKT;
        }
    }
    //public class GiaCuoc_DTO
    //public class PhieuGiaoHang_DTO


