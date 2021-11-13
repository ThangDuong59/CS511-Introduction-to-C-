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
    public partial class ucItemShippingStatus : UserControl
    {
        #region Properties
        private string _order_title;
        private string _order_id;
        private string _order_date;
        private string _product_id;
        private string _product_name;
        private string _product_brand;
        private string _product_price;
        private string _discount_code;
        private string _exchange_method;
        private string _product_quantity;
        private string _total_price;
        private string _order_status;

        [Category("Custom Props")]
        public string OrderTitle
        {
            get { return _order_title; }
            set { _order_title = value; labelValue_ucHistoryScreen_orderTitle.Text = value; }
        }

        [Category("Custom Props")]
        public string OrderID
        {
            get { return _order_id; }
            set { _order_id = value; }
        }

        [Category("Custom Props")]
        public string OrderDate
        {
            get { return _order_date; }
            set { _order_date = value; labelValue_ucHistoryScreen_orderDate.Text = value; }
        }

        [Category("Custom Props")]
        public string OrderProductID
        {
            get { return _product_id; }
            set { _product_id = value; }
        }

        [Category("Custom Props")]
        public string OrderProductName
        {
            get { return _product_name; }
            set { _product_name = value; }
        }

        [Category("Custom Props")]
        public string OrderProductPrice
        {
            get { return _product_price; }
            set { _product_price = value; }
        }

        [Category("Custom Props")]
        public string OrderDiscountCode
        {
            get { return _discount_code; }
            set { _discount_code = value; }
        }

        [Category("Custom Props")]
        public string OrderExchangeMethod
        {
            get { return _exchange_method; }
            set { _exchange_method = value; }
        }

        [Category("Custom Props")]
        public string OrderProductQuantity
        {
            get { return _product_quantity; }
            set { _product_quantity = value; }
        }

        [Category("Custom Props")]
        public string OrderTotalPrice
        {
            get { return _total_price; }
            set { _total_price = value; labelValue_ucHistoryScreen_price.Text = value; }
        }

        [Category("Custom Props")]
        public string OrderStatus
        {
            get { return _order_status; }
            set { _order_status = value;
                if (_order_status == "0")
                {
                    labelValue_ucHistoryScreen_status.Text = "Chờ xác nhận";
                    labelValue_ucHistoryScreen_status.ForeColor = Color.DarkOrange;
                }
                else if (_order_status == "2")
                {
                    labelValue_ucHistoryScreen_status.Text = "Đã giao";
                    labelValue_ucHistoryScreen_status.ForeColor = Color.ForestGreen;
                    pictureBox_ucHistoryScreen.Enabled = false;
                    pictureBox_ucHistoryScreen.Visible = false;
                }
                else if (_order_status == "3")
                {
                    labelValue_ucHistoryScreen_status.Text = "Đã hủy";
                    labelValue_ucHistoryScreen_status.ForeColor = Color.DarkRed;
                    pictureBox_ucHistoryScreen.Enabled = false;
                    pictureBox_ucHistoryScreen.Visible = false;
                }
            }
        }

        [Category("Custom Props")]
        public string OrderProductBrand
        {
            get { return _product_brand; }
            set { _product_brand = value; }
        }


        #endregion
        public ucItemShippingStatus()
        {
            InitializeComponent();
        }

        private void pictureBox_click_ucHistoryScreen(object sender, EventArgs e)
        {
            if (_order_status == "0")
            {
                _order_status = "3";
                labelValue_ucHistoryScreen_status.Text = "Đã hủy";
                labelValue_ucHistoryScreen_status.ForeColor = Color.DarkRed;
                pictureBox_ucHistoryScreen.Enabled = false;
                pictureBox_ucHistoryScreen.Visible = false;
            }
            DataTable dt = formMain.Instance.UserOrderedHistoryDataTable;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (dt.Rows[i]["OrderID"].ToString() == _order_id)
                {
                    dt.Rows[i]["OrderStatus"] = "3";
                }
            }
            dt.AcceptChanges();
        }

        private void labelValue_ucHistoryScreen_orderDate_Click(object sender, EventArgs e)
        {

        }
    }
}
