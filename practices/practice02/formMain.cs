using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExcelApp = Microsoft.Office.Interop.Excel;

namespace practice02
{
    public partial class formMain : Form
    {
        static formMain _obj;

        DataTable user_ordered_history_dt = new DataTable();
        DataTable items_list_dt = new DataTable();
        string search_string = "Nhập sản phẩm cần tìm...";

        DataTable initialize_datatable_items_list()
        {
            DataTable myTable = new DataTable();

            myTable.Columns.Add("ProductID", typeof(string));
            myTable.Columns.Add("ProductTitle", typeof(string));
            myTable.Columns.Add("Name", typeof(string));
            myTable.Columns.Add("ProductCategory", typeof(string));
            myTable.Columns.Add("Brand", typeof(string));
            myTable.Columns.Add("MadeIn", typeof(string));
            myTable.Columns.Add("WarrantyPeriod", typeof(string));
            myTable.Columns.Add("Stars", typeof(string));
            myTable.Columns.Add("Price", typeof(string));
            myTable.Columns.Add("isLoved", typeof(string));
            myTable.Columns.Add("ImagePath", typeof(string));

            myTable.Rows.Add("SP1", "Iphone 11 màu đỏ 512GB Chip xử lý ABC", "Iphone 11", "điện thoại", "apple", "Trung Quốc", "12 tháng", "5", "30000000", "0", @"..\..\images\smartphone\apple-iphone11-01.JPG");

            myTable.Rows.Add("SP2", "Iphone11 màu xanh 256gb", "Iphone 11", "điện thoại", "apple", "Trung Quốc", "12 tháng", "3", "20040200", "0", @"..\..\images\smartphone\apple-iphone11-02.JPG");

            myTable.Rows.Add("SP3", "Iphone 6 màu trắng 512gb", "Iphone 6", "điện thoại", "apple", "Trung Quốc", "12 tháng", "4", "30045000", "0", @"..\..\images\smartphone\apple-iphone6-03.JPG");

            myTable.Rows.Add("SP4", "Iphone 8 màu xám 256gb", "Iphone 6", "điện thoại", "apple", "Trung Quốc", "12 tháng", "5", "10000000", "0", @"..\..\images\smartphone\apple-iphone6-04.JPG");

            myTable.Rows.Add("SP5", "Iphone 8 màu đỏ 256gb", "Iphone 8", "điện thoại", "apple", "Trung Quốc", "12 tháng", "5", "10000000", "0", @"..\..\images\smartphone\apple-iphone8-05.JPG");

            myTable.Rows.Add("SP6", "Iphone 6 màu vàng 256gb", "Iphone 6", "điện thoại", "apple", "Trung Quốc", "12 tháng", "5", "10570000", "0", @"..\..\images\smartphone\apple-iphone6-07.JPG");

            myTable.Rows.Add("SP7", "Iphone 10 màu  đen 256gb", "Iphone 10", "điện thoại", "apple", "Trung Quốc", "12 tháng", "5", "10000000", "0", @"..\..\images\smartphone\apple-iphone10-08.PNG");

            myTable.Rows.Add("SP8", "Iphone 7 màu vàng 256gb", "Iphone 7", "điện thoại", "apple", "Trung Quốc", "12 tháng", "5", "16000000", "0", @"..\..\images\smartphone\apple-iphone7-09.JPG");

            myTable.Rows.Add("SP9", "huawei 10 màu tím 256gb", "huawei 10", "điện thoại", "huawei", "Trung Quốc", "12 tháng", "5", "18000000", "0", @"..\..\images\smartphone\huawei-10.JPG");

            myTable.Rows.Add("SP10", "huawei 11 màu đen 256gb", "huawei 10", "điện thoại", "huawei", "Trung Quốc", "12 tháng", "5", "1350000", "0", @"..\..\images\smartphone\huawei-11.JPG");

            myTable.Rows.Add("SP11", "huawei 11 màu xanh 256gb", "huawei 11", "điện thoại", "huawei", "Trung Quốc", "12 tháng", "5", "13000000", "0", @"..\..\images\smartphone\huawei-12.JPG");

            myTable.Rows.Add("SP12", "samsungpro 11 màu tím 256gb", "samsungpro 11", "điện thoại", "samsungpro", "Trung Quốc", "12 tháng", "5", "10000000", "0", @"..\..\images\smartphone\samsungpro-11.JPG");

            myTable.Rows.Add("SP13", "samsungnot 13 màu tím 256gb", "samsungnot 13", "điện thoại", "samsungnot", "Trung Quốc", "12 tháng", "5", "15000000", "0", @"..\..\images\smartphone\samsungnot-13.JPG");


            myTable.Rows.Add("SP14", "headphone 1 màu đen", "headphone 1", "tai nghe", "headphone 1", "Trung Quốc", "12 tháng", "5", "1540000", "0", @"..\..\images\headphone\headphone-01.JPG");

            myTable.Rows.Add("SP15", "headphone 2 màu đen", "headphone 2", "tai nghe", "headphone 2", "Trung Quốc", "12 tháng", "5", "2000000", "0", @"..\..\images\headphone\headphone-02.JPG");

            myTable.Rows.Add("SP16", "headphone 3 màu đen", "headphone 3", "tai nghe", "headphone 3", "Trung Quốc", "12 tháng", "5", "2100000", "0", @"..\..\images\headphone\headphone-03.JPG");

            myTable.Rows.Add("SP17", "headphone 4 màu đen", "headphone 4", "tai nghe", "headphone 4", "Trung Quốc", "12 tháng", "5", "2300000", "0", @"..\..\images\headphone\headphone-04.JPG");

            myTable.Rows.Add("SP18", "headphone 5 màu đen", "headphone 5", "tai nghe", "headphone 5", "Trung Quốc", "12 tháng", "5", "3500000", "0", @"..\..\images\headphone\headphone-05.JPG");

            myTable.Rows.Add("SP19", "headphone 7 màu đen", "headphone 7", "tai nghe", "headphone 5", "Trung Quốc", "12 tháng", "5", "4500000", "0", @"..\..\images\headphone\headphone-07.JPG");

            myTable.Rows.Add("SP20", "headphone 8 màu đen", "headphone 8", "tai nghe", "headphone 5", "Trung Quốc", "12 tháng", "5", "1500000", "0", @"..\..\images\headphone\headphone-08.JPG");

            myTable.Rows.Add("SP21", "headphone 9 màu đen", "headphone 9", "tai nghe", "headphone 5", "Trung Quốc", "12 tháng", "5", "1800000", "0", @"..\..\images\headphone\headphone-09.JPG");

            myTable.Rows.Add("SP22", "headphone 10 màu đen", "headphone 10", "tai nghe", "headphone 5", "Trung Quốc", "12 tháng", "5", "1504000", "0", @"..\..\images\headphone\headphone-10.JPG");

            myTable.Rows.Add("SP23", "pc 1 màu đen", "pc 1", "pc", "pc1", "Trung Quốc", "12 tháng", "5", "23000000", "0", @"..\..\images\pc\pc-01.JPG");

            myTable.Rows.Add("SP24", "pc 2 màu đen", "pc 2", "pc", "pc2", "Trung Quốc", "12 tháng", "5", "35000000", "0", @"..\..\images\pc\pc-02.PNG");

            myTable.Rows.Add("SP25", "pc 3 màu đen", "pc 3", "pc", "pc3", "Trung Quốc", "12 tháng", "5", "25000000", "0", @"..\..\images\pc\pc-03.JPG");

            myTable.Rows.Add("SP26", "pc 4 màu đen", "pc 4", "pc", "pc4", "Trung Quốc", "12 tháng", "5", "46700000", "0", @"..\..\images\pc\pc-04.JPG");

            myTable.Rows.Add("SP27", "pc 5 màu đen", "pc 5", "pc", "pc5", "Trung Quốc", "12 tháng", "5", "23000000", "0", @"..\..\images\pc\pc-05.JPG");

            myTable.Rows.Add("SP28", "pc 6 màu đen", "pc 6", "pc", "pc6", "Trung Quốc", "12 tháng", "5", "40000000", "0", @"..\..\images\pc\pc-06.JPG");

            myTable.Rows.Add("SP29", "pc 7 màu đen", "pc 7", "pc", "pc7", "Trung Quốc", "12 tháng", "5", "24000000", "0", @"..\..\images\pc\pc-07.JPG");

            myTable.Rows.Add("SP30", "pc 8 màu đen", "pc 8", "pc", "pc8", "Trung Quốc", "12 tháng", "5", "28000000", "0", @"..\..\images\pc\pc-08.JPG");

            myTable.Rows.Add("SP31", "pc 9 màu đen", "pc 9", "pc", "pc9", "Trung Quốc", "12 tháng", "5", "29000000", "0", @"..\..\images\pc\pc-09.JPG");
            

            myTable.Rows.Add("SP32", "pc 10 màu đen", "pc 10", "pc", "pc10", "Trung Quốc", "12 tháng", "5", "55000000", "0", @"..\..\images\pc\pc-10.JPG");

            myTable.Rows.Add("SP32", "pc 10 màu đen", "pc 10", "pc", "pc10", "Trung Quốc", "12 tháng", "5", "42000000", "0", @"..\..\images\pc\pc-10.JPG");

            myTable.Rows.Add("SP33", " keyboard 1 màu đen", "keyboard 1", "keyboard ", "keyboard 1", "Trung Quốc", "12 tháng", "5", "1500000", "0", @"..\..\images\keyboard\keyboard-01.JPG");

            myTable.Rows.Add("SP34", " keyboard 2 màu đen", "keyboard 2", "keyboard ", "keyboard 2", "Trung Quốc", "12 tháng", "5", "2300000", "0", @"..\..\images\keyboard\keyboard-02.JPG");

            myTable.Rows.Add("SP35", " keyboard 3 màu đen", "keyboard 3", "keyboard ", "keyboard 3", "Trung Quốc", "12 tháng", "5", "3400000", "0", @"..\..\images\keyboard\keyboard-03.PNG");

            myTable.Rows.Add("SP36", " keyboard 4 màu đen", "keyboard 4", "keyboard ", "keyboard 4", "Trung Quốc", "12 tháng", "5", "350000", "0", @"..\..\images\keyboard\keyboard-04.PNG");

            myTable.Rows.Add("SP37", " keyboard 5 màu đen", "keyboard 5", "keyboard ", "keyboard  5", "Trung Quốc", "12 tháng", "5", "340000", "0", @"..\..\images\keyboard\keyboard-05.JPG");

            myTable.Rows.Add("SP38", " keyboard 6 màu đen", "keyboard 6", "keyboard ", "keyboard 6", "Trung Quốc", "12 tháng", "5", "1440000", "0", @"..\..\images\keyboard\keyboard-06.JPG");

            myTable.Rows.Add("SP39", " keyboard 7 màu đen", "keyboard 7", "keyboard ", "keyboard 7", "Trung Quốc", "12 tháng", "5", "130000", "0", @"..\..\images\keyboard\keyboard-07.JPG");

            myTable.Rows.Add("SP40", " keyboard 8 màu đen", "keyboard 8", "keyboard ", "keyboard 8", "Trung Quốc", "12 tháng", "5", "2400000", "0", @"..\..\images\keyboard\keyboard-08.JPG");

            myTable.Rows.Add("SP41", " keyboard 9 màu đen", "keyboard 9", "keyboard ", "keyboard 9", "Trung Quốc", "12 tháng", "5", "7300000", "0", @"..\..\images\keyboard\keyboard-09.JPG");

            myTable.Rows.Add("SP42", " keyboard 10 màu đen", "keyboard 10", "keyboard ", "keyboard 10 ", "Trung Quốc", "12 tháng", "5", "4200000", "0", @"..\..\images\keyboard\keyboard-10.PNG");

            myTable.Rows.Add("SP43", " mouse 1 màu đen", "mouse 1", "mouse ", "mouse 1", "Trung Quốc", "12 tháng", "5", "3113000", "0", @"..\..\images\mouse\mouse-01.PNG");

            myTable.Rows.Add("SP44", " mouse 2 màu đen", "mouse 2", "mouse ", "mouse 2", "Trung Quốc", "12 tháng", "5", "3400000", "0", @"..\..\images\mouse\mouse-02.PNG");

            myTable.Rows.Add("SP45", " mouse 3 màu đen", "mouse 3", "mouse ", "mouse 3", "Trung Quốc", "12 tháng", "5", "1310000", "0", @"..\..\images\mouse\mouse-03.JPG");

            myTable.Rows.Add("SP47", " mouse 5 màu đen", "mouse 5", "mouse ", "mouse  5", "Trung Quốc", "12 tháng", "5", "1531400", "0", @"..\..\images\mouse\mouse-05.JPG");

            myTable.Rows.Add("SP48", " mouse 6 màu đen", "mouse 6", "mouse ", "mouse 6", "Trung Quốc", "12 tháng", "5", "1503100", "0", @"..\..\images\mouse\mouse-06.PNG");

            myTable.Rows.Add("SP49", " mouse 7 màu đen", "mouse 7", "mouse ", "mouse 7", "Trung Quốc", "12 tháng", "5", "15031000", "0", @"..\..\images\mouse\mouse-07.JPG");

            myTable.Rows.Add("SP50", " mouse 8 màu đen", "mouse 8", "mouse ", "mouse 8", "Trung Quốc", "12 tháng", "5", "153000", "0", @"..\..\images\mouse\mouse-08.JPG");

            myTable.Rows.Add("SP51", " mouse 9 màu đen", "mouse 9", "mouse ", "mouse 9", "Trung Quốc", "12 tháng", "5", "15013000", "0", @"..\..\images\mouse\mouse-09.JPG");

            myTable.Rows.Add("SP52", " mouse 10 màu đen", "mouse 10", "mouse ", "mouse 10 ", "Trung Quốc", "12 tháng", "5", "153000", "0", @"..\..\images\mouse\mouse-10.JPG");


            myTable.Rows.Add("SP53", " mouse 11 màu đen", "mouse 11", "mouse ", "mouse 11", "Trung Quốc", "12 tháng", "5", "150080", "0", @"..\..\images\mouse\mouse-11.JPG");

            myTable.Rows.Add("SP54", " mouse 12 màu đen", "mouse 12", "mouse ", "mouse 12", "Trung Quốc", "12 tháng", "5", "1509000", "0", @"..\..\images\mouse\mouse-12.JPG");

            myTable.Rows.Add("SP55", " speaker 1 màu đen", "speaker 1", "speaker ", "speaker 1", "Trung Quốc", "12 tháng", "5", "1500540", "0", @"..\..\images\speaker\speaker-01.JPG");

            myTable.Rows.Add("SP56", " speaker 2 màu đen", "speaker 2", "speaker ", "speaker 2", "Trung Quốc", "12 tháng", "5", "187000", "0", @"..\..\images\speaker\speaker-02.JPG");

            myTable.Rows.Add("SP57", " speaker 3 màu đen", "speaker 3", "speaker ", "speaker 3", "Trung Quốc", "12 tháng", "5", "197000", "0", @"..\..\images\speaker\speaker-03.JPG");

            myTable.Rows.Add("SP58", " speaker 4 màu đen", "speaker 4", "speaker ", "speaker 4", "Trung Quốc", "12 tháng", "5", "159800", "0", @"..\..\images\speaker\speaker-04.JPG");

            myTable.Rows.Add("SP59", " speaker 5 màu đen", "speaker 5", "speaker ", "speaker  5", "Trung Quốc", "12 tháng", "5", "16800", "0", @"..\..\images\speaker\speaker-05.JPG");

            myTable.Rows.Add("SP60", " speaker 6 màu đen", "speaker 6", "speaker ", "speaker 6", "Trung Quốc", "12 tháng", "5", "123000", "0", @"..\..\images\speaker\speaker-06.JPG");

            myTable.Rows.Add("SP61", " speaker 7 màu đen", "speaker 7", "speaker ", "speaker 7", "Trung Quốc", "12 tháng", "5", "650000", "0", @"..\..\images\speaker\speaker-07.JPG");

            myTable.Rows.Add("SP62", " speaker 8 màu đen", "speaker 8", "speaker ", "speaker 8", "Trung Quốc", "12 tháng", "5", "159000", "0", @"..\..\images\speaker\speaker-08.JPG");

            myTable.Rows.Add("SP63", " speaker 9 màu đen", "speaker 9", "speaker ", "speaker 9", "Trung Quốc", "12 tháng", "5", "87000", "0", @"..\..\images\speaker\speaker-09.JPG");

            myTable.Rows.Add("SP64", " tablet 1 màu đen", "tablet 1", "tablet ", "tablet 1", "Trung Quốc", "12 tháng", "5", "8787870", "0", @"..\..\images\tablet\tablet-01.JPG");

            myTable.Rows.Add("SP65", " tablet 2 màu đen", "tablet 2", "tablet ", "tablet 2", "Trung Quốc", "12 tháng", "5", "1999800", "0", @"..\..\images\tablet\tablet-02.JPG");

            myTable.Rows.Add("SP66", " tablet 3 màu đen", "tablet 3", "tablet ", "tablet 3", "Trung Quốc", "12 tháng", "5", "1509800", "0", @"..\..\images\tablet\tablet-03.PNG");

            myTable.Rows.Add("SP67", " tablet 4 màu đen", "tablet 4", "tablet ", "tablet 4", "Trung Quốc", "12 tháng", "5", "15097000", "0", @"..\..\images\tablet\tablet-04.JPG");

            myTable.Rows.Add("SP68", " tablet 5 màu đen", "tablet 5", "tablet ", "tablet  5", "Trung Quốc", "12 tháng", "5", "1989000", "0", @"..\..\images\tablet\tablet-05.JPG");

            myTable.Rows.Add("SP69", " tablet 6 màu đen", "tablet 6", "tablet ", "tablet 6", "Trung Quốc", "12 tháng", "5", "1598000", "0", @"..\..\images\tablet\tablet-06.JPG");

            myTable.Rows.Add("SP70", " tablet 7 màu đen", "tablet 7", "tablet ", "tablet 7", "Trung Quốc", "12 tháng", "5", "198000", "0", @"..\..\images\tablet\tablet-07.JPG");

            myTable.Rows.Add("SP71", " tablet 8 màu đen", "tablet 8", "tablet ", "tablet 8", "Trung Quốc", "12 tháng", "5", "159890000", "0", @"..\..\images\tablet\tablet-08.JPG");

            myTable.Rows.Add("SP72", " tablet 9 màu đen", "tablet 9", "tablet ", "tablet 9", "Trung Quốc", "12 tháng", "5", "1598000", "0", @"..\..\images\tablet\tablet-09.JPG");

            myTable.Rows.Add("SP73", " tablet 10 màu đen", "tablet 10", "tablet ", "tablet 10 ", "Trung Quốc", "12 tháng", "5", "159800", "0", @"..\..\images\tablet\tablet-10.JPG");


            myTable.Rows.Add("SP74", " tablet 11 màu đen", "tablet 11", "tablet ", "tablet 11", "Trung Quốc", "12 tháng", "5", "1509800", "0", @"..\..\images\tablet\tablet-11.JPG");


            myTable.Rows.Add("SP75", " laptop 1 màu đen", "laptop 1", "laptop ", "laptop 1", "Trung Quốc", "12 tháng", "5", "1587000", "0", @"..\..\images\laptop\laptop-01.JPG");

            myTable.Rows.Add("SP76", " laptop 2 màu đen", "laptop 2", "laptop ", "laptop 2", "Trung Quốc", "12 tháng", "5", "1508700", "0", @"..\..\images\laptop\laptop-02.JPG");

            myTable.Rows.Add("SP77", " laptop 3 màu đen", "laptop 3", "laptop ", "laptop 3", "Trung Quốc", "12 tháng", "5", "1870000", "0", @"..\..\images\laptop\laptop-03.PNG");

            myTable.Rows.Add("SP78", " laptop 4 màu đen", "laptop 4", "laptop ", "laptop 4", "Trung Quốc", "12 tháng", "5", "1508700", "0", @"..\..\images\laptop\laptop-04.PNG");

            myTable.Rows.Add("SP79", " laptop 5 màu đen", "laptop 5", "laptop ", "laptop  5", "Trung Quốc", "12 tháng", "5", "8000000", "0", @"..\..\images\laptop\laptop-05.PNG");

            myTable.Rows.Add("SP80", " laptop 6 màu đen", "laptop 6", "laptop ", "laptop 6", "Trung Quốc", "12 tháng", "5", "150800", "0", @"..\..\images\laptop\laptop-06.JPG");

            myTable.Rows.Add("SP81", " laptop 7 màu đen", "laptop 7", "laptop ", "laptop 7", "Trung Quốc", "12 tháng", "5", "800000", "0", @"..\..\images\laptop\laptop-07.JPG");

            myTable.Rows.Add("SP82", " laptop 8 màu đen", "laptop 8", "laptop ", "laptop 8", "Trung Quốc", "12 tháng", "5", "900000", "0", @"..\..\images\laptop\laptop-08.PNG");

            myTable.Rows.Add("SP83", " laptop 9 màu đen", "laptop 9", "laptop ", "laptop 9", "Trung Quốc", "12 tháng", "5", "80000", "0", @"..\..\images\laptop\laptop-09.JPG");

            myTable.Rows.Add("SP84", " laptop 10 màu đen", "laptop 10", "laptop ", "laptop 10 ", "Trung Quốc", "12 tháng", "5", "18000", "0", @"..\..\images\laptop\laptop-10.PNG");


            myTable.Rows.Add("SP85", " laptop 11 màu đen", "laptop 11", "laptop ", "laptop 11", "Trung Quốc", "12 tháng", "5", "158000", "0", @"..\..\images\laptop\laptop-11.JPG");

            myTable.Rows.Add("SP86", " laptop 12 màu đen", "laptop 12", "laptop ", "laptop 12", "Trung Quốc", "12 tháng", "5", "15000", "0", @"..\..\images\laptop\laptop-12.JPG");

            myTable.Rows.Add("SP87", " laptop 13 màu đen", "laptop 13", "laptop ", "laptop 13", "Trung Quốc", "12 tháng", "5", "150000", "0", @"..\..\images\laptop\laptop-13.PNG");

            myTable.Rows.Add("SP88", " laptop 14 màu đen", "laptop 12", "laptop ", "laptop 14", "Trung Quốc", "12 tháng", "5", "1599900", "0", @"..\..\images\laptop\laptop-14.JPG");
            

            return myTable;
        }

