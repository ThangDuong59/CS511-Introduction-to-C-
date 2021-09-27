using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exercise4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void help_about_notepad_click(object sender, EventArgs e)
        {
            MessageBox.Show("Họ tên: Dương Đình Thắng\nMSSV: 19522195");
        }

        private void file_open_click(object sender, EventArgs e)
        {
            OpenFileDialog ofile = new OpenFileDialog();
            if (ofile.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void format_font_click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.Font = fontDialog.Font;
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void format_color_select_text_click(object sender, EventArgs e)
        {
            ColorDialog colorfile = new ColorDialog();
            if (colorfile.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionColor = colorfile.Color;
            }
        }

        private void format_color_background_click(object sender, EventArgs e)
        {
            ColorDialog colorfile = new ColorDialog();
            if (colorfile.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionBackColor = colorfile.Color;
            }
        }
    }
}
