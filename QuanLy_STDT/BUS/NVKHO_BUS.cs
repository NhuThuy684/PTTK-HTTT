using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO;
using DAO;

namespace BUS
{
    public class SanPhamNVK_BUS
    {
        public static DataTable ThongTinSP(int masp)
        {
            return SANPHAMNVK_DAO.ThongTinSP(masp);
        }

    }
    public class khoNVkho_Bus
    {
        public static void ThemSP(kho_DTO kho)
        {
             KhoNVKho_DAO.ThemSP(kho);
        }
    }
}
