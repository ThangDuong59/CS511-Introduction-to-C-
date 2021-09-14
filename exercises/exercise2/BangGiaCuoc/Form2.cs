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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            home_picturebox.BackColor = Color.SeaGreen;
            giup_viec_nha_groupbox.Location = thong_tin_gio_hang_groupbox.Location;
            thong_tin_gio_hang_groupbox.Visible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void giat_ui_click_box(object sender, EventArgs e)
        {
            System.Globalization.CultureInfo cul = System.Globalization.CultureInfo.GetCultureInfo("vi-VN");  
            if (giat_ui_button.BackColor == Color.Aqua)
            {
                giat_ui_button.BackColor = Color.Teal;
                giat_ui_text_box.Text = double.Parse("100000").ToString("#,###", cul.NumberFormat);
                int thanh_toan;
                if (thanh_toan_text_box.Text == "0")
                {
                    thanh_toan = Convert.ToInt32(thanh_toan_text_box.Text);
                }
                else
                {
                    thanh_toan = Convert.ToInt32(thanh_toan_text_box.Text.Replace(".", ""));
                }
                thanh_toan += 100000;
                thanh_toan_text_box.Text = double.Parse(Convert.ToString(thanh_toan)).ToString("#,###", cul.NumberFormat);
            }
            else
            {
                giat_ui_button.BackColor = Color.Aqua;
                giat_ui_text_box.Text = "0";
                int thanh_toan = Convert.ToInt32(thanh_toan_text_box.Text.Replace(".", ""));
                thanh_toan -= 100000;
                if (thanh_toan == 0)
                {
                    thanh_toan_text_box.Text = "0";
                }
                else
                {
                    thanh_toan_text_box.Text = double.Parse(Convert.ToString(thanh_toan)).ToString("#,###", cul.NumberFormat);
                }
            }
        }

        private void ve_sinh_may_lanh_click_box(object sender, EventArgs e)
        {
            System.Globalization.CultureInfo cul = System.Globalization.CultureInfo.GetCultureInfo("vi-VN");
            if (ve_sinh_may_lanh_button.BackColor == Color.Aqua)
            {
                ve_sinh_may_lanh_button.BackColor = Color.Teal;
                ve_sinh_may_lanh_text_box.Text = double.Parse("150000").ToString("#,###", cul.NumberFormat);
                int thanh_toan;
                if (thanh_toan_text_box.Text == "0")
                {
                    thanh_toan = Convert.ToInt32(thanh_toan_text_box.Text);
                }
                else
                {
                    thanh_toan = Convert.ToInt32(thanh_toan_text_box.Text.Replace(".", ""));
                }
                thanh_toan += 150000;
                thanh_toan_text_box.Text = double.Parse(Convert.ToString(thanh_toan)).ToString("#,###", cul.NumberFormat);
            }
            else
            {
                ve_sinh_may_lanh_button.BackColor = Color.Aqua;
                ve_sinh_may_lanh_text_box.Text = "0";
                int thanh_toan = Convert.ToInt32(thanh_toan_text_box.Text.Replace(".", ""));
                thanh_toan -= 150000;
                if (thanh_toan == 0)
                {
                    thanh_toan_text_box.Text = "0";
                }
                else
                {
                    thanh_toan_text_box.Text = double.Parse(Convert.ToString(thanh_toan)).ToString("#,###", cul.NumberFormat);
                }
            }
        }

        private void don_dep_nha_click_box(object sender, EventArgs e)
        {
            System.Globalization.CultureInfo cul = System.Globalization.CultureInfo.GetCultureInfo("vi-VN");
            if (don_dep_nha_button.BackColor == Color.Aqua)
            {
                don_dep_nha_button.BackColor = Color.Teal;
                don_dep_text_box.Text = double.Parse("200000").ToString("#,###", cul.NumberFormat);
                int thanh_toan;
                if (thanh_toan_text_box.Text == "0")
                {
                    thanh_toan = Convert.ToInt32(thanh_toan_text_box.Text);
                }
                else
                {
                    thanh_toan = Convert.ToInt32(thanh_toan_text_box.Text.Replace(".", ""));
                }
                thanh_toan += 200000;
                thanh_toan_text_box.Text = double.Parse(Convert.ToString(thanh_toan)).ToString("#,###", cul.NumberFormat);
            }
            else
            {
                don_dep_nha_button.BackColor = Color.Aqua;
                don_dep_text_box.Text = "0";
                int thanh_toan = Convert.ToInt32(thanh_toan_text_box.Text.Replace(".", ""));
                thanh_toan -= 200000;
                if (thanh_toan == 0)
                {
                    thanh_toan_text_box.Text = "0";
                }
                else
                {
                    thanh_toan_text_box.Text = double.Parse(Convert.ToString(thanh_toan)).ToString("#,###", cul.NumberFormat);
                }
            }
        }

        private void tong_ve_sinh_click_box(object sender, EventArgs e)
        {
            System.Globalization.CultureInfo cul = System.Globalization.CultureInfo.GetCultureInfo("vi-VN");
            if (tong_ve_sinh_button.BackColor == Color.Aqua)
            {
                tong_ve_sinh_button.BackColor = Color.Teal;
                tong_ve_sinh_text_box.Text = double.Parse("400000").ToString("#,###", cul.NumberFormat);
                int thanh_toan;
                if (thanh_toan_text_box.Text == "0")
                {
                    thanh_toan = Convert.ToInt32(thanh_toan_text_box.Text);
                }
                else
                {
                    thanh_toan = Convert.ToInt32(thanh_toan_text_box.Text.Replace(".", ""));
                }
                thanh_toan += 400000;
                thanh_toan_text_box.Text = double.Parse(Convert.ToString(thanh_toan)).ToString("#,###", cul.NumberFormat);
            }
            else
            {
                tong_ve_sinh_button.BackColor = Color.Aqua;
                tong_ve_sinh_text_box.Text = "0";
                int thanh_toan = Convert.ToInt32(thanh_toan_text_box.Text.Replace(".", ""));
                thanh_toan -= 400000;
                if (thanh_toan == 0)
                {
                    thanh_toan_text_box.Text = "0";
                }
                else
                {
                    thanh_toan_text_box.Text = double.Parse(Convert.ToString(thanh_toan)).ToString("#,###", cul.NumberFormat);
                }
            }
        }
        

        private void dich_vu_khac_click_box(object sender, EventArgs e)
        {
            System.Globalization.CultureInfo cul = System.Globalization.CultureInfo.GetCultureInfo("vi-VN");
            if (dich_vu_khac_button.BackColor == Color.Aqua)
            {
                dich_vu_khac_button.BackColor = Color.Teal;
                dich_vu_khac_text_box.Text = double.Parse("500000").ToString("#,###", cul.NumberFormat);
                int thanh_toan;
                if (thanh_toan_text_box.Text == "0")
                {
                    thanh_toan = Convert.ToInt32(thanh_toan_text_box.Text);
                }
                else
                {
                    thanh_toan = Convert.ToInt32(thanh_toan_text_box.Text.Replace(".", ""));
                }
                thanh_toan += 500000;
                thanh_toan_text_box.Text = double.Parse(Convert.ToString(thanh_toan)).ToString("#,###", cul.NumberFormat);
            }
            else
            {
                dich_vu_khac_button.BackColor = Color.Aqua;
                dich_vu_khac_text_box.Text = "0";
                int thanh_toan = Convert.ToInt32(thanh_toan_text_box.Text.Replace(".", ""));
                thanh_toan -= 500000;
                if (thanh_toan == 0)
                {
                    thanh_toan_text_box.Text = "0";
                }
                else
                {
                    thanh_toan_text_box.Text = double.Parse(Convert.ToString(thanh_toan)).ToString("#,###", cul.NumberFormat);
                }
            }
        }

        private void nau_an_click_box(object sender, EventArgs e)
        {
            System.Globalization.CultureInfo cul = System.Globalization.CultureInfo.GetCultureInfo("vi-VN");
            if (nau_an_button.BackColor == Color.Aqua)
            {
                nau_an_button.BackColor = Color.Teal;
                nau_an_text_box.Text = double.Parse("500000").ToString("#,###", cul.NumberFormat);
                int thanh_toan;
                if (thanh_toan_text_box.Text == "0")
                {
                    thanh_toan = Convert.ToInt32(thanh_toan_text_box.Text);
                }
                else
                {
                    thanh_toan = Convert.ToInt32(thanh_toan_text_box.Text.Replace(".", ""));
                }
                thanh_toan += 500000;
                thanh_toan_text_box.Text = double.Parse(Convert.ToString(thanh_toan)).ToString("#,###", cul.NumberFormat);
            }
            else
            {
                nau_an_button.BackColor = Color.Aqua;
                nau_an_text_box.Text = "0";
                int thanh_toan = Convert.ToInt32(thanh_toan_text_box.Text.Replace(".", ""));
                thanh_toan -= 500000;
                if (thanh_toan == 0)
                {
                    thanh_toan_text_box.Text = "0";
                }
                else
                {
                    thanh_toan_text_box.Text = double.Parse(Convert.ToString(thanh_toan)).ToString("#,###", cul.NumberFormat);
                }
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void home_clickbox(object sender, EventArgs e)
        {
            home_picturebox.BackColor = Color.SeaGreen;
            cart_picturebox.BackColor = Color.White;
            giup_viec_nha_groupbox.Visible = true;
            thong_tin_gio_hang_groupbox.Visible = false;
        }

        private void card_clickbox(object sender, EventArgs e)
        {
            home_picturebox.BackColor = Color.White;
            cart_picturebox.BackColor = Color.SeaGreen;
            giup_viec_nha_groupbox.Visible = false;
            thong_tin_gio_hang_groupbox.Visible = true;
        }

        private void textBox7_TextChanged_2(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
