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
    public partial class ucItemDetailScreen : UserControl
    {
        #region Properties
        private string _title;
        private string _price;
        private string _stars;
        private string _item_name;
        private string _item_brand;
        private string _item_madeIn;
        private string _item_category;
        private string _item_timeRestore;
        private Image _pictureBoxImage;

        [Category("Custom Props")]
        public string ItemTimeRestore
        {
            get { return _item_timeRestore; }
            set { _item_timeRestore = value; labelValue_ucItemDetailScreen_itemTimeRestore.Text = value; }
        }

        [Category("Custom Props")]
        public string ItemCategory
        {
            get { return _item_category; }
            set { _item_category = value; }
        }

        [Category("Custom Props")]
        public string ItemMadeIn
        {
            get { return _item_madeIn; }
            set { _item_madeIn = value; labelValue_ucItemDetailScreen_itemMadeIn.Text = value; }
        }

        [Category("Custom Props")]
        public string ItemBrand
        {
            get { return _item_brand; }
            set { _item_brand = value; labelValue_ucItemDetailScreen_itemBrand.Text = value; }
        }

        [Category("Custom Props")]
        public string ItemName
        {
            get { return _item_name; }
            set { _item_name = value; labelValue_ucItemDetailScreen_itemName.Text = value; }
        }

        [Category("Custom Props")]
        public string Title
        {
            get { return _title; }
            set { _title = value; labelValue_ucItemDetailScreen_itemName_bigTitle.Text = value; }
        }

        [Category("Custom Props")]
        public string Price
        {
            get { return _price; }
            set { _price = value; labelValue_ucItemDetailScreen_itemPrice.Text = value; }
        }

        [Category("Custom Props")]
        public string Stars
        {
            get { return _stars; }
            set { _stars = value; labelValue_ucItemDetailScreen_itemStars.Text = value; }
        }

        [Category("Custom Props")]
        public Image PictureBoxImage
        {
            get { return _pictureBoxImage; }
            set { _pictureBoxImage = value; pictureBox_ucItemDetailScreen_itemPicture.Image = value; }
        }



        #endregion
        public ucItemDetailScreen()
        {
            InitializeComponent();
        }

        private void labelText_ucItemDetailScreen_itemName_Click(object sender, EventArgs e)
        {

        }

        public static PictureBox item_detail_picturebox = new PictureBox();

        private bool is_check_loved = false;
        private void pictureBox_click_ucItemDetailScreen_loveItem(object sender, EventArgs e)
        {
            if (is_check_loved == false)
            {
                Image filled_love = Image.FromFile(@"../../icons/red_heart_48.png");
                pictureBox_ucItemDetailScreen_loveItem.Image = filled_love;
                is_check_loved = true;
            }
            else
            {
                Image filled_love = Image.FromFile(@"../../icons/heart_48.png");
                pictureBox_ucItemDetailScreen_loveItem.Image = filled_love;
                is_check_loved = false;
            }
        }


        private void button_click_ucItemDetailScreen_itemAddToOrder(object sender, EventArgs e)
        {
            ucOrderedItemUI ucOrderedItemInstance = new ucOrderedItemUI();
            ucOrderedItemInstance.Title = labelValue_ucItemDetailScreen_itemName_bigTitle.Text;
            ucOrderedItemInstance.Price = labelValue_ucItemDetailScreen_itemPrice.Text;
            ucOrderedItemInstance.PictureBoxImage = pictureBox_ucItemDetailScreen_itemPicture.Image;
            ucOrderedItemInstance.CheckBoxIsBuy = false;
            ucMyOrderScreen ucMyOrderScreenInstance = formMain.Instance.PanelContainer.Controls["ucMyOrderScreen"] as ucMyOrderScreen;
            ucMyOrderScreenInstance.NumItemInOrder += 1;
            ucOrderedItemInstance.Index = ucMyOrderScreenInstance.Controls["flowLayoutPanel_ucMyOrderScreen"].Controls.Count + 1;

            formMain.Instance.PanelContainer.Controls["ucMyOrderScreen"].Controls["flowLayoutPanel_ucMyOrderScreen"].Controls.Add(ucOrderedItemInstance);
            formMain.Instance.PanelContainer.Controls["ucMyOrderScreen"].BringToFront();
        }

        private void button_click_ucItemDetailScreen_itemBuy(object sender, EventArgs e)
        {
            ucOrderedItemUI ucOrderedItemInstance = new ucOrderedItemUI();
            ucOrderedItemInstance.Title = labelValue_ucItemDetailScreen_itemName_bigTitle.Text;
            ucOrderedItemInstance.Price = labelValue_ucItemDetailScreen_itemPrice.Text;
            ucOrderedItemInstance.PictureBoxImage = pictureBox_ucItemDetailScreen_itemPicture.Image;
            ucOrderedItemInstance.CheckBoxIsBuy = true;

            ucMyOrderScreen ucMyOrderScreenInstance = formMain.Instance.PanelContainer.Controls["ucMyOrderScreen"] as ucMyOrderScreen;
            ucMyOrderScreenInstance.NumItemInOrder += 1;
            int total_price = Convert.ToInt32(labelValue_ucItemDetailScreen_itemPrice.Text.Replace(".", "").Replace("đ", "")) + Convert.ToInt32(ucMyOrderScreenInstance.totalPrice.Replace(".", "").Replace("đ", ""));
            System.Globalization.CultureInfo cul = System.Globalization.CultureInfo.GetCultureInfo("vi-VN");
            ucOrderedItemInstance.Index = ucMyOrderScreenInstance.Controls["flowLayoutPanel_ucMyOrderScreen"].Controls.Count + 1;
            ucMyOrderScreenInstance.totalPrice = double.Parse(Convert.ToString(total_price)).ToString("#,###", cul.NumberFormat);
            formMain.Instance.PanelContainer.Controls["ucMyOrderScreen"].Controls["flowLayoutPanel_ucMyOrderScreen"].Controls.Add(ucOrderedItemInstance);
            formMain.Instance.PanelContainer.Controls["ucMyOrderScreen"].BringToFront();
        }

        private void labelText_ucItemDetailScreen_itemCategory_Click(object sender, EventArgs e)
        {

        }

        private void button_click_ucItemDetailScreen_backArrow(object sender, EventArgs e)
        {
            ucSearchScreen ucSearchScreenInstance = formMain.Instance.PanelContainer.Controls["ucSearchScreen"] as ucSearchScreen;
            formMain.Instance.PanelContainer.Controls.Remove(ucSearchScreenInstance);
            ucSearchScreen ucSearchScreen = new ucSearchScreen();
            formMain.Instance.PanelContainer.Controls.Add(ucSearchScreen);
            formMain.Instance.PanelContainer.Controls["ucSearchScreen"].BringToFront();
        }
    }
}
