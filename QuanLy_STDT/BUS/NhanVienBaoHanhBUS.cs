using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;
using DAO;

namespace BUS
{
  public class NhanVienBaoHanhBUS
    {
        // them don bao hanh
        public static void ThemDonBaoHanh(SANPHAMDTO dbh)
        {
            NhanVienBaoHanhDAO.ThemDonBaoHanh(dbh);
        }
        public static DataTable ThongKeSPBaoHanh(DateTime NgayBaoHanh)
        {
            return NhanVienBaoHanhDAO.ThongKeSPBaoHanh(NgayBaoHanh);
        }
    }
}
