using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;
using System.Data.SqlClient;
//using System.Text.RegularExpressions;

namespace DAO
{  
    public class NhanVienBaoHanhDAO
    {
        /// them đơn bảo hành
        public static void ThemDonBaoHanh(SANPHAMDTO dbh)

        {
            SqlConnection cnn = sqlconnectionData.hamKetNoi();
           
            SqlCommand cmd = new SqlCommand("Them_san_pham_bao_hanh", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MaSP", SqlDbType.Int);
            cmd.Parameters.Add("@MaKH", SqlDbType.Int);
            cmd.Parameters.Add("@TinhTrang", SqlDbType.NVarChar, 100);
            cmd.Parameters.Add("@MaNCC",SqlDbType.Int);
            cmd.Parameters.Add("@NgayBaoHanh", SqlDbType.DateTime);
            cmd.Parameters.Add("@HinhThucBH", SqlDbType.NVarChar, 5);
            //gán giá trị
            cmd.Parameters["@MaSP"].Value =dbh.MaSP1;
            cmd.Parameters["@MaKH"].Value = dbh.MaKH1;
            cmd.Parameters["@TinhTrang"].Value = dbh.TinhTrang1;
            cmd.Parameters["@MaNCC"].Value = dbh.MaNCC1;
            cmd.Parameters["@NgayBaoHanh"].Value = dbh.NgayBaoHanh1;
            cmd.Parameters["@HinhThucBH"].Value = dbh.HinhThucBH1;
            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();           
        }
        
        public static DataTable ThongKeSPBaoHanh( DateTime NgayBaoHanh)
        {
            SqlConnection cnn = sqlconnectionData.hamKetNoi();
            SqlCommand cmd = new SqlCommand("ThongKe_SP_BaoHanh", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@NgayBaoHanh", SqlDbType.DateTime);
            cmd.Parameters["@NgayBaoHanh"].Value = NgayBaoHanh;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dtb = new DataTable();
            da.Fill(dtb);
            return dtb;
        }

    }
}
