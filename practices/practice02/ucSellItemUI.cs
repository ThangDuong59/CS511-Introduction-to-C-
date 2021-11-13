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
    public partial class ucSellItemUI : UserControl
    {

        public ucSellItemUI()
        {
            InitializeComponent();
        }

        private void ucSellItemUI_Load(object sender, EventArgs e)
        {

        }

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
            set { _item_timeRestore = value;}
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
            set { _item_madeIn = value;  }
        }

        [Category("Custom Props")]
        public string ItemBrand
        {
            get { return _item_brand; }
            set { _item_brand = value; }
        }

        [Category("Custom Props")]
        public string ItemName
        {
            get { return _item_name; }
            set { _item_name = value;  }
        }

        [Category("Custom Props")]
        public string Stars
        {
            get { return _stars; }
            set { _stars = value; labelValue_ucSellItemUI_starsNumber.Text = value + "/"; }
        }

        [Category("Custom Props")]
        public string Title
        {
            get { return _title; }
            set { _title = value; labelValue_ucSellItemUIScreen_title.Text = value; }
        }

        [Category("Custom Props")]
        public string Price
        {
            get { return _price; }
            set { _price = value; labelValue_ucSellItemUIScreen_price.Text = value; }
        }

        [Category("Custom Props")]
        public Image PictureBoxImage
        {
            get { return _pictureBoxImage; }
            set { _pictureBoxImage = value; pictureBox_ucSellItemUIScreen_itemPic.Image = value; }
        }

        #endregion

        private void directToItemDetailScreen()
        {
            ucItemDetailScreen ucItemDetailScreen = formMain.Instance.PanelContainer.Controls["ucItemDetailScreen"] as ucItemDetailScreen;
            formMain.Instance.PanelContainer.Controls.Remove(ucItemDetailScreen);
            ucItemDetailScreen newucItemDetailScreen = new ucItemDetailScreen();
            newucItemDetailScreen.Title = labelValue_ucSellItemUIScreen_title.Text;
            newucItemDetailScreen.Price = labelValue_ucSellItemUIScreen_price.Text;
            newucItemDetailScreen.Stars = labelValue_ucSellItemUI_starsNumber.Text;
            newucItemDetailScreen.ItemName = _item_name;
            newucItemDetailScreen.ItemCategory = _item_category;
            newucItemDetailScreen.ItemBrand = _item_brand;
            newucItemDetailScreen.ItemMadeIn = _item_madeIn;
            newucItemDetailScreen.ItemTimeRestore = _item_timeRestore;
            newucItemDetailScreen.PictureBoxImage = pictureBox_ucSellItemUIScreen_itemPic.Image;
            formMain.Instance.PanelContainer.Controls.Add(newucItemDetailScreen);
            formMain.Instance.PanelContainer.Controls["ucItemDetailScreen"].BringToFront();
        }

        private void labelValue_click_ucSellItemUI_starsNumber(object sender, EventArgs e)
        {
            directToItemDetailScreen();
        }

        private void pictureBox_click_ucSellItemUIScreen_itemPic(object sender, EventArgs e)
        {
            directToItemDetailScreen();
        }

        private void labelValue_click_ucSellItemUIScreen_title(object sender, EventArgs e)
        {
            directToItemDetailScreen();
        }
    }
}
