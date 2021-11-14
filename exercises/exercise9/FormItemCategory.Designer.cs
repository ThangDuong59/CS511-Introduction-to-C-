namespace exercise9
{
    partial class FormItemCategory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormItemCategory));
            this.dataGridView_category = new System.Windows.Forms.DataGridView();
            this.pictureBox_save = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_category)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_save)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_category
            // 
            this.dataGridView_category.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_category.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView_category.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_category.Name = "dataGridView_category";
            this.dataGridView_category.Size = new System.Drawing.Size(417, 312);
            this.dataGridView_category.TabIndex = 0;
            this.dataGridView_category.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_cellEndEdit_category);
            this.dataGridView_category.UserAddedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.dataGridView_userAddedRow_category);
            // 
            // pictureBox_save
            // 
            this.pictureBox_save.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_save.Image")));
            this.pictureBox_save.Location = new System.Drawing.Point(173, 331);
            this.pictureBox_save.Name = "pictureBox_save";
            this.pictureBox_save.Size = new System.Drawing.Size(69, 50);
            this.pictureBox_save.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_save.TabIndex = 1;
            this.pictureBox_save.TabStop = false;
            this.pictureBox_save.Click += new System.EventHandler(this.pictureBox_click_save);
            // 
            // FormItemCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(417, 399);
            this.Controls.Add(this.pictureBox_save);
            this.Controls.Add(this.dataGridView_category);
            this.Name = "FormItemCategory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh mục sản phẩm";
            this.Load += new System.EventHandler(this.FormItemCategory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_category)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_save)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_category;
        private System.Windows.Forms.PictureBox pictureBox_save;
    }
}