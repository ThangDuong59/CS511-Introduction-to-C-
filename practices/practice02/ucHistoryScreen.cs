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
    public partial class ucHistoryScreen : UserControl
    {
        public ucHistoryScreen()
        {
            InitializeComponent();
        }

        private void pictureBox_click_ucHistoryScreen(object sender, EventArgs e)
        {
            DataTable dt = formMain.Instance.UserOrderedHistoryDataTable;
            if (formMain.Instance.PanelContainer.Controls.ContainsKey("ucStatisticScreen"))
            {
                ucStatisticScreen anucStatisticScreen = formMain.Instance.PanelContainer.Controls["ucStatisticScreen"] as ucStatisticScreen;
                formMain.Instance.PanelContainer.Controls.Remove(anucStatisticScreen);
            }
            ucStatisticScreen ucStatisticScreenInstance = new ucStatisticScreen();
            int total_orders = dt.Rows.Count;
            int total_price_int = 0;
            string search_success_orders_expression = "OrderStatus = '2'";
            DataRow[] found_success_rows = dt.Select(search_success_orders_expression);
            int total_success_orders = found_success_rows.Length;

            for (int i = 0; i < found_success_rows.Length; i++)
            {
                total_price_int += Convert.ToInt32(found_success_rows[i]["TotalPrice"]);
            }

            string search_cancel_orders_expression = "OrderStatus = '3'";
            DataRow[] found_cancel_rows = dt.Select(search_cancel_orders_expression);
            int total_cancel_orders = found_cancel_rows.Length;

            string search_waiting_orders_expression = "OrderStatus = '0'";
            DataRow[] found_waiting_rows = dt.Select(search_waiting_orders_expression);
            int total_waiting_orders = found_waiting_rows.Length;

            ucStatisticScreenInstance.TotalOrders = total_orders.ToString();
            ucStatisticScreenInstance.TotalSuccessOrders = total_success_orders.ToString();
            ucStatisticScreenInstance.TotalWaitingOrders = total_waiting_orders.ToString();
            ucStatisticScreenInstance.TotalCancelOrders = total_cancel_orders.ToString();
            System.Globalization.CultureInfo cul = System.Globalization.CultureInfo.GetCultureInfo("vi-VN");
            ucStatisticScreenInstance.TotalPaid = double.Parse(total_price_int.ToString()).ToString("#,###", cul.NumberFormat);
            formMain.Instance.PanelContainer.Controls.Add(ucStatisticScreenInstance);
            formMain.Instance.PanelContainer.Controls["ucStatisticScreen"].BringToFront();
        }
    }
}
