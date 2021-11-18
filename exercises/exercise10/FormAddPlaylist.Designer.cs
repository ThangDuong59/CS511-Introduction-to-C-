namespace exercise10
{
    partial class FormAddPlaylist
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddPlaylist));
            this.labelText_playlistName = new System.Windows.Forms.Label();
            this.textBox_playlistName = new System.Windows.Forms.TextBox();
            this.pictureBox_savePlaylist = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_savePlaylist)).BeginInit();
            this.SuspendLayout();
            // 
            // labelText_playlistName
            // 
            this.labelText_playlistName.AutoSize = true;
            this.labelText_playlistName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelText_playlistName.Location = new System.Drawing.Point(23, 33);
            this.labelText_playlistName.Name = "labelText_playlistName";
            this.labelText_playlistName.Size = new System.Drawing.Size(55, 20);
            this.labelText_playlistName.TabIndex = 0;
            this.labelText_playlistName.Text = "Name";
            // 
            // textBox_playlistName
            // 
            this.textBox_playlistName.Location = new System.Drawing.Point(97, 33);
            this.textBox_playlistName.Name = "textBox_playlistName";
            this.textBox_playlistName.Size = new System.Drawing.Size(206, 20);
            this.textBox_playlistName.TabIndex = 1;
            // 
            // pictureBox_savePlaylist
            // 
            this.pictureBox_savePlaylist.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_savePlaylist.Image")));
            this.pictureBox_savePlaylist.Location = new System.Drawing.Point(143, 83);
            this.pictureBox_savePlaylist.Name = "pictureBox_savePlaylist";
            this.pictureBox_savePlaylist.Size = new System.Drawing.Size(64, 54);
            this.pictureBox_savePlaylist.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_savePlaylist.TabIndex = 2;
            this.pictureBox_savePlaylist.TabStop = false;
            this.pictureBox_savePlaylist.Click += new System.EventHandler(this.pictureBox_click_savePlaylist);
            // 
            // FormAddPlaylist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.ClientSize = new System.Drawing.Size(342, 149);
            this.Controls.Add(this.pictureBox_savePlaylist);
            this.Controls.Add(this.textBox_playlistName);
            this.Controls.Add(this.labelText_playlistName);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAddPlaylist";
            this.ShowIcon = false;
            this.Text = "Playlist";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_savePlaylist)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelText_playlistName;
        private System.Windows.Forms.TextBox textBox_playlistName;
        private System.Windows.Forms.PictureBox pictureBox_savePlaylist;
    }
}