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
            string search_string = formMain.Instance.SearchString;
            textBox_ucSearchScreen_searchBar.Text = formMain.Instance.SearchString;
            populateItems(search_string);
        }

        private void populateItems(string searchItemName)
        {
            DataTable dt = formMain.Instance.ItemsListDataTable;
            if (searchItemName == "điện thoại" || searchItemName == "laptop" || searchItemName == "pc" || searchItemName == "tablet" || searchItemName == "tai nghe" || searchItemName == "keyboard" || searchItemName == "mouse" || searchItemName == "speaker")
            {
                string search_expression = "ProductCategory='" + searchItemName + "'";
                DataRow[] found_rows = dt.Select(search_expression);
                int num_found_rows = found_rows.Length;
                ucSellItemUI[] listUCSellItemUIs = new ucSellItemUI[num_found_rows];
                if (flowLayoutPanel_ucSearchScreen.Controls.Count > 0)
                {
                    flowLayoutPanel_ucSearchScreen.Controls.Clear();
                }
                for (int i = 0; i < num_found_rows; i++)
                {
                    listUCSellItemUIs[i] = new ucSellItemUI();
                    listUCSellItemUIs[i].Title = found_rows[i]["ProductTitle"].ToString();

                    int price = Convert.ToInt32(found_rows[i]["Price"].ToString());
                    System.Globalization.CultureInfo cul = System.Globalization.CultureInfo.GetCultureInfo("vi-VN");
                    listUCSellItemUIs[i].Price = double.Parse(Convert.ToString(price)).ToString("#,###", cul.NumberFormat);
                    listUCSellItemUIs[i].Stars = found_rows[i]["Stars"].ToString();
                    listUCSellItemUIs[i].PictureBoxImage = Image.FromFile(@found_rows[i]["ImagePath"].ToString());
                    listUCSellItemUIs[i].ItemName = found_rows[i]["Name"].ToString();
                    listUCSellItemUIs[i].ItemCategory = found_rows[i]["ProductCategory"].ToString();
                    listUCSellItemUIs[i].ItemBrand = found_rows[i]["Brand"].ToString();
                    listUCSellItemUIs[i].ItemMadeIn = found_rows[i]["MadeIn"].ToString();
                    listUCSellItemUIs[i].ItemTimeRestore = found_rows[i]["WarrantyPeriod"].ToString();
                    flowLayoutPanel_ucSearchScreen.Controls.Add(listUCSellItemUIs[i]);
                }
            }
            else if (searchItemName == "apple" || searchItemName == "samsung" || searchItemName == "huawei")
            {
                string search_expression = "Brand='" + searchItemName + "'";
                DataRow[] found_rows = dt.Select(search_expression);
                int num_found_rows = found_rows.Length;
                ucSellItemUI[] listUCSellItemUIs = new ucSellItemUI[num_found_rows];
                if (flowLayoutPanel_ucSearchScreen.Controls.Count > 0)
                {
                    flowLayoutPanel_ucSearchScreen.Controls.Clear();
                }
                for (int i = 0; i < num_found_rows; i++)
                {
                    listUCSellItemUIs[i] = new ucSellItemUI();
                    listUCSellItemUIs[i].Title = found_rows[i]["ProductTitle"].ToString();

                    int price = Convert.ToInt32(found_rows[i]["Price"].ToString());
                    System.Globalization.CultureInfo cul = System.Globalization.CultureInfo.GetCultureInfo("vi-VN");
                    listUCSellItemUIs[i].Price = double.Parse(Convert.ToString(price)).ToString("#,###", cul.NumberFormat);
                    listUCSellItemUIs[i].Stars = found_rows[i]["Stars"].ToString();
                    listUCSellItemUIs[i].PictureBoxImage = Image.FromFile(@found_rows[i]["ImagePath"].ToString());
                    listUCSellItemUIs[i].ItemName = found_rows[i]["Name"].ToString();
                    listUCSellItemUIs[i].ItemCategory = found_rows[i]["ProductCategory"].ToString();
                    listUCSellItemUIs[i].ItemBrand = found_rows[i]["Brand"].ToString();
                    listUCSellItemUIs[i].ItemMadeIn = found_rows[i]["MadeIn"].ToString();
                    listUCSellItemUIs[i].ItemTimeRestore = found_rows[i]["WarrantyPeriod"].ToString();
                    flowLayoutPanel_ucSearchScreen.Controls.Add(listUCSellItemUIs[i]);
                }
            }
        }

        private void button_click_ucSearchScreen_backArrow(object sender, EventArgs e)
        {
            formMain.Instance.PanelContainer.Controls["uciTechScreen"].BringToFront();
            string defaultText = "Nhập sản phẩm bạn cần tìm...";
            formMain.Instance.SearchString = defaultText;
            formMain.Instance.PanelContainer.Controls["uciTechScreen"].Controls["panel_uciTechScreen_menuTopBar"].Controls["panel_uciTechScreen_searchBar"].Controls["textBox_uciTechScreen_searchBar"].Text = defaultText;
        }

        private void ucSearchScreen_Load(object sender, EventArgs e)
        {

        }

        private void button_click_ucSearchScreen_notification(object sender, EventArgs e)
        {
            formMain.Instance.PanelContainer.Controls["ucNotificationScreen"].BringToFront();
        }

        private void textBox_keyDown_ucSearchScreen_searchBar(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string search_string = textBox_ucSearchScreen_searchBar.Text.ToLower().Trim();
                if (search_string == "điện thoại" || search_string == "mobile phone" || search_string == "phone")
                {
                    search_string = "điện thoại";
                }
                else if (search_string == "tai nghe" || search_string == "headphone")
                {
                    search_string = "tai nghe";
                }
                else if (search_string == "pc" || search_string == "máy tính bàn" || search_string == "máy tính")
                {
                    search_string = "pc";
                }
                else if (search_string == "loa" || search_string == "seapker")
                {
                    search_string = "speaker";
                }
                else if (search_string == "bàn phím" || search_string == "keyboard")
                {
                    search_string = "keyboard";
                }
                else if (search_string == "chuột" || search_string == "mouse")
                {
                    search_string = "mouse";
                }
                else if (search_string == "máy tính bảng" || search_string == "tablet")
                {
                    search_string = "tablet";
                }
                else if (search_string == "máy tính xách tay")
                {
                    search_string = "laptop";
                }
                else if (search_string == "iphone" || search_string == "apple")
                {
                    search_string = "apple";
                }
                formMain.Instance.SearchString = search_string;
                ucSearchScreen ucSearchScreenInstance = formMain.Instance.PanelContainer.Controls["ucSearchScreen"] as ucSearchScreen;
                formMain.Instance.PanelContainer.Controls.Remove(ucSearchScreenInstance);
                ucSearchScreen ucSearchScreen = new ucSearchScreen();
                formMain.Instance.PanelContainer.Controls.Add(ucSearchScreen);
                formMain.Instance.PanelContainer.Controls["ucSearchScreen"].BringToFront();
            }
        }
    }
}