        //DataTable initialize_datatable_items_list()
        //{
        //    //Create COM Objects.
        //    ExcelApp.Application excelApp = new ExcelApp.Application();
        //    DataRow myNewRow;
        //    DataTable myTable = new DataTable();


        //    if (excelApp == null)
        //    {
        //        return myTable;
        //    }

        //    //
        //    ExcelApp.Workbook excelBook = excelApp.Workbooks.Open(@"D:\UIT\CS511\CS511-Introduction-to-C-Sharp\practices\practice02\data\items_list.xlsx");
        //    ExcelApp._Worksheet excelSheet = excelBook.Sheets[1];
        //    ExcelApp.Range excelRange = excelSheet.UsedRange;

        //    int rows = excelRange.Rows.Count;
        //    int cols = excelRange.Columns.Count;

        //    //Set DataTable Name and Columns Name
        //    myTable.Columns.Add("ProductID", typeof(string));
        //    myTable.Columns.Add("ProductTitle", typeof(string));
        //    myTable.Columns.Add("Name", typeof(string));
        //    myTable.Columns.Add("ProductCategory", typeof(string));
        //    myTable.Columns.Add("Brand", typeof(string));
        //    myTable.Columns.Add("MadeIn", typeof(string));
        //    myTable.Columns.Add("WarrantyPeriod", typeof(string));
        //    myTable.Columns.Add("Stars", typeof(string));
        //    myTable.Columns.Add("Price", typeof(string));
        //    myTable.Columns.Add("isLoved", typeof(string));
        //    myTable.Columns.Add("ImagePath", typeof(string));



