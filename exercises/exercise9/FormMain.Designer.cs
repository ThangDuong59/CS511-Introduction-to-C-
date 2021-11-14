namespace exercise9
{
    partial class FormMain
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.pictureBox_webCam = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.labelText_title = new System.Windows.Forms.Label();
            this.pictureBox_category = new System.Windows.Forms.PictureBox();
            this.labelText_khachHang = new System.Windows.Forms.Label();
            this.textBox_khachHang = new System.Windows.Forms.TextBox();
            this.labelText_nhanVien = new System.Windows.Forms.Label();
            this.labelText_soHoaDon = new System.Windows.Forms.Label();
            this.labelText_ngayIn = new System.Windows.Forms.Label();
            this.textBox_nhanVien = new System.Windows.Forms.TextBox();
            this.textBox_soHoaDon = new System.Windows.Forms.TextBox();
            this.dateTimePicker_ngayIn = new System.Windows.Forms.DateTimePicker();
            this.textBox_thanhToan = new System.Windows.Forms.TextBox();
            this.textBox_khuyenMai = new System.Windows.Forms.TextBox();
            this.labelText_thanhToan = new System.Windows.Forms.Label();
            this.labelText_khuyenMai = new System.Windows.Forms.Label();
            this.textBox_tongTien = new System.Windows.Forms.TextBox();
            this.labelText_tongTien = new System.Windows.Forms.Label();
            this.pictureBox_report = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_webCam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_category)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_report)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_webCam
            // 
            this.pictureBox_webCam.Location = new System.Drawing.Point(391, 12);
            this.pictureBox_webCam.Name = "pictureBox_webCam";
            this.pictureBox_webCam.Size = new System.Drawing.Size(286, 215);
            this.pictureBox_webCam.TabIndex = 0;
            this.pictureBox_webCam.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_tick);
            // 
            // labelText_title
            // 
            this.labelText_title.AutoSize = true;
            this.labelText_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelText_title.ForeColor = System.Drawing.Color.Chocolate;
            this.labelText_title.Location = new System.Drawing.Point(107, 31);
            this.labelText_title.Name = "labelText_title";
            this.labelText_title.Size = new System.Drawing.Size(278, 31);
            this.labelText_title.TabIndex = 1;
            this.labelText_title.Text = "SIÊU THỊ KHÁNH AN";
            // 
            // pictureBox_category
            // 
            this.pictureBox_category.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_category.Image")));
            this.pictureBox_category.Location = new System.Drawing.Point(12, 12);
            this.pictureBox_category.Name = "pictureBox_category";
            this.pictureBox_category.Size = new System.Drawing.Size(89, 86);
            this.pictureBox_category.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_category.TabIndex = 2;
            this.pictureBox_category.TabStop = false;
            this.pictureBox_category.Click += new System.EventHandler(this.pictureBox_click_category);
            // 
            // labelText_khachHang
            // 
            this.labelText_khachHang.AutoSize = true;
            this.labelText_khachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelText_khachHang.ForeColor = System.Drawing.Color.DarkGreen;
            this.labelText_khachHang.Location = new System.Drawing.Point(9, 121);
            this.labelText_khachHang.Name = "labelText_khachHang";
            this.labelText_khachHang.Size = new System.Drawing.Size(99, 17);
            this.labelText_khachHang.TabIndex = 3;
            this.labelText_khachHang.Text = "Khách hàng:";
            // 
            // textBox_khachHang
            // 
            this.textBox_khachHang.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.textBox_khachHang.Location = new System.Drawing.Point(137, 121);
            this.textBox_khachHang.Name = "textBox_khachHang";
            this.textBox_khachHang.Size = new System.Drawing.Size(156, 20);
            this.textBox_khachHang.TabIndex = 4;
            this.textBox_khachHang.Text = "Chị Ngân";
            // 
            // labelText_nhanVien
            // 
            this.labelText_nhanVien.AutoSize = true;
            this.labelText_nhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelText_nhanVien.ForeColor = System.Drawing.Color.DarkGreen;
            this.labelText_nhanVien.Location = new System.Drawing.Point(9, 149);
            this.labelText_nhanVien.Name = "labelText_nhanVien";
            this.labelText_nhanVien.Size = new System.Drawing.Size(86, 17);
            this.labelText_nhanVien.TabIndex = 5;
            this.labelText_nhanVien.Text = "Nhân viên:";
            // 
            // labelText_soHoaDon
            // 
            this.labelText_soHoaDon.AutoSize = true;
            this.labelText_soHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelText_soHoaDon.ForeColor = System.Drawing.Color.DarkGreen;
            this.labelText_soHoaDon.Location = new System.Drawing.Point(9, 177);
            this.labelText_soHoaDon.Name = "labelText_soHoaDon";
            this.labelText_soHoaDon.Size = new System.Drawing.Size(96, 17);
            this.labelText_soHoaDon.TabIndex = 6;
            this.labelText_soHoaDon.Text = "Số hóa đơn:";
            // 
            // labelText_ngayIn
            // 
            this.labelText_ngayIn.AutoSize = true;
            this.labelText_ngayIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelText_ngayIn.ForeColor = System.Drawing.Color.DarkGreen;
            this.labelText_ngayIn.Location = new System.Drawing.Point(9, 207);
            this.labelText_ngayIn.Name = "labelText_ngayIn";
            this.labelText_ngayIn.Size = new System.Drawing.Size(68, 17);
            this.labelText_ngayIn.TabIndex = 7;
            this.labelText_ngayIn.Text = "Ngày in:";
            // 
            // textBox_nhanVien
            // 
            this.textBox_nhanVien.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.textBox_nhanVien.Location = new System.Drawing.Point(137, 149);
            this.textBox_nhanVien.Name = "textBox_nhanVien";
            this.textBox_nhanVien.Size = new System.Drawing.Size(156, 20);
            this.textBox_nhanVien.TabIndex = 8;
            this.textBox_nhanVien.Text = "Liêu Lam";
            // 
            // textBox_soHoaDon
            // 
            this.textBox_soHoaDon.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.textBox_soHoaDon.Location = new System.Drawing.Point(137, 177);
            this.textBox_soHoaDon.Name = "textBox_soHoaDon";
            this.textBox_soHoaDon.Size = new System.Drawing.Size(156, 20);
            this.textBox_soHoaDon.TabIndex = 9;
            this.textBox_soHoaDon.Text = "11124543";
            // 
            // dateTimePicker_ngayIn
            // 
            this.dateTimePicker_ngayIn.CustomFormat = "";
            this.dateTimePicker_ngayIn.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_ngayIn.Location = new System.Drawing.Point(137, 207);
            this.dateTimePicker_ngayIn.Name = "dateTimePicker_ngayIn";
            this.dateTimePicker_ngayIn.Size = new System.Drawing.Size(156, 20);
            this.dateTimePicker_ngayIn.TabIndex = 10;
            this.dateTimePicker_ngayIn.Value = new System.DateTime(2021, 11, 3, 0, 0, 0, 0);
            // 
            // textBox_thanhToan
            // 
            this.textBox_thanhToan.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.textBox_thanhToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_thanhToan.ForeColor = System.Drawing.Color.Red;
            this.textBox_thanhToan.Location = new System.Drawing.Point(137, 532);
            this.textBox_thanhToan.Name = "textBox_thanhToan";
            this.textBox_thanhToan.Size = new System.Drawing.Size(156, 20);
            this.textBox_thanhToan.TabIndex = 16;
            this.textBox_thanhToan.Text = "0";
            this.textBox_thanhToan.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox_khuyenMai
            // 
            this.textBox_khuyenMai.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.textBox_khuyenMai.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_khuyenMai.ForeColor = System.Drawing.Color.Blue;
            this.textBox_khuyenMai.Location = new System.Drawing.Point(137, 504);
            this.textBox_khuyenMai.Name = "textBox_khuyenMai";
            this.textBox_khuyenMai.Size = new System.Drawing.Size(156, 20);
            this.textBox_khuyenMai.TabIndex = 15;
            this.textBox_khuyenMai.Text = "0";
            this.textBox_khuyenMai.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelText_thanhToan
            // 
            this.labelText_thanhToan.AutoSize = true;
            this.labelText_thanhToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelText_thanhToan.ForeColor = System.Drawing.Color.DarkGreen;
            this.labelText_thanhToan.Location = new System.Drawing.Point(9, 532);
            this.labelText_thanhToan.Name = "labelText_thanhToan";
            this.labelText_thanhToan.Size = new System.Drawing.Size(96, 17);
            this.labelText_thanhToan.TabIndex = 14;
            this.labelText_thanhToan.Text = "Thanh toán:";
            // 
            // labelText_khuyenMai
            // 
            this.labelText_khuyenMai.AutoSize = true;
            this.labelText_khuyenMai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelText_khuyenMai.ForeColor = System.Drawing.Color.DarkGreen;
            this.labelText_khuyenMai.Location = new System.Drawing.Point(9, 504);
            this.labelText_khuyenMai.Name = "labelText_khuyenMai";
            this.labelText_khuyenMai.Size = new System.Drawing.Size(115, 17);
            this.labelText_khuyenMai.TabIndex = 13;
            this.labelText_khuyenMai.Text = "Khuyến mãi %:";
            // 
            // textBox_tongTien
            // 
            this.textBox_tongTien.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.textBox_tongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_tongTien.Location = new System.Drawing.Point(137, 476);
            this.textBox_tongTien.Name = "textBox_tongTien";
            this.textBox_tongTien.Size = new System.Drawing.Size(156, 20);
            this.textBox_tongTien.TabIndex = 12;
            this.textBox_tongTien.Text = "0";
            this.textBox_tongTien.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelText_tongTien
            // 
            this.labelText_tongTien.AutoSize = true;
            this.labelText_tongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelText_tongTien.ForeColor = System.Drawing.Color.DarkGreen;
            this.labelText_tongTien.Location = new System.Drawing.Point(9, 476);
            this.labelText_tongTien.Name = "labelText_tongTien";
            this.labelText_tongTien.Size = new System.Drawing.Size(82, 17);
            this.labelText_tongTien.TabIndex = 11;
            this.labelText_tongTien.Text = "Tổng tiền:";
            // 
            // pictureBox_report
            // 
            this.pictureBox_report.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox_report.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_report.Image")));
            this.pictureBox_report.Location = new System.Drawing.Point(587, 476);
            this.pictureBox_report.Name = "pictureBox_report";
            this.pictureBox_report.Size = new System.Drawing.Size(90, 76);
            this.pictureBox_report.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox_report.TabIndex = 17;
            this.pictureBox_report.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.Location = new System.Drawing.Point(12, 246);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(665, 214);
            this.dataGridView1.TabIndex = 18;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(689, 564);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox_report);
            this.Controls.Add(this.textBox_thanhToan);
            this.Controls.Add(this.textBox_khuyenMai);
            this.Controls.Add(this.labelText_thanhToan);
            this.Controls.Add(this.labelText_khuyenMai);
            this.Controls.Add(this.textBox_tongTien);
            this.Controls.Add(this.labelText_tongTien);
            this.Controls.Add(this.dateTimePicker_ngayIn);
            this.Controls.Add(this.textBox_soHoaDon);
            this.Controls.Add(this.textBox_nhanVien);
            this.Controls.Add(this.labelText_ngayIn);
            this.Controls.Add(this.labelText_soHoaDon);
            this.Controls.Add(this.labelText_nhanVien);
            this.Controls.Add(this.textBox_khachHang);
            this.Controls.Add(this.labelText_khachHang);
            this.Controls.Add(this.pictureBox_category);
            this.Controls.Add(this.labelText_title);
            this.Controls.Add(this.pictureBox_webCam);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thanh toán";
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_webCam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_category)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_report)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_webCam;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label labelText_title;
        private System.Windows.Forms.PictureBox pictureBox_category;
        private System.Windows.Forms.Label labelText_khachHang;
        private System.Windows.Forms.TextBox textBox_khachHang;
        private System.Windows.Forms.Label labelText_nhanVien;
        private System.Windows.Forms.Label labelText_soHoaDon;
        private System.Windows.Forms.Label labelText_ngayIn;
        private System.Windows.Forms.TextBox textBox_nhanVien;
        private System.Windows.Forms.TextBox textBox_soHoaDon;
        private System.Windows.Forms.DateTimePicker dateTimePicker_ngayIn;
        private System.Windows.Forms.TextBox textBox_thanhToan;
        private System.Windows.Forms.TextBox textBox_khuyenMai;
        private System.Windows.Forms.Label labelText_thanhToan;
        private System.Windows.Forms.Label labelText_khuyenMai;
        private System.Windows.Forms.TextBox textBox_tongTien;
        private System.Windows.Forms.Label labelText_tongTien;
        private System.Windows.Forms.PictureBox pictureBox_report;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

