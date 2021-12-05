namespace exercise11
{
    partial class FormTA02
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTA02));
            this.pictureBox_story = new System.Windows.Forms.PictureBox();
            this.panel_menu = new System.Windows.Forms.Panel();
            this.pictureBox_mute = new System.Windows.Forms.PictureBox();
            this.pictureBox_speak = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_story)).BeginInit();
            this.panel_menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_mute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_speak)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_story
            // 
            this.pictureBox_story.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox_story.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_story.Image")));
            this.pictureBox_story.Location = new System.Drawing.Point(0, 56);
            this.pictureBox_story.Name = "pictureBox_story";
            this.pictureBox_story.Size = new System.Drawing.Size(800, 394);
            this.pictureBox_story.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_story.TabIndex = 0;
            this.pictureBox_story.TabStop = false;
            // 
            // panel_menu
            // 
            this.panel_menu.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel_menu.Controls.Add(this.pictureBox_mute);
            this.panel_menu.Controls.Add(this.pictureBox_speak);
            this.panel_menu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_menu.Location = new System.Drawing.Point(0, 0);
            this.panel_menu.Name = "panel_menu";
            this.panel_menu.Size = new System.Drawing.Size(800, 60);
            this.panel_menu.TabIndex = 1;
            // 
            // pictureBox_mute
            // 
            this.pictureBox_mute.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox_mute.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_mute.Image")));
            this.pictureBox_mute.Location = new System.Drawing.Point(727, 0);
            this.pictureBox_mute.Name = "pictureBox_mute";
            this.pictureBox_mute.Size = new System.Drawing.Size(61, 60);
            this.pictureBox_mute.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_mute.TabIndex = 1;
            this.pictureBox_mute.TabStop = false;
            this.pictureBox_mute.Click += new System.EventHandler(this.pictureBox_mute_Click);
            // 
            // pictureBox_speak
            // 
            this.pictureBox_speak.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_speak.Image")));
            this.pictureBox_speak.Location = new System.Drawing.Point(12, 0);
            this.pictureBox_speak.Name = "pictureBox_speak";
            this.pictureBox_speak.Size = new System.Drawing.Size(61, 60);
            this.pictureBox_speak.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_speak.TabIndex = 0;
            this.pictureBox_speak.TabStop = false;
            this.pictureBox_speak.Click += new System.EventHandler(this.pictureBox_speak_Click);
            // 
            // FormTA02
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel_menu);
            this.Controls.Add(this.pictureBox_story);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormTA02";
            this.Text = "Story - Birds and a Baby";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_story)).EndInit();
            this.panel_menu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_mute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_speak)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_story;
        private System.Windows.Forms.Panel panel_menu;
        private System.Windows.Forms.PictureBox pictureBox_mute;
        private System.Windows.Forms.PictureBox pictureBox_speak;
    }
}