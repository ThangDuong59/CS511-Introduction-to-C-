namespace practice02
{
    partial class ucPayingScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucPayingScreen));
            this.panel_ucPayingScreen_title = new System.Windows.Forms.Panel();
            this.button_ucPayingScreen_backArrow = new System.Windows.Forms.Button();
            this.labelText_ucPayingScreen_title = new System.Windows.Forms.Label();
            this.panel_ucPayingScreen_mainContainer = new System.Windows.Forms.Panel();
            this.panel_ucPayingScreen_title.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_ucPayingScreen_title
            // 
            this.panel_ucPayingScreen_title.BackColor = System.Drawing.Color.Thistle;
            this.panel_ucPayingScreen_title.Controls.Add(this.button_ucPayingScreen_backArrow);
            this.panel_ucPayingScreen_title.Controls.Add(this.labelText_ucPayingScreen_title);
            this.panel_ucPayingScreen_title.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_ucPayingScreen_title.Location = new System.Drawing.Point(0, 0);
            this.panel_ucPayingScreen_title.Name = "panel_ucPayingScreen_title";
            this.panel_ucPayingScreen_title.Size = new System.Drawing.Size(377, 45);
            this.panel_ucPayingScreen_title.TabIndex = 4;
            // 
            // button_ucPayingScreen_backArrow
            // 
            this.button_ucPayingScreen_backArrow.FlatAppearance.BorderSize = 0;
            this.button_ucPayingScreen_backArrow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_ucPayingScreen_backArrow.Image = ((System.Drawing.Image)(resources.GetObject("button_ucPayingScreen_backArrow.Image")));
            this.button_ucPayingScreen_backArrow.Location = new System.Drawing.Point(12, 9);
            this.button_ucPayingScreen_backArrow.Name = "button_ucPayingScreen_backArrow";
            this.button_ucPayingScreen_backArrow.Size = new System.Drawing.Size(29, 29);
            this.button_ucPayingScreen_backArrow.TabIndex = 5;
            this.button_ucPayingScreen_backArrow.UseVisualStyleBackColor = true;
            // 
            // labelText_ucPayingScreen_title
            // 
            this.labelText_ucPayingScreen_title.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelText_ucPayingScreen_title.ForeColor = System.Drawing.Color.Black;
            this.labelText_ucPayingScreen_title.Location = new System.Drawing.Point(95, 10);
            this.labelText_ucPayingScreen_title.Name = "labelText_ucPayingScreen_title";
            this.labelText_ucPayingScreen_title.Size = new System.Drawing.Size(186, 23);
            this.labelText_ucPayingScreen_title.TabIndex = 0;
            this.labelText_ucPayingScreen_title.Text = "Thanh toán";
            this.labelText_ucPayingScreen_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel_ucPayingScreen_mainContainer
            // 
            this.panel_ucPayingScreen_mainContainer.Location = new System.Drawing.Point(0, 44);
            this.panel_ucPayingScreen_mainContainer.Name = "panel_ucPayingScreen_mainContainer";
            this.panel_ucPayingScreen_mainContainer.Size = new System.Drawing.Size(377, 516);
            this.panel_ucPayingScreen_mainContainer.TabIndex = 5;
            // 
            // ucPaying
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel_ucPayingScreen_mainContainer);
            this.Controls.Add(this.panel_ucPayingScreen_title);
            this.Name = "ucPaying";
            this.Size = new System.Drawing.Size(377, 560);
            this.panel_ucPayingScreen_title.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_ucPayingScreen_title;
        private System.Windows.Forms.Button button_ucPayingScreen_backArrow;
        private System.Windows.Forms.Label labelText_ucPayingScreen_title;
        private System.Windows.Forms.Panel panel_ucPayingScreen_mainContainer;
    }
}
