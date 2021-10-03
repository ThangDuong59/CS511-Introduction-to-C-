using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practice01
{
    public partial class form_main : Form
    {
        DataTable dt = new DataTable();
        DataTable accounts_dt = new DataTable();

        int tong_so_tien = 0;
        int MaGD = 0;
        int STTDV = -1;
        bool checkDaDangNhap = false;
        string tenDangNhapHienTai = "";
        DataTable initialize_datatable_transactions()
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("MaGD", typeof(string));
            dt.Columns.Add("STTDV", typeof(string));
            dt.Columns.Add("TenDV", typeof(string));
            dt.Columns.Add("GioiTinh", typeof(string));
            dt.Columns.Add("DoTuoi", typeof(int));
            dt.Columns.Add("DiaChiLamViec", typeof(string));
            dt.Columns.Add("GhiChu", typeof(string));
            dt.Columns.Add("ThanhTien", typeof(string));
            dt.Columns.Add("ThoiGianThucHienGD", typeof(string));

            return dt;
        }

        DataTable initialize_datatable_accounts()
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("TenDangNhap", typeof(string));
            dt.Columns.Add("Ho", typeof(string));
            dt.Columns.Add("Ten", typeof(string));
            dt.Columns.Add("GioiTinh", typeof(string));
            dt.Columns.Add("NgaySinh", typeof(string));
            dt.Columns.Add("SDT", typeof(string));
            dt.Columns.Add("Email", typeof(string));
            dt.Columns.Add("CMND_CCCD", typeof(string));
            dt.Columns.Add("MatKhau", typeof(string));

            return dt;
        }
        public form_main()
        {
            Thread thread = new Thread(new ThreadStart(start_form));
            thread.Start();
            Thread.Sleep(2000);
            InitializeComponent();
            customizeDesign();

            dt = this.initialize_datatable_transactions();
            accounts_dt = this.initialize_datatable_accounts();

            // Tắt visibility của một số objects trong XoetXoet Screen
            panel_xoetXoetScreen_cuaSoChinh.AutoScroll = false;
            panel_xoetXoetScreen_cuaSoChinh.HorizontalScroll.Enabled = false;
            panel_xoetXoetScreen_cuaSoChinh.HorizontalScroll.Visible = false;
            panel_xoetXoetScreen_cuaSoChinh.HorizontalScroll.Maximum = 0;
            panel_xoetXoetScreen_cuaSoChinh.VerticalScroll.Visible = false;
            panel_xoetXoetScreen_cuaSoChinh.AutoScroll = true;

            // Tắt visibility một số objet trong screen cá nhân
            labelText_caNhanScreen_xinChao.Visible = false;

            textBox_dangKyTaiKhoanScreen_matKhau.PasswordChar = '*';
            textBox_dangKyTaiKhoanScreen_nhapLaiMatKhau.PasswordChar = '*';
            textBox_dangNhapScreen_matKhau.PasswordChar = '*';

            // Tắt visibility các listview
            listView_lichSuGDScreen_lichSuGiaoDich.Visible = false;
            listView_thanhToanScreen_danhSachDichVuDaDat.Visible = false;

            thread.Abort();
        }

        public void start_form()
        {
            Application.Run(new Form_Splash_Screen());
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void customizeDesign()
        {
            panel_caNhanScreen_caiDatNgonNguSubMenu.Visible = false;
            panel_caNhanScreen_doiMauUngDungSubMenu.Visible = false;
        }

        private void hideSubMenu()
        {
            if (panel_caNhanScreen_caiDatNgonNguSubMenu.Visible == true)
            {
                panel_caNhanScreen_caiDatNgonNguSubMenu.Visible = false;
            }
            if (panel_caNhanScreen_doiMauUngDungSubMenu.Visible == true)
            {
                panel_caNhanScreen_doiMauUngDungSubMenu.Visible = false;
            }
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listView_thanhToanScreen_danhSachDichVuDaDat.View = View.Details;
            listView_lichSuGDScreen_lichSuGiaoDich.View = View.Details;

            // Thêm vào các trường thông tin hiển thị của list view danh sách dịch vụ
            listView_thanhToanScreen_danhSachDichVuDaDat.Font = new Font(listView_thanhToanScreen_danhSachDichVuDaDat.Font, FontStyle.Bold);
            listView_thanhToanScreen_danhSachDichVuDaDat.Columns.Add("STT", 50);
            listView_thanhToanScreen_danhSachDichVuDaDat.Columns.Add("Dịch vụ", 150);
            listView_thanhToanScreen_danhSachDichVuDaDat.Columns.Add("Thành tiền", 100);

            // Thêm vào các trường thông tin hiển thị của list view lịch sử giao dịch
            listView_lichSuGDScreen_lichSuGiaoDich.Font = new Font(listView_lichSuGDScreen_lichSuGiaoDich.Font, FontStyle.Bold);
            listView_lichSuGDScreen_lichSuGiaoDich.Columns.Add("STT", 50);
            listView_lichSuGDScreen_lichSuGiaoDich.Columns.Add("Ngày giao dịch", 100);
            listView_lichSuGDScreen_lichSuGiaoDich.Columns.Add("Giờ giao dịch", 100);
            listView_lichSuGDScreen_lichSuGiaoDich.Columns.Add("Tổng số tiền", 100);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void richtextbox_click_search_bar(object sender, EventArgs e)
        {
            richTextBox_search_bar.Text = "";
        }

        private void button_click_notifications(object sender, EventArgs e)
        {
            panelScreen_thongBao.Location = new Point(0, 0);
            panelScreen_thongBao.Visible = true;

            panelScreen_main_home_xoetxoet.Visible = false;
            panelScreen_caNhan.Visible = false;
            panelScreen_lichSuGD.Visible = false;
            panelScreen_thongTinChiTiet.Visible = false;
            panelScreen_thanhToan.Visible = false;
            panelScreen_chiTietDichVuDaDat.Visible = false;
            panelScreen_dangKyTaiKhoan.Visible = false;
            panelScreen_dangNhap.Visible = false;
            panelScreen_thongTinTaiKhoan.Visible = false;
        }

        private void button_click_shopping(object sender, EventArgs e)
        {
            panelScreen_thanhToan.Location = new Point(0, 0);
            panelScreen_thanhToan.Visible = true;

            panelScreen_main_home_xoetxoet.Visible = false;
            panelScreen_caNhan.Visible = false;
            panelScreen_lichSuGD.Visible = false;
            panelScreen_thongTinChiTiet.Visible = false;
            panelScreen_thongBao.Visible = false;
            panelScreen_chiTietDichVuDaDat.Visible = false;
            panelScreen_dangKyTaiKhoan.Visible = false;
            panelScreen_dangNhap.Visible = false;
            panelScreen_thongTinTaiKhoan.Visible = false;

            labelValue_thongTinChiTietScreen_thanhTien.Text = "0";
            richTextBox_thongTinChiTietScreen_ghiChu.Text = "";
            richTextBox_thongTinChiTietScreen_diaChiLamViec.Text = "";
        }

        private void button_click_xoetxoet(object sender, EventArgs e)
        {
            panelScreen_main_home_xoetxoet.Location = new Point(0, 0);
            panelScreen_main_home_xoetxoet.Visible = true;

            panelScreen_caNhan.Visible = false;
            panelScreen_thanhToan.Visible = false;
            panelScreen_lichSuGD.Visible = false;
            panelScreen_thongTinChiTiet.Visible = false;
            panelScreen_thongBao.Visible = false;
            panelScreen_chiTietDichVuDaDat.Visible = false;
            panelScreen_dangKyTaiKhoan.Visible = false;
            panelScreen_dangNhap.Visible = false;
            panelScreen_thongTinTaiKhoan.Visible = false;

            labelValue_thongTinChiTietScreen_thanhTien.Text = "0";
            richTextBox_thongTinChiTietScreen_ghiChu.Text = "";
            richTextBox_thongTinChiTietScreen_diaChiLamViec.Text = "";

            if (buttonSub_caNhanScreen_tiengViet.BackColor == Color.LightGreen)
            {
                richTextBox_search_bar.Text = " Tìm kiếm dịch vụ...";
            }
            else if (buttonSub_caNhanScreen_tiengAnh.BackColor == Color.LightGreen)
            {
                richTextBox_search_bar.Text = " Service search...";
            }
            else
            {
                richTextBox_search_bar.Text = " サービスの検索...";
            }


        }

        private void button_click_history(object sender, EventArgs e)
        {
            panelScreen_lichSuGD.Location = new Point(0, 0);
            panelScreen_lichSuGD.Visible = true;

            panelScreen_main_home_xoetxoet.Visible = false;
            panelScreen_caNhan.Visible = false;
            panelScreen_thanhToan.Visible = false;
            panelScreen_thongTinChiTiet.Visible = false;
            panelScreen_thongBao.Visible = false;
            panelScreen_chiTietDichVuDaDat.Visible = false;
            panelScreen_dangKyTaiKhoan.Visible = false;
            panelScreen_dangNhap.Visible = false;
            panelScreen_thongTinTaiKhoan.Visible = false;

            labelValue_thongTinChiTietScreen_thanhTien.Text = "0";
            richTextBox_thongTinChiTietScreen_ghiChu.Text = "";
            richTextBox_thongTinChiTietScreen_diaChiLamViec.Text = "";
        }

        private void button_click_personal(object sender, EventArgs e)
        {
            panelScreen_caNhan.Location = new Point(0, 0);
            panelScreen_caNhan.Visible = true;

            panelScreen_main_home_xoetxoet.Visible = false;
            panelScreen_thanhToan.Visible = false;
            panelScreen_lichSuGD.Visible = false;
            panelScreen_thongTinChiTiet.Visible = false;
            panelScreen_thongBao.Visible = false;
            panelScreen_chiTietDichVuDaDat.Visible = false;
            panelScreen_dangKyTaiKhoan.Visible = false;
            panelScreen_dangNhap.Visible = false;
            panelScreen_thongTinTaiKhoan.Visible = false;

            labelValue_thongTinChiTietScreen_thanhTien.Text = "0";
            richTextBox_thongTinChiTietScreen_ghiChu.Text = "";
            richTextBox_thongTinChiTietScreen_diaChiLamViec.Text = "";
        }

        private void button_click_shopping_left_arrow(object sender, EventArgs e)
        {
            panelScreen_main_home_xoetxoet.Location = new Point(0, 0);
            panelScreen_main_home_xoetxoet.Visible = true;
            
            panelScreen_thongTinChiTiet.Visible = false;
            panelScreen_thanhToan.Visible = false;
            panelScreen_lichSuGD.Visible = false;
            panelScreen_caNhan.Visible = false;
            panelScreen_thongBao.Visible = false;
            panelScreen_chiTietDichVuDaDat.Visible = false;
            panelScreen_dangKyTaiKhoan.Visible = false;
            panelScreen_dangNhap.Visible = false;
            panelScreen_thongTinTaiKhoan.Visible = false;

            labelValue_thongTinChiTietScreen_thanhTien.Text = "0";
            richTextBox_thongTinChiTietScreen_ghiChu.Text = "";
            richTextBox_thongTinChiTietScreen_diaChiLamViec.Text = "";

            if (buttonSub_caNhanScreen_tiengViet.BackColor == Color.LightGreen)
            {
                richTextBox_search_bar.Text = " Tìm kiếm dịch vụ...";
            }
            else if (buttonSub_caNhanScreen_tiengAnh.BackColor == Color.LightGreen)
            {
                richTextBox_search_bar.Text = " Service search...";
            }
            else
            {
                richTextBox_search_bar.Text = " サービスの検索...";
            }
        }

        private void button_click_notifications_left_arrow(object sender, EventArgs e)
        {
            panelScreen_main_home_xoetxoet.Location = new Point(0, 0);
            panelScreen_main_home_xoetxoet.Visible = true;

            panelScreen_thongTinChiTiet.Visible = false;
            panelScreen_thanhToan.Visible = false;
            panelScreen_lichSuGD.Visible = false;
            panelScreen_caNhan.Visible = false;
            panelScreen_thongBao.Visible = false;
            panelScreen_chiTietDichVuDaDat.Visible = false;
            panelScreen_dangKyTaiKhoan.Visible = false;
            panelScreen_dangNhap.Visible = false;
            panelScreen_thongTinTaiKhoan.Visible = false;

            if (buttonSub_caNhanScreen_tiengViet.BackColor == Color.LightGreen)
            {
                richTextBox_search_bar.Text = " Tìm kiếm dịch vụ...";
            }
            else if (buttonSub_caNhanScreen_tiengAnh.BackColor == Color.LightGreen)
            {
                richTextBox_search_bar.Text = " Service search...";
            }
            else
            {
                richTextBox_search_bar.Text = " サービスの検索...";
            }
        }

        private void button_click_giupViecNha(object sender, EventArgs e)
        {
            panelScreen_thongTinChiTiet.Location = new Point(0, 0);
            panelScreen_thongTinChiTiet.Visible = true;

            panelScreen_main_home_xoetxoet.Visible = false;
            panelScreen_thanhToan.Visible = false;
            panelScreen_lichSuGD.Visible = false;
            panelScreen_caNhan.Visible = false;
            panelScreen_thongBao.Visible = false;
            panelScreen_chiTietDichVuDaDat.Visible = false;
            panelScreen_dangKyTaiKhoan.Visible = false;
            panelScreen_dangNhap.Visible = false;
            panelScreen_thongTinTaiKhoan.Visible = false;

            if (buttonSub_caNhanScreen_tiengViet.BackColor == Color.LightGreen)
            {
                labelText_thongTinChiTietScreen_thongTinChiTiet.Text = "Lau dọn";
            }
            else if (buttonSub_caNhanScreen_tiengAnh.BackColor == Color.LightGreen)
            {
                labelText_thongTinChiTietScreen_thongTinChiTiet.Text = "Cleaning";
            }
            else
            {
                labelText_thongTinChiTietScreen_thongTinChiTiet.Text = "掃除";
            }

            labelValue_thongTinChiTietScreen_thanhTien.Text = "500,000";
        }

        private void button_click_trongTre(object sender, EventArgs e)
        {
            panelScreen_thongTinChiTiet.Location = new Point(0, 0);
            panelScreen_thongTinChiTiet.Visible = true;

            panelScreen_main_home_xoetxoet.Visible = false;
            panelScreen_thanhToan.Visible = false;
            panelScreen_lichSuGD.Visible = false;
            panelScreen_caNhan.Visible = false;
            panelScreen_thongBao.Visible = false;
            panelScreen_chiTietDichVuDaDat.Visible = false;
            panelScreen_dangKyTaiKhoan.Visible = false;
            panelScreen_dangNhap.Visible = false;
            panelScreen_thongTinTaiKhoan.Visible = false;

            if (buttonSub_caNhanScreen_tiengViet.BackColor == Color.LightGreen)
            {
                labelText_thongTinChiTietScreen_thongTinChiTiet.Text = "Trông trẻ";
            }
            else if (buttonSub_caNhanScreen_tiengAnh.BackColor == Color.LightGreen)
            {
                labelText_thongTinChiTietScreen_thongTinChiTiet.Text = "Babysitter";
            }
            else
            {
                labelText_thongTinChiTietScreen_thongTinChiTiet.Text = "子供の面倒";
            }
            
            labelValue_thongTinChiTietScreen_thanhTien.Text = "300,000";
        }

        private void button_click_diCho(object sender, EventArgs e)
        {
            panelScreen_thongTinChiTiet.Location = new Point(0, 0);
            panelScreen_thongTinChiTiet.Visible = true;

            panelScreen_main_home_xoetxoet.Visible = false;
            panelScreen_thanhToan.Visible = false;
            panelScreen_lichSuGD.Visible = false;
            panelScreen_caNhan.Visible = false;
            panelScreen_thongBao.Visible = false;
            panelScreen_chiTietDichVuDaDat.Visible = false;
            panelScreen_dangKyTaiKhoan.Visible = false;
            panelScreen_dangNhap.Visible = false;
            panelScreen_thongTinTaiKhoan.Visible = false;

            if (buttonSub_caNhanScreen_tiengViet.BackColor == Color.LightGreen)
            {
                labelText_thongTinChiTietScreen_thongTinChiTiet.Text = "Đi chợ";
            }
            else if (buttonSub_caNhanScreen_tiengAnh.BackColor == Color.LightGreen)
            {
                labelText_thongTinChiTietScreen_thongTinChiTiet.Text = "Shopping";
            }
            else
            {
                labelText_thongTinChiTietScreen_thongTinChiTiet.Text = "お買い物";
            }

            labelValue_thongTinChiTietScreen_thanhTien.Text = "100,000";
        }

        private void button_click_giatUi(object sender, EventArgs e)
        {
            panelScreen_thongTinChiTiet.Location = new Point(0, 0);
            panelScreen_thongTinChiTiet.Visible = true;

            panelScreen_main_home_xoetxoet.Visible = false;
            panelScreen_thanhToan.Visible = false;
            panelScreen_lichSuGD.Visible = false;
            panelScreen_caNhan.Visible = false;
            panelScreen_thongBao.Visible = false;
            panelScreen_chiTietDichVuDaDat.Visible = false;
            panelScreen_dangKyTaiKhoan.Visible = false;
            panelScreen_dangNhap.Visible = false;
            panelScreen_thongTinTaiKhoan.Visible = false;

            if (buttonSub_caNhanScreen_tiengViet.BackColor == Color.LightGreen)
            {
                labelText_thongTinChiTietScreen_thongTinChiTiet.Text = "Giặt ủi";
            }
            else if (buttonSub_caNhanScreen_tiengAnh.BackColor == Color.LightGreen)
            {
                labelText_thongTinChiTietScreen_thongTinChiTiet.Text = "Laundry";
            }
            else
            {
                labelText_thongTinChiTietScreen_thongTinChiTiet.Text = "洗濯";
            }

            labelValue_thongTinChiTietScreen_thanhTien.Text = "100,000";
        }

        private void button_click_nauAn(object sender, EventArgs e)
        {
            panelScreen_thongTinChiTiet.Location = new Point(0, 0);
            panelScreen_thongTinChiTiet.Visible = true;

            panelScreen_main_home_xoetxoet.Visible = false;
            panelScreen_thanhToan.Visible = false;
            panelScreen_lichSuGD.Visible = false;
            panelScreen_caNhan.Visible = false;
            panelScreen_thongBao.Visible = false;
            panelScreen_chiTietDichVuDaDat.Visible = false;
            panelScreen_dangKyTaiKhoan.Visible = false;
            panelScreen_dangNhap.Visible = false;
            panelScreen_thongTinTaiKhoan.Visible = false;

            if (buttonSub_caNhanScreen_tiengViet.BackColor == Color.LightGreen)
            {
                labelText_thongTinChiTietScreen_thongTinChiTiet.Text = "Nấu ăn";
            }
            else if (buttonSub_caNhanScreen_tiengAnh.BackColor == Color.LightGreen)
            {
                labelText_thongTinChiTietScreen_thongTinChiTiet.Text = "Cooking";
            }
            else
            {
                labelText_thongTinChiTietScreen_thongTinChiTiet.Text = "クッキング";
            }

            labelValue_thongTinChiTietScreen_thanhTien.Text = "200,000";
        }

        private void button_click_lauKinh(object sender, EventArgs e)
        {
            panelScreen_thongTinChiTiet.Location = new Point(0, 0);
            panelScreen_thongTinChiTiet.Visible = true;

            panelScreen_main_home_xoetxoet.Visible = false;
            panelScreen_thanhToan.Visible = false;
            panelScreen_lichSuGD.Visible = false;
            panelScreen_caNhan.Visible = false;
            panelScreen_thongBao.Visible = false;
            panelScreen_chiTietDichVuDaDat.Visible = false;
            panelScreen_dangKyTaiKhoan.Visible = false;
            panelScreen_dangNhap.Visible = false;
            panelScreen_thongTinTaiKhoan.Visible = false;

            if (buttonSub_caNhanScreen_tiengViet.BackColor == Color.LightGreen)
            {
                labelText_thongTinChiTietScreen_thongTinChiTiet.Text = "Lau kính";
            }
            else if (buttonSub_caNhanScreen_tiengAnh.BackColor == Color.LightGreen)
            {
                labelText_thongTinChiTietScreen_thongTinChiTiet.Text = "Glasses Washing";
            }
            else
            {
                labelText_thongTinChiTietScreen_thongTinChiTiet.Text = "ガラス磨き";
            }

            labelValue_thongTinChiTietScreen_thanhTien.Text = "150,000";
        }

        private void button_click_ruaXe(object sender, EventArgs e)
        {
            panelScreen_thongTinChiTiet.Location = new Point(0, 0);
            panelScreen_thongTinChiTiet.Visible = true;

            panelScreen_main_home_xoetxoet.Visible = false;
            panelScreen_thanhToan.Visible = false;
            panelScreen_lichSuGD.Visible = false;
            panelScreen_caNhan.Visible = false;
            panelScreen_thongBao.Visible = false;
            panelScreen_chiTietDichVuDaDat.Visible = false;
            panelScreen_dangKyTaiKhoan.Visible = false;
            panelScreen_dangNhap.Visible = false;
            panelScreen_thongTinTaiKhoan.Visible = false;

            if (buttonSub_caNhanScreen_tiengViet.BackColor == Color.LightGreen)
            {
                labelText_thongTinChiTietScreen_thongTinChiTiet.Text = "Rửa xe";
            }
            else if (buttonSub_caNhanScreen_tiengAnh.BackColor == Color.LightGreen)
            {
                labelText_thongTinChiTietScreen_thongTinChiTiet.Text = "Car Washing";
            }
            else
            {
                labelText_thongTinChiTietScreen_thongTinChiTiet.Text = "洗車";
            }

            labelValue_thongTinChiTietScreen_thanhTien.Text = "100,000";
        }

        private void button_click_chuyenPhat(object sender, EventArgs e)
        {
            panelScreen_thongTinChiTiet.Location = new Point(0, 0);
            panelScreen_thongTinChiTiet.Visible = true;

            panelScreen_main_home_xoetxoet.Visible = false;
            panelScreen_thanhToan.Visible = false;
            panelScreen_lichSuGD.Visible = false;
            panelScreen_caNhan.Visible = false;
            panelScreen_thongBao.Visible = false;
            panelScreen_chiTietDichVuDaDat.Visible = false;
            panelScreen_dangKyTaiKhoan.Visible = false;
            panelScreen_dangNhap.Visible = false;
            panelScreen_thongTinTaiKhoan.Visible = false;

            if (buttonSub_caNhanScreen_tiengViet.BackColor == Color.LightGreen)
            {
                labelText_thongTinChiTietScreen_thongTinChiTiet.Text = "Chuyển phát";
            }
            else if (buttonSub_caNhanScreen_tiengAnh.BackColor == Color.LightGreen)
            {
                labelText_thongTinChiTietScreen_thongTinChiTiet.Text = "Delivery";
            }
            else
            {
                labelText_thongTinChiTietScreen_thongTinChiTiet.Text = "配送";
            }

            labelValue_thongTinChiTietScreen_thanhTien.Text = "100,000";
        }

        private void button_click_trongNha(object sender, EventArgs e)
        {
            panelScreen_thongTinChiTiet.Location = new Point(0, 0);
            panelScreen_thongTinChiTiet.Visible = true;

            panelScreen_main_home_xoetxoet.Visible = false;
            panelScreen_thanhToan.Visible = false;
            panelScreen_lichSuGD.Visible = false;
            panelScreen_caNhan.Visible = false;
            panelScreen_thongBao.Visible = false;
            panelScreen_chiTietDichVuDaDat.Visible = false;
            panelScreen_dangKyTaiKhoan.Visible = false;
            panelScreen_dangNhap.Visible = false;
            panelScreen_thongTinTaiKhoan.Visible = false;

            if (buttonSub_caNhanScreen_tiengViet.BackColor == Color.LightGreen)
            {
                labelText_thongTinChiTietScreen_thongTinChiTiet.Text = "Trông nhà";
            }
            else if (buttonSub_caNhanScreen_tiengAnh.BackColor == Color.LightGreen)
            {
                labelText_thongTinChiTietScreen_thongTinChiTiet.Text = "Security";
            }
            else
            {
                labelText_thongTinChiTietScreen_thongTinChiTiet.Text = "留守番";
            }

            labelValue_thongTinChiTietScreen_thanhTien.Text = "200,000";
        }

        private void button_click_suaChuaDienMay(object sender, EventArgs e)
        {
            panelScreen_thongTinChiTiet.Location = new Point(0, 0);
            panelScreen_thongTinChiTiet.Visible = true;

            panelScreen_main_home_xoetxoet.Visible = false;
            panelScreen_thanhToan.Visible = false;
            panelScreen_lichSuGD.Visible = false;
            panelScreen_caNhan.Visible = false;
            panelScreen_thongBao.Visible = false;
            panelScreen_chiTietDichVuDaDat.Visible = false;
            panelScreen_dangKyTaiKhoan.Visible = false;
            panelScreen_dangNhap.Visible = false;
            panelScreen_thongTinTaiKhoan.Visible = false;

            if (buttonSub_caNhanScreen_tiengViet.BackColor == Color.LightGreen)
            {
                labelText_thongTinChiTietScreen_thongTinChiTiet.Text = "Sửa chữa điện máy";
            }
            else if (buttonSub_caNhanScreen_tiengAnh.BackColor == Color.LightGreen)
            {
                labelText_thongTinChiTietScreen_thongTinChiTiet.Text = "Repairman";
            }
            else
            {
                labelText_thongTinChiTietScreen_thongTinChiTiet.Text = "機械修理";
            }

            labelValue_thongTinChiTietScreen_thanhTien.Text = "150,000";
        }

        private void button_click_trangTriNoiThat(object sender, EventArgs e)
        {
            panelScreen_thongTinChiTiet.Location = new Point(0, 0);
            panelScreen_thongTinChiTiet.Visible = true;

            panelScreen_main_home_xoetxoet.Visible = false;
            panelScreen_thanhToan.Visible = false;
            panelScreen_lichSuGD.Visible = false;
            panelScreen_caNhan.Visible = false;
            panelScreen_thongBao.Visible = false;
            panelScreen_chiTietDichVuDaDat.Visible = false;
            panelScreen_dangKyTaiKhoan.Visible = false;
            panelScreen_dangNhap.Visible = false;
            panelScreen_thongTinTaiKhoan.Visible = false;

            if (buttonSub_caNhanScreen_tiengViet.BackColor == Color.LightGreen)
            {
                labelText_thongTinChiTietScreen_thongTinChiTiet.Text = "Trang trí nội thất";
            }
            else if (buttonSub_caNhanScreen_tiengAnh.BackColor == Color.LightGreen)
            {
                labelText_thongTinChiTietScreen_thongTinChiTiet.Text = "Decorating";
            }
            else
            {
                labelText_thongTinChiTietScreen_thongTinChiTiet.Text = "インテリアデザイン";
            }

            labelValue_thongTinChiTietScreen_thanhTien.Text = "500,000";
        }

        private void button_click_dietConTrung(object sender, EventArgs e)
        {
            panelScreen_thongTinChiTiet.Location = new Point(0, 0);
            panelScreen_thongTinChiTiet.Visible = true;

            panelScreen_main_home_xoetxoet.Visible = false;
            panelScreen_thanhToan.Visible = false;
            panelScreen_lichSuGD.Visible = false;
            panelScreen_caNhan.Visible = false;
            panelScreen_thongBao.Visible = false;
            panelScreen_chiTietDichVuDaDat.Visible = false;
            panelScreen_dangKyTaiKhoan.Visible = false;
            panelScreen_dangNhap.Visible = false;
            panelScreen_thongTinTaiKhoan.Visible = false;

            if (buttonSub_caNhanScreen_tiengViet.BackColor == Color.LightGreen)
            {
                labelText_thongTinChiTietScreen_thongTinChiTiet.Text = "Diệt côn trùng";
            }
            else if (buttonSub_caNhanScreen_tiengAnh.BackColor == Color.LightGreen)
            {
                labelText_thongTinChiTietScreen_thongTinChiTiet.Text = "Exterminator";
            }
            else
            {
                labelText_thongTinChiTietScreen_thongTinChiTiet.Text = "殺虫消毒";
            }

            labelValue_thongTinChiTietScreen_thanhTien.Text = "200,000";
        }

        private void button_click_veSinhDieuHoa(object sender, EventArgs e)
        {
            panelScreen_thongTinChiTiet.Location = new Point(0, 0);
            panelScreen_thongTinChiTiet.Visible = true;

            panelScreen_main_home_xoetxoet.Visible = false;
            panelScreen_thanhToan.Visible = false;
            panelScreen_lichSuGD.Visible = false;
            panelScreen_caNhan.Visible = false;
            panelScreen_thongBao.Visible = false;
            panelScreen_chiTietDichVuDaDat.Visible = false;
            panelScreen_dangKyTaiKhoan.Visible = false;
            panelScreen_dangNhap.Visible = false;
            panelScreen_thongTinTaiKhoan.Visible = false;

            if (buttonSub_caNhanScreen_tiengViet.BackColor == Color.LightGreen)
            {
                labelText_thongTinChiTietScreen_thongTinChiTiet.Text = "Vệ sinh điều hòa";
            }
            else if (buttonSub_caNhanScreen_tiengAnh.BackColor == Color.LightGreen)
            {
                labelText_thongTinChiTietScreen_thongTinChiTiet.Text = "AC Cleaning";
            }
            else
            {
                labelText_thongTinChiTietScreen_thongTinChiTiet.Text = "エアコン掃除";
            }

            labelValue_thongTinChiTietScreen_thanhTien.Text = "150,000";
        }

        private void button_click_chuyenNha(object sender, EventArgs e)
        {
            panelScreen_thongTinChiTiet.Location = new Point(0, 0);
            panelScreen_thongTinChiTiet.Visible = true;

            panelScreen_main_home_xoetxoet.Visible = false;
            panelScreen_thanhToan.Visible = false;
            panelScreen_lichSuGD.Visible = false;
            panelScreen_caNhan.Visible = false;
            panelScreen_thongBao.Visible = false;
            panelScreen_chiTietDichVuDaDat.Visible = false;
            panelScreen_dangKyTaiKhoan.Visible = false;
            panelScreen_dangNhap.Visible = false;
            panelScreen_thongTinTaiKhoan.Visible = false;

            if (buttonSub_caNhanScreen_tiengViet.BackColor == Color.LightGreen)
            {
                labelText_thongTinChiTietScreen_thongTinChiTiet.Text = "Chuyển nhà";
            }
            else if (buttonSub_caNhanScreen_tiengAnh.BackColor == Color.LightGreen)
            {
                labelText_thongTinChiTietScreen_thongTinChiTiet.Text = "Moving home";
            }
            else
            {
                labelText_thongTinChiTietScreen_thongTinChiTiet.Text = "引っ越し";
            }

            labelValue_thongTinChiTietScreen_thanhTien.Text = "500,000";
        }

        private void button_click_diCho_2(object sender, EventArgs e)
        {
            this.button_click_diCho(sender, e);
        }

        private void button_click_trongTre_2(object sender, EventArgs e)
        {
            this.button_click_diCho(sender, e);
        }

        private void button_click_giupViecNha_2(object sender, EventArgs e)
        {
            this.button_click_giupViecNha(sender, e);
        }

        private void button_click_service_details_confirm(object sender, EventArgs e)
        {
            if (checkDaDangNhap == false)
            {
                string message = "";
                if (buttonSub_caNhanScreen_tiengViet.BackColor == Color.LightGreen)
                {
                    message = "Bạn cần đăng nhập để thực hiện giao dịch";
                }
                else if (buttonSub_caNhanScreen_tiengAnh.BackColor == Color.LightGreen)
                {
                    message = "You need to login to make a transaction";
                }
                else
                {
                    message = "取引を行うにはログインする必要があります";
                }
                this.button_click_shopping_left_arrow(sender, e);
                MessageBox.Show(message);
            }
            else if (richTextBox_thongTinChiTietScreen_diaChiLamViec.Text == "")
            {
                string message = "";
                if (buttonSub_caNhanScreen_tiengViet.BackColor == Color.LightGreen)
                {
                    message = "Xin quý khách vui lòng cung cấp thông tin địa chỉ";
                }
                else if (buttonSub_caNhanScreen_tiengAnh.BackColor == Color.LightGreen)
                {
                    message = "Please provide address information";
                }
                else
                {
                    message = "住所情報を入力してください";
                }
                MessageBox.Show(message);
            }
            else
            {
                // Cộng dồng tiền dịch vụ vào tổng tiền
                System.Globalization.CultureInfo cul = System.Globalization.CultureInfo.GetCultureInfo("vi-VN");
                tong_so_tien += Convert.ToInt32(labelValue_thongTinChiTietScreen_thanhTien.Text.Replace(",", ""));
                labelValue_thanhToanScreen_tongSoTien.Text = double.Parse(Convert.ToString(tong_so_tien)).ToString("#,###", cul.NumberFormat);

                // Ẩn label hiện chưa chọn dịch vụ nào
                labelText_thanhToanScreen_hienTaiChuaChonDichVuNao.Visible = false;

                // Thêm dữ liệu dịch vụ đã xác nhận vào data table
                STTDV += 1;
                DateTime VietNam_time_now = TimeZoneInfo.ConvertTime(DateTime.Now, TimeZoneInfo.Local, TimeZoneInfo.FindSystemTimeZoneById("SE Asia Standard Time"));
                dt.Rows.Add(Convert.ToString(MaGD), Convert.ToString(STTDV), labelText_thongTinChiTietScreen_thongTinChiTiet.Text, comboBox_thongTinChiTietScreen_gioiTinh.Text, numericUpDown_thongTinChiTietScreen_doTuoi.Value, richTextBox_thongTinChiTietScreen_diaChiLamViec.Text, richTextBox_thongTinChiTietScreen_ghiChu.Text, labelValue_thongTinChiTietScreen_thanhTien.Text, VietNam_time_now.ToString("dd/MM/yyyy | HH:mm:ss"));

                // Thêm vào danh sách dịch vụ đã đặt (vào trong list view)
                string[] row = {Convert.ToString(STTDV + 1), labelText_thongTinChiTietScreen_thongTinChiTiet.Text, labelValue_thongTinChiTietScreen_thanhTien.Text };
                ListViewItem item = new ListViewItem(row);
                listView_thanhToanScreen_danhSachDichVuDaDat.Items.Add(item);

                // Xóa toàn bộ thông tin giao dịch trước đó
                labelValue_thongTinChiTietScreen_thanhTien.Text = "0";
                richTextBox_thongTinChiTietScreen_ghiChu.Text = "";
                richTextBox_thongTinChiTietScreen_diaChiLamViec.Text = "";

                // Quay lại màn hình chính
                panelScreen_main_home_xoetxoet.Location = new Point(0, 0);
                panelScreen_main_home_xoetxoet.Visible = true;

                panelScreen_caNhan.Visible = false;
                panelScreen_thanhToan.Visible = false;
                panelScreen_lichSuGD.Visible = false;
                panelScreen_thongTinChiTiet.Visible = false;
                panelScreen_thongBao.Visible = false;
                panelScreen_chiTietDichVuDaDat.Visible = false;
                panelScreen_dangKyTaiKhoan.Visible = false;
                panelScreen_dangNhap.Visible = false;
                panelScreen_thongTinTaiKhoan.Visible = false;

                if (buttonSub_caNhanScreen_tiengViet.BackColor == Color.LightGreen)
                {
                    richTextBox_search_bar.Text = " Tìm kiếm dịch vụ...";
                }
                else if (buttonSub_caNhanScreen_tiengAnh.BackColor == Color.LightGreen)
                {
                    richTextBox_search_bar.Text = " Service search...";
                }
                else
                {
                    richTextBox_search_bar.Text = " サービスの検索...";
                }
            }
        }

        private void richtextbox_keyDown_search_bar(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (richTextBox_search_bar.Text.ToLower().Trim() == "lau dọn")
                {
                    panelScreen_thongTinChiTiet.Location = new Point(0, 0);
                    panelScreen_thongTinChiTiet.Visible = true;

                    panelScreen_main_home_xoetxoet.Visible = false;
                    panelScreen_thanhToan.Visible = false;
                    panelScreen_lichSuGD.Visible = false;
                    panelScreen_caNhan.Visible = false;
                    panelScreen_thongBao.Visible = false;
                    panelScreen_chiTietDichVuDaDat.Visible = false;
                    panelScreen_dangKyTaiKhoan.Visible = false;
                    panelScreen_dangNhap.Visible = false;
                    panelScreen_thongTinTaiKhoan.Visible = false;

                    if (buttonSub_caNhanScreen_tiengViet.BackColor == Color.LightGreen)
                    {
                        labelText_thongTinChiTietScreen_thongTinChiTiet.Text = "Lau dọn";
                    }
                    else if (buttonSub_caNhanScreen_tiengAnh.BackColor == Color.LightGreen)
                    {
                        labelText_thongTinChiTietScreen_thongTinChiTiet.Text = "Cleaning";
                    }
                    else
                    {
                        labelText_thongTinChiTietScreen_thongTinChiTiet.Text = "掃除";
                    }

                    labelValue_thongTinChiTietScreen_thanhTien.Text = "500,000";
                }
                else if (richTextBox_search_bar.Text.ToLower().Trim() == "trông trẻ")
                {
                    panelScreen_thongTinChiTiet.Location = new Point(0, 0);
                    panelScreen_thongTinChiTiet.Visible = true;

                    panelScreen_main_home_xoetxoet.Visible = false;
                    panelScreen_thanhToan.Visible = false;
                    panelScreen_lichSuGD.Visible = false;
                    panelScreen_caNhan.Visible = false;
                    panelScreen_thongBao.Visible = false;
                    panelScreen_chiTietDichVuDaDat.Visible = false;
                    panelScreen_dangKyTaiKhoan.Visible = false;
                    panelScreen_dangNhap.Visible = false;
                    panelScreen_thongTinTaiKhoan.Visible = false;

                    if (buttonSub_caNhanScreen_tiengViet.BackColor == Color.LightGreen)
                    {
                        labelText_thongTinChiTietScreen_thongTinChiTiet.Text = "Trông trẻ";
                    }
                    else if (buttonSub_caNhanScreen_tiengAnh.BackColor == Color.LightGreen)
                    {
                        labelText_thongTinChiTietScreen_thongTinChiTiet.Text = "Babysitter";
                    }
                    else
                    {
                        labelText_thongTinChiTietScreen_thongTinChiTiet.Text = "子供の面倒";
                    }

                    labelValue_thongTinChiTietScreen_thanhTien.Text = "300,000";
                }
                else if (richTextBox_search_bar.Text.ToLower().Trim() == "đi chợ")
                {
                    panelScreen_thongTinChiTiet.Location = new Point(0, 0);
                    panelScreen_thongTinChiTiet.Visible = true;

                    panelScreen_main_home_xoetxoet.Visible = false;
                    panelScreen_thanhToan.Visible = false;
                    panelScreen_lichSuGD.Visible = false;
                    panelScreen_caNhan.Visible = false;
                    panelScreen_thongBao.Visible = false;
                    panelScreen_chiTietDichVuDaDat.Visible = false;
                    panelScreen_dangKyTaiKhoan.Visible = false;
                    panelScreen_dangNhap.Visible = false;
                    panelScreen_thongTinTaiKhoan.Visible = false;

                    if (buttonSub_caNhanScreen_tiengViet.BackColor == Color.LightGreen)
                    {
                        labelText_thongTinChiTietScreen_thongTinChiTiet.Text = "Đi chợ";
                    }
                    else if (buttonSub_caNhanScreen_tiengAnh.BackColor == Color.LightGreen)
                    {
                        labelText_thongTinChiTietScreen_thongTinChiTiet.Text = "Shopping";
                    }
                    else
                    {
                        labelText_thongTinChiTietScreen_thongTinChiTiet.Text = "お買い物";
                    }

                    labelValue_thongTinChiTietScreen_thanhTien.Text = "100,000";
                }
                else if (richTextBox_search_bar.Text.ToLower().Trim() == "giặt ủi")
                {
                    panelScreen_thongTinChiTiet.Location = new Point(0, 0);
                    panelScreen_thongTinChiTiet.Visible = true;

                    panelScreen_main_home_xoetxoet.Visible = false;
                    panelScreen_thanhToan.Visible = false;
                    panelScreen_lichSuGD.Visible = false;
                    panelScreen_caNhan.Visible = false;
                    panelScreen_thongBao.Visible = false;
                    panelScreen_chiTietDichVuDaDat.Visible = false;
                    panelScreen_dangKyTaiKhoan.Visible = false;
                    panelScreen_dangNhap.Visible = false;
                    panelScreen_thongTinTaiKhoan.Visible = false;

                    if (buttonSub_caNhanScreen_tiengViet.BackColor == Color.LightGreen)
                    {
                        labelText_thongTinChiTietScreen_thongTinChiTiet.Text = "Giặt ủi";
                    }
                    else if (buttonSub_caNhanScreen_tiengAnh.BackColor == Color.LightGreen)
                    {
                        labelText_thongTinChiTietScreen_thongTinChiTiet.Text = "Laundry";
                    }
                    else
                    {
                        labelText_thongTinChiTietScreen_thongTinChiTiet.Text = "洗濯";
                    }

                    labelValue_thongTinChiTietScreen_thanhTien.Text = "100,000";
                }
                else if (richTextBox_search_bar.Text.ToLower().Trim() == "nấu ăn")
                {
                    panelScreen_thongTinChiTiet.Location = new Point(0, 0);
                    panelScreen_thongTinChiTiet.Visible = true;

                    panelScreen_main_home_xoetxoet.Visible = false;
                    panelScreen_thanhToan.Visible = false;
                    panelScreen_lichSuGD.Visible = false;
                    panelScreen_caNhan.Visible = false;
                    panelScreen_thongBao.Visible = false;
                    panelScreen_chiTietDichVuDaDat.Visible = false;
                    panelScreen_dangKyTaiKhoan.Visible = false;
                    panelScreen_dangNhap.Visible = false;
                    panelScreen_thongTinTaiKhoan.Visible = false;

                    if (buttonSub_caNhanScreen_tiengViet.BackColor == Color.LightGreen)
                    {
                        labelText_thongTinChiTietScreen_thongTinChiTiet.Text = "Nấu ăn";
                    }
                    else if (buttonSub_caNhanScreen_tiengAnh.BackColor == Color.LightGreen)
                    {
                        labelText_thongTinChiTietScreen_thongTinChiTiet.Text = "Cooking";
                    }
                    else
                    {
                        labelText_thongTinChiTietScreen_thongTinChiTiet.Text = "クッキング";
                    }

                    labelValue_thongTinChiTietScreen_thanhTien.Text = "200,000";
                }
                else if (richTextBox_search_bar.Text.ToLower().Trim() == "lau kính")
                {
                    panelScreen_thongTinChiTiet.Location = new Point(0, 0);
                    panelScreen_thongTinChiTiet.Visible = true;

                    panelScreen_main_home_xoetxoet.Visible = false;
                    panelScreen_thanhToan.Visible = false;
                    panelScreen_lichSuGD.Visible = false;
                    panelScreen_caNhan.Visible = false;
                    panelScreen_thongBao.Visible = false;
                    panelScreen_chiTietDichVuDaDat.Visible = false;
                    panelScreen_dangKyTaiKhoan.Visible = false;
                    panelScreen_dangNhap.Visible = false;
                    panelScreen_thongTinTaiKhoan.Visible = false;

                    if (buttonSub_caNhanScreen_tiengViet.BackColor == Color.LightGreen)
                    {
                        labelText_thongTinChiTietScreen_thongTinChiTiet.Text = "Lau kính";
                    }
                    else if (buttonSub_caNhanScreen_tiengAnh.BackColor == Color.LightGreen)
                    {
                        labelText_thongTinChiTietScreen_thongTinChiTiet.Text = "Glasses Washing";
                    }
                    else
                    {
                        labelText_thongTinChiTietScreen_thongTinChiTiet.Text = "ガラス磨き";
                    }

                    labelValue_thongTinChiTietScreen_thanhTien.Text = "150,000";
                }
                else if (richTextBox_search_bar.Text.ToLower().Trim() == "rửa xe")
                {
                    panelScreen_thongTinChiTiet.Location = new Point(0, 0);
                    panelScreen_thongTinChiTiet.Visible = true;

                    panelScreen_main_home_xoetxoet.Visible = false;
                    panelScreen_thanhToan.Visible = false;
                    panelScreen_lichSuGD.Visible = false;
                    panelScreen_caNhan.Visible = false;
                    panelScreen_thongBao.Visible = false;
                    panelScreen_chiTietDichVuDaDat.Visible = false;
                    panelScreen_dangKyTaiKhoan.Visible = false;
                    panelScreen_dangNhap.Visible = false;
                    panelScreen_thongTinTaiKhoan.Visible = false;

                    if (buttonSub_caNhanScreen_tiengViet.BackColor == Color.LightGreen)
                    {
                        labelText_thongTinChiTietScreen_thongTinChiTiet.Text = "Rửa xe";
                    }
                    else if (buttonSub_caNhanScreen_tiengAnh.BackColor == Color.LightGreen)
                    {
                        labelText_thongTinChiTietScreen_thongTinChiTiet.Text = "Car Washing";
                    }
                    else
                    {
                        labelText_thongTinChiTietScreen_thongTinChiTiet.Text = "洗車";
                    }

                    labelValue_thongTinChiTietScreen_thanhTien.Text = "100,000";
                }
                else if (richTextBox_search_bar.Text.ToLower().Trim() == "trông nhà")
                {
                    panelScreen_thongTinChiTiet.Location = new Point(0, 0);
                    panelScreen_thongTinChiTiet.Visible = true;

                    panelScreen_main_home_xoetxoet.Visible = false;
                    panelScreen_thanhToan.Visible = false;
                    panelScreen_lichSuGD.Visible = false;
                    panelScreen_caNhan.Visible = false;
                    panelScreen_thongBao.Visible = false;
                    panelScreen_chiTietDichVuDaDat.Visible = false;
                    panelScreen_dangKyTaiKhoan.Visible = false;
                    panelScreen_dangNhap.Visible = false;
                    panelScreen_thongTinTaiKhoan.Visible = false;

                    if (buttonSub_caNhanScreen_tiengViet.BackColor == Color.LightGreen)
                    {
                        labelText_thongTinChiTietScreen_thongTinChiTiet.Text = "Trông nhà";
                    }
                    else if (buttonSub_caNhanScreen_tiengAnh.BackColor == Color.LightGreen)
                    {
                        labelText_thongTinChiTietScreen_thongTinChiTiet.Text = "Security";
                    }
                    else
                    {
                        labelText_thongTinChiTietScreen_thongTinChiTiet.Text = "留守番";
                    }

                    labelValue_thongTinChiTietScreen_thanhTien.Text = "200,000";
                }
                else if (richTextBox_search_bar.Text.ToLower().Trim() == "chuyển phát")
                {
                    panelScreen_thongTinChiTiet.Location = new Point(0, 0);
                    panelScreen_thongTinChiTiet.Visible = true;

                    panelScreen_main_home_xoetxoet.Visible = false;
                    panelScreen_thanhToan.Visible = false;
                    panelScreen_lichSuGD.Visible = false;
                    panelScreen_caNhan.Visible = false;
                    panelScreen_thongBao.Visible = false;
                    panelScreen_chiTietDichVuDaDat.Visible = false;
                    panelScreen_dangKyTaiKhoan.Visible = false;
                    panelScreen_dangNhap.Visible = false;
                    panelScreen_thongTinTaiKhoan.Visible = false;

                    if (buttonSub_caNhanScreen_tiengViet.BackColor == Color.LightGreen)
                    {
                        labelText_thongTinChiTietScreen_thongTinChiTiet.Text = "Chuyển phát";
                    }
                    else if (buttonSub_caNhanScreen_tiengAnh.BackColor == Color.LightGreen)
                    {
                        labelText_thongTinChiTietScreen_thongTinChiTiet.Text = "Delivery";
                    }
                    else
                    {
                        labelText_thongTinChiTietScreen_thongTinChiTiet.Text = "配送";
                    }

                    labelValue_thongTinChiTietScreen_thanhTien.Text = "100,000";
                }
                else if (richTextBox_search_bar.Text.ToLower().Trim() == "sửa chữa điện máy")
                {
                    panelScreen_thongTinChiTiet.Location = new Point(0, 0);
                    panelScreen_thongTinChiTiet.Visible = true;

                    panelScreen_main_home_xoetxoet.Visible = false;
                    panelScreen_thanhToan.Visible = false;
                    panelScreen_lichSuGD.Visible = false;
                    panelScreen_caNhan.Visible = false;
                    panelScreen_thongBao.Visible = false;
                    panelScreen_chiTietDichVuDaDat.Visible = false;
                    panelScreen_dangKyTaiKhoan.Visible = false;
                    panelScreen_dangNhap.Visible = false;
                    panelScreen_thongTinTaiKhoan.Visible = false;

                    if (buttonSub_caNhanScreen_tiengViet.BackColor == Color.LightGreen)
                    {
                        labelText_thongTinChiTietScreen_thongTinChiTiet.Text = "Sửa chữa điện máy";
                    }
                    else if (buttonSub_caNhanScreen_tiengAnh.BackColor == Color.LightGreen)
                    {
                        labelText_thongTinChiTietScreen_thongTinChiTiet.Text = "Repairman";
                    }
                    else
                    {
                        labelText_thongTinChiTietScreen_thongTinChiTiet.Text = "機械修理";
                    }

                    labelValue_thongTinChiTietScreen_thanhTien.Text = "150,000";
                }
                else if (richTextBox_search_bar.Text.ToLower().Trim() == "trang trí nội thất")
                {
                    panelScreen_thongTinChiTiet.Location = new Point(0, 0);
                    panelScreen_thongTinChiTiet.Visible = true;

                    panelScreen_main_home_xoetxoet.Visible = false;
                    panelScreen_thanhToan.Visible = false;
                    panelScreen_lichSuGD.Visible = false;
                    panelScreen_caNhan.Visible = false;
                    panelScreen_thongBao.Visible = false;
                    panelScreen_chiTietDichVuDaDat.Visible = false;
                    panelScreen_dangKyTaiKhoan.Visible = false;
                    panelScreen_dangNhap.Visible = false;
                    panelScreen_thongTinTaiKhoan.Visible = false;

                    if (buttonSub_caNhanScreen_tiengViet.BackColor == Color.LightGreen)
                    {
                        labelText_thongTinChiTietScreen_thongTinChiTiet.Text = "Trang trí nội thất";
                    }
                    else if (buttonSub_caNhanScreen_tiengAnh.BackColor == Color.LightGreen)
                    {
                        labelText_thongTinChiTietScreen_thongTinChiTiet.Text = "Decorating";
                    }
                    else
                    {
                        labelText_thongTinChiTietScreen_thongTinChiTiet.Text = "インテリアデザイン";
                    }

                    labelValue_thongTinChiTietScreen_thanhTien.Text = "500,000";
                }
                else if (richTextBox_search_bar.Text.ToLower().Trim() == "vệ sinh điều hòa")
                {
                    panelScreen_thongTinChiTiet.Location = new Point(0, 0);
                    panelScreen_thongTinChiTiet.Visible = true;

                    panelScreen_main_home_xoetxoet.Visible = false;
                    panelScreen_thanhToan.Visible = false;
                    panelScreen_lichSuGD.Visible = false;
                    panelScreen_caNhan.Visible = false;
                    panelScreen_thongBao.Visible = false;
                    panelScreen_chiTietDichVuDaDat.Visible = false;
                    panelScreen_dangKyTaiKhoan.Visible = false;
                    panelScreen_dangNhap.Visible = false;
                    panelScreen_thongTinTaiKhoan.Visible = false;

                    if (buttonSub_caNhanScreen_tiengViet.BackColor == Color.LightGreen)
                    {
                        labelText_thongTinChiTietScreen_thongTinChiTiet.Text = "Vệ sinh điều hòa";
                    }
                    else if (buttonSub_caNhanScreen_tiengAnh.BackColor == Color.LightGreen)
                    {
                        labelText_thongTinChiTietScreen_thongTinChiTiet.Text = "AC Cleaning";
                    }
                    else
                    {
                        labelText_thongTinChiTietScreen_thongTinChiTiet.Text = "エアコン掃除";
                    }

                    labelValue_thongTinChiTietScreen_thanhTien.Text = "150,000";
                }
                else if (richTextBox_search_bar.Text.ToLower().Trim() == "diệt côn trùng")
                {
                    panelScreen_thongTinChiTiet.Location = new Point(0, 0);
                    panelScreen_thongTinChiTiet.Visible = true;

                    panelScreen_main_home_xoetxoet.Visible = false;
                    panelScreen_thanhToan.Visible = false;
                    panelScreen_lichSuGD.Visible = false;
                    panelScreen_caNhan.Visible = false;
                    panelScreen_thongBao.Visible = false;
                    panelScreen_chiTietDichVuDaDat.Visible = false;
                    panelScreen_dangKyTaiKhoan.Visible = false;
                    panelScreen_dangNhap.Visible = false;
                    panelScreen_thongTinTaiKhoan.Visible = false;

                    if (buttonSub_caNhanScreen_tiengViet.BackColor == Color.LightGreen)
                    {
                        labelText_thongTinChiTietScreen_thongTinChiTiet.Text = "Diệt côn trùng";
                    }
                    else if (buttonSub_caNhanScreen_tiengAnh.BackColor == Color.LightGreen)
                    {
                        labelText_thongTinChiTietScreen_thongTinChiTiet.Text = "Exterminator";
                    }
                    else
                    {
                        labelText_thongTinChiTietScreen_thongTinChiTiet.Text = "殺虫消毒";
                    }

                    labelValue_thongTinChiTietScreen_thanhTien.Text = "200,000";
                }
                else if (richTextBox_search_bar.Text.ToLower().Trim() == "chuyển nhà")
                {
                    panelScreen_thongTinChiTiet.Location = new Point(0, 0);
                    panelScreen_thongTinChiTiet.Visible = true;

                    panelScreen_main_home_xoetxoet.Visible = false;
                    panelScreen_thanhToan.Visible = false;
                    panelScreen_lichSuGD.Visible = false;
                    panelScreen_caNhan.Visible = false;
                    panelScreen_thongBao.Visible = false;
                    panelScreen_chiTietDichVuDaDat.Visible = false;
                    panelScreen_dangKyTaiKhoan.Visible = false;
                    panelScreen_dangNhap.Visible = false;
                    panelScreen_thongTinTaiKhoan.Visible = false;

                    if (buttonSub_caNhanScreen_tiengViet.BackColor == Color.LightGreen)
                    {
                        labelText_thongTinChiTietScreen_thongTinChiTiet.Text = "Chuyển nhà";
                    }
                    else if (buttonSub_caNhanScreen_tiengAnh.BackColor == Color.LightGreen)
                    {
                        labelText_thongTinChiTietScreen_thongTinChiTiet.Text = "Moving home";
                    }
                    else
                    {
                        labelText_thongTinChiTietScreen_thongTinChiTiet.Text = "引っ越し";
                    }

                    labelValue_thongTinChiTietScreen_thanhTien.Text = "500,000";
                }
            }
        }

        private void button_click_CT_left_arrow(object sender, EventArgs e)
        {

        }

        private void button_click_thanhToan(object sender, EventArgs e)
        {
            if (checkDaDangNhap == false)
            {
                string message = "";
                if (buttonSub_caNhanScreen_tiengViet.BackColor == Color.LightGreen)
                {
                    message = "Bạn cần đăng nhập để thực hiện giao dịch";
                }
                else if (buttonSub_caNhanScreen_tiengAnh.BackColor == Color.LightGreen)
                {
                    message = "You need to login to make a transaction";
                }
                else
                {
                    message = "取引を行うにはログインする必要があります";
                }
                MessageBox.Show(message);
            }
            else if (listView_thanhToanScreen_danhSachDichVuDaDat.Items.Count == 0)
            {
                string message = "";
                if (buttonSub_caNhanScreen_tiengViet.BackColor == Color.LightGreen)
                {
                    message = "Hiện tại bạn chưa chọn dịch vụ nào";
                }
                else if (buttonSub_caNhanScreen_tiengAnh.BackColor == Color.LightGreen)
                {
                    message = "You have not selected any service yet";
                }
                else
                {
                    message = "まだサービスを選択していません";
                }
                MessageBox.Show(message);
            }
            else
            {
                DateTime VietNam_time_now = TimeZoneInfo.ConvertTime(DateTime.Now, TimeZoneInfo.Local, TimeZoneInfo.FindSystemTimeZoneById("SE Asia Standard Time"));

                // Xóa toàn bộ danh sách dịch vụ đã yêu cầu trong list view
                listView_thanhToanScreen_danhSachDichVuDaDat.Items.Clear();

                // Hiện lại label Hiện tại chưa chọn dịch vụ nào
                labelText_thanhToanScreen_hienTaiChuaChonDichVuNao.Visible = true;
                labelText_lichSuGDScreen_hienTaiChuaCoGiaoDichNao.Visible = false;
                
                // Tăng mã giao dịch lên để sử dụng cho đợt thanh toán tiếp theo và set lại thứ tự dịch vụ
                MaGD += 1;
                STTDV = -1;

                // Thêm vào lịch sử giao dịch (vào trong list view)
                string[] row = {Convert.ToString(MaGD), VietNam_time_now.ToString("dd/MM/yyyy"), VietNam_time_now.ToString("HH:mm:ss"), Convert.ToString(labelValue_thanhToanScreen_tongSoTien.Text)};
                ListViewItem item = new ListViewItem(row);
                listView_lichSuGDScreen_lichSuGiaoDich.Items.Add(item);

                // Đặt label tổng số tiền lại = 0
                labelValue_thanhToanScreen_tongSoTien.Text = "0";
                tong_so_tien = 0;

                string message = "";
                if (buttonSub_caNhanScreen_tiengViet.BackColor == Color.LightGreen)
                {
                    message = "Thanh toán thành công. Nhân viên chúng tôi sẽ liên hệ quý khách trong thời gian sớm nhất. Xin cảm ơn quý khách.";
                }
                else if (buttonSub_caNhanScreen_tiengAnh.BackColor == Color.LightGreen)
                {
                    message = "Payment success. Our staff will contact you as soon as possible. Thank you.";
                }
                else
                {
                    message = "支払いの成功。スタッフよりお早めにご連絡いたします。ありがとうございました";
                }
                MessageBox.Show(message);
            }
        }

        private void listView_mouseClick_danhSachDichVuDaDat(object sender, MouseEventArgs e)
        {
            string searchExpression = "MaGD='" + Convert.ToString(MaGD) + "'";
            DataRow[] rows = dt.Select(searchExpression);
            int rowIndex = STTDV;
            labelValue_chiTietScreen_thoiGianDat.Text = rows[rowIndex]["ThoiGianThucHienGD"].ToString();
            labelValue_chiTietScreen_tenDichVu.Text = rows[rowIndex]["TenDV"].ToString();
            labelValue_chiTietScreen_gioiTinh.Text = rows[rowIndex]["GioiTinh"].ToString();
            labelValue_chiTietScreen_doTuoi.Text = rows[rowIndex]["DoTuoi"].ToString();
            labelValue_chiTietScreen_diaChiLamViec.Text = rows[rowIndex]["DiaChiLamViec"].ToString();
            labelValue_chiTietScreen_ghiChu.Text = rows[rowIndex]["GhiChu"].ToString();
            labelValue_chiTietScreen_thanhTien.Text = rows[rowIndex]["ThanhTien"].ToString();

            // Hiện màn hình thông tin chi tiết dịch vụ đã đặt
            panelScreen_chiTietDichVuDaDat.Location = new Point(0, 0);
            panelScreen_chiTietDichVuDaDat.Visible = true;

            panelScreen_main_home_xoetxoet.Visible = false;
            panelScreen_thanhToan.Visible = false;
            panelScreen_lichSuGD.Visible = false;
            panelScreen_caNhan.Visible = false;
            panelScreen_thongBao.Visible = false;
            panelScreen_thongTinChiTiet.Visible = false;
            panelScreen_dangKyTaiKhoan.Visible = false;
            panelScreen_dangNhap.Visible = false;
            panelScreen_thongTinTaiKhoan.Visible = false;
        }

        private void button_click_dangKyNgay(object sender, EventArgs e)
        {
            // Hiện màn hình đăng ký tài khoản
            panelScreen_dangKyTaiKhoan.Location = new Point(0, 0);
            panelScreen_dangKyTaiKhoan.Visible = true;

            panelScreen_main_home_xoetxoet.Visible = false;
            panelScreen_thanhToan.Visible = false;
            panelScreen_lichSuGD.Visible = false;
            panelScreen_caNhan.Visible = false;
            panelScreen_thongBao.Visible = false;
            panelScreen_thongTinChiTiet.Visible = false;
            panelScreen_chiTietDichVuDaDat.Visible = false;
            panelScreen_dangNhap.Visible = false;
            panelScreen_thongTinTaiKhoan.Visible = false;
        }

        private void button_click_dangKyTaiKhoanScreen_dangKy(object sender, EventArgs e)
        {
            string tenDangNhap = textBox_dangKyTaiKhoanScreen_tenDangNhap.Text;
            string ho = textBox_dangKyTaiKhoanScreen_ho.Text;
            string ten = textBox_dangKyTaiKhoanScreen_ten.Text;
            string gioiTinh = comboBox_dangKyTaiKhoanScreen_gioiTinh.Text;
            string ngaySinh = dateTimePicker_caNhanScreen_ngaySinh.Text;
            string soDienThoai = textBox_dangKyTaiKhoanScreen_soDienThoai.Text;
            string email = textBox_dangKyTaiKhoanScreen_email.Text;
            string cmnd_cccd = textBox_dangKyTaiKhoanScreen_CMND_CCCD.Text;
            string matKhau = textBox_dangKyTaiKhoanScreen_matKhau.Text;
            string matKhauNhapLai = textBox_dangKyTaiKhoanScreen_nhapLaiMatKhau.Text;
            bool checkDieuKhoan = checkBox_dangKyTaiKhoanScreen_dongYDieuKhoan.Checked;

            if (tenDangNhap == "")
            {
                string message = "";
                if (buttonSub_caNhanScreen_tiengViet.BackColor == Color.LightGreen)
                {
                    message = "Bạn cần điền thông tin về Tên đăng nhập.";
                }
                else if (buttonSub_caNhanScreen_tiengAnh.BackColor == Color.LightGreen)
                {
                    message = "You need to fill in your Username information.";
                }
                else
                {
                    message = "ユーザー名情報を入力する必要があります。";
                }
                MessageBox.Show(message);
            }
            else if (ho == "")
            {
                string message = "";
                if (buttonSub_caNhanScreen_tiengViet.BackColor == Color.LightGreen)
                {
                    message = "Bạn cần điền thông tin về Họ của bạn.";
                }
                else if (buttonSub_caNhanScreen_tiengAnh.BackColor == Color.LightGreen)
                {
                    message = "You need to fill in your Last Name information.";
                }
                else
                {
                    message = "姓の情報を入力する必要があります。";
                }
                MessageBox.Show(message);
            }
            else if (ten == "")
            {
                string message = "";
                if (buttonSub_caNhanScreen_tiengViet.BackColor == Color.LightGreen)
                {
                    message = "Bạn cần điền thông tin về Tên của bạn.";
                }
                else if (buttonSub_caNhanScreen_tiengAnh.BackColor == Color.LightGreen)
                {
                    message = "You need to fill in your First name information.";
                }
                else
                {
                    message = "名前情報を入力する必要があります。";
                }
                MessageBox.Show(message);
            }
            else if (gioiTinh == "")
            {
                string message = "";
                if (buttonSub_caNhanScreen_tiengViet.BackColor == Color.LightGreen)
                {
                    message = "Bạn cần điền thông tin về Giới tính của bạn.";
                }
                else if (buttonSub_caNhanScreen_tiengAnh.BackColor == Color.LightGreen)
                {
                    message = "You need to fill in your Gender information.";
                }
                else
                {
                    message = "性別情報を入力する必要があります。";
                }
                MessageBox.Show(message);
            }
            else if (soDienThoai == "")
            {
                string message = "";
                if (buttonSub_caNhanScreen_tiengViet.BackColor == Color.LightGreen)
                {
                    message = "Bạn cần điền thông tin về Số điện thoại của bạn.";
                }
                else if (buttonSub_caNhanScreen_tiengAnh.BackColor == Color.LightGreen)
                {
                    message = "You need to fill in information about your Phone Number.";
                }
                else
                {
                    message = "あなたはあなたの電話番号についての情報を記入する必要があります。";
                }
                MessageBox.Show(message);
            }
            else if (email == "")
            {
                string message = "";
                if (buttonSub_caNhanScreen_tiengViet.BackColor == Color.LightGreen)
                {
                    message = "Bạn cần điền thông tin về Email của bạn.";
                }
                else if (buttonSub_caNhanScreen_tiengAnh.BackColor == Color.LightGreen)
                {
                    message = "You need to fill in your email information.";
                }
                else
                {
                    message = "あなたはあなたの電子メール情報を記入する必要があります。";
                }
                MessageBox.Show(message);
            }
            else if (ngaySinh == "")
            {
                string message = "";
                if (buttonSub_caNhanScreen_tiengViet.BackColor == Color.LightGreen)
                {
                    message = "Bạn cần điền thông tin về Ngày sinh của bạn.";
                }
                else if (buttonSub_caNhanScreen_tiengAnh.BackColor == Color.LightGreen)
                {
                    message = "You need to fill in your Date of Birth.";
                }
                else
                {
                    message = "生年月日を記入する必要があります。";
                }
                MessageBox.Show(message);
            }
            else if (cmnd_cccd == "")
            {
                string message = "";
                if (buttonSub_caNhanScreen_tiengViet.BackColor == Color.LightGreen)
                {
                    message = "Bạn cần điền thông tin về Số CMND/CCCD của bạn.";
                }
                else if (buttonSub_caNhanScreen_tiengAnh.BackColor == Color.LightGreen)
                {
                    message = "You need to fill in information about your ID Card number.";
                }
                else
                {
                    message = "IDカード番号を入力する必要があります。";
                }
                MessageBox.Show(message);
            }
            else if (matKhau == "")
            {
                string message = "";
                if (buttonSub_caNhanScreen_tiengViet.BackColor == Color.LightGreen)
                {
                    message = "Bạn cần điền thông tin về Mật khẩu tài khoản.";
                }
                else if (buttonSub_caNhanScreen_tiengAnh.BackColor == Color.LightGreen)
                {
                    message = "You need to fill in the Account Password information.";
                }
                else
                {
                    message = "アカウントのパスワード情報を入力する必要があります。";
                }
                MessageBox.Show(message);
            }
            else if (matKhauNhapLai == "")
            {
                string message = "";
                if (buttonSub_caNhanScreen_tiengViet.BackColor == Color.LightGreen)
                {
                    message = "Bạn cần nhập lại mật khẩu của mình.";
                }
                else if (buttonSub_caNhanScreen_tiengAnh.BackColor == Color.LightGreen)
                {
                    message = "You need to re-enter your password.";
                }
                else
                {
                    message = "パスワードを再入力する必要があります。";
                }
                MessageBox.Show(message);
            }
            else if (matKhau != matKhauNhapLai)
            {
                string message = "";
                if (buttonSub_caNhanScreen_tiengViet.BackColor == Color.LightGreen)
                {
                    message = "Mật khẩu và mật khẩu nhập lại không trùng khớp. Bạn vui lòng chỉnh sửa lại nhé.";
                }
                else if (buttonSub_caNhanScreen_tiengAnh.BackColor == Color.LightGreen)
                {
                    message = "Password and re-entered password do not match. Please edit it again.";
                }
                else
                {
                    message = "パスワードと再入力したパスワードが一致しません。もう一度編集してください。";
                }
                MessageBox.Show(message);
            }
            else if (checkDieuKhoan == false)
            {
                string message = "";
                if (buttonSub_caNhanScreen_tiengViet.BackColor == Color.LightGreen)
                {
                    message = "Bạn cần phải chấp nhận điều khoản của chúng tôi.";
                }
                else if (buttonSub_caNhanScreen_tiengAnh.BackColor == Color.LightGreen)
                {
                    message = "You need to accept our terms.";
                }
                else
                {
                    message = "あなたは私たちの条件に同意する必要があります。";
                }
                MessageBox.Show(message);
            }
            else if (accounts_dt.Select("TenDangNhap='" + tenDangNhap + "'").Length != 0)
            {
                string message = "";
                if (buttonSub_caNhanScreen_tiengViet.BackColor == Color.LightGreen)
                {
                    message = "Tên đăng nhập này đã tồn tại. Vui lòng sử dụng tên đăng nhập khác.";
                }
                else if (buttonSub_caNhanScreen_tiengAnh.BackColor == Color.LightGreen)
                {
                    message = "This username already exists. Please use another username.";
                }
                else
                {
                    message = "このユーザー名は既に存在します。別のユーザー名を使用してください。";
                }
                MessageBox.Show(message);
            }
            else
            {
                // Cập nhật thông tin tài khoản đã đăng ký vào data table
                accounts_dt.Rows.Add(tenDangNhap, ho, ten, gioiTinh, ngaySinh, soDienThoai, email, cmnd_cccd, matKhau);

                // Tắt visibility của một số objects trang cá nhân
                labelText_caNhanScreen_chuaDangNhap.Visible = false;
                button_caNhanScreen_dangKyNgay.Visible = false;
                button_caNhanScreen_dangNhap.Visible = false;
                labelText_caNhanScreen_xinChao.Text += tenDangNhap;
                labelText_caNhanScreen_xinChao.Visible = true;

                // Bật tính năng thoát khỏi tài khoản hiện tại
                button_caNhanScreen_thoat.Visible = true;

                // Xóa thông tin trên các ô cần điền ở form đăng ký
                textBox_dangKyTaiKhoanScreen_tenDangNhap.Text = "";
                textBox_dangKyTaiKhoanScreen_ho.Text = "";
                textBox_dangKyTaiKhoanScreen_ten.Text = "";
                comboBox_dangKyTaiKhoanScreen_gioiTinh.Text = "";
                dateTimePicker_caNhanScreen_ngaySinh.Text = "4/10/2021";
                textBox_dangKyTaiKhoanScreen_soDienThoai.Text = "";
                textBox_dangKyTaiKhoanScreen_email.Text = "";
                textBox_dangKyTaiKhoanScreen_CMND_CCCD.Text = "";
                textBox_dangKyTaiKhoanScreen_matKhau.Text = "";
                textBox_dangKyTaiKhoanScreen_nhapLaiMatKhau.Text = "";
                checkBox_dangKyTaiKhoanScreen_dongYDieuKhoan.Checked = false;

                // Check đã đăng nhập
                checkDaDangNhap = true;

                // Cập nhật tên đăng nhập hiện tại
                tenDangNhapHienTai = tenDangNhap;

                // Bật visibility các listview
                listView_lichSuGDScreen_lichSuGiaoDich.Visible = true;
                listView_thanhToanScreen_danhSachDichVuDaDat.Visible = true;

                // Trở về màn hình cá nhân
                this.button_click_dangKyTaiKhoanScreen_left_arrow(sender, e);

                string message = "";
                if (buttonSub_caNhanScreen_tiengViet.BackColor == Color.LightGreen)
                {
                    message = "Chúc mừng. Bạn đã tạo tài khoản thành công.";
                }
                else if (buttonSub_caNhanScreen_tiengAnh.BackColor == Color.LightGreen)
                {
                    message = "Congratulations. You have successfully created an account.";
                }
                else
                {
                    message = "おめでとう。アカウントが正常に作成されました。";
                }
                MessageBox.Show(message);
            }
        }

        private void pictureBox_click_caNhanScreen_avatar(object sender, EventArgs e)
        {
            if (checkDaDangNhap == false)
            {
                string message = "";
                if (buttonSub_caNhanScreen_tiengViet.BackColor == Color.LightGreen)
                {
                    message = "Bạn cần đăng nhập để cập nhật ảnh đại diện.";
                }
                else if (buttonSub_caNhanScreen_tiengAnh.BackColor == Color.LightGreen)
                {
                    message = "You need to log in to update your profile picture.";
                }
                else
                {
                    message = "プロフィール写真を更新するには、ログインする必要があります。";
                }
                MessageBox.Show(message);
            }
            else
            {
                // open file dialog   
                OpenFileDialog open = new OpenFileDialog();
                // image filters  
                open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
                if (open.ShowDialog() == DialogResult.OK)
                {
                    // display image in picture box  
                    pictureBox_caNhanScreen_avatar.Image = new Bitmap(open.FileName);

                    string message = "";
                    if (buttonSub_caNhanScreen_tiengViet.BackColor == Color.LightGreen)
                    {
                        message = "Cập nhật ảnh đại diện thành công.";
                    }
                    else if (buttonSub_caNhanScreen_tiengAnh.BackColor == Color.LightGreen)
                    {
                        message = "Profile photo update successfully.";
                    }
                    else
                    {
                        message = "プロフィール写真の更新に成功しました。";
                    }
                    MessageBox.Show(message);
                }
            }
        }

        private void button_click_dangKyTaiKhoanScreen_left_arrow(object sender, EventArgs e)
        {
            panelScreen_caNhan.Location = new Point(0, 0);
            panelScreen_caNhan.Visible = true;

            panelScreen_thongTinChiTiet.Visible = false;
            panelScreen_lichSuGD.Visible = false;
            panelScreen_thanhToan.Visible = false;
            panelScreen_thongBao.Visible = false;
            panelScreen_main_home_xoetxoet.Visible = false;
            panelScreen_chiTietDichVuDaDat.Visible = false;
            panelScreen_dangKyTaiKhoan.Visible = false;
            panelScreen_dangNhap.Visible = false;
            panelScreen_thongTinTaiKhoan.Visible = false;
        }

        private void button_click_caNhanScreen_caiDatNgonNgu(object sender, EventArgs e)
        {
            showSubMenu(panel_caNhanScreen_caiDatNgonNguSubMenu);
        }

        private void button_click_caNhanScreen_thongTinTaiKhoan(object sender, EventArgs e)
        {
            if (tenDangNhapHienTai == "")
            {
                string message = "";
                if (buttonSub_caNhanScreen_tiengViet.BackColor == Color.LightGreen)
                {
                    message = "Bạn phải đăng nhập để sử dụng chức năng này.";
                }
                else if (buttonSub_caNhanScreen_tiengAnh.BackColor == Color.LightGreen)
                {
                    message = "You must be logged in to use this function.";
                }
                else
                {
                    message = "この機能を使用するには、ログインする必要があります。";
                }
                MessageBox.Show(message);
            }
            else
            {
                panelScreen_thongTinTaiKhoan.Location = new Point(0, 0);
                panelScreen_thongTinTaiKhoan.Visible = true;

                panelScreen_thongTinChiTiet.Visible = false;
                panelScreen_lichSuGD.Visible = false;
                panelScreen_thanhToan.Visible = false;
                panelScreen_thongBao.Visible = false;
                panelScreen_main_home_xoetxoet.Visible = false;
                panelScreen_chiTietDichVuDaDat.Visible = false;
                panelScreen_dangKyTaiKhoan.Visible = false;
                panelScreen_dangNhap.Visible = false;
                panelScreen_caNhan.Visible = false;

                // Hiển thị thông tin của tài khoản hiện tại
                string searchExpression = "TenDangNhap='" + tenDangNhapHienTai + "'";
                DataRow[] rows = accounts_dt.Select(searchExpression);

                labelValue_thongTinTaiKhoanScreen_tenDangNhap.Text = rows[0]["TenDangNhap"].ToString();
                labelValue_thongTinTaiKhoanScreen_hoTen.Text = rows[0]["Ho"].ToString() + " " + rows[0]["Ten"].ToString();
                labelValue_thongTinTaiKhoanScreen_gioiTinh.Text = rows[0]["GioiTinh"].ToString();
                labelValue_thongTinTaiKhoanScreen_ngaySinh.Text = rows[0]["NgaySinh"].ToString();
                labelValue_thongTinTaiKhoanScreen_email.Text = rows[0]["Email"].ToString();
                labelValue_thongTinTaiKhoanScreen_soDienThoai.Text = rows[0]["SDT"].ToString();
                labelValue_thongTinTaiKhoanScreen_cmnd_cccd.Text = rows[0]["CMND_CCCD"].ToString();

            }
        }

        private void buttonSub_click_caNhanScreen_tiengViet(object sender, EventArgs e)
        {
            // Thay screen xoetxoet
            richTextBox_search_bar.Text = " Tìm kiếm dịch vụ...";
            labelText_xoetXoetScreen_deXuat.Text = "XoetXoet đề xuất";
            labelText_xoetXoetScreen_uuDai.Text = "Ưu đãi";
            labelText_xoetXoetScreen_dichVu.Text = "Dịch vụ";
            button_xoetXoetScreen_lauDon.Text = "Lau dọn";
            button_xoetXoetScreen_trongTre.Text = "Trông trẻ";
            button_xoetXoetScreen_diCho.Text = "Đi chợ";
            button_xoetXoetScreen_giatUi.Text = "Giặt ủi";
            button_xoetXoetScreen_nauAn.Text = "Nấu ăn";
            button_xoetXoetScreen_lauKinh.Text = "Lau kính";
            button_xoetXoetScreen_ruaXe.Text = "Rửa xe";
            button_xoetXoetScreen_chuyenPhat.Text = "Chuyển phát";
            button_xoetXoetScreen_trongNha.Text = "Trông nhà";
            button_xoetXoetScreen_suaChuaDienMay.Text = "Sửa chữa điện máy";
            button_xoetXoetScreen_trangTriNoiThat.Text = "Trang trí nội thất";
            button_xoetXoetScreen_diCho_2.Text = "Đi chợ";
            button_xoetXoetScreen_dietConTrung.Text = "Diệt côn trùng";
            button_xoetXoetScreen_lauDon_2.Text = "Lau dọn";
            button_xoetXoetScreen_trongTre_2.Text = "Trông trẻ";
            button_xoetXoetScreen_veSinhDieuHoa.Text = "Vệ sinh điều hòa";
            button_xoetXoetScreen_chuyenNha.Text = "Chuyển nhà";

            // Thay screen thông tin chi tiết
            labelText_thongTinChiTietScreen_vuiLongDienThongTin.Text = "Vui lòng điền các thông tin sau";
            labelText_thongTinChiTietScreen_ngayLamViec.Text = "Ngày làm việc";
            labelText_thongTinChiTietScreen_gioiTinh.Text = "Giới tính nhân viên";
            labelText_thongTinChiTietScreen_doTuoi.Text = "Độ tuổi nhân viên";
            labelText_thongTinChiTietScreen_diaChiLamViec.Text = "Địa chỉ làm việc";
            labelText_thongTinChiTietScreen_ghiChu.Text = "Ghi chú";
            labelText_thongTinChiTietScreen_thanhTien.Text = "Thành tiền";
            button_thongTinChiTietScreen_xacNhan.Text = "Xác nhận";

            // Thay screen thông báo
            labelText_thongBaoScreen_thongBao.Text = "Thông báo";

            // Thay screen thanh toán
            button_thanhToan.Text = "Thanh toán";
            labelText_thanhToanScreen_thanhToan.Text = "Thanh toán";
            labelText_thanhToanScreen_hienTaiChuaChonDichVuNao.Text = "Hiện tại bạn chưa chọn dịch vụ nào";
            labelText_thanhToanScreen_nhapMaGiamGia.Text = "Nhập mã giảm giá";
            labelText_thanhToanScreen_tongSoTien.Text = "Tổng số tiền";
            button_thanhToanScreen_thanhToan.Text = "Thanh toán";

            // Thay screen chi tiết
            labelText_chiTietScreen_chiTiet.Text = "Chi tiết";
            labelText_chiTietScreen_thoiGianDat.Text = "Thời gian đặt";
            labelText_chiTietScreen_tenDichVu.Text = "Tên dịch vụ";
            labelText_chiTietScreen_gioiTinh.Text = "Giới tính";
            labelText_chiTietScreen_doTuoi.Text = "Độ tuổi";
            labelText_chiTietScreen_diaChiLamViec.Text = "Địa chỉ làm việc";
            labelText_chiTietScreen_ghiChu.Text = "Ghi chú";
            labelText_chiTietScreen_thanhTien.Text = "Thành tiền";
            button_chiTietScreen_huyYeuCau.Text = "Hủy yêu cầu";

            // Thay screen lịch sử giao dịch
            button_lichSuGD.Text = "Lịch sử";
            labelText_lichSuGDScreen_lichSuGiaoDich.Text = "Lịch sử giao dịch";
            labelText_lichSuGDScreen_hienTaiChuaCoGiaoDichNao.Text = "Hiện tại chưa có giao dịch nào";

            // Thay screen cá nhân
            button_caNhan.Text = "Cá nhân";
            labelText_caNhanScreen_chuaDangNhap.Text = "Bạn hiện chưa đăng nhập";
            labelText_caNhanScreen_caNhan.Text = "Cá nhân";
            button_caNhanScreen_dangNhap.Text = "Đăng nhập";
            button_caNhanScreen_dangKyNgay.Text = "Đăng ký ngay";
            button_caNhanScreen_thongTinTaiKhoan.Text = "Thông tin tài khoản";
            button_caNhanScreen_caiDatNgonNgu.Text = "Cài dặt ngôn ngữ";
            buttonSub_caNhanScreen_tiengViet.Text = "Tiếng Việt";
            buttonSub_caNhanScreen_tiengAnh.Text = "Tiếng Anh";
            buttonSub_caNhanScreen_tiengNhat.Text = "Tiếng Nhật";
            button_caNhanScreen_doiMauUngDung.Text = "Đổi màu ứng dụng";
            buttonSub_caNhanScreen_xanhDaTroi.Text = "Xanh da trời";
            buttonSub_caNhanScreen_cam.Text = "Cam";
            buttonSub_caNhanScreen_vang.Text = "Vàng";
            button_caNhanScreen_troGiup.Text = "Trợ giúp";
            button_caNhanScreen_thoat.Text = "Thoát";
            labelText_caNhanScreen_xinChao.Text = "Xin chào, ";

            // Thay screen đăng nhập
            button_dangNhapScreen_dangNhap.Text = "Đăng nhập";
            labelText_dangNhapScreen_tenDangNhap.Text = "Tên đăng nhập";
            labelText_dangNhapScreen_matKhau.Text = "Mật khẩu";
            button_dangNhapScreen_dangNhap.Text = "Đăng nhập";
            label_dangNhapScreen_matKhau.Text = "Quên mật khẩu";

            // Thay screen đăng ký tài khoản
            labelText_dangKyTaiKhoanScreen_dangKyTaiKhoan.Text = "Đăng ký tài khoản";
            labelText_dangKyTaiKhoanScreen_chaoMung.Text = "Chào mừng bạn đã đến với XoetXoet";
            labelText_dangKyTaiKhoanScreen_text1.Text = "Bạn chỉ còn một vài bước nhỏ nữa để gia nhập vào đại gia đình XoetXoet chúng mình nè ^^";
            labelText_dangKyTaiKhoanScreen_tenDangNhap.Text = "Tên đăng nhập";
            labelText_dangKyTaiKhoanScreen_ho.Text = "Họ";
            labelText_dangKyTaiKhoanScreen_ten.Text = "Tên";
            labelText_dangKyTaiKhoanScreen_gioiTinh.Text = "Giới tính";
            labelText_dangKyTaiKhoanScreen_ngaySinh.Text = "Ngày sinh";
            labelText_dangKyTaiKhoanScreen_soDienThoai.Text = "Số điện thoại";
            labelText_dangKyTaiKhoanScreen_email.Text = "Email";
            labelText_dangKyTaiKhoanScreen_CMND_CCCD.Text = "CMND/CCCD";
            labelText_dangKyTaiKhoanScreen_matKhau.Text = "Mật khẩu";
            labelText_dangKyTaiKhoanScreen_nhapLaiMatKhau.Text = "Nhập lại mật khẩu";
            checkBox_dangKyTaiKhoanScreen_dongYDieuKhoan.Text = "Tôi đồng ý với các điều khoản của dịch vụ";
            button_dangKyTaiKhoanScreen_dangKy.Text = "Đăng ký";

            // Thay screen thông tin tài khoản
            labelText_thongTinTaiKhoanScreen_thongTinTaiKhoan.Text = "Thông tin tài khoản";
            labelText_thongTinTaiKhoanScreen_tenDangNhap.Text = "Tên đăng nhập";
            labelText_thongTinTaiKhoanScreen_hoTen.Text = "Họ tên";
            labelText_thongTinTaiKhoanScreen_gioiTinh.Text = "Giới tính";
            labelText_thongTinTaiKhoanScreen_ngaySinh.Text = "Ngày sinh";
            labelText_thongTinTaiKhoanScreen_email.Text = "Email";
            labelText_thongTinTaiKhoanScreen_soDienThoai.Text = "Số điện thoại";
            labelText_thongTinTaiKhoanScreen_cmnd_cccd.Text = "CMND/CCCD";


            buttonSub_caNhanScreen_tiengViet.BackColor = Color.LightGreen;
            buttonSub_caNhanScreen_tiengAnh.BackColor = Color.White;
            buttonSub_caNhanScreen_tiengNhat.BackColor = Color.White;
            hideSubMenu();
        }

        private void buttonSub_click_caNhanScreen_tiengAnh(object sender, EventArgs e)
        {
            // Thay screen xoetxoet
            richTextBox_search_bar.Text = " Service search...";
            labelText_xoetXoetScreen_deXuat.Text = "XoetXoet's Recommendation";
            labelText_xoetXoetScreen_uuDai.Text = "Vouchers";
            labelText_xoetXoetScreen_dichVu.Text = "Services";
            button_xoetXoetScreen_lauDon.Text = "Cleaning";
            button_xoetXoetScreen_trongTre.Text = "Babysitter";
            button_xoetXoetScreen_diCho.Text = "Shopping";
            button_xoetXoetScreen_giatUi.Text = "Laundry";
            button_xoetXoetScreen_nauAn.Text = "Cooking";
            button_xoetXoetScreen_lauKinh.Text = "Glasses Washing";
            button_xoetXoetScreen_ruaXe.Text = "Car Washing";
            button_xoetXoetScreen_chuyenPhat.Text = "Delivery";
            button_xoetXoetScreen_trongNha.Text = "Security";
            button_xoetXoetScreen_suaChuaDienMay.Text = "Repairman";
            button_xoetXoetScreen_trangTriNoiThat.Text = "Decorating";
            button_xoetXoetScreen_diCho_2.Text = "Shopping";
            button_xoetXoetScreen_dietConTrung.Text = "Exterminator";
            button_xoetXoetScreen_lauDon_2.Text = "Cleaning";
            button_xoetXoetScreen_trongTre_2.Text = "Babysitter";
            button_xoetXoetScreen_veSinhDieuHoa.Text = "AC Cleaning";
            button_xoetXoetScreen_chuyenNha.Text = "Moving house";

            // Thay screen thông tin chi tiết
            labelText_thongTinChiTietScreen_vuiLongDienThongTin.Text = "Please filling these following information";
            labelText_thongTinChiTietScreen_ngayLamViec.Text = "Working day:";
            labelText_thongTinChiTietScreen_gioiTinh.Text = "Employee gender:";
            labelText_thongTinChiTietScreen_doTuoi.Text = "Employee age:";
            labelText_thongTinChiTietScreen_diaChiLamViec.Text = "Working address:";
            labelText_thongTinChiTietScreen_ghiChu.Text = "Notes:";
            labelText_thongTinChiTietScreen_thanhTien.Text = "Cash:";
            button_thongTinChiTietScreen_xacNhan.Text = "Confirm";

            // Thay screen thông báo
            labelText_thongBaoScreen_thongBao.Text = "Notification";

            // Thay screen thanh toán
            button_thanhToan.Text = "Payment";
            labelText_thanhToanScreen_thanhToan.Text = "Payment";
            labelText_thanhToanScreen_hienTaiChuaChonDichVuNao.Text = "There are currently no selected services";
            labelText_thanhToanScreen_nhapMaGiamGia.Text = "Input voucher:";
            labelText_thanhToanScreen_tongSoTien.Text = "Total:";
            button_thanhToanScreen_thanhToan.Text = "Pay";

            // Thay screen chi tiết
            labelText_chiTietScreen_chiTiet.Text = "Detail";
            labelText_chiTietScreen_thoiGianDat.Text = "Ordered time:";
            labelText_chiTietScreen_tenDichVu.Text = "Service name:";
            labelText_chiTietScreen_gioiTinh.Text = "Employee gender:";
            labelText_chiTietScreen_doTuoi.Text = "Employee age:";
            labelText_chiTietScreen_diaChiLamViec.Text = "Working address:";
            labelText_chiTietScreen_ghiChu.Text = "Notes:";
            labelText_chiTietScreen_thanhTien.Text = "Cash:";
            button_chiTietScreen_huyYeuCau.Text = "Cancel";

            // Thay screen lịch sử giao dịch
            button_lichSuGD.Text = "History";
            labelText_lichSuGDScreen_lichSuGiaoDich.Text = "Transaction history";
            labelText_lichSuGDScreen_hienTaiChuaCoGiaoDichNao.Text = "There are currently no transactions";

            // Thay screen cá nhân
            button_caNhan.Text = "Personal";
            labelText_caNhanScreen_chuaDangNhap.Text = "You are not currently logged in";
            labelText_caNhanScreen_caNhan.Text = "Personal";
            button_caNhanScreen_dangNhap.Text = "Log in";
            button_caNhanScreen_dangKyNgay.Text = "Sign up now";
            button_caNhanScreen_thongTinTaiKhoan.Text = "Account information";
            button_caNhanScreen_caiDatNgonNgu.Text = "Language setting";
            buttonSub_caNhanScreen_tiengViet.Text = "Vietnamese";
            buttonSub_caNhanScreen_tiengAnh.Text = "English";
            buttonSub_caNhanScreen_tiengNhat.Text = "Japanese";
            button_caNhanScreen_doiMauUngDung.Text = "Change system color";
            buttonSub_caNhanScreen_xanhDaTroi.Text = "Blue";
            buttonSub_caNhanScreen_cam.Text = "Orange";
            buttonSub_caNhanScreen_vang.Text = "Yellow";
            button_caNhanScreen_troGiup.Text = "Help";
            button_caNhanScreen_thoat.Text = "Log out";
            labelText_caNhanScreen_xinChao.Text = "Hi, ";

            // Thay screen đăng nhập
            button_dangNhapScreen_dangNhap.Text = "Log in";
            labelText_dangNhapScreen_tenDangNhap.Text = "Account name";
            labelText_dangNhapScreen_matKhau.Text = "Password";
            button_dangNhapScreen_dangNhap.Text = "Log in";
            label_dangNhapScreen_matKhau.Text = "Forgot password";

            // Thay screen đăng ký tài khoản
            labelText_dangKyTaiKhoanScreen_dangKyTaiKhoan.Text = "Sign up";
            labelText_dangKyTaiKhoanScreen_chaoMung.Text = "Welcome to XoetXoet";
            labelText_dangKyTaiKhoanScreen_text1.Text = "You are only a few steps away from joining our big XoetXoet family ^";
            labelText_dangKyTaiKhoanScreen_tenDangNhap.Text = "Account name";
            labelText_dangKyTaiKhoanScreen_ho.Text = "Last name";
            labelText_dangKyTaiKhoanScreen_ten.Text = "First name";
            labelText_dangKyTaiKhoanScreen_gioiTinh.Text = "Gender";
            labelText_dangKyTaiKhoanScreen_ngaySinh.Text = "Date of birth";
            labelText_dangKyTaiKhoanScreen_soDienThoai.Text = "Phone number";
            labelText_dangKyTaiKhoanScreen_email.Text = "Email";
            labelText_dangKyTaiKhoanScreen_CMND_CCCD.Text = "Identity card number";
            labelText_dangKyTaiKhoanScreen_matKhau.Text = "Password";
            labelText_dangKyTaiKhoanScreen_nhapLaiMatKhau.Text = "Repeat password";
            checkBox_dangKyTaiKhoanScreen_dongYDieuKhoan.Text = "I agree to the terms of service";
            button_dangKyTaiKhoanScreen_dangKy.Text = "Sign up";

            // Thay screen thông tin tài khoản
            labelText_thongTinTaiKhoanScreen_thongTinTaiKhoan.Text = "Account information";
            labelText_thongTinTaiKhoanScreen_tenDangNhap.Text = "Account name:";
            labelText_thongTinTaiKhoanScreen_hoTen.Text = "Name:";
            labelText_thongTinTaiKhoanScreen_gioiTinh.Text = "Gender:";
            labelText_thongTinTaiKhoanScreen_ngaySinh.Text = "Date of birth:";
            labelText_thongTinTaiKhoanScreen_email.Text = "Email:";
            labelText_thongTinTaiKhoanScreen_soDienThoai.Text = "Phone number:";
            labelText_thongTinTaiKhoanScreen_cmnd_cccd.Text = "Identity card number";

            buttonSub_caNhanScreen_tiengViet.BackColor = Color.White;
            buttonSub_caNhanScreen_tiengAnh.BackColor = Color.LightGreen;
            buttonSub_caNhanScreen_tiengNhat.BackColor = Color.White;
            hideSubMenu();
        }

        private void buttonSub_click_caNhanScreen_tiengNhat(object sender, EventArgs e)
        {
            // Thay screen xoetxoet
            richTextBox_search_bar.Text = " サービスの検索...";
            labelText_xoetXoetScreen_deXuat.Text = "XoetXoetおすすめ";
            labelText_xoetXoetScreen_uuDai.Text = "お得";
            labelText_xoetXoetScreen_dichVu.Text = "サービス";
            button_xoetXoetScreen_lauDon.Text = "掃除";
            button_xoetXoetScreen_trongTre.Text = "子供の面倒";
            button_xoetXoetScreen_diCho.Text = "お買い物";
            button_xoetXoetScreen_giatUi.Text = "洗濯";
            button_xoetXoetScreen_nauAn.Text = "クッキング";
            button_xoetXoetScreen_lauKinh.Text = "ガラス磨き";
            button_xoetXoetScreen_ruaXe.Text = "洗車";
            button_xoetXoetScreen_chuyenPhat.Text = "配送";
            button_xoetXoetScreen_trongNha.Text = "留守番";
            button_xoetXoetScreen_suaChuaDienMay.Text = "留守番";
            button_xoetXoetScreen_trangTriNoiThat.Text = "インテリアデザイン";
            button_xoetXoetScreen_diCho_2.Text = "お買い物";
            button_xoetXoetScreen_dietConTrung.Text = "殺虫消毒";
            button_xoetXoetScreen_lauDon_2.Text = "掃除";
            button_xoetXoetScreen_trongTre_2.Text = "子供の面倒";
            button_xoetXoetScreen_veSinhDieuHoa.Text = "エアコン掃除";
            button_xoetXoetScreen_chuyenNha.Text = "引っ越し";

            // Thay screen thông tin chi tiết
            labelText_thongTinChiTietScreen_vuiLongDienThongTin.Text = "下記の情報をご記入ください";
            labelText_thongTinChiTietScreen_ngayLamViec.Text = "出勤日:";
            labelText_thongTinChiTietScreen_gioiTinh.Text = "スタッフの性別:";
            labelText_thongTinChiTietScreen_doTuoi.Text = "スタッフの年齢:";
            labelText_thongTinChiTietScreen_diaChiLamViec.Text = "勤務先:";
            labelText_thongTinChiTietScreen_ghiChu.Text = "備考:";
            labelText_thongTinChiTietScreen_thanhTien.Text = "金額:";
            button_thongTinChiTietScreen_xacNhan.Text = "確認:";

            // Thay screen thông báo
            labelText_thongBaoScreen_thongBao.Text = "通知";

            // Thay screen thanh toán
            button_thanhToan.Text = "お支払い";
            labelText_thanhToanScreen_thanhToan.Text = "お支払い";
            labelText_thanhToanScreen_hienTaiChuaChonDichVuNao.Text = "現在、サービスがまだ選択されておりません";
            labelText_thanhToanScreen_nhapMaGiamGia.Text = "割引クーポン:";
            labelText_thanhToanScreen_tongSoTien.Text = "全額:";
            button_thanhToanScreen_thanhToan.Text = "お支払い";

            // Thay screen chi tiết
            labelText_chiTietScreen_chiTiet.Text = "詳細";
            labelText_chiTietScreen_thoiGianDat.Text = "発注時間:";
            labelText_chiTietScreen_tenDichVu.Text = "サービスの種類:";
            labelText_chiTietScreen_gioiTinh.Text = "性別:";
            labelText_chiTietScreen_doTuoi.Text = "年齢:";
            labelText_chiTietScreen_diaChiLamViec.Text = "勤務先:";
            labelText_chiTietScreen_ghiChu.Text = "備考:";
            labelText_chiTietScreen_thanhTien.Text = "金額:";
            button_chiTietScreen_huyYeuCau.Text = "キャンセル";

            // Thay screen lịch sử giao dịch
            button_lichSuGD.Text = "履歴";
            labelText_lichSuGDScreen_lichSuGiaoDich.Text = "取引履歴";
            labelText_lichSuGDScreen_hienTaiChuaCoGiaoDichNao.Text = "現在、取引がございません";

            // Thay screen cá nhân
            button_caNhan.Text = "個人";
            labelText_caNhanScreen_chuaDangNhap.Text = "まだログインしておりません";
            labelText_caNhanScreen_caNhan.Text = "個人";
            button_caNhanScreen_dangNhap.Text = "ログイン";
            button_caNhanScreen_dangKyNgay.Text = "登録";
            button_caNhanScreen_thongTinTaiKhoan.Text = "アカウント情報";
            button_caNhanScreen_caiDatNgonNgu.Text = "言語設定";
            buttonSub_caNhanScreen_tiengViet.Text = "ベトナム語";
            buttonSub_caNhanScreen_tiengAnh.Text = "英語";
            buttonSub_caNhanScreen_tiengNhat.Text = "日本語";
            button_caNhanScreen_doiMauUngDung.Text = "色の変更";
            buttonSub_caNhanScreen_xanhDaTroi.Text = "青";
            buttonSub_caNhanScreen_cam.Text = "オレンジ";
            buttonSub_caNhanScreen_vang.Text = "黄色";
            button_caNhanScreen_troGiup.Text = "サポート";
            button_caNhanScreen_thoat.Text = "ログアウト";
            labelText_caNhanScreen_xinChao.Text = "こんにちは、";

            // Thay screen đăng nhập
            button_dangNhapScreen_dangNhap.Text = "ログイン";
            labelText_dangNhapScreen_tenDangNhap.Text = "ログインID";
            labelText_dangNhapScreen_matKhau.Text = "パスワード"; 
            button_dangNhapScreen_dangNhap.Text = "ログイン";
            label_dangNhapScreen_matKhau.Text = "パスワード忘れ";

            // Thay screen đăng ký tài khoản
            labelText_dangKyTaiKhoanScreen_dangKyTaiKhoan.Text = "アカウント登録";
            labelText_dangKyTaiKhoanScreen_chaoMung.Text = "ようこそ XoetXoetへ";
            labelText_dangKyTaiKhoanScreen_text1.Text = "XoetXoetのコミュニティに参加するもう少しのステップ ^^";
            labelText_dangKyTaiKhoanScreen_tenDangNhap.Text = "ログインID";
            labelText_dangKyTaiKhoanScreen_ho.Text = "名字";
            labelText_dangKyTaiKhoanScreen_ten.Text = "お名前";
            labelText_dangKyTaiKhoanScreen_gioiTinh.Text = "性別";
            labelText_dangKyTaiKhoanScreen_ngaySinh.Text = "生年月日";
            labelText_dangKyTaiKhoanScreen_soDienThoai.Text = "電話番号";
            labelText_dangKyTaiKhoanScreen_email.Text = "メールアドレス";
            labelText_dangKyTaiKhoanScreen_CMND_CCCD.Text = "IDカード番号";
            labelText_dangKyTaiKhoanScreen_matKhau.Text = "パスワード";
            labelText_dangKyTaiKhoanScreen_nhapLaiMatKhau.Text = "パスワードをもう一度入力してください";
            checkBox_dangKyTaiKhoanScreen_dongYDieuKhoan.Text = "サービスの条件に同意する";
            button_dangKyTaiKhoanScreen_dangKy.Text = "登録";

            // Thay screen thông tin tài khoản
            labelText_thongTinTaiKhoanScreen_thongTinTaiKhoan.Text = "アカウント情報";
            labelText_thongTinTaiKhoanScreen_tenDangNhap.Text = "ログインID";
            labelText_thongTinTaiKhoanScreen_hoTen.Text = "お名前";
            labelText_thongTinTaiKhoanScreen_gioiTinh.Text = "性別";
            labelText_thongTinTaiKhoanScreen_ngaySinh.Text = "生年月日";
            labelText_thongTinTaiKhoanScreen_email.Text = "メールアドレス";
            labelText_thongTinTaiKhoanScreen_soDienThoai.Text = "電話番号";
            labelText_thongTinTaiKhoanScreen_cmnd_cccd.Text = "IDカード番号";

            buttonSub_caNhanScreen_tiengViet.BackColor = Color.White;
            buttonSub_caNhanScreen_tiengAnh.BackColor = Color.White;
            buttonSub_caNhanScreen_tiengNhat.BackColor = Color.LightGreen;
            hideSubMenu();
        }

        private void button_click_caNhanScreen_doiMauUngDung(object sender, EventArgs e)
        {
            showSubMenu(panel_caNhanScreen_doiMauUngDungSubMenu);
        }

        private void button_click_caNhanScreen_troGiup(object sender, EventArgs e)
        {
            string message = "";
            if (buttonSub_caNhanScreen_tiengViet.BackColor == Color.LightGreen)
            {
                message = "Sản phẩm của: Dương Đình Thắng\nMã số sinh viên: 19522195";
            }
            else if (buttonSub_caNhanScreen_tiengAnh.BackColor == Color.LightGreen)
            {
                message = "Products of: Duong Dinh Thang\nStudent ID: 19522195";
            }
            else
            {
                message = "タングの製品\n学生証：19522195";
            }
            MessageBox.Show(message);
        }

        private void button_click_caNhanScreen_dangNhap(object sender, EventArgs e)
        {
            panelScreen_dangNhap.Location = new Point(0, 0);
            panelScreen_dangNhap.Visible = true;

            panelScreen_thongTinChiTiet.Visible = false;
            panelScreen_lichSuGD.Visible = false;
            panelScreen_thanhToan.Visible = false;
            panelScreen_thongBao.Visible = false;
            panelScreen_main_home_xoetxoet.Visible = false;
            panelScreen_chiTietDichVuDaDat.Visible = false;
            panelScreen_dangKyTaiKhoan.Visible = false;
            panelScreen_caNhan.Visible = false;
            panelScreen_thongTinTaiKhoan.Visible = false;
        }

        private void button_click_caNhanScreen_thoat(object sender, EventArgs e)
        {
            // Bật và tắt visibility của một số objects trang cá nhân
            labelText_caNhanScreen_chuaDangNhap.Visible = true;
            button_caNhanScreen_dangKyNgay.Visible = true;
            button_caNhanScreen_dangNhap.Visible = true ;
            if (buttonSub_caNhanScreen_tiengViet.BackColor == Color.LightGreen)
            {
                labelText_caNhanScreen_xinChao.Text = "Xin chào, ";
            }
            else if (buttonSub_caNhanScreen_tiengAnh.BackColor == Color.LightGreen)
            {
                labelText_caNhanScreen_xinChao.Text = "Hi, ";
            }
            else
            {
                labelText_caNhanScreen_xinChao.Text = "こんにちは、";
            }
            labelText_caNhanScreen_xinChao.Visible = false; ;

            // Tắt tính năng thoát khỏi tài khoản hiện tại
            button_caNhanScreen_thoat.Visible = false;

            // Uncheck đã đăng nhập
            checkDaDangNhap = false;

            // Cập nhật tên đăng nhập hiện tại
            tenDangNhapHienTai = "";

            // Ẩn số tiền tạm tính trong giỏ hàng của account đã thoát
            labelValue_thanhToanScreen_tongSoTien.Text = "0";

            // Tắt visibility các listview
            listView_lichSuGDScreen_lichSuGiaoDich.Visible = false;
            listView_thanhToanScreen_danhSachDichVuDaDat.Visible = false;

            // display image in picture box  
            pictureBox_caNhanScreen_avatar.Image = new Bitmap(@"..\..\materials\default_avatar.png");

            string message = "";
            if (buttonSub_caNhanScreen_tiengViet.BackColor == Color.LightGreen)
            {
                message = "Thoát khỏi tài khoản thành công.";
            }
            else if (buttonSub_caNhanScreen_tiengAnh.BackColor == Color.LightGreen)
            {
                message = "Successfully logged out of the account.";
            }
            else
            {
                message = "アカウントから正常にログアウトしました。";
            }
            MessageBox.Show(message);
        }

        private void button_click_dangNhapScreen_dangNhap(object sender, EventArgs e)
        {
            string inputTenDangNhap = textBox_dangNhapScreen_tenDangNhap.Text;
            string inputMatKhau = textBox_dangNhapScreen_matKhau.Text;

            string searchExpression = "TenDangNhap='" + inputTenDangNhap + "'";
            try
            {
                DataRow[] rows = accounts_dt.Select(searchExpression);

                if (inputMatKhau != rows[0]["MatKhau"].ToString())
                {
                    string message = "";
                    if (buttonSub_caNhanScreen_tiengViet.BackColor == Color.LightGreen)
                    {
                        message = "Tên đăng nhập hoặc mật khẩu không hợp lệ.";
                    }
                    else if (buttonSub_caNhanScreen_tiengAnh.BackColor == Color.LightGreen)
                    {
                        message = "Invalid username or password.";
                    }
                    else
                    {
                        message = "無効なユーザー名またはパスワード。";
                    }
                    MessageBox.Show(message);
                }
                else
                {
                    // Check đã đăng nhập
                    checkDaDangNhap = true;

                    // Bật visibility các listview
                    listView_lichSuGDScreen_lichSuGiaoDich.Visible = true;
                    listView_thanhToanScreen_danhSachDichVuDaDat.Visible = true;

                    // Bật và tắt visibility của một số objects trang cá nhân
                    labelText_caNhanScreen_chuaDangNhap.Visible = false;
                    button_caNhanScreen_dangKyNgay.Visible = false;
                    button_caNhanScreen_dangNhap.Visible = false;
                    labelText_caNhanScreen_xinChao.Text += inputTenDangNhap;
                    labelText_caNhanScreen_xinChao.Visible = true;

                    // Cập nhật tên đăng nhập hiện tại
                    tenDangNhapHienTai = inputTenDangNhap;

                    // Bật tính năng thoát khỏi tài khoản hiện tại
                    button_caNhanScreen_thoat.Visible = true;

                    // Hiển thị lại thông tin tổng số tiền trong giỏ hàng
                    System.Globalization.CultureInfo cul = System.Globalization.CultureInfo.GetCultureInfo("vi-VN");
                    labelValue_thanhToanScreen_tongSoTien.Text = double.Parse(Convert.ToString(tong_so_tien)).ToString("#,###", cul.NumberFormat);

                    // Xóa các thông tin ghi trong textbox ở screen đăng nhập 
                    textBox_dangNhapScreen_tenDangNhap.Text = "";
                    textBox_dangNhapScreen_matKhau.Text = "";

                    this.button_click_dangKyTaiKhoanScreen_left_arrow(sender, e);

                    string message = "";
                    if (buttonSub_caNhanScreen_tiengViet.BackColor == Color.LightGreen)
                    {
                        message = "Đăng nhập thành công.";
                    }
                    else if (buttonSub_caNhanScreen_tiengAnh.BackColor == Color.LightGreen)
                    {
                        message = "Logged in successfully.";
                    }
                    else
                    {
                        message = "正常にログインしました。";
                    }
                    MessageBox.Show(message);
                }
            }
            catch (Exception)
            {
                string message = "";
                if (buttonSub_caNhanScreen_tiengViet.BackColor == Color.LightGreen)
                {
                    message = "Tên đăng nhập hoặc mật khẩu không hợp lệ.";
                }
                else if (buttonSub_caNhanScreen_tiengAnh.BackColor == Color.LightGreen)
                {
                    message = "Invalid username or password.";
                }
                else
                {
                    message = "無効なユーザー名またはパスワード。";
                }
                MessageBox.Show(message);
            }
        }

        private void labelText_click_dangNhapScreen_quenMatKhau(object sender, EventArgs e)
        {

        }

        private void button_click_dangNhapScreen_left_arrow(object sender, EventArgs e)
        {
            this.button_click_dangKyTaiKhoanScreen_left_arrow(sender, e);
        }

        private void button_click_thongTinTaiKhoanScreen_left_arrow(object sender, EventArgs e)
        {
            this.button_click_dangKyTaiKhoanScreen_left_arrow(sender, e);
        }

        private void buttonSub_click_caNhanScreen_xanhDaTroi(object sender, EventArgs e)
        {
            panelBottomBar_mainMenu.BackColor = Color.LightSkyBlue;
            panelTopBar_caNhanScreen.BackColor = Color.LightSkyBlue;
            panelTopBar_chiTietScreen.BackColor = Color.LightSkyBlue;
            paneltopBar_dangKyTaiKhoanScreen.BackColor = Color.LightSkyBlue;
            panelTopBar_dangNhapScreen.BackColor = Color.LightSkyBlue;
            panelTopBar_lichSuGD.BackColor = Color.LightSkyBlue;
            panelTopBar_thanhToanScreen.BackColor = Color.LightSkyBlue;
            panelTopBar_thongBaoScreen.BackColor = Color.LightSkyBlue;
            panelTopBar_thongTinChiTietScreen.BackColor = Color.LightSkyBlue;
            panelTopBar_thongTinTaiKhoanScreen.BackColor = Color.LightSkyBlue;
            panelTopBar_xoetXoetScreen.BackColor = Color.LightSkyBlue;

            buttonSub_caNhanScreen_xanhDaTroi.BackColor = Color.LightGreen;
            buttonSub_caNhanScreen_cam.BackColor = Color.White;
            buttonSub_caNhanScreen_vang.BackColor = Color.White;
            hideSubMenu();
        }

        private void buttonSub_click_caNhanScreen_cam(object sender, EventArgs e)
        {
            panelBottomBar_mainMenu.BackColor = Color.Coral;
            panelTopBar_caNhanScreen.BackColor = Color.Coral;
            panelTopBar_chiTietScreen.BackColor = Color.Coral;
            paneltopBar_dangKyTaiKhoanScreen.BackColor = Color.Coral;
            panelTopBar_dangNhapScreen.BackColor = Color.Coral;
            panelTopBar_lichSuGD.BackColor = Color.Coral;
            panelTopBar_thanhToanScreen.BackColor = Color.Coral;
            panelTopBar_thongBaoScreen.BackColor = Color.Coral;
            panelTopBar_thongTinChiTietScreen.BackColor = Color.Coral;
            panelTopBar_thongTinTaiKhoanScreen.BackColor = Color.Coral;
            panelTopBar_xoetXoetScreen.BackColor = Color.Coral;

            buttonSub_caNhanScreen_xanhDaTroi.BackColor = Color.White;
            buttonSub_caNhanScreen_cam.BackColor = Color.LightGreen;
            buttonSub_caNhanScreen_vang.BackColor = Color.White;
            hideSubMenu();
        }

        private void buttonSub_click_caNhanScreen_vang(object sender, EventArgs e)
        {
            panelBottomBar_mainMenu.BackColor = Color.Khaki;
            panelTopBar_caNhanScreen.BackColor = Color.Khaki;
            panelTopBar_chiTietScreen.BackColor = Color.Khaki;
            paneltopBar_dangKyTaiKhoanScreen.BackColor = Color.Khaki;
            panelTopBar_dangNhapScreen.BackColor = Color.Khaki;
            panelTopBar_lichSuGD.BackColor = Color.Khaki;
            panelTopBar_thanhToanScreen.BackColor = Color.Khaki;
            panelTopBar_thongBaoScreen.BackColor = Color.Khaki;
            panelTopBar_thongTinChiTietScreen.BackColor = Color.Khaki;
            panelTopBar_thongTinTaiKhoanScreen.BackColor = Color.Khaki;
            panelTopBar_xoetXoetScreen.BackColor = Color.Khaki;


            buttonSub_caNhanScreen_xanhDaTroi.BackColor = Color.White;
            buttonSub_caNhanScreen_cam.BackColor = Color.White;
            buttonSub_caNhanScreen_vang.BackColor = Color.LightGreen;
            hideSubMenu();
        }

        private void button_click_chiTietDichVuDaDatScreen_left_arrow(object sender, EventArgs e)
        {
            panelScreen_thanhToan.Location = new Point(0, 0);
            panelScreen_thanhToan.Visible = true;

            panelScreen_thongTinChiTiet.Visible = false;
            panelScreen_lichSuGD.Visible = false;
            panelScreen_caNhan.Visible = false;
            panelScreen_thongBao.Visible = false;
            panelScreen_main_home_xoetxoet.Visible = false;
            panelScreen_chiTietDichVuDaDat.Visible = false;
            panelScreen_dangKyTaiKhoan.Visible = false;
            panelScreen_dangNhap.Visible = false;
            panelScreen_thongTinTaiKhoan.Visible = false;
        }

        private void button_click_chiTietScreen_huyYeuCau(object sender, EventArgs e)
        {
            string searchExpression = "MaGD='" + Convert.ToString(MaGD) + "'";
            DataRow[] rows = dt.Select(searchExpression);
            int rowIndex = STTDV;
            rows[rowIndex].Delete();

            // Trừ tiền dịch vụ vào tổng tiền
            System.Globalization.CultureInfo cul = System.Globalization.CultureInfo.GetCultureInfo("vi-VN");
            tong_so_tien -= Convert.ToInt32(labelValue_chiTietScreen_thanhTien.Text.Replace(",", ""));
            labelValue_thanhToanScreen_tongSoTien.Text = double.Parse(Convert.ToString(tong_so_tien)).ToString("#,###", cul.NumberFormat);

            listView_thanhToanScreen_danhSachDichVuDaDat.Items[rowIndex].Remove();
            STTDV -= 1;
            this.button_click_chiTietDichVuDaDatScreen_left_arrow(sender, e);
        }

        private int welcomeImageNumber = 1;
        private void loadNextWelcomeImage()
        {
            if (welcomeImageNumber == 3)
            {
                welcomeImageNumber = 1;
            }
            picturebox_xoetXoetScreen_quangCaoSliding.ImageLocation = string.Format(@"homescreen_sliding\{0}.jpg", welcomeImageNumber);
            welcomeImageNumber++;
        }

        private int voucherImageNumber = 1;
        private void loadNextVoucherImage()
        {
            if (voucherImageNumber == 3)
            {
                voucherImageNumber = 1;
            }
            pictureBox_xoetXoetScreen_voucher.ImageLocation = string.Format(@"voucher_sliding\{0}.jpg", voucherImageNumber);
            voucherImageNumber++;
        }

        private void timer_tick_for_homescreen_sliding(object sender, EventArgs e)
        {
            loadNextWelcomeImage();
        }

        private void timer_for_voucher_sliding_Tick(object sender, EventArgs e)
        {
            loadNextVoucherImage();
        }
    }
}