        //    //first row using for heading, start second row for data
        //    for (int i = 2; i <= rows; i++)
        //    {
        //        myNewRow = myTable.NewRow();
        //        myNewRow["ProductID"] = excelRange.Cells[i, 1].Value2.ToString(); 
        //        myNewRow["ProductTitle"] = excelRange.Cells[i, 2].Value2.ToString(); 
        //        myNewRow["Name"] = excelRange.Cells[i, 3].Value2.ToString();
        //        myNewRow["ProductCategory"] = excelRange.Cells[i, 4].Value2.ToString();
        //        myNewRow["Brand"] = excelRange.Cells[i, 5].Value2.ToString();
        //        myNewRow["MadeIn"] = excelRange.Cells[i, 6].Value2.ToString();
        //        myNewRow["WarrantyPeriod"] = excelRange.Cells[i, 7].Value2.ToString();
        //        myNewRow["Stars"] = excelRange.Cells[i, 8].Value2.ToString();
        //        myNewRow["Price"] = excelRange.Cells[i, 9].Value2.ToString();
        //        myNewRow["isLoved"] = excelRange.Cells[i, 10].Value2.ToString();
        //        myNewRow["ImagePath"] = excelRange.Cells[i, 11].Value2.ToString();

        //        myTable.Rows.Add(myNewRow);
        //    }


