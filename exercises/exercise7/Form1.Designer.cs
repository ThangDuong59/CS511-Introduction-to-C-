
namespace BTH8
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnloadimage = new System.Windows.Forms.Button();
            this.textBox_y = new System.Windows.Forms.TextBox();
            this.textBox_x = new System.Windows.Forms.TextBox();
            this.btnclean = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numpensize = new System.Windows.Forms.NumericUpDown();
            this.btnpencolor = new System.Windows.Forms.Button();
            this.radioButton_FillElipse = new System.Windows.Forms.RadioButton();
            this.radioButton_Elipse = new System.Windows.Forms.RadioButton();
            this.radioButton_String = new System.Windows.Forms.RadioButton();
            this.radioButton_FilRectangle = new System.Windows.Forms.RadioButton();
            this.radioButton_Rectangle = new System.Windows.Forms.RadioButton();
            this.radioButton_line = new System.Windows.Forms.RadioButton();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numpensize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.btnclean);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(987, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(240, 545);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.CadetBlue;
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.btnloadimage);
            this.groupBox3.Controls.Add(this.textBox_y);
            this.groupBox3.Controls.Add(this.textBox_x);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.groupBox3.Location = new System.Drawing.Point(3, 348);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(234, 194);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Image ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(9, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Point X,Y";
            // 
            // btnloadimage
            // 
            this.btnloadimage.BackColor = System.Drawing.Color.DarkGreen;
            this.btnloadimage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnloadimage.ForeColor = System.Drawing.Color.White;
            this.btnloadimage.Location = new System.Drawing.Point(6, 121);
            this.btnloadimage.Name = "btnloadimage";
            this.btnloadimage.Size = new System.Drawing.Size(222, 51);
            this.btnloadimage.TabIndex = 2;
            this.btnloadimage.Text = "Load Image";
            this.btnloadimage.UseVisualStyleBackColor = false;
            this.btnloadimage.Click += new System.EventHandler(this.btnloadimage_Click);
            // 
            // textBox_y
            // 
            this.textBox_y.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBox_y.Location = new System.Drawing.Point(158, 50);
            this.textBox_y.Name = "textBox_y";
            this.textBox_y.Size = new System.Drawing.Size(59, 23);
            this.textBox_y.TabIndex = 1;
            this.textBox_y.Text = "100";
            // 
            // textBox_x
            // 
            this.textBox_x.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBox_x.Location = new System.Drawing.Point(91, 50);
            this.textBox_x.Name = "textBox_x";
            this.textBox_x.Size = new System.Drawing.Size(59, 23);
            this.textBox_x.TabIndex = 0;
            this.textBox_x.Text = "100";
            // 
            // btnclean
            // 
            this.btnclean.BackColor = System.Drawing.Color.Goldenrod;
            this.btnclean.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnclean.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnclean.ForeColor = System.Drawing.Color.White;
            this.btnclean.Location = new System.Drawing.Point(3, 260);
            this.btnclean.Name = "btnclean";
            this.btnclean.Size = new System.Drawing.Size(234, 51);
            this.btnclean.TabIndex = 1;
            this.btnclean.Text = "Clean ";
            this.btnclean.UseVisualStyleBackColor = false;
            this.btnclean.Click += new System.EventHandler(this.btnclean_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.CadetBlue;
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.numpensize);
            this.groupBox2.Controls.Add(this.btnpencolor);
            this.groupBox2.Controls.Add(this.radioButton_FillElipse);
            this.groupBox2.Controls.Add(this.radioButton_Elipse);
            this.groupBox2.Controls.Add(this.radioButton_String);
            this.groupBox2.Controls.Add(this.radioButton_FilRectangle);
            this.groupBox2.Controls.Add(this.radioButton_Rectangle);
            this.groupBox2.Controls.Add(this.radioButton_line);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.groupBox2.Location = new System.Drawing.Point(3, 16);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(234, 244);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Draw";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(9, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Pen Width";
            // 
            // numpensize
            // 
            this.numpensize.Location = new System.Drawing.Point(102, 199);
            this.numpensize.Name = "numpensize";
            this.numpensize.Size = new System.Drawing.Size(120, 26);
            this.numpensize.TabIndex = 7;
            // 
            // btnpencolor
            // 
            this.btnpencolor.BackColor = System.Drawing.Color.Black;
            this.btnpencolor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnpencolor.ForeColor = System.Drawing.Color.White;
            this.btnpencolor.Location = new System.Drawing.Point(7, 138);
            this.btnpencolor.Name = "btnpencolor";
            this.btnpencolor.Size = new System.Drawing.Size(221, 39);
            this.btnpencolor.TabIndex = 6;
            this.btnpencolor.Text = "Pen Color";
            this.btnpencolor.UseVisualStyleBackColor = false;
            this.btnpencolor.Click += new System.EventHandler(this.btnpencolor_Click);
            // 
            // radioButton_FillElipse
            // 
            this.radioButton_FillElipse.AutoSize = true;
            this.radioButton_FillElipse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.radioButton_FillElipse.Location = new System.Drawing.Point(137, 106);
            this.radioButton_FillElipse.Name = "radioButton_FillElipse";
            this.radioButton_FillElipse.Size = new System.Drawing.Size(85, 21);
            this.radioButton_FillElipse.TabIndex = 5;
            this.radioButton_FillElipse.TabStop = true;
            this.radioButton_FillElipse.Text = "Fill Elipse";
            this.radioButton_FillElipse.UseVisualStyleBackColor = true;
            // 
            // radioButton_Elipse
            // 
            this.radioButton_Elipse.AutoSize = true;
            this.radioButton_Elipse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.radioButton_Elipse.Location = new System.Drawing.Point(137, 70);
            this.radioButton_Elipse.Name = "radioButton_Elipse";
            this.radioButton_Elipse.Size = new System.Drawing.Size(64, 21);
            this.radioButton_Elipse.TabIndex = 4;
            this.radioButton_Elipse.TabStop = true;
            this.radioButton_Elipse.Text = "Elipse";
            this.radioButton_Elipse.UseVisualStyleBackColor = true;
            // 
            // radioButton_String
            // 
            this.radioButton_String.AutoSize = true;
            this.radioButton_String.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.radioButton_String.Location = new System.Drawing.Point(137, 34);
            this.radioButton_String.Name = "radioButton_String";
            this.radioButton_String.Size = new System.Drawing.Size(63, 21);
            this.radioButton_String.TabIndex = 3;
            this.radioButton_String.TabStop = true;
            this.radioButton_String.Text = "String";
            this.radioButton_String.UseVisualStyleBackColor = true;
            // 
            // radioButton_FilRectangle
            // 
            this.radioButton_FilRectangle.AutoSize = true;
            this.radioButton_FilRectangle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.radioButton_FilRectangle.Location = new System.Drawing.Point(7, 106);
            this.radioButton_FilRectangle.Name = "radioButton_FilRectangle";
            this.radioButton_FilRectangle.Size = new System.Drawing.Size(111, 21);
            this.radioButton_FilRectangle.TabIndex = 2;
            this.radioButton_FilRectangle.TabStop = true;
            this.radioButton_FilRectangle.Text = "Fill Rectangle";
            this.radioButton_FilRectangle.UseVisualStyleBackColor = true;
            // 
            // radioButton_Rectangle
            // 
            this.radioButton_Rectangle.AutoSize = true;
            this.radioButton_Rectangle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.radioButton_Rectangle.Location = new System.Drawing.Point(7, 70);
            this.radioButton_Rectangle.Name = "radioButton_Rectangle";
            this.radioButton_Rectangle.Size = new System.Drawing.Size(90, 21);
            this.radioButton_Rectangle.TabIndex = 1;
            this.radioButton_Rectangle.TabStop = true;
            this.radioButton_Rectangle.Text = "Rectangle";
            this.radioButton_Rectangle.UseVisualStyleBackColor = true;
            // 
            // radioButton_line
            // 
            this.radioButton_line.AutoSize = true;
            this.radioButton_line.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.radioButton_line.Location = new System.Drawing.Point(7, 34);
            this.radioButton_line.Name = "radioButton_line";
            this.radioButton_line.Size = new System.Drawing.Size(53, 21);
            this.radioButton_line.TabIndex = 0;
            this.radioButton_line.TabStop = true;
            this.radioButton_line.Text = "Line";
            this.radioButton_line.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Enabled = false;
            this.pictureBox1.Location = new System.Drawing.Point(-208, -163);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(223, 174);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1227, 545);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Paint";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numpensize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnloadimage;
        private System.Windows.Forms.TextBox textBox_y;
        private System.Windows.Forms.TextBox textBox_x;
        private System.Windows.Forms.Button btnclean;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown numpensize;
        private System.Windows.Forms.Button btnpencolor;
        private System.Windows.Forms.RadioButton radioButton_FillElipse;
        private System.Windows.Forms.RadioButton radioButton_Elipse;
        private System.Windows.Forms.RadioButton radioButton_String;
        private System.Windows.Forms.RadioButton radioButton_FilRectangle;
        private System.Windows.Forms.RadioButton radioButton_Rectangle;
        private System.Windows.Forms.RadioButton radioButton_line;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

