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
using System.Text.RegularExpressions;

namespace GUI_QuanLy_STDT.UC_MuaHang
{
    public partial class uc_LapHoaDon : UserControl
    {
        public uc_LapHoaDon()
        {
            InitializeComponent();
            
        }
        private void uc_LapHoaDon_Load(object sender, EventArgs e)
        {

            lb_NLHD.Text = DateTime.Now.ToShortDateString();
        }
        private void ReSet_Form(object sender, EventArgs e)
        {
             sender = new uc_LapHoaDon();
            
            this.Dispose(false);
        }




        string typeHD = "Lẻ";//loại hóa đơn ban đầu là lẻ



        //void Clear(Control Parent)
        //{
        //    //Group box 1
        //    tb_maKH.ResetText();
        //    tb_Coupon.ResetText();
        //    dgv_KhachHang.DataSource= null;


        //    // Group box 2
        //    dgv_HoaDon.DataSource=null;
        //    lb_ThongBao.Text = "[Mã HĐ]";
        //    lb_TongTien.Text = "0";

        //    //Group box 3
        //    tbTN_tenSP.ResetText();
        //    dgvTN_TimKiem.DataSource = null;

        //    //Group box 4
        //    tbTN_maSP.ResetText();
        //    tb_tenSP.ResetText();
        //    tbTN_donGia.Text = "0";
        //    tbTN_soLuong.Text = "0";
        //    lbTN_thanhTien.Text = "0";

        //}
        private void btTN_TimKiem_Click(object sender, EventArgs e)
        {
            switch (cb_loaiSP.Text)
            {
                case "Tất cả":
                    {
                        dgvTN_TimKiem.DataSource = SanPham_BUS.timKiemSanPham(tb_tenSP.Text, "");
                        break;
                    }
                case "Điện thoại":
                    {
                        dgvTN_TimKiem.DataSource = SanPham_BUS.timKiemSanPham(tb_tenSP.Text, "ĐTDĐ");
                        break;
                    }
                case "Phụ kiện":
                    {
                        dgvTN_TimKiem.DataSource = SanPham_BUS.timKiemSanPham(tb_tenSP.Text, cb_loaiSP.Text);
                        break;
                    }
                default:
                    {
                        dgvTN_TimKiem.DataSource = SanPham_BUS.timKiemSanPham(tb_tenSP.Text, "");
                        break;
                    }

            }

        }

        private void rBT_muaSi_CheckedChanged(object sender, EventArgs e)
        {
            if (rBT_muaSi.Checked == true)
                typeHD = "Sỉ";
            else typeHD = "Lẻ";
        }

        private void dgvTN_TimKiem_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           
                    dgvTN_TimKiem.CurrentRow.Selected = true;
                    
                     tbTN_maSP.Text = dgvTN_TimKiem.Rows[e.RowIndex].Cells["maSP"].FormattedValue.ToString();

                    tbTN_tenSP.Text = dgvTN_TimKiem.Rows[e.RowIndex].Cells["tenSP"].FormattedValue.ToString();
                    tbTN_soLuong.Text = "1";
                    tbTN_donGia.Text = dgvTN_TimKiem.Rows[e.RowIndex].Cells["gia"].FormattedValue.ToString();
            lbTN_thanhTien.Text = (double.Parse(tbTN_donGia.Text) * double.Parse(tbTN_soLuong.Text)).ToString();
        }

