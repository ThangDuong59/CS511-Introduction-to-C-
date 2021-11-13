namespace practice02
{
    partial class ucMyOrderScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucMyOrderScreen));
            this.panel_ucMyOrderScreen_title = new System.Windows.Forms.Panel();
            this.labelText_ucMyOrderScreen_title = new System.Windows.Forms.Label();
            this.flowLayoutPanel_ucMyOrderScreen = new System.Windows.Forms.FlowLayoutPanel();
            this.labelText_ucMyOrderScreen_totalPrice = new System.Windows.Forms.Label();
            this.labelValue_ucMyOrderScreen_totalPrice = new System.Windows.Forms.Label();
            this.button_ucMyOrderScreen_paying = new System.Windows.Forms.Button();
            this.pictureBox_ucMyOrderScreen_trash = new System.Windows.Forms.PictureBox();
            this.panel_ucMyOrderScreen_title.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_ucMyOrderScreen_trash)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_ucMyOrderScreen_title
            // 
            this.panel_ucMyOrderScreen_title.BackColor = System.Drawing.Color.Thistle;
            this.panel_ucMyOrderScreen_title.Controls.Add(this.labelText_ucMyOrderScreen_title);
            this.panel_ucMyOrderScreen_title.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_ucMyOrderScreen_title.Location = new System.Drawing.Point(0, 0);
            this.panel_ucMyOrderScreen_title.Name = "panel_ucMyOrderScreen_title";
            this.panel_ucMyOrderScreen_title.Size = new System.Drawing.Size(377, 45);
            this.panel_ucMyOrderScreen_title.TabIndex = 1;
            // 
            // labelText_ucMyOrderScreen_title
            // 
            this.labelText_ucMyOrderScreen_title.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelText_ucMyOrderScreen_title.ForeColor = System.Drawing.Color.Black;
            this.labelText_ucMyOrderScreen_title.Location = new System.Drawing.Point(98, 10);
            this.labelText_ucMyOrderScreen_title.Name = "labelText_ucMyOrderScreen_title";
            this.labelText_ucMyOrderScreen_title.Size = new System.Drawing.Size(186, 23);
            this.labelText_ucMyOrderScreen_title.TabIndex = 0;
            this.labelText_ucMyOrderScreen_title.Text = "Giỏ hàng của bạn";
            this.labelText_ucMyOrderScreen_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel_ucMyOrderScreen
            // 
            this.flowLayoutPanel_ucMyOrderScreen.AutoScroll = true;
            this.flowLayoutPanel_ucMyOrderScreen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel_ucMyOrderScreen.Location = new System.Drawing.Point(0, 84);
            this.flowLayoutPanel_ucMyOrderScreen.Name = "flowLayoutPanel_ucMyOrderScreen";
            this.flowLayoutPanel_ucMyOrderScreen.Size = new System.Drawing.Size(407, 311);
            this.flowLayoutPanel_ucMyOrderScreen.TabIndex = 2;
            // 
            // labelText_ucMyOrderScreen_totalPrice
            // 
            this.labelText_ucMyOrderScreen_totalPrice.AutoSize = true;
            this.labelText_ucMyOrderScreen_totalPrice.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelText_ucMyOrderScreen_totalPrice.ForeColor = System.Drawing.Color.Red;
            this.labelText_ucMyOrderScreen_totalPrice.Location = new System.Drawing.Point(8, 455);
            this.labelText_ucMyOrderScreen_totalPrice.Name = "labelText_ucMyOrderScreen_totalPrice";
            this.labelText_ucMyOrderScreen_totalPrice.Size = new System.Drawing.Size(110, 25);
            this.labelText_ucMyOrderScreen_totalPrice.TabIndex = 4;
            this.labelText_ucMyOrderScreen_totalPrice.Text = "Tổng tiền:";
            // 
            // labelValue_ucMyOrderScreen_totalPrice
            // 
            this.labelValue_ucMyOrderScreen_totalPrice.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelValue_ucMyOrderScreen_totalPrice.ForeColor = System.Drawing.Color.Red;
            this.labelValue_ucMyOrderScreen_totalPrice.Location = new System.Drawing.Point(133, 455);
            this.labelValue_ucMyOrderScreen_totalPrice.Name = "labelValue_ucMyOrderScreen_totalPrice";
            this.labelValue_ucMyOrderScreen_totalPrice.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelValue_ucMyOrderScreen_totalPrice.Size = new System.Drawing.Size(234, 25);
            this.labelValue_ucMyOrderScreen_totalPrice.TabIndex = 5;
            this.labelValue_ucMyOrderScreen_totalPrice.Text = "0đ";
            // 
            // button_ucMyOrderScreen_paying
            // 
            this.button_ucMyOrderScreen_paying.BackColor = System.Drawing.Color.Green;
            this.button_ucMyOrderScreen_paying.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ucMyOrderScreen_paying.ForeColor = System.Drawing.Color.White;
            this.button_ucMyOrderScreen_paying.Location = new System.Drawing.Point(102, 502);
            this.button_ucMyOrderScreen_paying.Name = "button_ucMyOrderScreen_paying";
            this.button_ucMyOrderScreen_paying.Size = new System.Drawing.Size(182, 46);
            this.button_ucMyOrderScreen_paying.TabIndex = 6;
            this.button_ucMyOrderScreen_paying.Text = "Thanh toán và đặt hàng";
            this.button_ucMyOrderScreen_paying.UseVisualStyleBackColor = false;
            this.button_ucMyOrderScreen_paying.Click += new System.EventHandler(this.button_click_ucMyOrderScreen_paying);
            // 
            // pictureBox_ucMyOrderScreen_trash
            // 
            this.pictureBox_ucMyOrderScreen_trash.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_ucMyOrderScreen_trash.Image")));
            this.pictureBox_ucMyOrderScreen_trash.Location = new System.Drawing.Point(348, 57);
            this.pictureBox_ucMyOrderScreen_trash.Name = "pictureBox_ucMyOrderScreen_trash";
            this.pictureBox_ucMyOrderScreen_trash.Size = new System.Drawing.Size(21, 21);
            this.pictureBox_ucMyOrderScreen_trash.TabIndex = 7;
            this.pictureBox_ucMyOrderScreen_trash.TabStop = false;
            this.pictureBox_ucMyOrderScreen_trash.Click += new System.EventHandler(this.pictureBox_click_ucMyOrderScreen_trash);
            // 
            // ucMyOrderScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pictureBox_ucMyOrderScreen_trash);
            this.Controls.Add(this.button_ucMyOrderScreen_paying);
            this.Controls.Add(this.labelValue_ucMyOrderScreen_totalPrice);
            this.Controls.Add(this.labelText_ucMyOrderScreen_totalPrice);
            this.Controls.Add(this.flowLayoutPanel_ucMyOrderScreen);
            this.Controls.Add(this.panel_ucMyOrderScreen_title);
            this.Name = "ucMyOrderScreen";
            this.Size = new System.Drawing.Size(377, 560);
            this.panel_ucMyOrderScreen_title.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_ucMyOrderScreen_trash)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_ucMyOrderScreen_title;
        private System.Windows.Forms.Label labelText_ucMyOrderScreen_title;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_ucMyOrderScreen;
        private System.Windows.Forms.Label labelText_ucMyOrderScreen_totalPrice;
        private System.Windows.Forms.Label labelValue_ucMyOrderScreen_totalPrice;
        private System.Windows.Forms.Button button_ucMyOrderScreen_paying;
        private System.Windows.Forms.PictureBox pictureBox_ucMyOrderScreen_trash;
    }
}
