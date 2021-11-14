using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QRCoder;

namespace exercise9
{
    public partial class FormItemCategory : Form
    {
        public FormItemCategory()
        {
            InitializeComponent();
        }

        private FormMain mainForm = null;
        private List<DataRow> new_items = new List<DataRow>();
        public FormItemCategory(Form callingForm)
        {
            this.mainForm = callingForm as FormMain;
            InitializeComponent();
        }

        private void FormItemCategory_Load(object sender, EventArgs e)
        {
            dataGridView_category.DataSource = mainForm.ItemCategoryDt.DefaultView;
            dataGridView_category.BackgroundColor = dataGridView_category.DefaultCellStyle.BackColor;
        }

        private void pictureBox_click_save(object sender, EventArgs e)
        {
            for(int i = 0; i < new_items.Count; i++)
            {
                mainForm.ItemCategoryDt.Rows.Add(new_items[i]);
            }
        }

        private void dataGridView_userAddedRow_category(object sender, DataGridViewRowEventArgs e)
        {
            DataRow row = mainForm.ItemCategoryDt.NewRow();
            new_items.Add(row);
        }

        private void dataGridView_cellEndEdit_category(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                new_items[new_items.Count - 1]["MaSP"] = dataGridView_category.Rows[e.RowIndex].Cells["MaSP"].Value.ToString();
                QRCodeGenerator qrGenerator = new QRCodeGenerator();
                QRCode qrCode = new QRCode(qrGenerator.CreateQrCode(dataGridView_category.Rows[e.RowIndex].Cells["MaSP"].Value.ToString(), QRCodeGenerator.ECCLevel.Q));
                new_items[new_items.Count - 1]["QRCode"] = qrCode.GetGraphic(2, Color.Black, Color.White, false);
            }
            else if (e.ColumnIndex == 1)
            {
                new_items[new_items.Count - 1]["TenSP"] = dataGridView_category.Rows[e.RowIndex].Cells["TenSP"].Value.ToString();
            }
            else
            {
                new_items[new_items.Count - 1]["Gia"] = dataGridView_category.Rows[e.RowIndex].Cells["Gia"].Value.ToString();
            }
        }

        
    }
}