        private void dgv_HoaDon_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắm muốn xóa không?", "Đang xóa...", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int rowIndex = e.RowIndex;
                string temp = dgv_HoaDon.Rows[e.RowIndex].Cells[3].Value.ToString();
                lb_TongTien.Text = (int.Parse(lb_TongTien.Text) - int.Parse(temp)).ToString();
                dgv_HoaDon.Rows.RemoveAt(rowIndex);
            }
        }

        private void tbTN_soLuong_TextChanged(object sender, EventArgs e)
        {
            if (tbTN_soLuong.Text == "")
                tbTN_soLuong.Text = "0";
            lbTN_thanhTien.Text = (double.Parse(tbTN_donGia.Text) * double.Parse(tbTN_soLuong.Text)).ToString();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            try
            {
                if(tbTN_maSP.Text=="")
                {
                    MessageBox.Show("Bạn chưa chọn sản phẩm!", "Thông báo");
                }
                else
                {
                    //Load thông tin từ text box vào datagriview
                    dgv_HoaDon.AllowUserToAddRows = false;
                    dgv_HoaDon.Rows.Add(1);
                    int indexRow = dgv_HoaDon.Rows.Count - 1;
                    if (indexRow > 0)
                    {
                        for (int i = 0; i <= indexRow;)
                        {
                            if (dgv_HoaDon.Rows[i].Cells["masp2"].Value != null)
                            {
                                string temp = dgv_HoaDon.Rows[i].Cells["masp2"].Value.ToString();
                                if (temp == tbTN_maSP.Text)
                                {
                                    string tem1 = dgv_HoaDon.Rows[i].Cells["soluong2"].Value.ToString();
                                    string temp2 = dgv_HoaDon.Rows[i].Cells["dongia"].Value.ToString();
                                    string temp3 = dgv_HoaDon.Rows[i].Cells["tien"].Value.ToString();
                                    dgv_HoaDon[1, i].Value = int.Parse(tbTN_soLuong.Text) + int.Parse(tem1);
                                    dgv_HoaDon[2, i].Value = int.Parse(tbTN_donGia.Text) + int.Parse(temp2);
                                    dgv_HoaDon[3, i].Value = int.Parse(lbTN_thanhTien.Text) + int.Parse(temp3);
                                    //1
                                    dgv_HoaDon.Rows.RemoveAt(dgv_HoaDon.Rows[indexRow].Index);

                                    lb_TongTien.Text = (int.Parse(lb_TongTien.Text) + int.Parse(lbTN_thanhTien.Text)).ToString();
                                    //
                                    return;

                                }
                            }
                            i++;

                        }
                        dgv_HoaDon[0, indexRow].Value = tbTN_maSP.Text;
                        dgv_HoaDon[1, indexRow].Value = tbTN_soLuong.Text;
                        dgv_HoaDon[2, indexRow].Value = tbTN_donGia.Text;
                        dgv_HoaDon[3, indexRow].Value = lbTN_thanhTien.Text;
                    }
                    else
                    {
                        dgv_HoaDon[0, indexRow].Value = tbTN_maSP.Text;
                        dgv_HoaDon[1, indexRow].Value = tbTN_soLuong.Text;
                        dgv_HoaDon[2, indexRow].Value = tbTN_donGia.Text;
                        dgv_HoaDon[3, indexRow].Value = lbTN_thanhTien.Text;
                    }

                    //2
                    lb_TongTien.Text = (int.Parse(lb_TongTien.Text) + int.Parse(lbTN_thanhTien.Text)).ToString();

                }
            }
            catch
            {
                MessageBox.Show("Hệ thống mất kết nối, vui lòng quay lại sau!", "Thông báo");
            }

           }
        
       

        private void bt_kiemTra_Click(object sender, EventArgs e)
        {
            try
            {
                if (tb_maKH.Text=="")
                {
                    MessageBox.Show("Bạn chưa nhập mã khách hàng!", "Thông báo");
                }
                else
                {
                    if (tb_maKH.Text != "")
                    {
                        dgv_KhachHang.AllowUserToAddRows = false;


                        //dgv_KhachHang.DataSource = SanPham_BUS.kiemTraLoaiKH(int.Parse(tb_maKH.Text));
                        dgv_KhachHang.DataSource = KhachHang_BUS.tiLeGiamGia(int.Parse(tb_maKH.Text), tb_Coupon.Text, typeHD);
                        if (dgv_KhachHang.Rows.Count == 0)
                        {
                            MessageBox.Show("Mã khách hàng không tồn tại! Vui lòng kiểm tra lại!", "Thông báo");
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("Hệ thống mất kết nối, vui lòng quay lại sau!", "Thông báo");
                ReSet_Form(sender, e);
            }
        
        }

        private void bt_LapHoaDon_Click(object sender, EventArgs e)
        {
            try
            {
                if(dgv_HoaDon.Rows.Count==0 || tb_maKH.Text==""|| dgv_KhachHang.Rows.Count == 0)
                {
                    MessageBox.Show("Bạn chưa nhập mã khách hàng, hoặc hóa đơn chưa có mặt hàng!", "Thông báo");
                    
                }
                else
                {
                    string temp=dgv_KhachHang.Rows[0].Cells["tileGG"].Value.ToString();
                    dgv_DTB.DataSource = HoaDon_BUS.lapHoaDon(int.Parse(tb_maKH.Text), typeHD,float.Parse(temp) ,float.Parse(lb_TongTien.Text));

                    lb_ThongBao.Text = dgv_DTB[0, 0].Value.ToString();
                    for (int i = 0; i < dgv_HoaDon.Rows.Count; i++)
                    {

                        string masp = dgv_HoaDon.Rows[i].Cells["masp2"].Value.ToString();


                        string soLuong = dgv_HoaDon.Rows[i].Cells["soluong2"].Value.ToString();
                        string dongia = dgv_HoaDon.Rows[i].Cells["dongia"].Value.ToString();
                        string thanhtien = dgv_HoaDon.Rows[i].Cells["tien"].Value.ToString();
                        ChiTietHoaDon_BUS.InsertChiTietHoaDon(int.Parse(lb_ThongBao.Text), int.Parse(masp), int.Parse(soLuong), int.Parse(dongia), int.Parse(thanhtien));
                    }

                    MessageBox.Show("Thiết lập đơn hàng thành công!", "Thông báo");
                    ReSet_Form(sender, e);
                   
                }
               


            }
            catch
            {
                MessageBox.Show("Hệ thống mất kết nối, vui lòng quay lại sau!", "Thông báo");
                ReSet_Form(sender, e);
            }

          
        }


        private static bool IsNumber(string val)
        {
            if (val != "")
                return Regex.IsMatch(val, @"^[0-9]\d*\.?[0]*$");
            else return true;
        }
        private void tb_MaKH_Change(object sender, EventArgs e)
        {
            if (IsNumber(tb_maKH.Text) != true)
            {
                MessageBox.Show("Dữ liệu nhập không hợp lệ, không được nhập ký tự", "Thông báo");
                tb_maKH.Text = "";
            }
        }
        private void tbTN_soLuong_Change(object sender, EventArgs e)
        {
            if (IsNumber(tbTN_soLuong.Text) != true)
            {
                MessageBox.Show("Dữ liệu nhập không hợp lệ, không được nhập ký tự", "Thông báo");
                tbTN_soLuong.Text = "0";
            }
        }

        
    }
}
