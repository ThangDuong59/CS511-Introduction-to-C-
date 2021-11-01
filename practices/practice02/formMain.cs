using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practice02
{
    public partial class formMain : Form
    {
        static formMain _obj;

        public static formMain Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new formMain();
                }
                return _obj;
            }
        }

        public Panel PanelContainer
        {
            get { return panelContainer_formMain; }
            set { panelContainer_formMain = value; }
        }
        public formMain()
        {
            InitializeComponent();

            _obj = this;

            uciTechScreen uciTechScreen = new uciTechScreen();
            ucMyOrderScreen ucMyOrderScreen = new ucMyOrderScreen();
            ucSearchScreen ucSearchScreen = new ucSearchScreen();

            panelContainer_formMain.Controls.Add(uciTechScreen);
            panelContainer_formMain.Controls.Add(ucMyOrderScreen);
            panelContainer_formMain.Controls.Add(ucSearchScreen);

            panelContainer_formMain.Controls["uciTechScreen"].BringToFront();
        }

        private void button_click_uciTechScreen_toiTechHome(object sender, EventArgs e)
        {
            panelContainer_formMain.Controls["uciTechScreen"].BringToFront();
        }

        private void button_click_uciTechScreen_toShoppingScreen(object sender, EventArgs e)
        {
            panelContainer_formMain.Controls["ucMyOrderScreen"].BringToFront();
        }

        private void button_click_uciTechScreen_toHistoryScreen(object sender, EventArgs e)
        {

        }

        private void button_click_uciTechScreen_toPersonalScreen(object sender, EventArgs e)
        {

        }
    }
}
