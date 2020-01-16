namespace GUI_QuanLy_STDT.UC_NVKinhDoanh
{
    partial class UC_BaoCaoDoanhThu
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_BaoCaoDoanhThu));
            this.txt_BaoCaoDoanhThu = new System.Windows.Forms.Label();
            this.button_TKTongHop = new System.Windows.Forms.Button();
            this.button_TKTungMatHang = new System.Windows.Forms.Button();
            this.button_TKMotMatHang = new System.Windows.Forms.Button();
            this.dataGridView_BCDoanhThu = new System.Windows.Forms.DataGridView();
            this.dateTimePicker_NgayBD = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_NgayKT = new System.Windows.Forms.DateTimePicker();
            this.comboBox_MatHang = new System.Windows.Forms.ComboBox();
            this.comboBox_SanPham = new System.Windows.Forms.ComboBox();
            this.label_NgayBD = new System.Windows.Forms.Label();
            this.label_Den = new System.Windows.Forms.Label();
            this.label_MatHang = new System.Windows.Forms.Label();
            this.label_SanPham = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.qL_SieuThi_DienThoaiDataSet = new GUI_QuanLy_STDT.QL_SieuThi_DienThoaiDataSet();
            this.qLSieuThiDienThoaiDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_BCDoanhThu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_SieuThi_DienThoaiDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLSieuThiDienThoaiDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_BaoCaoDoanhThu
            // 
            this.txt_BaoCaoDoanhThu.AutoSize = true;
            this.txt_BaoCaoDoanhThu.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_BaoCaoDoanhThu.Location = new System.Drawing.Point(370, 23);
            this.txt_BaoCaoDoanhThu.Name = "txt_BaoCaoDoanhThu";
            this.txt_BaoCaoDoanhThu.Size = new System.Drawing.Size(589, 36);
            this.txt_BaoCaoDoanhThu.TabIndex = 1;
            this.txt_BaoCaoDoanhThu.Text = "BÁO CÁO DOANH THU THEO THÁNG";
            // 
            // button_TKTongHop
            // 
            this.button_TKTongHop.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_TKTongHop.Location = new System.Drawing.Point(151, 255);
            this.button_TKTongHop.Name = "button_TKTongHop";
            this.button_TKTongHop.Size = new System.Drawing.Size(233, 59);
            this.button_TKTongHop.TabIndex = 6;
            this.button_TKTongHop.Text = "Doanh thu tổng hợp";
            this.button_TKTongHop.UseVisualStyleBackColor = true;
            this.button_TKTongHop.Click += new System.EventHandler(this.button_TKTongHop_Click);
            // 
            // button_TKTungMatHang
            // 
            this.button_TKTungMatHang.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_TKTungMatHang.Location = new System.Drawing.Point(151, 352);
            this.button_TKTungMatHang.Name = "button_TKTungMatHang";
            this.button_TKTungMatHang.Size = new System.Drawing.Size(233, 59);
            this.button_TKTungMatHang.TabIndex = 7;
            this.button_TKTungMatHang.Text = "Doanh thu theo từng mặt hàng";
            this.button_TKTungMatHang.UseVisualStyleBackColor = true;
            this.button_TKTungMatHang.Click += new System.EventHandler(this.button_TKTungMatHang_Click);
            // 
            // button_TKMotMatHang
            // 
            this.button_TKMotMatHang.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_TKMotMatHang.Location = new System.Drawing.Point(151, 450);
            this.button_TKMotMatHang.Name = "button_TKMotMatHang";
            this.button_TKMotMatHang.Size = new System.Drawing.Size(233, 59);
            this.button_TKMotMatHang.TabIndex = 8;
            this.button_TKMotMatHang.Text = "Doanh thu của một mặt hàng\r\n \r\n";
            this.button_TKMotMatHang.UseVisualStyleBackColor = true;
            this.button_TKMotMatHang.Click += new System.EventHandler(this.button_TKMotMatHang_Click);
            // 
            // dataGridView_BCDoanhThu
            // 
            this.dataGridView_BCDoanhThu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_BCDoanhThu.Location = new System.Drawing.Point(454, 223);
            this.dataGridView_BCDoanhThu.Name = "dataGridView_BCDoanhThu";
            this.dataGridView_BCDoanhThu.Size = new System.Drawing.Size(689, 286);
            this.dataGridView_BCDoanhThu.TabIndex = 9;
            // 
            // dateTimePicker_NgayBD
            // 
            this.dateTimePicker_NgayBD.CalendarFont = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker_NgayBD.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker_NgayBD.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_NgayBD.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dateTimePicker_NgayBD.Location = new System.Drawing.Point(454, 114);
            this.dateTimePicker_NgayBD.Name = "dateTimePicker_NgayBD";
            this.dateTimePicker_NgayBD.Size = new System.Drawing.Size(170, 26);
            this.dateTimePicker_NgayBD.TabIndex = 10;
            this.dateTimePicker_NgayBD.Value = new System.DateTime(2019, 1, 1, 0, 0, 0, 0);
            // 
            // dateTimePicker_NgayKT
            // 
            this.dateTimePicker_NgayKT.CalendarFont = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker_NgayKT.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker_NgayKT.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_NgayKT.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dateTimePicker_NgayKT.Location = new System.Drawing.Point(454, 175);
            this.dateTimePicker_NgayKT.Name = "dateTimePicker_NgayKT";
            this.dateTimePicker_NgayKT.Size = new System.Drawing.Size(170, 26);
            this.dateTimePicker_NgayKT.TabIndex = 11;
            this.dateTimePicker_NgayKT.Value = new System.DateTime(2019, 1, 1, 0, 0, 0, 0);
            // 
            // comboBox_MatHang
            // 
            this.comboBox_MatHang.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_MatHang.FormattingEnabled = true;
            this.comboBox_MatHang.Items.AddRange(new object[] {
            "ĐTDĐ",
            "Phụ kiện"});
            this.comboBox_MatHang.Location = new System.Drawing.Point(676, 174);
            this.comboBox_MatHang.Name = "comboBox_MatHang";
            this.comboBox_MatHang.Size = new System.Drawing.Size(187, 27);
            this.comboBox_MatHang.TabIndex = 12;
            // 
            // comboBox_SanPham
            // 
            this.comboBox_SanPham.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_SanPham.FormattingEnabled = true;
            this.comboBox_SanPham.Items.AddRange(new object[] {
            "SamSung Galaxy S9",
            "SamSung Galaxy J7",
            "SamSung Galaxy A7",
            "OPPO F1s",
            "IPhone X",
            "IPhone 8",
            "Tai nghe Sony WH",
            "Tai nghe Sony cao cấp Z1R",
            "Sạc dự phòng Mi",
            "Thẻ nhớ AZF1",
            "Sạc dự phòng Sony A43"});
            this.comboBox_SanPham.Location = new System.Drawing.Point(914, 174);
            this.comboBox_SanPham.Name = "comboBox_SanPham";
            this.comboBox_SanPham.Size = new System.Drawing.Size(229, 27);
            this.comboBox_SanPham.TabIndex = 13;
            // 
            // label_NgayBD
            // 
            this.label_NgayBD.AutoSize = true;
            this.label_NgayBD.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_NgayBD.Location = new System.Drawing.Point(450, 92);
            this.label_NgayBD.Name = "label_NgayBD";
            this.label_NgayBD.Size = new System.Drawing.Size(70, 19);
            this.label_NgayBD.TabIndex = 14;
            this.label_NgayBD.Text = "Từ ngày:";
            // 
            // label_Den
            // 
            this.label_Den.AutoSize = true;
            this.label_Den.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Den.Location = new System.Drawing.Point(450, 153);
            this.label_Den.Name = "label_Den";
            this.label_Den.Size = new System.Drawing.Size(73, 19);
            this.label_Den.TabIndex = 15;
            this.label_Den.Text = "Đến ngày";
            // 
            // label_MatHang
            // 
            this.label_MatHang.AutoSize = true;
            this.label_MatHang.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_MatHang.Location = new System.Drawing.Point(672, 152);
            this.label_MatHang.Name = "label_MatHang";
            this.label_MatHang.Size = new System.Drawing.Size(79, 19);
            this.label_MatHang.TabIndex = 16;
            this.label_MatHang.Text = "Mặt hàng:";
            // 
            // label_SanPham
            // 
            this.label_SanPham.AutoSize = true;
            this.label_SanPham.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_SanPham.Location = new System.Drawing.Point(910, 153);
            this.label_SanPham.Name = "label_SanPham";
            this.label_SanPham.Size = new System.Drawing.Size(74, 19);
            this.label_SanPham.TabIndex = 17;
            this.label_SanPham.Text = "Sản phẩm";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(151, 76);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(214, 151);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // qL_SieuThi_DienThoaiDataSet
            // 
            this.qL_SieuThi_DienThoaiDataSet.DataSetName = "QL_SieuThi_DienThoaiDataSet";
            this.qL_SieuThi_DienThoaiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // qLSieuThiDienThoaiDataSetBindingSource
            // 
            this.qLSieuThiDienThoaiDataSetBindingSource.DataSource = this.qL_SieuThi_DienThoaiDataSet;
            this.qLSieuThiDienThoaiDataSetBindingSource.Position = 0;
            // 
            // UC_BaoCaoDoanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label_SanPham);
            this.Controls.Add(this.label_MatHang);
            this.Controls.Add(this.label_Den);
            this.Controls.Add(this.label_NgayBD);
            this.Controls.Add(this.comboBox_SanPham);
            this.Controls.Add(this.comboBox_MatHang);
            this.Controls.Add(this.dateTimePicker_NgayKT);
            this.Controls.Add(this.dateTimePicker_NgayBD);
            this.Controls.Add(this.dataGridView_BCDoanhThu);
            this.Controls.Add(this.button_TKMotMatHang);
            this.Controls.Add(this.button_TKTungMatHang);
            this.Controls.Add(this.button_TKTongHop);
            this.Controls.Add(this.txt_BaoCaoDoanhThu);
            this.Name = "UC_BaoCaoDoanhThu";
            this.Size = new System.Drawing.Size(1320, 580);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_BCDoanhThu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_SieuThi_DienThoaiDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLSieuThiDienThoaiDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label txt_BaoCaoDoanhThu;
        private System.Windows.Forms.Button button_TKTongHop;
        private System.Windows.Forms.Button button_TKTungMatHang;
        private System.Windows.Forms.Button button_TKMotMatHang;
        private System.Windows.Forms.DataGridView dataGridView_BCDoanhThu;
        private System.Windows.Forms.DateTimePicker dateTimePicker_NgayBD;
        private System.Windows.Forms.DateTimePicker dateTimePicker_NgayKT;
        private System.Windows.Forms.ComboBox comboBox_MatHang;
        private System.Windows.Forms.ComboBox comboBox_SanPham;
        private System.Windows.Forms.Label label_NgayBD;
        private System.Windows.Forms.Label label_Den;
        private System.Windows.Forms.Label label_MatHang;
        private System.Windows.Forms.Label label_SanPham;
        private System.Windows.Forms.PictureBox pictureBox1;
        private QL_SieuThi_DienThoaiDataSet qL_SieuThi_DienThoaiDataSet;
        private System.Windows.Forms.BindingSource qLSieuThiDienThoaiDataSetBindingSource;
    }
}
