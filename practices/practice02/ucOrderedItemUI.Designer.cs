namespace practice02
{
    partial class ucOrderedItemUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucOrderedItemUI));
            this.pictureBox_ucOrderedItemUI_itemPic = new System.Windows.Forms.PictureBox();
            this.labelValue_ucOrderedItemUI_itemTitle = new System.Windows.Forms.Label();
            this.labelValue_ucOrderedItemUI_itemPrice = new System.Windows.Forms.Label();
            this.checkBox_ucOrderedItemUI_isPay = new System.Windows.Forms.CheckBox();
            this.pictureBox_ucOrderedItemUI_trash = new System.Windows.Forms.PictureBox();
            this.numericUpDown_ucOrderedItemUI_quantity = new System.Windows.Forms.NumericUpDown();
            this.labelText_ucOrderedItemUI_quantity = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_ucOrderedItemUI_itemPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_ucOrderedItemUI_trash)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_ucOrderedItemUI_quantity)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_ucOrderedItemUI_itemPic
            // 
            this.pictureBox_ucOrderedItemUI_itemPic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox_ucOrderedItemUI_itemPic.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_ucOrderedItemUI_itemPic.Image")));
            this.pictureBox_ucOrderedItemUI_itemPic.Location = new System.Drawing.Point(0, 0);
            this.pictureBox_ucOrderedItemUI_itemPic.Name = "pictureBox_ucOrderedItemUI_itemPic";
            this.pictureBox_ucOrderedItemUI_itemPic.Size = new System.Drawing.Size(107, 100);
            this.pictureBox_ucOrderedItemUI_itemPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_ucOrderedItemUI_itemPic.TabIndex = 0;
            this.pictureBox_ucOrderedItemUI_itemPic.TabStop = false;
            // 
            // labelValue_ucOrderedItemUI_itemTitle
            // 
            this.labelValue_ucOrderedItemUI_itemTitle.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelValue_ucOrderedItemUI_itemTitle.Location = new System.Drawing.Point(110, 7);
            this.labelValue_ucOrderedItemUI_itemTitle.Name = "labelValue_ucOrderedItemUI_itemTitle";
            this.labelValue_ucOrderedItemUI_itemTitle.Size = new System.Drawing.Size(238, 36);
            this.labelValue_ucOrderedItemUI_itemTitle.TabIndex = 1;
            this.labelValue_ucOrderedItemUI_itemTitle.Text = "label1";
            // 
            // labelValue_ucOrderedItemUI_itemPrice
            // 
            this.labelValue_ucOrderedItemUI_itemPrice.AutoSize = true;
            this.labelValue_ucOrderedItemUI_itemPrice.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelValue_ucOrderedItemUI_itemPrice.ForeColor = System.Drawing.Color.Red;
            this.labelValue_ucOrderedItemUI_itemPrice.Location = new System.Drawing.Point(113, 74);
            this.labelValue_ucOrderedItemUI_itemPrice.Name = "labelValue_ucOrderedItemUI_itemPrice";
            this.labelValue_ucOrderedItemUI_itemPrice.Size = new System.Drawing.Size(47, 17);
            this.labelValue_ucOrderedItemUI_itemPrice.TabIndex = 2;
            this.labelValue_ucOrderedItemUI_itemPrice.Text = "label2";
            // 
            // checkBox_ucOrderedItemUI_isPay
            // 
            this.checkBox_ucOrderedItemUI_isPay.AutoSize = true;
            this.checkBox_ucOrderedItemUI_isPay.Location = new System.Drawing.Point(356, 77);
            this.checkBox_ucOrderedItemUI_isPay.Name = "checkBox_ucOrderedItemUI_isPay";
            this.checkBox_ucOrderedItemUI_isPay.Size = new System.Drawing.Size(15, 14);
            this.checkBox_ucOrderedItemUI_isPay.TabIndex = 3;
            this.checkBox_ucOrderedItemUI_isPay.UseVisualStyleBackColor = true;
            this.checkBox_ucOrderedItemUI_isPay.Click += new System.EventHandler(this.checkBox_click_ucOrderedItemUI_isPay);
            // 
            // pictureBox_ucOrderedItemUI_trash
            // 
            this.pictureBox_ucOrderedItemUI_trash.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_ucOrderedItemUI_trash.Image")));
            this.pictureBox_ucOrderedItemUI_trash.Location = new System.Drawing.Point(354, 3);
            this.pictureBox_ucOrderedItemUI_trash.Name = "pictureBox_ucOrderedItemUI_trash";
            this.pictureBox_ucOrderedItemUI_trash.Size = new System.Drawing.Size(20, 22);
            this.pictureBox_ucOrderedItemUI_trash.TabIndex = 4;
            this.pictureBox_ucOrderedItemUI_trash.TabStop = false;
            this.pictureBox_ucOrderedItemUI_trash.Click += new System.EventHandler(this.pictureBox_click_ucOrderedItemUI_trash);
            // 
            // numericUpDown_ucOrderedItemUI_quantity
            // 
            this.numericUpDown_ucOrderedItemUI_quantity.Location = new System.Drawing.Point(287, 74);
            this.numericUpDown_ucOrderedItemUI_quantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_ucOrderedItemUI_quantity.Name = "numericUpDown_ucOrderedItemUI_quantity";
            this.numericUpDown_ucOrderedItemUI_quantity.Size = new System.Drawing.Size(61, 20);
            this.numericUpDown_ucOrderedItemUI_quantity.TabIndex = 5;
            this.numericUpDown_ucOrderedItemUI_quantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_ucOrderedItemUI_quantity.ValueChanged += new System.EventHandler(this.numericUpDown_valueChanged_ucOrderedItemUI_quantity);
            // 
            // labelText_ucOrderedItemUI_quantity
            // 
            this.labelText_ucOrderedItemUI_quantity.AutoSize = true;
            this.labelText_ucOrderedItemUI_quantity.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelText_ucOrderedItemUI_quantity.ForeColor = System.Drawing.Color.Black;
            this.labelText_ucOrderedItemUI_quantity.Location = new System.Drawing.Point(216, 75);
            this.labelText_ucOrderedItemUI_quantity.Name = "labelText_ucOrderedItemUI_quantity";
            this.labelText_ucOrderedItemUI_quantity.Size = new System.Drawing.Size(65, 17);
            this.labelText_ucOrderedItemUI_quantity.TabIndex = 6;
            this.labelText_ucOrderedItemUI_quantity.Text = "Số lượng:";
            // 
            // ucOrderedItemUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.labelText_ucOrderedItemUI_quantity);
            this.Controls.Add(this.numericUpDown_ucOrderedItemUI_quantity);
            this.Controls.Add(this.pictureBox_ucOrderedItemUI_trash);
            this.Controls.Add(this.checkBox_ucOrderedItemUI_isPay);
            this.Controls.Add(this.labelValue_ucOrderedItemUI_itemPrice);
            this.Controls.Add(this.labelValue_ucOrderedItemUI_itemTitle);
            this.Controls.Add(this.pictureBox_ucOrderedItemUI_itemPic);
            this.Name = "ucOrderedItemUI";
            this.Size = new System.Drawing.Size(377, 100);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_ucOrderedItemUI_itemPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_ucOrderedItemUI_trash)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_ucOrderedItemUI_quantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_ucOrderedItemUI_itemPic;
        private System.Windows.Forms.Label labelValue_ucOrderedItemUI_itemTitle;
        private System.Windows.Forms.Label labelValue_ucOrderedItemUI_itemPrice;
        private System.Windows.Forms.CheckBox checkBox_ucOrderedItemUI_isPay;
        private System.Windows.Forms.PictureBox pictureBox_ucOrderedItemUI_trash;
        private System.Windows.Forms.NumericUpDown numericUpDown_ucOrderedItemUI_quantity;
        private System.Windows.Forms.Label labelText_ucOrderedItemUI_quantity;
    }
}
