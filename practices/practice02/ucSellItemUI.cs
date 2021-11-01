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
        private Image _pictureBoxImage;

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
        public Image PicturePath
        {
            get { return _pictureBoxImage; }
            set { _pictureBoxImage = value; pictureBox_ucSellItemUIScreen_itemPic.Image = value; }
        } 
        #endregion


    }
}
