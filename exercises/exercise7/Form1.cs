using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTH8
{
    public partial class Form1 : Form
    {
        public List<Dictionary<Pen, Rectangle>> listDictRects = new List<Dictionary<Pen, Rectangle>>();
        public List<Dictionary<SolidBrush, Rectangle>> listDictFilledRects = new List<Dictionary<SolidBrush, Rectangle>>();
        public List<Dictionary<Pen, Rectangle>> listDictEllipses = new List<Dictionary<Pen, Rectangle>>();
        public List<Dictionary<SolidBrush, Rectangle>> listDictFilledEllipses = new List<Dictionary<SolidBrush, Rectangle>>();
        public List<Dictionary<Pen, List<int>>> listDictLines = new List<Dictionary<Pen, List<int>>>();
        public List<Dictionary<SolidBrush, List<int>>> listDictStrings = new List<Dictionary<SolidBrush, List<int>>>();
        public List<PictureBox> listPictureBoxes = new List<PictureBox>();

        Point LocationXY;
        Point LocationX1Y1;
        bool IsMouseDown = false;
        int line1, line2, line3, line4;
        Pen pen = new Pen(Color.Blue,3);
     
        SolidBrush brush1 = new SolidBrush(Color.Red);
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            IsMouseDown = true;
            LocationXY = e.Location;
            line1 = LocationXY.X;
            line2 = LocationXY.Y;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if(IsMouseDown==true)
            {
                LocationX1Y1 = e.Location;
                line3 = LocationX1Y1.X;
                line4 = LocationX1Y1.Y;
                Refresh();
            }
        }
        int s1, s2;
        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            if(IsMouseDown==true)
            {
                LocationX1Y1 = e.Location;
                s1 = LocationX1Y1.X;
                s2 = LocationX1Y1.Y;
                IsMouseDown = false;
                if (radioButton_line.Checked == true)
                {
                    Dictionary<Pen, List<int>> pre_rect = new Dictionary<Pen, List<int>>();
                    pre_rect.Add(new Pen(pen.Color, pen.Width), new List<int> { line1, line2, s1, s2 });
                    listDictLines.Add(pre_rect);
                }
                else if (radioButton_Rectangle.Checked == true)
                {
                    Rectangle rect = GetRect();
                    Dictionary<Pen, Rectangle> pre_rect = new Dictionary<Pen, Rectangle>();
                    pre_rect.Add(new Pen(pen.Color, pen.Width), rect);
                    listDictRects.Add(pre_rect);
                }
                else if (radioButton_FilRectangle.Checked == true)
                {
                    Rectangle rect = GetRect();
                    Dictionary<SolidBrush, Rectangle> pre_filled_rect = new Dictionary<SolidBrush, Rectangle>();
                    pre_filled_rect.Add(new SolidBrush(brush1.Color), rect);
                    listDictFilledRects.Add(pre_filled_rect);
                }
                else if (radioButton_Elipse.Checked == true)
                {
                    Rectangle rect = GetRect();
                    Dictionary<Pen, Rectangle> pre_ellipse = new Dictionary<Pen, Rectangle>();
                    pre_ellipse.Add(new Pen(pen.Color, pen.Width), rect);
                    listDictEllipses.Add(pre_ellipse);
                }
                else if (radioButton_FillElipse.Checked == true)
                {
                    Rectangle rect = GetRect();
                    Dictionary<SolidBrush, Rectangle> pre_filled_ellipse = new Dictionary<SolidBrush, Rectangle>();
                    pre_filled_ellipse.Add(new SolidBrush(brush1.Color), rect);
                    listDictFilledEllipses.Add(pre_filled_ellipse);
                }
                else if (radioButton_String.Checked == true)
                {
                    System.Drawing.Font f = new System.Drawing.Font("Arial", 14);
                    Dictionary<SolidBrush, List<int>> pre_string = new Dictionary<SolidBrush, List<int>>();
                    pre_string.Add(new SolidBrush(brush1.Color), new List<int> { line1, line2 });
                    listDictStrings.Add(pre_string);
                }
            }
        }

        private void btnloadimage_Click(object sender, EventArgs e)
        {
            OpenFileDialog odl = new OpenFileDialog();
            if (odl.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Image image = Image.FromFile(odl.FileName);
                pictureBox1.Image = image;
                pictureBox1.Width = image.Width;       
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                
            }
            Point curr = new Point(Convert.ToInt32(textBox_x.Text), Convert.ToInt32(textBox_y.Text));
            pictureBox1.Location = curr;
            pictureBox1.SendToBack();
            pictureBox1.Visible = true;
            PictureBox pre_pic = new PictureBox();
            pre_pic.Name = pictureBox1.Name;
            pre_pic.Image = pictureBox1.Image;
            pre_pic.Width = pictureBox1.Width;
            pre_pic.Visible = true;
            pre_pic.Location = pictureBox1.Location;
            this.Controls.Add(pre_pic);
            listPictureBoxes.Add(pre_pic);
        }

        private Rectangle GetRect()
        {
            Rectangle rect = new Rectangle();

            rect.X = Math.Min(LocationXY.X, LocationX1Y1.X);
            rect.Y = Math.Min(LocationXY.Y, LocationX1Y1.Y);
            rect.Width = Math.Abs(LocationXY.X - LocationX1Y1.X);
            rect.Height = Math.Abs(LocationXY.Y - LocationX1Y1.Y);

            return rect;
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            foreach (var item in listDictRects)
                e.Graphics.DrawRectangle(item.Keys.First(), item.Values.First());
            foreach (var item in listDictEllipses)
                e.Graphics.DrawEllipse(item.Keys.First(), item.Values.First());
            foreach (var item in listDictFilledRects)
                e.Graphics.FillRectangle(item.Keys.First(), item.Values.First());
            foreach (var item in listDictFilledEllipses)
                e.Graphics.FillEllipse(item.Keys.First(), item.Values.First());
            foreach (var item in listDictLines)
                e.Graphics.DrawLine(item.Keys.First(), item.Values.First()[0], item.Values.First()[1], item.Values.First()[2], item.Values.First()[3]);
            foreach (var item in listDictStrings)
            {
                System.Drawing.Font f = new System.Drawing.Font("Arial", 14);
                e.Graphics.DrawString("Nhom16_ABCD", f, item.Keys.First(), item.Values.First()[0], item.Values.First()[1]);
            }
           

            pen.Width = Convert.ToInt32(numpensize.Text);
            if (radioButton_line.Checked == true)
            {
                e.Graphics.DrawLine(pen, line1, line2, line3, line4);
            }
            else if (radioButton_Rectangle.Checked == true)
            {
                Rectangle rect = GetRect();
                e.Graphics.DrawRectangle(pen, rect);
            }
            else if (radioButton_FilRectangle.Checked == true)
            {
                Rectangle rect = GetRect();
                e.Graphics.FillRectangle(brush1, rect);
            }
            else if (radioButton_Elipse.Checked == true)
            {
                Rectangle rect = GetRect();
                e.Graphics.DrawEllipse(pen, rect);
            }
            else if (radioButton_FillElipse.Checked == true)
            {
                Rectangle rect = GetRect();
                e.Graphics.FillEllipse(brush1, rect);
            }
            else if (radioButton_String.Checked == true)
            {
                System.Drawing.Font f = new System.Drawing.Font("Arial", 14);
                e.Graphics.DrawString("Nhom16_ABCD", f, brush1,line1,line2);
            }

        }

        private void btnpencolor_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            pen.Color = colorDialog1.Color;
            brush1.Color = colorDialog1.Color;          
        }

        private void btnclean_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            g.Clear(Color.White);
            pictureBox1.Image = null;
            pictureBox1.BackColor = Color.White;
            listDictLines.Clear();
            listDictRects.Clear();
            listDictFilledRects.Clear();
            listDictEllipses.Clear();
            listDictFilledEllipses.Clear();
            listDictStrings.Clear();
            foreach (PictureBox pic in listPictureBoxes)
            {
                this.Controls.Remove(pic);
            }
            listPictureBoxes.Clear();
            pictureBox1.Visible = false;
        }
    }
}
