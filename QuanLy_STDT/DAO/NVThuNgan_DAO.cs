using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO;

namespace DAO
{
    //public class sqlconnectionData
    //{
    //    public static SqlConnection hamKetNoi()
    //    {
    //        SqlConnection cnn = new SqlConnection("Data Source=DESKTOP-LG74QVH\\SQLEXPRESS;Initial Catalog=QL_SieuThi_DienThoai;Integrated Security=True");
    //        return cnn;
    //    }
    //}
   
    
    public class SanPham_DAO
    {
        //Tìm kiếm sản phẩm
        public static DataTable timKiemSanPham(string tenSP, string loaiSP )
        {
            SqlConnection cnn = sqlconnectionData.hamKetNoi();
            SqlCommand cmd = new SqlCommand("SP_TIMKIEMSANPHAM", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            //gán giá trị
            cmd.Parameters.Add("@TENSP", SqlDbType.NVarChar, 50);
            cmd.Parameters["@TENSP"].Value = tenSP;
            cmd.Parameters.Add("@LOAISP", SqlDbType.NVarChar, 20);
            cmd.Parameters["@LOAISP"].Value = loaiSP;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dtb = new DataTable();
            da.Fill(dtb);
            return dtb;
        }
      
    }

    public class KhachHang_DAO
    {
        //Tỉ lệ giảm giá 
        public static DataTable tiLeGiamGia(int makh, string macoupon, string loaimua)
        {
            SqlConnection cnn = sqlconnectionData.hamKetNoi();
            SqlCommand cmd = new SqlCommand("sp_KiemTraVAKM", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            //gán giá trị
            cmd.Parameters.Add("@maKH", SqlDbType.Int);
            cmd.Parameters["@maKH"].Value = makh;
            cmd.Parameters.Add("@macoupon", SqlDbType.NVarChar, 2);
            cmd.Parameters["@macoupon"].Value = macoupon;
            cmd.Parameters.Add("@loaimua", SqlDbType.NVarChar, 20);
            cmd.Parameters["@loaimua"].Value = loaimua;


            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dtb = new DataTable();
            da.Fill(dtb);
            return dtb;
        }
    }

    //Kiểm tra loại khách hàng
   



    public class ChiTietHoaDon_DAO
    {
        //Insert thêm một chi tiết hóa đơn
        public static void InsertChiTietHoaDon(int maHD, int maSP, int soluong, int dongia, int tongtien )
        {
            SqlConnection cnn = sqlconnectionData.hamKetNoi();
            SqlCommand cmd = new SqlCommand("sp_LapChiTietHoaDon",cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            //Gán giá trị
            cmd.Parameters.Add("@maHD", SqlDbType.Int);
            cmd.Parameters["@maHD"].Value = maHD;
            cmd.Parameters.Add("@maSP", SqlDbType.Int);
            cmd.Parameters["@maSP"].Value = maSP;
            cmd.Parameters.Add("@soLuong", SqlDbType.Int);
            cmd.Parameters["@soLuong"].Value = soluong;
            cmd.Parameters.Add("@donGia", SqlDbType.Int);
            cmd.Parameters["@donGia"].Value = dongia;
            cmd.Parameters.Add("@tongtien", SqlDbType.Int);
            cmd.Parameters["@tongtien"].Value = tongtien;

            cnn.Open();

            cmd.ExecuteNonQuery();
            cnn.Close();
        }
      
    }
    public class HoaDon_DAO
    {
        
        //Lập hóa đơn
        public static DataTable lapHoaDon(int makh, string loaiHD, float tileGG, float tonngTien)
        {
            SqlConnection cnn = sqlconnectionData.hamKetNoi();
            SqlCommand cmd = new SqlCommand("sp_LapHoaDon", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            //gán giá trị
            cmd.Parameters.Add("@maKH", SqlDbType.Int);
            cmd.Parameters["@maKH"].Value = makh;
            cmd.Parameters.Add("@loaiHD", SqlDbType.NVarChar, 2);
            cmd.Parameters["@loaiHD"].Value = loaiHD;
            cmd.Parameters.Add("@tileGG", SqlDbType.Int);
            cmd.Parameters["@tileGG"].Value = tileGG;
            cmd.Parameters.Add("@tongTien", SqlDbType.Float);
            cmd.Parameters["@tongTien"].Value = tonngTien;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dtb = new DataTable();
            da.Fill(dtb);
          
            return dtb;
            
        }
    }


}

