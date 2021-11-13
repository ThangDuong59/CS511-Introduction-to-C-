namespace practice02
{
    partial class ucStatisticScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucStatisticScreen));
            this.panel_ucHistoryScreen_title = new System.Windows.Forms.Panel();
            this.button_ucStatisticScreen_backArrow = new System.Windows.Forms.Button();
            this.labelText_ucStatisticScreen_title = new System.Windows.Forms.Label();
            this.panel_ucStatisticScreen = new System.Windows.Forms.Panel();
            this.labelValue_ucStatisticScreen_totalPaid = new System.Windows.Forms.Label();
            this.labelValue_ucStatisticScreen_waitingOrder = new System.Windows.Forms.Label();
            this.labelValue_ucStatisticScreen_cancelOrder = new System.Windows.Forms.Label();
            this.labelValue_ucStatisticScreen_successOrder = new System.Windows.Forms.Label();
            this.labelValue_ucStatisticScreen_totalOrder = new System.Windows.Forms.Label();
            this.labelText_ucStatisticScreen_waitingOrder = new System.Windows.Forms.Label();
            this.labelText_ucStatisticScreen_cancelOrder = new System.Windows.Forms.Label();
            this.labelText_ucStatisticScreen_successOrder = new System.Windows.Forms.Label();
            this.labelText_ucStatisticScreen_totalPaid = new System.Windows.Forms.Label();
            this.labelText_ucStatisticScreen_totalOrder = new System.Windows.Forms.Label();
            this.panel_ucHistoryScreen_title.SuspendLayout();
            this.panel_ucStatisticScreen.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_ucHistoryScreen_title
            // 
            this.panel_ucHistoryScreen_title.BackColor = System.Drawing.Color.Thistle;
            this.panel_ucHistoryScreen_title.Controls.Add(this.button_ucStatisticScreen_backArrow);
            this.panel_ucHistoryScreen_title.Controls.Add(this.labelText_ucStatisticScreen_title);
            this.panel_ucHistoryScreen_title.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_ucHistoryScreen_title.Location = new System.Drawing.Point(0, 0);
            this.panel_ucHistoryScreen_title.Name = "panel_ucHistoryScreen_title";
            this.panel_ucHistoryScreen_title.Size = new System.Drawing.Size(377, 45);
            this.panel_ucHistoryScreen_title.TabIndex = 6;
            // 
            // button_ucStatisticScreen_backArrow
            // 
            this.button_ucStatisticScreen_backArrow.FlatAppearance.BorderSize = 0;
            this.button_ucStatisticScreen_backArrow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_ucStatisticScreen_backArrow.Image = ((System.Drawing.Image)(resources.GetObject("button_ucStatisticScreen_backArrow.Image")));
            this.button_ucStatisticScreen_backArrow.Location = new System.Drawing.Point(10, 9);
            this.button_ucStatisticScreen_backArrow.Name = "button_ucStatisticScreen_backArrow";
            this.button_ucStatisticScreen_backArrow.Size = new System.Drawing.Size(29, 29);
            this.button_ucStatisticScreen_backArrow.TabIndex = 5;
            this.button_ucStatisticScreen_backArrow.UseVisualStyleBackColor = true;
            this.button_ucStatisticScreen_backArrow.Click += new System.EventHandler(this.button_click_ucStatisticScreen_backArrow);
            // 
            // labelText_ucStatisticScreen_title
            // 
            this.labelText_ucStatisticScreen_title.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelText_ucStatisticScreen_title.ForeColor = System.Drawing.Color.Black;
            this.labelText_ucStatisticScreen_title.Location = new System.Drawing.Point(95, 10);
            this.labelText_ucStatisticScreen_title.Name = "labelText_ucStatisticScreen_title";
            this.labelText_ucStatisticScreen_title.Size = new System.Drawing.Size(186, 23);
            this.labelText_ucStatisticScreen_title.TabIndex = 0;
            this.labelText_ucStatisticScreen_title.Text = "Thống kê giao dịch";
            this.labelText_ucStatisticScreen_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel_ucStatisticScreen
            // 
            this.panel_ucStatisticScreen.Controls.Add(this.labelValue_ucStatisticScreen_totalPaid);
            this.panel_ucStatisticScreen.Controls.Add(this.labelValue_ucStatisticScreen_waitingOrder);
            this.panel_ucStatisticScreen.Controls.Add(this.labelValue_ucStatisticScreen_cancelOrder);
            this.panel_ucStatisticScreen.Controls.Add(this.labelValue_ucStatisticScreen_successOrder);
            this.panel_ucStatisticScreen.Controls.Add(this.labelValue_ucStatisticScreen_totalOrder);
            this.panel_ucStatisticScreen.Controls.Add(this.labelText_ucStatisticScreen_waitingOrder);
            this.panel_ucStatisticScreen.Controls.Add(this.labelText_ucStatisticScreen_cancelOrder);
            this.panel_ucStatisticScreen.Controls.Add(this.labelText_ucStatisticScreen_successOrder);
            this.panel_ucStatisticScreen.Controls.Add(this.labelText_ucStatisticScreen_totalPaid);
            this.panel_ucStatisticScreen.Controls.Add(this.labelText_ucStatisticScreen_totalOrder);
            this.panel_ucStatisticScreen.Location = new System.Drawing.Point(0, 51);
            this.panel_ucStatisticScreen.Name = "panel_ucStatisticScreen";
            this.panel_ucStatisticScreen.Size = new System.Drawing.Size(377, 512);
            this.panel_ucStatisticScreen.TabIndex = 7;
            this.panel_ucStatisticScreen.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_ucStatisticScreen_Paint);
            // 
            // labelValue_ucStatisticScreen_totalPaid
            // 
            this.labelValue_ucStatisticScreen_totalPaid.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelValue_ucStatisticScreen_totalPaid.ForeColor = System.Drawing.Color.Red;
            this.labelValue_ucStatisticScreen_totalPaid.Location = new System.Drawing.Point(138, 213);
            this.labelValue_ucStatisticScreen_totalPaid.Name = "labelValue_ucStatisticScreen_totalPaid";
            this.labelValue_ucStatisticScreen_totalPaid.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelValue_ucStatisticScreen_totalPaid.Size = new System.Drawing.Size(227, 16);
            this.labelValue_ucStatisticScreen_totalPaid.TabIndex = 9;
            this.labelValue_ucStatisticScreen_totalPaid.Text = "0đ";
            // 
            // labelValue_ucStatisticScreen_waitingOrder
            // 
            this.labelValue_ucStatisticScreen_waitingOrder.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelValue_ucStatisticScreen_waitingOrder.ForeColor = System.Drawing.Color.Red;
            this.labelValue_ucStatisticScreen_waitingOrder.Location = new System.Drawing.Point(209, 164);
            this.labelValue_ucStatisticScreen_waitingOrder.Name = "labelValue_ucStatisticScreen_waitingOrder";
            this.labelValue_ucStatisticScreen_waitingOrder.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelValue_ucStatisticScreen_waitingOrder.Size = new System.Drawing.Size(156, 16);
            this.labelValue_ucStatisticScreen_waitingOrder.TabIndex = 8;
            this.labelValue_ucStatisticScreen_waitingOrder.Text = "0";
            // 
            // labelValue_ucStatisticScreen_cancelOrder
            // 
            this.labelValue_ucStatisticScreen_cancelOrder.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelValue_ucStatisticScreen_cancelOrder.ForeColor = System.Drawing.Color.Red;
            this.labelValue_ucStatisticScreen_cancelOrder.Location = new System.Drawing.Point(165, 115);
            this.labelValue_ucStatisticScreen_cancelOrder.Name = "labelValue_ucStatisticScreen_cancelOrder";
            this.labelValue_ucStatisticScreen_cancelOrder.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelValue_ucStatisticScreen_cancelOrder.Size = new System.Drawing.Size(200, 16);
            this.labelValue_ucStatisticScreen_cancelOrder.TabIndex = 7;
            this.labelValue_ucStatisticScreen_cancelOrder.Text = "0";
            // 
            // labelValue_ucStatisticScreen_successOrder
            // 
            this.labelValue_ucStatisticScreen_successOrder.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelValue_ucStatisticScreen_successOrder.ForeColor = System.Drawing.Color.Red;
            this.labelValue_ucStatisticScreen_successOrder.Location = new System.Drawing.Point(227, 70);
            this.labelValue_ucStatisticScreen_successOrder.Name = "labelValue_ucStatisticScreen_successOrder";
            this.labelValue_ucStatisticScreen_successOrder.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelValue_ucStatisticScreen_successOrder.Size = new System.Drawing.Size(138, 16);
            this.labelValue_ucStatisticScreen_successOrder.TabIndex = 6;
            this.labelValue_ucStatisticScreen_successOrder.Text = "0";
            // 
            // labelValue_ucStatisticScreen_totalOrder
            // 
            this.labelValue_ucStatisticScreen_totalOrder.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelValue_ucStatisticScreen_totalOrder.ForeColor = System.Drawing.Color.Red;
            this.labelValue_ucStatisticScreen_totalOrder.Location = new System.Drawing.Point(165, 28);
            this.labelValue_ucStatisticScreen_totalOrder.Name = "labelValue_ucStatisticScreen_totalOrder";
            this.labelValue_ucStatisticScreen_totalOrder.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelValue_ucStatisticScreen_totalOrder.Size = new System.Drawing.Size(200, 16);
            this.labelValue_ucStatisticScreen_totalOrder.TabIndex = 5;
            this.labelValue_ucStatisticScreen_totalOrder.Text = "0";
            // 
            // labelText_ucStatisticScreen_waitingOrder
            // 
            this.labelText_ucStatisticScreen_waitingOrder.AutoSize = true;
            this.labelText_ucStatisticScreen_waitingOrder.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelText_ucStatisticScreen_waitingOrder.Location = new System.Drawing.Point(13, 164);
            this.labelText_ucStatisticScreen_waitingOrder.Name = "labelText_ucStatisticScreen_waitingOrder";
            this.labelText_ucStatisticScreen_waitingOrder.Size = new System.Drawing.Size(190, 16);
            this.labelText_ucStatisticScreen_waitingOrder.TabIndex = 4;
            this.labelText_ucStatisticScreen_waitingOrder.Text = "Số đơn hàng chờ xác nhận:";
            // 
            // labelText_ucStatisticScreen_cancelOrder
            // 
            this.labelText_ucStatisticScreen_cancelOrder.AutoSize = true;
            this.labelText_ucStatisticScreen_cancelOrder.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelText_ucStatisticScreen_cancelOrder.Location = new System.Drawing.Point(13, 115);
            this.labelText_ucStatisticScreen_cancelOrder.Name = "labelText_ucStatisticScreen_cancelOrder";
            this.labelText_ucStatisticScreen_cancelOrder.Size = new System.Drawing.Size(146, 16);
            this.labelText_ucStatisticScreen_cancelOrder.TabIndex = 3;
            this.labelText_ucStatisticScreen_cancelOrder.Text = "Số đơn hàng đã hủy:";
            // 
            // labelText_ucStatisticScreen_successOrder
            // 
            this.labelText_ucStatisticScreen_successOrder.AutoSize = true;
            this.labelText_ucStatisticScreen_successOrder.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelText_ucStatisticScreen_successOrder.Location = new System.Drawing.Point(13, 70);
            this.labelText_ucStatisticScreen_successOrder.Name = "labelText_ucStatisticScreen_successOrder";
            this.labelText_ucStatisticScreen_successOrder.Size = new System.Drawing.Size(208, 16);
            this.labelText_ucStatisticScreen_successOrder.TabIndex = 2;
            this.labelText_ucStatisticScreen_successOrder.Text = "Số đơn hàng giao thành công:";
            // 
            // labelText_ucStatisticScreen_totalPaid
            // 
            this.labelText_ucStatisticScreen_totalPaid.AutoSize = true;
            this.labelText_ucStatisticScreen_totalPaid.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelText_ucStatisticScreen_totalPaid.Location = new System.Drawing.Point(13, 213);
            this.labelText_ucStatisticScreen_totalPaid.Name = "labelText_ucStatisticScreen_totalPaid";
            this.labelText_ucStatisticScreen_totalPaid.Size = new System.Drawing.Size(119, 16);
            this.labelText_ucStatisticScreen_totalPaid.TabIndex = 1;
            this.labelText_ucStatisticScreen_totalPaid.Text = "Tổng tiền đã chi:";
            // 
            // labelText_ucStatisticScreen_totalOrder
            // 
            this.labelText_ucStatisticScreen_totalOrder.AutoSize = true;
            this.labelText_ucStatisticScreen_totalOrder.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelText_ucStatisticScreen_totalOrder.Location = new System.Drawing.Point(13, 28);
            this.labelText_ucStatisticScreen_totalOrder.Name = "labelText_ucStatisticScreen_totalOrder";
            this.labelText_ucStatisticScreen_totalOrder.Size = new System.Drawing.Size(144, 16);
            this.labelText_ucStatisticScreen_totalOrder.TabIndex = 0;
            this.labelText_ucStatisticScreen_totalOrder.Text = "Số đơn hàng đã đặt:";
            // 
            // ucStatisticScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel_ucStatisticScreen);
            this.Controls.Add(this.panel_ucHistoryScreen_title);
            this.Name = "ucStatisticScreen";
            this.Size = new System.Drawing.Size(377, 560);
            this.panel_ucHistoryScreen_title.ResumeLayout(false);
            this.panel_ucStatisticScreen.ResumeLayout(false);
            this.panel_ucStatisticScreen.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_ucHistoryScreen_title;
        private System.Windows.Forms.Label labelText_ucStatisticScreen_title;
        private System.Windows.Forms.Panel panel_ucStatisticScreen;
        private System.Windows.Forms.Label labelText_ucStatisticScreen_totalOrder;
        private System.Windows.Forms.Label labelText_ucStatisticScreen_waitingOrder;
        private System.Windows.Forms.Label labelText_ucStatisticScreen_cancelOrder;
        private System.Windows.Forms.Label labelText_ucStatisticScreen_successOrder;
        private System.Windows.Forms.Label labelText_ucStatisticScreen_totalPaid;
        private System.Windows.Forms.Label labelValue_ucStatisticScreen_totalPaid;
        private System.Windows.Forms.Label labelValue_ucStatisticScreen_waitingOrder;
        private System.Windows.Forms.Label labelValue_ucStatisticScreen_cancelOrder;
        private System.Windows.Forms.Label labelValue_ucStatisticScreen_successOrder;
        private System.Windows.Forms.Label labelValue_ucStatisticScreen_totalOrder;
        private System.Windows.Forms.Button button_ucStatisticScreen_backArrow;
    }
}
