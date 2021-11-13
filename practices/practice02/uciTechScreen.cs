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
                string search_string = textBox_uciTechScreen_searchBar.Text.ToLower().Trim();
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

        private void populateItems()
        {
            ucSellItemUI[] listUCSellItemUIs = new ucSellItemUI[2];
            DataTable dt = formMain.Instance.ItemsListDataTable;
            if (flowLayoutPanel_uciTechScreen_youMayLikeItems.Controls.Count > 0)
            {
                flowLayoutPanel_uciTechScreen_youMayLikeItems.Controls.Clear();
            }
            for (int i = 0; i < listUCSellItemUIs.Length; i++)
            {
                Random rnd = new Random();
                int index = rnd.Next(0, dt.Rows.Count - 1);
                DataRow found_row = dt.Rows[index];
                listUCSellItemUIs[i] = new ucSellItemUI();
                listUCSellItemUIs[i].Title = found_row["ProductTitle"].ToString();

                int price = Convert.ToInt32(found_row["Price"].ToString());
                System.Globalization.CultureInfo cul = System.Globalization.CultureInfo.GetCultureInfo("vi-VN");
                listUCSellItemUIs[i].Price = double.Parse(Convert.ToString(price)).ToString("#,###", cul.NumberFormat);
                listUCSellItemUIs[i].Stars = found_row["Stars"].ToString();
                listUCSellItemUIs[i].PictureBoxImage = Image.FromFile(found_row["ImagePath"].ToString());
                listUCSellItemUIs[i].ItemName = found_row["Name"].ToString();
                listUCSellItemUIs[i].ItemCategory = found_row["ProductCategory"].ToString();
                listUCSellItemUIs[i].ItemBrand = found_row["Brand"].ToString();
                listUCSellItemUIs[i].ItemMadeIn = found_row["MadeIn"].ToString();
                listUCSellItemUIs[i].ItemTimeRestore = found_row["WarrantyPeriod"].ToString();
                flowLayoutPanel_uciTechScreen_youMayLikeItems.Controls.Add(listUCSellItemUIs[i]);
            }
        }

        private void textBox_click_uciTechScreen_searchBar(object sender, EventArgs e)
        {
            textBox_uciTechScreen_searchBar.SelectionStart = 0;
            textBox_uciTechScreen_searchBar.SelectionLength = 0;
        }

        private void textBox_textChanged_uciTechScreen_searchBar(object sender, EventArgs e)
        {
            if (textBox_uciTechScreen_searchBar.Text.Length == 0)
            {
                textBox_uciTechScreen_searchBar.SelectionStart = 0;
                textBox_uciTechScreen_searchBar.SelectionLength = 0;
            }
            else if (textBox_uciTechScreen_searchBar.Text.Substring(1, textBox_uciTechScreen_searchBar.Text.Length - 1) == "Nhập sản phẩm bạn cần tìm...")
            {
                textBox_uciTechScreen_searchBar.Text = textBox_uciTechScreen_searchBar.Text[0].ToString();
                textBox_uciTechScreen_searchBar.SelectionStart = 1;
                textBox_uciTechScreen_searchBar.SelectionLength = 0;
            }
        }

        private void button_click_uniTechScreen_notification(object sender, EventArgs e)
        {
            formMain.Instance.PanelContainer.Controls["ucNotificationScreen"].BringToFront();
        }

        private void button_click_uciTechScreen_telephoneCategory(object sender, EventArgs e)
        {
            textBox_uciTechScreen_searchBar.Text = "điện thoại";
            formMain.Instance.SearchString = textBox_uciTechScreen_searchBar.Text;
            ucSearchScreen ucSearchScreenInstance = formMain.Instance.PanelContainer.Controls["ucSearchScreen"] as ucSearchScreen;
            formMain.Instance.PanelContainer.Controls.Remove(ucSearchScreenInstance);
            ucSearchScreen ucSearchScreen = new ucSearchScreen();
            formMain.Instance.PanelContainer.Controls.Add(ucSearchScreen);
            formMain.Instance.PanelContainer.Controls["ucSearchScreen"].BringToFront();
        }

        private void button_click_uciTechScreen_pcCategory(object sender, EventArgs e)
        {
            textBox_uciTechScreen_searchBar.Text = "pc";
            formMain.Instance.SearchString = textBox_uciTechScreen_searchBar.Text;
            ucSearchScreen ucSearchScreenInstance = formMain.Instance.PanelContainer.Controls["ucSearchScreen"] as ucSearchScreen;
            formMain.Instance.PanelContainer.Controls.Remove(ucSearchScreenInstance);
            ucSearchScreen ucSearchScreen = new ucSearchScreen();
            formMain.Instance.PanelContainer.Controls.Add(ucSearchScreen);
            formMain.Instance.PanelContainer.Controls["ucSearchScreen"].BringToFront();
        }

        private void button_click_uciTechScreen_laptopCategory(object sender, EventArgs e)
        {
            textBox_uciTechScreen_searchBar.Text = "laptop";
            formMain.Instance.SearchString = textBox_uciTechScreen_searchBar.Text;
            ucSearchScreen ucSearchScreenInstance = formMain.Instance.PanelContainer.Controls["ucSearchScreen"] as ucSearchScreen;
            formMain.Instance.PanelContainer.Controls.Remove(ucSearchScreenInstance);
            ucSearchScreen ucSearchScreen = new ucSearchScreen();
            formMain.Instance.PanelContainer.Controls.Add(ucSearchScreen);
            formMain.Instance.PanelContainer.Controls["ucSearchScreen"].BringToFront();
        }

        private void button_click_uciTechScreen_tabletCateogry(object sender, EventArgs e)
        {
            textBox_uciTechScreen_searchBar.Text = "tablet";
            formMain.Instance.SearchString = textBox_uciTechScreen_searchBar.Text;
            ucSearchScreen ucSearchScreenInstance = formMain.Instance.PanelContainer.Controls["ucSearchScreen"] as ucSearchScreen;
            formMain.Instance.PanelContainer.Controls.Remove(ucSearchScreenInstance);
            ucSearchScreen ucSearchScreen = new ucSearchScreen();
            formMain.Instance.PanelContainer.Controls.Add(ucSearchScreen);
            formMain.Instance.PanelContainer.Controls["ucSearchScreen"].BringToFront();
        }

        private void button_click_uciTechScreen_headPhoneCategory(object sender, EventArgs e)
        {
            textBox_uciTechScreen_searchBar.Text = "tai nghe";
            formMain.Instance.SearchString = textBox_uciTechScreen_searchBar.Text;
            ucSearchScreen ucSearchScreenInstance = formMain.Instance.PanelContainer.Controls["ucSearchScreen"] as ucSearchScreen;
            formMain.Instance.PanelContainer.Controls.Remove(ucSearchScreenInstance);
            ucSearchScreen ucSearchScreen = new ucSearchScreen();
            formMain.Instance.PanelContainer.Controls.Add(ucSearchScreen);
            formMain.Instance.PanelContainer.Controls["ucSearchScreen"].BringToFront();
        }

        private void button_click_uciTechScreen_keyBoardCategory(object sender, EventArgs e)
        {
            textBox_uciTechScreen_searchBar.Text = "keyboard";
            formMain.Instance.SearchString = textBox_uciTechScreen_searchBar.Text;
            ucSearchScreen ucSearchScreenInstance = formMain.Instance.PanelContainer.Controls["ucSearchScreen"] as ucSearchScreen;
            formMain.Instance.PanelContainer.Controls.Remove(ucSearchScreenInstance);
            ucSearchScreen ucSearchScreen = new ucSearchScreen();
            formMain.Instance.PanelContainer.Controls.Add(ucSearchScreen);
            formMain.Instance.PanelContainer.Controls["ucSearchScreen"].BringToFront();
        }

        private void button_click_uciTechScreen_mouseCategory(object sender, EventArgs e)
        {
            textBox_uciTechScreen_searchBar.Text = "mouse";
            formMain.Instance.SearchString = textBox_uciTechScreen_searchBar.Text;
            ucSearchScreen ucSearchScreenInstance = formMain.Instance.PanelContainer.Controls["ucSearchScreen"] as ucSearchScreen;
            formMain.Instance.PanelContainer.Controls.Remove(ucSearchScreenInstance);
            ucSearchScreen ucSearchScreen = new ucSearchScreen();
            formMain.Instance.PanelContainer.Controls.Add(ucSearchScreen);
            formMain.Instance.PanelContainer.Controls["ucSearchScreen"].BringToFront();
        }

        private void button_click_uciTechScreen_speakerCategory(object sender, EventArgs e)
        {
            textBox_uciTechScreen_searchBar.Text = "speaker";
            formMain.Instance.SearchString = textBox_uciTechScreen_searchBar.Text;
            ucSearchScreen ucSearchScreenInstance = formMain.Instance.PanelContainer.Controls["ucSearchScreen"] as ucSearchScreen;
            formMain.Instance.PanelContainer.Controls.Remove(ucSearchScreenInstance);
            ucSearchScreen ucSearchScreen = new ucSearchScreen();
            formMain.Instance.PanelContainer.Controls.Add(ucSearchScreen);
            formMain.Instance.PanelContainer.Controls["ucSearchScreen"].BringToFront();
        }
    }
}
