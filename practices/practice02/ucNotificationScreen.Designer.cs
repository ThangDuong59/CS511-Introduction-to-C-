namespace practice02
{
    partial class ucNotificationScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucNotificationScreen));
            this.panel_ucNotificationScreen_title = new System.Windows.Forms.Panel();
            this.labelText_ucNotificationScreen_title = new System.Windows.Forms.Label();
            this.button_ucNotificationScreen_backArrow = new System.Windows.Forms.Button();
            this.flowLayoutPanel_ucNotificationScreen = new System.Windows.Forms.FlowLayoutPanel();
            this.panel_ucNotificationScreen_title.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_ucNotificationScreen_title
            // 
            this.panel_ucNotificationScreen_title.BackColor = System.Drawing.Color.Thistle;
            this.panel_ucNotificationScreen_title.Controls.Add(this.button_ucNotificationScreen_backArrow);
            this.panel_ucNotificationScreen_title.Controls.Add(this.labelText_ucNotificationScreen_title);
            this.panel_ucNotificationScreen_title.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_ucNotificationScreen_title.Location = new System.Drawing.Point(0, 0);
            this.panel_ucNotificationScreen_title.Name = "panel_ucNotificationScreen_title";
            this.panel_ucNotificationScreen_title.Size = new System.Drawing.Size(377, 45);
            this.panel_ucNotificationScreen_title.TabIndex = 2;
            // 
            // labelText_ucNotificationScreen_title
            // 
            this.labelText_ucNotificationScreen_title.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelText_ucNotificationScreen_title.ForeColor = System.Drawing.Color.Black;
            this.labelText_ucNotificationScreen_title.Location = new System.Drawing.Point(95, 10);
            this.labelText_ucNotificationScreen_title.Name = "labelText_ucNotificationScreen_title";
            this.labelText_ucNotificationScreen_title.Size = new System.Drawing.Size(186, 23);
            this.labelText_ucNotificationScreen_title.TabIndex = 0;
            this.labelText_ucNotificationScreen_title.Text = "Thông báo";
            this.labelText_ucNotificationScreen_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_ucNotificationScreen_backArrow
            // 
            this.button_ucNotificationScreen_backArrow.FlatAppearance.BorderSize = 0;
            this.button_ucNotificationScreen_backArrow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_ucNotificationScreen_backArrow.Image = ((System.Drawing.Image)(resources.GetObject("button_ucNotificationScreen_backArrow.Image")));
            this.button_ucNotificationScreen_backArrow.Location = new System.Drawing.Point(12, 9);
            this.button_ucNotificationScreen_backArrow.Name = "button_ucNotificationScreen_backArrow";
            this.button_ucNotificationScreen_backArrow.Size = new System.Drawing.Size(29, 29);
            this.button_ucNotificationScreen_backArrow.TabIndex = 5;
            this.button_ucNotificationScreen_backArrow.UseVisualStyleBackColor = true;
            this.button_ucNotificationScreen_backArrow.Click += new System.EventHandler(this.button_click_ucNotificationScreen_backArrow);
            // 
            // flowLayoutPanel_ucNotificationScreen
            // 
            this.flowLayoutPanel_ucNotificationScreen.AutoScroll = true;
            this.flowLayoutPanel_ucNotificationScreen.FlowDirection = System.Windows.Forms.FlowDirection.BottomUp;
            this.flowLayoutPanel_ucNotificationScreen.Location = new System.Drawing.Point(0, 44);
            this.flowLayoutPanel_ucNotificationScreen.Name = "flowLayoutPanel_ucNotificationScreen";
            this.flowLayoutPanel_ucNotificationScreen.Size = new System.Drawing.Size(400, 516);
            this.flowLayoutPanel_ucNotificationScreen.TabIndex = 3;
            // 
            // ucNotificationScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowLayoutPanel_ucNotificationScreen);
            this.Controls.Add(this.panel_ucNotificationScreen_title);
            this.Name = "ucNotificationScreen";
            this.Size = new System.Drawing.Size(377, 560);
            this.panel_ucNotificationScreen_title.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_ucNotificationScreen_title;
        private System.Windows.Forms.Label labelText_ucNotificationScreen_title;
        private System.Windows.Forms.Button button_ucNotificationScreen_backArrow;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_ucNotificationScreen;
    }
}
