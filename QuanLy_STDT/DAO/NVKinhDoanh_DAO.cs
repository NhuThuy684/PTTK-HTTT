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
    public class sqlconnectionData
    {
        public static SqlConnection hamKetNoi()
        {
            SqlConnection cnn = new SqlConnection("Data Source=DESKTOP-Q0EIM07;Initial Catalog=QL_SieuThi_DienThoai;Integrated Security=True");
            return cnn;
        }
    }
    public class NVKinhDoanh_DAO
    {
        //Báo cáo doanh thu theo tổng hợp
        public static DataTable ThongKe_Thang_TongHop(DateTime ngayBD, DateTime ngayKT)
        {
            SqlConnection cnn = sqlconnectionData.hamKetNoi();
            SqlCommand cmd = new SqlCommand("DoanhThu_Thang_TongHop", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@NgayBD", SqlDbType.DateTime);
            cmd.Parameters.Add("@NgayKT", SqlDbType.DateTime);
            //Gán giá trị:
            cmd.Parameters["@NgayBD"].Value = ngayBD;
            cmd.Parameters["@NgayKT"].Value = ngayKT;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dtb = new DataTable();
            da.Fill(dtb);
            return dtb;
        }

        //Báo cáo daaonh thu tháng theo từng loại mặt hàng:
        public static DataTable ThongKe_Thang_TungMatHang(DateTime ngayBD, DateTime ngayKT, string matHang)
        {
            {
                SqlConnection cnn = sqlconnectionData.hamKetNoi();
                SqlCommand cmd = new SqlCommand("DoanhThu_Thang_TungMatHang", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@NgayBD", SqlDbType.DateTime);
                cmd.Parameters.Add("@NgayKT", SqlDbType.DateTime);
                cmd.Parameters.Add("@MatHang", SqlDbType.NVarChar, 10);
                //Gán giá trị:
                cmd.Parameters["@NgayBD"].Value = ngayBD;
                cmd.Parameters["@NgayKT"].Value = ngayKT;
                cmd.Parameters["@MatHang"].Value = matHang;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dtb = new DataTable();
                da.Fill(dtb);
                return dtb;
            }

        }

        //Báo cáo doanh thu tháng của một mặt hàng:
        public static DataTable ThongKe_Thang_MotMatHang(DateTime ngayBD, DateTime ngayKT, string sanPham)
        {
            SqlConnection cnn = sqlconnectionData.hamKetNoi();
            SqlCommand cmd = new SqlCommand("DoanhThu_Thang_MotMatHang", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@NgayBD", SqlDbType.DateTime);
            cmd.Parameters.Add("@NgayKT", SqlDbType.DateTime);
            cmd.Parameters.Add("@SanPham", SqlDbType.NVarChar, 50);
            //Gán giá trị:
            cmd.Parameters["@NgayBD"].Value = ngayBD;
            cmd.Parameters["@NgayKT"].Value = ngayKT;
            cmd.Parameters["@SanPham"].Value = sanPham;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dtb = new DataTable();
            da.Fill(dtb);
            return dtb;
        }
    }
}


