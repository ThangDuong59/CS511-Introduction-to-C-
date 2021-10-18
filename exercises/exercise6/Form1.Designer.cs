namespace exercise6
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
            this.groupBox_mouse = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.richTextBox_groupBoxMouse = new System.Windows.Forms.RichTextBox();
            this.label_groupBoxMouse_mouseClick = new System.Windows.Forms.Label();
            this.label_groupBoxMouse_mouseDoubleClick = new System.Windows.Forms.Label();
            this.label_groupBoxMouse_mouseDown = new System.Windows.Forms.Label();
            this.label_groupBoxMouse_mouseUp = new System.Windows.Forms.Label();
            this.label_groupBoxMouse_mouseMove = new System.Windows.Forms.Label();
            this.richTextBox_groupBoxKey = new System.Windows.Forms.RichTextBox();
            this.label_groupBoxKey_keyPress = new System.Windows.Forms.Label();
            this.label_groupBoxKey_keyDown = new System.Windows.Forms.Label();
            this.label_groupBoxKey_keyUp = new System.Windows.Forms.Label();
            this.groupBox_mouse.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_mouse
            // 
            this.groupBox_mouse.BackColor = System.Drawing.Color.Teal;
            this.groupBox_mouse.Controls.Add(this.label_groupBoxMouse_mouseMove);
            this.groupBox_mouse.Controls.Add(this.label_groupBoxMouse_mouseUp);
            this.groupBox_mouse.Controls.Add(this.label_groupBoxMouse_mouseDown);
            this.groupBox_mouse.Controls.Add(this.label_groupBoxMouse_mouseDoubleClick);
            this.groupBox_mouse.Controls.Add(this.label_groupBoxMouse_mouseClick);
            this.groupBox_mouse.Controls.Add(this.richTextBox_groupBoxMouse);
            this.groupBox_mouse.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_mouse.Location = new System.Drawing.Point(12, 12);
            this.groupBox_mouse.Name = "groupBox_mouse";
            this.groupBox_mouse.Size = new System.Drawing.Size(434, 499);
            this.groupBox_mouse.TabIndex = 0;
            this.groupBox_mouse.TabStop = false;
            this.groupBox_mouse.Text = "Mouse";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.SteelBlue;
            this.groupBox2.Controls.Add(this.label_groupBoxKey_keyUp);
            this.groupBox2.Controls.Add(this.label_groupBoxKey_keyDown);
            this.groupBox2.Controls.Add(this.label_groupBoxKey_keyPress);
            this.groupBox2.Controls.Add(this.richTextBox_groupBoxKey);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(452, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(507, 499);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Key";
            // 
            // richTextBox_groupBoxMouse
            // 
            this.richTextBox_groupBoxMouse.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox_groupBoxMouse.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.richTextBox_groupBoxMouse.Location = new System.Drawing.Point(19, 41);
            this.richTextBox_groupBoxMouse.Name = "richTextBox_groupBoxMouse";
            this.richTextBox_groupBoxMouse.Size = new System.Drawing.Size(397, 62);
            this.richTextBox_groupBoxMouse.TabIndex = 0;
            this.richTextBox_groupBoxMouse.Text = "Hãy nhấp chuột vào đây";
            this.richTextBox_groupBoxMouse.MouseClick += new System.Windows.Forms.MouseEventHandler(this.richTextBox_groupBoxMouse_mouseClick);
            this.richTextBox_groupBoxMouse.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.richTextBox_groupBoxMouse_mouseDoubleClick);
            this.richTextBox_groupBoxMouse.MouseDown += new System.Windows.Forms.MouseEventHandler(this.richTextBox_groupBoxMouse_mouseDown);
            this.richTextBox_groupBoxMouse.MouseMove += new System.Windows.Forms.MouseEventHandler(this.richTextBox_groupBoxMouse_mouseMove);
            this.richTextBox_groupBoxMouse.MouseUp += new System.Windows.Forms.MouseEventHandler(this.richTextBox_groupBoxMouse_mouseUp);
            // 
            // label_groupBoxMouse_mouseClick
            // 
            this.label_groupBoxMouse_mouseClick.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label_groupBoxMouse_mouseClick.Location = new System.Drawing.Point(15, 135);
            this.label_groupBoxMouse_mouseClick.Name = "label_groupBoxMouse_mouseClick";
            this.label_groupBoxMouse_mouseClick.Size = new System.Drawing.Size(401, 25);
            this.label_groupBoxMouse_mouseClick.TabIndex = 1;
            this.label_groupBoxMouse_mouseClick.Text = "MouseClick";
            // 
            // label_groupBoxMouse_mouseDoubleClick
            // 
            this.label_groupBoxMouse_mouseDoubleClick.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label_groupBoxMouse_mouseDoubleClick.Location = new System.Drawing.Point(15, 178);
            this.label_groupBoxMouse_mouseDoubleClick.Name = "label_groupBoxMouse_mouseDoubleClick";
            this.label_groupBoxMouse_mouseDoubleClick.Size = new System.Drawing.Size(401, 25);
            this.label_groupBoxMouse_mouseDoubleClick.TabIndex = 2;
            this.label_groupBoxMouse_mouseDoubleClick.Text = "MouseDoubleClick";
            // 
            // label_groupBoxMouse_mouseDown
            // 
            this.label_groupBoxMouse_mouseDown.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label_groupBoxMouse_mouseDown.Location = new System.Drawing.Point(15, 220);
            this.label_groupBoxMouse_mouseDown.Name = "label_groupBoxMouse_mouseDown";
            this.label_groupBoxMouse_mouseDown.Size = new System.Drawing.Size(401, 25);
            this.label_groupBoxMouse_mouseDown.TabIndex = 3;
            this.label_groupBoxMouse_mouseDown.Text = "MouseDown";
            // 
            // label_groupBoxMouse_mouseUp
            // 
            this.label_groupBoxMouse_mouseUp.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label_groupBoxMouse_mouseUp.Location = new System.Drawing.Point(15, 261);
            this.label_groupBoxMouse_mouseUp.Name = "label_groupBoxMouse_mouseUp";
            this.label_groupBoxMouse_mouseUp.Size = new System.Drawing.Size(401, 25);
            this.label_groupBoxMouse_mouseUp.TabIndex = 4;
            this.label_groupBoxMouse_mouseUp.Text = "MouseUp";
            // 
            // label_groupBoxMouse_mouseMove
            // 
            this.label_groupBoxMouse_mouseMove.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label_groupBoxMouse_mouseMove.Location = new System.Drawing.Point(15, 305);
            this.label_groupBoxMouse_mouseMove.Name = "label_groupBoxMouse_mouseMove";
            this.label_groupBoxMouse_mouseMove.Size = new System.Drawing.Size(401, 25);
            this.label_groupBoxMouse_mouseMove.TabIndex = 5;
            this.label_groupBoxMouse_mouseMove.Text = "MouseMove";
            // 
            // richTextBox_groupBoxKey
            // 
            this.richTextBox_groupBoxKey.Location = new System.Drawing.Point(21, 41);
            this.richTextBox_groupBoxKey.Name = "richTextBox_groupBoxKey";
            this.richTextBox_groupBoxKey.Size = new System.Drawing.Size(464, 62);
            this.richTextBox_groupBoxKey.TabIndex = 1;
            this.richTextBox_groupBoxKey.Text = "";
            // 
            // label_groupBoxKey_keyPress
            // 
            this.label_groupBoxKey_keyPress.ForeColor = System.Drawing.Color.SlateBlue;
            this.label_groupBoxKey_keyPress.Location = new System.Drawing.Point(17, 135);
            this.label_groupBoxKey_keyPress.Name = "label_groupBoxKey_keyPress";
            this.label_groupBoxKey_keyPress.Size = new System.Drawing.Size(231, 68);
            this.label_groupBoxKey_keyPress.TabIndex = 2;
            this.label_groupBoxKey_keyPress.Text = "KeyPress";
            // 
            // label_groupBoxKey_keyDown
            // 
            this.label_groupBoxKey_keyDown.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label_groupBoxKey_keyDown.Location = new System.Drawing.Point(17, 220);
            this.label_groupBoxKey_keyDown.Name = "label_groupBoxKey_keyDown";
            this.label_groupBoxKey_keyDown.Size = new System.Drawing.Size(231, 189);
            this.label_groupBoxKey_keyDown.TabIndex = 3;
            this.label_groupBoxKey_keyDown.Text = "KeyDown";
            // 
            // label_groupBoxKey_keyUp
            // 
            this.label_groupBoxKey_keyUp.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label_groupBoxKey_keyUp.Location = new System.Drawing.Point(254, 220);
            this.label_groupBoxKey_keyUp.Name = "label_groupBoxKey_keyUp";
            this.label_groupBoxKey_keyUp.Size = new System.Drawing.Size(231, 189);
            this.label_groupBoxKey_keyUp.TabIndex = 4;
            this.label_groupBoxKey_keyUp.Text = "KeyUp";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(971, 523);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox_mouse);
            this.Name = "Form1";
            this.Text = "Mouse_Key";
            this.groupBox_mouse.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_mouse;
        private System.Windows.Forms.Label label_groupBoxMouse_mouseMove;
        private System.Windows.Forms.Label label_groupBoxMouse_mouseUp;
        private System.Windows.Forms.Label label_groupBoxMouse_mouseDown;
        private System.Windows.Forms.Label label_groupBoxMouse_mouseDoubleClick;
        private System.Windows.Forms.Label label_groupBoxMouse_mouseClick;
        private System.Windows.Forms.RichTextBox richTextBox_groupBoxMouse;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label_groupBoxKey_keyUp;
        private System.Windows.Forms.Label label_groupBoxKey_keyDown;
        private System.Windows.Forms.Label label_groupBoxKey_keyPress;
        private System.Windows.Forms.RichTextBox richTextBox_groupBoxKey;
    }
}

