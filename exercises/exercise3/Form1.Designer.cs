namespace exercise3
{
    partial class Hotel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Hotel));
            this.listView1 = new System.Windows.Forms.ListView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textbox_gia_phong = new System.Windows.Forms.TextBox();
            this.textbox_ma_phong = new System.Windows.Forms.TextBox();
            this.combobox_loai_phong = new System.Windows.Forms.ComboBox();
            this.numericupdown_so_ngay_o = new System.Windows.Forms.NumericUpDown();
            this.radiobutton_day = new System.Windows.Forms.RadioButton();
            this.radiobutton_trong = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button_thanh_toan = new System.Windows.Forms.Button();
            this.button_huy_phong = new System.Windows.Forms.Button();
            this.button_dat_phong = new System.Windows.Forms.Button();
            this.button_them_phong = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericupdown_so_ngay_o)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(309, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(860, 670);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listview1_itemselectionchange);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.textbox_gia_phong);
            this.groupBox1.Controls.Add(this.textbox_ma_phong);
            this.groupBox1.Controls.Add(this.combobox_loai_phong);
            this.groupBox1.Controls.Add(this.numericupdown_so_ngay_o);
            this.groupBox1.Controls.Add(this.radiobutton_day);
            this.groupBox1.Controls.Add(this.radiobutton_trong);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(5, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(298, 254);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // textbox_gia_phong
            // 
            this.textbox_gia_phong.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textbox_gia_phong.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_gia_phong.Location = new System.Drawing.Point(172, 116);
            this.textbox_gia_phong.Name = "textbox_gia_phong";
            this.textbox_gia_phong.Size = new System.Drawing.Size(120, 26);
            this.textbox_gia_phong.TabIndex = 12;
            this.textbox_gia_phong.Text = "0";
            // 
            // textbox_ma_phong
            // 
            this.textbox_ma_phong.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textbox_ma_phong.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_ma_phong.Location = new System.Drawing.Point(172, 33);
            this.textbox_ma_phong.Name = "textbox_ma_phong";
            this.textbox_ma_phong.ReadOnly = true;
            this.textbox_ma_phong.Size = new System.Drawing.Size(120, 26);
            this.textbox_ma_phong.TabIndex = 11;
            this.textbox_ma_phong.Text = "A1";
            // 
            // combobox_loai_phong
            // 
            this.combobox_loai_phong.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combobox_loai_phong.FormattingEnabled = true;
            this.combobox_loai_phong.Items.AddRange(new object[] {
            "A",
            "B",
            "C"});
            this.combobox_loai_phong.Location = new System.Drawing.Point(172, 75);
            this.combobox_loai_phong.Name = "combobox_loai_phong";
            this.combobox_loai_phong.Size = new System.Drawing.Size(120, 26);
            this.combobox_loai_phong.TabIndex = 10;
            this.combobox_loai_phong.Text = "A";
            // 
            // numericupdown_so_ngay_o
            // 
            this.numericupdown_so_ngay_o.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericupdown_so_ngay_o.Location = new System.Drawing.Point(172, 222);
            this.numericupdown_so_ngay_o.Name = "numericupdown_so_ngay_o";
            this.numericupdown_so_ngay_o.Size = new System.Drawing.Size(120, 26);
            this.numericupdown_so_ngay_o.TabIndex = 3;
            // 
            // radiobutton_day
            // 
            this.radiobutton_day.AutoSize = true;
            this.radiobutton_day.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radiobutton_day.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.radiobutton_day.Location = new System.Drawing.Point(201, 187);
            this.radiobutton_day.Name = "radiobutton_day";
            this.radiobutton_day.Size = new System.Drawing.Size(56, 22);
            this.radiobutton_day.TabIndex = 8;
            this.radiobutton_day.Text = "Đầy";
            this.radiobutton_day.UseVisualStyleBackColor = true;
            // 
            // radiobutton_trong
            // 
            this.radiobutton_trong.AutoSize = true;
            this.radiobutton_trong.Checked = true;
            this.radiobutton_trong.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radiobutton_trong.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.radiobutton_trong.Location = new System.Drawing.Point(201, 159);
            this.radiobutton_trong.Name = "radiobutton_trong";
            this.radiobutton_trong.Size = new System.Drawing.Size(76, 22);
            this.radiobutton_trong.TabIndex = 7;
            this.radiobutton_trong.TabStop = true;
            this.radiobutton_trong.Text = "Trống";
            this.radiobutton_trong.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label6.Location = new System.Drawing.Point(7, 224);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 18);
            this.label6.TabIndex = 5;
            this.label6.Text = "Số ngày ở :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label5.Location = new System.Drawing.Point(7, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(188, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tình trạng phòng :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label4.Location = new System.Drawing.Point(7, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Giá phòng :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label3.Location = new System.Drawing.Point(7, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Loại phòng :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label2.Location = new System.Drawing.Point(7, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã phòng :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thông tin phòng";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Window;
            this.groupBox2.Controls.Add(this.button_thanh_toan);
            this.groupBox2.Controls.Add(this.button_huy_phong);
            this.groupBox2.Controls.Add(this.button_dat_phong);
            this.groupBox2.Controls.Add(this.button_them_phong);
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(5, 272);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(298, 195);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // button_thanh_toan
            // 
            this.button_thanh_toan.BackColor = System.Drawing.Color.SaddleBrown;
            this.button_thanh_toan.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_thanh_toan.ForeColor = System.Drawing.SystemColors.Window;
            this.button_thanh_toan.Location = new System.Drawing.Point(162, 143);
            this.button_thanh_toan.Name = "button_thanh_toan";
            this.button_thanh_toan.Size = new System.Drawing.Size(130, 35);
            this.button_thanh_toan.TabIndex = 18;
            this.button_thanh_toan.Text = "Thanh toán";
            this.button_thanh_toan.UseVisualStyleBackColor = false;
            this.button_thanh_toan.Click += new System.EventHandler(this.click_thanh_toan);
            // 
            // button_huy_phong
            // 
            this.button_huy_phong.BackColor = System.Drawing.Color.SaddleBrown;
            this.button_huy_phong.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_huy_phong.ForeColor = System.Drawing.SystemColors.Window;
            this.button_huy_phong.Location = new System.Drawing.Point(162, 102);
            this.button_huy_phong.Name = "button_huy_phong";
            this.button_huy_phong.Size = new System.Drawing.Size(130, 35);
            this.button_huy_phong.TabIndex = 17;
            this.button_huy_phong.Text = "Hủy phòng";
            this.button_huy_phong.UseVisualStyleBackColor = false;
            this.button_huy_phong.Click += new System.EventHandler(this.click_huy_phong);
            // 
            // button_dat_phong
            // 
            this.button_dat_phong.BackColor = System.Drawing.Color.SaddleBrown;
            this.button_dat_phong.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_dat_phong.ForeColor = System.Drawing.SystemColors.Window;
            this.button_dat_phong.Location = new System.Drawing.Point(162, 61);
            this.button_dat_phong.Name = "button_dat_phong";
            this.button_dat_phong.Size = new System.Drawing.Size(130, 35);
            this.button_dat_phong.TabIndex = 16;
            this.button_dat_phong.Text = "Đặt phòng";
            this.button_dat_phong.UseVisualStyleBackColor = false;
            this.button_dat_phong.Click += new System.EventHandler(this.click_dat_phong);
            // 
            // button_them_phong
            // 
            this.button_them_phong.BackColor = System.Drawing.Color.SaddleBrown;
            this.button_them_phong.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_them_phong.ForeColor = System.Drawing.SystemColors.Window;
            this.button_them_phong.Location = new System.Drawing.Point(162, 19);
            this.button_them_phong.Name = "button_them_phong";
            this.button_them_phong.Size = new System.Drawing.Size(130, 35);
            this.button_them_phong.TabIndex = 15;
            this.button_them_phong.Text = "Thêm phòng";
            this.button_them_phong.UseVisualStyleBackColor = false;
            this.button_them_phong.Click += new System.EventHandler(this.click_them_phong);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(6, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 169);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label7.Location = new System.Drawing.Point(6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 18);
            this.label7.TabIndex = 14;
            this.label7.Text = "Chức năng";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Room.png");
            // 
            // Hotel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(1181, 694);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Hotel";
            this.Text = "Hotel";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericupdown_so_ngay_o)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radiobutton_day;
        private System.Windows.Forms.RadioButton radiobutton_trong;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_thanh_toan;
        private System.Windows.Forms.Button button_huy_phong;
        private System.Windows.Forms.Button button_dat_phong;
        private System.Windows.Forms.Button button_them_phong;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox combobox_loai_phong;
        private System.Windows.Forms.NumericUpDown numericupdown_so_ngay_o;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TextBox textbox_gia_phong;
        private System.Windows.Forms.TextBox textbox_ma_phong;
    }
}