        //    //after reading, relaase the excel project
        //    excelApp.Quit();
        //    System.Runtime.InteropServices.Marshal.ReleaseComObject(excelApp);

        //    return myTable;
        //}


        DataTable initialize_datatable_items_bought()
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("OrderID", typeof(string));
            dt.Columns.Add("OrderTitle", typeof(string));
            dt.Columns.Add("OrderDate", typeof(string));
            dt.Columns.Add("ProductID", typeof(string));
            dt.Columns.Add("ProductName", typeof(string));
            dt.Columns.Add("ProductBrand", typeof(string));
            dt.Columns.Add("ProductPrice", typeof(string));
            dt.Columns.Add("DiscountCode", typeof(string));
            dt.Columns.Add("ExchangeMethod", typeof(string)); // {0: COD, 1: Thanh toan online}
            dt.Columns.Add("ProductQuantity", typeof(string));
            dt.Columns.Add("TotalPrice", typeof(string));
            dt.Columns.Add("OrderStatus", typeof(string)); // {0: Chờ xác nhận, 1: Đang giao, 2: Đã giao, 3: Đã hủy}

            dt.Rows.Add("DH01", "Đơn hàng thứ 1", "24/10/2021", "SP05", "Iphone 11", "Apple", "30000000", "123ABSEA", "0", "1", "30000000", "2");
            dt.Rows.Add("DH02", "Đơn hàng thứ 2", "26/10/2021", "SP30", "Mouse X", "Mouse X", "150000", "123ABSEA", "0", "1", "150000", "0");
            dt.Rows.Add("DH03", "Đơn hàng thứ 3", "29/10/2021", "SP20", "Mouse Y", "Mouse Y", "300000", "123ABSEA", "0", "1", "300000", "2");
            dt.Rows.Add("DH04", "Đơn hàng thứ 4", "30/10/2021", "SP02", "Iphone 13", "Apple", "80000000", "123ABSEA", "0", "1", "80000000", "3");
            dt.Rows.Add("DH05", "Đơn hàng thứ 5", "30/10/2021", "SP08", "Samsung Galaxy S3", "Samsung", "7500000", "123ABSEA", "0", "1", "7500000", "2");

