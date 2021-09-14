using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BangGiaCuoc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void thanh_toan_click_box(object sender, EventArgs e)
        {
            int so_km = Convert.ToInt32(so_km_text_box.Text);
            int khuyen_mai = Convert.ToInt32(khuyen_mai_text_box.Text) / 100;
            int thanh_toan = 0;
            if (so_km < 5)
            {
                thanh_toan = so_km * 14000;
            }
            else if (so_km > 4 && so_km < 26)
            {
                thanh_toan = 4 * 14000 + (so_km - 4) * 16000;
            }
            else
            {
                thanh_toan = 4 * 14000 + 21 * 16000 + (so_km - 25) * 12000;
            }
            thanh_toan = ((100 - khuyen_mai) / 100 * thanh_toan) / 1000;
            thanh_toan_text_box.Text = string.Format("{0:F3}", thanh_toan).Replace(',', '.');
 

        }
    }
}
