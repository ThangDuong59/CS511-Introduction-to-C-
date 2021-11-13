using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practice02
{
    public partial class ucOrderedItemUI : UserControl
    {
        #region Properties
        private int _index;
        private string _product_id;
        private string _title;
        private string _name;
        private string _category;
        private string _brand;
        private string _made_in;
        private string _time_restore;
        private string _price;
        private string _stars;
        private string _discount_code;
        private int _exchange_method;
        private int _quantity = 1;
        private Image _pictureBoxImage;
        private bool _isBuy;

        [Category("Custom Props")]
        public int Index
        {
            get { return _index; }
            set { _index = value; }
        }

        [Category("Custom Props")]
        public string ProductID
        {
            get { return _product_id; }
            set { _product_id = value; }
        }

        [Category("Custom Props")]
        public string Stars
        {
            get { return _stars; }
            set { _stars = value; }
        }

        [Category("Custom Props")]
        public string Brand
        {
            get { return _brand; }
            set { _brand = value; }
        }

        [Category("Custom Props")]
        public string MadeIn
        {
            get { return _made_in; }
            set { _made_in = value; }
        }

        [Category("Custom Props")]
        public string TimeRestore
        {
            get { return _time_restore; }
            set { _time_restore = value; }
        }

        [Category("Custom Props")]
        public string Category
        {
            get { return _category; }
            set { _category = value; }
        }

        [Category("Custom Props")]
        public string ItemName
        {
            get { return _name; }
            set { _name = value;}
        }


        [Category("Custom Props")]
        public string DiscountCode
        {
            get { return _discount_code; }
            set { _discount_code = value;}
        }

        [Category("Custom Props")]
        public int ExchangeMethod
        {
            get { return _exchange_method; }
            set { _exchange_method = value;}
        }

        [Category("Custom Props")]
        public string Title
        {
            get { return _title; }
            set { _title = value; labelValue_ucOrderedItemUI_itemTitle.Text = value; }
        }

        [Category("Custom Props")]
        public string Price
        {
            get { return _price; }
            set { _price = value; labelValue_ucOrderedItemUI_itemPrice.Text = value; }
        }

        [Category("Custom Props")]
        public Image PictureBoxImage
        {
            get { return _pictureBoxImage; }
            set { _pictureBoxImage = value; pictureBox_ucOrderedItemUI_itemPic.Image = value; }
        }

        [Category("Custom Props")]
        public bool CheckBoxIsBuy
        {
            get { return _isBuy; }
            set { _isBuy = value; checkBox_ucOrderedItemUI_isPay.Checked = value; }
        }

        [Category("Custom Props")]
        public int Quantity
        {
            get { return _quantity; }
            set { _quantity = value; numericUpDown_ucOrderedItemUI_quantity.Value = value; }
        }

        #endregion
        public ucOrderedItemUI()
        {
            InitializeComponent();
        }

        private void checkBox_click_ucOrderedItemUI_isPay(object sender, EventArgs e)
        {
            _isBuy = true;
            if (checkBox_ucOrderedItemUI_isPay.Checked == true)
            {
                ucMyOrderScreen ucMyOrderScreenInstance = formMain.Instance.PanelContainer.Controls["ucMyOrderScreen"] as ucMyOrderScreen;
                int total_price = Convert.ToInt32(labelValue_ucOrderedItemUI_itemPrice.Text.Replace(".", "").Replace("đ", "")) + Convert.ToInt32(ucMyOrderScreenInstance.totalPrice.Replace(".", "").Replace("đ", ""));
                System.Globalization.CultureInfo cul = System.Globalization.CultureInfo.GetCultureInfo("vi-VN");
                ucMyOrderScreenInstance.totalPrice = double.Parse(Convert.ToString(total_price)).ToString("#,###", cul.NumberFormat);
            }
            else
            {
                ucMyOrderScreen ucMyOrderScreenInstance = formMain.Instance.PanelContainer.Controls["ucMyOrderScreen"] as ucMyOrderScreen;
                int total_price = Convert.ToInt32(ucMyOrderScreenInstance.totalPrice.Replace(".", "").Replace("đ", "")) - Convert.ToInt32(labelValue_ucOrderedItemUI_itemPrice.Text.Replace(".", "").Replace("đ", "")) ;
                if (total_price == 0)
                {
                    ucMyOrderScreenInstance.totalPrice = "0";
                }
                else
                {
                    System.Globalization.CultureInfo cul = System.Globalization.CultureInfo.GetCultureInfo("vi-VN");
                    ucMyOrderScreenInstance.totalPrice = double.Parse(Convert.ToString(total_price)).ToString("#,###", cul.NumberFormat);
                }
            }
        }

        private void numericUpDown_valueChanged_ucOrderedItemUI_quantity(object sender, EventArgs e)
        {
            _quantity = Convert.ToInt32(numericUpDown_ucOrderedItemUI_quantity.Value);
            System.Globalization.CultureInfo cul = System.Globalization.CultureInfo.GetCultureInfo("vi-VN");
            if (checkBox_ucOrderedItemUI_isPay.Checked == true)
            {
                checkBox_ucOrderedItemUI_isPay.Checked = false;
                ucMyOrderScreen ucMyOrderScreenInstance = formMain.Instance.PanelContainer.Controls["ucMyOrderScreen"] as ucMyOrderScreen;
                int total_price = Convert.ToInt32(ucMyOrderScreenInstance.totalPrice.Replace(".", "").Replace("đ", "")) - Convert.ToInt32(labelValue_ucOrderedItemUI_itemPrice.Text.Replace(".", "").Replace("đ", ""));
                if (total_price == 0)
                {
                    ucMyOrderScreenInstance.totalPrice = "0";
                }
                else
                {
                    ucMyOrderScreenInstance.totalPrice = double.Parse(Convert.ToString(total_price)).ToString("#,###", cul.NumberFormat);
                }
            }
            int new_total_price = Convert.ToInt32(_price.Replace(".", "").Replace("đ", "")) * Convert.ToInt32(_quantity);
            labelValue_ucOrderedItemUI_itemPrice.Text = double.Parse(Convert.ToString(new_total_price)).ToString("#,###", cul.NumberFormat);
        }

        private void pictureBox_click_ucOrderedItemUI_trash(object sender, EventArgs e)
        {
            ucMyOrderScreen ucMyOrderScreenInstance = formMain.Instance.PanelContainer.Controls["ucMyOrderScreen"] as ucMyOrderScreen;
            FlowLayoutPanel flowLayoutPanelInstance = formMain.Instance.PanelContainer.Controls["ucMyOrderScreen"].Controls["flowLayoutPanel_ucMyOrderScreen"] as FlowLayoutPanel;

            if(_isBuy == true)
            {
                int total_price = Convert.ToInt32(ucMyOrderScreenInstance.totalPrice.Replace(".", "").Replace("đ", "")) - Convert.ToInt32(labelValue_ucOrderedItemUI_itemPrice.Text.Replace(".", "").Replace("đ", ""));
                System.Globalization.CultureInfo cul = System.Globalization.CultureInfo.GetCultureInfo("vi-VN");
                if (total_price == 0)
                {
                    ucMyOrderScreenInstance.totalPrice = "0";
                }
                else
                {
                    ucMyOrderScreenInstance.totalPrice = double.Parse(Convert.ToString(total_price)).ToString("#,###", cul.NumberFormat);
                }
            }
            flowLayoutPanelInstance.Controls.Remove(this);
        }
    }
}
