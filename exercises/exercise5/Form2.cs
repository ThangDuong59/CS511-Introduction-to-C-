using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Buoi6
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            button_panelMenu_test.Enabled = false;
        }
        DataTable dt = new DataTable();
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
       
        private void button_panelImport_click_question(object sender, EventArgs e)
        {
            string pathTracNghiem = @"..\..\TracNghiem_01.txt";
            string pathDapAn = @"..\..\DapAn_01.txt";
            StreamReader stream = new StreamReader(pathTracNghiem);
            string filedata = stream.ReadToEnd();
            string[] fileDapAn = File.ReadAllLines(pathDapAn);
            richTextBox_panelImport_questions.Text = filedata.ToString();
            richTextBox_panelImport_questions.Font = new System.Drawing.Font(richTextBox_panelImport_questions.Font.Name, 16F);
            button_panelMenu_test.Enabled = true;
            dt.Rows.Clear();
            using (StreamReader fileCauHoi = new StreamReader(pathTracNghiem))
            {
                int count = 0;
                int dapAn_count = 0;
                string line;

                string question = " ";
                while ((line = fileCauHoi.ReadLine()) != null)
                {
                    if (count % 2 == 0)
                    {
                        question = line.ToString();
                    }
                    else if (count % 2 != 0)
                    {
                        string[] dapAn = line.ToString().Split("\t".ToCharArray());
                        string a = dapAn[0].ToString();
                        string b = dapAn[1].ToString();
                        string c = dapAn[2].ToString();
                        string d = dapAn[3].ToString();

                        DataRow row = dt.NewRow();
                        row["Question"] = question;
                        row["Dapan1"] = a;
                        row["Dapan2"] = b;
                        row["Dapan3"] = c;
                        row["Dapan4"] = d;
                        row["Result"] = fileDapAn[dapAn_count];
                        row["Picked"] = " ";
                        dt.Rows.Add(row);

                        dapAn_count++;
                    }
                    count++;
                }
                fileCauHoi.Close();
            }
            stream.Close();
        }

        private void button_panelImport_click_key(object sender, EventArgs e)
        {
            string path1 = @"..\..\DapAn_01.txt";
            StreamReader stream = new StreamReader(path1);
            string filedata1 = stream.ReadToEnd();
            richTextBox_panelImport_dapAn.Text = filedata1.ToString();
            richTextBox_panelImport_dapAn.Font = new System.Drawing.Font(richTextBox_panelImport_dapAn.Font.Name, 16F);
            stream.Close();
        }

        private void button_panelMenu_click_import(object sender, EventArgs e)
        {
            panelImport.Visible = true;
            panelTest.Visible = false;
            richTextBox_panelImport_questions.Text = "";
            richTextBox_panelImport_dapAn.Text = "";
        }
        string ans;
        private void button_panelMenu_click_test(object sender, EventArgs e)
        {
            panelImport.Visible = false;
            panelTest.Location = panelImport.Location;
            panelTest.Visible = true;
            label_panelTest_dapAn.Text = Convert.ToString(dt.Rows[0]["Question"]);
            radioButton_panelTest_a.Text = Convert.ToString(dt.Rows[0]["Dapan1"]);
            radioButton_panelTest_c.Text = Convert.ToString(dt.Rows[0]["Dapan2"]);
            radioButton_panelTest_b.Text = Convert.ToString(dt.Rows[0]["Dapan3"]);
            radioButton_panelTest_d.Text = Convert.ToString(dt.Rows[0]["Dapan4"]);
            label_panelTest_dapAn.Font = new System.Drawing.Font(label_panelTest_dapAn.Font.Name, 16F);

            radioButton_panelTest_a.Enabled = true;
            radioButton_panelTest_b.Enabled = true;
            radioButton_panelTest_c.Enabled = true;
            radioButton_panelTest_d.Enabled = true;
            button_panelTest_ketQua.Enabled = true;
            button_panelTest_tien.Enabled = true;
            button_panelTest_lui.Enabled = false;

            label_panelTest_true.Text = "True: 0";
            label_panelTest_false.Text = "False: 0";

            listView_panelTest_dapAn.Items.Clear();
            a = 0;
            button_panelMenu_import.Enabled = false;

            radioButton_panelTest_a.Checked = true;
            radioButton_panelTest_c.Checked = false;
            radioButton_panelTest_b.Checked = false;
            radioButton_panelTest_d.Checked = false;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            dt.Columns.Add("Question", typeof(string));
            dt.Columns.Add("Dapan1", typeof(string));
            dt.Columns.Add("Dapan2", typeof(string));
            dt.Columns.Add("Dapan3", typeof(string));
            dt.Columns.Add("Dapan4", typeof(string));
            dt.Columns.Add("Result", typeof(string));
            dt.Columns.Add("Picked", typeof(string));         
        }
        int a = 0;
        private void button_panelTest_click_tien(object sender, EventArgs e)
        {

            if (radioButton_panelTest_a.Checked == true)
            {
                ans = "A";
                dt.Rows[a]["Picked"] = ans;
            }
            else if (radioButton_panelTest_c.Checked == true)
            {
                ans = "B";
                dt.Rows[a]["Picked"] = ans;
            }
            else if (radioButton_panelTest_b.Checked == true)
            {
                ans = "C";
                dt.Rows[a]["Picked"] = ans;
            }
            else if (radioButton_panelTest_d.Checked == true)
            {
                ans = "D";
                dt.Rows[a]["Picked"] = ans;
            }
            a++;
            label_panelTest_dapAn.Text = Convert.ToString(dt.Rows[a]["Question"]);
            radioButton_panelTest_a.Text = Convert.ToString(dt.Rows[a]["Dapan1"]);
            radioButton_panelTest_c.Text = Convert.ToString(dt.Rows[a]["Dapan2"]);
            radioButton_panelTest_b.Text = Convert.ToString(dt.Rows[a]["Dapan3"]);
            radioButton_panelTest_d.Text = Convert.ToString(dt.Rows[a]["Dapan4"]);
            label_panelTest_dapAn.Font = new System.Drawing.Font(label_panelTest_dapAn.Font.Name, 16F);

            radioButton_panelTest_a.Checked = true;
            radioButton_panelTest_c.Checked = false;
            radioButton_panelTest_b.Checked = false;
            radioButton_panelTest_d.Checked = false;

            button_panelTest_lui.Enabled = true;
            if(a == 49)
            {
                button_panelTest_tien.Enabled = false;
            }
        }

        private void button_panelTest_click_lui(object sender, EventArgs e)
        {
            a--;
            label_panelTest_dapAn.Text = Convert.ToString(dt.Rows[a]["Question"]);
            radioButton_panelTest_a.Text = Convert.ToString(dt.Rows[a]["Dapan1"]);
            radioButton_panelTest_c.Text = Convert.ToString(dt.Rows[a]["Dapan2"]);
            radioButton_panelTest_b.Text = Convert.ToString(dt.Rows[a]["Dapan3"]);
            radioButton_panelTest_d.Text = Convert.ToString(dt.Rows[a]["Dapan4"]);
            label_panelTest_dapAn.Font = new System.Drawing.Font(label_panelTest_dapAn.Font.Name, 16F);
            string answer = Convert.ToString(dt.Rows[a]["Picked"]);
            if (answer == "A")
            {
                radioButton_panelTest_a.Checked = true;
                radioButton_panelTest_c.Checked = false;
                radioButton_panelTest_b.Checked = false;
                radioButton_panelTest_d.Checked = false;
            }
            else if (answer == "B")
            {
                radioButton_panelTest_a.Checked = false;
                radioButton_panelTest_c.Checked = true;
                radioButton_panelTest_b.Checked = false;
                radioButton_panelTest_d.Checked = false;
            }
            else if (answer == "C")
            {
                radioButton_panelTest_a.Checked = false;
                radioButton_panelTest_c.Checked = false;
                radioButton_panelTest_b.Checked = true;
                radioButton_panelTest_d.Checked = false;
            }
            else if (answer == "D")
            {
                radioButton_panelTest_a.Checked = false;
                radioButton_panelTest_c.Checked = false;
                radioButton_panelTest_b.Checked = false;
                radioButton_panelTest_d.Checked = true;
            }
            if (a==0)
            {
                button_panelTest_lui.Enabled = false;
            }

        }
        private void button_panelTest_click_ketQua(object sender, EventArgs e)
        {
            button_panelTest_lui.Enabled = false;
            button_panelTest_tien.Enabled = false;
            button_panelMenu_test.Enabled = false;
            button_panelMenu_import.Enabled = true;

            string t = " ";
            int tang = 1;
            int soCauDung = 0;
            int soCauSai = 0;
            listView_panelTest_dapAn.View = View.LargeIcon;
            if (radioButton_panelTest_a.Checked == true)
            {
                ans = "A";
                dt.Rows[a]["Picked"] = ans;
            }
            else if (radioButton_panelTest_c.Checked == true)
            {
                ans = "B";
                dt.Rows[a]["Picked"] = ans;
            }
            else if (radioButton_panelTest_b.Checked == true)
            {
                ans = "C";
                dt.Rows[a]["Picked"] = ans;
            }
            else if (radioButton_panelTest_d.Checked == true)
            {
                ans = "D";
                dt.Rows[a]["Picked"] = ans;
            }
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (Convert.ToString(dt.Rows[i]["Picked"]) == " ")
                {
                    continue;
                }
                else
                {
                    if (Convert.ToString(dt.Rows[i]["Picked"]) != Convert.ToString(dt.Rows[i]["Result"]))
                    {
                        t = "Q" + tang.ToString();
                        listView_panelTest_dapAn.LargeImageList = imageList1;
                        listView_panelTest_dapAn.Items.Add(t, 1);
                        tang++;
                        soCauSai++;
                    }
                    else if(Convert.ToString(dt.Rows[i]["Picked"]) == Convert.ToString(dt.Rows[i]["Result"]))
                    {
                        t = "Q" + tang.ToString();
                        listView_panelTest_dapAn.LargeImageList = imageList1;
                        listView_panelTest_dapAn.Items.Add(t, 0);
                        tang++;
                        soCauDung++;
                    }
                }
            }
            button_panelTest_ketQua.Enabled = false;
            radioButton_panelTest_a.Enabled = false;
            radioButton_panelTest_c.Enabled = false;
            radioButton_panelTest_b.Enabled = false;
            radioButton_panelTest_d.Enabled = false;

            label_panelTest_true.Text = String.Format("True: {0:d}", soCauDung);
            label_panelTest_false.Text = String.Format("False: {0:d}", soCauSai);
        }
        private void button_panelMenu_click_close(object sender, EventArgs e)
        {
            Application.Exit();            
        }

        private void pnltest_Paint(object sender, PaintEventArgs e)
        {

        }

        private void listView_panelTest_mouseClick_dapAn(object sender, MouseEventArgs e)
        {
            int index = listView_panelTest_dapAn.SelectedItems[0].Index;
            label_panelTest_dapAn.Text = Convert.ToString(dt.Rows[index]["Question"]);
            radioButton_panelTest_a.Text = Convert.ToString(dt.Rows[index]["Dapan1"]);
            radioButton_panelTest_c.Text = Convert.ToString(dt.Rows[index]["Dapan2"]);
            radioButton_panelTest_b.Text = Convert.ToString(dt.Rows[index]["Dapan3"]);
            radioButton_panelTest_d.Text = Convert.ToString(dt.Rows[index]["Dapan4"]);
            label_panelTest_dapAn.Font = new System.Drawing.Font(label_panelTest_dapAn.Font.Name, 16F);

            string answer = Convert.ToString(dt.Rows[index]["Picked"]);
            if (answer == "A")
            {
                radioButton_panelTest_a.Checked = true;
                radioButton_panelTest_c.Checked = false;
                radioButton_panelTest_b.Checked = false;
                radioButton_panelTest_d.Checked = false;
            }
            else if (answer == "B")
            {
                radioButton_panelTest_a.Checked = false;
                radioButton_panelTest_c.Checked = true;
                radioButton_panelTest_b.Checked = false;
                radioButton_panelTest_d.Checked = false;
            }
            else if (answer == "C")
            {
                radioButton_panelTest_a.Checked = false;
                radioButton_panelTest_c.Checked = false;
                radioButton_panelTest_b.Checked = true;
                radioButton_panelTest_d.Checked = false;
            }
            else if (answer == "D")
            {
                radioButton_panelTest_a.Checked = false;
                radioButton_panelTest_c.Checked = false;
                radioButton_panelTest_b.Checked = false;
                radioButton_panelTest_d.Checked = true;
            }

            radioButton_panelTest_a.Enabled = false;
            radioButton_panelTest_c.Enabled = false;
            radioButton_panelTest_b.Enabled = false;
            radioButton_panelTest_d.Enabled = false;
        }
    }
}
