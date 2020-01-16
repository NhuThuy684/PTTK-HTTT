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
    public class SANPHAMNVK_DAO
    {
        public static DataTable ThongTinSP(int masp)
        {
            SqlConnection cnn = sqlconnectionData.hamKetNoi();
            SqlCommand cmd = new SqlCommand("TIMSP", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            //gán giá trị
            cmd.Parameters.Add("@MASP", SqlDbType.Int);
            cmd.Parameters["@MASP"].Value = masp;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dtb = new DataTable();
            da.Fill(dtb);
            return dtb;
        }
       
    }
    public class KhoNVKho_DAO
    {
        public static void ThemSP(kho_DTO k)
        {
            SqlConnection cnn = sqlconnectionData.hamKetNoi();
            SqlCommand cmd = new SqlCommand("ThemSP", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            //gán giá trị
            cmd.Parameters.Add("@tensp", SqlDbType.NVarChar,50);
            cmd.Parameters["@tensp"].Value = k.TenSP;

            cmd.Parameters.Add("@gia", SqlDbType.Int);
            cmd.Parameters["@gia"].Value = k.Gia;

            cmd.Parameters.Add("@tenhangsx", SqlDbType.NVarChar,50);
            cmd.Parameters["@tenhangsx"].Value = k.HangSX;

            cmd.Parameters.Add("@xuatxu", SqlDbType.NVarChar,20);
            cmd.Parameters["@xuatxu"].Value = k.XuatXu;

            cmd.Parameters.Add("@thoigianbaohanh", SqlDbType.NVarChar, 10);
            cmd.Parameters["@thoigianbaohanh"].Value = k.ThoiGianBaoHanh;

            cmd.Parameters.Add("@loaisp", SqlDbType.NVarChar, 20);
            cmd.Parameters["@loaisp"].Value = k.LoaiSP;

            cmd.Parameters.Add("@kichthuoc", SqlDbType.NVarChar, 10);
            cmd.Parameters["@kichthuoc"].Value = k.KichThuoc;

            cmd.Parameters.Add("@trongluong", SqlDbType.NVarChar,10);
            cmd.Parameters["@tensp"].Value = k.TrongLuong;

            cmd.Parameters.Add("@hedieuhanh", SqlDbType.NVarChar, 10);
            cmd.Parameters["@hedieuhanh"].Value = k.HeDieuHanh;
            cmd.Parameters.Add("@motathem", SqlDbType.NVarChar,100);
            cmd.Parameters["@motathem"].Value = k.MoTaThem;

            cmd.Parameters.Add("@soluong", SqlDbType.Int);
            cmd.Parameters["@soluong"].Value = k.SoLuong;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }
    }
}
