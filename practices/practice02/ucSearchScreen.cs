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
    public partial class ucSearchScreen : UserControl
    {
        public ucSearchScreen()
        {
            InitializeComponent();
            populateItems("abc");
        }

        private void populateItems(string searchItemName)
        {
            ucSellItemUI[] listUCSellItemUIs = new ucSellItemUI[10];
            if (flowLayoutPanel_ucSearchScreen.Controls.Count > 0)
            {
                flowLayoutPanel_ucSearchScreen.Controls.Clear();
            }
            for (int i = 0; i < listUCSellItemUIs.Length; i++)
            {
                listUCSellItemUIs[i] = new ucSellItemUI();
                listUCSellItemUIs[i].Title = "Hello " + Convert.ToString(i);
                listUCSellItemUIs[i].Price = Convert.ToString(i * 1000);
                flowLayoutPanel_ucSearchScreen.Controls.Add(listUCSellItemUIs[i]);
            }
        }

        private void button_click_ucSearchScreen_backArrow(object sender, EventArgs e)
        {
            formMain.Instance.PanelContainer.Controls["uciTechScreen"].BringToFront();
        }
    }
}
