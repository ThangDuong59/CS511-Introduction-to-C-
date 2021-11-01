namespace practice02
{
    partial class ucSearchScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucSearchScreen));
            this.panel_uciTech_menuTopBar = new System.Windows.Forms.Panel();
            this.panel_ucSearchScreen_searchBar = new System.Windows.Forms.Panel();
            this.textBox_ucSearchScreen_searchBar = new System.Windows.Forms.TextBox();
            this.pictureBox_ucSearchScreen_magnifiyingGlass = new System.Windows.Forms.PictureBox();
            this.button_ucSearchScreen_backArrow = new System.Windows.Forms.Button();
            this.button_ucSearchScreen_notification = new System.Windows.Forms.Button();
            this.flowLayoutPanel_ucSearchScreen = new System.Windows.Forms.FlowLayoutPanel();
            this.panel_uciTech_menuTopBar.SuspendLayout();
            this.panel_ucSearchScreen_searchBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_ucSearchScreen_magnifiyingGlass)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_uciTech_menuTopBar
            // 
            this.panel_uciTech_menuTopBar.BackColor = System.Drawing.Color.Thistle;
            this.panel_uciTech_menuTopBar.Controls.Add(this.button_ucSearchScreen_notification);
            this.panel_uciTech_menuTopBar.Controls.Add(this.button_ucSearchScreen_backArrow);
            this.panel_uciTech_menuTopBar.Controls.Add(this.panel_ucSearchScreen_searchBar);
            this.panel_uciTech_menuTopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_uciTech_menuTopBar.Location = new System.Drawing.Point(0, 0);
            this.panel_uciTech_menuTopBar.Name = "panel_uciTech_menuTopBar";
            this.panel_uciTech_menuTopBar.Size = new System.Drawing.Size(377, 49);
            this.panel_uciTech_menuTopBar.TabIndex = 1;
            // 
            // panel_ucSearchScreen_searchBar
            // 
            this.panel_ucSearchScreen_searchBar.BackColor = System.Drawing.Color.Gainsboro;
            this.panel_ucSearchScreen_searchBar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_ucSearchScreen_searchBar.Controls.Add(this.textBox_ucSearchScreen_searchBar);
            this.panel_ucSearchScreen_searchBar.Controls.Add(this.pictureBox_ucSearchScreen_magnifiyingGlass);
            this.panel_ucSearchScreen_searchBar.Location = new System.Drawing.Point(55, 9);
            this.panel_ucSearchScreen_searchBar.Name = "panel_ucSearchScreen_searchBar";
            this.panel_ucSearchScreen_searchBar.Size = new System.Drawing.Size(280, 29);
            this.panel_ucSearchScreen_searchBar.TabIndex = 3;
            // 
            // textBox_ucSearchScreen_searchBar
            // 
            this.textBox_ucSearchScreen_searchBar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_ucSearchScreen_searchBar.Location = new System.Drawing.Point(33, 2);
            this.textBox_ucSearchScreen_searchBar.Name = "textBox_ucSearchScreen_searchBar";
            this.textBox_ucSearchScreen_searchBar.Size = new System.Drawing.Size(242, 23);
            this.textBox_ucSearchScreen_searchBar.TabIndex = 1;
            this.textBox_ucSearchScreen_searchBar.Text = "Nhập sản phẩm bạn cần tìm...";
            // 
            // pictureBox_ucSearchScreen_magnifiyingGlass
            // 
            this.pictureBox_ucSearchScreen_magnifiyingGlass.BackColor = System.Drawing.Color.Gainsboro;
            this.pictureBox_ucSearchScreen_magnifiyingGlass.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_ucSearchScreen_magnifiyingGlass.Image")));
            this.pictureBox_ucSearchScreen_magnifiyingGlass.Location = new System.Drawing.Point(4, 2);
            this.pictureBox_ucSearchScreen_magnifiyingGlass.Name = "pictureBox_ucSearchScreen_magnifiyingGlass";
            this.pictureBox_ucSearchScreen_magnifiyingGlass.Size = new System.Drawing.Size(24, 22);
            this.pictureBox_ucSearchScreen_magnifiyingGlass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_ucSearchScreen_magnifiyingGlass.TabIndex = 4;
            this.pictureBox_ucSearchScreen_magnifiyingGlass.TabStop = false;
            // 
            // button_ucSearchScreen_backArrow
            // 
            this.button_ucSearchScreen_backArrow.FlatAppearance.BorderSize = 0;
            this.button_ucSearchScreen_backArrow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_ucSearchScreen_backArrow.Image = ((System.Drawing.Image)(resources.GetObject("button_ucSearchScreen_backArrow.Image")));
            this.button_ucSearchScreen_backArrow.Location = new System.Drawing.Point(12, 9);
            this.button_ucSearchScreen_backArrow.Name = "button_ucSearchScreen_backArrow";
            this.button_ucSearchScreen_backArrow.Size = new System.Drawing.Size(29, 29);
            this.button_ucSearchScreen_backArrow.TabIndex = 4;
            this.button_ucSearchScreen_backArrow.UseVisualStyleBackColor = true;
            this.button_ucSearchScreen_backArrow.Click += new System.EventHandler(this.button_click_ucSearchScreen_backArrow);
            // 
            // button_ucSearchScreen_notification
            // 
            this.button_ucSearchScreen_notification.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_ucSearchScreen_notification.BackgroundImage")));
            this.button_ucSearchScreen_notification.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_ucSearchScreen_notification.FlatAppearance.BorderSize = 0;
            this.button_ucSearchScreen_notification.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_ucSearchScreen_notification.Location = new System.Drawing.Point(337, 9);
            this.button_ucSearchScreen_notification.Name = "button_ucSearchScreen_notification";
            this.button_ucSearchScreen_notification.Size = new System.Drawing.Size(32, 28);
            this.button_ucSearchScreen_notification.TabIndex = 5;
            this.button_ucSearchScreen_notification.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel_ucSearchScreen
            // 
            this.flowLayoutPanel_ucSearchScreen.AutoScroll = true;
            this.flowLayoutPanel_ucSearchScreen.Location = new System.Drawing.Point(0, 44);
            this.flowLayoutPanel_ucSearchScreen.Name = "flowLayoutPanel_ucSearchScreen";
            this.flowLayoutPanel_ucSearchScreen.Size = new System.Drawing.Size(400, 516);
            this.flowLayoutPanel_ucSearchScreen.TabIndex = 2;
            // 
            // ucSearchScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.flowLayoutPanel_ucSearchScreen);
            this.Controls.Add(this.panel_uciTech_menuTopBar);
            this.Name = "ucSearchScreen";
            this.Size = new System.Drawing.Size(377, 560);
            this.panel_uciTech_menuTopBar.ResumeLayout(false);
            this.panel_ucSearchScreen_searchBar.ResumeLayout(false);
            this.panel_ucSearchScreen_searchBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_ucSearchScreen_magnifiyingGlass)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_uciTech_menuTopBar;
        private System.Windows.Forms.Panel panel_ucSearchScreen_searchBar;
        private System.Windows.Forms.TextBox textBox_ucSearchScreen_searchBar;
        private System.Windows.Forms.PictureBox pictureBox_ucSearchScreen_magnifiyingGlass;
        private System.Windows.Forms.Button button_ucSearchScreen_backArrow;
        private System.Windows.Forms.Button button_ucSearchScreen_notification;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_ucSearchScreen;
    }
}
