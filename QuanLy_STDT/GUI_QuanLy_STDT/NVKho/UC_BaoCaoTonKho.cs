using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;
namespace GUI_QuanLy_STDT.NVKho
{
    public partial class UC_BaoCaoTonKho : UserControl
    {


        public UC_BaoCaoTonKho()
        {
            InitializeComponent();


        }
        private void cb_loaiSP_click(object sender, EventArgs e)
        {
            if (tbMaSanPham.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập mã sản phẩm");

            }
            else
            {
                dgv_Temp.DataSource = SanPhamNVK_BUS.ThongTinSP(int.Parse(tbMaSanPham.Text));
            }
        }
        

        private void BtnThem_Click(object sender, EventArgs e)
        {
            kho_DTO kho = new kho_DTO();
            kho.TenSP = tbTenSanPham.Text;
            kho.Gia = int.Parse( tbGia.Text);
            kho.HangSX = cbHangSanXuat.Text;
            kho.ThoiGianBaoHanh = tbThoiGianBaoHanh.Text;
            kho.XuatXu = tbXuatXu.Text;
            kho.MoTaThem = tbMoTa.Text;
            kho.HeDieuHanh = "";
            kho.KichThuoc = "";
            kho.LoaiSP = "";
            kho.ThoiGianBaoHanh = "";
            kho.SoLuong = int.Parse(tbSoLuong.Text);
            khoNVkho_Bus.ThemSP(kho);
            MessageBox.Show("Thêm sản phẩm mới vào kho thành công!");

        }

        private void tbTimKiemTenSP_TextChanged(object sender, EventArgs e)
        {
        }

        private void dgvSanPham_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void dgv_Temp_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
