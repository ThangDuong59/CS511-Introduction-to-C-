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
    public partial class ucStatisticScreen : UserControl
    {
        #region Properties
        private string _total_orders;
        private string _total_success_orders;
        private string _total_cancel_orders;
        private string _total_waiting_orders;
        private string _total_paid;

        [Category("Custom Props")]
        public string TotalOrders
        {
            get { return _total_orders; }
            set { _total_orders = value; labelValue_ucStatisticScreen_totalOrder.Text = value; }
        }

        [Category("Custom Props")]
        public string TotalSuccessOrders
        {
            get { return _total_success_orders; }
            set { _total_success_orders = value; labelValue_ucStatisticScreen_successOrder.Text = value; }
        }

        [Category("Custom Props")]
        public string TotalCancelOrders
        {
            get { return _total_cancel_orders; }
            set { _total_cancel_orders = value; labelValue_ucStatisticScreen_cancelOrder.Text = value; }
        }

        [Category("Custom Props")]
        public string TotalWaitingOrders
        {
            get { return _total_waiting_orders; }
            set { _total_waiting_orders = value; labelValue_ucStatisticScreen_waitingOrder.Text = value; }
        }

        [Category("Custom Props")]
        public string TotalPaid
        {
            get { return _total_paid; }
            set { _total_paid = value; labelValue_ucStatisticScreen_totalPaid.Text = value; }
        }
        #endregion
        public ucStatisticScreen()
        {
            InitializeComponent();
        }

        private void panel_ucStatisticScreen_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button_click_ucStatisticScreen_backArrow(object sender, EventArgs e)
        {
            formMain.Instance.PanelContainer.Controls["ucHistoryScreen"].BringToFront();
        }
    }
}
