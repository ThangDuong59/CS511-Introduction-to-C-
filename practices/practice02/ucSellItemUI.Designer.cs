namespace practice02
{
    partial class ucSellItemUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucSellItemUI));
            this.pictureBox_ucSellItemUIScreen_itemPic = new System.Windows.Forms.PictureBox();
            this.labelValue_ucSellItemUIScreen_title = new System.Windows.Forms.Label();
            this.labelText_ucSellItemUIScreen_price = new System.Windows.Forms.Label();
            this.labelValue_ucSellItemUIScreen_price = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_ucSellItemUIScreen_itemPic)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_ucSellItemUIScreen_itemPic
            // 
            this.pictureBox_ucSellItemUIScreen_itemPic.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_ucSellItemUIScreen_itemPic.Image")));
            this.pictureBox_ucSellItemUIScreen_itemPic.Location = new System.Drawing.Point(0, 0);
            this.pictureBox_ucSellItemUIScreen_itemPic.Name = "pictureBox_ucSellItemUIScreen_itemPic";
            this.pictureBox_ucSellItemUIScreen_itemPic.Size = new System.Drawing.Size(182, 152);
            this.pictureBox_ucSellItemUIScreen_itemPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_ucSellItemUIScreen_itemPic.TabIndex = 0;
            this.pictureBox_ucSellItemUIScreen_itemPic.TabStop = false;
            // 
            // labelValue_ucSellItemUIScreen_title
            // 
            this.labelValue_ucSellItemUIScreen_title.Font = new System.Drawing.Font("Century Gothic", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelValue_ucSellItemUIScreen_title.Location = new System.Drawing.Point(3, 155);
            this.labelValue_ucSellItemUIScreen_title.Name = "labelValue_ucSellItemUIScreen_title";
            this.labelValue_ucSellItemUIScreen_title.Size = new System.Drawing.Size(176, 39);
            this.labelValue_ucSellItemUIScreen_title.TabIndex = 1;
            this.labelValue_ucSellItemUIScreen_title.Text = "Áo khoác Hoodie Nỉ Hình Mặt Buồn Xanh Rêu Siêu Lạ";
            // 
            // labelText_ucSellItemUIScreen_price
            // 
            this.labelText_ucSellItemUIScreen_price.AutoSize = true;
            this.labelText_ucSellItemUIScreen_price.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelText_ucSellItemUIScreen_price.ForeColor = System.Drawing.Color.Red;
            this.labelText_ucSellItemUIScreen_price.Location = new System.Drawing.Point(3, 194);
            this.labelText_ucSellItemUIScreen_price.Name = "labelText_ucSellItemUIScreen_price";
            this.labelText_ucSellItemUIScreen_price.Size = new System.Drawing.Size(36, 16);
            this.labelText_ucSellItemUIScreen_price.TabIndex = 2;
            this.labelText_ucSellItemUIScreen_price.Text = "Giá:";
            // 
            // labelValue_ucSellItemUIScreen_price
            // 
            this.labelValue_ucSellItemUIScreen_price.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelValue_ucSellItemUIScreen_price.ForeColor = System.Drawing.Color.Tomato;
            this.labelValue_ucSellItemUIScreen_price.Location = new System.Drawing.Point(45, 194);
            this.labelValue_ucSellItemUIScreen_price.Name = "labelValue_ucSellItemUIScreen_price";
            this.labelValue_ucSellItemUIScreen_price.Size = new System.Drawing.Size(152, 16);
            this.labelValue_ucSellItemUIScreen_price.TabIndex = 3;
            this.labelValue_ucSellItemUIScreen_price.Text = "1.000.000đ";
            // 
            // ucSellItemUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.labelValue_ucSellItemUIScreen_price);
            this.Controls.Add(this.labelText_ucSellItemUIScreen_price);
            this.Controls.Add(this.labelValue_ucSellItemUIScreen_title);
            this.Controls.Add(this.pictureBox_ucSellItemUIScreen_itemPic);
            this.Name = "ucSellItemUI";
            this.Size = new System.Drawing.Size(182, 223);
            this.Load += new System.EventHandler(this.ucSellItemUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_ucSellItemUIScreen_itemPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_ucSellItemUIScreen_itemPic;
        private System.Windows.Forms.Label labelValue_ucSellItemUIScreen_title;
        private System.Windows.Forms.Label labelText_ucSellItemUIScreen_price;
        private System.Windows.Forms.Label labelValue_ucSellItemUIScreen_price;
    }
}
