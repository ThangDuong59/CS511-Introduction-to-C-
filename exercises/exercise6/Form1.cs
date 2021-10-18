using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exercise6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void richTextBox_groupBoxMouse_mouseClick(object sender, MouseEventArgs e)
        {
            label_groupBoxMouse_mouseClick.Text = "MouseClick: Bạn vừa nhấn chuột " + e.ToString();
        }

        private void richTextBox_groupBoxMouse_mouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void richTextBox_groupBoxMouse_mouseDown(object sender, MouseEventArgs e)
        {

        }

        private void richTextBox_groupBoxMouse_mouseUp(object sender, MouseEventArgs e)
        {

        }

        private void richTextBox_groupBoxMouse_mouseMove(object sender, MouseEventArgs e)
        {

        }
    }
}
