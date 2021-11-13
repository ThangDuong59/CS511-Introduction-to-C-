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
    public partial class ucMyOrderScreen : UserControl
    {
        #region Properties
        private int _num_item_in_order = 0;
        private string _totalPrice = "0";

        [Category("Custom Props")]
        public int NumItemInOrder
        {
            get { return _num_item_in_order; }
            set { _num_item_in_order = value; }
        }


        [Category("Custom Props")]
        public string totalPrice
        {
            get { return _totalPrice; }
            set { _totalPrice = value; labelValue_ucMyOrderScreen_totalPrice.Text = value + "đ"; }
        }

        #endregion
        public ucMyOrderScreen()
        {
            InitializeComponent();
        }

        private void checkBox_checkedChanged_ucMyOrderScreen_checkAll(object sender, EventArgs e)
        {

        }

        private void button_click_ucMyOrderScreen_paying(object sender, EventArgs e)
        {
            DataTable dt = formMain.Instance.UserOrderedHistoryDataTable;
            foreach (ucOrderedItemUI ucOrderedItemInstance in flowLayoutPanel_ucMyOrderScreen.Controls)
            {
                if (ucOrderedItemInstance.CheckBoxIsBuy == true)
                {
                    _num_item_in_order -= 1;
                    int total_price = ucOrderedItemInstance.Quantity * Convert.ToInt32(ucOrderedItemInstance.Price.Replace(".", "").Replace("đ", ""));
                    int num_bought = dt.Rows.Count + 1;

                    string OrderID = "DH" + num_bought.ToString();
                    string OrderTitle = "Đơn hàng thứ " + (dt.Rows.Count + 1).ToString();
                    string OrderDate = TimeZoneInfo.ConvertTime(DateTime.Now, TimeZoneInfo.Local, TimeZoneInfo.FindSystemTimeZoneById("SE Asia Standard Time")).ToString("dd/MM/yyyy");
                    string ProductID = ucOrderedItemInstance.ProductID;
                    string ProductName = ucOrderedItemInstance.ProductName;
                    string ProductBrand = ucOrderedItemInstance.Brand;
                    string ProductPrice = ucOrderedItemInstance.Price;
                    string DiscountCode = ucOrderedItemInstance.DiscountCode;
                    string ExchangeMethod = ucOrderedItemInstance.ExchangeMethod.ToString();
                    string ProductQuantity = ucOrderedItemInstance.Quantity.ToString();
                    string TotalPrice = total_price.ToString();
                    string OrderStatus = "0";

                    dt.Rows.Add(OrderID, OrderTitle, OrderDate, ProductID, ProductName, ProductBrand, ProductPrice, DiscountCode, ExchangeMethod, ProductQuantity, TotalPrice, OrderStatus);


                    flowLayoutPanel_ucMyOrderScreen.Controls.Remove(ucOrderedItemInstance);
                    ucOrderedItemInstance.Dispose();

                }
            }
            _totalPrice = "0";
            labelValue_ucMyOrderScreen_totalPrice.Text = "0đ";       
        }

        private void pictureBox_click_ucMyOrderScreen_trash(object sender, EventArgs e)
        {
            if (flowLayoutPanel_ucMyOrderScreen.Controls.Count > 0)
            {
                flowLayoutPanel_ucMyOrderScreen.Controls.Clear();
                ucMyOrderScreen ucMyOrderScreenInstance = formMain.Instance.PanelContainer.Controls["ucMyOrderScreen"] as ucMyOrderScreen;
                ucMyOrderScreenInstance.totalPrice = "0";
            }
        }
    }
}
