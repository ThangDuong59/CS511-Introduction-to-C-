namespace exercise10
{
    partial class FormAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            this.pictureBox_speak = new System.Windows.Forms.PictureBox();
            this.labelText_script = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_speak)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_speak
            // 
            this.pictureBox_speak.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_speak.Image")));
            this.pictureBox_speak.Location = new System.Drawing.Point(35, 43);
            this.pictureBox_speak.Name = "pictureBox_speak";
            this.pictureBox_speak.Size = new System.Drawing.Size(69, 57);
            this.pictureBox_speak.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_speak.TabIndex = 0;
            this.pictureBox_speak.TabStop = false;
            this.pictureBox_speak.Click += new System.EventHandler(this.pictureBox_click_speak);
            // 
            // labelText_script
            // 
            this.labelText_script.AutoSize = true;
            this.labelText_script.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelText_script.ForeColor = System.Drawing.Color.OrangeRed;
            this.labelText_script.Location = new System.Drawing.Point(133, 58);
            this.labelText_script.Name = "labelText_script";
            this.labelText_script.Size = new System.Drawing.Size(152, 25);
            this.labelText_script.TabIndex = 1;
            this.labelText_script.Text = "Hello world C#";
            // 
            // FormAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(330, 149);
            this.Controls.Add(this.labelText_script);
            this.Controls.Add(this.pictureBox_speak);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAbout";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "About";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_speak)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_speak;
        private System.Windows.Forms.Label labelText_script;
    }
}