using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exercise3
{
    public partial class Hotel : Form
    {
        int so_phong_A = 0;
        int so_phong_B = 0;
        int so_phong_C = 0;
       
        DataTable dt = new DataTable();
        int item_index = -1;
        DataTable initialize_datatable()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("MaPhong", typeof(string));
            dt.Columns.Add("LoaiPhong", typeof(string));
            dt.Columns.Add("GiaPhong", typeof(double));
            dt.Columns.Add("TinhTrangPhong", typeof(string));
            dt.Columns.Add("Ngay", typeof(int));

            return dt;
        }
        public Hotel()
        {
            InitializeComponent();
            dt = this.initialize_datatable();
            button_dat_phong.Enabled = false;
            button_huy_phong.Enabled = false;
            button_thanh_toan.Enabled = false;
        }

        string AutoIDRoom(string TypeRoom)
        {
            string IDRoom = "";
            if (TypeRoom == "A")
            {
                IDRoom += "A";
                so_phong_A += 1;
                IDRoom += Convert.ToString(so_phong_A);
            }
            else if (TypeRoom == "B")
            {
                IDRoom += "B";
                so_phong_B += 1;
                IDRoom += Convert.ToString(so_phong_B);
            }
            else
            {
                IDRoom += "C";
                so_phong_C += 1;
                IDRoom += Convert.ToString(so_phong_C);
            }

            return IDRoom;
        }

        private void click_them_phong(object sender, EventArgs e)
        {
            string id_room = this.AutoIDRoom(combobox_loai_phong.Text);
            dt.Rows.Add(id_room, id_room[0], Convert.ToDouble(textbox_gia_phong.Text), (radiobutton_trong.Checked == true) ? "Trong" : "Day", numericupdown_so_ngay_o.Value);
            listView1.Items.Add(id_room, 0);
            textbox_ma_phong.Text = id_room;
            listView1.LargeImageList = imageList1;
            listView1.View = View.LargeIcon;
        }

        private void listview1_itemselectionchange(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            string s = "MaPhong='" + e.Item.Text + "'";
            item_index = e.ItemIndex;
            System.Console.WriteLine("Phong: " + item_index.ToString());
            DataRow[] dr = dt.Select(s);
            textbox_ma_phong.Text = dr[0]["MaPhong"].ToString();
            combobox_loai_phong.Text = dr[0]["LoaiPhong"].ToString();
            textbox_gia_phong.Text = dr[0]["GiaPhong"].ToString();
            if (dr[0]["TinhTrangPhong"].ToString() == "Trong")
            {
                e.Item.BackColor = Color.White;
                radiobutton_trong.Checked = true;
                radiobutton_day.Checked = false;
                button_huy_phong.Enabled = false;
                button_thanh_toan.Enabled = false;
                button_dat_phong.Enabled = true;
            }
            else
            {
                e.Item.BackColor = Color.Red;
                radiobutton_day.Checked = true;
                radiobutton_trong.Checked = false;
                button_dat_phong.Enabled = false;
                button_huy_phong.Enabled = true;
                button_thanh_toan.Enabled = true;
            }
            numericupdown_so_ngay_o.Text = dr[0]["Ngay"].ToString();
        }

        private void click_thanh_toan(object sender, EventArgs e)
        {
            radiobutton_trong.Checked = true;
            radiobutton_day.Checked = false;
            numericupdown_so_ngay_o.Value = 0;

            button_huy_phong.Enabled = false;
            button_thanh_toan.Enabled = false;
            button_dat_phong.Enabled = true;

            dt.Rows[item_index]["Ngay"] = 0;
            dt.Rows[item_index]["TinhTrangPhong"] = "Trong";
            MessageBox.Show("So tien da thanh toan: " + textbox_gia_phong.Text);
        }

        private void click_huy_phong(object sender, EventArgs e)
        {
            radiobutton_trong.Checked = true;
            radiobutton_day.Checked = false;

            button_huy_phong.Enabled = false;
            button_thanh_toan.Enabled = false;
            button_dat_phong.Enabled = true;

            numericupdown_so_ngay_o.Value = 0;
            dt.Rows[item_index]["Ngay"] = 0;
            dt.Rows[item_index]["TinhTrangPhong"] = "Trong";
        }

        private void click_dat_phong(object sender, EventArgs e)
        {
            radiobutton_trong.Checked = false;
            radiobutton_day.Checked = true;

            button_dat_phong.Enabled = false;
            button_thanh_toan.Enabled = true;
            button_huy_phong.Enabled = true;

            dt.Rows[item_index]["Ngay"] = numericupdown_so_ngay_o.Value;
            dt.Rows[item_index]["TinhTrangPhong"] = "Day";
        }
    }
}
