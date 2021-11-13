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
    public partial class ucNotificationScreen : UserControl
    {
        public ucNotificationScreen()
        {
            InitializeComponent();
        }

        private void button_click_ucNotificationScreen_backArrow(object sender, EventArgs e)
        {
            formMain.Instance.PanelContainer.Controls["uciTechScreen"].BringToFront();
            string defaultText = "Nhập sản phẩm bạn cần tìm...";
            formMain.Instance.PanelContainer.Controls["uciTechScreen"].Controls["panel_uciTechScreen_menuTopBar"].Controls["panel_uciTechScreen_searchBar"].Controls["textBox_uciTechScreen_searchBar"].Text = defaultText;
        }
    }
}
