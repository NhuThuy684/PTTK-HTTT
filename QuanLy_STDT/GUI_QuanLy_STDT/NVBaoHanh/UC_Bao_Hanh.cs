using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using BUS;
using DTO;


namespace GUI_QuanLy_STDT.NVBaoHanh
{
    public partial class UC_Bao_Hanh : UserControl
    {
        public UC_Bao_Hanh()
        {
            InitializeComponent();
        }

        private void UC_Bao_Hanh_Load(object sender, EventArgs e)
        {

        }

        
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button_Click(object sender, EventArgs e)
        {

        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormMain n = new FormMain();
            n.ShowDialog();
            //this.close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            SANPHAMDTO dbh = new SANPHAMDTO();
            dbh.MaSP1 = int.Parse(txtMaSP.Text);
            dbh.MaKH1 = int.Parse(txtMaKH.Text);
            dbh.TinhTrang1 = txtTinhTrangBH.Text;
            dbh.MaNCC1 = int.Parse(txtMaNCC.Text);                            
            dbh.NgayBaoHanh1 = txtNgayBaoHanh.Value;
            dbh.HinhThucBH1 = txtHinhThuc.Text;
            NhanVienBaoHanhBUS.ThemDonBaoHanh(dbh);
            MessageBox.Show("Đã thêm thành công", "Thông báo");

        }

        
        private void btnThongKe_Click(object sender, EventArgs e)
        {
            try
            { 
                dataGridView1.DataSource = NhanVienBaoHanhBUS.ThongKeSPBaoHanh(txtNgayBaoHanh.Value);
            }
            catch(Exception ex)
                {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
    
