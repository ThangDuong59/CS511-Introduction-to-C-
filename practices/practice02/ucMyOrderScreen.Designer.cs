namespace practice02
{
    partial class ucMyOrderScreen
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
            this.panel_ucMyOrderScreen_title = new System.Windows.Forms.Panel();
            this.labelText_ucMyOrderScreen_yourOrder = new System.Windows.Forms.Label();
            this.panel_ucMyOrderScreen_title.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_ucMyOrderScreen_title
            // 
            this.panel_ucMyOrderScreen_title.BackColor = System.Drawing.Color.Thistle;
            this.panel_ucMyOrderScreen_title.Controls.Add(this.labelText_ucMyOrderScreen_yourOrder);
            this.panel_ucMyOrderScreen_title.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_ucMyOrderScreen_title.Location = new System.Drawing.Point(0, 0);
            this.panel_ucMyOrderScreen_title.Name = "panel_ucMyOrderScreen_title";
            this.panel_ucMyOrderScreen_title.Size = new System.Drawing.Size(377, 49);
            this.panel_ucMyOrderScreen_title.TabIndex = 1;
            // 
            // labelText_ucMyOrderScreen_yourOrder
            // 
            this.labelText_ucMyOrderScreen_yourOrder.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelText_ucMyOrderScreen_yourOrder.ForeColor = System.Drawing.Color.Black;
            this.labelText_ucMyOrderScreen_yourOrder.Location = new System.Drawing.Point(98, 13);
            this.labelText_ucMyOrderScreen_yourOrder.Name = "labelText_ucMyOrderScreen_yourOrder";
            this.labelText_ucMyOrderScreen_yourOrder.Size = new System.Drawing.Size(186, 23);
            this.labelText_ucMyOrderScreen_yourOrder.TabIndex = 0;
            this.labelText_ucMyOrderScreen_yourOrder.Text = "Giỏ hàng của bạn";
            this.labelText_ucMyOrderScreen_yourOrder.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ucMyOrderScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel_ucMyOrderScreen_title);
            this.Name = "ucMyOrderScreen";
            this.Size = new System.Drawing.Size(377, 560);
            this.panel_ucMyOrderScreen_title.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_ucMyOrderScreen_title;
        private System.Windows.Forms.Label labelText_ucMyOrderScreen_yourOrder;
    }
}
