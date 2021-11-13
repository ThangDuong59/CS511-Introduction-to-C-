namespace practice02
{
    partial class ucPersonalScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucPersonalScreen));
            this.panel_ucPersonalScreen_title = new System.Windows.Forms.Panel();
            this.labelText_ucPersonalScreen_title = new System.Windows.Forms.Label();
            this.pictureBox_ucPersonalScreen_avatar = new System.Windows.Forms.PictureBox();
            this.labelText_ucPersonalScreen_helloUser = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel_ucPersonalScreen_title.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_ucPersonalScreen_avatar)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_ucPersonalScreen_title
            // 
            this.panel_ucPersonalScreen_title.BackColor = System.Drawing.Color.Thistle;
            this.panel_ucPersonalScreen_title.Controls.Add(this.labelText_ucPersonalScreen_title);
            this.panel_ucPersonalScreen_title.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_ucPersonalScreen_title.Location = new System.Drawing.Point(0, 0);
            this.panel_ucPersonalScreen_title.Name = "panel_ucPersonalScreen_title";
            this.panel_ucPersonalScreen_title.Size = new System.Drawing.Size(377, 45);
            this.panel_ucPersonalScreen_title.TabIndex = 5;
            // 
            // labelText_ucPersonalScreen_title
            // 
            this.labelText_ucPersonalScreen_title.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelText_ucPersonalScreen_title.ForeColor = System.Drawing.Color.Black;
            this.labelText_ucPersonalScreen_title.Location = new System.Drawing.Point(95, 10);
            this.labelText_ucPersonalScreen_title.Name = "labelText_ucPersonalScreen_title";
            this.labelText_ucPersonalScreen_title.Size = new System.Drawing.Size(186, 23);
            this.labelText_ucPersonalScreen_title.TabIndex = 0;
            this.labelText_ucPersonalScreen_title.Text = "Cá nhân";
            this.labelText_ucPersonalScreen_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox_ucPersonalScreen_avatar
            // 
            this.pictureBox_ucPersonalScreen_avatar.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_ucPersonalScreen_avatar.Image")));
            this.pictureBox_ucPersonalScreen_avatar.Location = new System.Drawing.Point(20, 19);
            this.pictureBox_ucPersonalScreen_avatar.Name = "pictureBox_ucPersonalScreen_avatar";
            this.pictureBox_ucPersonalScreen_avatar.Size = new System.Drawing.Size(126, 114);
            this.pictureBox_ucPersonalScreen_avatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_ucPersonalScreen_avatar.TabIndex = 6;
            this.pictureBox_ucPersonalScreen_avatar.TabStop = false;
            // 
            // labelText_ucPersonalScreen_helloUser
            // 
            this.labelText_ucPersonalScreen_helloUser.AutoSize = true;
            this.labelText_ucPersonalScreen_helloUser.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelText_ucPersonalScreen_helloUser.Location = new System.Drawing.Point(168, 41);
            this.labelText_ucPersonalScreen_helloUser.Name = "labelText_ucPersonalScreen_helloUser";
            this.labelText_ucPersonalScreen_helloUser.Size = new System.Drawing.Size(189, 19);
            this.labelText_ucPersonalScreen_helloUser.TabIndex = 7;
            this.labelText_ucPersonalScreen_helloUser.Text = "Xin chào, Thắng Dương";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.pictureBox_ucPersonalScreen_avatar);
            this.panel1.Controls.Add(this.labelText_ucPersonalScreen_helloUser);
            this.panel1.Location = new System.Drawing.Point(0, 51);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(377, 512);
            this.panel1.TabIndex = 8;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(0, 260);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(377, 48);
            this.button3.TabIndex = 12;
            this.button3.Text = "Thông tin đơn hàng";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(0, 169);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(377, 48);
            this.button1.TabIndex = 8;
            this.button1.Text = "Thông tin chi tiết";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(0, 215);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(377, 48);
            this.button2.TabIndex = 9;
            this.button2.Text = "Mặt hàng yêu thích";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // ucPersonalScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel_ucPersonalScreen_title);
            this.Name = "ucPersonalScreen";
            this.Size = new System.Drawing.Size(377, 563);
            this.panel_ucPersonalScreen_title.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_ucPersonalScreen_avatar)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_ucPersonalScreen_title;
        private System.Windows.Forms.Label labelText_ucPersonalScreen_title;
        private System.Windows.Forms.PictureBox pictureBox_ucPersonalScreen_avatar;
        private System.Windows.Forms.Label labelText_ucPersonalScreen_helloUser;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
    }
}
