using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class SANPHAMDTO

    {
        private int MaDBH;
        private int MaSP;
        private int MaKH;
        private string TinhTrang;
        private int MaNCC;
        private DateTime NgayBaoHanh;
        private string HinhThucBH;
        

        public int MaDBH1 { get => MaDBH; set => MaDBH = value; }
        public int MaSP1 { get => MaSP; set => MaSP = value; }
        public int MaKH1 { get => MaKH; set => MaKH = value; }
        public string TinhTrang1 { get => TinhTrang; set => TinhTrang = value; }
        public int MaNCC1 { get => MaNCC; set => MaNCC = value; }
        public DateTime NgayBaoHanh1 { get => NgayBaoHanh; set => NgayBaoHanh = value; }
        public string HinhThucBH1 { get => HinhThucBH; set => HinhThucBH = value; }
    }  
}
