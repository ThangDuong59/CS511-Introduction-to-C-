namespace practice02
{
    partial class ucHistoryScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucHistoryScreen));
            this.panel_ucHistoryScreen_title = new System.Windows.Forms.Panel();
            this.pictureBox_ucHistoryScreen = new System.Windows.Forms.PictureBox();
            this.labelText_ucHistoryScreen_title = new System.Windows.Forms.Label();
            this.flowLayoutPanel_ucHistoryScreen = new System.Windows.Forms.FlowLayoutPanel();
            this.panel_ucHistoryScreen_title.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_ucHistoryScreen)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_ucHistoryScreen_title
            // 
            this.panel_ucHistoryScreen_title.BackColor = System.Drawing.Color.Thistle;
            this.panel_ucHistoryScreen_title.Controls.Add(this.pictureBox_ucHistoryScreen);
            this.panel_ucHistoryScreen_title.Controls.Add(this.labelText_ucHistoryScreen_title);
            this.panel_ucHistoryScreen_title.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_ucHistoryScreen_title.Location = new System.Drawing.Point(0, 0);
            this.panel_ucHistoryScreen_title.Name = "panel_ucHistoryScreen_title";
            this.panel_ucHistoryScreen_title.Size = new System.Drawing.Size(377, 45);
            this.panel_ucHistoryScreen_title.TabIndex = 5;
            // 
            // pictureBox_ucHistoryScreen
            // 
            this.pictureBox_ucHistoryScreen.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_ucHistoryScreen.Image")));
            this.pictureBox_ucHistoryScreen.Location = new System.Drawing.Point(337, 7);
            this.pictureBox_ucHistoryScreen.Name = "pictureBox_ucHistoryScreen";
            this.pictureBox_ucHistoryScreen.Size = new System.Drawing.Size(32, 32);
            this.pictureBox_ucHistoryScreen.TabIndex = 0;
            this.pictureBox_ucHistoryScreen.TabStop = false;
            this.pictureBox_ucHistoryScreen.Click += new System.EventHandler(this.pictureBox_click_ucHistoryScreen);
            // 
            // labelText_ucHistoryScreen_title
            // 
            this.labelText_ucHistoryScreen_title.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelText_ucHistoryScreen_title.ForeColor = System.Drawing.Color.Black;
            this.labelText_ucHistoryScreen_title.Location = new System.Drawing.Point(95, 10);
            this.labelText_ucHistoryScreen_title.Name = "labelText_ucHistoryScreen_title";
            this.labelText_ucHistoryScreen_title.Size = new System.Drawing.Size(186, 23);
            this.labelText_ucHistoryScreen_title.TabIndex = 0;
            this.labelText_ucHistoryScreen_title.Text = "Lịch sử giao dịch";
            this.labelText_ucHistoryScreen_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel_ucHistoryScreen
            // 
            this.flowLayoutPanel_ucHistoryScreen.AutoScroll = true;
            this.flowLayoutPanel_ucHistoryScreen.Location = new System.Drawing.Point(0, 51);
            this.flowLayoutPanel_ucHistoryScreen.Name = "flowLayoutPanel_ucHistoryScreen";
            this.flowLayoutPanel_ucHistoryScreen.Size = new System.Drawing.Size(405, 512);
            this.flowLayoutPanel_ucHistoryScreen.TabIndex = 6;
            // 
            // ucHistoryScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.flowLayoutPanel_ucHistoryScreen);
            this.Controls.Add(this.panel_ucHistoryScreen_title);
            this.Name = "ucHistoryScreen";
            this.Size = new System.Drawing.Size(377, 560);
            this.panel_ucHistoryScreen_title.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_ucHistoryScreen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_ucHistoryScreen_title;
        private System.Windows.Forms.Label labelText_ucHistoryScreen_title;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_ucHistoryScreen;
        private System.Windows.Forms.PictureBox pictureBox_ucHistoryScreen;
    }
}
