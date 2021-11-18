namespace exercise10
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createPlaylistToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox_features = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelText_video = new System.Windows.Forms.Label();
            this.pictureBox_add_video = new System.Windows.Forms.PictureBox();
            this.listBox_video = new System.Windows.Forms.ListBox();
            this.listView_playlists = new System.Windows.Forms.ListView();
            this.pictureBox_add_playlists = new System.Windows.Forms.PictureBox();
            this.labelText_playlists = new System.Windows.Forms.Label();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.menuStrip1.SuspendLayout();
            this.groupBox_features.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_add_video)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_add_playlists)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.settingToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(847, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.createPlaylistToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.homeToolStripMenuItem.Text = "Home";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // createPlaylistToolStripMenuItem
            // 
            this.createPlaylistToolStripMenuItem.Name = "createPlaylistToolStripMenuItem";
            this.createPlaylistToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.createPlaylistToolStripMenuItem.Text = "Create Playlist";
            this.createPlaylistToolStripMenuItem.Click += new System.EventHandler(this.createPlaylistToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // settingToolStripMenuItem
            // 
            this.settingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.settingToolStripMenuItem.Name = "settingToolStripMenuItem";
            this.settingToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.settingToolStripMenuItem.Text = "Setting";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // groupBox_features
            // 
            this.groupBox_features.Controls.Add(this.panel1);
            this.groupBox_features.Controls.Add(this.listBox_video);
            this.groupBox_features.Controls.Add(this.listView_playlists);
            this.groupBox_features.Controls.Add(this.pictureBox_add_playlists);
            this.groupBox_features.Controls.Add(this.labelText_playlists);
            this.groupBox_features.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox_features.Location = new System.Drawing.Point(600, 24);
            this.groupBox_features.Name = "groupBox_features";
            this.groupBox_features.Size = new System.Drawing.Size(247, 538);
            this.groupBox_features.TabIndex = 1;
            this.groupBox_features.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelText_video);
            this.panel1.Controls.Add(this.pictureBox_add_video);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(3, 291);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(241, 45);
            this.panel1.TabIndex = 6;
            // 
            // labelText_video
            // 
            this.labelText_video.AutoSize = true;
            this.labelText_video.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelText_video.ForeColor = System.Drawing.Color.White;
            this.labelText_video.Location = new System.Drawing.Point(3, 11);
            this.labelText_video.Name = "labelText_video";
            this.labelText_video.Size = new System.Drawing.Size(55, 20);
            this.labelText_video.TabIndex = 3;
            this.labelText_video.Text = "Video";
            // 
            // pictureBox_add_video
            // 
            this.pictureBox_add_video.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_add_video.Image")));
            this.pictureBox_add_video.Location = new System.Drawing.Point(197, 10);
            this.pictureBox_add_video.Name = "pictureBox_add_video";
            this.pictureBox_add_video.Size = new System.Drawing.Size(35, 32);
            this.pictureBox_add_video.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_add_video.TabIndex = 4;
            this.pictureBox_add_video.TabStop = false;
            this.pictureBox_add_video.Click += new System.EventHandler(this.pictureBox_add_video_Click);
            // 
            // listBox_video
            // 
            this.listBox_video.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listBox_video.FormattingEnabled = true;
            this.listBox_video.Location = new System.Drawing.Point(3, 336);
            this.listBox_video.Name = "listBox_video";
            this.listBox_video.Size = new System.Drawing.Size(241, 199);
            this.listBox_video.TabIndex = 5;
            this.listBox_video.SelectedIndexChanged += new System.EventHandler(this.listBox_selectedIndexChanged_video);
            // 
            // listView_playlists
            // 
            this.listView_playlists.HideSelection = false;
            this.listView_playlists.Location = new System.Drawing.Point(6, 51);
            this.listView_playlists.Name = "listView_playlists";
            this.listView_playlists.Size = new System.Drawing.Size(235, 226);
            this.listView_playlists.TabIndex = 2;
            this.listView_playlists.UseCompatibleStateImageBehavior = false;
            this.listView_playlists.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listView_itemSelectionChanged_playlists);
            // 
            // pictureBox_add_playlists
            // 
            this.pictureBox_add_playlists.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_add_playlists.Image")));
            this.pictureBox_add_playlists.Location = new System.Drawing.Point(206, 16);
            this.pictureBox_add_playlists.Name = "pictureBox_add_playlists";
            this.pictureBox_add_playlists.Size = new System.Drawing.Size(35, 32);
            this.pictureBox_add_playlists.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_add_playlists.TabIndex = 1;
            this.pictureBox_add_playlists.TabStop = false;
            this.pictureBox_add_playlists.Click += new System.EventHandler(this.pictureBox_add_playlists_Click);
            // 
            // labelText_playlists
            // 
            this.labelText_playlists.AutoSize = true;
            this.labelText_playlists.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelText_playlists.ForeColor = System.Drawing.Color.White;
            this.labelText_playlists.Location = new System.Drawing.Point(6, 16);
            this.labelText_playlists.Name = "labelText_playlists";
            this.labelText_playlists.Size = new System.Drawing.Size(74, 20);
            this.labelText_playlists.TabIndex = 0;
            this.labelText_playlists.Text = "Playlists";
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(0, 24);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(600, 538);
            this.axWindowsMediaPlayer1.TabIndex = 2;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(847, 562);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.groupBox_features);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.Text = "Media Player";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox_features.ResumeLayout(false);
            this.groupBox_features.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_add_video)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_add_playlists)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createPlaylistToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox_features;
        private System.Windows.Forms.ListBox listBox_video;
        private System.Windows.Forms.PictureBox pictureBox_add_video;
        private System.Windows.Forms.Label labelText_video;
        private System.Windows.Forms.ListView listView_playlists;
        private System.Windows.Forms.PictureBox pictureBox_add_playlists;
        private System.Windows.Forms.Label labelText_playlists;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.Panel panel1;
    }
}

