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

namespace GUI_QuanLy_STDT.UC_NVKinhDoanh
{
    public partial class UC_BaoCaoDoanhThu : UserControl
    {
        public UC_BaoCaoDoanhThu()
        {
            InitializeComponent();
        }

        private void button_TKTongHop_Click(object sender, EventArgs e)
        {
            try
            {
                if (dateTimePicker_NgayBD.Value <= dateTimePicker_NgayKT.Value)
                {
                    dataGridView_BCDoanhThu.DataSource = NVKinhDoanh_BUS.ThongKe_Thang_TongHop(dateTimePicker_NgayBD.Value, dateTimePicker_NgayKT.Value);
                    dataGridView_BCDoanhThu.Columns["DOANH THU THÁNG"].DefaultCellStyle.Format = "#,### dong";
                }
                else
                {
                    MessageBox.Show("Thông tin ngày bạn nhập không hợp lệ!", "Thông báo");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi nhập 2 năm không giống nhau.Vui lòng kiểm tra lại!");
            }
        }

        private void button_TKTungMatHang_Click(object sender, EventArgs e)
        {
            try
            {
                if ((comboBox_MatHang.Text != "") && (dateTimePicker_NgayBD.Value <= dateTimePicker_NgayKT.Value))
                {
                    dataGridView_BCDoanhThu.DataSource = NVKinhDoanh_BUS.ThongKe_Thang_TungMatHang(dateTimePicker_NgayBD.Value, dateTimePicker_NgayKT.Value, comboBox_MatHang.Text);
                    dataGridView_BCDoanhThu.Columns["DOANH THU THÁNG"].DefaultCellStyle.Format = "#,### dong";
                }
                else
                {
                    MessageBox.Show("Thông tin bạn nhập chưa đầy đủ. Vui lòng kiểm tra lại!", "Thông báo");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi nhập 2 năm không giống nhau.Vui lòng kiểm tra lại!");
            }
        }

        private void button_TKMotMatHang_Click(object sender, EventArgs e)
        {
            try
            {
                if ((comboBox_SanPham.Text != "") && (dateTimePicker_NgayBD.Value <= dateTimePicker_NgayKT.Value))
                {
                    dataGridView_BCDoanhThu.DataSource = NVKinhDoanh_BUS.ThongKe_Thang_MotMatHang(dateTimePicker_NgayBD.Value, dateTimePicker_NgayKT.Value, comboBox_SanPham.Text);
                    dataGridView_BCDoanhThu.Columns["DOANH THU THÁNG"].DefaultCellStyle.Format = "#,### dong";
                }
                else
                {
                    MessageBox.Show("Thông tin bạn nhập chưa đầy đủ. Vui lòng kiểm tra lại!", "Thông báo");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi nhập 2 năm không giống nhau.Vui lòng kiểm tra lại!");
            }
        }

       
    }
}
