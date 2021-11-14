using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.Util;
using Emgu.CV.Structure;
using Emgu.CV.CvEnum;
using ZXing;
using QRCoder;

namespace exercise9
{
    public partial class FormMain : Form
    {

        private DataTable item_category;
        private DataTable picked_items;

        public DataTable ItemCategoryDt
        {
            get { return item_category; }
            set { item_category = value; }
        }

        private void UpdateDataGridView(DataTable new_dt)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = new_dt.DefaultView;
            dataGridView1.BackgroundColor = dataGridView1.DefaultCellStyle.BackColor;
            dataGridView1.Update();
            dataGridView1.Refresh();
        }

        private DataTable initialize_item_category_dt()
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("MaSP", typeof(string));
            dt.Columns.Add("TenSP", typeof(string));
            dt.Columns.Add("Gia", typeof(string));
            dt.Columns.Add("QRCode", typeof(Image));

            QRCodeGenerator qrGenerator = new QRCodeGenerator();

            QRCode qrCode = new QRCode(qrGenerator.CreateQrCode("001", QRCodeGenerator.ECCLevel.Q));
            dt.Rows.Add("001", "Dầu gội", "99000", qrCode.GetGraphic(2, Color.Black, Color.White, false));

            qrCode = new QRCode(qrGenerator.CreateQrCode("002", QRCodeGenerator.ECCLevel.Q));
            dt.Rows.Add("002", "Sữa tắm", "135000", qrCode.GetGraphic(2, Color.Black, Color.White, false));

            qrCode = new QRCode(qrGenerator.CreateQrCode("003", QRCodeGenerator.ECCLevel.Q));
            dt.Rows.Add("003", "Nước rửa chén", "88000", qrCode.GetGraphic(2, Color.Black, Color.White, false));

            qrCode = new QRCode(qrGenerator.CreateQrCode("004", QRCodeGenerator.ECCLevel.Q));
            dt.Rows.Add("004", "Gạo S125", "150000", qrCode.GetGraphic(2, Color.Black, Color.White, false));

            qrCode = new QRCode(qrGenerator.CreateQrCode("005", QRCodeGenerator.ECCLevel.Q));
            dt.Rows.Add("005", "Nước suối lavie chai 1 lít", "21000", qrCode.GetGraphic(2, Color.Black, Color.White, false));

            qrCode = new QRCode(qrGenerator.CreateQrCode("006", QRCodeGenerator.ECCLevel.Q));
            dt.Rows.Add("006", "Nước tăng lực Sting", "8000", qrCode.GetGraphic(2, Color.Black, Color.White, false));

            qrCode = new QRCode(qrGenerator.CreateQrCode("007", QRCodeGenerator.ECCLevel.Q));
            dt.Rows.Add("007", "Dầu ăn Simply chai 5 lít", "209000", qrCode.GetGraphic(2, Color.Black, Color.White, false));

            qrCode = new QRCode(qrGenerator.CreateQrCode("008", QRCodeGenerator.ECCLevel.Q));
            dt.Rows.Add("008", "Kem Wall", "11000", qrCode.GetGraphic(2, Color.Black, Color.White, false));

            qrCode = new QRCode(qrGenerator.CreateQrCode("009", QRCodeGenerator.ECCLevel.Q));
            dt.Rows.Add("009", "Bánh gạo One One", "18000", qrCode.GetGraphic(2, Color.Black, Color.White, false));

            qrCode = new QRCode(qrGenerator.CreateQrCode("010", QRCodeGenerator.ECCLevel.Q));
            dt.Rows.Add("010", "Kẹo bạc hà", "10000", qrCode.GetGraphic(2, Color.Black, Color.White, false));

            return dt;
        }

        private DataTable initialize_picked_items_dt()
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("STT", typeof(string));
            dt.Columns.Add("MaSP", typeof(string));
            dt.Columns.Add("TenSP", typeof(string));
            dt.Columns.Add("SL", typeof(string));
            dt.Columns.Add("Gia", typeof(string));
            dt.Columns.Add("TT", typeof(string));


            return dt;
        }

        private Capture cap;
        public FormMain()
        {
            item_category = initialize_item_category_dt();
            picked_items = initialize_picked_items_dt();
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = picked_items;
            dataGridView1.BackgroundColor = dataGridView1.DefaultCellStyle.BackColor;
            cap = new Capture(0);
            timer1.Enabled = true;
        }


        private void timer1_tick(object sender, EventArgs e)
        {
            Image<Bgr, byte> nextFrame = cap.QueryFrame();
            //Image<Gray, Byte> grayframe = new Image<Gray, byte>(nextFrame.ToBitmap());
            //Image<Gray, byte> grayframe = nextFrame.Convert<Gray, byte>();
            pictureBox_webCam.Image = nextFrame.ToBitmap();
            Bitmap imgQRCode = (Bitmap)pictureBox_webCam.Image;
            if (imgQRCode != null)
            {
                try
                {
                    ZXing.BarcodeReader Reader = new ZXing.BarcodeReader();
                    Result result = Reader.Decode(imgQRCode);
                    string decoded = result.ToString().Trim();
                    string search_expresison = "MaSP='" + decoded + "'";
                    DataRow[] find_row = picked_items.Select(search_expresison);
                    if (find_row.Length.ToString() == "0")
                    {
                        int stt = picked_items.Rows.Count + 1;
                        DataRow[] find_category_rows = item_category.Select(search_expresison);
                        string MaSP = find_category_rows[0][0].ToString();
                        string TenSP = find_category_rows[0][1].ToString();
                        int sl = 1;
                        int gia = Convert.ToInt32(find_category_rows[0][2].ToString());
                        int tt = gia * sl;
                        picked_items.Rows.Add(stt.ToString(), MaSP, TenSP, sl.ToString(), gia.ToString(), tt.ToString());
                    }
                    else
                    {
                        int sl = Convert.ToInt32(find_row[0][3].ToString()) + 1;
                        find_row[0][3] = sl.ToString();
                        int gia = Convert.ToInt32(find_row[0][4].ToString());
                        int tt = gia * sl;
                        find_row[0][5] = tt.ToString();
                        // picked_items.Rows.Add("0", "0", "0", "0", "0", "0");
                    }
                    // picked_items.Rows.Add("0", "0", "0", "0", "0", "0");
                    // imgQRCode.Dispose();
                    dataGridView1.Update();
                    dataGridView1.Refresh();
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message + "");
                }
            }
            int tong = 0;
            foreach (DataRow row in picked_items.Rows)
            {
                tong += Convert.ToInt32(row[5].ToString());
            }
            int thanh_toan;
            if (textBox_khuyenMai.Text == "")
            {
                thanh_toan = tong;
            }
            else
            {
                thanh_toan = tong - tong * Convert.ToInt32(textBox_khuyenMai.Text) / 100;
            }
            textBox_tongTien.Text = tong.ToString();
            textBox_thanhToan.Text = thanh_toan.ToString();
        }

        private void pictureBox_click_category(object sender, EventArgs e)
        {
            FormItemCategory form = new FormItemCategory(this);            
            form.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
