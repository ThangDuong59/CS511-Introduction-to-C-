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
    public partial class uciTechScreen : UserControl
    {
        public uciTechScreen()
        {
            InitializeComponent();
            populateItems();
        }

        private void textBox_keyDown_uciTechScreen_searchBar(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!formMain.Instance.PanelContainer.Controls.ContainsKey("ucSearchScreen"))
                {
                    ucSearchScreen ucSearchScreen = new ucSearchScreen();
                    formMain.Instance.PanelContainer.Controls.Add(ucSearchScreen);
                }
                formMain.Instance.PanelContainer.Controls["ucSearchScreen"].BringToFront();
            }
        }

        private void populateItems()
        {
            ucSellItemUI[] listUCSellItemUIs = new ucSellItemUI[2];
            if (flowLayoutPanel_uciTechScreen_youMayLikeItems.Controls.Count > 0)
            {
                flowLayoutPanel_uciTechScreen_youMayLikeItems.Controls.Clear();
            }
            for (int i = 0; i < listUCSellItemUIs.Length; i++)
            {
                listUCSellItemUIs[i] = new ucSellItemUI();
                listUCSellItemUIs[i].Title = "Hello " + Convert.ToString(i);
                listUCSellItemUIs[i].Price = Convert.ToString(i * 1000);
                flowLayoutPanel_uciTechScreen_youMayLikeItems.Controls.Add(listUCSellItemUIs[i]);
            }
        }
    }
}