            return dt;
        }

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

        public string SearchString
        {
            get { return search_string; }
            set { search_string = value; }
        }

        public DataTable UserOrderedHistoryDataTable
        {
            get { return user_ordered_history_dt; }
            set { user_ordered_history_dt = value; }
        }
        public DataTable ItemsListDataTable
        {
            get { return items_list_dt; }
            set { items_list_dt = value; }
        }

        public formMain()
        {
            InitializeComponent();

            user_ordered_history_dt = initialize_datatable_items_bought();
            items_list_dt = initialize_datatable_items_list();

            _obj = this;

            uciTechScreen uciTechScreen = new uciTechScreen();
            ucMyOrderScreen ucMyOrderScreen = new ucMyOrderScreen();
            ucNotificationScreen ucNotificationScreen = new ucNotificationScreen();
            ucItemDetailScreen ucItemDetailScreen = new ucItemDetailScreen();
            ucPersonalScreen ucPersonalScreen = new ucPersonalScreen();
            ucPayingScreen ucPayingScreen = new ucPayingScreen();

            panelContainer_formMain.Controls.Add(uciTechScreen);
            panelContainer_formMain.Controls.Add(ucMyOrderScreen);
            panelContainer_formMain.Controls.Add(ucNotificationScreen);
            panelContainer_formMain.Controls.Add(ucItemDetailScreen);

            panelContainer_formMain.Controls.Add(ucPersonalScreen);
            panelContainer_formMain.Controls.Add(ucPayingScreen);

            panelContainer_formMain.Controls["uciTechScreen"].BringToFront();
        }

