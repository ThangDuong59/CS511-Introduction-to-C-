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
    public partial class Form2 : Form
    {
        int steps = 0;
        int white_block_index = 0;
        List<RichTextBox> arr = new List<RichTextBox>();
        public Form2()
        {
            InitializeComponent();
            arr.Add(richTextBox_block1);
            arr.Add(richTextBox_block2);
            arr.Add(richTextBox_block3);
            arr.Add(richTextBox_block4);
            arr.Add(richTextBox_block5);
            arr.Add(richTextBox_block6);
            arr.Add(richTextBox_block7);
            arr.Add(richTextBox_block8);
            arr.Add(richTextBox_block9);
            this.KeyPreview = true;
        }
        private void button_start_click(object sender, EventArgs e)
        {
            arr[0].BackColor = Color.White;
            arr[1].BackColor = Color.Blue;
            arr[2].BackColor = Color.Green;
            arr[3].BackColor = Color.Red;
            arr[4].BackColor = Color.Green;
            arr[5].BackColor = Color.Blue;
            arr[6].BackColor = Color.Green;
            arr[7].BackColor = Color.Blue;
            arr[8].BackColor = Color.Red;
            Random rnd = new Random();
            label_steps.Text = "Steps: 0";
            steps = 0;
            white_block_index = 0;
            int sample = rnd.Next(1, 12);
            if (sample == 1)
            {
                pictureBox_Example.Image = Image.FromFile(@"samples\M11.png");
            }
            else if (sample == 2)
            {
                pictureBox_Example.Image = Image.FromFile(@"samples\M12.png");
            }
            else if (sample == 3)
            {
                pictureBox_Example.Image = Image.FromFile(@"samples\M13.png");
            }
            else if (sample == 4)
            {
                pictureBox_Example.Image = Image.FromFile(@"samples\M14.png");
            }
            else if (sample == 5)
            {
                pictureBox_Example.Image = Image.FromFile(@"samples\M15.png");
            }
            else if (sample == 6)
            {
                pictureBox_Example.Image = Image.FromFile(@"samples\M16.png");
            }
            else if (sample == 7)
            {
                pictureBox_Example.Image = Image.FromFile(@"samples\M17.png");
            }
            else if (sample == 8)
            {
                pictureBox_Example.Image = Image.FromFile(@"samples\M18.png");
            }
            else if (sample == 9)
            {
                pictureBox_Example.Image = Image.FromFile(@"samples\M19.png");
            }
            else if (sample == 10)
            {
                pictureBox_Example.Image = Image.FromFile(@"samples\M20.png");
            }
            pictureBox_Example.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void form_keyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                if (white_block_index == 2 || white_block_index == 5 || white_block_index == 8)
                {
                    return;
                }
                Color temp = arr[white_block_index + 1].BackColor;
                arr[white_block_index + 1].BackColor = arr[white_block_index].BackColor;
                arr[white_block_index].BackColor = temp;
                white_block_index += 1;
            }
            else if (e.KeyCode == Keys.Right)
            {
                if (white_block_index == 0 || white_block_index == 3 || white_block_index == 6)
                {
                    return;
                }
                Color temp = arr[white_block_index - 1].BackColor;
                arr[white_block_index - 1].BackColor = arr[white_block_index].BackColor;
                arr[white_block_index].BackColor = temp;
                white_block_index -= 1;
            }
            else if (e.KeyCode == Keys.Up)
            {
                if (white_block_index == 6 || white_block_index == 7 || white_block_index == 8)
                {
                    return;
                }
                Color temp = arr[white_block_index + 3].BackColor;
                arr[white_block_index + 3].BackColor = arr[white_block_index].BackColor;
                arr[white_block_index].BackColor = temp;
                white_block_index += 3;
            }
            else if (e.KeyCode == Keys.Down)
            {
                if (white_block_index == 0 || white_block_index == 1 || white_block_index == 2)
                {
                    return;
                }
                Color temp = arr[white_block_index - 3].BackColor;
                arr[white_block_index - 3].BackColor = arr[white_block_index].BackColor;
                arr[white_block_index].BackColor = temp;
                white_block_index -= 3;
            }
            steps += 1;
            label_steps.Text = "Steps: " + steps.ToString();
        }

        private void richTextBox_block1_TextChanged(object sender, EventArgs e)
        {

        }

        private void form_keyUp(object sender, KeyEventArgs e)
        {
           
        }
    }
}
