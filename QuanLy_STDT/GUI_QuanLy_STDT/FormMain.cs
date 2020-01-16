using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;


using GUI_QuanLy_STDT.UC_NVKinhDoanh;
using GUI_QuanLy_STDT.NVBaoHanh;
using GUI_QuanLy_STDT.UC_MuaHang;
using GUI_QuanLy_STDT.NVKho;

namespace GUI_QuanLy_STDT
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
           
        }
        private static FormMain _formMain;

        public static FormMain formMain
        {
            get
            {
                if (_formMain == null)
                {
                    _formMain = new FormMain();
                }
                return _formMain;
            }
        }

        //private void FormMain_Load(object sender, EventArgs e)
        //{
            
        //    UserControl us = new uc_LapHoaDon();
        //    showControl(us);
        //}

        public void showControl(System.Windows.Forms.Control obj)
        {
            panelHome.Controls.Clear();
            obj.Dock = DockStyle.Fill;
            panelHome.Controls.Add(obj);
        }
     
        private void button_NVKinhDoanh_Click(object sender, EventArgs e)
        {
            UserControl us = new UC_BaoCaoDoanhThu();
            showControl(us);
        }

        private void button_NVThuNgan_Click(object sender, EventArgs e)
        {
            UserControl us = new uc_LapHoaDon();
            showControl(us);
        }

        private void button_NVBaoHanh_Click(object sender, EventArgs e)
        {
            UserControl us = new UC_Bao_Hanh();
            showControl(us);
        }

        private void button_NVThuKho_Click(object sender, EventArgs e)
        {
            UserControl us = new UC_BaoCaoTonKho();
            showControl(us);
        }
    }
}
