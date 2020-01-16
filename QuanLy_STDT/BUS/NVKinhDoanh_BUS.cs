using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAO;
using DTO;

namespace BUS
{
    public class NVKinhDoanh_BUS
    {
        public static DataTable ThongKe_Thang_TongHop(DateTime ngayBD, DateTime ngayKT)
        {
            return NVKinhDoanh_DAO.ThongKe_Thang_TongHop(ngayBD, ngayKT);
        }

        public static DataTable ThongKe_Thang_TungMatHang(DateTime ngayBD, DateTime ngayKT, string matHang)
        {
            return NVKinhDoanh_DAO.ThongKe_Thang_TungMatHang(ngayBD, ngayKT, matHang);
        }

        public static DataTable ThongKe_Thang_MotMatHang(DateTime ngayBD, DateTime ngayKT, string sanPham)
        {
            return NVKinhDoanh_DAO.ThongKe_Thang_MotMatHang(ngayBD, ngayKT, sanPham);
        }
    }
}
