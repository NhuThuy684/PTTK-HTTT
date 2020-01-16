using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAO;
using DTO;
using System.Data.SqlClient;

namespace BUS
{
    public class NhaCungCap_BUS
    {
        
    }
    public class SanPham_BUS
    {
        public static DataTable timKiemSanPham(string tenSP, string loaiSP)
        {
            return SanPham_DAO.timKiemSanPham(tenSP, loaiSP);
        }
        
    }
    public class HoaDon_BUS
    {
        

        public static DataTable lapHoaDon(int makh, string loaiHD, float tileGG, float tongTien)
        {
            return HoaDon_DAO.lapHoaDon(makh, loaiHD, tileGG, tongTien);
        }
    }
    public class ChiTietHoaDon_BUS
    {

        public static void InsertChiTietHoaDon(int maHD, int maSP, int soluong, int dongia, int tongtien)
        {
             ChiTietHoaDon_DAO.InsertChiTietHoaDon(maHD, maSP, soluong, dongia, tongtien);
        }
    }
    public class KhachHang_BUS
    {
        public static DataTable tiLeGiamGia(int makh, string macoupon, string loaimua)
        {
            return KhachHang_DAO.tiLeGiamGia(makh, macoupon, loaimua);
        }
    }
}