        private void button_click_uciTechScreen_toiTechHome(object sender, EventArgs e)
        {
            panelContainer_formMain.Controls["uciTechScreen"].BringToFront();
            PanelContainer.Controls["uciTechScreen"].Controls["panel_uciTechScreen_menuTopBar"].Controls["panel_uciTechScreen_searchBar"].Controls["textBox_uciTechScreen_searchBar"].Text = search_string;
        }

        private void button_click_uciTechScreen_toShoppingScreen(object sender, EventArgs e)
        {
            panelContainer_formMain.Controls["ucMyOrderScreen"].BringToFront();
        }

        private void button_click_uciTechScreen_toHistoryScreen(object sender, EventArgs e)
        {
            if (formMain.Instance.PanelContainer.Controls.ContainsKey("ucHistoryScreen") == true)
            {
                ucHistoryScreen anucHistoryScreenInstance = formMain.Instance.PanelContainer.Controls["ucHistoryScreen"] as ucHistoryScreen;
                formMain.Instance.PanelContainer.Controls.Remove(anucHistoryScreenInstance);
            }
            ucHistoryScreen ucHistoryScreen = new ucHistoryScreen();
            for (int i = 0; i < user_ordered_history_dt.Rows.Count; i++)
            {
                ucItemShippingStatus ucItemShippingStatusInstance = new ucItemShippingStatus();
                ucItemShippingStatusInstance.OrderID = user_ordered_history_dt.Rows[i]["OrderID"].ToString();
                ucItemShippingStatusInstance.OrderTitle = "Đơn hàng thứ " + (i + 1).ToString();
                ucItemShippingStatusInstance.OrderDate = user_ordered_history_dt.Rows[i]["OrderDate"].ToString();
                ucItemShippingStatusInstance.OrderProductID = user_ordered_history_dt.Rows[i]["ProductID"].ToString();
                ucItemShippingStatusInstance.OrderProductName = user_ordered_history_dt.Rows[i]["ProductName"].ToString();
                ucItemShippingStatusInstance.OrderProductBrand = user_ordered_history_dt.Rows[i]["ProductBrand"].ToString();
                ucItemShippingStatusInstance.OrderProductPrice = user_ordered_history_dt.Rows[i]["ProductPrice"].ToString();
                ucItemShippingStatusInstance.OrderDiscountCode = user_ordered_history_dt.Rows[i]["DiscountCode"].ToString();
                ucItemShippingStatusInstance.OrderExchangeMethod = user_ordered_history_dt.Rows[i]["ExchangeMethod"].ToString();
                ucItemShippingStatusInstance.OrderProductQuantity = user_ordered_history_dt.Rows[i]["ProductQuantity"].ToString();
                System.Globalization.CultureInfo cul = System.Globalization.CultureInfo.GetCultureInfo("vi-VN");
                ucItemShippingStatusInstance.OrderTotalPrice = double.Parse(user_ordered_history_dt.Rows[i]["TotalPrice"].ToString()).ToString("#,###", cul.NumberFormat);
                ucItemShippingStatusInstance.OrderStatus = user_ordered_history_dt.Rows[i]["OrderStatus"].ToString();
                ucHistoryScreen.Controls["flowLayoutPanel_ucHistoryScreen"].Controls.Add(ucItemShippingStatusInstance);
            }
            panelContainer_formMain.Controls.Add(ucHistoryScreen);
            panelContainer_formMain.Controls["ucHistoryScreen"].BringToFront();
        }

        private void button_click_uciTechScreen_toPersonalScreen(object sender, EventArgs e)
        {
            panelContainer_formMain.Controls["ucPersonalScreen"].BringToFront();
        }
    }
}
