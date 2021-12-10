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
using System.Diagnostics;
using System.Drawing.Imaging;
using System.Collections;
using System.Collections.Specialized;



namespace doAnC_Sharp_Finale
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }


        DataTable dtCar = new DataTable();
        DataTable dtInterior = new DataTable();
        DataTable dtOceans = new DataTable();
        DataTable dtMotoBike = new DataTable();
        DataTable dtForest = new DataTable();
        DataTable dtFlower = new DataTable();
        DataTable dtAll = new DataTable();
        DataTable dtSearched = new DataTable();
        DataTable dtType = new DataTable();
        DataTable dtFiltered = new DataTable();
        DataTable dtChoosen = new DataTable();
        /// <summary>
        ///IMPORTANT
        /// </summary>
        ListDictionary lstImageInfoScreenMain = new ListDictionary();

        int saveimgnumber = 0;
        private void Form1_Load(object sender, EventArgs e)
        {

            ///DataTable cho Categorized Car
            dtCar.Columns.Add("STT", typeof(string));
            dtCar.Columns.Add("Categorized", typeof(string));
            dtCar.Columns.Add("Path", typeof(string));
            dtCar.Columns.Add("Favorites", typeof(int));
            dtCar.Columns.Add("Comments", typeof(int));
            dtCar.Columns.Add("Views", typeof(int));
            dtCar.Columns.Add("Price", typeof(int));
            ///DataTable cho Categorized Interior
            dtInterior.Columns.Add("STT", typeof(string));
            dtInterior.Columns.Add("Categorized", typeof(string));
            dtInterior.Columns.Add("Path", typeof(string));
            dtInterior.Columns.Add("Favorites", typeof(int));
            dtInterior.Columns.Add("Comments", typeof(int));
            dtInterior.Columns.Add("Views", typeof(int));
            dtInterior.Columns.Add("Price", typeof(int));
            ///DataTable cho Categorized Oceans
            dtOceans.Columns.Add("STT", typeof(string));
            dtOceans.Columns.Add("Categorized", typeof(string));
            dtOceans.Columns.Add("Path", typeof(string));
            dtOceans.Columns.Add("Favorites", typeof(int));
            dtOceans.Columns.Add("Comments", typeof(int));
            dtOceans.Columns.Add("Views", typeof(int));
            dtOceans.Columns.Add("Price", typeof(int));
            ///DataTable cho Categorized MotoBike
            dtMotoBike.Columns.Add("STT", typeof(string));
            dtMotoBike.Columns.Add("Categorized", typeof(string));
            dtMotoBike.Columns.Add("Path", typeof(string));
            dtMotoBike.Columns.Add("Favorites", typeof(int));
            dtMotoBike.Columns.Add("Comments", typeof(int));
            dtMotoBike.Columns.Add("Views", typeof(int));
            dtMotoBike.Columns.Add("Price", typeof(int));
            ///DataTable cho Categorized Forest
            dtForest.Columns.Add("STT", typeof(string));
            dtForest.Columns.Add("Categorized", typeof(string));
            dtForest.Columns.Add("Path", typeof(string));
            dtForest.Columns.Add("Favorites", typeof(int));
            dtForest.Columns.Add("Comments", typeof(int));
            dtForest.Columns.Add("Views", typeof(int));
            dtForest.Columns.Add("Price", typeof(int));
            ///DataTable cho Categorized Flower
            dtFlower.Columns.Add("STT", typeof(string));
            dtFlower.Columns.Add("Categorized", typeof(string));
            dtFlower.Columns.Add("Path", typeof(string));
            dtFlower.Columns.Add("Favorites", typeof(int));
            dtFlower.Columns.Add("Comments", typeof(int));
            dtFlower.Columns.Add("Views", typeof(int));
            dtFlower.Columns.Add("Price", typeof(int));

            dtAll.Columns.Add("STT", typeof(string));
            dtAll.Columns.Add("Categorized", typeof(string));
            dtAll.Columns.Add("Path", typeof(string));
            dtAll.Columns.Add("Favorites", typeof(int));
            dtAll.Columns.Add("Comments", typeof(int));
            dtAll.Columns.Add("Views", typeof(int));
            dtAll.Columns.Add("Price", typeof(int));
            dtCar.Rows.Add("1", "CAR", @"../../UsedForResource/Car/Car_1.jpg", 141, 226, 168, 0);
            dtCar.Rows.Add("2", "CAR", @"../../UsedForResource/Car/Car_2.jpg", 59, 245, 261, 1);
            dtCar.Rows.Add("3", "CAR", @"../../UsedForResource/Car/Car_3.jpg", 11, 121, 121, 0);
            dtCar.Rows.Add("4", "CAR", @"../../UsedForResource/Car/Car_4.jpg", 185, 218, 111, 1);
            dtCar.Rows.Add("5", "CAR", @"../../UsedForResource/Car/Car_5.jpg", 125, 205, 270, 1);
            dtCar.Rows.Add("6", "CAR", @"../../UsedForResource/Car/Car_6.jpg", 120, 235, 213, 1);
            dtCar.Rows.Add("7", "CAR", @"../../UsedForResource/Car/Car_7.jpg", 195, 181, 123, 0);
            dtCar.Rows.Add("8", "CAR", @"../../UsedForResource/Car/Car_8.jpg", 166, 97, 294, 0);
            dtCar.Rows.Add("9", "CAR", @"../../UsedForResource/Car/Car_9.jpg", 70, 63, 73, 0);
            dtCar.Rows.Add("10", "CAR", @"../../UsedForResource/Car/Car_10.jpg", 108, 179, 217, 0);
            dtCar.Rows.Add("11", "CAR", @"../../UsedForResource/Car/Car_11.jpg", 118, 158, 140, 1);
            dtCar.Rows.Add("12", "CAR", @"../../UsedForResource/Car/Car_12.jpg", 94, 161, 138, 1);
            dtCar.Rows.Add("13", "CAR", @"../../UsedForResource/Car/Car_13.jpg", 48, 105, 240, 0);
            dtCar.Rows.Add("14", "CAR", @"../../UsedForResource/Car/Car_14.jpg", 144, 107, 190, 0);
            dtCar.Rows.Add("15", "CAR", @"../../UsedForResource/Car/Car_15.jpg", 55, 151, 166, 0);
            dtCar.Rows.Add("16", "CAR", @"../../UsedForResource/Car/Car_16.jpg", 45, 243, 289, 1);
            dtCar.Rows.Add("17", "CAR", @"../../UsedForResource/Car/Car_17.jpg", 63, 210, 215, 1);
            dtCar.Rows.Add("18", "CAR", @"../../UsedForResource/Car/Car_18.jpg", 187, 214, 174, 0);
            dtCar.Rows.Add("19", "CAR", @"../../UsedForResource/Car/Car_19.jpg", 69, 234, 192, 1);
            dtCar.Rows.Add("20", "CAR", @"../../UsedForResource/Car/Car_20.jpg", 111, 195, 239, 0);
            dtCar.Rows.Add("21", "CAR", @"../../UsedForResource/Car/Car_21.jpg", 171, 224, 188, 0);
            dtCar.Rows.Add("22", "CAR", @"../../UsedForResource/Car/Car_22.jpg", 39, 165, 100, 1);
            dtCar.Rows.Add("23", "CAR", @"../../UsedForResource/Car/Car_23.jpg", 159, 246, 274, 1);
            dtCar.Rows.Add("24", "CAR", @"../../UsedForResource/Car/Car_24.jpg", 41, 124, 287, 0);
            dtCar.Rows.Add("25", "CAR", @"../../UsedForResource/Car/Car_25.jpg", 25, 91, 84, 1);
            dtCar.Rows.Add("26", "CAR", @"../../UsedForResource/Car/Car_26.jpg", 16, 73, 237, 0);
            dtCar.Rows.Add("27", "CAR", @"../../UsedForResource/Car/Car_27.jpg", 29, 123, 171, 1);
            dtCar.Rows.Add("28", "CAR", @"../../UsedForResource/Car/Car_28.jpg", 183, 51, 252, 1);
            dtCar.Rows.Add("29", "CAR", @"../../UsedForResource/Car/Car_29.jpg", 123, 176, 116, 1);
            dtCar.Rows.Add("30", "CAR", @"../../UsedForResource/Car/Car_30.jpg", 92, 62, 136, 1);
            dtCar.Rows.Add("31", "CAR", @"../../UsedForResource/Car/Car_31.jpg", 190, 228, 187, 1);
            dtCar.Rows.Add("32", "CAR", @"../../UsedForResource/Car/Car_32.jpg", 155, 104, 144, 1);
            dtCar.Rows.Add("33", "CAR", @"../../UsedForResource/Car/Car_33.jpg", 74, 186, 79, 0);
            dtCar.Rows.Add("34", "CAR", @"../../UsedForResource/Car/Car_34.jpg", 15, 113, 167, 1);
            dtCar.Rows.Add("35", "CAR", @"../../UsedForResource/Car/Car_35.jpg", 130, 191, 120, 1);
            dtCar.Rows.Add("36", "CAR", @"../../UsedForResource/Car/Car_36.jpg", 132, 174, 283, 1);
            dtCar.Rows.Add("37", "CAR", @"../../UsedForResource/Car/Car_37.jpg", 177, 143, 161, 0);
            dtCar.Rows.Add("38", "CAR", @"../../UsedForResource/Car/Car_38.jpg", 143, 57, 247, 1);
            dtCar.Rows.Add("39", "CAR", @"../../UsedForResource/Car/Car_39.jpg", 149, 160, 295, 0);
            dtCar.Rows.Add("40", "CAR", @"../../UsedForResource/Car/Car_40.jpg", 164, 146, 262, 1);
            dtCar.Rows.Add("41", "CAR", @"../../UsedForResource/Car/Car_41.jpg", 100, 220, 207, 1);
            dtCar.Rows.Add("42", "CAR", @"../../UsedForResource/Car/Car_42.jpg", 197, 120, 135, 0);
            dtCar.Rows.Add("43", "CAR", @"../../UsedForResource/Car/Car_43.jpg", 32, 173, 137, 1);
            dtCar.Rows.Add("44", "CAR", @"../../UsedForResource/Car/Car_44.jpg", 12, 70, 119, 1);
            dtCar.Rows.Add("45", "CAR", @"../../UsedForResource/Car/Car_45.jpg", 98, 201, 243, 1);
            dtCar.Rows.Add("46", "CAR", @"../../UsedForResource/Car/Car_46.jpg", 154, 101, 205, 1);
            dtCar.Rows.Add("47", "CAR", @"../../UsedForResource/Car/Car_47.jpg", 112, 170, 208, 1);
            dtCar.Rows.Add("48", "CAR", @"../../UsedForResource/Car/Car_48.jpg", 93, 231, 103, 0);
            dtCar.Rows.Add("49", "CAR", @"../../UsedForResource/Car/Car_49.jpg", 170, 147, 114, 0);
            dtCar.Rows.Add("50", "CAR", @"../../UsedForResource/Car/Car_50.jpg", 196, 66, 163, 0);
            dtCar.Rows.Add("51", "CAR", @"../../UsedForResource/Car/Car_51.jpg", 176, 213, 71, 1);
            dtCar.Rows.Add("52", "CAR", @"../../UsedForResource/Car/Car_52.jpg", 22, 241, 260, 0);
            dtCar.Rows.Add("53", "CAR", @"../../UsedForResource/Car/Car_53.jpg", 104, 83, 281, 1);
            dtCar.Rows.Add("54", "CAR", @"../../UsedForResource/Car/Car_54.jpg", 194, 162, 278, 0);
            dtCar.Rows.Add("55", "CAR", @"../../UsedForResource/Car/Car_55.jpg", 113, 230, 195, 1);
            dtCar.Rows.Add("56", "CAR", @"../../UsedForResource/Car/Car_56.jpg", 44, 110, 178, 0);
            dtCar.Rows.Add("57", "CAR", @"../../UsedForResource/Car/Car_57.jpg", 129, 152, 86, 0);
            dtCar.Rows.Add("58", "CAR", @"../../UsedForResource/Car/Car_58.jpg", 20, 74, 259, 1);
            dtCar.Rows.Add("59", "CAR", @"../../UsedForResource/Car/Car_59.jpg", 28, 227, 214, 0);
            dtCar.Rows.Add("60", "CAR", @"../../UsedForResource/Car/Car_60.jpg", 101, 156, 104, 1);
            dtCar.Rows.Add("61", "CAR", @"../../UsedForResource/Car/Car_61.jpg", 75, 84, 267, 1);
            dtCar.Rows.Add("62", "CAR", @"../../UsedForResource/Car/Car_62.jpg", 54, 202, 241, 0);
            dtCar.Rows.Add("63", "CAR", @"../../UsedForResource/Car/Car_63.jpg", 88, 119, 158, 0);
            dtCar.Rows.Add("64", "CAR", @"../../UsedForResource/Car/Car_64.jpg", 34, 58, 112, 0);
            dtCar.Rows.Add("65", "CAR", @"../../UsedForResource/Car/Car_65.jpg", 184, 112, 146, 1);
            dtCar.Rows.Add("66", "CAR", @"../../UsedForResource/Car/Car_66.jpg", 106, 108, 141, 1);
            dtCar.Rows.Add("67", "CAR", @"../../UsedForResource/Car/Car_67.jpg", 158, 125, 276, 0);
            dtCar.Rows.Add("68", "CAR", @"../../UsedForResource/Car/Car_68.jpg", 119, 82, 85, 1);
            dtCar.Rows.Add("69", "CAR", @"../../UsedForResource/Car/Car_69.jpg", 78, 222, 234, 0);
            dtCar.Rows.Add("70", "CAR", @"../../UsedForResource/Car/Car_70.jpg", 116, 52, 164, 0);
            dtCar.Rows.Add("71", "CAR", @"../../UsedForResource/Car/Car_71.jpg", 82, 164, 288, 0);
            dtCar.Rows.Add("72", "CAR", @"../../UsedForResource/Car/Car_72.jpg", 172, 56, 154, 0);
            dtCar.Rows.Add("73", "CAR", @"../../UsedForResource/Car/Car_73.jpg", 91, 209, 143, 0);
            dtCar.Rows.Add("74", "CAR", @"../../UsedForResource/Car/Car_74.jpg", 156, 96, 291, 0);
            dtCar.Rows.Add("75", "CAR", @"../../UsedForResource/Car/Car_75.jpg", 162, 215, 92, 1);
            dtCar.Rows.Add("76", "CAR", @"../../UsedForResource/Car/Car_76.jpg", 189, 111, 210, 1);
            dtCar.Rows.Add("77", "CAR", @"../../UsedForResource/Car/Car_77.jpg", 56, 199, 255, 1);
            dtCar.Rows.Add("78", "CAR", @"../../UsedForResource/Car/Car_78.jpg", 165, 197, 113, 1);
            dtCar.Rows.Add("79", "CAR", @"../../UsedForResource/Car/Car_79.jpg", 26, 238, 176, 0);
            dtCar.Rows.Add("80", "CAR", @"../../UsedForResource/Car/Car_80.jpg", 10, 78, 284, 1);
            dtCar.Rows.Add("81", "CAR", @"../../UsedForResource/Car/Car_81.jpg", 103, 145, 93, 1);
            dtCar.Rows.Add("82", "CAR", @"../../UsedForResource/Car/Car_82.jpg", 50, 138, 273, 1);
            dtCar.Rows.Add("83", "CAR", @"../../UsedForResource/Car/Car_83.jpg", 24, 81, 218, 1);
            dtCar.Rows.Add("84", "CAR", @"../../UsedForResource/Car/Car_84.jpg", 76, 225, 139, 0);
            dtCar.Rows.Add("85", "CAR", @"../../UsedForResource/Car/Car_85.jpg", 179, 61, 223, 1);
            dtCar.Rows.Add("86", "CAR", @"../../UsedForResource/Car/Car_86.jpg", 161, 114, 106, 1);
            dtCar.Rows.Add("87", "CAR", @"../../UsedForResource/Car/Car_87.jpg", 124, 90, 90, 1);
            dtCar.Rows.Add("88", "CAR", @"../../UsedForResource/Car/Car_88.jpg", 199, 233, 292, 1);
            dtCar.Rows.Add("89", "CAR", @"../../UsedForResource/Car/Car_89.jpg", 23, 60, 285, 0);
            dtCar.Rows.Add("90", "CAR", @"../../UsedForResource/Car/Car_90.jpg", 198, 248, 271, 0);
            dtCar.Rows.Add("91", "CAR", @"../../UsedForResource/Car/Car_91.jpg", 134, 122, 162, 1);
            dtCar.Rows.Add("92", "CAR", @"../../UsedForResource/Car/Car_92.jpg", 49, 139, 280, 0);
            dtCar.Rows.Add("93", "CAR", @"../../UsedForResource/Car/Car_93.jpg", 30, 117, 128, 1);
            dtCar.Rows.Add("94", "CAR", @"../../UsedForResource/Car/Car_94.jpg", 81, 167, 194, 1);
            dtCar.Rows.Add("95", "CAR", @"../../UsedForResource/Car/Car_95.jpg", 151, 86, 107, 0);
            dtCar.Rows.Add("96", "CAR", @"../../UsedForResource/Car/Car_96.jpg", 186, 126, 204, 1);
            dtCar.Rows.Add("97", "CAR", @"../../UsedForResource/Car/Car_97.jpg", 139, 180, 156, 0);
            dtCar.Rows.Add("98", "CAR", @"../../UsedForResource/Car/Car_98.jpg", 43, 153, 181, 0);
            dtCar.Rows.Add("99", "CAR", @"../../UsedForResource/Car/Car_99.jpg", 14, 211, 201, 1);
            dtCar.Rows.Add("100", "CAR", @"../../UsedForResource/Car/Car_100.jpg", 192, 128, 245, 0);
            dtCar.Rows.Add("101", "CAR", @"../../UsedForResource/Car/Car_101.jpg", 140, 212, 264, 1);
            dtCar.Rows.Add("102", "CAR", @"../../UsedForResource/Car/Car_102.jpg", 97, 127, 258, 1);
            dtCar.Rows.Add("103", "CAR", @"../../UsedForResource/Car/Car_103.jpg", 18, 137, 197, 1);
            dtCar.Rows.Add("104", "CAR", @"../../UsedForResource/Car/Car_104.jpg", 174, 207, 115, 0);
            dtCar.Rows.Add("105", "CAR", @"../../UsedForResource/Car/Car_105.jpg", 83, 178, 129, 0);
            dtCar.Rows.Add("106", "CAR", @"../../UsedForResource/Car/Car_106.jpg", 163, 236, 172, 0);
            dtCar.Rows.Add("107", "CAR", @"../../UsedForResource/Car/Car_107.jpg", 145, 116, 170, 1);
            dtCar.Rows.Add("108", "CAR", @"../../UsedForResource/Car/Car_108.jpg", 193, 192, 269, 0);
            dtCar.Rows.Add("109", "CAR", @"../../UsedForResource/Car/Car_109.jpg", 137, 109, 290, 0);
            dtCar.Rows.Add("110", "CAR", @"../../UsedForResource/Car/Car_110.jpg", 37, 144, 242, 1);
            dtCar.Rows.Add("111", "CAR", @"../../UsedForResource/Car/Car_111.jpg", 109, 217, 108, 0);
            dtCar.Rows.Add("112", "CAR", @"../../UsedForResource/Car/Car_112.jpg", 126, 80, 77, 1);
            dtCar.Rows.Add("113", "CAR", @"../../UsedForResource/Car/Car_113.jpg", 33, 50, 256, 1);
            dtCar.Rows.Add("114", "CAR", @"../../UsedForResource/Car/Car_114.jpg", 47, 131, 134, 1);
            dtCar.Rows.Add("115", "CAR", @"../../UsedForResource/Car/Car_115.jpg", 58, 141, 293, 1);
            dtCar.Rows.Add("116", "CAR", @"../../UsedForResource/Car/Car_116.jpg", 64, 203, 76, 1);
            dtCar.Rows.Add("117", "CAR", @"../../UsedForResource/Car/Car_117.jpg", 147, 132, 133, 1);
            dtCar.Rows.Add("118", "CAR", @"../../UsedForResource/Car/Car_118.jpg", 13, 171, 88, 0);
            dtCar.Rows.Add("119", "CAR", @"../../UsedForResource/Car/Car_119.jpg", 148, 182, 117, 0);
            dtCar.Rows.Add("120", "CAR", @"../../UsedForResource/Car/Car_120.jpg", 72, 103, 130, 0);
            dtCar.Rows.Add("121", "CAR", @"../../UsedForResource/Car/Car_121.jpg", 84, 102, 199, 0);
            dtCar.Rows.Add("122", "CAR", @"../../UsedForResource/Car/Car_122.jpg", 19, 64, 198, 0);
            dtCar.Rows.Add("123", "CAR", @"../../UsedForResource/Car/Car_123.jpg", 67, 87, 297, 1);
            dtCar.Rows.Add("124", "CAR", @"../../UsedForResource/Car/Car_124.jpg", 79, 244, 226, 1);
            dtCar.Rows.Add("125", "CAR", @"../../UsedForResource/Car/Car_125.jpg", 60, 249, 265, 1);
            dtCar.Rows.Add("126", "CAR", @"../../UsedForResource/Car/Car_126.jpg", 153, 72, 173, 1);
            dtCar.Rows.Add("127", "CAR", @"../../UsedForResource/Car/Car_127.jpg", 150, 163, 212, 1);
            dtCar.Rows.Add("128", "CAR", @"../../UsedForResource/Car/Car_128.jpg", 107, 247, 189, 0);
            dtCar.Rows.Add("129", "CAR", @"../../UsedForResource/Car/Car_129.jpg", 52, 94, 229, 0);
            dtCar.Rows.Add("130", "CAR", @"../../UsedForResource/Car/Car_130.jpg", 73, 175, 282, 0);
            dtCar.Rows.Add("131", "CAR", @"../../UsedForResource/Car/Car_131.jpg", 65, 130, 206, 1);
            dtCar.Rows.Add("132", "CAR", @"../../UsedForResource/Car/Car_132.jpg", 77, 142, 233, 0);
            dtCar.Rows.Add("133", "CAR", @"../../UsedForResource/Car/Car_133.jpg", 53, 95, 95, 0);
            dtCar.Rows.Add("134", "CAR", @"../../UsedForResource/Car/Car_134.jpg", 17, 185, 165, 1);
            dtCar.Rows.Add("135", "CAR", @"../../UsedForResource/Car/Car_135.jpg", 35, 154, 224, 0);
            dtCar.Rows.Add("136", "CAR", @"../../UsedForResource/Car/Car_136.jpg", 122, 55, 191, 0);
            dtCar.Rows.Add("137", "CAR", @"../../UsedForResource/Car/Car_137.jpg", 71, 168, 238, 0);
            dtCar.Rows.Add("138", "CAR", @"../../UsedForResource/Car/Car_138.jpg", 86, 134, 81, 1);
            dtCar.Rows.Add("139", "CAR", @"../../UsedForResource/Car/Car_139.jpg", 21, 150, 70, 0);
            dtCar.Rows.Add("140", "CAR", @"../../UsedForResource/Car/Car_140.jpg", 57, 221, 131, 1);
            dtCar.Rows.Add("141", "CAR", @"../../UsedForResource/Car/Car_141.jpg", 80, 194, 160, 1);
            dtCar.Rows.Add("142", "CAR", @"../../UsedForResource/Car/Car_142.jpg", 87, 239, 268, 1);
            dtCar.Rows.Add("143", "CAR", @"../../UsedForResource/Car/Car_143.jpg", 175, 169, 94, 1);
            dtCar.Rows.Add("144", "CAR", @"../../UsedForResource/Car/Car_144.jpg", 110, 92, 279, 0);
            dtCar.Rows.Add("145", "CAR", @"../../UsedForResource/Car/Car_145.jpg", 133, 189, 150, 0);
            dtCar.Rows.Add("146", "CAR", @"../../UsedForResource/Car/Car_146.jpg", 167, 67, 220, 1);
            dtCar.Rows.Add("147", "CAR", @"../../UsedForResource/Car/Car_147.jpg", 168, 79, 186, 1);
            dtCar.Rows.Add("148", "CAR", @"../../UsedForResource/Car/Car_148.jpg", 96, 54, 169, 1);
            dtCar.Rows.Add("149", "CAR", @"../../UsedForResource/Car/Car_149.jpg", 40, 68, 99, 1);
            dtCar.Rows.Add("150", "CAR", @"../../UsedForResource/Car/Car_150.jpg", 152, 106, 185, 0);
            dtCar.Rows.Add("151", "CAR", @"../../UsedForResource/Car/Car_151.jpg", 46, 187, 251, 0);
            dtCar.Rows.Add("152", "CAR", @"../../UsedForResource/Car/Car_152.jpg", 142, 216, 109, 0);
            dtCar.Rows.Add("153", "CAR", @"../../UsedForResource/Car/Car_153.jpg", 117, 196, 277, 1);
            dtCar.Rows.Add("154", "CAR", @"../../UsedForResource/Car/Car_154.jpg", 99, 69, 74, 1);
            dtCar.Rows.Add("155", "CAR", @"../../UsedForResource/Car/Car_155.jpg", 128, 166, 244, 1);
            dtCar.Rows.Add("156", "CAR", @"../../UsedForResource/Car/Car_156.jpg", 61, 157, 222, 0);
            dtCar.Rows.Add("157", "CAR", @"../../UsedForResource/Car/Car_157.jpg", 181, 172, 145, 1);


            dtAll.Rows.Add("1", "CAR", @"../../UsedForResource/Car/Car_1.jpg", 141, 226, 168, 0);
            dtAll.Rows.Add("2", "CAR", @"../../UsedForResource/Car/Car_2.jpg", 59, 245, 261, 1);
            dtAll.Rows.Add("3", "CAR", @"../../UsedForResource/Car/Car_3.jpg", 11, 121, 121, 0);
            dtAll.Rows.Add("4", "CAR", @"../../UsedForResource/Car/Car_4.jpg", 185, 218, 111, 1);
            dtAll.Rows.Add("5", "CAR", @"../../UsedForResource/Car/Car_5.jpg", 125, 205, 270, 1);
            dtAll.Rows.Add("6", "CAR", @"../../UsedForResource/Car/Car_6.jpg", 120, 235, 213, 1);
            dtAll.Rows.Add("7", "CAR", @"../../UsedForResource/Car/Car_7.jpg", 195, 181, 123, 0);
            dtAll.Rows.Add("8", "CAR", @"../../UsedForResource/Car/Car_8.jpg", 166, 97, 294, 0);
            dtAll.Rows.Add("9", "CAR", @"../../UsedForResource/Car/Car_9.jpg", 70, 63, 73, 0);
            dtAll.Rows.Add("10", "CAR", @"../../UsedForResource/Car/Car_10.jpg", 108, 179, 217, 0);
            dtAll.Rows.Add("11", "CAR", @"../../UsedForResource/Car/Car_11.jpg", 118, 158, 140, 1);
            dtAll.Rows.Add("12", "CAR", @"../../UsedForResource/Car/Car_12.jpg", 94, 161, 138, 1);
            dtAll.Rows.Add("13", "CAR", @"../../UsedForResource/Car/Car_13.jpg", 48, 105, 240, 0);
            dtAll.Rows.Add("14", "CAR", @"../../UsedForResource/Car/Car_14.jpg", 144, 107, 190, 0);
            dtAll.Rows.Add("15", "CAR", @"../../UsedForResource/Car/Car_15.jpg", 55, 151, 166, 0);
            dtAll.Rows.Add("16", "CAR", @"../../UsedForResource/Car/Car_16.jpg", 45, 243, 289, 1);
            dtAll.Rows.Add("17", "CAR", @"../../UsedForResource/Car/Car_17.jpg", 63, 210, 215, 1);
            dtAll.Rows.Add("18", "CAR", @"../../UsedForResource/Car/Car_18.jpg", 187, 214, 174, 0);
            dtAll.Rows.Add("19", "CAR", @"../../UsedForResource/Car/Car_19.jpg", 69, 234, 192, 1);
            dtAll.Rows.Add("20", "CAR", @"../../UsedForResource/Car/Car_20.jpg", 111, 195, 239, 0);
            dtAll.Rows.Add("21", "CAR", @"../../UsedForResource/Car/Car_21.jpg", 171, 224, 188, 0);
            dtAll.Rows.Add("22", "CAR", @"../../UsedForResource/Car/Car_22.jpg", 39, 165, 100, 1);
            dtAll.Rows.Add("23", "CAR", @"../../UsedForResource/Car/Car_23.jpg", 159, 246, 274, 1);
            dtAll.Rows.Add("24", "CAR", @"../../UsedForResource/Car/Car_24.jpg", 41, 124, 287, 0);
            dtAll.Rows.Add("25", "CAR", @"../../UsedForResource/Car/Car_25.jpg", 25, 91, 84, 1);
            dtAll.Rows.Add("26", "CAR", @"../../UsedForResource/Car/Car_26.jpg", 16, 73, 237, 0);
            dtAll.Rows.Add("27", "CAR", @"../../UsedForResource/Car/Car_27.jpg", 29, 123, 171, 1);
            dtAll.Rows.Add("28", "CAR", @"../../UsedForResource/Car/Car_28.jpg", 183, 51, 252, 1);
            dtAll.Rows.Add("29", "CAR", @"../../UsedForResource/Car/Car_29.jpg", 123, 176, 116, 1);
            dtAll.Rows.Add("30", "CAR", @"../../UsedForResource/Car/Car_30.jpg", 92, 62, 136, 1);
            dtAll.Rows.Add("31", "CAR", @"../../UsedForResource/Car/Car_31.jpg", 190, 228, 187, 1);
            dtAll.Rows.Add("32", "CAR", @"../../UsedForResource/Car/Car_32.jpg", 155, 104, 144, 1);
            dtAll.Rows.Add("33", "CAR", @"../../UsedForResource/Car/Car_33.jpg", 74, 186, 79, 0);
            dtAll.Rows.Add("34", "CAR", @"../../UsedForResource/Car/Car_34.jpg", 15, 113, 167, 1);
            dtAll.Rows.Add("35", "CAR", @"../../UsedForResource/Car/Car_35.jpg", 130, 191, 120, 1);
            dtAll.Rows.Add("36", "CAR", @"../../UsedForResource/Car/Car_36.jpg", 132, 174, 283, 1);
            dtAll.Rows.Add("37", "CAR", @"../../UsedForResource/Car/Car_37.jpg", 177, 143, 161, 0);
            dtAll.Rows.Add("38", "CAR", @"../../UsedForResource/Car/Car_38.jpg", 143, 57, 247, 1);
            dtAll.Rows.Add("39", "CAR", @"../../UsedForResource/Car/Car_39.jpg", 149, 160, 295, 0);
            dtAll.Rows.Add("40", "CAR", @"../../UsedForResource/Car/Car_40.jpg", 164, 146, 262, 1);
            dtAll.Rows.Add("41", "CAR", @"../../UsedForResource/Car/Car_41.jpg", 100, 220, 207, 1);
            dtAll.Rows.Add("42", "CAR", @"../../UsedForResource/Car/Car_42.jpg", 197, 120, 135, 0);
            dtAll.Rows.Add("43", "CAR", @"../../UsedForResource/Car/Car_43.jpg", 32, 173, 137, 1);
            dtAll.Rows.Add("44", "CAR", @"../../UsedForResource/Car/Car_44.jpg", 12, 70, 119, 1);
            dtAll.Rows.Add("45", "CAR", @"../../UsedForResource/Car/Car_45.jpg", 98, 201, 243, 1);
            dtAll.Rows.Add("46", "CAR", @"../../UsedForResource/Car/Car_46.jpg", 154, 101, 205, 1);
            dtAll.Rows.Add("47", "CAR", @"../../UsedForResource/Car/Car_47.jpg", 112, 170, 208, 1);
            dtAll.Rows.Add("48", "CAR", @"../../UsedForResource/Car/Car_48.jpg", 93, 231, 103, 0);
            dtAll.Rows.Add("49", "CAR", @"../../UsedForResource/Car/Car_49.jpg", 170, 147, 114, 0);
            dtAll.Rows.Add("50", "CAR", @"../../UsedForResource/Car/Car_50.jpg", 196, 66, 163, 0);
            dtAll.Rows.Add("51", "CAR", @"../../UsedForResource/Car/Car_51.jpg", 176, 213, 71, 1);
            dtAll.Rows.Add("52", "CAR", @"../../UsedForResource/Car/Car_52.jpg", 22, 241, 260, 0);
            dtAll.Rows.Add("53", "CAR", @"../../UsedForResource/Car/Car_53.jpg", 104, 83, 281, 1);
            dtAll.Rows.Add("54", "CAR", @"../../UsedForResource/Car/Car_54.jpg", 194, 162, 278, 0);
            dtAll.Rows.Add("55", "CAR", @"../../UsedForResource/Car/Car_55.jpg", 113, 230, 195, 1);
            dtAll.Rows.Add("56", "CAR", @"../../UsedForResource/Car/Car_56.jpg", 44, 110, 178, 0);
            dtAll.Rows.Add("57", "CAR", @"../../UsedForResource/Car/Car_57.jpg", 129, 152, 86, 0);
            dtAll.Rows.Add("58", "CAR", @"../../UsedForResource/Car/Car_58.jpg", 20, 74, 259, 1);
            dtAll.Rows.Add("59", "CAR", @"../../UsedForResource/Car/Car_59.jpg", 28, 227, 214, 0);
            dtAll.Rows.Add("60", "CAR", @"../../UsedForResource/Car/Car_60.jpg", 101, 156, 104, 1);
            dtAll.Rows.Add("61", "CAR", @"../../UsedForResource/Car/Car_61.jpg", 75, 84, 267, 1);
            dtAll.Rows.Add("62", "CAR", @"../../UsedForResource/Car/Car_62.jpg", 54, 202, 241, 0);
            dtAll.Rows.Add("63", "CAR", @"../../UsedForResource/Car/Car_63.jpg", 88, 119, 158, 0);
            dtAll.Rows.Add("64", "CAR", @"../../UsedForResource/Car/Car_64.jpg", 34, 58, 112, 0);
            dtAll.Rows.Add("65", "CAR", @"../../UsedForResource/Car/Car_65.jpg", 184, 112, 146, 1);
            dtAll.Rows.Add("66", "CAR", @"../../UsedForResource/Car/Car_66.jpg", 106, 108, 141, 1);
            dtAll.Rows.Add("67", "CAR", @"../../UsedForResource/Car/Car_67.jpg", 158, 125, 276, 0);
            dtAll.Rows.Add("68", "CAR", @"../../UsedForResource/Car/Car_68.jpg", 119, 82, 85, 1);
            dtAll.Rows.Add("69", "CAR", @"../../UsedForResource/Car/Car_69.jpg", 78, 222, 234, 0);
            dtAll.Rows.Add("70", "CAR", @"../../UsedForResource/Car/Car_70.jpg", 116, 52, 164, 0);
            dtAll.Rows.Add("71", "CAR", @"../../UsedForResource/Car/Car_71.jpg", 82, 164, 288, 0);
            dtAll.Rows.Add("72", "CAR", @"../../UsedForResource/Car/Car_72.jpg", 172, 56, 154, 0);
            dtAll.Rows.Add("73", "CAR", @"../../UsedForResource/Car/Car_73.jpg", 91, 209, 143, 0);
            dtAll.Rows.Add("74", "CAR", @"../../UsedForResource/Car/Car_74.jpg", 156, 96, 291, 0);
            dtAll.Rows.Add("75", "CAR", @"../../UsedForResource/Car/Car_75.jpg", 162, 215, 92, 1);
            dtAll.Rows.Add("76", "CAR", @"../../UsedForResource/Car/Car_76.jpg", 189, 111, 210, 1);
            dtAll.Rows.Add("77", "CAR", @"../../UsedForResource/Car/Car_77.jpg", 56, 199, 255, 1);
            dtAll.Rows.Add("78", "CAR", @"../../UsedForResource/Car/Car_78.jpg", 165, 197, 113, 1);
            dtAll.Rows.Add("79", "CAR", @"../../UsedForResource/Car/Car_79.jpg", 26, 238, 176, 0);
            dtAll.Rows.Add("80", "CAR", @"../../UsedForResource/Car/Car_80.jpg", 10, 78, 284, 1);
            dtAll.Rows.Add("81", "CAR", @"../../UsedForResource/Car/Car_81.jpg", 103, 145, 93, 1);
            dtAll.Rows.Add("82", "CAR", @"../../UsedForResource/Car/Car_82.jpg", 50, 138, 273, 1);
            dtAll.Rows.Add("83", "CAR", @"../../UsedForResource/Car/Car_83.jpg", 24, 81, 218, 1);
            dtAll.Rows.Add("84", "CAR", @"../../UsedForResource/Car/Car_84.jpg", 76, 225, 139, 0);
            dtAll.Rows.Add("85", "CAR", @"../../UsedForResource/Car/Car_85.jpg", 179, 61, 223, 1);
            dtAll.Rows.Add("86", "CAR", @"../../UsedForResource/Car/Car_86.jpg", 161, 114, 106, 1);
            dtAll.Rows.Add("87", "CAR", @"../../UsedForResource/Car/Car_87.jpg", 124, 90, 90, 1);
            dtAll.Rows.Add("88", "CAR", @"../../UsedForResource/Car/Car_88.jpg", 199, 233, 292, 1);
            dtAll.Rows.Add("89", "CAR", @"../../UsedForResource/Car/Car_89.jpg", 23, 60, 285, 0);
            dtAll.Rows.Add("90", "CAR", @"../../UsedForResource/Car/Car_90.jpg", 198, 248, 271, 0);
            dtAll.Rows.Add("91", "CAR", @"../../UsedForResource/Car/Car_91.jpg", 134, 122, 162, 1);
            dtAll.Rows.Add("92", "CAR", @"../../UsedForResource/Car/Car_92.jpg", 49, 139, 280, 0);
            dtAll.Rows.Add("93", "CAR", @"../../UsedForResource/Car/Car_93.jpg", 30, 117, 128, 1);
            dtAll.Rows.Add("94", "CAR", @"../../UsedForResource/Car/Car_94.jpg", 81, 167, 194, 1);
            dtAll.Rows.Add("95", "CAR", @"../../UsedForResource/Car/Car_95.jpg", 151, 86, 107, 0);
            dtAll.Rows.Add("96", "CAR", @"../../UsedForResource/Car/Car_96.jpg", 186, 126, 204, 1);
            dtAll.Rows.Add("97", "CAR", @"../../UsedForResource/Car/Car_97.jpg", 139, 180, 156, 0);
            dtAll.Rows.Add("98", "CAR", @"../../UsedForResource/Car/Car_98.jpg", 43, 153, 181, 0);
            dtAll.Rows.Add("99", "CAR", @"../../UsedForResource/Car/Car_99.jpg", 14, 211, 201, 1);
            dtAll.Rows.Add("100", "CAR", @"../../UsedForResource/Car/Car_100.jpg", 192, 128, 245, 0);
            dtAll.Rows.Add("101", "CAR", @"../../UsedForResource/Car/Car_101.jpg", 140, 212, 264, 1);
            dtAll.Rows.Add("102", "CAR", @"../../UsedForResource/Car/Car_102.jpg", 97, 127, 258, 1);
            dtAll.Rows.Add("103", "CAR", @"../../UsedForResource/Car/Car_103.jpg", 18, 137, 197, 1);
            dtAll.Rows.Add("104", "CAR", @"../../UsedForResource/Car/Car_104.jpg", 174, 207, 115, 0);
            dtAll.Rows.Add("105", "CAR", @"../../UsedForResource/Car/Car_105.jpg", 83, 178, 129, 0);
            dtAll.Rows.Add("106", "CAR", @"../../UsedForResource/Car/Car_106.jpg", 163, 236, 172, 0);
            dtAll.Rows.Add("107", "CAR", @"../../UsedForResource/Car/Car_107.jpg", 145, 116, 170, 1);
            dtAll.Rows.Add("108", "CAR", @"../../UsedForResource/Car/Car_108.jpg", 193, 192, 269, 0);
            dtAll.Rows.Add("109", "CAR", @"../../UsedForResource/Car/Car_109.jpg", 137, 109, 290, 0);
            dtAll.Rows.Add("110", "CAR", @"../../UsedForResource/Car/Car_110.jpg", 37, 144, 242, 1);
            dtAll.Rows.Add("111", "CAR", @"../../UsedForResource/Car/Car_111.jpg", 109, 217, 108, 0);
            dtAll.Rows.Add("112", "CAR", @"../../UsedForResource/Car/Car_112.jpg", 126, 80, 77, 1);
            dtAll.Rows.Add("113", "CAR", @"../../UsedForResource/Car/Car_113.jpg", 33, 50, 256, 1);
            dtAll.Rows.Add("114", "CAR", @"../../UsedForResource/Car/Car_114.jpg", 47, 131, 134, 1);
            dtAll.Rows.Add("115", "CAR", @"../../UsedForResource/Car/Car_115.jpg", 58, 141, 293, 1);
            dtAll.Rows.Add("116", "CAR", @"../../UsedForResource/Car/Car_116.jpg", 64, 203, 76, 1);
            dtAll.Rows.Add("117", "CAR", @"../../UsedForResource/Car/Car_117.jpg", 147, 132, 133, 1);
            dtAll.Rows.Add("118", "CAR", @"../../UsedForResource/Car/Car_118.jpg", 13, 171, 88, 0);
            dtAll.Rows.Add("119", "CAR", @"../../UsedForResource/Car/Car_119.jpg", 148, 182, 117, 0);
            dtAll.Rows.Add("120", "CAR", @"../../UsedForResource/Car/Car_120.jpg", 72, 103, 130, 0);
            dtAll.Rows.Add("121", "CAR", @"../../UsedForResource/Car/Car_121.jpg", 84, 102, 199, 0);
            dtAll.Rows.Add("122", "CAR", @"../../UsedForResource/Car/Car_122.jpg", 19, 64, 198, 0);
            dtAll.Rows.Add("123", "CAR", @"../../UsedForResource/Car/Car_123.jpg", 67, 87, 297, 1);
            dtAll.Rows.Add("124", "CAR", @"../../UsedForResource/Car/Car_124.jpg", 79, 244, 226, 1);
            dtAll.Rows.Add("125", "CAR", @"../../UsedForResource/Car/Car_125.jpg", 60, 249, 265, 1);
            dtAll.Rows.Add("126", "CAR", @"../../UsedForResource/Car/Car_126.jpg", 153, 72, 173, 1);
            dtAll.Rows.Add("127", "CAR", @"../../UsedForResource/Car/Car_127.jpg", 150, 163, 212, 1);
            dtAll.Rows.Add("128", "CAR", @"../../UsedForResource/Car/Car_128.jpg", 107, 247, 189, 0);
            dtAll.Rows.Add("129", "CAR", @"../../UsedForResource/Car/Car_129.jpg", 52, 94, 229, 0);
            dtAll.Rows.Add("130", "CAR", @"../../UsedForResource/Car/Car_130.jpg", 73, 175, 282, 0);
            dtAll.Rows.Add("131", "CAR", @"../../UsedForResource/Car/Car_131.jpg", 65, 130, 206, 1);
            dtAll.Rows.Add("132", "CAR", @"../../UsedForResource/Car/Car_132.jpg", 77, 142, 233, 0);
            dtAll.Rows.Add("133", "CAR", @"../../UsedForResource/Car/Car_133.jpg", 53, 95, 95, 0);
            dtAll.Rows.Add("134", "CAR", @"../../UsedForResource/Car/Car_134.jpg", 17, 185, 165, 1);
            dtAll.Rows.Add("135", "CAR", @"../../UsedForResource/Car/Car_135.jpg", 35, 154, 224, 0);
            dtAll.Rows.Add("136", "CAR", @"../../UsedForResource/Car/Car_136.jpg", 122, 55, 191, 0);
            dtAll.Rows.Add("137", "CAR", @"../../UsedForResource/Car/Car_137.jpg", 71, 168, 238, 0);
            dtAll.Rows.Add("138", "CAR", @"../../UsedForResource/Car/Car_138.jpg", 86, 134, 81, 1);
            dtAll.Rows.Add("139", "CAR", @"../../UsedForResource/Car/Car_139.jpg", 21, 150, 70, 0);
            dtAll.Rows.Add("140", "CAR", @"../../UsedForResource/Car/Car_140.jpg", 57, 221, 131, 1);
            dtAll.Rows.Add("141", "CAR", @"../../UsedForResource/Car/Car_141.jpg", 80, 194, 160, 1);
            dtAll.Rows.Add("142", "CAR", @"../../UsedForResource/Car/Car_142.jpg", 87, 239, 268, 1);
            dtAll.Rows.Add("143", "CAR", @"../../UsedForResource/Car/Car_143.jpg", 175, 169, 94, 1);
            dtAll.Rows.Add("144", "CAR", @"../../UsedForResource/Car/Car_144.jpg", 110, 92, 279, 0);
            dtAll.Rows.Add("145", "CAR", @"../../UsedForResource/Car/Car_145.jpg", 133, 189, 150, 0);
            dtAll.Rows.Add("146", "CAR", @"../../UsedForResource/Car/Car_146.jpg", 167, 67, 220, 1);
            dtAll.Rows.Add("147", "CAR", @"../../UsedForResource/Car/Car_147.jpg", 168, 79, 186, 1);
            dtAll.Rows.Add("148", "CAR", @"../../UsedForResource/Car/Car_148.jpg", 96, 54, 169, 1);
            dtAll.Rows.Add("149", "CAR", @"../../UsedForResource/Car/Car_149.jpg", 40, 68, 99, 1);
            dtAll.Rows.Add("150", "CAR", @"../../UsedForResource/Car/Car_150.jpg", 152, 106, 185, 0);
            dtAll.Rows.Add("151", "CAR", @"../../UsedForResource/Car/Car_151.jpg", 46, 187, 251, 0);
            dtAll.Rows.Add("152", "CAR", @"../../UsedForResource/Car/Car_152.jpg", 142, 216, 109, 0);
            dtAll.Rows.Add("153", "CAR", @"../../UsedForResource/Car/Car_153.jpg", 117, 196, 277, 1);
            dtAll.Rows.Add("154", "CAR", @"../../UsedForResource/Car/Car_154.jpg", 99, 69, 74, 1);
            dtAll.Rows.Add("155", "CAR", @"../../UsedForResource/Car/Car_155.jpg", 128, 166, 244, 1);
            dtAll.Rows.Add("156", "CAR", @"../../UsedForResource/Car/Car_156.jpg", 61, 157, 222, 0);
            dtAll.Rows.Add("157", "CAR", @"../../UsedForResource/Car/Car_157.jpg", 181, 172, 145, 1);
            dtAll.Rows.Add("158", "INTERIOR", @"../../UsedForResource/Interior/Interior_1.jpg", 114, 181, 280, 0);
            dtAll.Rows.Add("159", "INTERIOR", @"../../UsedForResource/Interior/Interior_2.jpg", 118, 282, 130, 0);
            dtAll.Rows.Add("160", "INTERIOR", @"../../UsedForResource/Interior/Interior_3.jpg", 161, 171, 178, 1);
            dtAll.Rows.Add("161", "INTERIOR", @"../../UsedForResource/Interior/Interior_4.jpg", 78, 130, 284, 0);
            dtAll.Rows.Add("162", "INTERIOR", @"../../UsedForResource/Interior/Interior_5.jpg", 236, 87, 129, 1);
            dtAll.Rows.Add("163", "INTERIOR", @"../../UsedForResource/Interior/Interior_6.jpg", 49, 99, 68, 0);
            dtAll.Rows.Add("164", "INTERIOR", @"../../UsedForResource/Interior/Interior_7.jpg", 126, 262, 267, 0);
            dtAll.Rows.Add("165", "INTERIOR", @"../../UsedForResource/Interior/Interior_8.jpg", 101, 72, 64, 1);
            dtAll.Rows.Add("166", "INTERIOR", @"../../UsedForResource/Interior/Interior_9.jpg", 211, 280, 65, 1);
            dtAll.Rows.Add("167", "INTERIOR", @"../../UsedForResource/Interior/Interior_10.jpg", 68, 169, 253, 1);
            dtAll.Rows.Add("168", "INTERIOR", @"../../UsedForResource/Interior/Interior_11.jpg", 219, 270, 238, 0);
            dtAll.Rows.Add("169", "INTERIOR", @"../../UsedForResource/Interior/Interior_12.jpg", 62, 195, 61, 0);
            dtAll.Rows.Add("170", "INTERIOR", @"../../UsedForResource/Interior/Interior_13.jpg", 129, 278, 275, 1);
            dtAll.Rows.Add("171", "INTERIOR", @"../../UsedForResource/Interior/Interior_14.jpg", 218, 133, 63, 1);
            dtAll.Rows.Add("172", "INTERIOR", @"../../UsedForResource/Interior/Interior_15.jpg", 156, 190, 209, 1);
            dtAll.Rows.Add("173", "INTERIOR", @"../../UsedForResource/Interior/Interior_16.jpg", 58, 269, 105, 0);
            dtAll.Rows.Add("174", "INTERIOR", @"../../UsedForResource/Interior/Interior_17.jpg", 109, 253, 247, 1);
            dtAll.Rows.Add("175", "INTERIOR", @"../../UsedForResource/Interior/Interior_18.jpg", 182, 273, 184, 0);
            dtAll.Rows.Add("176", "INTERIOR", @"../../UsedForResource/Interior/Interior_19.jpg", 117, 158, 98, 1);
            dtAll.Rows.Add("177", "INTERIOR", @"../../UsedForResource/Interior/Interior_20.jpg", 137, 107, 97, 1);
            dtAll.Rows.Add("178", "INTERIOR", @"../../UsedForResource/Interior/Interior_21.jpg", 133, 229, 136, 1);
            dtAll.Rows.Add("179", "INTERIOR", @"../../UsedForResource/Interior/Interior_22.jpg", 190, 96, 214, 0);
            dtAll.Rows.Add("180", "INTERIOR", @"../../UsedForResource/Interior/Interior_23.jpg", 204, 86, 251, 0);
            dtAll.Rows.Add("181", "INTERIOR", @"../../UsedForResource/Interior/Interior_24.jpg", 104, 124, 202, 0);
            dtAll.Rows.Add("182", "INTERIOR", @"../../UsedForResource/Interior/Interior_25.jpg", 107, 70, 221, 1);
            dtAll.Rows.Add("183", "INTERIOR", @"../../UsedForResource/Interior/Interior_26.jpg", 206, 74, 123, 1);
            dtAll.Rows.Add("184", "INTERIOR", @"../../UsedForResource/Interior/Interior_27.jpg", 265, 63, 278, 1);
            dtAll.Rows.Add("185", "INTERIOR", @"../../UsedForResource/Interior/Interior_28.jpg", 217, 128, 274, 1);
            dtAll.Rows.Add("186", "INTERIOR", @"../../UsedForResource/Interior/Interior_29.jpg", 208, 125, 268, 0);
            dtAll.Rows.Add("187", "INTERIOR", @"../../UsedForResource/Interior/Interior_30.jpg", 92, 196, 74, 0);
            dtAll.Rows.Add("188", "INTERIOR", @"../../UsedForResource/Interior/Interior_31.jpg", 96, 147, 179, 1);
            dtAll.Rows.Add("189", "INTERIOR", @"../../UsedForResource/Interior/Interior_32.jpg", 155, 161, 120, 1);
            dtAll.Rows.Add("190", "INTERIOR", @"../../UsedForResource/Interior/Interior_33.jpg", 268, 143, 246, 1);
            dtAll.Rows.Add("191", "INTERIOR", @"../../UsedForResource/Interior/Interior_34.jpg", 139, 140, 82, 1);
            dtAll.Rows.Add("192", "INTERIOR", @"../../UsedForResource/Interior/Interior_35.jpg", 150, 193, 222, 1);
            dtAll.Rows.Add("193", "INTERIOR", @"../../UsedForResource/Interior/Interior_36.jpg", 207, 226, 223, 0);
            dtAll.Rows.Add("194", "INTERIOR", @"../../UsedForResource/Interior/Interior_37.jpg", 216, 127, 144, 1);
            dtAll.Rows.Add("195", "INTERIOR", @"../../UsedForResource/Interior/Interior_38.jpg", 84, 100, 269, 1);
            dtAll.Rows.Add("196", "INTERIOR", @"../../UsedForResource/Interior/Interior_39.jpg", 239, 299, 174, 0);
            dtAll.Rows.Add("197", "INTERIOR", @"../../UsedForResource/Interior/Interior_40.jpg", 235, 219, 72, 0);
            dtAll.Rows.Add("198", "INTERIOR", @"../../UsedForResource/Interior/Interior_41.jpg", 192, 134, 141, 1);
            dtAll.Rows.Add("199", "INTERIOR", @"../../UsedForResource/Interior/Interior_42.jpg", 61, 129, 106, 0);
            dtAll.Rows.Add("200", "INTERIOR", @"../../UsedForResource/Interior/Interior_43.jpg", 82, 105, 96, 1);
            dtAll.Rows.Add("201", "INTERIOR", @"../../UsedForResource/Interior/Interior_44.jpg", 136, 62, 263, 1);
            dtAll.Rows.Add("202", "INTERIOR", @"../../UsedForResource/Interior/Interior_45.jpg", 229, 88, 54, 0);
            dtAll.Rows.Add("203", "INTERIOR", @"../../UsedForResource/Interior/Interior_46.jpg", 97, 183, 99, 1);
            dtAll.Rows.Add("204", "INTERIOR", @"../../UsedForResource/Interior/Interior_47.jpg", 149, 218, 85, 0);
            dtAll.Rows.Add("205", "INTERIOR", @"../../UsedForResource/Interior/Interior_48.jpg", 140, 259, 160, 0);
            dtAll.Rows.Add("206", "INTERIOR", @"../../UsedForResource/Interior/Interior_49.jpg", 64, 230, 88, 1);
            dtAll.Rows.Add("207", "INTERIOR", @"../../UsedForResource/Interior/Interior_50.jpg", 128, 263, 197, 0);
            dtAll.Rows.Add("208", "INTERIOR", @"../../UsedForResource/Interior/Interior_51.jpg", 143, 155, 66, 0);
            dtAll.Rows.Add("209", "INTERIOR", @"../../UsedForResource/Interior/Interior_52.jpg", 106, 201, 175, 0);
            dtAll.Rows.Add("210", "INTERIOR", @"../../UsedForResource/Interior/Interior_53.jpg", 212, 266, 67, 1);
            dtAll.Rows.Add("211", "INTERIOR", @"../../UsedForResource/Interior/Interior_54.jpg", 200, 255, 211, 1);
            dtAll.Rows.Add("212", "INTERIOR", @"../../UsedForResource/Interior/Interior_55.jpg", 170, 178, 112, 0);
            dtAll.Rows.Add("213", "INTERIOR", @"../../UsedForResource/Interior/Interior_56.jpg", 171, 296, 273, 0);
            dtAll.Rows.Add("214", "INTERIOR", @"../../UsedForResource/Interior/Interior_57.jpg", 154, 98, 264, 0);
            dtAll.Rows.Add("215", "INTERIOR", @"../../UsedForResource/Interior/Interior_58.jpg", 103, 60, 143, 1);
            dtAll.Rows.Add("216", "INTERIOR", @"../../UsedForResource/Interior/Interior_59.jpg", 210, 148, 148, 0);
            dtAll.Rows.Add("217", "INTERIOR", @"../../UsedForResource/Interior/Interior_60.jpg", 199, 137, 117, 0);
            dtAll.Rows.Add("218", "INTERIOR", @"../../UsedForResource/Interior/Interior_61.jpg", 247, 245, 216, 1);
            dtAll.Rows.Add("219", "INTERIOR", @"../../UsedForResource/Interior/Interior_62.jpg", 45, 113, 282, 1);
            dtAll.Rows.Add("220", "INTERIOR", @"../../UsedForResource/Interior/Interior_63.jpg", 43, 223, 256, 0);
            dtAll.Rows.Add("221", "INTERIOR", @"../../UsedForResource/Interior/Interior_64.jpg", 37, 274, 177, 1);
            dtAll.Rows.Add("222", "INTERIOR", @"../../UsedForResource/Interior/Interior_65.jpg", 98, 164, 71, 0);
            dtAll.Rows.Add("223", "INTERIOR", @"../../UsedForResource/Interior/Interior_66.jpg", 81, 233, 205, 1);
            dtAll.Rows.Add("224", "INTERIOR", @"../../UsedForResource/Interior/Interior_67.jpg", 166, 123, 185, 0);
            dtAll.Rows.Add("225", "INTERIOR", @"../../UsedForResource/Interior/Interior_68.jpg", 70, 154, 138, 0);
            dtAll.Rows.Add("226", "INTERIOR", @"../../UsedForResource/Interior/Interior_69.jpg", 231, 132, 128, 0);
            dtAll.Rows.Add("227", "INTERIOR", @"../../UsedForResource/Interior/Interior_70.jpg", 65, 150, 257, 0);
            dtAll.Rows.Add("228", "INTERIOR", @"../../UsedForResource/Interior/Interior_71.jpg", 120, 254, 121, 1);
            dtAll.Rows.Add("229", "INTERIOR", @"../../UsedForResource/Interior/Interior_72.jpg", 245, 152, 146, 0);
            dtAll.Rows.Add("230", "INTERIOR", @"../../UsedForResource/Interior/Interior_73.jpg", 145, 71, 133, 0);
            dtAll.Rows.Add("231", "INTERIOR", @"../../UsedForResource/Interior/Interior_74.jpg", 176, 206, 86, 1);
            dtAll.Rows.Add("232", "INTERIOR", @"../../UsedForResource/Interior/Interior_75.jpg", 263, 281, 265, 0);
            dtAll.Rows.Add("233", "INTERIOR", @"../../UsedForResource/Interior/Interior_76.jpg", 60, 119, 287, 1);
            dtAll.Rows.Add("234", "INTERIOR", @"../../UsedForResource/Interior/Interior_77.jpg", 241, 200, 145, 0);
            dtAll.Rows.Add("235", "INTERIOR", @"../../UsedForResource/Interior/Interior_78.jpg", 34, 101, 169, 0);
            dtAll.Rows.Add("236", "INTERIOR", @"../../UsedForResource/Interior/Interior_79.jpg", 110, 115, 183, 1);
            dtAll.Rows.Add("237", "INTERIOR", @"../../UsedForResource/Interior/Interior_80.jpg", 69, 209, 207, 1);
            dtAll.Rows.Add("238", "INTERIOR", @"../../UsedForResource/Interior/Interior_81.jpg", 76, 122, 81, 1);
            dtAll.Rows.Add("239", "INTERIOR", @"../../UsedForResource/Interior/Interior_82.jpg", 159, 260, 163, 1);
            dtAll.Rows.Add("240", "INTERIOR", @"../../UsedForResource/Interior/Interior_83.jpg", 202, 108, 272, 1);
            dtAll.Rows.Add("241", "INTERIOR", @"../../UsedForResource/Interior/Interior_84.jpg", 260, 207, 276, 1);
            dtAll.Rows.Add("242", "INTERIOR", @"../../UsedForResource/Interior/Interior_85.jpg", 113, 67, 241, 1);
            dtAll.Rows.Add("243", "INTERIOR", @"../../UsedForResource/Interior/Interior_86.jpg", 196, 157, 193, 1);
            dtAll.Rows.Add("244", "INTERIOR", @"../../UsedForResource/Interior/Interior_87.jpg", 59, 85, 219, 1);
            dtAll.Rows.Add("245", "INTERIOR", @"../../UsedForResource/Interior/Interior_88.jpg", 33, 180, 89, 0);
            dtAll.Rows.Add("246", "INTERIOR", @"../../UsedForResource/Interior/Interior_89.jpg", 179, 141, 108, 0);
            dtAll.Rows.Add("247", "INTERIOR", @"../../UsedForResource/Interior/Interior_90.jpg", 35, 283, 215, 0);
            dtAll.Rows.Add("248", "INTERIOR", @"../../UsedForResource/Interior/Interior_91.jpg", 250, 222, 261, 1);
            dtAll.Rows.Add("249", "INTERIOR", @"../../UsedForResource/Interior/Interior_92.jpg", 83, 272, 232, 0);
            dtAll.Rows.Add("250", "INTERIOR", @"../../UsedForResource/Interior/Interior_93.jpg", 209, 251, 244, 1);
            dtAll.Rows.Add("251", "INTERIOR", @"../../UsedForResource/Interior/Interior_94.jpg", 151, 90, 208, 0);
            dtAll.Rows.Add("252", "INTERIOR", @"../../UsedForResource/Interior/Interior_95.jpg", 164, 173, 94, 1);
            dtAll.Rows.Add("253", "INTERIOR", @"../../UsedForResource/Interior/Interior_96.jpg", 222, 243, 153, 1);
            dtAll.Rows.Add("254", "INTERIOR", @"../../UsedForResource/Interior/Interior_97.jpg", 48, 172, 188, 0);
            dtAll.Rows.Add("255", "INTERIOR", @"../../UsedForResource/Interior/Interior_98.jpg", 38, 198, 289, 0);
            dtAll.Rows.Add("256", "INTERIOR", @"../../UsedForResource/Interior/Interior_99.jpg", 238, 61, 76, 1);
            dtAll.Rows.Add("257", "INTERIOR", @"../../UsedForResource/Interior/Interior_100.jpg", 79, 83, 137, 0);
            dtAll.Rows.Add("258", "INTERIOR", @"../../UsedForResource/Interior/Interior_101.jpg", 36, 256, 277, 1);
            dtAll.Rows.Add("259", "INTERIOR", @"../../UsedForResource/Interior/Interior_102.jpg", 50, 225, 239, 0);
            dtAll.Rows.Add("260", "INTERIOR", @"../../UsedForResource/Interior/Interior_103.jpg", 187, 139, 189, 1);
            dtAll.Rows.Add("261", "INTERIOR", @"../../UsedForResource/Interior/Interior_104.jpg", 74, 279, 286, 1);
            dtAll.Rows.Add("262", "INTERIOR", @"../../UsedForResource/Interior/Interior_105.jpg", 100, 192, 220, 0);
            dtAll.Rows.Add("263", "INTERIOR", @"../../UsedForResource/Interior/Interior_106.jpg", 142, 217, 91, 1);
            dtAll.Rows.Add("264", "INTERIOR", @"../../UsedForResource/Interior/Interior_107.jpg", 116, 69, 180, 1);
            dtAll.Rows.Add("265", "INTERIOR", @"../../UsedForResource/Interior/Interior_108.jpg", 230, 168, 237, 0);
            dtAll.Rows.Add("266", "INTERIOR", @"../../UsedForResource/Interior/Interior_109.jpg", 225, 276, 107, 0);
            dtAll.Rows.Add("267", "INTERIOR", @"../../UsedForResource/Interior/Interior_110.jpg", 31, 145, 248, 0);
            dtAll.Rows.Add("268", "INTERIOR", @"../../UsedForResource/Interior/Interior_111.jpg", 148, 126, 186, 1);
            dtAll.Rows.Add("269", "INTERIOR", @"../../UsedForResource/Interior/Interior_112.jpg", 226, 293, 240, 0);
            dtAll.Rows.Add("270", "INTERIOR", @"../../UsedForResource/Interior/Interior_113.jpg", 119, 257, 70, 0);
            dtAll.Rows.Add("271", "INTERIOR", @"../../UsedForResource/Interior/Interior_114.jpg", 255, 146, 242, 1);
            dtAll.Rows.Add("272", "INTERIOR", @"../../UsedForResource/Interior/Interior_115.jpg", 141, 117, 161, 0);
            dtAll.Rows.Add("273", "INTERIOR", @"../../UsedForResource/Interior/Interior_116.jpg", 244, 104, 172, 1);
            dtAll.Rows.Add("274", "INTERIOR", @"../../UsedForResource/Interior/Interior_117.jpg", 257, 138, 225, 1);
            dtAll.Rows.Add("275", "INTERIOR", @"../../UsedForResource/Interior/Interior_118.jpg", 175, 292, 118, 0);
            dtAll.Rows.Add("276", "INTERIOR", @"../../UsedForResource/Interior/Interior_119.jpg", 91, 290, 229, 0);
            dtAll.Rows.Add("277", "INTERIOR", @"../../UsedForResource/Interior/Interior_120.jpg", 191, 252, 127, 0);
            dtAll.Rows.Add("278", "INTERIOR", @"../../UsedForResource/Interior/Interior_121.jpg", 189, 236, 134, 1);
            dtAll.Rows.Add("279", "INTERIOR", @"../../UsedForResource/Interior/Interior_122.jpg", 41, 194, 164, 0);
            dtAll.Rows.Add("280", "INTERIOR", @"../../UsedForResource/Interior/Interior_123.jpg", 146, 81, 217, 1);
            dtAll.Rows.Add("281", "INTERIOR", @"../../UsedForResource/Interior/Interior_124.jpg", 66, 149, 260, 0);
            dtAll.Rows.Add("282", "INTERIOR", @"../../UsedForResource/Interior/Interior_125.jpg", 264, 216, 194, 0);
            dtAll.Rows.Add("283", "INTERIOR", @"../../UsedForResource/Interior/Interior_126.jpg", 125, 277, 190, 0);
            dtAll.Rows.Add("284", "INTERIOR", @"../../UsedForResource/Interior/Interior_127.jpg", 40, 118, 139, 0);
            dtAll.Rows.Add("285", "INTERIOR", @"../../UsedForResource/Interior/Interior_128.jpg", 123, 114, 113, 0);
            dtAll.Rows.Add("286", "INTERIOR", @"../../UsedForResource/Interior/Interior_129.jpg", 261, 93, 57, 0);
            dtAll.Rows.Add("287", "INTERIOR", @"../../UsedForResource/Interior/Interior_130.jpg", 249, 220, 258, 1);
            dtAll.Rows.Add("288", "INTERIOR", @"../../UsedForResource/Interior/Interior_131.jpg", 163, 92, 176, 0);
            dtAll.Rows.Add("289", "INTERIOR", @"../../UsedForResource/Interior/Interior_132.jpg", 201, 77, 114, 1);
            dtAll.Rows.Add("290", "INTERIOR", @"../../UsedForResource/Interior/Interior_133.jpg", 131, 160, 233, 0);
            dtAll.Rows.Add("291", "INTERIOR", @"../../UsedForResource/Interior/Interior_134.jpg", 138, 165, 116, 0);
            dtAll.Rows.Add("292", "INTERIOR", @"../../UsedForResource/Interior/Interior_135.jpg", 197, 135, 157, 1);
            dtAll.Rows.Add("293", "INTERIOR", @"../../UsedForResource/Interior/Interior_136.jpg", 240, 112, 115, 0);
            dtAll.Rows.Add("294", "INTERIOR", @"../../UsedForResource/Interior/Interior_137.jpg", 254, 234, 191, 1);
            dtAll.Rows.Add("295", "INTERIOR", @"../../UsedForResource/Interior/Interior_138.jpg", 233, 64, 150, 1);
            dtAll.Rows.Add("296", "INTERIOR", @"../../UsedForResource/Interior/Interior_139.jpg", 89, 78, 111, 1);
            dtAll.Rows.Add("297", "INTERIOR", @"../../UsedForResource/Interior/Interior_140.jpg", 258, 166, 167, 1);
            dtAll.Rows.Add("298", "INTERIOR", @"../../UsedForResource/Interior/Interior_141.jpg", 39, 182, 90, 1);
            dtAll.Rows.Add("299", "INTERIOR", @"../../UsedForResource/Interior/Interior_142.jpg", 184, 231, 84, 0);
            dtAll.Rows.Add("300", "INTERIOR", @"../../UsedForResource/Interior/Interior_143.jpg", 124, 295, 200, 0);
            dtAll.Rows.Add("301", "INTERIOR", @"../../UsedForResource/Interior/Interior_144.jpg", 198, 97, 181, 0);
            dtAll.Rows.Add("302", "INTERIOR", @"../../UsedForResource/Interior/Interior_145.jpg", 203, 116, 122, 0);
            dtAll.Rows.Add("303", "INTERIOR", @"../../UsedForResource/Interior/Interior_146.jpg", 162, 271, 119, 0);
            dtAll.Rows.Add("304", "INTERIOR", @"../../UsedForResource/Interior/Interior_147.jpg", 165, 249, 271, 1);
            dtAll.Rows.Add("305", "INTERIOR", @"../../UsedForResource/Interior/Interior_148.jpg", 259, 95, 173, 0);
            dtAll.Rows.Add("306", "INTERIOR", @"../../UsedForResource/Interior/Interior_149.jpg", 167, 240, 135, 1);
            dtAll.Rows.Add("307", "INTERIOR", @"../../UsedForResource/Interior/Interior_150.jpg", 44, 106, 142, 0);
            dtAll.Rows.Add("308", "INTERIOR", @"../../UsedForResource/Interior/Interior_151.jpg", 122, 298, 83, 0);
            dtAll.Rows.Add("309", "INTERIOR", @"../../UsedForResource/Interior/Interior_152.jpg", 86, 144, 92, 0);
            dtAll.Rows.Add("310", "INTERIOR", @"../../UsedForResource/Interior/Interior_153.jpg", 42, 241, 195, 0);
            dtAll.Rows.Add("311", "INTERIOR", @"../../UsedForResource/Interior/Interior_154.jpg", 223, 204, 109, 0);
            dtAll.Rows.Add("312", "INTERIOR", @"../../UsedForResource/Interior/Interior_155.jpg", 232, 176, 198, 1);
            dtAll.Rows.Add("313", "INTERIOR", @"../../UsedForResource/Interior/Interior_156.jpg", 53, 258, 196, 1);
            dtAll.Rows.Add("314", "INTERIOR", @"../../UsedForResource/Interior/Interior_157.jpg", 243, 197, 60, 0);
            dtAll.Rows.Add("315", "INTERIOR", @"../../UsedForResource/Interior/Interior_158.jpg", 105, 238, 103, 1);
            dtAll.Rows.Add("316", "INTERIOR", @"../../UsedForResource/Interior/Interior_159.jpg", 147, 247, 165, 0);
            dtAll.Rows.Add("317", "INTERIOR", @"../../UsedForResource/Interior/Interior_160.jpg", 73, 242, 95, 1);
            dtAll.Rows.Add("318", "INTERIOR", @"../../UsedForResource/Interior/Interior_161.jpg", 194, 76, 140, 0);
            dtAll.Rows.Add("319", "INTERIOR", @"../../UsedForResource/Interior/Interior_162.jpg", 242, 73, 279, 1);
            dtAll.Rows.Add("320", "INTERIOR", @"../../UsedForResource/Interior/Interior_163.jpg", 32, 213, 224, 1);
            dtAll.Rows.Add("321", "INTERIOR", @"../../UsedForResource/Interior/Interior_164.jpg", 47, 103, 218, 1);
            dtAll.Rows.Add("322", "INTERIOR", @"../../UsedForResource/Interior/Interior_165.jpg", 71, 120, 87, 1);
            dtAll.Rows.Add("323", "INTERIOR", @"../../UsedForResource/Interior/Interior_166.jpg", 112, 208, 228, 0);
            dtAll.Rows.Add("324", "INTERIOR", @"../../UsedForResource/Interior/Interior_167.jpg", 158, 82, 210, 1);
            dtAll.Rows.Add("325", "INTERIOR", @"../../UsedForResource/Interior/Interior_168.jpg", 121, 68, 100, 0);
            dtAll.Rows.Add("326", "INTERIOR", @"../../UsedForResource/Interior/Interior_169.jpg", 95, 185, 59, 1);
            dtAll.Rows.Add("327", "INTERIOR", @"../../UsedForResource/Interior/Interior_170.jpg", 172, 237, 56, 1);
            dtAll.Rows.Add("328", "INTERIOR", @"../../UsedForResource/Interior/Interior_171.jpg", 134, 212, 132, 0);
            dtAll.Rows.Add("329", "INTERIOR", @"../../UsedForResource/Interior/Interior_172.jpg", 55, 202, 75, 1);
            dtAll.Rows.Add("330", "INTERIOR", @"../../UsedForResource/Interior/Interior_173.jpg", 63, 66, 158, 0);
            dtAll.Rows.Add("331", "INTERIOR", @"../../UsedForResource/Interior/Interior_174.jpg", 67, 232, 152, 1);
            dtAll.Rows.Add("332", "INTERIOR", @"../../UsedForResource/Interior/Interior_175.jpg", 262, 187, 69, 0);
            dtAll.Rows.Add("333", "INTERIOR", @"../../UsedForResource/Interior/Interior_176.jpg", 248, 121, 262, 1);
            dtAll.Rows.Add("334", "INTERIOR", @"../../UsedForResource/Interior/Interior_177.jpg", 215, 188, 155, 1);
            dtAll.Rows.Add("335", "INTERIOR", @"../../UsedForResource/Interior/Interior_178.jpg", 266, 170, 147, 0);
            dtAll.Rows.Add("336", "INTERIOR", @"../../UsedForResource/Interior/Interior_179.jpg", 77, 94, 187, 1);
            dtAll.Rows.Add("337", "INTERIOR", @"../../UsedForResource/Interior/Interior_180.jpg", 152, 275, 170, 1);
            dtAll.Rows.Add("338", "INTERIOR", @"../../UsedForResource/Interior/Interior_181.jpg", 75, 267, 203, 0);
            dtAll.Rows.Add("339", "INTERIOR", @"../../UsedForResource/Interior/Interior_182.jpg", 56, 156, 73, 0);
            dtAll.Rows.Add("340", "INTERIOR", @"../../UsedForResource/Interior/Interior_183.jpg", 54, 268, 199, 0);
            dtAll.Rows.Add("341", "INTERIOR", @"../../UsedForResource/Interior/Interior_184.jpg", 99, 75, 231, 0);
            dtAll.Rows.Add("342", "INTERIOR", @"../../UsedForResource/Interior/Interior_185.jpg", 102, 111, 77, 0);
            dtAll.Rows.Add("343", "INTERIOR", @"../../UsedForResource/Interior/Interior_186.jpg", 51, 221, 226, 0);
            dtAll.Rows.Add("344", "INTERIOR", @"../../UsedForResource/Interior/Interior_187.jpg", 193, 162, 110, 0);
            dtAll.Rows.Add("345", "INTERIOR", @"../../UsedForResource/Interior/Interior_188.jpg", 115, 191, 255, 0);
            dtAll.Rows.Add("346", "INTERIOR", @"../../UsedForResource/Interior/Interior_189.jpg", 224, 199, 236, 1);
            dtAll.Rows.Add("347", "INTERIOR", @"../../UsedForResource/Interior/Interior_190.jpg", 214, 91, 283, 1);
            dtAll.Rows.Add("348", "INTERIOR", @"../../UsedForResource/Interior/Interior_191.jpg", 111, 214, 281, 0);
            dtAll.Rows.Add("349", "INTERIOR", @"../../UsedForResource/Interior/Interior_192.jpg", 195, 177, 234, 0);
            dtAll.Rows.Add("350", "INTERIOR", @"../../UsedForResource/Interior/Interior_193.jpg", 228, 102, 201, 0);
            dtAll.Rows.Add("351", "INTERIOR", @"../../UsedForResource/Interior/Interior_194.jpg", 153, 65, 245, 0);
            dtAll.Rows.Add("352", "INTERIOR", @"../../UsedForResource/Interior/Interior_195.jpg", 127, 291, 182, 1);
            dtAll.Rows.Add("353", "INTERIOR", @"../../UsedForResource/Interior/Interior_196.jpg", 220, 205, 250, 0);
            dtAll.Rows.Add("354", "INTERIOR", @"../../UsedForResource/Interior/Interior_197.jpg", 252, 89, 288, 0);
            dtAll.Rows.Add("355", "INTERIOR", @"../../UsedForResource/Interior/Interior_198.jpg", 251, 159, 213, 1);
            dtAll.Rows.Add("356", "INTERIOR", @"../../UsedForResource/Interior/Interior_199.jpg", 221, 131, 252, 0);
            dtAll.Rows.Add("357", "INTERIOR", @"../../UsedForResource/Interior/Interior_200.jpg", 181, 248, 166, 0);
            dtAll.Rows.Add("358", "INTERIOR", @"../../UsedForResource/Interior/Interior_201.jpg", 234, 244, 168, 0);
            dtAll.Rows.Add("359", "INTERIOR", @"../../UsedForResource/Interior/Interior_202.jpg", 186, 228, 102, 1);
            dtAll.Rows.Add("360", "INTERIOR", @"../../UsedForResource/Interior/Interior_203.jpg", 269, 250, 259, 0);
            dtAll.Rows.Add("361", "INTERIOR", @"../../UsedForResource/Interior/Interior_204.jpg", 227, 264, 192, 0);
            dtAll.Rows.Add("362", "INTERIOR", @"../../UsedForResource/Interior/Interior_205.jpg", 205, 215, 156, 0);
            dtAll.Rows.Add("363", "INTERIOR", @"../../UsedForResource/Interior/Interior_206.jpg", 80, 151, 230, 0);
            dtAll.Rows.Add("364", "INTERIOR", @"../../UsedForResource/Interior/Interior_207.jpg", 246, 110, 53, 0);
            dtAll.Rows.Add("365", "INTERIOR", @"../../UsedForResource/Interior/Interior_208.jpg", 88, 167, 254, 1);
            dtAll.Rows.Add("366", "INTERIOR", @"../../UsedForResource/Interior/Interior_209.jpg", 267, 175, 206, 1);
            dtAll.Rows.Add("367", "INTERIOR", @"../../UsedForResource/Interior/Interior_210.jpg", 144, 136, 62, 1);
            dtAll.Rows.Add("368", "INTERIOR", @"../../UsedForResource/Interior/Interior_211.jpg", 169, 289, 151, 0);
            dtAll.Rows.Add("369", "INTERIOR", @"../../UsedForResource/Interior/Interior_212.jpg", 46, 203, 80, 0);
            dtAll.Rows.Add("370", "INTERIOR", @"../../UsedForResource/Interior/Interior_213.jpg", 177, 184, 78, 1);
            dtAll.Rows.Add("371", "INTERIOR", @"../../UsedForResource/Interior/Interior_214.jpg", 135, 109, 204, 0);
            dtAll.Rows.Add("372", "INTERIOR", @"../../UsedForResource/Interior/Interior_215.jpg", 174, 265, 235, 1);
            dtAll.Rows.Add("373", "INTERIOR", @"../../UsedForResource/Interior/Interior_216.jpg", 93, 189, 285, 1);
            dtAll.Rows.Add("374", "INTERIOR", @"../../UsedForResource/Interior/Interior_217.jpg", 52, 286, 58, 0);
            dtAll.Rows.Add("375", "INTERIOR", @"../../UsedForResource/Interior/Interior_218.jpg", 168, 261, 79, 1);
            dtAll.Rows.Add("376", "INTERIOR", @"../../UsedForResource/Interior/Interior_219.jpg", 213, 142, 212, 1);
            dtAll.Rows.Add("377", "INTERIOR", @"../../UsedForResource/Interior/Interior_220.jpg", 57, 284, 101, 0);
            dtAll.Rows.Add("378", "INTERIOR", @"../../UsedForResource/Interior/Interior_221.jpg", 30, 186, 131, 0);
            dtAll.Rows.Add("379", "INTERIOR", @"../../UsedForResource/Interior/Interior_222.jpg", 87, 287, 93, 0);
            dtAll.Rows.Add("380", "INTERIOR", @"../../UsedForResource/Interior/Interior_223.jpg", 180, 153, 162, 1);
            dtAll.Rows.Add("381", "INTERIOR", @"../../UsedForResource/Interior/Interior_224.jpg", 108, 179, 243, 1);
            dtAll.Rows.Add("382", "INTERIOR", @"../../UsedForResource/Interior/Interior_225.jpg", 183, 235, 126, 0);
            dtAll.Rows.Add("383", "INTERIOR", @"../../UsedForResource/Interior/Interior_226.jpg", 173, 297, 227, 1);
            dtAll.Rows.Add("384", "INTERIOR", @"../../UsedForResource/Interior/Interior_227.jpg", 157, 210, 270, 1);
            dtAll.Rows.Add("385", "INTERIOR", @"../../UsedForResource/Interior/Interior_228.jpg", 132, 211, 266, 0);
            dtAll.Rows.Add("386", "INTERIOR", @"../../UsedForResource/Interior/Interior_229.jpg", 85, 80, 171, 0);
            dtAll.Rows.Add("387", "OCEANS", @"../../UsedForResource/Ocean/Ocean_1.jpg", 45, 95, 142, 1);
            dtAll.Rows.Add("388", "OCEANS", @"../../UsedForResource/Ocean/Ocean_2.jpg", 182, 279, 274, 1);
            dtAll.Rows.Add("389", "OCEANS", @"../../UsedForResource/Ocean/Ocean_3.jpg", 60, 292, 122, 0);
            dtAll.Rows.Add("390", "OCEANS", @"../../UsedForResource/Ocean/Ocean_4.jpg", 252, 328, 280, 0);
            dtAll.Rows.Add("391", "OCEANS", @"../../UsedForResource/Ocean/Ocean_5.jpg", 139, 160, 184, 1);
            dtAll.Rows.Add("392", "OCEANS", @"../../UsedForResource/Ocean/Ocean_6.jpg", 27, 232, 104, 0);
            dtAll.Rows.Add("393", "OCEANS", @"../../UsedForResource/Ocean/Ocean_7.jpg", 219, 338, 102, 1);
            dtAll.Rows.Add("394", "OCEANS", @"../../UsedForResource/Ocean/Ocean_8.jpg", 59, 174, 279, 1);
            dtAll.Rows.Add("395", "OCEANS", @"../../UsedForResource/Ocean/Ocean_9.jpg", 208, 192, 82, 1);
            dtAll.Rows.Add("396", "OCEANS", @"../../UsedForResource/Ocean/Ocean_10.jpg", 216, 252, 213, 1);
            dtAll.Rows.Add("397", "OCEANS", @"../../UsedForResource/Ocean/Ocean_11.jpg", 93, 180, 232, 1);
            dtAll.Rows.Add("398", "OCEANS", @"../../UsedForResource/Ocean/Ocean_12.jpg", 88, 199, 243, 0);
            dtAll.Rows.Add("399", "OCEANS", @"../../UsedForResource/Ocean/Ocean_13.jpg", 162, 134, 106, 1);
            dtAll.Rows.Add("400", "OCEANS", @"../../UsedForResource/Ocean/Ocean_14.jpg", 239, 209, 246, 1);
            dtAll.Rows.Add("401", "OCEANS", @"../../UsedForResource/Ocean/Ocean_15.jpg", 48, 124, 234, 0);
            dtAll.Rows.Add("402", "OCEANS", @"../../UsedForResource/Ocean/Ocean_16.jpg", 64, 219, 143, 0);
            dtAll.Rows.Add("403", "OCEANS", @"../../UsedForResource/Ocean/Ocean_17.jpg", 232, 213, 110, 1);
            dtAll.Rows.Add("404", "OCEANS", @"../../UsedForResource/Ocean/Ocean_18.jpg", 142, 137, 75, 1);
            dtAll.Rows.Add("405", "OCEANS", @"../../UsedForResource/Ocean/Ocean_19.jpg", 82, 310, 192, 1);
            dtAll.Rows.Add("406", "OCEANS", @"../../UsedForResource/Ocean/Ocean_20.jpg", 72, 257, 126, 1);
            dtAll.Rows.Add("407", "OCEANS", @"../../UsedForResource/Ocean/Ocean_21.jpg", 51, 97, 200, 1);
            dtAll.Rows.Add("408", "OCEANS", @"../../UsedForResource/Ocean/Ocean_22.jpg", 115, 100, 98, 0);
            dtAll.Rows.Add("409", "OCEANS", @"../../UsedForResource/Ocean/Ocean_23.jpg", 42, 290, 100, 1);
            dtAll.Rows.Add("410", "OCEANS", @"../../UsedForResource/Ocean/Ocean_24.jpg", 110, 237, 182, 1);
            dtAll.Rows.Add("411", "OCEANS", @"../../UsedForResource/Ocean/Ocean_25.jpg", 131, 158, 115, 1);
            dtAll.Rows.Add("412", "OCEANS", @"../../UsedForResource/Ocean/Ocean_26.jpg", 36, 223, 285, 1);
            dtAll.Rows.Add("413", "OCEANS", @"../../UsedForResource/Ocean/Ocean_27.jpg", 137, 277, 255, 0);
            dtAll.Rows.Add("414", "OCEANS", @"../../UsedForResource/Ocean/Ocean_28.jpg", 53, 247, 155, 0);
            dtAll.Rows.Add("415", "OCEANS", @"../../UsedForResource/Ocean/Ocean_29.jpg", 125, 194, 174, 0);
            dtAll.Rows.Add("416", "OCEANS", @"../../UsedForResource/Ocean/Ocean_30.jpg", 206, 112, 226, 1);
            dtAll.Rows.Add("417", "OCEANS", @"../../UsedForResource/Ocean/Ocean_31.jpg", 180, 275, 227, 1);
            dtAll.Rows.Add("418", "OCEANS", @"../../UsedForResource/Ocean/Ocean_32.jpg", 130, 156, 88, 0);
            dtAll.Rows.Add("419", "OCEANS", @"../../UsedForResource/Ocean/Ocean_33.jpg", 155, 314, 85, 1);
            dtAll.Rows.Add("420", "OCEANS", @"../../UsedForResource/Ocean/Ocean_34.jpg", 172, 167, 77, 0);
            dtAll.Rows.Add("421", "OCEANS", @"../../UsedForResource/Ocean/Ocean_35.jpg", 29, 93, 235, 1);
            dtAll.Rows.Add("422", "OCEANS", @"../../UsedForResource/Ocean/Ocean_36.jpg", 257, 262, 175, 1);
            dtAll.Rows.Add("423", "OCEANS", @"../../UsedForResource/Ocean/Ocean_37.jpg", 258, 92, 186, 0);
            dtAll.Rows.Add("424", "OCEANS", @"../../UsedForResource/Ocean/Ocean_38.jpg", 111, 215, 145, 1);
            dtAll.Rows.Add("425", "OCEANS", @"../../UsedForResource/Ocean/Ocean_39.jpg", 260, 331, 194, 1);
            dtAll.Rows.Add("426", "OCEANS", @"../../UsedForResource/Ocean/Ocean_40.jpg", 167, 126, 154, 1);
            dtAll.Rows.Add("427", "OCEANS", @"../../UsedForResource/Ocean/Ocean_41.jpg", 26, 304, 248, 1);
            dtAll.Rows.Add("428", "OCEANS", @"../../UsedForResource/Ocean/Ocean_42.jpg", 156, 293, 266, 0);
            dtAll.Rows.Add("429", "OCEANS", @"../../UsedForResource/Ocean/Ocean_43.jpg", 28, 114, 137, 1);
            dtAll.Rows.Add("430", "OCEANS", @"../../UsedForResource/Ocean/Ocean_44.jpg", 249, 216, 187, 0);
            dtAll.Rows.Add("431", "OCEANS", @"../../UsedForResource/Ocean/Ocean_45.jpg", 213, 297, 221, 1);
            dtAll.Rows.Add("432", "OCEANS", @"../../UsedForResource/Ocean/Ocean_46.jpg", 210, 102, 89, 1);
            dtAll.Rows.Add("433", "OCEANS", @"../../UsedForResource/Ocean/Ocean_47.jpg", 97, 128, 195, 0);
            dtAll.Rows.Add("434", "OCEANS", @"../../UsedForResource/Ocean/Ocean_48.jpg", 133, 307, 239, 1);
            dtAll.Rows.Add("435", "OCEANS", @"../../UsedForResource/Ocean/Ocean_49.jpg", 195, 107, 250, 0);
            dtAll.Rows.Add("436", "OCEANS", @"../../UsedForResource/Ocean/Ocean_50.jpg", 199, 140, 261, 1);
            dtAll.Rows.Add("437", "OCEANS", @"../../UsedForResource/Ocean/Ocean_51.jpg", 189, 99, 225, 1);
            dtAll.Rows.Add("438", "OCEANS", @"../../UsedForResource/Ocean/Ocean_52.jpg", 264, 283, 275, 0);
            dtAll.Rows.Add("439", "OCEANS", @"../../UsedForResource/Ocean/Ocean_53.jpg", 50, 269, 131, 1);
            dtAll.Rows.Add("440", "OCEANS", @"../../UsedForResource/Ocean/Ocean_54.jpg", 185, 178, 158, 1);
            dtAll.Rows.Add("441", "OCEANS", @"../../UsedForResource/Ocean/Ocean_55.jpg", 101, 111, 211, 0);
            dtAll.Rows.Add("442", "OCEANS", @"../../UsedForResource/Ocean/Ocean_56.jpg", 118, 217, 121, 0);
            dtAll.Rows.Add("443", "OCEANS", @"../../UsedForResource/Ocean/Ocean_57.jpg", 119, 172, 153, 0);
            dtAll.Rows.Add("444", "OCEANS", @"../../UsedForResource/Ocean/Ocean_58.jpg", 107, 171, 278, 0);
            dtAll.Rows.Add("445", "OCEANS", @"../../UsedForResource/Ocean/Ocean_59.jpg", 161, 285, 289, 1);
            dtAll.Rows.Add("446", "OCEANS", @"../../UsedForResource/Ocean/Ocean_60.jpg", 99, 138, 170, 0);
            dtAll.Rows.Add("447", "OCEANS", @"../../UsedForResource/Ocean/Ocean_61.jpg", 243, 340, 94, 1);
            dtAll.Rows.Add("448", "OCEANS", @"../../UsedForResource/Ocean/Ocean_62.jpg", 236, 344, 219, 0);
            dtAll.Rows.Add("449", "OCEANS", @"../../UsedForResource/Ocean/Ocean_63.jpg", 269, 168, 189, 0);
            dtAll.Rows.Add("450", "OCEANS", @"../../UsedForResource/Ocean/Ocean_64.jpg", 253, 206, 203, 1);
            dtAll.Rows.Add("451", "OCEANS", @"../../UsedForResource/Ocean/Ocean_65.jpg", 150, 193, 76, 1);
            dtAll.Rows.Add("452", "OCEANS", @"../../UsedForResource/Ocean/Ocean_66.jpg", 106, 295, 282, 0);
            dtAll.Rows.Add("453", "OCEANS", @"../../UsedForResource/Ocean/Ocean_67.jpg", 120, 173, 286, 1);
            dtAll.Rows.Add("454", "OCEANS", @"../../UsedForResource/Ocean/Ocean_68.jpg", 215, 210, 199, 0);
            dtAll.Rows.Add("455", "OCEANS", @"../../UsedForResource/Ocean/Ocean_69.jpg", 105, 226, 191, 1);
            dtAll.Rows.Add("456", "OCEANS", @"../../UsedForResource/Ocean/Ocean_70.jpg", 245, 144, 97, 1);
            dtAll.Rows.Add("457", "OCEANS", @"../../UsedForResource/Ocean/Ocean_71.jpg", 187, 182, 181, 0);
            dtAll.Rows.Add("458", "OCEANS", @"../../UsedForResource/Ocean/Ocean_72.jpg", 238, 84, 152, 0);
            dtAll.Rows.Add("459", "OCEANS", @"../../UsedForResource/Ocean/Ocean_73.jpg", 265, 334, 103, 0);
            dtAll.Rows.Add("460", "OCEANS", @"../../UsedForResource/Ocean/Ocean_74.jpg", 86, 220, 119, 1);
            dtAll.Rows.Add("461", "OCEANS", @"../../UsedForResource/Ocean/Ocean_75.jpg", 184, 119, 147, 0);
            dtAll.Rows.Add("462", "OCEANS", @"../../UsedForResource/Ocean/Ocean_76.jpg", 94, 224, 114, 1);
            dtAll.Rows.Add("463", "OCEANS", @"../../UsedForResource/Ocean/Ocean_77.jpg", 202, 282, 130, 1);
            dtAll.Rows.Add("464", "OCEANS", @"../../UsedForResource/Ocean/Ocean_78.jpg", 233, 129, 108, 1);
            dtAll.Rows.Add("465", "OCEANS", @"../../UsedForResource/Ocean/Ocean_79.jpg", 227, 280, 208, 0);
            dtAll.Rows.Add("466", "OCEANS", @"../../UsedForResource/Ocean/Ocean_80.jpg", 138, 256, 269, 0);
            dtAll.Rows.Add("467", "OCEANS", @"../../UsedForResource/Ocean/Ocean_81.jpg", 148, 271, 70, 1);
            dtAll.Rows.Add("468", "OCEANS", @"../../UsedForResource/Ocean/Ocean_82.jpg", 241, 228, 179, 0);
            dtAll.Rows.Add("469", "OCEANS", @"../../UsedForResource/Ocean/Ocean_83.jpg", 188, 142, 177, 1);
            dtAll.Rows.Add("470", "OCEANS", @"../../UsedForResource/Ocean/Ocean_84.jpg", 81, 208, 217, 0);
            dtAll.Rows.Add("471", "OCEANS", @"../../UsedForResource/Ocean/Ocean_85.jpg", 209, 265, 281, 0);
            dtAll.Rows.Add("472", "OCEANS", @"../../UsedForResource/Ocean/Ocean_86.jpg", 214, 339, 240, 0);
            dtAll.Rows.Add("473", "OCEANS", @"../../UsedForResource/Ocean/Ocean_87.jpg", 127, 200, 117, 0);
            dtAll.Rows.Add("474", "OCEANS", @"../../UsedForResource/Ocean/Ocean_88.jpg", 198, 191, 272, 0);
            dtAll.Rows.Add("475", "OCEANS", @"../../UsedForResource/Ocean/Ocean_89.jpg", 157, 266, 172, 1);
            dtAll.Rows.Add("476", "OCEANS", @"../../UsedForResource/Ocean/Ocean_90.jpg", 136, 296, 223, 0);
            dtAll.Rows.Add("477", "OCEANS", @"../../UsedForResource/Ocean/Ocean_91.jpg", 116, 202, 218, 1);
            dtAll.Rows.Add("478", "OCEANS", @"../../UsedForResource/Ocean/Ocean_92.jpg", 71, 133, 268, 1);
            dtAll.Rows.Add("479", "OCEANS", @"../../UsedForResource/Ocean/Ocean_93.jpg", 217, 259, 233, 0);
            dtAll.Rows.Add("480", "OCEANS", @"../../UsedForResource/Ocean/Ocean_94.jpg", 171, 235, 84, 0);
            dtAll.Rows.Add("481", "OCEANS", @"../../UsedForResource/Ocean/Ocean_95.jpg", 164, 249, 101, 0);
            dtAll.Rows.Add("482", "OCEANS", @"../../UsedForResource/Ocean/Ocean_96.jpg", 230, 153, 107, 1);
            dtAll.Rows.Add("483", "OCEANS", @"../../UsedForResource/Ocean/Ocean_97.jpg", 248, 105, 90, 0);
            dtAll.Rows.Add("484", "OCEANS", @"../../UsedForResource/Ocean/Ocean_98.jpg", 31, 337, 112, 0);
            dtAll.Rows.Add("485", "OCEANS", @"../../UsedForResource/Ocean/Ocean_99.jpg", 92, 204, 116, 0);
            dtAll.Rows.Add("486", "OCEANS", @"../../UsedForResource/Ocean/Ocean_100.jpg", 102, 214, 253, 1);
            dtAll.Rows.Add("487", "OCEANS", @"../../UsedForResource/Ocean/Ocean_101.jpg", 109, 218, 196, 0);
            dtAll.Rows.Add("488", "OCEANS", @"../../UsedForResource/Ocean/Ocean_102.jpg", 191, 246, 169, 0);
            dtAll.Rows.Add("489", "OCEANS", @"../../UsedForResource/Ocean/Ocean_103.jpg", 56, 221, 132, 0);
            dtAll.Rows.Add("490", "OCEANS", @"../../UsedForResource/Ocean/Ocean_104.jpg", 179, 113, 83, 0);
            dtAll.Rows.Add("491", "OCEANS", @"../../UsedForResource/Ocean/Ocean_105.jpg", 153, 189, 109, 1);
            dtAll.Rows.Add("492", "OCEANS", @"../../UsedForResource/Ocean/Ocean_106.jpg", 242, 118, 214, 1);
            dtAll.Rows.Add("493", "OCEANS", @"../../UsedForResource/Ocean/Ocean_107.jpg", 54, 261, 207, 1);
            dtAll.Rows.Add("494", "OCEANS", @"../../UsedForResource/Ocean/Ocean_108.jpg", 113, 342, 204, 0);
            dtAll.Rows.Add("495", "OCEANS", @"../../UsedForResource/Ocean/Ocean_109.jpg", 201, 333, 96, 0);
            dtAll.Rows.Add("496", "OCEANS", @"../../UsedForResource/Ocean/Ocean_110.jpg", 194, 345, 92, 0);
            dtAll.Rows.Add("497", "OCEANS", @"../../UsedForResource/Ocean/Ocean_111.jpg", 149, 143, 87, 1);
            dtAll.Rows.Add("498", "OCEANS", @"../../UsedForResource/Ocean/Ocean_112.jpg", 173, 123, 257, 0);
            dtAll.Rows.Add("499", "OCEANS", @"../../UsedForResource/Ocean/Ocean_113.jpg", 151, 300, 138, 1);
            dtAll.Rows.Add("500", "OCEANS", @"../../UsedForResource/Ocean/Ocean_114.jpg", 47, 289, 224, 0);
            dtAll.Rows.Add("501", "OCEANS", @"../../UsedForResource/Ocean/Ocean_115.jpg", 268, 122, 128, 0);
            dtAll.Rows.Add("502", "OCEANS", @"../../UsedForResource/Ocean/Ocean_116.jpg", 67, 169, 262, 0);
            dtAll.Rows.Add("503", "OCEANS", @"../../UsedForResource/Ocean/Ocean_117.jpg", 200, 229, 173, 0);
            dtAll.Rows.Add("504", "OCEANS", @"../../UsedForResource/Ocean/Ocean_118.jpg", 220, 162, 267, 0);
            dtAll.Rows.Add("505", "OCEANS", @"../../UsedForResource/Ocean/Ocean_119.jpg", 224, 263, 79, 1);
            dtAll.Rows.Add("506", "OCEANS", @"../../UsedForResource/Ocean/Ocean_120.jpg", 117, 86, 183, 0);
            dtAll.Rows.Add("507", "OCEANS", @"../../UsedForResource/Ocean/Ocean_121.jpg", 226, 272, 258, 0);
            dtAll.Rows.Add("508", "OCEANS", @"../../UsedForResource/Ocean/Ocean_122.jpg", 30, 211, 198, 1);
            dtAll.Rows.Add("509", "OCEANS", @"../../UsedForResource/Ocean/Ocean_123.jpg", 256, 325, 252, 0);
            dtAll.Rows.Add("510", "OCEANS", @"../../UsedForResource/Ocean/Ocean_124.jpg", 70, 148, 78, 1);
            dtAll.Rows.Add("511", "OCEANS", @"../../UsedForResource/Ocean/Ocean_125.jpg", 231, 294, 287, 0);
            dtAll.Rows.Add("512", "OCEANS", @"../../UsedForResource/Ocean/Ocean_126.jpg", 205, 291, 265, 0);
            dtAll.Rows.Add("513", "OCEANS", @"../../UsedForResource/Ocean/Ocean_127.jpg", 190, 284, 237, 0);
            dtAll.Rows.Add("514", "OCEANS", @"../../UsedForResource/Ocean/Ocean_128.jpg", 250, 332, 166, 0);
            dtAll.Rows.Add("515", "OCEANS", @"../../UsedForResource/Ocean/Ocean_129.jpg", 58, 125, 133, 1);
            dtAll.Rows.Add("516", "OCEANS", @"../../UsedForResource/Ocean/Ocean_130.jpg", 158, 298, 135, 0);
            dtAll.Rows.Add("517", "OCEANS", @"../../UsedForResource/Ocean/Ocean_131.jpg", 100, 89, 168, 0);
            dtAll.Rows.Add("518", "OCEANS", @"../../UsedForResource/Ocean/Ocean_132.jpg", 108, 315, 162, 0);
            dtAll.Rows.Add("519", "OCEANS", @"../../UsedForResource/Ocean/Ocean_133.jpg", 89, 222, 72, 1);
            dtAll.Rows.Add("520", "OCEANS", @"../../UsedForResource/Ocean/Ocean_134.jpg", 122, 242, 161, 1);
            dtAll.Rows.Add("521", "OCEANS", @"../../UsedForResource/Ocean/Ocean_135.jpg", 259, 248, 124, 0);
            dtAll.Rows.Add("522", "OCEANS", @"../../UsedForResource/Ocean/Ocean_136.jpg", 154, 183, 91, 0);
            dtAll.Rows.Add("523", "OCEANS", @"../../UsedForResource/Ocean/Ocean_137.jpg", 176, 281, 125, 0);
            dtAll.Rows.Add("524", "OCEANS", @"../../UsedForResource/Ocean/Ocean_138.jpg", 55, 166, 216, 0);
            dtAll.Rows.Add("525", "OCEANS", @"../../UsedForResource/Ocean/Ocean_139.jpg", 267, 101, 260, 1);
            dtAll.Rows.Add("526", "OCEANS", @"../../UsedForResource/Ocean/Ocean_140.jpg", 274, 155, 150, 0);
            dtAll.Rows.Add("527", "OCEANS", @"../../UsedForResource/Ocean/Ocean_141.jpg", 95, 273, 244, 0);
            dtAll.Rows.Add("528", "OCEANS", @"../../UsedForResource/Ocean/Ocean_142.jpg", 163, 251, 201, 1);
            dtAll.Rows.Add("529", "OCEANS", @"../../UsedForResource/Ocean/Ocean_143.jpg", 83, 267, 273, 0);
            dtAll.Rows.Add("530", "OCEANS", @"../../UsedForResource/Ocean/Ocean_144.jpg", 85, 157, 146, 1);
            dtAll.Rows.Add("531", "OCEANS", @"../../UsedForResource/Ocean/Ocean_145.jpg", 177, 241, 241, 0);
            dtAll.Rows.Add("532", "OCEANS", @"../../UsedForResource/Ocean/Ocean_146.jpg", 80, 330, 256, 1);
            dtAll.Rows.Add("533", "OCEANS", @"../../UsedForResource/Ocean/Ocean_147.jpg", 160, 341, 165, 1);
            dtAll.Rows.Add("534", "OCEANS", @"../../UsedForResource/Ocean/Ocean_148.jpg", 39, 88, 149, 1);
            dtAll.Rows.Add("535", "OCEANS", @"../../UsedForResource/Ocean/Ocean_149.jpg", 52, 152, 105, 1);
            dtAll.Rows.Add("536", "OCEANS", @"../../UsedForResource/Ocean/Ocean_150.jpg", 141, 309, 264, 0);
            dtAll.Rows.Add("537", "OCEANS", @"../../UsedForResource/Ocean/Ocean_151.jpg", 63, 85, 164, 0);
            dtAll.Rows.Add("538", "OCEANS", @"../../UsedForResource/Ocean/Ocean_152.jpg", 255, 270, 134, 0);
            dtAll.Rows.Add("539", "OCEANS", @"../../UsedForResource/Ocean/Ocean_153.jpg", 237, 175, 288, 0);
            dtAll.Rows.Add("540", "OCEANS", @"../../UsedForResource/Ocean/Ocean_154.jpg", 271, 90, 212, 1);
            dtAll.Rows.Add("541", "OCEANS", @"../../UsedForResource/Ocean/Ocean_155.jpg", 76, 135, 259, 1);
            dtAll.Rows.Add("542", "OCEANS", @"../../UsedForResource/Ocean/Ocean_156.jpg", 270, 81, 157, 1);
            dtAll.Rows.Add("543", "OCEANS", @"../../UsedForResource/Ocean/Ocean_157.jpg", 114, 190, 205, 1);
            dtAll.Rows.Add("544", "OCEANS", @"../../UsedForResource/Ocean/Ocean_158.jpg", 65, 306, 276, 0);
            dtAll.Rows.Add("545", "OCEANS", @"../../UsedForResource/Ocean/Ocean_159.jpg", 251, 117, 163, 0);
            dtAll.Rows.Add("546", "OCEANS", @"../../UsedForResource/Ocean/Ocean_160.jpg", 145, 329, 210, 0);
            dtAll.Rows.Add("547", "OCEANS", @"../../UsedForResource/Ocean/Ocean_161.jpg", 147, 320, 95, 1);
            dtAll.Rows.Add("548", "OCEANS", @"../../UsedForResource/Ocean/Ocean_162.jpg", 223, 196, 202, 1);
            dtAll.Rows.Add("549", "OCEANS", @"../../UsedForResource/Ocean/Ocean_163.jpg", 175, 326, 193, 0);
            dtAll.Rows.Add("550", "OCEANS", @"../../UsedForResource/Ocean/Ocean_164.jpg", 123, 104, 113, 1);
            dtAll.Rows.Add("551", "OCEANS", @"../../UsedForResource/Ocean/Ocean_165.jpg", 144, 322, 178, 0);
            dtAll.Rows.Add("552", "OCEANS", @"../../UsedForResource/Ocean/Ocean_166.jpg", 73, 264, 148, 1);
            dtAll.Rows.Add("553", "OCEANS", @"../../UsedForResource/Ocean/Ocean_167.jpg", 32, 233, 242, 1);
            dtAll.Rows.Add("554", "OCEANS", @"../../UsedForResource/Ocean/Ocean_168.jpg", 181, 346, 176, 1);
            dtAll.Rows.Add("555", "OCEANS", @"../../UsedForResource/Ocean/Ocean_169.jpg", 33, 212, 215, 1);
            dtAll.Rows.Add("556", "OCEANS", @"../../UsedForResource/Ocean/Ocean_170.jpg", 91, 274, 245, 0);
            dtAll.Rows.Add("557", "OCEANS", @"../../UsedForResource/Ocean/Ocean_171.jpg", 234, 305, 284, 1);
            dtAll.Rows.Add("558", "OCEANS", @"../../UsedForResource/Ocean/Ocean_172.jpg", 121, 83, 249, 0);
            dtAll.Rows.Add("559", "OCEANS", @"../../UsedForResource/Ocean/Ocean_173.jpg", 178, 348, 270, 1);
            dtAll.Rows.Add("560", "OCEANS", @"../../UsedForResource/Ocean/Ocean_174.jpg", 211, 303, 171, 1);
            dtAll.Rows.Add("561", "OCEANS", @"../../UsedForResource/Ocean/Ocean_175.jpg", 135, 276, 222, 0);
            dtAll.Rows.Add("562", "OCEANS", @"../../UsedForResource/Ocean/Ocean_176.jpg", 192, 336, 160, 1);
            dtAll.Rows.Add("563", "OCEANS", @"../../UsedForResource/Ocean/Ocean_177.jpg", 247, 82, 254, 0);
            dtAll.Rows.Add("564", "OCEANS", @"../../UsedForResource/Ocean/Ocean_178.jpg", 186, 323, 99, 0);
            dtAll.Rows.Add("565", "OCEANS", @"../../UsedForResource/Ocean/Ocean_179.jpg", 38, 236, 263, 0);
            dtAll.Rows.Add("566", "OCEANS", @"../../UsedForResource/Ocean/Ocean_180.jpg", 273, 98, 236, 0);
            dtAll.Rows.Add("567", "OCEANS", @"../../UsedForResource/Ocean/Ocean_181.jpg", 240, 317, 206, 1);
            dtAll.Rows.Add("568", "OCEANS", @"../../UsedForResource/Ocean/Ocean_182.jpg", 126, 187, 80, 1);
            dtAll.Rows.Add("569", "OCEANS", @"../../UsedForResource/Ocean/Ocean_183.jpg", 143, 195, 151, 1);
            dtAll.Rows.Add("570", "OCEANS", @"../../UsedForResource/Ocean/Ocean_184.jpg", 263, 116, 144, 1);
            dtAll.Rows.Add("571", "OCEANS", @"../../UsedForResource/Ocean/Ocean_185.jpg", 266, 188, 231, 1);
            dtAll.Rows.Add("572", "OCEANS", @"../../UsedForResource/Ocean/Ocean_186.jpg", 68, 141, 93, 1);
            dtAll.Rows.Add("573", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_1.jpg", 276, 275, 327, 0);
            dtAll.Rows.Add("574", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_2.jpg", 146, 134, 233, 0);
            dtAll.Rows.Add("575", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_3.jpg", 54, 329, 132, 0);
            dtAll.Rows.Add("576", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_4.jpg", 208, 276, 352, 1);
            dtAll.Rows.Add("577", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_5.jpg", 250, 287, 210, 0);
            dtAll.Rows.Add("578", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_6.jpg", 73, 108, 245, 1);
            dtAll.Rows.Add("579", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_7.jpg", 44, 143, 127, 1);
            dtAll.Rows.Add("580", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_8.jpg", 196, 154, 262, 0);
            dtAll.Rows.Add("581", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_9.jpg", 134, 145, 244, 0);
            dtAll.Rows.Add("582", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_10.jpg", 55, 184, 101, 1);
            dtAll.Rows.Add("583", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_11.jpg", 83, 313, 258, 0);
            dtAll.Rows.Add("584", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_12.jpg", 41, 252, 250, 0);
            dtAll.Rows.Add("585", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_13.jpg", 72, 140, 363, 1);
            dtAll.Rows.Add("586", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_14.jpg", 132, 161, 97, 0);
            dtAll.Rows.Add("587", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_15.jpg", 234, 222, 318, 0);
            dtAll.Rows.Add("588", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_16.jpg", 182, 238, 254, 1);
            dtAll.Rows.Add("589", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_17.jpg", 189, 159, 139, 0);
            dtAll.Rows.Add("590", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_18.jpg", 85, 196, 199, 0);
            dtAll.Rows.Add("591", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_19.jpg", 166, 102, 152, 0);
            dtAll.Rows.Add("592", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_20.jpg", 128, 251, 125, 1);
            dtAll.Rows.Add("593", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_21.jpg", 170, 333, 142, 1);
            dtAll.Rows.Add("594", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_22.jpg", 159, 249, 356, 0);
            dtAll.Rows.Add("595", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_23.jpg", 76, 282, 107, 1);
            dtAll.Rows.Add("596", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_24.jpg", 221, 209, 266, 0);
            dtAll.Rows.Add("597", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_25.jpg", 243, 296, 135, 0);
            dtAll.Rows.Add("598", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_26.jpg", 201, 148, 364, 0);
            dtAll.Rows.Add("599", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_27.jpg", 213, 81, 257, 1);
            dtAll.Rows.Add("600", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_28.jpg", 284, 297, 95, 1);
            dtAll.Rows.Add("601", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_29.jpg", 181, 234, 220, 0);
            dtAll.Rows.Add("602", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_30.jpg", 57, 201, 225, 0);
            dtAll.Rows.Add("603", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_31.jpg", 268, 207, 361, 1);
            dtAll.Rows.Add("604", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_32.jpg", 139, 99, 247, 1);
            dtAll.Rows.Add("605", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_33.jpg", 111, 240, 331, 0);
            dtAll.Rows.Add("606", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_34.jpg", 244, 170, 226, 0);
            dtAll.Rows.Add("607", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_35.jpg", 56, 128, 99, 0);
            dtAll.Rows.Add("608", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_36.jpg", 96, 321, 359, 1);
            dtAll.Rows.Add("609", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_37.jpg", 172, 280, 204, 1);
            dtAll.Rows.Add("610", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_38.jpg", 179, 229, 228, 1);
            dtAll.Rows.Add("611", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_39.jpg", 281, 96, 295, 1);
            dtAll.Rows.Add("612", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_40.jpg", 249, 214, 253, 0);
            dtAll.Rows.Add("613", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_41.jpg", 89, 244, 221, 1);
            dtAll.Rows.Add("614", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_42.jpg", 58, 277, 334, 0);
            dtAll.Rows.Add("615", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_43.jpg", 188, 226, 200, 0);
            dtAll.Rows.Add("616", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_44.jpg", 49, 177, 102, 0);
            dtAll.Rows.Add("617", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_45.jpg", 103, 125, 302, 0);
            dtAll.Rows.Add("618", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_46.jpg", 269, 219, 192, 1);
            dtAll.Rows.Add("619", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_47.jpg", 279, 314, 297, 0);
            dtAll.Rows.Add("620", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_48.jpg", 113, 117, 275, 1);
            dtAll.Rows.Add("621", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_49.jpg", 115, 233, 113, 1);
            dtAll.Rows.Add("622", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_50.jpg", 197, 264, 367, 1);
            dtAll.Rows.Add("623", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_51.jpg", 178, 236, 203, 1);
            dtAll.Rows.Add("624", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_52.jpg", 36, 341, 133, 1);
            dtAll.Rows.Add("625", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_53.jpg", 192, 104, 182, 0);
            dtAll.Rows.Add("626", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_54.jpg", 112, 232, 188, 0);
            dtAll.Rows.Add("627", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_55.jpg", 35, 153, 117, 1);
            dtAll.Rows.Add("628", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_56.jpg", 232, 316, 104, 0);
            dtAll.Rows.Add("629", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_57.jpg", 288, 173, 219, 0);
            dtAll.Rows.Add("630", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_58.jpg", 142, 309, 217, 0);
            dtAll.Rows.Add("631", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_59.jpg", 240, 119, 166, 0);
            dtAll.Rows.Add("632", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_60.jpg", 61, 157, 286, 1);
            dtAll.Rows.Add("633", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_61.jpg", 74, 72, 293, 0);
            dtAll.Rows.Add("634", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_62.jpg", 193, 135, 122, 0);
            dtAll.Rows.Add("635", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_63.jpg", 63, 336, 208, 1);
            dtAll.Rows.Add("636", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_64.jpg", 204, 97, 292, 1);
            dtAll.Rows.Add("637", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_65.jpg", 203, 175, 137, 1);
            dtAll.Rows.Add("638", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_66.jpg", 88, 286, 243, 1);
            dtAll.Rows.Add("639", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_67.jpg", 231, 335, 140, 0);
            dtAll.Rows.Add("640", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_68.jpg", 222, 116, 305, 0);
            dtAll.Rows.Add("641", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_69.jpg", 117, 94, 189, 0);
            dtAll.Rows.Add("642", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_70.jpg", 37, 270, 321, 0);
            dtAll.Rows.Add("643", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_71.jpg", 107, 77, 350, 1);
            dtAll.Rows.Add("644", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_72.jpg", 200, 339, 355, 1);
            dtAll.Rows.Add("645", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_73.jpg", 135, 126, 165, 1);
            dtAll.Rows.Add("646", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_74.jpg", 59, 348, 317, 0);
            dtAll.Rows.Add("647", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_75.jpg", 126, 84, 278, 0);
            dtAll.Rows.Add("648", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_76.jpg", 185, 199, 234, 0);
            dtAll.Rows.Add("649", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_77.jpg", 217, 194, 156, 1);
            dtAll.Rows.Add("650", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_78.jpg", 53, 78, 345, 0);
            dtAll.Rows.Add("651", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_79.jpg", 265, 231, 360, 0);
            dtAll.Rows.Add("652", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_80.jpg", 153, 217, 241, 1);
            dtAll.Rows.Add("653", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_81.jpg", 255, 112, 124, 1);
            dtAll.Rows.Add("654", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_82.jpg", 215, 203, 91, 1);
            dtAll.Rows.Add("655", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_83.jpg", 173, 95, 90, 0);
            dtAll.Rows.Add("656", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_84.jpg", 248, 136, 178, 1);
            dtAll.Rows.Add("657", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_85.jpg", 282, 318, 207, 1);
            dtAll.Rows.Add("658", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_86.jpg", 31, 172, 338, 0);
            dtAll.Rows.Add("659", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_87.jpg", 32, 220, 346, 1);
            dtAll.Rows.Add("660", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_88.jpg", 119, 160, 183, 0);
            dtAll.Rows.Add("661", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_89.jpg", 102, 137, 303, 0);
            dtAll.Rows.Add("662", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_90.jpg", 220, 191, 329, 1);
            dtAll.Rows.Add("663", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_91.jpg", 99, 300, 209, 1);
            dtAll.Rows.Add("664", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_92.jpg", 66, 85, 114, 0);
            dtAll.Rows.Add("665", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_93.jpg", 79, 100, 348, 1);
            dtAll.Rows.Add("666", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_94.jpg", 94, 230, 358, 1);
            dtAll.Rows.Add("667", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_95.jpg", 286, 166, 211, 1);
            dtAll.Rows.Add("668", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_96.jpg", 125, 288, 106, 1);
            dtAll.Rows.Add("669", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_97.jpg", 109, 107, 118, 1);
            dtAll.Rows.Add("670", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_98.jpg", 48, 80, 335, 0);
            dtAll.Rows.Add("671", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_99.jpg", 264, 218, 136, 1);
            dtAll.Rows.Add("672", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_100.jpg", 157, 215, 308, 1);
            dtAll.Rows.Add("673", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_101.jpg", 148, 237, 222, 1);
            dtAll.Rows.Add("674", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_102.jpg", 162, 88, 239, 0);
            dtAll.Rows.Add("675", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_103.jpg", 140, 327, 212, 1);
            dtAll.Rows.Add("676", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_104.jpg", 289, 211, 311, 0);
            dtAll.Rows.Add("677", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_105.jpg", 180, 292, 129, 1);
            dtAll.Rows.Add("678", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_106.jpg", 123, 257, 368, 1);
            dtAll.Rows.Add("679", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_107.jpg", 141, 202, 128, 0);
            dtAll.Rows.Add("680", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_108.jpg", 136, 338, 260, 0);
            dtAll.Rows.Add("681", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_109.jpg", 43, 340, 232, 1);
            dtAll.Rows.Add("682", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_110.jpg", 150, 228, 248, 0);
            dtAll.Rows.Add("683", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_111.jpg", 69, 281, 267, 1);
            dtAll.Rows.Add("684", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_112.jpg", 227, 90, 336, 1);
            dtAll.Rows.Add("685", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_113.jpg", 168, 255, 354, 0);
            dtAll.Rows.Add("686", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_114.jpg", 78, 76, 100, 1);
            dtAll.Rows.Add("687", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_115.jpg", 206, 111, 184, 0);
            dtAll.Rows.Add("688", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_116.jpg", 235, 121, 236, 1);
            dtAll.Rows.Add("689", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_117.jpg", 86, 169, 322, 0);
            dtAll.Rows.Add("690", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_118.jpg", 239, 284, 197, 1);
            dtAll.Rows.Add("691", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_119.jpg", 237, 197, 116, 0);
            dtAll.Rows.Add("692", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_120.jpg", 167, 208, 115, 0);
            dtAll.Rows.Add("693", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_121.jpg", 216, 253, 340, 1);
            dtAll.Rows.Add("694", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_122.jpg", 144, 334, 111, 1);
            dtAll.Rows.Add("695", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_123.jpg", 224, 158, 288, 1);
            dtAll.Rows.Add("696", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_124.jpg", 205, 337, 235, 0);
            dtAll.Rows.Add("697", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_125.jpg", 183, 98, 298, 0);
            dtAll.Rows.Add("698", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_126.jpg", 80, 144, 130, 0);
            dtAll.Rows.Add("699", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_127.jpg", 116, 293, 176, 1);
            dtAll.Rows.Add("700", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_128.jpg", 207, 131, 206, 1);
            dtAll.Rows.Add("701", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_129.jpg", 84, 127, 306, 1);
            dtAll.Rows.Add("702", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_130.jpg", 169, 247, 105, 0);
            dtAll.Rows.Add("703", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_131.jpg", 247, 174, 237, 1);
            dtAll.Rows.Add("704", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_132.jpg", 175, 200, 185, 1);
            dtAll.Rows.Add("705", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_133.jpg", 272, 204, 349, 1);
            dtAll.Rows.Add("706", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_134.jpg", 260, 155, 347, 0);
            dtAll.Rows.Add("707", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_135.jpg", 177, 83, 319, 1);
            dtAll.Rows.Add("708", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_136.jpg", 60, 114, 144, 0);
            dtAll.Rows.Add("709", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_137.jpg", 33, 70, 191, 1);
            dtAll.Rows.Add("710", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_138.jpg", 161, 133, 310, 0);
            dtAll.Rows.Add("711", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_139.jpg", 171, 132, 168, 1);
            dtAll.Rows.Add("712", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_140.jpg", 223, 223, 187, 1);
            dtAll.Rows.Add("713", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_141.jpg", 81, 71, 328, 1);
            dtAll.Rows.Add("714", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_142.jpg", 228, 124, 240, 0);
            dtAll.Rows.Add("715", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_143.jpg", 138, 213, 198, 0);
            dtAll.Rows.Add("716", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_144.jpg", 263, 150, 304, 0);
            dtAll.Rows.Add("717", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_145.jpg", 151, 248, 299, 0);
            dtAll.Rows.Add("718", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_146.jpg", 287, 265, 289, 0);
            dtAll.Rows.Add("719", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_147.jpg", 64, 206, 261, 1);
            dtAll.Rows.Add("720", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_148.jpg", 233, 91, 281, 0);
            dtAll.Rows.Add("721", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_149.jpg", 50, 149, 351, 1);
            dtAll.Rows.Add("722", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_150.jpg", 137, 273, 231, 1);
            dtAll.Rows.Add("723", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_151.jpg", 158, 250, 120, 0);
            dtAll.Rows.Add("724", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_152.jpg", 210, 138, 353, 0);
            dtAll.Rows.Add("725", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_153.jpg", 257, 279, 148, 0);
            dtAll.Rows.Add("726", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_154.jpg", 104, 271, 196, 1);
            dtAll.Rows.Add("727", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_155.jpg", 65, 243, 357, 1);
            dtAll.Rows.Add("728", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_156.jpg", 245, 156, 268, 0);
            dtAll.Rows.Add("729", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_157.jpg", 258, 179, 272, 1);
            dtAll.Rows.Add("730", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_158.jpg", 270, 176, 333, 0);
            dtAll.Rows.Add("731", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_159.jpg", 163, 186, 157, 1);
            dtAll.Rows.Add("732", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_160.jpg", 156, 274, 96, 1);
            dtAll.Rows.Add("733", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_161.jpg", 194, 165, 119, 0);
            dtAll.Rows.Add("734", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_162.jpg", 251, 289, 270, 0);
            dtAll.Rows.Add("735", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_163.jpg", 259, 193, 201, 1);
            dtAll.Rows.Add("736", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_164.jpg", 98, 75, 173, 1);
            dtAll.Rows.Add("737", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_165.jpg", 114, 320, 171, 1);
            dtAll.Rows.Add("738", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_166.jpg", 92, 164, 269, 0);
            dtAll.Rows.Add("739", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_167.jpg", 46, 86, 215, 1);
            dtAll.Rows.Add("740", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_168.jpg", 195, 324, 205, 0);
            dtAll.Rows.Add("741", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_169.jpg", 108, 242, 279, 1);
            dtAll.Rows.Add("742", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_170.jpg", 38, 195, 285, 0);
            dtAll.Rows.Add("743", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_171.jpg", 145, 167, 180, 0);
            dtAll.Rows.Add("744", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_172.jpg", 253, 130, 296, 1);
            dtAll.Rows.Add("745", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_173.jpg", 160, 259, 94, 1);
            dtAll.Rows.Add("746", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_174.jpg", 129, 311, 362, 1);
            dtAll.Rows.Add("747", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_175.jpg", 87, 181, 259, 1);
            dtAll.Rows.Add("748", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_176.jpg", 133, 245, 134, 1);
            dtAll.Rows.Add("749", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_177.jpg", 118, 346, 161, 0);
            dtAll.Rows.Add("750", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_178.jpg", 176, 246, 109, 0);
            dtAll.Rows.Add("751", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_179.jpg", 266, 123, 252, 0);
            dtAll.Rows.Add("752", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_180.jpg", 77, 323, 369, 1);
            dtAll.Rows.Add("753", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_181.jpg", 262, 260, 339, 0);
            dtAll.Rows.Add("754", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_182.jpg", 124, 171, 195, 1);
            dtAll.Rows.Add("755", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_183.jpg", 95, 188, 283, 1);
            dtAll.Rows.Add("756", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_184.jpg", 121, 267, 312, 1);
            dtAll.Rows.Add("757", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_185.jpg", 147, 168, 179, 0);
            dtAll.Rows.Add("758", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_186.jpg", 277, 92, 301, 1);
            dtAll.Rows.Add("759", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_187.jpg", 130, 307, 309, 1);
            dtAll.Rows.Add("760", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_188.jpg", 68, 192, 294, 1);
            dtAll.Rows.Add("761", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_189.jpg", 241, 129, 186, 1);
            dtAll.Rows.Add("762", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_190.jpg", 184, 278, 155, 0);
            dtAll.Rows.Add("763", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_191.jpg", 39, 283, 190, 0);
            dtAll.Rows.Add("764", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_192.jpg", 131, 139, 93, 1);
            dtAll.Rows.Add("765", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_193.jpg", 143, 304, 315, 1);
            dtAll.Rows.Add("766", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_194.jpg", 198, 331, 255, 0);
            dtAll.Rows.Add("767", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_195.jpg", 47, 103, 143, 1);
            dtAll.Rows.Add("768", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_196.jpg", 261, 317, 242, 1);
            dtAll.Rows.Add("769", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_197.jpg", 271, 74, 218, 0);
            dtAll.Rows.Add("770", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_198.jpg", 256, 225, 167, 1);
            dtAll.Rows.Add("771", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_199.jpg", 275, 301, 307, 0);
            dtAll.Rows.Add("772", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_200.jpg", 187, 347, 131, 0);
            dtAll.Rows.Add("773", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_201.jpg", 212, 344, 110, 1);
            dtAll.Rows.Add("774", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_202.jpg", 211, 185, 284, 1);
            dtAll.Rows.Add("775", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_203.jpg", 285, 322, 326, 1);
            dtAll.Rows.Add("776", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_204.jpg", 101, 101, 126, 0);
            dtAll.Rows.Add("777", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_205.jpg", 82, 349, 273, 0);
            dtAll.Rows.Add("778", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_206.jpg", 155, 142, 149, 1);
            dtAll.Rows.Add("779", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_207.jpg", 93, 285, 256, 0);
            dtAll.Rows.Add("780", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_208.jpg", 267, 254, 169, 0);
            dtAll.Rows.Add("781", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_209.jpg", 226, 342, 365, 1);
            dtAll.Rows.Add("782", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_210.jpg", 230, 306, 159, 0);
            dtAll.Rows.Add("783", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_211.jpg", 120, 332, 274, 1);
            dtAll.Rows.Add("784", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_212.jpg", 283, 198, 227, 1);
            dtAll.Rows.Add("785", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_213.jpg", 273, 87, 103, 1);
            dtAll.Rows.Add("786", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_214.jpg", 246, 182, 213, 0);
            dtAll.Rows.Add("787", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_215.jpg", 199, 113, 92, 1);
            dtAll.Rows.Add("788", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_216.jpg", 209, 299, 154, 1);
            dtAll.Rows.Add("789", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_217.jpg", 105, 227, 123, 1);
            dtAll.Rows.Add("790", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_218.jpg", 100, 105, 337, 1);
            dtAll.Rows.Add("791", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_219.jpg", 90, 310, 177, 0);
            dtAll.Rows.Add("792", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_220.jpg", 149, 256, 313, 1);
            dtAll.Rows.Add("793", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_221.jpg", 30, 178, 314, 0);
            dtAll.Rows.Add("794", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_222.jpg", 154, 308, 224, 0);
            dtAll.Rows.Add("795", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_223.jpg", 71, 241, 290, 0);
            dtAll.Rows.Add("796", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_224.jpg", 152, 258, 366, 1);
            dtAll.Rows.Add("797", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_225.jpg", 278, 224, 229, 0);
            dtAll.Rows.Add("798", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_226.jpg", 219, 315, 150, 0);
            dtAll.Rows.Add("799", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_227.jpg", 242, 180, 151, 0);
            dtAll.Rows.Add("800", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_228.jpg", 91, 291, 320, 0);
            dtAll.Rows.Add("801", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_229.jpg", 280, 151, 251, 0);
            dtAll.Rows.Add("802", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_230.jpg", 191, 106, 174, 1);
            dtAll.Rows.Add("803", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_231.jpg", 127, 319, 145, 1);
            dtAll.Rows.Add("804", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_232.jpg", 70, 141, 287, 0);
            dtAll.Rows.Add("805", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_233.jpg", 174, 93, 141, 1);
            dtAll.Rows.Add("806", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_234.jpg", 214, 210, 325, 0);
            dtAll.Rows.Add("807", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_235.jpg", 218, 162, 300, 1);
            dtAll.Rows.Add("808", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_236.jpg", 252, 152, 202, 1);
            dtAll.Rows.Add("809", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_237.jpg", 165, 216, 164, 1);
            dtAll.Rows.Add("810", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_238.jpg", 236, 163, 291, 1);
            dtAll.Rows.Add("811", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_239.jpg", 186, 343, 216, 0);
            dtAll.Rows.Add("812", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_240.jpg", 34, 82, 246, 0);
            dtAll.Rows.Add("813", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_241.jpg", 51, 115, 265, 0);
            dtAll.Rows.Add("814", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_242.jpg", 40, 122, 138, 1);
            dtAll.Rows.Add("815", "FOREST", @"../../UsedForResource/Forest/Forest_1.jpg", 272, 171, 251, 1);
            dtAll.Rows.Add("816", "FOREST", @"../../UsedForResource/Forest/Forest_2.jpg", 265, 311, 125, 0);
            dtAll.Rows.Add("817", "FOREST", @"../../UsedForResource/Forest/Forest_3.jpg", 204, 315, 302, 0);
            dtAll.Rows.Add("818", "FOREST", @"../../UsedForResource/Forest/Forest_4.jpg", 105, 384, 249, 1);
            dtAll.Rows.Add("819", "FOREST", @"../../UsedForResource/Forest/Forest_5.jpg", 261, 181, 204, 0);
            dtAll.Rows.Add("820", "FOREST", @"../../UsedForResource/Forest/Forest_6.jpg", 290, 156, 277, 1);
            dtAll.Rows.Add("821", "FOREST", @"../../UsedForResource/Forest/Forest_7.jpg", 190, 321, 341, 0);
            dtAll.Rows.Add("822", "FOREST", @"../../UsedForResource/Forest/Forest_8.jpg", 170, 120, 255, 0);
            dtAll.Rows.Add("823", "FOREST", @"../../UsedForResource/Forest/Forest_9.jpg", 207, 163, 262, 1);
            dtAll.Rows.Add("824", "FOREST", @"../../UsedForResource/Forest/Forest_10.jpg", 221, 331, 155, 0);
            dtAll.Rows.Add("825", "FOREST", @"../../UsedForResource/Forest/Forest_11.jpg", 193, 218, 287, 0);
            dtAll.Rows.Add("826", "FOREST", @"../../UsedForResource/Forest/Forest_12.jpg", 56, 119, 158, 1);
            dtAll.Rows.Add("827", "FOREST", @"../../UsedForResource/Forest/Forest_13.jpg", 239, 216, 205, 0);
            dtAll.Rows.Add("828", "FOREST", @"../../UsedForResource/Forest/Forest_14.jpg", 111, 363, 164, 1);
            dtAll.Rows.Add("829", "FOREST", @"../../UsedForResource/Forest/Forest_15.jpg", 232, 155, 220, 0);
            dtAll.Rows.Add("830", "FOREST", @"../../UsedForResource/Forest/Forest_16.jpg", 116, 304, 231, 1);
            dtAll.Rows.Add("831", "FOREST", @"../../UsedForResource/Forest/Forest_17.jpg", 174, 302, 135, 0);
            dtAll.Rows.Add("832", "FOREST", @"../../UsedForResource/Forest/Forest_18.jpg", 118, 96, 241, 0);
            dtAll.Rows.Add("833", "FOREST", @"../../UsedForResource/Forest/Forest_19.jpg", 242, 169, 173, 1);
            dtAll.Rows.Add("834", "FOREST", @"../../UsedForResource/Forest/Forest_20.jpg", 153, 78, 137, 0);
            dtAll.Rows.Add("835", "FOREST", @"../../UsedForResource/Forest/Forest_21.jpg", 60, 359, 269, 0);
            dtAll.Rows.Add("836", "FOREST", @"../../UsedForResource/Forest/Forest_22.jpg", 81, 85, 156, 0);
            dtAll.Rows.Add("837", "FOREST", @"../../UsedForResource/Forest/Forest_23.jpg", 233, 284, 130, 1);
            dtAll.Rows.Add("838", "FOREST", @"../../UsedForResource/Forest/Forest_24.jpg", 78, 189, 278, 1);
            dtAll.Rows.Add("839", "FOREST", @"../../UsedForResource/Forest/Forest_25.jpg", 168, 177, 285, 1);
            dtAll.Rows.Add("840", "FOREST", @"../../UsedForResource/Forest/Forest_26.jpg", 54, 93, 244, 0);
            dtAll.Rows.Add("841", "FOREST", @"../../UsedForResource/Forest/Forest_27.jpg", 262, 194, 206, 0);
            dtAll.Rows.Add("842", "FOREST", @"../../UsedForResource/Forest/Forest_28.jpg", 152, 199, 113, 1);
            dtAll.Rows.Add("843", "FOREST", @"../../UsedForResource/Forest/Forest_29.jpg", 205, 159, 218, 0);
            dtAll.Rows.Add("844", "FOREST", @"../../UsedForResource/Forest/Forest_30.jpg", 59, 200, 141, 1);
            dtAll.Rows.Add("845", "FOREST", @"../../UsedForResource/Forest/Forest_31.jpg", 264, 387, 111, 1);
            dtAll.Rows.Add("846", "FOREST", @"../../UsedForResource/Forest/Forest_32.jpg", 202, 364, 326, 1);
            dtAll.Rows.Add("847", "FOREST", @"../../UsedForResource/Forest/Forest_33.jpg", 283, 165, 102, 1);
            dtAll.Rows.Add("848", "FOREST", @"../../UsedForResource/Forest/Forest_34.jpg", 240, 323, 189, 1);
            dtAll.Rows.Add("849", "FOREST", @"../../UsedForResource/Forest/Forest_35.jpg", 176, 366, 268, 1);
            dtAll.Rows.Add("850", "FOREST", @"../../UsedForResource/Forest/Forest_36.jpg", 249, 277, 292, 0);
            dtAll.Rows.Add("851", "FOREST", @"../../UsedForResource/Forest/Forest_37.jpg", 208, 174, 172, 0);
            dtAll.Rows.Add("852", "FOREST", @"../../UsedForResource/Forest/Forest_38.jpg", 93, 95, 139, 1);
            dtAll.Rows.Add("853", "FOREST", @"../../UsedForResource/Forest/Forest_39.jpg", 103, 367, 165, 1);
            dtAll.Rows.Add("854", "FOREST", @"../../UsedForResource/Forest/Forest_40.jpg", 76, 82, 202, 1);
            dtAll.Rows.Add("855", "FOREST", @"../../UsedForResource/Forest/Forest_41.jpg", 199, 127, 143, 1);
            dtAll.Rows.Add("856", "FOREST", @"../../UsedForResource/Forest/Forest_42.jpg", 219, 148, 103, 1);
            dtAll.Rows.Add("857", "FOREST", @"../../UsedForResource/Forest/Forest_43.jpg", 64, 184, 117, 0);
            dtAll.Rows.Add("858", "FOREST", @"../../UsedForResource/Forest/Forest_44.jpg", 159, 131, 196, 0);
            dtAll.Rows.Add("859", "FOREST", @"../../UsedForResource/Forest/Forest_45.jpg", 194, 289, 340, 1);
            dtAll.Rows.Add("860", "FOREST", @"../../UsedForResource/Forest/Forest_46.jpg", 139, 275, 329, 1);
            dtAll.Rows.Add("861", "FOREST", @"../../UsedForResource/Forest/Forest_47.jpg", 184, 161, 330, 0);
            dtAll.Rows.Add("862", "FOREST", @"../../UsedForResource/Forest/Forest_48.jpg", 252, 225, 105, 1);
            dtAll.Rows.Add("863", "FOREST", @"../../UsedForResource/Forest/Forest_49.jpg", 213, 300, 161, 1);
            dtAll.Rows.Add("864", "FOREST", @"../../UsedForResource/Forest/Forest_50.jpg", 165, 205, 279, 0);
            dtAll.Rows.Add("865", "FOREST", @"../../UsedForResource/Forest/Forest_51.jpg", 178, 246, 150, 1);
            dtAll.Rows.Add("866", "FOREST", @"../../UsedForResource/Forest/Forest_52.jpg", 285, 88, 325, 0);
            dtAll.Rows.Add("867", "FOREST", @"../../UsedForResource/Forest/Forest_53.jpg", 268, 94, 168, 0);
            dtAll.Rows.Add("868", "FOREST", @"../../UsedForResource/Forest/Forest_54.jpg", 189, 235, 169, 0);
            dtAll.Rows.Add("869", "FOREST", @"../../UsedForResource/Forest/Forest_55.jpg", 114, 341, 298, 0);
            dtAll.Rows.Add("870", "FOREST", @"../../UsedForResource/Forest/Forest_56.jpg", 133, 215, 142, 0);
            dtAll.Rows.Add("871", "FOREST", @"../../UsedForResource/Forest/Forest_57.jpg", 181, 76, 252, 1);
            dtAll.Rows.Add("872", "FOREST", @"../../UsedForResource/Forest/Forest_58.jpg", 286, 264, 270, 1);
            dtAll.Rows.Add("873", "FOREST", @"../../UsedForResource/Forest/Forest_59.jpg", 125, 137, 214, 1);
            dtAll.Rows.Add("874", "FOREST", @"../../UsedForResource/Forest/Forest_60.jpg", 229, 211, 124, 0);
            dtAll.Rows.Add("875", "FOREST", @"../../UsedForResource/Forest/Forest_61.jpg", 80, 108, 170, 0);
            dtAll.Rows.Add("876", "FOREST", @"../../UsedForResource/Forest/Forest_62.jpg", 65, 374, 338, 1);
            dtAll.Rows.Add("877", "FOREST", @"../../UsedForResource/Forest/Forest_63.jpg", 142, 173, 229, 1);
            dtAll.Rows.Add("878", "FOREST", @"../../UsedForResource/Forest/Forest_64.jpg", 230, 175, 321, 0);
            dtAll.Rows.Add("879", "FOREST", @"../../UsedForResource/Forest/Forest_65.jpg", 236, 326, 216, 0);
            dtAll.Rows.Add("880", "FOREST", @"../../UsedForResource/Forest/Forest_66.jpg", 113, 217, 336, 0);
            dtAll.Rows.Add("881", "FOREST", @"../../UsedForResource/Forest/Forest_67.jpg", 164, 308, 267, 0);
            dtAll.Rows.Add("882", "FOREST", @"../../UsedForResource/Forest/Forest_68.jpg", 101, 269, 122, 1);
            dtAll.Rows.Add("883", "FOREST", @"../../UsedForResource/Forest/Forest_69.jpg", 200, 383, 219, 0);
            dtAll.Rows.Add("884", "FOREST", @"../../UsedForResource/Forest/Forest_70.jpg", 248, 142, 114, 0);
            dtAll.Rows.Add("885", "FOREST", @"../../UsedForResource/Forest/Forest_71.jpg", 70, 219, 316, 0);
            dtAll.Rows.Add("886", "FOREST", @"../../UsedForResource/Forest/Forest_72.jpg", 88, 154, 226, 1);
            dtAll.Rows.Add("887", "FOREST", @"../../UsedForResource/Forest/Forest_73.jpg", 237, 342, 195, 0);
            dtAll.Rows.Add("888", "FOREST", @"../../UsedForResource/Forest/Forest_74.jpg", 244, 365, 232, 0);
            dtAll.Rows.Add("889", "FOREST", @"../../UsedForResource/Forest/Forest_75.jpg", 163, 361, 188, 0);
            dtAll.Rows.Add("890", "FOREST", @"../../UsedForResource/Forest/Forest_76.jpg", 155, 313, 166, 1);
            dtAll.Rows.Add("891", "FOREST", @"../../UsedForResource/Forest/Forest_77.jpg", 173, 241, 110, 1);
            dtAll.Rows.Add("892", "FOREST", @"../../UsedForResource/Forest/Forest_78.jpg", 144, 337, 240, 1);
            dtAll.Rows.Add("893", "FOREST", @"../../UsedForResource/Forest/Forest_79.jpg", 271, 230, 118, 0);
            dtAll.Rows.Add("894", "FOREST", @"../../UsedForResource/Forest/Forest_80.jpg", 119, 204, 343, 1);
            dtAll.Rows.Add("895", "FOREST", @"../../UsedForResource/Forest/Forest_81.jpg", 246, 345, 144, 1);
            dtAll.Rows.Add("896", "FOREST", @"../../UsedForResource/Forest/Forest_82.jpg", 145, 183, 154, 0);
            dtAll.Rows.Add("897", "FOREST", @"../../UsedForResource/Forest/Forest_83.jpg", 227, 170, 342, 1);
            dtAll.Rows.Add("898", "FOREST", @"../../UsedForResource/Forest/Forest_84.jpg", 253, 209, 289, 1);
            dtAll.Rows.Add("899", "FOREST", @"../../UsedForResource/Forest/Forest_85.jpg", 250, 340, 317, 1);
            dtAll.Rows.Add("900", "FOREST", @"../../UsedForResource/Forest/Forest_86.jpg", 195, 201, 133, 0);
            dtAll.Rows.Add("901", "FOREST", @"../../UsedForResource/Forest/Forest_87.jpg", 209, 370, 185, 1);
            dtAll.Rows.Add("902", "FOREST", @"../../UsedForResource/Forest/Forest_88.jpg", 91, 239, 160, 1);
            dtAll.Rows.Add("903", "FOREST", @"../../UsedForResource/Forest/Forest_89.jpg", 217, 375, 235, 1);
            dtAll.Rows.Add("904", "FOREST", @"../../UsedForResource/Forest/Forest_90.jpg", 131, 280, 109, 1);
            dtAll.Rows.Add("905", "FOREST", @"../../UsedForResource/Forest/Forest_91.jpg", 110, 309, 248, 0);
            dtAll.Rows.Add("906", "FOREST", @"../../UsedForResource/Forest/Forest_92.jpg", 284, 390, 192, 1);
            dtAll.Rows.Add("907", "FOREST", @"../../UsedForResource/Forest/Forest_93.jpg", 100, 116, 200, 1);
            dtAll.Rows.Add("908", "FOREST", @"../../UsedForResource/Forest/Forest_94.jpg", 186, 376, 324, 1);
            dtAll.Rows.Add("909", "FOREST", @"../../UsedForResource/Forest/Forest_95.jpg", 212, 207, 256, 0);
            dtAll.Rows.Add("910", "FOREST", @"../../UsedForResource/Forest/Forest_96.jpg", 77, 385, 182, 1);
            dtAll.Rows.Add("911", "FOREST", @"../../UsedForResource/Forest/Forest_97.jpg", 215, 139, 273, 1);
            dtAll.Rows.Add("912", "FOREST", @"../../UsedForResource/Forest/Forest_98.jpg", 179, 355, 323, 1);
            dtAll.Rows.Add("913", "FOREST", @"../../UsedForResource/Forest/Forest_99.jpg", 222, 261, 210, 0);
            dtAll.Rows.Add("914", "FOREST", @"../../UsedForResource/Forest/Forest_100.jpg", 92, 336, 288, 1);
            dtAll.Rows.Add("915", "FOREST", @"../../UsedForResource/Forest/Forest_101.jpg", 102, 234, 112, 1);
            dtAll.Rows.Add("916", "FOREST", @"../../UsedForResource/Forest/Forest_102.jpg", 53, 293, 320, 0);
            dtAll.Rows.Add("917", "FOREST", @"../../UsedForResource/Forest/Forest_103.jpg", 126, 123, 259, 0);
            dtAll.Rows.Add("918", "FOREST", @"../../UsedForResource/Forest/Forest_104.jpg", 247, 73, 281, 0);
            dtAll.Rows.Add("919", "FOREST", @"../../UsedForResource/Forest/Forest_105.jpg", 89, 122, 104, 0);
            dtAll.Rows.Add("920", "FOREST", @"../../UsedForResource/Forest/Forest_106.jpg", 157, 130, 222, 1);
            dtAll.Rows.Add("921", "FOREST", @"../../UsedForResource/Forest/Forest_107.jpg", 277, 265, 282, 1);
            dtAll.Rows.Add("922", "FOREST", @"../../UsedForResource/Forest/Forest_108.jpg", 148, 396, 293, 0);
            dtAll.Rows.Add("923", "FOREST", @"../../UsedForResource/Forest/Forest_109.jpg", 160, 233, 274, 1);
            dtAll.Rows.Add("924", "FOREST", @"../../UsedForResource/Forest/Forest_110.jpg", 235, 295, 245, 1);
            dtAll.Rows.Add("925", "FOREST", @"../../UsedForResource/Forest/Forest_111.jpg", 124, 140, 332, 0);
            dtAll.Rows.Add("926", "FOREST", @"../../UsedForResource/Forest/Forest_112.jpg", 182, 105, 242, 1);
            dtAll.Rows.Add("927", "FOREST", @"../../UsedForResource/Forest/Forest_113.jpg", 276, 187, 344, 0);
            dtAll.Rows.Add("928", "FOREST", @"../../UsedForResource/Forest/Forest_114.jpg", 109, 271, 290, 0);
            dtAll.Rows.Add("929", "FOREST", @"../../UsedForResource/Forest/Forest_115.jpg", 154, 110, 119, 1);
            dtAll.Rows.Add("930", "FOREST", @"../../UsedForResource/Forest/Forest_116.jpg", 270, 121, 254, 1);
            dtAll.Rows.Add("931", "FOREST", @"../../UsedForResource/Forest/Forest_117.jpg", 185, 86, 265, 0);
            dtAll.Rows.Add("932", "FOREST", @"../../UsedForResource/Forest/Forest_118.jpg", 295, 272, 184, 1);
            dtAll.Rows.Add("933", "FOREST", @"../../UsedForResource/Forest/Forest_119.jpg", 169, 350, 315, 0);
            dtAll.Rows.Add("934", "FOREST", @"../../UsedForResource/Forest/Forest_120.jpg", 259, 176, 318, 0);
            dtAll.Rows.Add("935", "FOREST", @"../../UsedForResource/Forest/Forest_121.jpg", 231, 389, 308, 1);
            dtAll.Rows.Add("936", "FOREST", @"../../UsedForResource/Forest/Forest_122.jpg", 112, 353, 225, 1);
            dtAll.Rows.Add("937", "FOREST", @"../../UsedForResource/Forest/Forest_123.jpg", 83, 319, 145, 1);
            dtAll.Rows.Add("938", "FOREST", @"../../UsedForResource/Forest/Forest_124.jpg", 66, 286, 237, 1);
            dtAll.Rows.Add("939", "FOREST", @"../../UsedForResource/Forest/Forest_125.jpg", 260, 254, 180, 1);
            dtAll.Rows.Add("940", "FOREST", @"../../UsedForResource/Forest/Forest_126.jpg", 106, 257, 193, 1);
            dtAll.Rows.Add("941", "FOREST", @"../../UsedForResource/Forest/Forest_127.jpg", 68, 368, 280, 1);
            dtAll.Rows.Add("942", "FOREST", @"../../UsedForResource/Forest/Forest_128.jpg", 269, 77, 333, 1);
            dtAll.Rows.Add("943", "FOREST", @"../../UsedForResource/Forest/Forest_129.jpg", 175, 377, 300, 1);
            dtAll.Rows.Add("944", "FOREST", @"../../UsedForResource/Forest/Forest_130.jpg", 86, 344, 123, 1);
            dtAll.Rows.Add("945", "FOREST", @"../../UsedForResource/Forest/Forest_131.jpg", 129, 79, 208, 1);
            dtAll.Rows.Add("946", "FOREST", @"../../UsedForResource/Forest/Forest_132.jpg", 61, 343, 258, 0);
            dtAll.Rows.Add("947", "FOREST", @"../../UsedForResource/Forest/Forest_133.jpg", 55, 332, 239, 0);
            dtAll.Rows.Add("948", "FOREST", @"../../UsedForResource/Forest/Forest_134.jpg", 58, 399, 159, 0);
            dtAll.Rows.Add("949", "FOREST", @"../../UsedForResource/Forest/Forest_135.jpg", 71, 226, 126, 0);
            dtAll.Rows.Add("950", "FOREST", @"../../UsedForResource/Forest/Forest_136.jpg", 146, 192, 179, 1);
            dtAll.Rows.Add("951", "FOREST", @"../../UsedForResource/Forest/Forest_137.jpg", 50, 282, 101, 0);
            dtAll.Rows.Add("952", "FOREST", @"../../UsedForResource/Forest/Forest_138.jpg", 73, 111, 234, 0);
            dtAll.Rows.Add("953", "FOREST", @"../../UsedForResource/Forest/Forest_139.jpg", 74, 372, 108, 1);
            dtAll.Rows.Add("954", "FOREST", @"../../UsedForResource/Forest/Forest_140.jpg", 220, 222, 304, 1);
            dtAll.Rows.Add("955", "FOREST", @"../../UsedForResource/Forest/Forest_141.jpg", 288, 393, 129, 0);
            dtAll.Rows.Add("956", "FOREST", @"../../UsedForResource/Forest/Forest_142.jpg", 210, 198, 322, 0);
            dtAll.Rows.Add("957", "FOREST", @"../../UsedForResource/Forest/Forest_143.jpg", 141, 185, 203, 1);
            dtAll.Rows.Add("958", "FOREST", @"../../UsedForResource/Forest/Forest_144.jpg", 243, 322, 349, 0);
            dtAll.Rows.Add("959", "FOREST", @"../../UsedForResource/Forest/Forest_145.jpg", 293, 132, 310, 1);
            dtAll.Rows.Add("960", "FOREST", @"../../UsedForResource/Forest/Forest_146.jpg", 211, 141, 257, 0);
            dtAll.Rows.Add("961", "FOREST", @"../../UsedForResource/Forest/Forest_147.jpg", 156, 188, 283, 0);
            dtAll.Rows.Add("962", "FOREST", @"../../UsedForResource/Forest/Forest_148.jpg", 291, 380, 115, 1);
            dtAll.Rows.Add("963", "FOREST", @"../../UsedForResource/Forest/Forest_149.jpg", 128, 91, 271, 1);
            dtAll.Rows.Add("964", "FOREST", @"../../UsedForResource/Forest/Forest_150.jpg", 149, 237, 138, 1);
            dtAll.Rows.Add("965", "FOREST", @"../../UsedForResource/Forest/Forest_151.jpg", 257, 249, 134, 0);
            dtAll.Rows.Add("966", "FOREST", @"../../UsedForResource/Forest/Forest_152.jpg", 266, 258, 128, 1);
            dtAll.Rows.Add("967", "FOREST", @"../../UsedForResource/Forest/Forest_153.jpg", 280, 109, 136, 0);
            dtAll.Rows.Add("968", "FOREST", @"../../UsedForResource/Forest/Forest_154.jpg", 226, 172, 335, 0);
            dtAll.Rows.Add("969", "FOREST", @"../../UsedForResource/Forest/Forest_155.jpg", 218, 347, 207, 0);
            dtAll.Rows.Add("970", "FOREST", @"../../UsedForResource/Forest/Forest_156.jpg", 67, 107, 127, 0);
            dtAll.Rows.Add("971", "FOREST", @"../../UsedForResource/Forest/Forest_157.jpg", 134, 102, 295, 0);
            dtAll.Rows.Add("972", "FOREST", @"../../UsedForResource/Forest/Forest_158.jpg", 85, 179, 309, 1);
            dtAll.Rows.Add("973", "FOREST", @"../../UsedForResource/Forest/Forest_159.jpg", 95, 92, 286, 0);
            dtAll.Rows.Add("974", "FOREST", @"../../UsedForResource/Forest/Forest_160.jpg", 97, 316, 260, 0);
            dtAll.Rows.Add("975", "FOREST", @"../../UsedForResource/Forest/Forest_161.jpg", 214, 301, 264, 1);
            dtAll.Rows.Add("976", "FOREST", @"../../UsedForResource/Forest/Forest_162.jpg", 108, 71, 299, 0);
            dtAll.Rows.Add("977", "FOREST", @"../../UsedForResource/Forest/Forest_163.jpg", 132, 310, 209, 0);
            dtAll.Rows.Add("978", "FOREST", @"../../UsedForResource/Forest/Forest_164.jpg", 203, 244, 217, 0);
            dtAll.Rows.Add("979", "FOREST", @"../../UsedForResource/Forest/Forest_165.jpg", 62, 381, 187, 1);
            dtAll.Rows.Add("980", "FOREST", @"../../UsedForResource/Forest/Forest_166.jpg", 256, 202, 294, 1);
            dtAll.Rows.Add("981", "FOREST", @"../../UsedForResource/Forest/Forest_167.jpg", 255, 283, 116, 1);
            dtAll.Rows.Add("982", "FOREST", @"../../UsedForResource/Forest/Forest_168.jpg", 258, 99, 253, 1);
            dtAll.Rows.Add("983", "FOREST", @"../../UsedForResource/Forest/Forest_169.jpg", 57, 334, 152, 0);
            dtAll.Rows.Add("984", "FOREST", @"../../UsedForResource/Forest/Forest_170.jpg", 273, 113, 233, 0);
            dtAll.Rows.Add("985", "FOREST", @"../../UsedForResource/Forest/Forest_171.jpg", 161, 351, 223, 1);
            dtAll.Rows.Add("986", "FOREST", @"../../UsedForResource/Forest/Forest_172.jpg", 98, 98, 171, 0);
            dtAll.Rows.Add("987", "FOREST", @"../../UsedForResource/Forest/Forest_173.jpg", 216, 223, 181, 0);
            dtAll.Rows.Add("988", "FOREST", @"../../UsedForResource/Forest/Forest_174.jpg", 292, 138, 174, 1);
            dtAll.Rows.Add("989", "FOREST", @"../../UsedForResource/Forest/Forest_175.jpg", 183, 325, 213, 1);
            dtAll.Rows.Add("990", "FOREST", @"../../UsedForResource/Forest/Forest_176.jpg", 136, 90, 243, 1);
            dtAll.Rows.Add("991", "FOREST", @"../../UsedForResource/Forest/Forest_177.jpg", 96, 231, 186, 1);
            dtAll.Rows.Add("992", "FOREST", @"../../UsedForResource/Forest/Forest_178.jpg", 84, 324, 306, 0);
            dtAll.Rows.Add("993", "FOREST", @"../../UsedForResource/Forest/Forest_179.jpg", 198, 263, 163, 1);
            dtAll.Rows.Add("994", "FOREST", @"../../UsedForResource/Forest/Forest_180.jpg", 223, 243, 276, 1);
            dtAll.Rows.Add("995", "FOREST", @"../../UsedForResource/Forest/Forest_181.jpg", 147, 83, 149, 1);
            dtAll.Rows.Add("996", "FOREST", @"../../UsedForResource/Forest/Forest_182.jpg", 122, 298, 228, 0);
            dtAll.Rows.Add("997", "FOREST", @"../../UsedForResource/Forest/Forest_183.jpg", 127, 206, 162, 0);
            dtAll.Rows.Add("998", "FOREST", @"../../UsedForResource/Forest/Forest_184.jpg", 162, 89, 348, 0);
            dtAll.Rows.Add("999", "FOREST", @"../../UsedForResource/Forest/Forest_185.jpg", 287, 221, 177, 0);
            dtAll.Rows.Add("1000", "FOREST", @"../../UsedForResource/Forest/Forest_186.jpg", 166, 153, 167, 1);
            dtAll.Rows.Add("1001", "FOREST", @"../../UsedForResource/Forest/Forest_187.jpg", 120, 84, 266, 0);
            dtAll.Rows.Add("1002", "FOREST", @"../../UsedForResource/Forest/Forest_188.jpg", 137, 378, 190, 0);
            dtAll.Rows.Add("1003", "FOREST", @"../../UsedForResource/Forest/Forest_189.jpg", 115, 369, 311, 1);
            dtAll.Rows.Add("1004", "FOREST", @"../../UsedForResource/Forest/Forest_190.jpg", 294, 128, 157, 1);
            dtAll.Rows.Add("1005", "FOREST", @"../../UsedForResource/Forest/Forest_191.jpg", 225, 391, 151, 0);
            dtAll.Rows.Add("1006", "FOREST", @"../../UsedForResource/Forest/Forest_192.jpg", 82, 134, 296, 1);
            dtAll.Rows.Add("1007", "FOREST", @"../../UsedForResource/Forest/Forest_193.jpg", 281, 268, 307, 0);
            dtAll.Rows.Add("1008", "FOREST", @"../../UsedForResource/Forest/Forest_194.jpg", 143, 273, 346, 0);
            dtAll.Rows.Add("1009", "FOREST", @"../../UsedForResource/Forest/Forest_195.jpg", 121, 203, 201, 0);
            dtAll.Rows.Add("1010", "FOREST", @"../../UsedForResource/Forest/Forest_196.jpg", 167, 291, 339, 1);
            dtAll.Rows.Add("1011", "FOREST", @"../../UsedForResource/Forest/Forest_197.jpg", 130, 327, 106, 0);
            dtAll.Rows.Add("1012", "FOREST", @"../../UsedForResource/Forest/Forest_198.jpg", 94, 398, 291, 0);
            dtAll.Rows.Add("1013", "FOREST", @"../../UsedForResource/Forest/Forest_199.jpg", 172, 314, 224, 1);
            dtAll.Rows.Add("1014", "FOREST", @"../../UsedForResource/Forest/Forest_200.jpg", 274, 210, 261, 0);
            dtAll.Rows.Add("1015", "FOREST", @"../../UsedForResource/Forest/Forest_201.jpg", 197, 125, 246, 0);
            dtAll.Rows.Add("1016", "FOREST", @"../../UsedForResource/Forest/Forest_202.jpg", 158, 285, 319, 0);
            dtAll.Rows.Add("1017", "FOREST", @"../../UsedForResource/Forest/Forest_203.jpg", 117, 166, 345, 1);
            dtAll.Rows.Add("1018", "FOREST", @"../../UsedForResource/Forest/Forest_204.jpg", 135, 329, 221, 1);
            dtAll.Rows.Add("1019", "FOREST", @"../../UsedForResource/Forest/Forest_205.jpg", 52, 297, 250, 0);
            dtAll.Rows.Add("1020", "FLOWER", @"../../UsedForResource/Flower/Flower_1.jpg", 62, 245, 396, 1);
            dtAll.Rows.Add("1021", "FLOWER", @"../../UsedForResource/Flower/Flower_2.jpg", 103, 244, 164, 0);
            dtAll.Rows.Add("1022", "FLOWER", @"../../UsedForResource/Flower/Flower_3.jpg", 201, 184, 274, 0);
            dtAll.Rows.Add("1023", "FLOWER", @"../../UsedForResource/Flower/Flower_4.jpg", 170, 379, 291, 1);
            dtAll.Rows.Add("1024", "FLOWER", @"../../UsedForResource/Flower/Flower_5.jpg", 74, 252, 371, 0);
            dtAll.Rows.Add("1025", "FLOWER", @"../../UsedForResource/Flower/Flower_6.jpg", 81, 312, 252, 0);
            dtAll.Rows.Add("1026", "FLOWER", @"../../UsedForResource/Flower/Flower_7.jpg", 196, 321, 209, 1);
            dtAll.Rows.Add("1027", "FLOWER", @"../../UsedForResource/Flower/Flower_8.jpg", 84, 272, 369, 1);
            dtAll.Rows.Add("1028", "FLOWER", @"../../UsedForResource/Flower/Flower_9.jpg", 126, 275, 175, 1);
            dtAll.Rows.Add("1029", "FLOWER", @"../../UsedForResource/Flower/Flower_10.jpg", 86, 276, 346, 1);
            dtAll.Rows.Add("1030", "FLOWER", @"../../UsedForResource/Flower/Flower_11.jpg", 136, 346, 240, 0);
            dtAll.Rows.Add("1031", "FLOWER", @"../../UsedForResource/Flower/Flower_12.jpg", 131, 194, 182, 0);
            dtAll.Rows.Add("1032", "FLOWER", @"../../UsedForResource/Flower/Flower_13.jpg", 70, 251, 408, 1);
            dtAll.Rows.Add("1033", "FLOWER", @"../../UsedForResource/Flower/Flower_14.jpg", 182, 316, 362, 1);
            dtAll.Rows.Add("1034", "FLOWER", @"../../UsedForResource/Flower/Flower_15.jpg", 216, 295, 394, 1);
            dtAll.Rows.Add("1035", "FLOWER", @"../../UsedForResource/Flower/Flower_16.jpg", 225, 371, 187, 1);
            dtAll.Rows.Add("1036", "FLOWER", @"../../UsedForResource/Flower/Flower_17.jpg", 69, 218, 307, 0);
            dtAll.Rows.Add("1037", "FLOWER", @"../../UsedForResource/Flower/Flower_18.jpg", 111, 122, 272, 1);
            dtAll.Rows.Add("1038", "FLOWER", @"../../UsedForResource/Flower/Flower_19.jpg", 129, 215, 349, 0);
            dtAll.Rows.Add("1039", "FLOWER", @"../../UsedForResource/Flower/Flower_20.jpg", 192, 361, 409, 1);
            dtAll.Rows.Add("1040", "FLOWER", @"../../UsedForResource/Flower/Flower_21.jpg", 157, 367, 180, 0);
            dtAll.Rows.Add("1041", "FLOWER", @"../../UsedForResource/Flower/Flower_22.jpg", 47, 389, 360, 1);
            dtAll.Rows.Add("1042", "FLOWER", @"../../UsedForResource/Flower/Flower_23.jpg", 133, 249, 379, 1);
            dtAll.Rows.Add("1043", "FLOWER", @"../../UsedForResource/Flower/Flower_24.jpg", 150, 271, 338, 1);
            dtAll.Rows.Add("1044", "FLOWER", @"../../UsedForResource/Flower/Flower_25.jpg", 121, 230, 418, 0);
            dtAll.Rows.Add("1045", "FLOWER", @"../../UsedForResource/Flower/Flower_26.jpg", 93, 139, 380, 1);
            dtAll.Rows.Add("1046", "FLOWER", @"../../UsedForResource/Flower/Flower_27.jpg", 212, 349, 184, 1);
            dtAll.Rows.Add("1047", "FLOWER", @"../../UsedForResource/Flower/Flower_28.jpg", 76, 360, 376, 1);
            dtAll.Rows.Add("1048", "FLOWER", @"../../UsedForResource/Flower/Flower_29.jpg", 220, 280, 340, 1);
            dtAll.Rows.Add("1049", "FLOWER", @"../../UsedForResource/Flower/Flower_30.jpg", 153, 357, 366, 1);
            dtAll.Rows.Add("1050", "FLOWER", @"../../UsedForResource/Flower/Flower_31.jpg", 195, 355, 304, 1);
            dtAll.Rows.Add("1051", "FLOWER", @"../../UsedForResource/Flower/Flower_32.jpg", 208, 202, 337, 0);
            dtAll.Rows.Add("1052", "FLOWER", @"../../UsedForResource/Flower/Flower_33.jpg", 174, 370, 210, 1);
            dtAll.Rows.Add("1053", "FLOWER", @"../../UsedForResource/Flower/Flower_34.jpg", 96, 135, 324, 1);
            dtAll.Rows.Add("1054", "FLOWER", @"../../UsedForResource/Flower/Flower_35.jpg", 88, 125, 224, 0);
            dtAll.Rows.Add("1055", "FLOWER", @"../../UsedForResource/Flower/Flower_36.jpg", 61, 297, 301, 1);
            dtAll.Rows.Add("1056", "FLOWER", @"../../UsedForResource/Flower/Flower_37.jpg", 90, 182, 206, 1);
            dtAll.Rows.Add("1057", "FLOWER", @"../../UsedForResource/Flower/Flower_38.jpg", 213, 342, 218, 0);
            dtAll.Rows.Add("1058", "FLOWER", @"../../UsedForResource/Flower/Flower_39.jpg", 151, 130, 246, 0);
            dtAll.Rows.Add("1059", "FLOWER", @"../../UsedForResource/Flower/Flower_40.jpg", 214, 142, 151, 1);
            dtAll.Rows.Add("1060", "FLOWER", @"../../UsedForResource/Flower/Flower_41.jpg", 163, 123, 199, 1);
            dtAll.Rows.Add("1061", "FLOWER", @"../../UsedForResource/Flower/Flower_42.jpg", 175, 376, 231, 1);
            dtAll.Rows.Add("1062", "FLOWER", @"../../UsedForResource/Flower/Flower_43.jpg", 148, 136, 260, 0);
            dtAll.Rows.Add("1063", "FLOWER", @"../../UsedForResource/Flower/Flower_44.jpg", 227, 293, 235, 1);
            dtAll.Rows.Add("1064", "FLOWER", @"../../UsedForResource/Flower/Flower_45.jpg", 149, 213, 368, 0);
            dtAll.Rows.Add("1065", "FLOWER", @"../../UsedForResource/Flower/Flower_46.jpg", 210, 228, 326, 1);
            dtAll.Rows.Add("1066", "FLOWER", @"../../UsedForResource/Flower/Flower_47.jpg", 41, 359, 364, 1);
            dtAll.Rows.Add("1067", "FLOWER", @"../../UsedForResource/Flower/Flower_48.jpg", 145, 192, 155, 0);
            dtAll.Rows.Add("1068", "FLOWER", @"../../UsedForResource/Flower/Flower_49.jpg", 209, 190, 241, 0);
            dtAll.Rows.Add("1069", "FLOWER", @"../../UsedForResource/Flower/Flower_50.jpg", 97, 305, 321, 1);
            dtAll.Rows.Add("1070", "FLOWER", @"../../UsedForResource/Flower/Flower_51.jpg", 89, 199, 261, 0);
            dtAll.Rows.Add("1071", "FLOWER", @"../../UsedForResource/Flower/Flower_52.jpg", 171, 154, 315, 1);
            dtAll.Rows.Add("1072", "FLOWER", @"../../UsedForResource/Flower/Flower_53.jpg", 119, 161, 344, 0);
            dtAll.Rows.Add("1073", "FLOWER", @"../../UsedForResource/Flower/Flower_54.jpg", 207, 339, 165, 0);
            dtAll.Rows.Add("1074", "FLOWER", @"../../UsedForResource/Flower/Flower_55.jpg", 78, 155, 259, 0);
            dtAll.Rows.Add("1075", "FLOWER", @"../../UsedForResource/Flower/Flower_56.jpg", 199, 224, 158, 1);
            dtAll.Rows.Add("1076", "FLOWER", @"../../UsedForResource/Flower/Flower_57.jpg", 184, 266, 414, 0);
            dtAll.Rows.Add("1077", "FLOWER", @"../../UsedForResource/Flower/Flower_58.jpg", 142, 333, 286, 0);
            dtAll.Rows.Add("1078", "FLOWER", @"../../UsedForResource/Flower/Flower_59.jpg", 178, 282, 402, 1);
            dtAll.Rows.Add("1079", "FLOWER", @"../../UsedForResource/Flower/Flower_60.jpg", 141, 127, 179, 1);
            dtAll.Rows.Add("1080", "FLOWER", @"../../UsedForResource/Flower/Flower_61.jpg", 147, 377, 280, 0);
            dtAll.Rows.Add("1081", "FLOWER", @"../../UsedForResource/Flower/Flower_62.jpg", 101, 144, 297, 0);
            dtAll.Rows.Add("1082", "FLOWER", @"../../UsedForResource/Flower/Flower_63.jpg", 162, 181, 211, 1);
            dtAll.Rows.Add("1083", "FLOWER", @"../../UsedForResource/Flower/Flower_64.jpg", 224, 222, 216, 0);
            dtAll.Rows.Add("1084", "FLOWER", @"../../UsedForResource/Flower/Flower_65.jpg", 75, 314, 289, 1);
            dtAll.Rows.Add("1085", "FLOWER", @"../../UsedForResource/Flower/Flower_66.jpg", 57, 147, 390, 1);
            dtAll.Rows.Add("1086", "FLOWER", @"../../UsedForResource/Flower/Flower_67.jpg", 105, 170, 397, 1);
            dtAll.Rows.Add("1087", "FLOWER", @"../../UsedForResource/Flower/Flower_68.jpg", 167, 356, 194, 1);
            dtAll.Rows.Add("1088", "FLOWER", @"../../UsedForResource/Flower/Flower_69.jpg", 161, 250, 389, 1);
            dtAll.Rows.Add("1089", "FLOWER", @"../../UsedForResource/Flower/Flower_70.jpg", 114, 242, 183, 1);
            dtAll.Rows.Add("1090", "FLOWER", @"../../UsedForResource/Flower/Flower_71.jpg", 110, 304, 399, 0);
            dtAll.Rows.Add("1091", "FLOWER", @"../../UsedForResource/Flower/Flower_72.jpg", 116, 231, 192, 1);
            dtAll.Rows.Add("1092", "FLOWER", @"../../UsedForResource/Flower/Flower_73.jpg", 180, 315, 162, 0);
            dtAll.Rows.Add("1093", "FLOWER", @"../../UsedForResource/Flower/Flower_74.jpg", 67, 209, 300, 1);
            dtAll.Rows.Add("1094", "FLOWER", @"../../UsedForResource/Flower/Flower_75.jpg", 152, 175, 258, 1);
            dtAll.Rows.Add("1095", "FLOWER", @"../../UsedForResource/Flower/Flower_76.jpg", 80, 237, 153, 1);
            dtAll.Rows.Add("1096", "FLOWER", @"../../UsedForResource/Flower/Flower_77.jpg", 197, 289, 267, 0);
            dtAll.Rows.Add("1097", "FLOWER", @"../../UsedForResource/Flower/Flower_78.jpg", 99, 148, 283, 0);
            dtAll.Rows.Add("1098", "FLOWER", @"../../UsedForResource/Flower/Flower_79.jpg", 124, 302, 222, 0);
            dtAll.Rows.Add("1099", "FLOWER", @"../../UsedForResource/Flower/Flower_80.jpg", 186, 166, 417, 0);
            dtAll.Rows.Add("1100", "FLOWER", @"../../UsedForResource/Flower/Flower_81.jpg", 203, 216, 238, 1);
            dtAll.Rows.Add("1101", "FLOWER", @"../../UsedForResource/Flower/Flower_82.jpg", 106, 325, 345, 1);
            dtAll.Rows.Add("1102", "FLOWER", @"../../UsedForResource/Flower/Flower_83.jpg", 194, 388, 214, 1);
            dtAll.Rows.Add("1103", "FLOWER", @"../../UsedForResource/Flower/Flower_84.jpg", 118, 157, 342, 1);
            dtAll.Rows.Add("1104", "FLOWER", @"../../UsedForResource/Flower/Flower_85.jpg", 215, 299, 311, 0);
            dtAll.Rows.Add("1105", "FLOWER", @"../../UsedForResource/Flower/Flower_86.jpg", 45, 277, 181, 1);
            dtAll.Rows.Add("1106", "FLOWER", @"../../UsedForResource/Flower/Flower_87.jpg", 100, 200, 281, 0);
            dtAll.Rows.Add("1107", "FLOWER", @"../../UsedForResource/Flower/Flower_88.jpg", 173, 173, 387, 0);
            dtAll.Rows.Add("1108", "FLOWER", @"../../UsedForResource/Flower/Flower_89.jpg", 49, 334, 327, 1);
            dtAll.Rows.Add("1109", "FLOWER", @"../../UsedForResource/Flower/Flower_90.jpg", 46, 227, 243, 1);
            dtAll.Rows.Add("1110", "FLOWER", @"../../UsedForResource/Flower/Flower_91.jpg", 191, 278, 196, 0);
            dtAll.Rows.Add("1111", "FLOWER", @"../../UsedForResource/Flower/Flower_92.jpg", 123, 383, 313, 0);
            dtAll.Rows.Add("1112", "FLOWER", @"../../UsedForResource/Flower/Flower_93.jpg", 79, 329, 168, 0);
            dtAll.Rows.Add("1113", "FLOWER", @"../../UsedForResource/Flower/Flower_94.jpg", 44, 331, 287, 0);
            dtAll.Rows.Add("1114", "FLOWER", @"../../UsedForResource/Flower/Flower_95.jpg", 113, 298, 201, 1);
            dtAll.Rows.Add("1115", "FLOWER", @"../../UsedForResource/Flower/Flower_96.jpg", 64, 366, 279, 1);
            dtAll.Rows.Add("1116", "FLOWER", @"../../UsedForResource/Flower/Flower_97.jpg", 164, 207, 171, 1);
            dtAll.Rows.Add("1117", "FLOWER", @"../../UsedForResource/Flower/Flower_98.jpg", 42, 372, 263, 1);
            dtAll.Rows.Add("1118", "FLOWER", @"../../UsedForResource/Flower/Flower_99.jpg", 223, 188, 268, 0);
            dtAll.Rows.Add("1119", "FLOWER", @"../../UsedForResource/Flower/Flower_100.jpg", 60, 352, 401, 1);
            dtAll.Rows.Add("1120", "FLOWER", @"../../UsedForResource/Flower/Flower_101.jpg", 177, 235, 328, 1);
            dtAll.Rows.Add("1121", "FLOWER", @"../../UsedForResource/Flower/Flower_102.jpg", 146, 140, 302, 0);
            dtAll.Rows.Add("1122", "FLOWER", @"../../UsedForResource/Flower/Flower_103.jpg", 66, 158, 174, 1);
            dtAll.Rows.Add("1123", "FLOWER", @"../../UsedForResource/Flower/Flower_104.jpg", 51, 380, 170, 1);
            dtAll.Rows.Add("1124", "FLOWER", @"../../UsedForResource/Flower/Flower_105.jpg", 107, 197, 276, 1);
            dtAll.Rows.Add("1125", "FLOWER", @"../../UsedForResource/Flower/Flower_106.jpg", 50, 257, 294, 0);
            dtAll.Rows.Add("1126", "FLOWER", @"../../UsedForResource/Flower/Flower_107.jpg", 165, 319, 237, 0);
            dtAll.Rows.Add("1127", "FLOWER", @"../../UsedForResource/Flower/Flower_108.jpg", 132, 149, 177, 1);
            dtAll.Rows.Add("1128", "FLOWER", @"../../UsedForResource/Flower/Flower_109.jpg", 65, 368, 200, 1);
            dtAll.Rows.Add("1129", "FLOWER", @"../../UsedForResource/Flower/Flower_110.jpg", 159, 206, 186, 1);
            dtAll.Rows.Add("1130", "FLOWER", @"../../UsedForResource/Flower/Flower_111.jpg", 188, 313, 378, 0);
            dtAll.Rows.Add("1131", "FLOWER", @"../../UsedForResource/Flower/Flower_112.jpg", 117, 274, 316, 1);
            dtAll.Rows.Add("1132", "FLOWER", @"../../UsedForResource/Flower/Flower_113.jpg", 219, 374, 305, 1);
            dtAll.Rows.Add("1133", "FLOWER", @"../../UsedForResource/Flower/Flower_114.jpg", 154, 385, 419, 1);
            dtAll.Rows.Add("1134", "FLOWER", @"../../UsedForResource/Flower/Flower_115.jpg", 94, 328, 348, 1);
            dtAll.Rows.Add("1135", "FLOWER", @"../../UsedForResource/Flower/Flower_116.jpg", 54, 322, 234, 0);
            dtAll.Rows.Add("1136", "FLOWER", @"../../UsedForResource/Flower/Flower_117.jpg", 95, 281, 232, 0);
            dtAll.Rows.Add("1137", "FLOWER", @"../../UsedForResource/Flower/Flower_118.jpg", 130, 344, 208, 0);
            dtAll.Rows.Add("1138", "FLOWER", @"../../UsedForResource/Flower/Flower_119.jpg", 71, 303, 247, 0);
            dtAll.Rows.Add("1139", "FLOWER", @"../../UsedForResource/Flower/Flower_120.jpg", 52, 171, 278, 0);
            dtAll.Rows.Add("1140", "FLOWER", @"../../UsedForResource/Flower/Flower_121.jpg", 102, 320, 388, 0);
            dtAll.Rows.Add("1141", "FLOWER", @"../../UsedForResource/Flower/Flower_122.jpg", 189, 238, 405, 1);
            dtAll.Rows.Add("1142", "FLOWER", @"../../UsedForResource/Flower/Flower_123.jpg", 190, 145, 251, 1);
            dtAll.Rows.Add("1143", "FLOWER", @"../../UsedForResource/Flower/Flower_124.jpg", 58, 196, 410, 0);
            dtAll.Rows.Add("1144", "FLOWER", @"../../UsedForResource/Flower/Flower_125.jpg", 87, 132, 191, 1);
            dtAll.Rows.Add("1145", "FLOWER", @"../../UsedForResource/Flower/Flower_126.jpg", 128, 169, 335, 1);
            dtAll.Rows.Add("1146", "FLOWER", @"../../UsedForResource/Flower/Flower_127.jpg", 179, 273, 343, 1);
            dtAll.Rows.Add("1147", "FLOWER", @"../../UsedForResource/Flower/Flower_128.jpg", 109, 261, 217, 0);
            dtAll.Rows.Add("1148", "FLOWER", @"../../UsedForResource/Flower/Flower_129.jpg", 183, 165, 375, 1);
            dtAll.Rows.Add("1149", "FLOWER", @"../../UsedForResource/Flower/Flower_130.jpg", 48, 324, 320, 1);
            dtAll.Rows.Add("1150", "FLOWER", @"../../UsedForResource/Flower/Flower_131.jpg", 217, 226, 382, 1);
            dtAll.Rows.Add("1151", "FLOWER", @"../../UsedForResource/Flower/Flower_132.jpg", 221, 254, 152, 1);
            dtAll.Rows.Add("1152", "FLOWER", @"../../UsedForResource/Flower/Flower_133.jpg", 181, 183, 370, 1);
            dtAll.Rows.Add("1153", "FLOWER", @"../../UsedForResource/Flower/Flower_134.jpg", 198, 270, 203, 1);
            dtAll.Rows.Add("1154", "FLOWER", @"../../UsedForResource/Flower/Flower_135.jpg", 98, 288, 161, 0);
            dtAll.Rows.Add("1155", "FLOWER", @"../../UsedForResource/Flower/Flower_136.jpg", 73, 264, 197, 1);
            dtAll.Rows.Add("1156", "FLOWER", @"../../UsedForResource/Flower/Flower_137.jpg", 40, 124, 306, 0);
            dtAll.Rows.Add("1157", "FLOWER", @"../../UsedForResource/Flower/Flower_138.jpg", 137, 335, 185, 0);
            dtAll.Rows.Add("1158", "FLOWER", @"../../UsedForResource/Flower/Flower_139.jpg", 92, 150, 166, 0);
            dtAll.Rows.Add("1159", "FLOWER", @"../../UsedForResource/Flower/Flower_140.jpg", 187, 301, 355, 1);
            dtAll.Rows.Add("1160", "FLOWER", @"../../UsedForResource/Flower/Flower_141.jpg", 53, 248, 303, 1);
            dtAll.Rows.Add("1161", "FLOWER", @"../../UsedForResource/Flower/Flower_142.jpg", 83, 294, 299, 0);
            dtAll.Rows.Add("1162", "FLOWER", @"../../UsedForResource/Flower/Flower_143.jpg", 172, 353, 400, 1);
            dtAll.Rows.Add("1163", "FLOWER", @"../../UsedForResource/Flower/Flower_144.jpg", 144, 327, 160, 0);
            dtAll.Rows.Add("1164", "FLOWER", @"../../UsedForResource/Flower/Flower_145.jpg", 115, 351, 404, 0);
            dtAll.Rows.Add("1165", "FLOWER", @"../../UsedForResource/Flower/Flower_146.jpg", 82, 134, 329, 1);
            dtAll.Rows.Add("1166", "FLOWER", @"../../UsedForResource/Flower/Flower_147.jpg", 134, 189, 188, 0);
            dtAll.Rows.Add("1167", "FLOWER", @"../../UsedForResource/Flower/Flower_148.jpg", 205, 279, 229, 1);
            dtAll.Rows.Add("1168", "FLOWER", @"../../UsedForResource/Flower/Flower_149.jpg", 140, 255, 271, 1);
            dtAll.Rows.Add("1169", "FLOWER", @"../../UsedForResource/Flower/Flower_150.jpg", 226, 239, 403, 1);
            dtAll.Rows.Add("1170", "FLOWER", @"../../UsedForResource/Flower/Flower_151.jpg", 68, 265, 398, 1);
            dtAll.Rows.Add("1171", "FLOWER", @"../../UsedForResource/Flower/Flower_152.jpg", 193, 208, 167, 1);
            dtAll.Rows.Add("1172", "FLOWER", @"../../UsedForResource/Flower/Flower_153.jpg", 156, 256, 159, 0);
            dtAll.Rows.Add("1173", "FLOWER", @"../../UsedForResource/Flower/Flower_154.jpg", 228, 159, 233, 1);
            dtAll.Rows.Add("1174", "FLOWER", @"../../UsedForResource/Flower/Flower_155.jpg", 160, 156, 242, 0);
            dtAll.Rows.Add("1175", "FLOWER", @"../../UsedForResource/Flower/Flower_156.jpg", 72, 211, 277, 0);
            dtAll.Rows.Add("1176", "FLOWER", @"../../UsedForResource/Flower/Flower_157.jpg", 204, 141, 352, 0);
            dtAll.Rows.Add("1177", "FLOWER", @"../../UsedForResource/Flower/Flower_158.jpg", 56, 387, 154, 0);
            dtAll.Rows.Add("1178", "FLOWER", @"../../UsedForResource/Flower/Flower_159.jpg", 63, 129, 178, 1);


            //////////////////////////////////////////////ADD DATA FOR INTERIOR CATEGORIZED///////////////////////////////////////////////////////////
            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            dtInterior.Rows.Add("1", "INTERIOR", @"../../UsedForResource/Interior/Interior_1.jpg", 114, 181, 280, 0);

            dtInterior.Rows.Add("2", "INTERIOR", @"../../UsedForResource/Interior/Interior_2.jpg", 118, 282, 130, 0);

            dtInterior.Rows.Add("3", "INTERIOR", @"../../UsedForResource/Interior/Interior_3.jpg", 161, 171, 178, 1);

            dtInterior.Rows.Add("4", "INTERIOR", @"../../UsedForResource/Interior/Interior_4.jpg", 78, 130, 284, 0);

            dtInterior.Rows.Add("5", "INTERIOR", @"../../UsedForResource/Interior/Interior_5.jpg", 236, 87, 129, 1);

            dtInterior.Rows.Add("6", "INTERIOR", @"../../UsedForResource/Interior/Interior_6.jpg", 49, 99, 68, 0);

            dtInterior.Rows.Add("7", "INTERIOR", @"../../UsedForResource/Interior/Interior_7.jpg", 126, 262, 267, 0);

            dtInterior.Rows.Add("8", "INTERIOR", @"../../UsedForResource/Interior/Interior_8.jpg", 101, 72, 64, 1);

            dtInterior.Rows.Add("9", "INTERIOR", @"../../UsedForResource/Interior/Interior_9.jpg", 211, 280, 65, 1);

            dtInterior.Rows.Add("10", "INTERIOR", @"../../UsedForResource/Interior/Interior_10.jpg", 68, 169, 253, 1);

            dtInterior.Rows.Add("11", "INTERIOR", @"../../UsedForResource/Interior/Interior_11.jpg", 219, 270, 238, 0);

            dtInterior.Rows.Add("12", "INTERIOR", @"../../UsedForResource/Interior/Interior_12.jpg", 62, 195, 61, 0);

            dtInterior.Rows.Add("13", "INTERIOR", @"../../UsedForResource/Interior/Interior_13.jpg", 129, 278, 275, 1);

            dtInterior.Rows.Add("14", "INTERIOR", @"../../UsedForResource/Interior/Interior_14.jpg", 218, 133, 63, 1);

            dtInterior.Rows.Add("15", "INTERIOR", @"../../UsedForResource/Interior/Interior_15.jpg", 156, 190, 209, 1);

            dtInterior.Rows.Add("16", "INTERIOR", @"../../UsedForResource/Interior/Interior_16.jpg", 58, 269, 105, 0);

            dtInterior.Rows.Add("17", "INTERIOR", @"../../UsedForResource/Interior/Interior_17.jpg", 109, 253, 247, 1);

            dtInterior.Rows.Add("18", "INTERIOR", @"../../UsedForResource/Interior/Interior_18.jpg", 182, 273, 184, 0);

            dtInterior.Rows.Add("19", "INTERIOR", @"../../UsedForResource/Interior/Interior_19.jpg", 117, 158, 98, 1);

            dtInterior.Rows.Add("20", "INTERIOR", @"../../UsedForResource/Interior/Interior_20.jpg", 137, 107, 97, 1);

            dtInterior.Rows.Add("21", "INTERIOR", @"../../UsedForResource/Interior/Interior_21.jpg", 133, 229, 136, 1);

            dtInterior.Rows.Add("22", "INTERIOR", @"../../UsedForResource/Interior/Interior_22.jpg", 190, 96, 214, 0);

            dtInterior.Rows.Add("23", "INTERIOR", @"../../UsedForResource/Interior/Interior_23.jpg", 204, 86, 251, 0);

            dtInterior.Rows.Add("24", "INTERIOR", @"../../UsedForResource/Interior/Interior_24.jpg", 104, 124, 202, 0);

            dtInterior.Rows.Add("25", "INTERIOR", @"../../UsedForResource/Interior/Interior_25.jpg", 107, 70, 221, 1);

            dtInterior.Rows.Add("26", "INTERIOR", @"../../UsedForResource/Interior/Interior_26.jpg", 206, 74, 123, 1);

            dtInterior.Rows.Add("27", "INTERIOR", @"../../UsedForResource/Interior/Interior_27.jpg", 265, 63, 278, 1);

            dtInterior.Rows.Add("28", "INTERIOR", @"../../UsedForResource/Interior/Interior_28.jpg", 217, 128, 274, 1);

            dtInterior.Rows.Add("29", "INTERIOR", @"../../UsedForResource/Interior/Interior_29.jpg", 208, 125, 268, 0);

            dtInterior.Rows.Add("30", "INTERIOR", @"../../UsedForResource/Interior/Interior_30.jpg", 92, 196, 74, 0);

            dtInterior.Rows.Add("31", "INTERIOR", @"../../UsedForResource/Interior/Interior_31.jpg", 96, 147, 179, 1);

            dtInterior.Rows.Add("32", "INTERIOR", @"../../UsedForResource/Interior/Interior_32.jpg", 155, 161, 120, 1);

            dtInterior.Rows.Add("33", "INTERIOR", @"../../UsedForResource/Interior/Interior_33.jpg", 268, 143, 246, 1);

            dtInterior.Rows.Add("34", "INTERIOR", @"../../UsedForResource/Interior/Interior_34.jpg", 139, 140, 82, 1);

            dtInterior.Rows.Add("35", "INTERIOR", @"../../UsedForResource/Interior/Interior_35.jpg", 150, 193, 222, 1);

            dtInterior.Rows.Add("36", "INTERIOR", @"../../UsedForResource/Interior/Interior_36.jpg", 207, 226, 223, 0);

            dtInterior.Rows.Add("37", "INTERIOR", @"../../UsedForResource/Interior/Interior_37.jpg", 216, 127, 144, 1);

            dtInterior.Rows.Add("38", "INTERIOR", @"../../UsedForResource/Interior/Interior_38.jpg", 84, 100, 269, 1);

            dtInterior.Rows.Add("39", "INTERIOR", @"../../UsedForResource/Interior/Interior_39.jpg", 239, 299, 174, 0);

            dtInterior.Rows.Add("40", "INTERIOR", @"../../UsedForResource/Interior/Interior_40.jpg", 235, 219, 72, 0);

            dtInterior.Rows.Add("41", "INTERIOR", @"../../UsedForResource/Interior/Interior_41.jpg", 192, 134, 141, 1);

            dtInterior.Rows.Add("42", "INTERIOR", @"../../UsedForResource/Interior/Interior_42.jpg", 61, 129, 106, 0);

            dtInterior.Rows.Add("43", "INTERIOR", @"../../UsedForResource/Interior/Interior_43.jpg", 82, 105, 96, 1);

            dtInterior.Rows.Add("44", "INTERIOR", @"../../UsedForResource/Interior/Interior_44.jpg", 136, 62, 263, 1);

            dtInterior.Rows.Add("45", "INTERIOR", @"../../UsedForResource/Interior/Interior_45.jpg", 229, 88, 54, 0);

            dtInterior.Rows.Add("46", "INTERIOR", @"../../UsedForResource/Interior/Interior_46.jpg", 97, 183, 99, 1);

            dtInterior.Rows.Add("47", "INTERIOR", @"../../UsedForResource/Interior/Interior_47.jpg", 149, 218, 85, 0);

            dtInterior.Rows.Add("48", "INTERIOR", @"../../UsedForResource/Interior/Interior_48.jpg", 140, 259, 160, 0);

            dtInterior.Rows.Add("49", "INTERIOR", @"../../UsedForResource/Interior/Interior_49.jpg", 64, 230, 88, 1);

            dtInterior.Rows.Add("50", "INTERIOR", @"../../UsedForResource/Interior/Interior_50.jpg", 128, 263, 197, 0);

            dtInterior.Rows.Add("51", "INTERIOR", @"../../UsedForResource/Interior/Interior_51.jpg", 143, 155, 66, 0);

            dtInterior.Rows.Add("52", "INTERIOR", @"../../UsedForResource/Interior/Interior_52.jpg", 106, 201, 175, 0);

            dtInterior.Rows.Add("53", "INTERIOR", @"../../UsedForResource/Interior/Interior_53.jpg", 212, 266, 67, 1);

            dtInterior.Rows.Add("54", "INTERIOR", @"../../UsedForResource/Interior/Interior_54.jpg", 200, 255, 211, 1);

            dtInterior.Rows.Add("55", "INTERIOR", @"../../UsedForResource/Interior/Interior_55.jpg", 170, 178, 112, 0);

            dtInterior.Rows.Add("56", "INTERIOR", @"../../UsedForResource/Interior/Interior_56.jpg", 171, 296, 273, 0);

            dtInterior.Rows.Add("57", "INTERIOR", @"../../UsedForResource/Interior/Interior_57.jpg", 154, 98, 264, 0);

            dtInterior.Rows.Add("58", "INTERIOR", @"../../UsedForResource/Interior/Interior_58.jpg", 103, 60, 143, 1);

            dtInterior.Rows.Add("59", "INTERIOR", @"../../UsedForResource/Interior/Interior_59.jpg", 210, 148, 148, 0);

            dtInterior.Rows.Add("60", "INTERIOR", @"../../UsedForResource/Interior/Interior_60.jpg", 199, 137, 117, 0);

            dtInterior.Rows.Add("61", "INTERIOR", @"../../UsedForResource/Interior/Interior_61.jpg", 247, 245, 216, 1);

            dtInterior.Rows.Add("62", "INTERIOR", @"../../UsedForResource/Interior/Interior_62.jpg", 45, 113, 282, 1);

            dtInterior.Rows.Add("63", "INTERIOR", @"../../UsedForResource/Interior/Interior_63.jpg", 43, 223, 256, 0);

            dtInterior.Rows.Add("64", "INTERIOR", @"../../UsedForResource/Interior/Interior_64.jpg", 37, 274, 177, 1);

            dtInterior.Rows.Add("65", "INTERIOR", @"../../UsedForResource/Interior/Interior_65.jpg", 98, 164, 71, 0);

            dtInterior.Rows.Add("66", "INTERIOR", @"../../UsedForResource/Interior/Interior_66.jpg", 81, 233, 205, 1);

            dtInterior.Rows.Add("67", "INTERIOR", @"../../UsedForResource/Interior/Interior_67.jpg", 166, 123, 185, 0);

            dtInterior.Rows.Add("68", "INTERIOR", @"../../UsedForResource/Interior/Interior_68.jpg", 70, 154, 138, 0);

            dtInterior.Rows.Add("69", "INTERIOR", @"../../UsedForResource/Interior/Interior_69.jpg", 231, 132, 128, 0);

            dtInterior.Rows.Add("70", "INTERIOR", @"../../UsedForResource/Interior/Interior_70.jpg", 65, 150, 257, 0);

            dtInterior.Rows.Add("71", "INTERIOR", @"../../UsedForResource/Interior/Interior_71.jpg", 120, 254, 121, 1);

            dtInterior.Rows.Add("72", "INTERIOR", @"../../UsedForResource/Interior/Interior_72.jpg", 245, 152, 146, 0);

            dtInterior.Rows.Add("73", "INTERIOR", @"../../UsedForResource/Interior/Interior_73.jpg", 145, 71, 133, 0);

            dtInterior.Rows.Add("74", "INTERIOR", @"../../UsedForResource/Interior/Interior_74.jpg", 176, 206, 86, 1);

            dtInterior.Rows.Add("75", "INTERIOR", @"../../UsedForResource/Interior/Interior_75.jpg", 263, 281, 265, 0);

            dtInterior.Rows.Add("76", "INTERIOR", @"../../UsedForResource/Interior/Interior_76.jpg", 60, 119, 287, 1);

            dtInterior.Rows.Add("77", "INTERIOR", @"../../UsedForResource/Interior/Interior_77.jpg", 241, 200, 145, 0);

            dtInterior.Rows.Add("78", "INTERIOR", @"../../UsedForResource/Interior/Interior_78.jpg", 34, 101, 169, 0);

            dtInterior.Rows.Add("79", "INTERIOR", @"../../UsedForResource/Interior/Interior_79.jpg", 110, 115, 183, 1);

            dtInterior.Rows.Add("80", "INTERIOR", @"../../UsedForResource/Interior/Interior_80.jpg", 69, 209, 207, 1);

            dtInterior.Rows.Add("81", "INTERIOR", @"../../UsedForResource/Interior/Interior_81.jpg", 76, 122, 81, 1);

            dtInterior.Rows.Add("82", "INTERIOR", @"../../UsedForResource/Interior/Interior_82.jpg", 159, 260, 163, 1);

            dtInterior.Rows.Add("83", "INTERIOR", @"../../UsedForResource/Interior/Interior_83.jpg", 202, 108, 272, 1);

            dtInterior.Rows.Add("84", "INTERIOR", @"../../UsedForResource/Interior/Interior_84.jpg", 260, 207, 276, 1);

            dtInterior.Rows.Add("85", "INTERIOR", @"../../UsedForResource/Interior/Interior_85.jpg", 113, 67, 241, 1);

            dtInterior.Rows.Add("86", "INTERIOR", @"../../UsedForResource/Interior/Interior_86.jpg", 196, 157, 193, 1);

            dtInterior.Rows.Add("87", "INTERIOR", @"../../UsedForResource/Interior/Interior_87.jpg", 59, 85, 219, 1);

            dtInterior.Rows.Add("88", "INTERIOR", @"../../UsedForResource/Interior/Interior_88.jpg", 33, 180, 89, 0);

            dtInterior.Rows.Add("89", "INTERIOR", @"../../UsedForResource/Interior/Interior_89.jpg", 179, 141, 108, 0);

            dtInterior.Rows.Add("90", "INTERIOR", @"../../UsedForResource/Interior/Interior_90.jpg", 35, 283, 215, 0);

            dtInterior.Rows.Add("91", "INTERIOR", @"../../UsedForResource/Interior/Interior_91.jpg", 250, 222, 261, 1);

            dtInterior.Rows.Add("92", "INTERIOR", @"../../UsedForResource/Interior/Interior_92.jpg", 83, 272, 232, 0);

            dtInterior.Rows.Add("93", "INTERIOR", @"../../UsedForResource/Interior/Interior_93.jpg", 209, 251, 244, 1);

            dtInterior.Rows.Add("94", "INTERIOR", @"../../UsedForResource/Interior/Interior_94.jpg", 151, 90, 208, 0);

            dtInterior.Rows.Add("95", "INTERIOR", @"../../UsedForResource/Interior/Interior_95.jpg", 164, 173, 94, 1);

            dtInterior.Rows.Add("96", "INTERIOR", @"../../UsedForResource/Interior/Interior_96.jpg", 222, 243, 153, 1);

            dtInterior.Rows.Add("97", "INTERIOR", @"../../UsedForResource/Interior/Interior_97.jpg", 48, 172, 188, 0);

            dtInterior.Rows.Add("98", "INTERIOR", @"../../UsedForResource/Interior/Interior_98.jpg", 38, 198, 289, 0);

            dtInterior.Rows.Add("99", "INTERIOR", @"../../UsedForResource/Interior/Interior_99.jpg", 238, 61, 76, 1);

            dtInterior.Rows.Add("100", "INTERIOR", @"../../UsedForResource/Interior/Interior_100.jpg", 79, 83, 137, 0);

            dtInterior.Rows.Add("101", "INTERIOR", @"../../UsedForResource/Interior/Interior_101.jpg", 36, 256, 277, 1);

            dtInterior.Rows.Add("102", "INTERIOR", @"../../UsedForResource/Interior/Interior_102.jpg", 50, 225, 239, 0);

            dtInterior.Rows.Add("103", "INTERIOR", @"../../UsedForResource/Interior/Interior_103.jpg", 187, 139, 189, 1);

            dtInterior.Rows.Add("104", "INTERIOR", @"../../UsedForResource/Interior/Interior_104.jpg", 74, 279, 286, 1);

            dtInterior.Rows.Add("105", "INTERIOR", @"../../UsedForResource/Interior/Interior_105.jpg", 100, 192, 220, 0);

            dtInterior.Rows.Add("106", "INTERIOR", @"../../UsedForResource/Interior/Interior_106.jpg", 142, 217, 91, 1);

            dtInterior.Rows.Add("107", "INTERIOR", @"../../UsedForResource/Interior/Interior_107.jpg", 116, 69, 180, 1);

            dtInterior.Rows.Add("108", "INTERIOR", @"../../UsedForResource/Interior/Interior_108.jpg", 230, 168, 237, 0);

            dtInterior.Rows.Add("109", "INTERIOR", @"../../UsedForResource/Interior/Interior_109.jpg", 225, 276, 107, 0);

            dtInterior.Rows.Add("110", "INTERIOR", @"../../UsedForResource/Interior/Interior_110.jpg", 31, 145, 248, 0);

            dtInterior.Rows.Add("111", "INTERIOR", @"../../UsedForResource/Interior/Interior_111.jpg", 148, 126, 186, 1);

            dtInterior.Rows.Add("112", "INTERIOR", @"../../UsedForResource/Interior/Interior_112.jpg", 226, 293, 240, 0);

            dtInterior.Rows.Add("113", "INTERIOR", @"../../UsedForResource/Interior/Interior_113.jpg", 119, 257, 70, 0);

            dtInterior.Rows.Add("114", "INTERIOR", @"../../UsedForResource/Interior/Interior_114.jpg", 255, 146, 242, 1);

            dtInterior.Rows.Add("115", "INTERIOR", @"../../UsedForResource/Interior/Interior_115.jpg", 141, 117, 161, 0);

            dtInterior.Rows.Add("116", "INTERIOR", @"../../UsedForResource/Interior/Interior_116.jpg", 244, 104, 172, 1);

            dtInterior.Rows.Add("117", "INTERIOR", @"../../UsedForResource/Interior/Interior_117.jpg", 257, 138, 225, 1);

            dtInterior.Rows.Add("118", "INTERIOR", @"../../UsedForResource/Interior/Interior_118.jpg", 175, 292, 118, 0);

            dtInterior.Rows.Add("119", "INTERIOR", @"../../UsedForResource/Interior/Interior_119.jpg", 91, 290, 229, 0);

            dtInterior.Rows.Add("120", "INTERIOR", @"../../UsedForResource/Interior/Interior_120.jpg", 191, 252, 127, 0);

            dtInterior.Rows.Add("121", "INTERIOR", @"../../UsedForResource/Interior/Interior_121.jpg", 189, 236, 134, 1);

            dtInterior.Rows.Add("122", "INTERIOR", @"../../UsedForResource/Interior/Interior_122.jpg", 41, 194, 164, 0);

            dtInterior.Rows.Add("123", "INTERIOR", @"../../UsedForResource/Interior/Interior_123.jpg", 146, 81, 217, 1);

            dtInterior.Rows.Add("124", "INTERIOR", @"../../UsedForResource/Interior/Interior_124.jpg", 66, 149, 260, 0);

            dtInterior.Rows.Add("125", "INTERIOR", @"../../UsedForResource/Interior/Interior_125.jpg", 264, 216, 194, 0);

            dtInterior.Rows.Add("126", "INTERIOR", @"../../UsedForResource/Interior/Interior_126.jpg", 125, 277, 190, 0);

            dtInterior.Rows.Add("127", "INTERIOR", @"../../UsedForResource/Interior/Interior_127.jpg", 40, 118, 139, 0);

            dtInterior.Rows.Add("128", "INTERIOR", @"../../UsedForResource/Interior/Interior_128.jpg", 123, 114, 113, 0);

            dtInterior.Rows.Add("129", "INTERIOR", @"../../UsedForResource/Interior/Interior_129.jpg", 261, 93, 57, 0);

            dtInterior.Rows.Add("130", "INTERIOR", @"../../UsedForResource/Interior/Interior_130.jpg", 249, 220, 258, 1);

            dtInterior.Rows.Add("131", "INTERIOR", @"../../UsedForResource/Interior/Interior_131.jpg", 163, 92, 176, 0);

            dtInterior.Rows.Add("132", "INTERIOR", @"../../UsedForResource/Interior/Interior_132.jpg", 201, 77, 114, 1);

            dtInterior.Rows.Add("133", "INTERIOR", @"../../UsedForResource/Interior/Interior_133.jpg", 131, 160, 233, 0);

            dtInterior.Rows.Add("134", "INTERIOR", @"../../UsedForResource/Interior/Interior_134.jpg", 138, 165, 116, 0);

            dtInterior.Rows.Add("135", "INTERIOR", @"../../UsedForResource/Interior/Interior_135.jpg", 197, 135, 157, 1);

            dtInterior.Rows.Add("136", "INTERIOR", @"../../UsedForResource/Interior/Interior_136.jpg", 240, 112, 115, 0);

            dtInterior.Rows.Add("137", "INTERIOR", @"../../UsedForResource/Interior/Interior_137.jpg", 254, 234, 191, 1);

            dtInterior.Rows.Add("138", "INTERIOR", @"../../UsedForResource/Interior/Interior_138.jpg", 233, 64, 150, 1);

            dtInterior.Rows.Add("139", "INTERIOR", @"../../UsedForResource/Interior/Interior_139.jpg", 89, 78, 111, 1);

            dtInterior.Rows.Add("140", "INTERIOR", @"../../UsedForResource/Interior/Interior_140.jpg", 258, 166, 167, 1);

            dtInterior.Rows.Add("141", "INTERIOR", @"../../UsedForResource/Interior/Interior_141.jpg", 39, 182, 90, 1);

            dtInterior.Rows.Add("142", "INTERIOR", @"../../UsedForResource/Interior/Interior_142.jpg", 184, 231, 84, 0);

            dtInterior.Rows.Add("143", "INTERIOR", @"../../UsedForResource/Interior/Interior_143.jpg", 124, 295, 200, 0);

            dtInterior.Rows.Add("144", "INTERIOR", @"../../UsedForResource/Interior/Interior_144.jpg", 198, 97, 181, 0);

            dtInterior.Rows.Add("145", "INTERIOR", @"../../UsedForResource/Interior/Interior_145.jpg", 203, 116, 122, 0);

            dtInterior.Rows.Add("146", "INTERIOR", @"../../UsedForResource/Interior/Interior_146.jpg", 162, 271, 119, 0);

            dtInterior.Rows.Add("147", "INTERIOR", @"../../UsedForResource/Interior/Interior_147.jpg", 165, 249, 271, 1);

            dtInterior.Rows.Add("148", "INTERIOR", @"../../UsedForResource/Interior/Interior_148.jpg", 259, 95, 173, 0);

            dtInterior.Rows.Add("149", "INTERIOR", @"../../UsedForResource/Interior/Interior_149.jpg", 167, 240, 135, 1);

            dtInterior.Rows.Add("150", "INTERIOR", @"../../UsedForResource/Interior/Interior_150.jpg", 44, 106, 142, 0);

            dtInterior.Rows.Add("151", "INTERIOR", @"../../UsedForResource/Interior/Interior_151.jpg", 122, 298, 83, 0);

            dtInterior.Rows.Add("152", "INTERIOR", @"../../UsedForResource/Interior/Interior_152.jpg", 86, 144, 92, 0);

            dtInterior.Rows.Add("153", "INTERIOR", @"../../UsedForResource/Interior/Interior_153.jpg", 42, 241, 195, 0);

            dtInterior.Rows.Add("154", "INTERIOR", @"../../UsedForResource/Interior/Interior_154.jpg", 223, 204, 109, 0);

            dtInterior.Rows.Add("155", "INTERIOR", @"../../UsedForResource/Interior/Interior_155.jpg", 232, 176, 198, 1);

            dtInterior.Rows.Add("156", "INTERIOR", @"../../UsedForResource/Interior/Interior_156.jpg", 53, 258, 196, 1);

            dtInterior.Rows.Add("157", "INTERIOR", @"../../UsedForResource/Interior/Interior_157.jpg", 243, 197, 60, 0);

            dtInterior.Rows.Add("158", "INTERIOR", @"../../UsedForResource/Interior/Interior_158.jpg", 105, 238, 103, 1);

            dtInterior.Rows.Add("159", "INTERIOR", @"../../UsedForResource/Interior/Interior_159.jpg", 147, 247, 165, 0);

            dtInterior.Rows.Add("160", "INTERIOR", @"../../UsedForResource/Interior/Interior_160.jpg", 73, 242, 95, 1);

            dtInterior.Rows.Add("161", "INTERIOR", @"../../UsedForResource/Interior/Interior_161.jpg", 194, 76, 140, 0);

            dtInterior.Rows.Add("162", "INTERIOR", @"../../UsedForResource/Interior/Interior_162.jpg", 242, 73, 279, 1);

            dtInterior.Rows.Add("163", "INTERIOR", @"../../UsedForResource/Interior/Interior_163.jpg", 32, 213, 224, 1);

            dtInterior.Rows.Add("164", "INTERIOR", @"../../UsedForResource/Interior/Interior_164.jpg", 47, 103, 218, 1);

            dtInterior.Rows.Add("165", "INTERIOR", @"../../UsedForResource/Interior/Interior_165.jpg", 71, 120, 87, 1);

            dtInterior.Rows.Add("166", "INTERIOR", @"../../UsedForResource/Interior/Interior_166.jpg", 112, 208, 228, 0);

            dtInterior.Rows.Add("167", "INTERIOR", @"../../UsedForResource/Interior/Interior_167.jpg", 158, 82, 210, 1);

            dtInterior.Rows.Add("168", "INTERIOR", @"../../UsedForResource/Interior/Interior_168.jpg", 121, 68, 100, 0);

            dtInterior.Rows.Add("169", "INTERIOR", @"../../UsedForResource/Interior/Interior_169.jpg", 95, 185, 59, 1);

            dtInterior.Rows.Add("170", "INTERIOR", @"../../UsedForResource/Interior/Interior_170.jpg", 172, 237, 56, 1);

            dtInterior.Rows.Add("171", "INTERIOR", @"../../UsedForResource/Interior/Interior_171.jpg", 134, 212, 132, 0);

            dtInterior.Rows.Add("172", "INTERIOR", @"../../UsedForResource/Interior/Interior_172.jpg", 55, 202, 75, 1);

            dtInterior.Rows.Add("173", "INTERIOR", @"../../UsedForResource/Interior/Interior_173.jpg", 63, 66, 158, 0);

            dtInterior.Rows.Add("174", "INTERIOR", @"../../UsedForResource/Interior/Interior_174.jpg", 67, 232, 152, 1);

            dtInterior.Rows.Add("175", "INTERIOR", @"../../UsedForResource/Interior/Interior_175.jpg", 262, 187, 69, 0);

            dtInterior.Rows.Add("176", "INTERIOR", @"../../UsedForResource/Interior/Interior_176.jpg", 248, 121, 262, 1);

            dtInterior.Rows.Add("177", "INTERIOR", @"../../UsedForResource/Interior/Interior_177.jpg", 215, 188, 155, 1);

            dtInterior.Rows.Add("178", "INTERIOR", @"../../UsedForResource/Interior/Interior_178.jpg", 266, 170, 147, 0);

            dtInterior.Rows.Add("179", "INTERIOR", @"../../UsedForResource/Interior/Interior_179.jpg", 77, 94, 187, 1);

            dtInterior.Rows.Add("180", "INTERIOR", @"../../UsedForResource/Interior/Interior_180.jpg", 152, 275, 170, 1);

            dtInterior.Rows.Add("181", "INTERIOR", @"../../UsedForResource/Interior/Interior_181.jpg", 75, 267, 203, 0);

            dtInterior.Rows.Add("182", "INTERIOR", @"../../UsedForResource/Interior/Interior_182.jpg", 56, 156, 73, 0);

            dtInterior.Rows.Add("183", "INTERIOR", @"../../UsedForResource/Interior/Interior_183.jpg", 54, 268, 199, 0);

            dtInterior.Rows.Add("184", "INTERIOR", @"../../UsedForResource/Interior/Interior_184.jpg", 99, 75, 231, 0);

            dtInterior.Rows.Add("185", "INTERIOR", @"../../UsedForResource/Interior/Interior_185.jpg", 102, 111, 77, 0);

            dtInterior.Rows.Add("186", "INTERIOR", @"../../UsedForResource/Interior/Interior_186.jpg", 51, 221, 226, 0);

            dtInterior.Rows.Add("187", "INTERIOR", @"../../UsedForResource/Interior/Interior_187.jpg", 193, 162, 110, 0);

            dtInterior.Rows.Add("188", "INTERIOR", @"../../UsedForResource/Interior/Interior_188.jpg", 115, 191, 255, 0);

            dtInterior.Rows.Add("189", "INTERIOR", @"../../UsedForResource/Interior/Interior_189.jpg", 224, 199, 236, 1);

            dtInterior.Rows.Add("190", "INTERIOR", @"../../UsedForResource/Interior/Interior_190.jpg", 214, 91, 283, 1);

            dtInterior.Rows.Add("191", "INTERIOR", @"../../UsedForResource/Interior/Interior_191.jpg", 111, 214, 281, 0);

            dtInterior.Rows.Add("192", "INTERIOR", @"../../UsedForResource/Interior/Interior_192.jpg", 195, 177, 234, 0);

            dtInterior.Rows.Add("193", "INTERIOR", @"../../UsedForResource/Interior/Interior_193.jpg", 228, 102, 201, 0);

            dtInterior.Rows.Add("194", "INTERIOR", @"../../UsedForResource/Interior/Interior_194.jpg", 153, 65, 245, 0);

            dtInterior.Rows.Add("195", "INTERIOR", @"../../UsedForResource/Interior/Interior_195.jpg", 127, 291, 182, 1);

            dtInterior.Rows.Add("196", "INTERIOR", @"../../UsedForResource/Interior/Interior_196.jpg", 220, 205, 250, 0);

            dtInterior.Rows.Add("197", "INTERIOR", @"../../UsedForResource/Interior/Interior_197.jpg", 252, 89, 288, 0);

            dtInterior.Rows.Add("198", "INTERIOR", @"../../UsedForResource/Interior/Interior_198.jpg", 251, 159, 213, 1);

            dtInterior.Rows.Add("199", "INTERIOR", @"../../UsedForResource/Interior/Interior_199.jpg", 221, 131, 252, 0);

            dtInterior.Rows.Add("200", "INTERIOR", @"../../UsedForResource/Interior/Interior_200.jpg", 181, 248, 166, 0);

            dtInterior.Rows.Add("201", "INTERIOR", @"../../UsedForResource/Interior/Interior_201.jpg", 234, 244, 168, 0);

            dtInterior.Rows.Add("202", "INTERIOR", @"../../UsedForResource/Interior/Interior_202.jpg", 186, 228, 102, 1);

            dtInterior.Rows.Add("203", "INTERIOR", @"../../UsedForResource/Interior/Interior_203.jpg", 269, 250, 259, 0);

            dtInterior.Rows.Add("204", "INTERIOR", @"../../UsedForResource/Interior/Interior_204.jpg", 227, 264, 192, 0);

            dtInterior.Rows.Add("205", "INTERIOR", @"../../UsedForResource/Interior/Interior_205.jpg", 205, 215, 156, 0);

            dtInterior.Rows.Add("206", "INTERIOR", @"../../UsedForResource/Interior/Interior_206.jpg", 80, 151, 230, 0);

            dtInterior.Rows.Add("207", "INTERIOR", @"../../UsedForResource/Interior/Interior_207.jpg", 246, 110, 53, 0);

            dtInterior.Rows.Add("208", "INTERIOR", @"../../UsedForResource/Interior/Interior_208.jpg", 88, 167, 254, 1);

            dtInterior.Rows.Add("209", "INTERIOR", @"../../UsedForResource/Interior/Interior_209.jpg", 267, 175, 206, 1);

            dtInterior.Rows.Add("210", "INTERIOR", @"../../UsedForResource/Interior/Interior_210.jpg", 144, 136, 62, 1);

            dtInterior.Rows.Add("211", "INTERIOR", @"../../UsedForResource/Interior/Interior_211.jpg", 169, 289, 151, 0);

            dtInterior.Rows.Add("212", "INTERIOR", @"../../UsedForResource/Interior/Interior_212.jpg", 46, 203, 80, 0);

            dtInterior.Rows.Add("213", "INTERIOR", @"../../UsedForResource/Interior/Interior_213.jpg", 177, 184, 78, 1);

            dtInterior.Rows.Add("214", "INTERIOR", @"../../UsedForResource/Interior/Interior_214.jpg", 135, 109, 204, 0);

            dtInterior.Rows.Add("215", "INTERIOR", @"../../UsedForResource/Interior/Interior_215.jpg", 174, 265, 235, 1);

            dtInterior.Rows.Add("216", "INTERIOR", @"../../UsedForResource/Interior/Interior_216.jpg", 93, 189, 285, 1);

            dtInterior.Rows.Add("217", "INTERIOR", @"../../UsedForResource/Interior/Interior_217.jpg", 52, 286, 58, 0);

            dtInterior.Rows.Add("218", "INTERIOR", @"../../UsedForResource/Interior/Interior_218.jpg", 168, 261, 79, 1);

            dtInterior.Rows.Add("219", "INTERIOR", @"../../UsedForResource/Interior/Interior_219.jpg", 213, 142, 212, 1);

            dtInterior.Rows.Add("220", "INTERIOR", @"../../UsedForResource/Interior/Interior_220.jpg", 57, 284, 101, 0);

            dtInterior.Rows.Add("221", "INTERIOR", @"../../UsedForResource/Interior/Interior_221.jpg", 30, 186, 131, 0);

            dtInterior.Rows.Add("222", "INTERIOR", @"../../UsedForResource/Interior/Interior_222.jpg", 87, 287, 93, 0);

            dtInterior.Rows.Add("223", "INTERIOR", @"../../UsedForResource/Interior/Interior_223.jpg", 180, 153, 162, 1);

            dtInterior.Rows.Add("224", "INTERIOR", @"../../UsedForResource/Interior/Interior_224.jpg", 108, 179, 243, 1);

            dtInterior.Rows.Add("225", "INTERIOR", @"../../UsedForResource/Interior/Interior_225.jpg", 183, 235, 126, 0);

            dtInterior.Rows.Add("226", "INTERIOR", @"../../UsedForResource/Interior/Interior_226.jpg", 173, 297, 227, 1);

            dtInterior.Rows.Add("227", "INTERIOR", @"../../UsedForResource/Interior/Interior_227.jpg", 157, 210, 270, 1);

            dtInterior.Rows.Add("228", "INTERIOR", @"../../UsedForResource/Interior/Interior_228.jpg", 132, 211, 266, 0);

            dtInterior.Rows.Add("229", "INTERIOR", @"../../UsedForResource/Interior/Interior_229.jpg", 85, 80, 171, 0);
            //////////////////////////////////////////// ADD THE DATA FOR OCEANS CATEGORIZED ////////////////////////////////////////////////////////
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            dtOceans.Rows.Add("1", "OCEANS", @"../../UsedForResource/Ocean/Ocean_1.jpg", 45, 95, 142, 1);

            dtOceans.Rows.Add("2", "OCEANS", @"../../UsedForResource/Ocean/Ocean_2.jpg", 182, 279, 274, 1);

            dtOceans.Rows.Add("3", "OCEANS", @"../../UsedForResource/Ocean/Ocean_3.jpg", 60, 292, 122, 0);

            dtOceans.Rows.Add("4", "OCEANS", @"../../UsedForResource/Ocean/Ocean_4.jpg", 252, 328, 280, 0);

            dtOceans.Rows.Add("5", "OCEANS", @"../../UsedForResource/Ocean/Ocean_5.jpg", 139, 160, 184, 1);

            dtOceans.Rows.Add("6", "OCEANS", @"../../UsedForResource/Ocean/Ocean_6.jpg", 27, 232, 104, 0);

            dtOceans.Rows.Add("7", "OCEANS", @"../../UsedForResource/Ocean/Ocean_7.jpg", 219, 338, 102, 1);

            dtOceans.Rows.Add("8", "OCEANS", @"../../UsedForResource/Ocean/Ocean_8.jpg", 59, 174, 279, 1);

            dtOceans.Rows.Add("9", "OCEANS", @"../../UsedForResource/Ocean/Ocean_9.jpg", 208, 192, 82, 1);

            dtOceans.Rows.Add("10", "OCEANS", @"../../UsedForResource/Ocean/Ocean_10.jpg", 216, 252, 213, 1);

            dtOceans.Rows.Add("11", "OCEANS", @"../../UsedForResource/Ocean/Ocean_11.jpg", 93, 180, 232, 1);

            dtOceans.Rows.Add("12", "OCEANS", @"../../UsedForResource/Ocean/Ocean_12.jpg", 88, 199, 243, 0);

            dtOceans.Rows.Add("13", "OCEANS", @"../../UsedForResource/Ocean/Ocean_13.jpg", 162, 134, 106, 1);

            dtOceans.Rows.Add("14", "OCEANS", @"../../UsedForResource/Ocean/Ocean_14.jpg", 239, 209, 246, 1);

            dtOceans.Rows.Add("15", "OCEANS", @"../../UsedForResource/Ocean/Ocean_15.jpg", 48, 124, 234, 0);

            dtOceans.Rows.Add("16", "OCEANS", @"../../UsedForResource/Ocean/Ocean_16.jpg", 64, 219, 143, 0);

            dtOceans.Rows.Add("17", "OCEANS", @"../../UsedForResource/Ocean/Ocean_17.jpg", 232, 213, 110, 1);

            dtOceans.Rows.Add("18", "OCEANS", @"../../UsedForResource/Ocean/Ocean_18.jpg", 142, 137, 75, 1);

            dtOceans.Rows.Add("19", "OCEANS", @"../../UsedForResource/Ocean/Ocean_19.jpg", 82, 310, 192, 1);

            dtOceans.Rows.Add("20", "OCEANS", @"../../UsedForResource/Ocean/Ocean_20.jpg", 72, 257, 126, 1);

            dtOceans.Rows.Add("21", "OCEANS", @"../../UsedForResource/Ocean/Ocean_21.jpg", 51, 97, 200, 1);

            dtOceans.Rows.Add("22", "OCEANS", @"../../UsedForResource/Ocean/Ocean_22.jpg", 115, 100, 98, 0);

            dtOceans.Rows.Add("23", "OCEANS", @"../../UsedForResource/Ocean/Ocean_23.jpg", 42, 290, 100, 1);

            dtOceans.Rows.Add("24", "OCEANS", @"../../UsedForResource/Ocean/Ocean_24.jpg", 110, 237, 182, 1);

            dtOceans.Rows.Add("25", "OCEANS", @"../../UsedForResource/Ocean/Ocean_25.jpg", 131, 158, 115, 1);

            dtOceans.Rows.Add("26", "OCEANS", @"../../UsedForResource/Ocean/Ocean_26.jpg", 36, 223, 285, 1);

            dtOceans.Rows.Add("27", "OCEANS", @"../../UsedForResource/Ocean/Ocean_27.jpg", 137, 277, 255, 0);

            dtOceans.Rows.Add("28", "OCEANS", @"../../UsedForResource/Ocean/Ocean_28.jpg", 53, 247, 155, 0);

            dtOceans.Rows.Add("29", "OCEANS", @"../../UsedForResource/Ocean/Ocean_29.jpg", 125, 194, 174, 0);

            dtOceans.Rows.Add("30", "OCEANS", @"../../UsedForResource/Ocean/Ocean_30.jpg", 206, 112, 226, 1);

            dtOceans.Rows.Add("31", "OCEANS", @"../../UsedForResource/Ocean/Ocean_31.jpg", 180, 275, 227, 1);

            dtOceans.Rows.Add("32", "OCEANS", @"../../UsedForResource/Ocean/Ocean_32.jpg", 130, 156, 88, 0);

            dtOceans.Rows.Add("33", "OCEANS", @"../../UsedForResource/Ocean/Ocean_33.jpg", 155, 314, 85, 1);

            dtOceans.Rows.Add("34", "OCEANS", @"../../UsedForResource/Ocean/Ocean_34.jpg", 172, 167, 77, 0);

            dtOceans.Rows.Add("35", "OCEANS", @"../../UsedForResource/Ocean/Ocean_35.jpg", 29, 93, 235, 1);

            dtOceans.Rows.Add("36", "OCEANS", @"../../UsedForResource/Ocean/Ocean_36.jpg", 257, 262, 175, 1);

            dtOceans.Rows.Add("37", "OCEANS", @"../../UsedForResource/Ocean/Ocean_37.jpg", 258, 92, 186, 0);

            dtOceans.Rows.Add("38", "OCEANS", @"../../UsedForResource/Ocean/Ocean_38.jpg", 111, 215, 145, 1);

            dtOceans.Rows.Add("39", "OCEANS", @"../../UsedForResource/Ocean/Ocean_39.jpg", 260, 331, 194, 1);

            dtOceans.Rows.Add("40", "OCEANS", @"../../UsedForResource/Ocean/Ocean_40.jpg", 167, 126, 154, 1);

            dtOceans.Rows.Add("41", "OCEANS", @"../../UsedForResource/Ocean/Ocean_41.jpg", 26, 304, 248, 1);

            dtOceans.Rows.Add("42", "OCEANS", @"../../UsedForResource/Ocean/Ocean_42.jpg", 156, 293, 266, 0);

            dtOceans.Rows.Add("43", "OCEANS", @"../../UsedForResource/Ocean/Ocean_43.jpg", 28, 114, 137, 1);

            dtOceans.Rows.Add("44", "OCEANS", @"../../UsedForResource/Ocean/Ocean_44.jpg", 249, 216, 187, 0);

            dtOceans.Rows.Add("45", "OCEANS", @"../../UsedForResource/Ocean/Ocean_45.jpg", 213, 297, 221, 1);

            dtOceans.Rows.Add("46", "OCEANS", @"../../UsedForResource/Ocean/Ocean_46.jpg", 210, 102, 89, 1);

            dtOceans.Rows.Add("47", "OCEANS", @"../../UsedForResource/Ocean/Ocean_47.jpg", 97, 128, 195, 0);

            dtOceans.Rows.Add("48", "OCEANS", @"../../UsedForResource/Ocean/Ocean_48.jpg", 133, 307, 239, 1);

            dtOceans.Rows.Add("49", "OCEANS", @"../../UsedForResource/Ocean/Ocean_49.jpg", 195, 107, 250, 0);

            dtOceans.Rows.Add("50", "OCEANS", @"../../UsedForResource/Ocean/Ocean_50.jpg", 199, 140, 261, 1);

            dtOceans.Rows.Add("51", "OCEANS", @"../../UsedForResource/Ocean/Ocean_51.jpg", 189, 99, 225, 1);

            dtOceans.Rows.Add("52", "OCEANS", @"../../UsedForResource/Ocean/Ocean_52.jpg", 264, 283, 275, 0);

            dtOceans.Rows.Add("53", "OCEANS", @"../../UsedForResource/Ocean/Ocean_53.jpg", 50, 269, 131, 1);

            dtOceans.Rows.Add("54", "OCEANS", @"../../UsedForResource/Ocean/Ocean_54.jpg", 185, 178, 158, 1);

            dtOceans.Rows.Add("55", "OCEANS", @"../../UsedForResource/Ocean/Ocean_55.jpg", 101, 111, 211, 0);

            dtOceans.Rows.Add("56", "OCEANS", @"../../UsedForResource/Ocean/Ocean_56.jpg", 118, 217, 121, 0);

            dtOceans.Rows.Add("57", "OCEANS", @"../../UsedForResource/Ocean/Ocean_57.jpg", 119, 172, 153, 0);

            dtOceans.Rows.Add("58", "OCEANS", @"../../UsedForResource/Ocean/Ocean_58.jpg", 107, 171, 278, 0);

            dtOceans.Rows.Add("59", "OCEANS", @"../../UsedForResource/Ocean/Ocean_59.jpg", 161, 285, 289, 1);

            dtOceans.Rows.Add("60", "OCEANS", @"../../UsedForResource/Ocean/Ocean_60.jpg", 99, 138, 170, 0);

            dtOceans.Rows.Add("61", "OCEANS", @"../../UsedForResource/Ocean/Ocean_61.jpg", 243, 340, 94, 1);

            dtOceans.Rows.Add("62", "OCEANS", @"../../UsedForResource/Ocean/Ocean_62.jpg", 236, 344, 219, 0);

            dtOceans.Rows.Add("63", "OCEANS", @"../../UsedForResource/Ocean/Ocean_63.jpg", 269, 168, 189, 0);

            dtOceans.Rows.Add("64", "OCEANS", @"../../UsedForResource/Ocean/Ocean_64.jpg", 253, 206, 203, 1);

            dtOceans.Rows.Add("65", "OCEANS", @"../../UsedForResource/Ocean/Ocean_65.jpg", 150, 193, 76, 1);

            dtOceans.Rows.Add("66", "OCEANS", @"../../UsedForResource/Ocean/Ocean_66.jpg", 106, 295, 282, 0);

            dtOceans.Rows.Add("67", "OCEANS", @"../../UsedForResource/Ocean/Ocean_67.jpg", 120, 173, 286, 1);

            dtOceans.Rows.Add("68", "OCEANS", @"../../UsedForResource/Ocean/Ocean_68.jpg", 215, 210, 199, 0);

            dtOceans.Rows.Add("69", "OCEANS", @"../../UsedForResource/Ocean/Ocean_69.jpg", 105, 226, 191, 1);

            dtOceans.Rows.Add("70", "OCEANS", @"../../UsedForResource/Ocean/Ocean_70.jpg", 245, 144, 97, 1);

            dtOceans.Rows.Add("71", "OCEANS", @"../../UsedForResource/Ocean/Ocean_71.jpg", 187, 182, 181, 0);

            dtOceans.Rows.Add("72", "OCEANS", @"../../UsedForResource/Ocean/Ocean_72.jpg", 238, 84, 152, 0);

            dtOceans.Rows.Add("73", "OCEANS", @"../../UsedForResource/Ocean/Ocean_73.jpg", 265, 334, 103, 0);

            dtOceans.Rows.Add("74", "OCEANS", @"../../UsedForResource/Ocean/Ocean_74.jpg", 86, 220, 119, 1);

            dtOceans.Rows.Add("75", "OCEANS", @"../../UsedForResource/Ocean/Ocean_75.jpg", 184, 119, 147, 0);

            dtOceans.Rows.Add("76", "OCEANS", @"../../UsedForResource/Ocean/Ocean_76.jpg", 94, 224, 114, 1);

            dtOceans.Rows.Add("77", "OCEANS", @"../../UsedForResource/Ocean/Ocean_77.jpg", 202, 282, 130, 1);

            dtOceans.Rows.Add("78", "OCEANS", @"../../UsedForResource/Ocean/Ocean_78.jpg", 233, 129, 108, 1);

            dtOceans.Rows.Add("79", "OCEANS", @"../../UsedForResource/Ocean/Ocean_79.jpg", 227, 280, 208, 0);

            dtOceans.Rows.Add("80", "OCEANS", @"../../UsedForResource/Ocean/Ocean_80.jpg", 138, 256, 269, 0);

            dtOceans.Rows.Add("81", "OCEANS", @"../../UsedForResource/Ocean/Ocean_81.jpg", 148, 271, 70, 1);

            dtOceans.Rows.Add("82", "OCEANS", @"../../UsedForResource/Ocean/Ocean_82.jpg", 241, 228, 179, 0);

            dtOceans.Rows.Add("83", "OCEANS", @"../../UsedForResource/Ocean/Ocean_83.jpg", 188, 142, 177, 1);

            dtOceans.Rows.Add("84", "OCEANS", @"../../UsedForResource/Ocean/Ocean_84.jpg", 81, 208, 217, 0);

            dtOceans.Rows.Add("85", "OCEANS", @"../../UsedForResource/Ocean/Ocean_85.jpg", 209, 265, 281, 0);

            dtOceans.Rows.Add("86", "OCEANS", @"../../UsedForResource/Ocean/Ocean_86.jpg", 214, 339, 240, 0);

            dtOceans.Rows.Add("87", "OCEANS", @"../../UsedForResource/Ocean/Ocean_87.jpg", 127, 200, 117, 0);

            dtOceans.Rows.Add("88", "OCEANS", @"../../UsedForResource/Ocean/Ocean_88.jpg", 198, 191, 272, 0);

            dtOceans.Rows.Add("89", "OCEANS", @"../../UsedForResource/Ocean/Ocean_89.jpg", 157, 266, 172, 1);

            dtOceans.Rows.Add("90", "OCEANS", @"../../UsedForResource/Ocean/Ocean_90.jpg", 136, 296, 223, 0);

            dtOceans.Rows.Add("91", "OCEANS", @"../../UsedForResource/Ocean/Ocean_91.jpg", 116, 202, 218, 1);

            dtOceans.Rows.Add("92", "OCEANS", @"../../UsedForResource/Ocean/Ocean_92.jpg", 71, 133, 268, 1);

            dtOceans.Rows.Add("93", "OCEANS", @"../../UsedForResource/Ocean/Ocean_93.jpg", 217, 259, 233, 0);

            dtOceans.Rows.Add("94", "OCEANS", @"../../UsedForResource/Ocean/Ocean_94.jpg", 171, 235, 84, 0);

            dtOceans.Rows.Add("95", "OCEANS", @"../../UsedForResource/Ocean/Ocean_95.jpg", 164, 249, 101, 0);

            dtOceans.Rows.Add("96", "OCEANS", @"../../UsedForResource/Ocean/Ocean_96.jpg", 230, 153, 107, 1);

            dtOceans.Rows.Add("97", "OCEANS", @"../../UsedForResource/Ocean/Ocean_97.jpg", 248, 105, 90, 0);

            dtOceans.Rows.Add("98", "OCEANS", @"../../UsedForResource/Ocean/Ocean_98.jpg", 31, 337, 112, 0);

            dtOceans.Rows.Add("99", "OCEANS", @"../../UsedForResource/Ocean/Ocean_99.jpg", 92, 204, 116, 0);

            dtOceans.Rows.Add("100", "OCEANS", @"../../UsedForResource/Ocean/Ocean_100.jpg", 102, 214, 253, 1);

            dtOceans.Rows.Add("101", "OCEANS", @"../../UsedForResource/Ocean/Ocean_101.jpg", 109, 218, 196, 0);

            dtOceans.Rows.Add("102", "OCEANS", @"../../UsedForResource/Ocean/Ocean_102.jpg", 191, 246, 169, 0);

            dtOceans.Rows.Add("103", "OCEANS", @"../../UsedForResource/Ocean/Ocean_103.jpg", 56, 221, 132, 0);

            dtOceans.Rows.Add("104", "OCEANS", @"../../UsedForResource/Ocean/Ocean_104.jpg", 179, 113, 83, 0);

            dtOceans.Rows.Add("105", "OCEANS", @"../../UsedForResource/Ocean/Ocean_105.jpg", 153, 189, 109, 1);

            dtOceans.Rows.Add("106", "OCEANS", @"../../UsedForResource/Ocean/Ocean_106.jpg", 242, 118, 214, 1);

            dtOceans.Rows.Add("107", "OCEANS", @"../../UsedForResource/Ocean/Ocean_107.jpg", 54, 261, 207, 1);

            dtOceans.Rows.Add("108", "OCEANS", @"../../UsedForResource/Ocean/Ocean_108.jpg", 113, 342, 204, 0);

            dtOceans.Rows.Add("109", "OCEANS", @"../../UsedForResource/Ocean/Ocean_109.jpg", 201, 333, 96, 0);

            dtOceans.Rows.Add("110", "OCEANS", @"../../UsedForResource/Ocean/Ocean_110.jpg", 194, 345, 92, 0);

            dtOceans.Rows.Add("111", "OCEANS", @"../../UsedForResource/Ocean/Ocean_111.jpg", 149, 143, 87, 1);

            dtOceans.Rows.Add("112", "OCEANS", @"../../UsedForResource/Ocean/Ocean_112.jpg", 173, 123, 257, 0);

            dtOceans.Rows.Add("113", "OCEANS", @"../../UsedForResource/Ocean/Ocean_113.jpg", 151, 300, 138, 1);

            dtOceans.Rows.Add("114", "OCEANS", @"../../UsedForResource/Ocean/Ocean_114.jpg", 47, 289, 224, 0);

            dtOceans.Rows.Add("115", "OCEANS", @"../../UsedForResource/Ocean/Ocean_115.jpg", 268, 122, 128, 0);

            dtOceans.Rows.Add("116", "OCEANS", @"../../UsedForResource/Ocean/Ocean_116.jpg", 67, 169, 262, 0);

            dtOceans.Rows.Add("117", "OCEANS", @"../../UsedForResource/Ocean/Ocean_117.jpg", 200, 229, 173, 0);

            dtOceans.Rows.Add("118", "OCEANS", @"../../UsedForResource/Ocean/Ocean_118.jpg", 220, 162, 267, 0);

            dtOceans.Rows.Add("119", "OCEANS", @"../../UsedForResource/Ocean/Ocean_119.jpg", 224, 263, 79, 1);

            dtOceans.Rows.Add("120", "OCEANS", @"../../UsedForResource/Ocean/Ocean_120.jpg", 117, 86, 183, 0);

            dtOceans.Rows.Add("121", "OCEANS", @"../../UsedForResource/Ocean/Ocean_121.jpg", 226, 272, 258, 0);

            dtOceans.Rows.Add("122", "OCEANS", @"../../UsedForResource/Ocean/Ocean_122.jpg", 30, 211, 198, 1);

            dtOceans.Rows.Add("123", "OCEANS", @"../../UsedForResource/Ocean/Ocean_123.jpg", 256, 325, 252, 0);

            dtOceans.Rows.Add("124", "OCEANS", @"../../UsedForResource/Ocean/Ocean_124.jpg", 70, 148, 78, 1);

            dtOceans.Rows.Add("125", "OCEANS", @"../../UsedForResource/Ocean/Ocean_125.jpg", 231, 294, 287, 0);

            dtOceans.Rows.Add("126", "OCEANS", @"../../UsedForResource/Ocean/Ocean_126.jpg", 205, 291, 265, 0);

            dtOceans.Rows.Add("127", "OCEANS", @"../../UsedForResource/Ocean/Ocean_127.jpg", 190, 284, 237, 0);

            dtOceans.Rows.Add("128", "OCEANS", @"../../UsedForResource/Ocean/Ocean_128.jpg", 250, 332, 166, 0);

            dtOceans.Rows.Add("129", "OCEANS", @"../../UsedForResource/Ocean/Ocean_129.jpg", 58, 125, 133, 1);

            dtOceans.Rows.Add("130", "OCEANS", @"../../UsedForResource/Ocean/Ocean_130.jpg", 158, 298, 135, 0);

            dtOceans.Rows.Add("131", "OCEANS", @"../../UsedForResource/Ocean/Ocean_131.jpg", 100, 89, 168, 0);

            dtOceans.Rows.Add("132", "OCEANS", @"../../UsedForResource/Ocean/Ocean_132.jpg", 108, 315, 162, 0);

            dtOceans.Rows.Add("133", "OCEANS", @"../../UsedForResource/Ocean/Ocean_133.jpg", 89, 222, 72, 1);

            dtOceans.Rows.Add("134", "OCEANS", @"../../UsedForResource/Ocean/Ocean_134.jpg", 122, 242, 161, 1);

            dtOceans.Rows.Add("135", "OCEANS", @"../../UsedForResource/Ocean/Ocean_135.jpg", 259, 248, 124, 0);

            dtOceans.Rows.Add("136", "OCEANS", @"../../UsedForResource/Ocean/Ocean_136.jpg", 154, 183, 91, 0);

            dtOceans.Rows.Add("137", "OCEANS", @"../../UsedForResource/Ocean/Ocean_137.jpg", 176, 281, 125, 0);

            dtOceans.Rows.Add("138", "OCEANS", @"../../UsedForResource/Ocean/Ocean_138.jpg", 55, 166, 216, 0);

            dtOceans.Rows.Add("139", "OCEANS", @"../../UsedForResource/Ocean/Ocean_139.jpg", 267, 101, 260, 1);

            dtOceans.Rows.Add("140", "OCEANS", @"../../UsedForResource/Ocean/Ocean_140.jpg", 274, 155, 150, 0);

            dtOceans.Rows.Add("141", "OCEANS", @"../../UsedForResource/Ocean/Ocean_141.jpg", 95, 273, 244, 0);

            dtOceans.Rows.Add("142", "OCEANS", @"../../UsedForResource/Ocean/Ocean_142.jpg", 163, 251, 201, 1);

            dtOceans.Rows.Add("143", "OCEANS", @"../../UsedForResource/Ocean/Ocean_143.jpg", 83, 267, 273, 0);

            dtOceans.Rows.Add("144", "OCEANS", @"../../UsedForResource/Ocean/Ocean_144.jpg", 85, 157, 146, 1);

            dtOceans.Rows.Add("145", "OCEANS", @"../../UsedForResource/Ocean/Ocean_145.jpg", 177, 241, 241, 0);

            dtOceans.Rows.Add("146", "OCEANS", @"../../UsedForResource/Ocean/Ocean_146.jpg", 80, 330, 256, 1);

            dtOceans.Rows.Add("147", "OCEANS", @"../../UsedForResource/Ocean/Ocean_147.jpg", 160, 341, 165, 1);

            dtOceans.Rows.Add("148", "OCEANS", @"../../UsedForResource/Ocean/Ocean_148.jpg", 39, 88, 149, 1);

            dtOceans.Rows.Add("149", "OCEANS", @"../../UsedForResource/Ocean/Ocean_149.jpg", 52, 152, 105, 1);

            dtOceans.Rows.Add("150", "OCEANS", @"../../UsedForResource/Ocean/Ocean_150.jpg", 141, 309, 264, 0);

            dtOceans.Rows.Add("151", "OCEANS", @"../../UsedForResource/Ocean/Ocean_151.jpg", 63, 85, 164, 0);

            dtOceans.Rows.Add("152", "OCEANS", @"../../UsedForResource/Ocean/Ocean_152.jpg", 255, 270, 134, 0);

            dtOceans.Rows.Add("153", "OCEANS", @"../../UsedForResource/Ocean/Ocean_153.jpg", 237, 175, 288, 0);

            dtOceans.Rows.Add("154", "OCEANS", @"../../UsedForResource/Ocean/Ocean_154.jpg", 271, 90, 212, 1);

            dtOceans.Rows.Add("155", "OCEANS", @"../../UsedForResource/Ocean/Ocean_155.jpg", 76, 135, 259, 1);

            dtOceans.Rows.Add("156", "OCEANS", @"../../UsedForResource/Ocean/Ocean_156.jpg", 270, 81, 157, 1);

            dtOceans.Rows.Add("157", "OCEANS", @"../../UsedForResource/Ocean/Ocean_157.jpg", 114, 190, 205, 1);

            dtOceans.Rows.Add("158", "OCEANS", @"../../UsedForResource/Ocean/Ocean_158.jpg", 65, 306, 276, 0);

            dtOceans.Rows.Add("159", "OCEANS", @"../../UsedForResource/Ocean/Ocean_159.jpg", 251, 117, 163, 0);

            dtOceans.Rows.Add("160", "OCEANS", @"../../UsedForResource/Ocean/Ocean_160.jpg", 145, 329, 210, 0);

            dtOceans.Rows.Add("161", "OCEANS", @"../../UsedForResource/Ocean/Ocean_161.jpg", 147, 320, 95, 1);

            dtOceans.Rows.Add("162", "OCEANS", @"../../UsedForResource/Ocean/Ocean_162.jpg", 223, 196, 202, 1);

            dtOceans.Rows.Add("163", "OCEANS", @"../../UsedForResource/Ocean/Ocean_163.jpg", 175, 326, 193, 0);

            dtOceans.Rows.Add("164", "OCEANS", @"../../UsedForResource/Ocean/Ocean_164.jpg", 123, 104, 113, 1);

            dtOceans.Rows.Add("165", "OCEANS", @"../../UsedForResource/Ocean/Ocean_165.jpg", 144, 322, 178, 0);

            dtOceans.Rows.Add("166", "OCEANS", @"../../UsedForResource/Ocean/Ocean_166.jpg", 73, 264, 148, 1);

            dtOceans.Rows.Add("167", "OCEANS", @"../../UsedForResource/Ocean/Ocean_167.jpg", 32, 233, 242, 1);

            dtOceans.Rows.Add("168", "OCEANS", @"../../UsedForResource/Ocean/Ocean_168.jpg", 181, 346, 176, 1);

            dtOceans.Rows.Add("169", "OCEANS", @"../../UsedForResource/Ocean/Ocean_169.jpg", 33, 212, 215, 1);

            dtOceans.Rows.Add("170", "OCEANS", @"../../UsedForResource/Ocean/Ocean_170.jpg", 91, 274, 245, 0);

            dtOceans.Rows.Add("171", "OCEANS", @"../../UsedForResource/Ocean/Ocean_171.jpg", 234, 305, 284, 1);

            dtOceans.Rows.Add("172", "OCEANS", @"../../UsedForResource/Ocean/Ocean_172.jpg", 121, 83, 249, 0);

            dtOceans.Rows.Add("173", "OCEANS", @"../../UsedForResource/Ocean/Ocean_173.jpg", 178, 348, 270, 1);

            dtOceans.Rows.Add("174", "OCEANS", @"../../UsedForResource/Ocean/Ocean_174.jpg", 211, 303, 171, 1);

            dtOceans.Rows.Add("175", "OCEANS", @"../../UsedForResource/Ocean/Ocean_175.jpg", 135, 276, 222, 0);

            dtOceans.Rows.Add("176", "OCEANS", @"../../UsedForResource/Ocean/Ocean_176.jpg", 192, 336, 160, 1);

            dtOceans.Rows.Add("177", "OCEANS", @"../../UsedForResource/Ocean/Ocean_177.jpg", 247, 82, 254, 0);

            dtOceans.Rows.Add("178", "OCEANS", @"../../UsedForResource/Ocean/Ocean_178.jpg", 186, 323, 99, 0);

            dtOceans.Rows.Add("179", "OCEANS", @"../../UsedForResource/Ocean/Ocean_179.jpg", 38, 236, 263, 0);

            dtOceans.Rows.Add("180", "OCEANS", @"../../UsedForResource/Ocean/Ocean_180.jpg", 273, 98, 236, 0);

            dtOceans.Rows.Add("181", "OCEANS", @"../../UsedForResource/Ocean/Ocean_181.jpg", 240, 317, 206, 1);

            dtOceans.Rows.Add("182", "OCEANS", @"../../UsedForResource/Ocean/Ocean_182.jpg", 126, 187, 80, 1);

            dtOceans.Rows.Add("183", "OCEANS", @"../../UsedForResource/Ocean/Ocean_183.jpg", 143, 195, 151, 1);

            dtOceans.Rows.Add("184", "OCEANS", @"../../UsedForResource/Ocean/Ocean_184.jpg", 263, 116, 144, 1);

            dtOceans.Rows.Add("185", "OCEANS", @"../../UsedForResource/Ocean/Ocean_185.jpg", 266, 188, 231, 1);

            dtOceans.Rows.Add("186", "OCEANS", @"../../UsedForResource/Ocean/Ocean_186.jpg", 68, 141, 93, 1);
            //////////////////////////////////////////// ADD THE DATA FOR MOTOBIKE CATEGORIZED ////////////////////////////////////////////////////////
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            dtMotoBike.Rows.Add("1", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_1.jpg", 276, 275, 327, 0);

            dtMotoBike.Rows.Add("2", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_2.jpg", 146, 134, 233, 0);

            dtMotoBike.Rows.Add("3", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_3.jpg", 54, 329, 132, 0);

            dtMotoBike.Rows.Add("4", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_4.jpg", 208, 276, 352, 1);

            dtMotoBike.Rows.Add("5", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_5.jpg", 250, 287, 210, 0);

            dtMotoBike.Rows.Add("6", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_6.jpg", 73, 108, 245, 1);

            dtMotoBike.Rows.Add("7", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_7.jpg", 44, 143, 127, 1);

            dtMotoBike.Rows.Add("8", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_8.jpg", 196, 154, 262, 0);

            dtMotoBike.Rows.Add("9", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_9.jpg", 134, 145, 244, 0);

            dtMotoBike.Rows.Add("10", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_10.jpg", 55, 184, 101, 1);

            dtMotoBike.Rows.Add("11", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_11.jpg", 83, 313, 258, 0);

            dtMotoBike.Rows.Add("12", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_12.jpg", 41, 252, 250, 0);

            dtMotoBike.Rows.Add("13", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_13.jpg", 72, 140, 363, 1);

            dtMotoBike.Rows.Add("14", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_14.jpg", 132, 161, 97, 0);

            dtMotoBike.Rows.Add("15", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_15.jpg", 234, 222, 318, 0);

            dtMotoBike.Rows.Add("16", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_16.jpg", 182, 238, 254, 1);

            dtMotoBike.Rows.Add("17", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_17.jpg", 189, 159, 139, 0);

            dtMotoBike.Rows.Add("18", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_18.jpg", 85, 196, 199, 0);

            dtMotoBike.Rows.Add("19", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_19.jpg", 166, 102, 152, 0);

            dtMotoBike.Rows.Add("20", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_20.jpg", 128, 251, 125, 1);

            dtMotoBike.Rows.Add("21", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_21.jpg", 170, 333, 142, 1);

            dtMotoBike.Rows.Add("22", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_22.jpg", 159, 249, 356, 0);

            dtMotoBike.Rows.Add("23", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_23.jpg", 76, 282, 107, 1);

            dtMotoBike.Rows.Add("24", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_24.jpg", 221, 209, 266, 0);

            dtMotoBike.Rows.Add("25", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_25.jpg", 243, 296, 135, 0);

            dtMotoBike.Rows.Add("26", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_26.jpg", 201, 148, 364, 0);

            dtMotoBike.Rows.Add("27", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_27.jpg", 213, 81, 257, 1);

            dtMotoBike.Rows.Add("28", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_28.jpg", 284, 297, 95, 1);

            dtMotoBike.Rows.Add("29", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_29.jpg", 181, 234, 220, 0);

            dtMotoBike.Rows.Add("30", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_30.jpg", 57, 201, 225, 0);

            dtMotoBike.Rows.Add("31", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_31.jpg", 268, 207, 361, 1);

            dtMotoBike.Rows.Add("32", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_32.jpg", 139, 99, 247, 1);

            dtMotoBike.Rows.Add("33", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_33.jpg", 111, 240, 331, 0);

            dtMotoBike.Rows.Add("34", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_34.jpg", 244, 170, 226, 0);

            dtMotoBike.Rows.Add("35", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_35.jpg", 56, 128, 99, 0);

            dtMotoBike.Rows.Add("36", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_36.jpg", 96, 321, 359, 1);

            dtMotoBike.Rows.Add("37", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_37.jpg", 172, 280, 204, 1);

            dtMotoBike.Rows.Add("38", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_38.jpg", 179, 229, 228, 1);

            dtMotoBike.Rows.Add("39", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_39.jpg", 281, 96, 295, 1);

            dtMotoBike.Rows.Add("40", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_40.jpg", 249, 214, 253, 0);

            dtMotoBike.Rows.Add("41", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_41.jpg", 89, 244, 221, 1);

            dtMotoBike.Rows.Add("42", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_42.jpg", 58, 277, 334, 0);

            dtMotoBike.Rows.Add("43", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_43.jpg", 188, 226, 200, 0);

            dtMotoBike.Rows.Add("44", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_44.jpg", 49, 177, 102, 0);

            dtMotoBike.Rows.Add("45", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_45.jpg", 103, 125, 302, 0);

            dtMotoBike.Rows.Add("46", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_46.jpg", 269, 219, 192, 1);

            dtMotoBike.Rows.Add("47", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_47.jpg", 279, 314, 297, 0);

            dtMotoBike.Rows.Add("48", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_48.jpg", 113, 117, 275, 1);

            dtMotoBike.Rows.Add("49", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_49.jpg", 115, 233, 113, 1);

            dtMotoBike.Rows.Add("50", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_50.jpg", 197, 264, 367, 1);

            dtMotoBike.Rows.Add("51", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_51.jpg", 178, 236, 203, 1);

            dtMotoBike.Rows.Add("52", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_52.jpg", 36, 341, 133, 1);

            dtMotoBike.Rows.Add("53", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_53.jpg", 192, 104, 182, 0);

            dtMotoBike.Rows.Add("54", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_54.jpg", 112, 232, 188, 0);

            dtMotoBike.Rows.Add("55", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_55.jpg", 35, 153, 117, 1);

            dtMotoBike.Rows.Add("56", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_56.jpg", 232, 316, 104, 0);

            dtMotoBike.Rows.Add("57", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_57.jpg", 288, 173, 219, 0);

            dtMotoBike.Rows.Add("58", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_58.jpg", 142, 309, 217, 0);

            dtMotoBike.Rows.Add("59", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_59.jpg", 240, 119, 166, 0);

            dtMotoBike.Rows.Add("60", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_60.jpg", 61, 157, 286, 1);

            dtMotoBike.Rows.Add("61", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_61.jpg", 74, 72, 293, 0);

            dtMotoBike.Rows.Add("62", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_62.jpg", 193, 135, 122, 0);

            dtMotoBike.Rows.Add("63", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_63.jpg", 63, 336, 208, 1);

            dtMotoBike.Rows.Add("64", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_64.jpg", 204, 97, 292, 1);

            dtMotoBike.Rows.Add("65", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_65.jpg", 203, 175, 137, 1);

            dtMotoBike.Rows.Add("66", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_66.jpg", 88, 286, 243, 1);

            dtMotoBike.Rows.Add("67", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_67.jpg", 231, 335, 140, 0);

            dtMotoBike.Rows.Add("68", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_68.jpg", 222, 116, 305, 0);

            dtMotoBike.Rows.Add("69", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_69.jpg", 117, 94, 189, 0);

            dtMotoBike.Rows.Add("70", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_70.jpg", 37, 270, 321, 0);

            dtMotoBike.Rows.Add("71", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_71.jpg", 107, 77, 350, 1);

            dtMotoBike.Rows.Add("72", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_72.jpg", 200, 339, 355, 1);

            dtMotoBike.Rows.Add("73", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_73.jpg", 135, 126, 165, 1);

            dtMotoBike.Rows.Add("74", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_74.jpg", 59, 348, 317, 0);

            dtMotoBike.Rows.Add("75", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_75.jpg", 126, 84, 278, 0);

            dtMotoBike.Rows.Add("76", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_76.jpg", 185, 199, 234, 0);

            dtMotoBike.Rows.Add("77", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_77.jpg", 217, 194, 156, 1);

            dtMotoBike.Rows.Add("78", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_78.jpg", 53, 78, 345, 0);

            dtMotoBike.Rows.Add("79", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_79.jpg", 265, 231, 360, 0);

            dtMotoBike.Rows.Add("80", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_80.jpg", 153, 217, 241, 1);

            dtMotoBike.Rows.Add("81", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_81.jpg", 255, 112, 124, 1);

            dtMotoBike.Rows.Add("82", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_82.jpg", 215, 203, 91, 1);

            dtMotoBike.Rows.Add("83", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_83.jpg", 173, 95, 90, 0);

            dtMotoBike.Rows.Add("84", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_84.jpg", 248, 136, 178, 1);

            dtMotoBike.Rows.Add("85", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_85.jpg", 282, 318, 207, 1);

            dtMotoBike.Rows.Add("86", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_86.jpg", 31, 172, 338, 0);

            dtMotoBike.Rows.Add("87", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_87.jpg", 32, 220, 346, 1);

            dtMotoBike.Rows.Add("88", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_88.jpg", 119, 160, 183, 0);

            dtMotoBike.Rows.Add("89", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_89.jpg", 102, 137, 303, 0);

            dtMotoBike.Rows.Add("90", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_90.jpg", 220, 191, 329, 1);

            dtMotoBike.Rows.Add("91", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_91.jpg", 99, 300, 209, 1);

            dtMotoBike.Rows.Add("92", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_92.jpg", 66, 85, 114, 0);

            dtMotoBike.Rows.Add("93", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_93.jpg", 79, 100, 348, 1);

            dtMotoBike.Rows.Add("94", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_94.jpg", 94, 230, 358, 1);

            dtMotoBike.Rows.Add("95", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_95.jpg", 286, 166, 211, 1);

            dtMotoBike.Rows.Add("96", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_96.jpg", 125, 288, 106, 1);

            dtMotoBike.Rows.Add("97", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_97.jpg", 109, 107, 118, 1);

            dtMotoBike.Rows.Add("98", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_98.jpg", 48, 80, 335, 0);

            dtMotoBike.Rows.Add("99", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_99.jpg", 264, 218, 136, 1);

            dtMotoBike.Rows.Add("100", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_100.jpg", 157, 215, 308, 1);

            dtMotoBike.Rows.Add("101", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_101.jpg", 148, 237, 222, 1);

            dtMotoBike.Rows.Add("102", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_102.jpg", 162, 88, 239, 0);

            dtMotoBike.Rows.Add("103", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_103.jpg", 140, 327, 212, 1);

            dtMotoBike.Rows.Add("104", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_104.jpg", 289, 211, 311, 0);

            dtMotoBike.Rows.Add("105", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_105.jpg", 180, 292, 129, 1);

            dtMotoBike.Rows.Add("106", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_106.jpg", 123, 257, 368, 1);

            dtMotoBike.Rows.Add("107", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_107.jpg", 141, 202, 128, 0);

            dtMotoBike.Rows.Add("108", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_108.jpg", 136, 338, 260, 0);

            dtMotoBike.Rows.Add("109", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_109.jpg", 43, 340, 232, 1);

            dtMotoBike.Rows.Add("110", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_110.jpg", 150, 228, 248, 0);

            dtMotoBike.Rows.Add("111", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_111.jpg", 69, 281, 267, 1);

            dtMotoBike.Rows.Add("112", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_112.jpg", 227, 90, 336, 1);

            dtMotoBike.Rows.Add("113", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_113.jpg", 168, 255, 354, 0);

            dtMotoBike.Rows.Add("114", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_114.jpg", 78, 76, 100, 1);

            dtMotoBike.Rows.Add("115", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_115.jpg", 206, 111, 184, 0);

            dtMotoBike.Rows.Add("116", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_116.jpg", 235, 121, 236, 1);

            dtMotoBike.Rows.Add("117", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_117.jpg", 86, 169, 322, 0);

            dtMotoBike.Rows.Add("118", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_118.jpg", 239, 284, 197, 1);

            dtMotoBike.Rows.Add("119", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_119.jpg", 237, 197, 116, 0);

            dtMotoBike.Rows.Add("120", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_120.jpg", 167, 208, 115, 0);

            dtMotoBike.Rows.Add("121", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_121.jpg", 216, 253, 340, 1);

            dtMotoBike.Rows.Add("122", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_122.jpg", 144, 334, 111, 1);

            dtMotoBike.Rows.Add("123", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_123.jpg", 224, 158, 288, 1);

            dtMotoBike.Rows.Add("124", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_124.jpg", 205, 337, 235, 0);

            dtMotoBike.Rows.Add("125", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_125.jpg", 183, 98, 298, 0);

            dtMotoBike.Rows.Add("126", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_126.jpg", 80, 144, 130, 0);

            dtMotoBike.Rows.Add("127", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_127.jpg", 116, 293, 176, 1);

            dtMotoBike.Rows.Add("128", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_128.jpg", 207, 131, 206, 1);

            dtMotoBike.Rows.Add("129", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_129.jpg", 84, 127, 306, 1);

            dtMotoBike.Rows.Add("130", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_130.jpg", 169, 247, 105, 0);

            dtMotoBike.Rows.Add("131", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_131.jpg", 247, 174, 237, 1);

            dtMotoBike.Rows.Add("132", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_132.jpg", 175, 200, 185, 1);

            dtMotoBike.Rows.Add("133", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_133.jpg", 272, 204, 349, 1);

            dtMotoBike.Rows.Add("134", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_134.jpg", 260, 155, 347, 0);

            dtMotoBike.Rows.Add("135", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_135.jpg", 177, 83, 319, 1);

            dtMotoBike.Rows.Add("136", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_136.jpg", 60, 114, 144, 0);

            dtMotoBike.Rows.Add("137", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_137.jpg", 33, 70, 191, 1);

            dtMotoBike.Rows.Add("138", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_138.jpg", 161, 133, 310, 0);

            dtMotoBike.Rows.Add("139", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_139.jpg", 171, 132, 168, 1);

            dtMotoBike.Rows.Add("140", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_140.jpg", 223, 223, 187, 1);

            dtMotoBike.Rows.Add("141", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_141.jpg", 81, 71, 328, 1);

            dtMotoBike.Rows.Add("142", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_142.jpg", 228, 124, 240, 0);

            dtMotoBike.Rows.Add("143", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_143.jpg", 138, 213, 198, 0);

            dtMotoBike.Rows.Add("144", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_144.jpg", 263, 150, 304, 0);

            dtMotoBike.Rows.Add("145", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_145.jpg", 151, 248, 299, 0);

            dtMotoBike.Rows.Add("146", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_146.jpg", 287, 265, 289, 0);

            dtMotoBike.Rows.Add("147", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_147.jpg", 64, 206, 261, 1);

            dtMotoBike.Rows.Add("148", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_148.jpg", 233, 91, 281, 0);

            dtMotoBike.Rows.Add("149", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_149.jpg", 50, 149, 351, 1);

            dtMotoBike.Rows.Add("150", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_150.jpg", 137, 273, 231, 1);

            dtMotoBike.Rows.Add("151", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_151.jpg", 158, 250, 120, 0);

            dtMotoBike.Rows.Add("152", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_152.jpg", 210, 138, 353, 0);

            dtMotoBike.Rows.Add("153", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_153.jpg", 257, 279, 148, 0);

            dtMotoBike.Rows.Add("154", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_154.jpg", 104, 271, 196, 1);

            dtMotoBike.Rows.Add("155", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_155.jpg", 65, 243, 357, 1);

            dtMotoBike.Rows.Add("156", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_156.jpg", 245, 156, 268, 0);

            dtMotoBike.Rows.Add("157", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_157.jpg", 258, 179, 272, 1);

            dtMotoBike.Rows.Add("158", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_158.jpg", 270, 176, 333, 0);

            dtMotoBike.Rows.Add("159", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_159.jpg", 163, 186, 157, 1);

            dtMotoBike.Rows.Add("160", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_160.jpg", 156, 274, 96, 1);

            dtMotoBike.Rows.Add("161", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_161.jpg", 194, 165, 119, 0);

            dtMotoBike.Rows.Add("162", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_162.jpg", 251, 289, 270, 0);

            dtMotoBike.Rows.Add("163", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_163.jpg", 259, 193, 201, 1);

            dtMotoBike.Rows.Add("164", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_164.jpg", 98, 75, 173, 1);

            dtMotoBike.Rows.Add("165", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_165.jpg", 114, 320, 171, 1);

            dtMotoBike.Rows.Add("166", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_166.jpg", 92, 164, 269, 0);

            dtMotoBike.Rows.Add("167", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_167.jpg", 46, 86, 215, 1);

            dtMotoBike.Rows.Add("168", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_168.jpg", 195, 324, 205, 0);

            dtMotoBike.Rows.Add("169", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_169.jpg", 108, 242, 279, 1);

            dtMotoBike.Rows.Add("170", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_170.jpg", 38, 195, 285, 0);

            dtMotoBike.Rows.Add("171", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_171.jpg", 145, 167, 180, 0);

            dtMotoBike.Rows.Add("172", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_172.jpg", 253, 130, 296, 1);

            dtMotoBike.Rows.Add("173", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_173.jpg", 160, 259, 94, 1);

            dtMotoBike.Rows.Add("174", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_174.jpg", 129, 311, 362, 1);

            dtMotoBike.Rows.Add("175", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_175.jpg", 87, 181, 259, 1);

            dtMotoBike.Rows.Add("176", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_176.jpg", 133, 245, 134, 1);

            dtMotoBike.Rows.Add("177", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_177.jpg", 118, 346, 161, 0);

            dtMotoBike.Rows.Add("178", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_178.jpg", 176, 246, 109, 0);

            dtMotoBike.Rows.Add("179", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_179.jpg", 266, 123, 252, 0);

            dtMotoBike.Rows.Add("180", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_180.jpg", 77, 323, 369, 1);

            dtMotoBike.Rows.Add("181", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_181.jpg", 262, 260, 339, 0);

            dtMotoBike.Rows.Add("182", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_182.jpg", 124, 171, 195, 1);

            dtMotoBike.Rows.Add("183", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_183.jpg", 95, 188, 283, 1);

            dtMotoBike.Rows.Add("184", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_184.jpg", 121, 267, 312, 1);

            dtMotoBike.Rows.Add("185", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_185.jpg", 147, 168, 179, 0);

            dtMotoBike.Rows.Add("186", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_186.jpg", 277, 92, 301, 1);

            dtMotoBike.Rows.Add("187", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_187.jpg", 130, 307, 309, 1);

            dtMotoBike.Rows.Add("188", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_188.jpg", 68, 192, 294, 1);

            dtMotoBike.Rows.Add("189", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_189.jpg", 241, 129, 186, 1);

            dtMotoBike.Rows.Add("190", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_190.jpg", 184, 278, 155, 0);

            dtMotoBike.Rows.Add("191", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_191.jpg", 39, 283, 190, 0);

            dtMotoBike.Rows.Add("192", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_192.jpg", 131, 139, 93, 1);

            dtMotoBike.Rows.Add("193", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_193.jpg", 143, 304, 315, 1);

            dtMotoBike.Rows.Add("194", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_194.jpg", 198, 331, 255, 0);

            dtMotoBike.Rows.Add("195", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_195.jpg", 47, 103, 143, 1);

            dtMotoBike.Rows.Add("196", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_196.jpg", 261, 317, 242, 1);

            dtMotoBike.Rows.Add("197", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_197.jpg", 271, 74, 218, 0);

            dtMotoBike.Rows.Add("198", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_198.jpg", 256, 225, 167, 1);

            dtMotoBike.Rows.Add("199", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_199.jpg", 275, 301, 307, 0);

            dtMotoBike.Rows.Add("200", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_200.jpg", 187, 347, 131, 0);

            dtMotoBike.Rows.Add("201", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_201.jpg", 212, 344, 110, 1);

            dtMotoBike.Rows.Add("202", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_202.jpg", 211, 185, 284, 1);

            dtMotoBike.Rows.Add("203", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_203.jpg", 285, 322, 326, 1);

            dtMotoBike.Rows.Add("204", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_204.jpg", 101, 101, 126, 0);

            dtMotoBike.Rows.Add("205", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_205.jpg", 82, 349, 273, 0);

            dtMotoBike.Rows.Add("206", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_206.jpg", 155, 142, 149, 1);

            dtMotoBike.Rows.Add("207", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_207.jpg", 93, 285, 256, 0);

            dtMotoBike.Rows.Add("208", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_208.jpg", 267, 254, 169, 0);

            dtMotoBike.Rows.Add("209", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_209.jpg", 226, 342, 365, 1);

            dtMotoBike.Rows.Add("210", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_210.jpg", 230, 306, 159, 0);

            dtMotoBike.Rows.Add("211", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_211.jpg", 120, 332, 274, 1);

            dtMotoBike.Rows.Add("212", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_212.jpg", 283, 198, 227, 1);

            dtMotoBike.Rows.Add("213", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_213.jpg", 273, 87, 103, 1);

            dtMotoBike.Rows.Add("214", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_214.jpg", 246, 182, 213, 0);

            dtMotoBike.Rows.Add("215", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_215.jpg", 199, 113, 92, 1);

            dtMotoBike.Rows.Add("216", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_216.jpg", 209, 299, 154, 1);

            dtMotoBike.Rows.Add("217", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_217.jpg", 105, 227, 123, 1);

            dtMotoBike.Rows.Add("218", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_218.jpg", 100, 105, 337, 1);

            dtMotoBike.Rows.Add("219", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_219.jpg", 90, 310, 177, 0);

            dtMotoBike.Rows.Add("220", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_220.jpg", 149, 256, 313, 1);

            dtMotoBike.Rows.Add("221", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_221.jpg", 30, 178, 314, 0);

            dtMotoBike.Rows.Add("222", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_222.jpg", 154, 308, 224, 0);

            dtMotoBike.Rows.Add("223", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_223.jpg", 71, 241, 290, 0);

            dtMotoBike.Rows.Add("224", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_224.jpg", 152, 258, 366, 1);

            dtMotoBike.Rows.Add("225", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_225.jpg", 278, 224, 229, 0);

            dtMotoBike.Rows.Add("226", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_226.jpg", 219, 315, 150, 0);

            dtMotoBike.Rows.Add("227", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_227.jpg", 242, 180, 151, 0);

            dtMotoBike.Rows.Add("228", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_228.jpg", 91, 291, 320, 0);

            dtMotoBike.Rows.Add("229", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_229.jpg", 280, 151, 251, 0);

            dtMotoBike.Rows.Add("230", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_230.jpg", 191, 106, 174, 1);

            dtMotoBike.Rows.Add("231", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_231.jpg", 127, 319, 145, 1);

            dtMotoBike.Rows.Add("232", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_232.jpg", 70, 141, 287, 0);

            dtMotoBike.Rows.Add("233", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_233.jpg", 174, 93, 141, 1);

            dtMotoBike.Rows.Add("234", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_234.jpg", 214, 210, 325, 0);

            dtMotoBike.Rows.Add("235", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_235.jpg", 218, 162, 300, 1);

            dtMotoBike.Rows.Add("236", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_236.jpg", 252, 152, 202, 1);

            dtMotoBike.Rows.Add("237", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_237.jpg", 165, 216, 164, 1);

            dtMotoBike.Rows.Add("238", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_238.jpg", 236, 163, 291, 1);

            dtMotoBike.Rows.Add("239", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_239.jpg", 186, 343, 216, 0);

            dtMotoBike.Rows.Add("240", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_240.jpg", 34, 82, 246, 0);

            dtMotoBike.Rows.Add("241", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_241.jpg", 51, 115, 265, 0);

            dtMotoBike.Rows.Add("242", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_242.jpg", 40, 122, 138, 1);
            //////////////////////////////////////////// ADD THE DATA FOR FOREST CATEGORIZED ////////////////////////////////////////////////////////
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            dtForest.Rows.Add("1", "FOREST", @"../../UsedForResource/Forest/Forest_1.jpg", 272, 171, 251, 1);

            dtForest.Rows.Add("2", "FOREST", @"../../UsedForResource/Forest/Forest_2.jpg", 265, 311, 125, 0);

            dtForest.Rows.Add("3", "FOREST", @"../../UsedForResource/Forest/Forest_3.jpg", 204, 315, 302, 0);

            dtForest.Rows.Add("4", "FOREST", @"../../UsedForResource/Forest/Forest_4.jpg", 105, 384, 249, 1);

            dtForest.Rows.Add("5", "FOREST", @"../../UsedForResource/Forest/Forest_5.jpg", 261, 181, 204, 0);

            dtForest.Rows.Add("6", "FOREST", @"../../UsedForResource/Forest/Forest_6.jpg", 290, 156, 277, 1);

            dtForest.Rows.Add("7", "FOREST", @"../../UsedForResource/Forest/Forest_7.jpg", 190, 321, 341, 0);

            dtForest.Rows.Add("8", "FOREST", @"../../UsedForResource/Forest/Forest_8.jpg", 170, 120, 255, 0);

            dtForest.Rows.Add("9", "FOREST", @"../../UsedForResource/Forest/Forest_9.jpg", 207, 163, 262, 1);

            dtForest.Rows.Add("10", "FOREST", @"../../UsedForResource/Forest/Forest_10.jpg", 221, 331, 155, 0);

            dtForest.Rows.Add("11", "FOREST", @"../../UsedForResource/Forest/Forest_11.jpg", 193, 218, 287, 0);

            dtForest.Rows.Add("12", "FOREST", @"../../UsedForResource/Forest/Forest_12.jpg", 56, 119, 158, 1);

            dtForest.Rows.Add("13", "FOREST", @"../../UsedForResource/Forest/Forest_13.jpg", 239, 216, 205, 0);

            dtForest.Rows.Add("14", "FOREST", @"../../UsedForResource/Forest/Forest_14.jpg", 111, 363, 164, 1);

            dtForest.Rows.Add("15", "FOREST", @"../../UsedForResource/Forest/Forest_15.jpg", 232, 155, 220, 0);

            dtForest.Rows.Add("16", "FOREST", @"../../UsedForResource/Forest/Forest_16.jpg", 116, 304, 231, 1);

            dtForest.Rows.Add("17", "FOREST", @"../../UsedForResource/Forest/Forest_17.jpg", 174, 302, 135, 0);

            dtForest.Rows.Add("18", "FOREST", @"../../UsedForResource/Forest/Forest_18.jpg", 118, 96, 241, 0);

            dtForest.Rows.Add("19", "FOREST", @"../../UsedForResource/Forest/Forest_19.jpg", 242, 169, 173, 1);

            dtForest.Rows.Add("20", "FOREST", @"../../UsedForResource/Forest/Forest_20.jpg", 153, 78, 137, 0);

            dtForest.Rows.Add("21", "FOREST", @"../../UsedForResource/Forest/Forest_21.jpg", 60, 359, 269, 0);

            dtForest.Rows.Add("22", "FOREST", @"../../UsedForResource/Forest/Forest_22.jpg", 81, 85, 156, 0);

            dtForest.Rows.Add("23", "FOREST", @"../../UsedForResource/Forest/Forest_23.jpg", 233, 284, 130, 1);

            dtForest.Rows.Add("24", "FOREST", @"../../UsedForResource/Forest/Forest_24.jpg", 78, 189, 278, 1);

            dtForest.Rows.Add("25", "FOREST", @"../../UsedForResource/Forest/Forest_25.jpg", 168, 177, 285, 1);

            dtForest.Rows.Add("26", "FOREST", @"../../UsedForResource/Forest/Forest_26.jpg", 54, 93, 244, 0);

            dtForest.Rows.Add("27", "FOREST", @"../../UsedForResource/Forest/Forest_27.jpg", 262, 194, 206, 0);

            dtForest.Rows.Add("28", "FOREST", @"../../UsedForResource/Forest/Forest_28.jpg", 152, 199, 113, 1);

            dtForest.Rows.Add("29", "FOREST", @"../../UsedForResource/Forest/Forest_29.jpg", 205, 159, 218, 0);

            dtForest.Rows.Add("30", "FOREST", @"../../UsedForResource/Forest/Forest_30.jpg", 59, 200, 141, 1);

            dtForest.Rows.Add("31", "FOREST", @"../../UsedForResource/Forest/Forest_31.jpg", 264, 387, 111, 1);

            dtForest.Rows.Add("32", "FOREST", @"../../UsedForResource/Forest/Forest_32.jpg", 202, 364, 326, 1);

            dtForest.Rows.Add("33", "FOREST", @"../../UsedForResource/Forest/Forest_33.jpg", 283, 165, 102, 1);

            dtForest.Rows.Add("34", "FOREST", @"../../UsedForResource/Forest/Forest_34.jpg", 240, 323, 189, 1);

            dtForest.Rows.Add("35", "FOREST", @"../../UsedForResource/Forest/Forest_35.jpg", 176, 366, 268, 1);

            dtForest.Rows.Add("36", "FOREST", @"../../UsedForResource/Forest/Forest_36.jpg", 249, 277, 292, 0);

            dtForest.Rows.Add("37", "FOREST", @"../../UsedForResource/Forest/Forest_37.jpg", 208, 174, 172, 0);

            dtForest.Rows.Add("38", "FOREST", @"../../UsedForResource/Forest/Forest_38.jpg", 93, 95, 139, 1);

            dtForest.Rows.Add("39", "FOREST", @"../../UsedForResource/Forest/Forest_39.jpg", 103, 367, 165, 1);

            dtForest.Rows.Add("40", "FOREST", @"../../UsedForResource/Forest/Forest_40.jpg", 76, 82, 202, 1);

            dtForest.Rows.Add("41", "FOREST", @"../../UsedForResource/Forest/Forest_41.jpg", 199, 127, 143, 1);

            dtForest.Rows.Add("42", "FOREST", @"../../UsedForResource/Forest/Forest_42.jpg", 219, 148, 103, 1);

            dtForest.Rows.Add("43", "FOREST", @"../../UsedForResource/Forest/Forest_43.jpg", 64, 184, 117, 0);

            dtForest.Rows.Add("44", "FOREST", @"../../UsedForResource/Forest/Forest_44.jpg", 159, 131, 196, 0);

            dtForest.Rows.Add("45", "FOREST", @"../../UsedForResource/Forest/Forest_45.jpg", 194, 289, 340, 1);

            dtForest.Rows.Add("46", "FOREST", @"../../UsedForResource/Forest/Forest_46.jpg", 139, 275, 329, 1);

            dtForest.Rows.Add("47", "FOREST", @"../../UsedForResource/Forest/Forest_47.jpg", 184, 161, 330, 0);

            dtForest.Rows.Add("48", "FOREST", @"../../UsedForResource/Forest/Forest_48.jpg", 252, 225, 105, 1);

            dtForest.Rows.Add("49", "FOREST", @"../../UsedForResource/Forest/Forest_49.jpg", 213, 300, 161, 1);

            dtForest.Rows.Add("50", "FOREST", @"../../UsedForResource/Forest/Forest_50.jpg", 165, 205, 279, 0);

            dtForest.Rows.Add("51", "FOREST", @"../../UsedForResource/Forest/Forest_51.jpg", 178, 246, 150, 1);

            dtForest.Rows.Add("52", "FOREST", @"../../UsedForResource/Forest/Forest_52.jpg", 285, 88, 325, 0);

            dtForest.Rows.Add("53", "FOREST", @"../../UsedForResource/Forest/Forest_53.jpg", 268, 94, 168, 0);

            dtForest.Rows.Add("54", "FOREST", @"../../UsedForResource/Forest/Forest_54.jpg", 189, 235, 169, 0);

            dtForest.Rows.Add("55", "FOREST", @"../../UsedForResource/Forest/Forest_55.jpg", 114, 341, 298, 0);

            dtForest.Rows.Add("56", "FOREST", @"../../UsedForResource/Forest/Forest_56.jpg", 133, 215, 142, 0);

            dtForest.Rows.Add("57", "FOREST", @"../../UsedForResource/Forest/Forest_57.jpg", 181, 76, 252, 1);

            dtForest.Rows.Add("58", "FOREST", @"../../UsedForResource/Forest/Forest_58.jpg", 286, 264, 270, 1);

            dtForest.Rows.Add("59", "FOREST", @"../../UsedForResource/Forest/Forest_59.jpg", 125, 137, 214, 1);

            dtForest.Rows.Add("60", "FOREST", @"../../UsedForResource/Forest/Forest_60.jpg", 229, 211, 124, 0);

            dtForest.Rows.Add("61", "FOREST", @"../../UsedForResource/Forest/Forest_61.jpg", 80, 108, 170, 0);

            dtForest.Rows.Add("62", "FOREST", @"../../UsedForResource/Forest/Forest_62.jpg", 65, 374, 338, 1);

            dtForest.Rows.Add("63", "FOREST", @"../../UsedForResource/Forest/Forest_63.jpg", 142, 173, 229, 1);

            dtForest.Rows.Add("64", "FOREST", @"../../UsedForResource/Forest/Forest_64.jpg", 230, 175, 321, 0);

            dtForest.Rows.Add("65", "FOREST", @"../../UsedForResource/Forest/Forest_65.jpg", 236, 326, 216, 0);

            dtForest.Rows.Add("66", "FOREST", @"../../UsedForResource/Forest/Forest_66.jpg", 113, 217, 336, 0);

            dtForest.Rows.Add("67", "FOREST", @"../../UsedForResource/Forest/Forest_67.jpg", 164, 308, 267, 0);

            dtForest.Rows.Add("68", "FOREST", @"../../UsedForResource/Forest/Forest_68.jpg", 101, 269, 122, 1);

            dtForest.Rows.Add("69", "FOREST", @"../../UsedForResource/Forest/Forest_69.jpg", 200, 383, 219, 0);

            dtForest.Rows.Add("70", "FOREST", @"../../UsedForResource/Forest/Forest_70.jpg", 248, 142, 114, 0);

            dtForest.Rows.Add("71", "FOREST", @"../../UsedForResource/Forest/Forest_71.jpg", 70, 219, 316, 0);

            dtForest.Rows.Add("72", "FOREST", @"../../UsedForResource/Forest/Forest_72.jpg", 88, 154, 226, 1);

            dtForest.Rows.Add("73", "FOREST", @"../../UsedForResource/Forest/Forest_73.jpg", 237, 342, 195, 0);

            dtForest.Rows.Add("74", "FOREST", @"../../UsedForResource/Forest/Forest_74.jpg", 244, 365, 232, 0);

            dtForest.Rows.Add("75", "FOREST", @"../../UsedForResource/Forest/Forest_75.jpg", 163, 361, 188, 0);

            dtForest.Rows.Add("76", "FOREST", @"../../UsedForResource/Forest/Forest_76.jpg", 155, 313, 166, 1);

            dtForest.Rows.Add("77", "FOREST", @"../../UsedForResource/Forest/Forest_77.jpg", 173, 241, 110, 1);

            dtForest.Rows.Add("78", "FOREST", @"../../UsedForResource/Forest/Forest_78.jpg", 144, 337, 240, 1);

            dtForest.Rows.Add("79", "FOREST", @"../../UsedForResource/Forest/Forest_79.jpg", 271, 230, 118, 0);

            dtForest.Rows.Add("80", "FOREST", @"../../UsedForResource/Forest/Forest_80.jpg", 119, 204, 343, 1);

            dtForest.Rows.Add("81", "FOREST", @"../../UsedForResource/Forest/Forest_81.jpg", 246, 345, 144, 1);

            dtForest.Rows.Add("82", "FOREST", @"../../UsedForResource/Forest/Forest_82.jpg", 145, 183, 154, 0);

            dtForest.Rows.Add("83", "FOREST", @"../../UsedForResource/Forest/Forest_83.jpg", 227, 170, 342, 1);

            dtForest.Rows.Add("84", "FOREST", @"../../UsedForResource/Forest/Forest_84.jpg", 253, 209, 289, 1);

            dtForest.Rows.Add("85", "FOREST", @"../../UsedForResource/Forest/Forest_85.jpg", 250, 340, 317, 1);

            dtForest.Rows.Add("86", "FOREST", @"../../UsedForResource/Forest/Forest_86.jpg", 195, 201, 133, 0);

            dtForest.Rows.Add("87", "FOREST", @"../../UsedForResource/Forest/Forest_87.jpg", 209, 370, 185, 1);

            dtForest.Rows.Add("88", "FOREST", @"../../UsedForResource/Forest/Forest_88.jpg", 91, 239, 160, 1);

            dtForest.Rows.Add("89", "FOREST", @"../../UsedForResource/Forest/Forest_89.jpg", 217, 375, 235, 1);

            dtForest.Rows.Add("90", "FOREST", @"../../UsedForResource/Forest/Forest_90.jpg", 131, 280, 109, 1);

            dtForest.Rows.Add("91", "FOREST", @"../../UsedForResource/Forest/Forest_91.jpg", 110, 309, 248, 0);

            dtForest.Rows.Add("92", "FOREST", @"../../UsedForResource/Forest/Forest_92.jpg", 284, 390, 192, 1);

            dtForest.Rows.Add("93", "FOREST", @"../../UsedForResource/Forest/Forest_93.jpg", 100, 116, 200, 1);

            dtForest.Rows.Add("94", "FOREST", @"../../UsedForResource/Forest/Forest_94.jpg", 186, 376, 324, 1);

            dtForest.Rows.Add("95", "FOREST", @"../../UsedForResource/Forest/Forest_95.jpg", 212, 207, 256, 0);

            dtForest.Rows.Add("96", "FOREST", @"../../UsedForResource/Forest/Forest_96.jpg", 77, 385, 182, 1);

            dtForest.Rows.Add("97", "FOREST", @"../../UsedForResource/Forest/Forest_97.jpg", 215, 139, 273, 1);

            dtForest.Rows.Add("98", "FOREST", @"../../UsedForResource/Forest/Forest_98.jpg", 179, 355, 323, 1);

            dtForest.Rows.Add("99", "FOREST", @"../../UsedForResource/Forest/Forest_99.jpg", 222, 261, 210, 0);

            dtForest.Rows.Add("100", "FOREST", @"../../UsedForResource/Forest/Forest_100.jpg", 92, 336, 288, 1);

            dtForest.Rows.Add("101", "FOREST", @"../../UsedForResource/Forest/Forest_101.jpg", 102, 234, 112, 1);

            dtForest.Rows.Add("102", "FOREST", @"../../UsedForResource/Forest/Forest_102.jpg", 53, 293, 320, 0);

            dtForest.Rows.Add("103", "FOREST", @"../../UsedForResource/Forest/Forest_103.jpg", 126, 123, 259, 0);

            dtForest.Rows.Add("104", "FOREST", @"../../UsedForResource/Forest/Forest_104.jpg", 247, 73, 281, 0);

            dtForest.Rows.Add("105", "FOREST", @"../../UsedForResource/Forest/Forest_105.jpg", 89, 122, 104, 0);

            dtForest.Rows.Add("106", "FOREST", @"../../UsedForResource/Forest/Forest_106.jpg", 157, 130, 222, 1);

            dtForest.Rows.Add("107", "FOREST", @"../../UsedForResource/Forest/Forest_107.jpg", 277, 265, 282, 1);

            dtForest.Rows.Add("108", "FOREST", @"../../UsedForResource/Forest/Forest_108.jpg", 148, 396, 293, 0);

            dtForest.Rows.Add("109", "FOREST", @"../../UsedForResource/Forest/Forest_109.jpg", 160, 233, 274, 1);

            dtForest.Rows.Add("110", "FOREST", @"../../UsedForResource/Forest/Forest_110.jpg", 235, 295, 245, 1);

            dtForest.Rows.Add("111", "FOREST", @"../../UsedForResource/Forest/Forest_111.jpg", 124, 140, 332, 0);

            dtForest.Rows.Add("112", "FOREST", @"../../UsedForResource/Forest/Forest_112.jpg", 182, 105, 242, 1);

            dtForest.Rows.Add("113", "FOREST", @"../../UsedForResource/Forest/Forest_113.jpg", 276, 187, 344, 0);

            dtForest.Rows.Add("114", "FOREST", @"../../UsedForResource/Forest/Forest_114.jpg", 109, 271, 290, 0);

            dtForest.Rows.Add("115", "FOREST", @"../../UsedForResource/Forest/Forest_115.jpg", 154, 110, 119, 1);

            dtForest.Rows.Add("116", "FOREST", @"../../UsedForResource/Forest/Forest_116.jpg", 270, 121, 254, 1);

            dtForest.Rows.Add("117", "FOREST", @"../../UsedForResource/Forest/Forest_117.jpg", 185, 86, 265, 0);

            dtForest.Rows.Add("118", "FOREST", @"../../UsedForResource/Forest/Forest_118.jpg", 295, 272, 184, 1);

            dtForest.Rows.Add("119", "FOREST", @"../../UsedForResource/Forest/Forest_119.jpg", 169, 350, 315, 0);

            dtForest.Rows.Add("120", "FOREST", @"../../UsedForResource/Forest/Forest_120.jpg", 259, 176, 318, 0);

            dtForest.Rows.Add("121", "FOREST", @"../../UsedForResource/Forest/Forest_121.jpg", 231, 389, 308, 1);

            dtForest.Rows.Add("122", "FOREST", @"../../UsedForResource/Forest/Forest_122.jpg", 112, 353, 225, 1);

            dtForest.Rows.Add("123", "FOREST", @"../../UsedForResource/Forest/Forest_123.jpg", 83, 319, 145, 1);

            dtForest.Rows.Add("124", "FOREST", @"../../UsedForResource/Forest/Forest_124.jpg", 66, 286, 237, 1);

            dtForest.Rows.Add("125", "FOREST", @"../../UsedForResource/Forest/Forest_125.jpg", 260, 254, 180, 1);

            dtForest.Rows.Add("126", "FOREST", @"../../UsedForResource/Forest/Forest_126.jpg", 106, 257, 193, 1);

            dtForest.Rows.Add("127", "FOREST", @"../../UsedForResource/Forest/Forest_127.jpg", 68, 368, 280, 1);

            dtForest.Rows.Add("128", "FOREST", @"../../UsedForResource/Forest/Forest_128.jpg", 269, 77, 333, 1);

            dtForest.Rows.Add("129", "FOREST", @"../../UsedForResource/Forest/Forest_129.jpg", 175, 377, 300, 1);

            dtForest.Rows.Add("130", "FOREST", @"../../UsedForResource/Forest/Forest_130.jpg", 86, 344, 123, 1);

            dtForest.Rows.Add("131", "FOREST", @"../../UsedForResource/Forest/Forest_131.jpg", 129, 79, 208, 1);

            dtForest.Rows.Add("132", "FOREST", @"../../UsedForResource/Forest/Forest_132.jpg", 61, 343, 258, 0);

            dtForest.Rows.Add("133", "FOREST", @"../../UsedForResource/Forest/Forest_133.jpg", 55, 332, 239, 0);

            dtForest.Rows.Add("134", "FOREST", @"../../UsedForResource/Forest/Forest_134.jpg", 58, 399, 159, 0);

            dtForest.Rows.Add("135", "FOREST", @"../../UsedForResource/Forest/Forest_135.jpg", 71, 226, 126, 0);

            dtForest.Rows.Add("136", "FOREST", @"../../UsedForResource/Forest/Forest_136.jpg", 146, 192, 179, 1);

            dtForest.Rows.Add("137", "FOREST", @"../../UsedForResource/Forest/Forest_137.jpg", 50, 282, 101, 0);

            dtForest.Rows.Add("138", "FOREST", @"../../UsedForResource/Forest/Forest_138.jpg", 73, 111, 234, 0);

            dtForest.Rows.Add("139", "FOREST", @"../../UsedForResource/Forest/Forest_139.jpg", 74, 372, 108, 1);

            dtForest.Rows.Add("140", "FOREST", @"../../UsedForResource/Forest/Forest_140.jpg", 220, 222, 304, 1);

            dtForest.Rows.Add("141", "FOREST", @"../../UsedForResource/Forest/Forest_141.jpg", 288, 393, 129, 0);

            dtForest.Rows.Add("142", "FOREST", @"../../UsedForResource/Forest/Forest_142.jpg", 210, 198, 322, 0);

            dtForest.Rows.Add("143", "FOREST", @"../../UsedForResource/Forest/Forest_143.jpg", 141, 185, 203, 1);

            dtForest.Rows.Add("144", "FOREST", @"../../UsedForResource/Forest/Forest_144.jpg", 243, 322, 349, 0);

            dtForest.Rows.Add("145", "FOREST", @"../../UsedForResource/Forest/Forest_145.jpg", 293, 132, 310, 1);

            dtForest.Rows.Add("146", "FOREST", @"../../UsedForResource/Forest/Forest_146.jpg", 211, 141, 257, 0);

            dtForest.Rows.Add("147", "FOREST", @"../../UsedForResource/Forest/Forest_147.jpg", 156, 188, 283, 0);

            dtForest.Rows.Add("148", "FOREST", @"../../UsedForResource/Forest/Forest_148.jpg", 291, 380, 115, 1);

            dtForest.Rows.Add("149", "FOREST", @"../../UsedForResource/Forest/Forest_149.jpg", 128, 91, 271, 1);

            dtForest.Rows.Add("150", "FOREST", @"../../UsedForResource/Forest/Forest_150.jpg", 149, 237, 138, 1);

            dtForest.Rows.Add("151", "FOREST", @"../../UsedForResource/Forest/Forest_151.jpg", 257, 249, 134, 0);

            dtForest.Rows.Add("152", "FOREST", @"../../UsedForResource/Forest/Forest_152.jpg", 266, 258, 128, 1);

            dtForest.Rows.Add("153", "FOREST", @"../../UsedForResource/Forest/Forest_153.jpg", 280, 109, 136, 0);

            dtForest.Rows.Add("154", "FOREST", @"../../UsedForResource/Forest/Forest_154.jpg", 226, 172, 335, 0);

            dtForest.Rows.Add("155", "FOREST", @"../../UsedForResource/Forest/Forest_155.jpg", 218, 347, 207, 0);

            dtForest.Rows.Add("156", "FOREST", @"../../UsedForResource/Forest/Forest_156.jpg", 67, 107, 127, 0);

            dtForest.Rows.Add("157", "FOREST", @"../../UsedForResource/Forest/Forest_157.jpg", 134, 102, 295, 0);

            dtForest.Rows.Add("158", "FOREST", @"../../UsedForResource/Forest/Forest_158.jpg", 85, 179, 309, 1);

            dtForest.Rows.Add("159", "FOREST", @"../../UsedForResource/Forest/Forest_159.jpg", 95, 92, 286, 0);

            dtForest.Rows.Add("160", "FOREST", @"../../UsedForResource/Forest/Forest_160.jpg", 97, 316, 260, 0);

            dtForest.Rows.Add("161", "FOREST", @"../../UsedForResource/Forest/Forest_161.jpg", 214, 301, 264, 1);

            dtForest.Rows.Add("162", "FOREST", @"../../UsedForResource/Forest/Forest_162.jpg", 108, 71, 299, 0);

            dtForest.Rows.Add("163", "FOREST", @"../../UsedForResource/Forest/Forest_163.jpg", 132, 310, 209, 0);

            dtForest.Rows.Add("164", "FOREST", @"../../UsedForResource/Forest/Forest_164.jpg", 203, 244, 217, 0);

            dtForest.Rows.Add("165", "FOREST", @"../../UsedForResource/Forest/Forest_165.jpg", 62, 381, 187, 1);

            dtForest.Rows.Add("166", "FOREST", @"../../UsedForResource/Forest/Forest_166.jpg", 256, 202, 294, 1);

            dtForest.Rows.Add("167", "FOREST", @"../../UsedForResource/Forest/Forest_167.jpg", 255, 283, 116, 1);

            dtForest.Rows.Add("168", "FOREST", @"../../UsedForResource/Forest/Forest_168.jpg", 258, 99, 253, 1);

            dtForest.Rows.Add("169", "FOREST", @"../../UsedForResource/Forest/Forest_169.jpg", 57, 334, 152, 0);

            dtForest.Rows.Add("170", "FOREST", @"../../UsedForResource/Forest/Forest_170.jpg", 273, 113, 233, 0);

            dtForest.Rows.Add("171", "FOREST", @"../../UsedForResource/Forest/Forest_171.jpg", 161, 351, 223, 1);

            dtForest.Rows.Add("172", "FOREST", @"../../UsedForResource/Forest/Forest_172.jpg", 98, 98, 171, 0);

            dtForest.Rows.Add("173", "FOREST", @"../../UsedForResource/Forest/Forest_173.jpg", 216, 223, 181, 0);

            dtForest.Rows.Add("174", "FOREST", @"../../UsedForResource/Forest/Forest_174.jpg", 292, 138, 174, 1);

            dtForest.Rows.Add("175", "FOREST", @"../../UsedForResource/Forest/Forest_175.jpg", 183, 325, 213, 1);

            dtForest.Rows.Add("176", "FOREST", @"../../UsedForResource/Forest/Forest_176.jpg", 136, 90, 243, 1);

            dtForest.Rows.Add("177", "FOREST", @"../../UsedForResource/Forest/Forest_177.jpg", 96, 231, 186, 1);

            dtForest.Rows.Add("178", "FOREST", @"../../UsedForResource/Forest/Forest_178.jpg", 84, 324, 306, 0);

            dtForest.Rows.Add("179", "FOREST", @"../../UsedForResource/Forest/Forest_179.jpg", 198, 263, 163, 1);

            dtForest.Rows.Add("180", "FOREST", @"../../UsedForResource/Forest/Forest_180.jpg", 223, 243, 276, 1);

            dtForest.Rows.Add("181", "FOREST", @"../../UsedForResource/Forest/Forest_181.jpg", 147, 83, 149, 1);

            dtForest.Rows.Add("182", "FOREST", @"../../UsedForResource/Forest/Forest_182.jpg", 122, 298, 228, 0);

            dtForest.Rows.Add("183", "FOREST", @"../../UsedForResource/Forest/Forest_183.jpg", 127, 206, 162, 0);

            dtForest.Rows.Add("184", "FOREST", @"../../UsedForResource/Forest/Forest_184.jpg", 162, 89, 348, 0);

            dtForest.Rows.Add("185", "FOREST", @"../../UsedForResource/Forest/Forest_185.jpg", 287, 221, 177, 0);

            dtForest.Rows.Add("186", "FOREST", @"../../UsedForResource/Forest/Forest_186.jpg", 166, 153, 167, 1);

            dtForest.Rows.Add("187", "FOREST", @"../../UsedForResource/Forest/Forest_187.jpg", 120, 84, 266, 0);

            dtForest.Rows.Add("188", "FOREST", @"../../UsedForResource/Forest/Forest_188.jpg", 137, 378, 190, 0);

            dtForest.Rows.Add("189", "FOREST", @"../../UsedForResource/Forest/Forest_189.jpg", 115, 369, 311, 1);

            dtForest.Rows.Add("190", "FOREST", @"../../UsedForResource/Forest/Forest_190.jpg", 294, 128, 157, 1);

            dtForest.Rows.Add("191", "FOREST", @"../../UsedForResource/Forest/Forest_191.jpg", 225, 391, 151, 0);

            dtForest.Rows.Add("192", "FOREST", @"../../UsedForResource/Forest/Forest_192.jpg", 82, 134, 296, 1);

            dtForest.Rows.Add("193", "FOREST", @"../../UsedForResource/Forest/Forest_193.jpg", 281, 268, 307, 0);

            dtForest.Rows.Add("194", "FOREST", @"../../UsedForResource/Forest/Forest_194.jpg", 143, 273, 346, 0);

            dtForest.Rows.Add("195", "FOREST", @"../../UsedForResource/Forest/Forest_195.jpg", 121, 203, 201, 0);

            dtForest.Rows.Add("196", "FOREST", @"../../UsedForResource/Forest/Forest_196.jpg", 167, 291, 339, 1);

            dtForest.Rows.Add("197", "FOREST", @"../../UsedForResource/Forest/Forest_197.jpg", 130, 327, 106, 0);

            dtForest.Rows.Add("198", "FOREST", @"../../UsedForResource/Forest/Forest_198.jpg", 94, 398, 291, 0);

            dtForest.Rows.Add("199", "FOREST", @"../../UsedForResource/Forest/Forest_199.jpg", 172, 314, 224, 1);

            dtForest.Rows.Add("200", "FOREST", @"../../UsedForResource/Forest/Forest_200.jpg", 274, 210, 261, 0);

            dtForest.Rows.Add("201", "FOREST", @"../../UsedForResource/Forest/Forest_201.jpg", 197, 125, 246, 0);

            dtForest.Rows.Add("202", "FOREST", @"../../UsedForResource/Forest/Forest_202.jpg", 158, 285, 319, 0);

            dtForest.Rows.Add("203", "FOREST", @"../../UsedForResource/Forest/Forest_203.jpg", 117, 166, 345, 1);

            dtForest.Rows.Add("204", "FOREST", @"../../UsedForResource/Forest/Forest_204.jpg", 135, 329, 221, 1);

            dtForest.Rows.Add("205", "FOREST", @"../../UsedForResource/Forest/Forest_205.jpg", 52, 297, 250, 0);
            //////////////////////////////////////////// ADD THE DATA FOR FLOWER CATEGORIZED ////////////////////////////////////////////////////////
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            dtFlower.Rows.Add("1", "FLOWER", @"../../UsedForResource/Flower/Flower_1.jpg", 62, 245, 396, 1);

            dtFlower.Rows.Add("2", "FLOWER", @"../../UsedForResource/Flower/Flower_2.jpg", 103, 244, 164, 0);

            dtFlower.Rows.Add("3", "FLOWER", @"../../UsedForResource/Flower/Flower_3.jpg", 201, 184, 274, 0);

            dtFlower.Rows.Add("4", "FLOWER", @"../../UsedForResource/Flower/Flower_4.jpg", 170, 379, 291, 1);

            dtFlower.Rows.Add("5", "FLOWER", @"../../UsedForResource/Flower/Flower_5.jpg", 74, 252, 371, 0);

            dtFlower.Rows.Add("6", "FLOWER", @"../../UsedForResource/Flower/Flower_6.jpg", 81, 312, 252, 0);

            dtFlower.Rows.Add("7", "FLOWER", @"../../UsedForResource/Flower/Flower_7.jpg", 196, 321, 209, 1);

            dtFlower.Rows.Add("8", "FLOWER", @"../../UsedForResource/Flower/Flower_8.jpg", 84, 272, 369, 1);

            dtFlower.Rows.Add("9", "FLOWER", @"../../UsedForResource/Flower/Flower_9.jpg", 126, 275, 175, 1);

            dtFlower.Rows.Add("10", "FLOWER", @"../../UsedForResource/Flower/Flower_10.jpg", 86, 276, 346, 1);

            dtFlower.Rows.Add("11", "FLOWER", @"../../UsedForResource/Flower/Flower_11.jpg", 136, 346, 240, 0);

            dtFlower.Rows.Add("12", "FLOWER", @"../../UsedForResource/Flower/Flower_12.jpg", 131, 194, 182, 0);

            dtFlower.Rows.Add("13", "FLOWER", @"../../UsedForResource/Flower/Flower_13.jpg", 70, 251, 408, 1);

            dtFlower.Rows.Add("14", "FLOWER", @"../../UsedForResource/Flower/Flower_14.jpg", 182, 316, 362, 1);

            dtFlower.Rows.Add("15", "FLOWER", @"../../UsedForResource/Flower/Flower_15.jpg", 216, 295, 394, 1);

            dtFlower.Rows.Add("16", "FLOWER", @"../../UsedForResource/Flower/Flower_16.jpg", 225, 371, 187, 1);

            dtFlower.Rows.Add("17", "FLOWER", @"../../UsedForResource/Flower/Flower_17.jpg", 69, 218, 307, 0);

            dtFlower.Rows.Add("18", "FLOWER", @"../../UsedForResource/Flower/Flower_18.jpg", 111, 122, 272, 1);

            dtFlower.Rows.Add("19", "FLOWER", @"../../UsedForResource/Flower/Flower_19.jpg", 129, 215, 349, 0);

            dtFlower.Rows.Add("20", "FLOWER", @"../../UsedForResource/Flower/Flower_20.jpg", 192, 361, 409, 1);

            dtFlower.Rows.Add("21", "FLOWER", @"../../UsedForResource/Flower/Flower_21.jpg", 157, 367, 180, 0);

            dtFlower.Rows.Add("22", "FLOWER", @"../../UsedForResource/Flower/Flower_22.jpg", 47, 389, 360, 1);

            dtFlower.Rows.Add("23", "FLOWER", @"../../UsedForResource/Flower/Flower_23.jpg", 133, 249, 379, 1);

            dtFlower.Rows.Add("24", "FLOWER", @"../../UsedForResource/Flower/Flower_24.jpg", 150, 271, 338, 1);

            dtFlower.Rows.Add("25", "FLOWER", @"../../UsedForResource/Flower/Flower_25.jpg", 121, 230, 418, 0);

            dtFlower.Rows.Add("26", "FLOWER", @"../../UsedForResource/Flower/Flower_26.jpg", 93, 139, 380, 1);

            dtFlower.Rows.Add("27", "FLOWER", @"../../UsedForResource/Flower/Flower_27.jpg", 212, 349, 184, 1);

            dtFlower.Rows.Add("28", "FLOWER", @"../../UsedForResource/Flower/Flower_28.jpg", 76, 360, 376, 1);

            dtFlower.Rows.Add("29", "FLOWER", @"../../UsedForResource/Flower/Flower_29.jpg", 220, 280, 340, 1);

            dtFlower.Rows.Add("30", "FLOWER", @"../../UsedForResource/Flower/Flower_30.jpg", 153, 357, 366, 1);

            dtFlower.Rows.Add("31", "FLOWER", @"../../UsedForResource/Flower/Flower_31.jpg", 195, 355, 304, 1);

            dtFlower.Rows.Add("32", "FLOWER", @"../../UsedForResource/Flower/Flower_32.jpg", 208, 202, 337, 0);

            dtFlower.Rows.Add("33", "FLOWER", @"../../UsedForResource/Flower/Flower_33.jpg", 174, 370, 210, 1);

            dtFlower.Rows.Add("34", "FLOWER", @"../../UsedForResource/Flower/Flower_34.jpg", 96, 135, 324, 1);

            dtFlower.Rows.Add("35", "FLOWER", @"../../UsedForResource/Flower/Flower_35.jpg", 88, 125, 224, 0);

            dtFlower.Rows.Add("36", "FLOWER", @"../../UsedForResource/Flower/Flower_36.jpg", 61, 297, 301, 1);

            dtFlower.Rows.Add("37", "FLOWER", @"../../UsedForResource/Flower/Flower_37.jpg", 90, 182, 206, 1);

            dtFlower.Rows.Add("38", "FLOWER", @"../../UsedForResource/Flower/Flower_38.jpg", 213, 342, 218, 0);

            dtFlower.Rows.Add("39", "FLOWER", @"../../UsedForResource/Flower/Flower_39.jpg", 151, 130, 246, 0);

            dtFlower.Rows.Add("40", "FLOWER", @"../../UsedForResource/Flower/Flower_40.jpg", 214, 142, 151, 1);

            dtFlower.Rows.Add("41", "FLOWER", @"../../UsedForResource/Flower/Flower_41.jpg", 163, 123, 199, 1);

            dtFlower.Rows.Add("42", "FLOWER", @"../../UsedForResource/Flower/Flower_42.jpg", 175, 376, 231, 1);

            dtFlower.Rows.Add("43", "FLOWER", @"../../UsedForResource/Flower/Flower_43.jpg", 148, 136, 260, 0);

            dtFlower.Rows.Add("44", "FLOWER", @"../../UsedForResource/Flower/Flower_44.jpg", 227, 293, 235, 1);

            dtFlower.Rows.Add("45", "FLOWER", @"../../UsedForResource/Flower/Flower_45.jpg", 149, 213, 368, 0);

            dtFlower.Rows.Add("46", "FLOWER", @"../../UsedForResource/Flower/Flower_46.jpg", 210, 228, 326, 1);

            dtFlower.Rows.Add("47", "FLOWER", @"../../UsedForResource/Flower/Flower_47.jpg", 41, 359, 364, 1);

            dtFlower.Rows.Add("48", "FLOWER", @"../../UsedForResource/Flower/Flower_48.jpg", 145, 192, 155, 0);

            dtFlower.Rows.Add("49", "FLOWER", @"../../UsedForResource/Flower/Flower_49.jpg", 209, 190, 241, 0);

            dtFlower.Rows.Add("50", "FLOWER", @"../../UsedForResource/Flower/Flower_50.jpg", 97, 305, 321, 1);

            dtFlower.Rows.Add("51", "FLOWER", @"../../UsedForResource/Flower/Flower_51.jpg", 89, 199, 261, 0);

            dtFlower.Rows.Add("52", "FLOWER", @"../../UsedForResource/Flower/Flower_52.jpg", 171, 154, 315, 1);

            dtFlower.Rows.Add("53", "FLOWER", @"../../UsedForResource/Flower/Flower_53.jpg", 119, 161, 344, 0);

            dtFlower.Rows.Add("54", "FLOWER", @"../../UsedForResource/Flower/Flower_54.jpg", 207, 339, 165, 0);

            dtFlower.Rows.Add("55", "FLOWER", @"../../UsedForResource/Flower/Flower_55.jpg", 78, 155, 259, 0);

            dtFlower.Rows.Add("56", "FLOWER", @"../../UsedForResource/Flower/Flower_56.jpg", 199, 224, 158, 1);

            dtFlower.Rows.Add("57", "FLOWER", @"../../UsedForResource/Flower/Flower_57.jpg", 184, 266, 414, 0);

            dtFlower.Rows.Add("58", "FLOWER", @"../../UsedForResource/Flower/Flower_58.jpg", 142, 333, 286, 0);

            dtFlower.Rows.Add("59", "FLOWER", @"../../UsedForResource/Flower/Flower_59.jpg", 178, 282, 402, 1);

            dtFlower.Rows.Add("60", "FLOWER", @"../../UsedForResource/Flower/Flower_60.jpg", 141, 127, 179, 1);

            dtFlower.Rows.Add("61", "FLOWER", @"../../UsedForResource/Flower/Flower_61.jpg", 147, 377, 280, 0);

            dtFlower.Rows.Add("62", "FLOWER", @"../../UsedForResource/Flower/Flower_62.jpg", 101, 144, 297, 0);

            dtFlower.Rows.Add("63", "FLOWER", @"../../UsedForResource/Flower/Flower_63.jpg", 162, 181, 211, 1);

            dtFlower.Rows.Add("64", "FLOWER", @"../../UsedForResource/Flower/Flower_64.jpg", 224, 222, 216, 0);

            dtFlower.Rows.Add("65", "FLOWER", @"../../UsedForResource/Flower/Flower_65.jpg", 75, 314, 289, 1);

            dtFlower.Rows.Add("66", "FLOWER", @"../../UsedForResource/Flower/Flower_66.jpg", 57, 147, 390, 1);

            dtFlower.Rows.Add("67", "FLOWER", @"../../UsedForResource/Flower/Flower_67.jpg", 105, 170, 397, 1);

            dtFlower.Rows.Add("68", "FLOWER", @"../../UsedForResource/Flower/Flower_68.jpg", 167, 356, 194, 1);

            dtFlower.Rows.Add("69", "FLOWER", @"../../UsedForResource/Flower/Flower_69.jpg", 161, 250, 389, 1);

            dtFlower.Rows.Add("70", "FLOWER", @"../../UsedForResource/Flower/Flower_70.jpg", 114, 242, 183, 1);

            dtFlower.Rows.Add("71", "FLOWER", @"../../UsedForResource/Flower/Flower_71.jpg", 110, 304, 399, 0);

            dtFlower.Rows.Add("72", "FLOWER", @"../../UsedForResource/Flower/Flower_72.jpg", 116, 231, 192, 1);

            dtFlower.Rows.Add("73", "FLOWER", @"../../UsedForResource/Flower/Flower_73.jpg", 180, 315, 162, 0);

            dtFlower.Rows.Add("74", "FLOWER", @"../../UsedForResource/Flower/Flower_74.jpg", 67, 209, 300, 1);

            dtFlower.Rows.Add("75", "FLOWER", @"../../UsedForResource/Flower/Flower_75.jpg", 152, 175, 258, 1);

            dtFlower.Rows.Add("76", "FLOWER", @"../../UsedForResource/Flower/Flower_76.jpg", 80, 237, 153, 1);

            dtFlower.Rows.Add("77", "FLOWER", @"../../UsedForResource/Flower/Flower_77.jpg", 197, 289, 267, 0);

            dtFlower.Rows.Add("78", "FLOWER", @"../../UsedForResource/Flower/Flower_78.jpg", 99, 148, 283, 0);

            dtFlower.Rows.Add("79", "FLOWER", @"../../UsedForResource/Flower/Flower_79.jpg", 124, 302, 222, 0);

            dtFlower.Rows.Add("80", "FLOWER", @"../../UsedForResource/Flower/Flower_80.jpg", 186, 166, 417, 0);

            dtFlower.Rows.Add("81", "FLOWER", @"../../UsedForResource/Flower/Flower_81.jpg", 203, 216, 238, 1);

            dtFlower.Rows.Add("82", "FLOWER", @"../../UsedForResource/Flower/Flower_82.jpg", 106, 325, 345, 1);

            dtFlower.Rows.Add("83", "FLOWER", @"../../UsedForResource/Flower/Flower_83.jpg", 194, 388, 214, 1);

            dtFlower.Rows.Add("84", "FLOWER", @"../../UsedForResource/Flower/Flower_84.jpg", 118, 157, 342, 1);

            dtFlower.Rows.Add("85", "FLOWER", @"../../UsedForResource/Flower/Flower_85.jpg", 215, 299, 311, 0);

            dtFlower.Rows.Add("86", "FLOWER", @"../../UsedForResource/Flower/Flower_86.jpg", 45, 277, 181, 1);

            dtFlower.Rows.Add("87", "FLOWER", @"../../UsedForResource/Flower/Flower_87.jpg", 100, 200, 281, 0);

            dtFlower.Rows.Add("88", "FLOWER", @"../../UsedForResource/Flower/Flower_88.jpg", 173, 173, 387, 0);

            dtFlower.Rows.Add("89", "FLOWER", @"../../UsedForResource/Flower/Flower_89.jpg", 49, 334, 327, 1);

            dtFlower.Rows.Add("90", "FLOWER", @"../../UsedForResource/Flower/Flower_90.jpg", 46, 227, 243, 1);

            dtFlower.Rows.Add("91", "FLOWER", @"../../UsedForResource/Flower/Flower_91.jpg", 191, 278, 196, 0);

            dtFlower.Rows.Add("92", "FLOWER", @"../../UsedForResource/Flower/Flower_92.jpg", 123, 383, 313, 0);

            dtFlower.Rows.Add("93", "FLOWER", @"../../UsedForResource/Flower/Flower_93.jpg", 79, 329, 168, 0);

            dtFlower.Rows.Add("94", "FLOWER", @"../../UsedForResource/Flower/Flower_94.jpg", 44, 331, 287, 0);

            dtFlower.Rows.Add("95", "FLOWER", @"../../UsedForResource/Flower/Flower_95.jpg", 113, 298, 201, 1);

            dtFlower.Rows.Add("96", "FLOWER", @"../../UsedForResource/Flower/Flower_96.jpg", 64, 366, 279, 1);

            dtFlower.Rows.Add("97", "FLOWER", @"../../UsedForResource/Flower/Flower_97.jpg", 164, 207, 171, 1);

            dtFlower.Rows.Add("98", "FLOWER", @"../../UsedForResource/Flower/Flower_98.jpg", 42, 372, 263, 1);

            dtFlower.Rows.Add("99", "FLOWER", @"../../UsedForResource/Flower/Flower_99.jpg", 223, 188, 268, 0);

            dtFlower.Rows.Add("100", "FLOWER", @"../../UsedForResource/Flower/Flower_100.jpg", 60, 352, 401, 1);

            dtFlower.Rows.Add("101", "FLOWER", @"../../UsedForResource/Flower/Flower_101.jpg", 177, 235, 328, 1);

            dtFlower.Rows.Add("102", "FLOWER", @"../../UsedForResource/Flower/Flower_102.jpg", 146, 140, 302, 0);

            dtFlower.Rows.Add("103", "FLOWER", @"../../UsedForResource/Flower/Flower_103.jpg", 66, 158, 174, 1);

            dtFlower.Rows.Add("104", "FLOWER", @"../../UsedForResource/Flower/Flower_104.jpg", 51, 380, 170, 1);

            dtFlower.Rows.Add("105", "FLOWER", @"../../UsedForResource/Flower/Flower_105.jpg", 107, 197, 276, 1);

            dtFlower.Rows.Add("106", "FLOWER", @"../../UsedForResource/Flower/Flower_106.jpg", 50, 257, 294, 0);

            dtFlower.Rows.Add("107", "FLOWER", @"../../UsedForResource/Flower/Flower_107.jpg", 165, 319, 237, 0);

            dtFlower.Rows.Add("108", "FLOWER", @"../../UsedForResource/Flower/Flower_108.jpg", 132, 149, 177, 1);

            dtFlower.Rows.Add("109", "FLOWER", @"../../UsedForResource/Flower/Flower_109.jpg", 65, 368, 200, 1);

            dtFlower.Rows.Add("110", "FLOWER", @"../../UsedForResource/Flower/Flower_110.jpg", 159, 206, 186, 1);

            dtFlower.Rows.Add("111", "FLOWER", @"../../UsedForResource/Flower/Flower_111.jpg", 188, 313, 378, 0);

            dtFlower.Rows.Add("112", "FLOWER", @"../../UsedForResource/Flower/Flower_112.jpg", 117, 274, 316, 1);

            dtFlower.Rows.Add("113", "FLOWER", @"../../UsedForResource/Flower/Flower_113.jpg", 219, 374, 305, 1);

            dtFlower.Rows.Add("114", "FLOWER", @"../../UsedForResource/Flower/Flower_114.jpg", 154, 385, 419, 1);

            dtFlower.Rows.Add("115", "FLOWER", @"../../UsedForResource/Flower/Flower_115.jpg", 94, 328, 348, 1);

            dtFlower.Rows.Add("116", "FLOWER", @"../../UsedForResource/Flower/Flower_116.jpg", 54, 322, 234, 0);

            dtFlower.Rows.Add("117", "FLOWER", @"../../UsedForResource/Flower/Flower_117.jpg", 95, 281, 232, 0);

            dtFlower.Rows.Add("118", "FLOWER", @"../../UsedForResource/Flower/Flower_118.jpg", 130, 344, 208, 0);

            dtFlower.Rows.Add("119", "FLOWER", @"../../UsedForResource/Flower/Flower_119.jpg", 71, 303, 247, 0);

            dtFlower.Rows.Add("120", "FLOWER", @"../../UsedForResource/Flower/Flower_120.jpg", 52, 171, 278, 0);

            dtFlower.Rows.Add("121", "FLOWER", @"../../UsedForResource/Flower/Flower_121.jpg", 102, 320, 388, 0);

            dtFlower.Rows.Add("122", "FLOWER", @"../../UsedForResource/Flower/Flower_122.jpg", 189, 238, 405, 1);

            dtFlower.Rows.Add("123", "FLOWER", @"../../UsedForResource/Flower/Flower_123.jpg", 190, 145, 251, 1);

            dtFlower.Rows.Add("124", "FLOWER", @"../../UsedForResource/Flower/Flower_124.jpg", 58, 196, 410, 0);

            dtFlower.Rows.Add("125", "FLOWER", @"../../UsedForResource/Flower/Flower_125.jpg", 87, 132, 191, 1);

            dtFlower.Rows.Add("126", "FLOWER", @"../../UsedForResource/Flower/Flower_126.jpg", 128, 169, 335, 1);

            dtFlower.Rows.Add("127", "FLOWER", @"../../UsedForResource/Flower/Flower_127.jpg", 179, 273, 343, 1);

            dtFlower.Rows.Add("128", "FLOWER", @"../../UsedForResource/Flower/Flower_128.jpg", 109, 261, 217, 0);

            dtFlower.Rows.Add("129", "FLOWER", @"../../UsedForResource/Flower/Flower_129.jpg", 183, 165, 375, 1);

            dtFlower.Rows.Add("130", "FLOWER", @"../../UsedForResource/Flower/Flower_130.jpg", 48, 324, 320, 1);

            dtFlower.Rows.Add("131", "FLOWER", @"../../UsedForResource/Flower/Flower_131.jpg", 217, 226, 382, 1);

            dtFlower.Rows.Add("132", "FLOWER", @"../../UsedForResource/Flower/Flower_132.jpg", 221, 254, 152, 1);

            dtFlower.Rows.Add("133", "FLOWER", @"../../UsedForResource/Flower/Flower_133.jpg", 181, 183, 370, 1);

            dtFlower.Rows.Add("134", "FLOWER", @"../../UsedForResource/Flower/Flower_134.jpg", 198, 270, 203, 1);

            dtFlower.Rows.Add("135", "FLOWER", @"../../UsedForResource/Flower/Flower_135.jpg", 98, 288, 161, 0);

            dtFlower.Rows.Add("136", "FLOWER", @"../../UsedForResource/Flower/Flower_136.jpg", 73, 264, 197, 1);

            dtFlower.Rows.Add("137", "FLOWER", @"../../UsedForResource/Flower/Flower_137.jpg", 40, 124, 306, 0);

            dtFlower.Rows.Add("138", "FLOWER", @"../../UsedForResource/Flower/Flower_138.jpg", 137, 335, 185, 0);

            dtFlower.Rows.Add("139", "FLOWER", @"../../UsedForResource/Flower/Flower_139.jpg", 92, 150, 166, 0);

            dtFlower.Rows.Add("140", "FLOWER", @"../../UsedForResource/Flower/Flower_140.jpg", 187, 301, 355, 1);

            dtFlower.Rows.Add("141", "FLOWER", @"../../UsedForResource/Flower/Flower_141.jpg", 53, 248, 303, 1);

            dtFlower.Rows.Add("142", "FLOWER", @"../../UsedForResource/Flower/Flower_142.jpg", 83, 294, 299, 0);

            dtFlower.Rows.Add("143", "FLOWER", @"../../UsedForResource/Flower/Flower_143.jpg", 172, 353, 400, 1);

            dtFlower.Rows.Add("144", "FLOWER", @"../../UsedForResource/Flower/Flower_144.jpg", 144, 327, 160, 0);

            dtFlower.Rows.Add("145", "FLOWER", @"../../UsedForResource/Flower/Flower_145.jpg", 115, 351, 404, 0);

            dtFlower.Rows.Add("146", "FLOWER", @"../../UsedForResource/Flower/Flower_146.jpg", 82, 134, 329, 1);

            dtFlower.Rows.Add("147", "FLOWER", @"../../UsedForResource/Flower/Flower_147.jpg", 134, 189, 188, 0);

            dtFlower.Rows.Add("148", "FLOWER", @"../../UsedForResource/Flower/Flower_148.jpg", 205, 279, 229, 1);

            dtFlower.Rows.Add("149", "FLOWER", @"../../UsedForResource/Flower/Flower_149.jpg", 140, 255, 271, 1);

            dtFlower.Rows.Add("150", "FLOWER", @"../../UsedForResource/Flower/Flower_150.jpg", 226, 239, 403, 1);

            dtFlower.Rows.Add("151", "FLOWER", @"../../UsedForResource/Flower/Flower_151.jpg", 68, 265, 398, 1);

            dtFlower.Rows.Add("152", "FLOWER", @"../../UsedForResource/Flower/Flower_152.jpg", 193, 208, 167, 1);

            dtFlower.Rows.Add("153", "FLOWER", @"../../UsedForResource/Flower/Flower_153.jpg", 156, 256, 159, 0);

            dtFlower.Rows.Add("154", "FLOWER", @"../../UsedForResource/Flower/Flower_154.jpg", 228, 159, 233, 1);

            dtFlower.Rows.Add("155", "FLOWER", @"../../UsedForResource/Flower/Flower_155.jpg", 160, 156, 242, 0);

            dtFlower.Rows.Add("156", "FLOWER", @"../../UsedForResource/Flower/Flower_156.jpg", 72, 211, 277, 0);

            dtFlower.Rows.Add("157", "FLOWER", @"../../UsedForResource/Flower/Flower_157.jpg", 204, 141, 352, 0);

            dtFlower.Rows.Add("158", "FLOWER", @"../../UsedForResource/Flower/Flower_158.jpg", 56, 387, 154, 0);

            dtFlower.Rows.Add("159", "FLOWER", @"../../UsedForResource/Flower/Flower_159.jpg", 63, 129, 178, 1);


            Random randomCar = new Random();
            Random randomInterior = new Random();
            Random randomForest = new Random();
            Random randomOceans = new Random();
            Random randomMotoBike = new Random();
            Random randomFlower = new Random();
            int numrandomCar_1 = randomCar.Next(1, 158);
            int numrandomCar_2 = randomCar.Next(1, 158);
            int numrandomCar_3 = randomCar.Next(1, 158);
            int numrandomCar_4 = randomCar.Next(1, 158);
            int numrandomInterior_1 = randomInterior.Next(1, 230);
            int numrandomInterior_2 = randomInterior.Next(1, 230);
            int numrandomInterior_3 = randomInterior.Next(1, 230);
            int numrandomInterior_4 = randomInterior.Next(1, 230);
            int numrandomForest_1 = randomForest.Next(1, 206);
            int numrandomForest_2 = randomForest.Next(1, 206);
            int numrandomForest_3 = randomForest.Next(1, 206);
            int numrandomForest_4 = randomForest.Next(1, 206);
            int numrandomOceans1 = randomOceans.Next(1, 187);
            int numrandomOceans2 = randomOceans.Next(1, 187);
            int numrandomOceans3 = randomOceans.Next(1, 187);
            int numrandomOceans4 = randomOceans.Next(1, 187);
            int numrandomMotoBike_1 = randomMotoBike.Next(1, 243);
            int numrandomMotoBike_2 = randomMotoBike.Next(1, 243);
            int numrandomMotoBike_3 = randomMotoBike.Next(1, 243);
            int numrandomMotoBike_4 = randomMotoBike.Next(1, 243);
            int numrandomFlower_1 = randomFlower.Next(1, 160);
            int numrandomFlower_2 = randomFlower.Next(1, 160);
            int numrandomFlower_3 = randomFlower.Next(1, 160);
            int numrandomFlower_4 = randomFlower.Next(1, 160);
            ///////////////RANDOM CAR CHO 4 PICTUREBO//////////

            for (int i = 1; i < 158; i++)
            {
                if (i == numrandomCar_1)
                {
                    pictureBoxShowingMain_1.Image = Image.FromFile(Convert.ToString(dtCar.Rows[numrandomCar_1 - 1]["Path"]));
                    pictureBox_click_panelExploreTopics_flowLayoutPanelMain_form1_categorizedCar.Image = Image.FromFile(Convert.ToString(dtCar.Rows[numrandomCar_1 - 1]["Path"]));
                    pictureBox_panelSeeMore_flowLayoutPanelDetailPicture_form1_showingMore_1.Image= Image.FromFile(Convert.ToString(dtCar.Rows[numrandomCar_1 - 1]["Path"]));

                    lstImageInfoScreenMain.Add("Categorized_main1",dtCar.Rows[numrandomCar_1 - 1]["Categorized"].ToString());
                    lstImageInfoScreenMain.Add("Path_main1", dtCar.Rows[numrandomCar_1 - 1]["Path"].ToString());
                    lstImageInfoScreenMain.Add("Favourites_main1", dtCar.Rows[numrandomCar_1 - 1]["Favorites"].ToString());
                    lstImageInfoScreenMain.Add("Comments_main1", dtCar.Rows[numrandomCar_1 - 1]["Comments"].ToString());
                    lstImageInfoScreenMain.Add("Views_main1", dtCar.Rows[numrandomCar_1 - 1]["Views"].ToString());
                    lstImageInfoScreenMain.Add("Price_main1", dtCar.Rows[numrandomCar_1 - 1]["Price"].ToString());


                }
                else if (i == numrandomCar_2)
                {
                    pictureBoxShowingMain_2.Image = Image.FromFile(Convert.ToString(dtCar.Rows[numrandomCar_2 - 1]["Path"]));
                    pictureBox_panelSeeMore_flowLayoutPanelDetailPicture_form1_showingMore_2.Image = Image.FromFile(Convert.ToString(dtCar.Rows[numrandomCar_2 - 1]["Path"]));

                    lstImageInfoScreenMain.Add("Categorized_main2", dtCar.Rows[numrandomCar_2 - 1]["Categorized"].ToString());
                    lstImageInfoScreenMain.Add("Path_main2", dtCar.Rows[numrandomCar_2 - 1]["Path"].ToString());
                    lstImageInfoScreenMain.Add("Favourites_main2", dtCar.Rows[numrandomCar_2 - 1]["Favorites"].ToString());
                    lstImageInfoScreenMain.Add("Comments_main2", dtCar.Rows[numrandomCar_2 - 1]["Comments"].ToString());
                    lstImageInfoScreenMain.Add("Views_main2", dtCar.Rows[numrandomCar_2 - 1]["Views"].ToString());
                    lstImageInfoScreenMain.Add("Price_main2", dtCar.Rows[numrandomCar_2 - 1]["Price"].ToString());


                }
                else if (i == numrandomCar_3)
                {
                    pictureBoxShowingMain_3.Image = Image.FromFile(Convert.ToString(dtCar.Rows[numrandomCar_3 - 1]["Path"]));

                    lstImageInfoScreenMain.Add("Categorized_main3", dtCar.Rows[numrandomCar_3 - 1]["Categorized"].ToString());
                    lstImageInfoScreenMain.Add("Path_main3", dtCar.Rows[numrandomCar_3 - 1]["Path"].ToString());
                    lstImageInfoScreenMain.Add("Favourites_main3", dtCar.Rows[numrandomCar_3 - 1]["Favorites"].ToString());
                    lstImageInfoScreenMain.Add("Comments_main3", dtCar.Rows[numrandomCar_3 - 1]["Comments"].ToString());
                    lstImageInfoScreenMain.Add("Views_main3", dtCar.Rows[numrandomCar_3 - 1]["Views"].ToString());
                    lstImageInfoScreenMain.Add("Price_main3", dtCar.Rows[numrandomCar_3 - 1]["Price"].ToString());

                }
                else if (i == numrandomCar_4)
                {
                    pictureBoxShowingMain_4.Image = Image.FromFile(Convert.ToString(dtCar.Rows[numrandomCar_4 - 1]["Path"]));
   
                    lstImageInfoScreenMain.Add("Categorized_main4", dtCar.Rows[numrandomCar_4 - 1]["Categorized"].ToString());
                    lstImageInfoScreenMain.Add("Path_main4", dtCar.Rows[numrandomCar_4 - 1]["Path"].ToString());
                    lstImageInfoScreenMain.Add("Favourites_main4", dtCar.Rows[numrandomCar_4 - 1]["Favorites"].ToString());
                    lstImageInfoScreenMain.Add("Comments_main4", dtCar.Rows[numrandomCar_4 - 1]["Comments"].ToString());
                    lstImageInfoScreenMain.Add("Views_main4", dtCar.Rows[numrandomCar_4 - 1]["Views"].ToString());
                    lstImageInfoScreenMain.Add("Price_main4", dtCar.Rows[numrandomCar_4 - 1]["Price"].ToString());

                }
            }
            for (int j = 1; j < 230; j++)
            {
                if (j == numrandomInterior_1)
                {
                    pictureBoxShowingMain_5.Image = Image.FromFile(Convert.ToString(dtInterior.Rows[numrandomInterior_1 - 1]["Path"]));
                    pictureBox_click_panelExploreTopics_flowLayoutPanelMain_form1_categorizedInterior.Image = Image.FromFile(Convert.ToString(dtInterior.Rows[numrandomInterior_1 - 1]["Path"]));
                    pictureBox_panelSeeMore_flowLayoutPanelDetailPicture_form1_showingMore_3.Image= Image.FromFile(Convert.ToString(dtInterior.Rows[numrandomInterior_1 - 1]["Path"]));
       
                    lstImageInfoScreenMain.Add("Categorized_main5", dtInterior.Rows[numrandomInterior_1 - 1]["Categorized"].ToString());
                    lstImageInfoScreenMain.Add("Path_main5", dtInterior.Rows[numrandomInterior_1 - 1]["Path"].ToString());
                    lstImageInfoScreenMain.Add("Favourites_main5", dtInterior.Rows[numrandomInterior_1 - 1]["Favorites"].ToString());
                    lstImageInfoScreenMain.Add("Comments_main5", dtInterior.Rows[numrandomInterior_1 - 1]["Comments"].ToString());
                    lstImageInfoScreenMain.Add("Views_main5", dtInterior.Rows[numrandomInterior_1 - 1]["Views"].ToString());
                    lstImageInfoScreenMain.Add("Price_main5", dtInterior.Rows[numrandomInterior_1 - 1]["Price"].ToString());
  

                }
                else if (j == numrandomInterior_2)
                {
                    pictureBoxShowingMain_6.Image = Image.FromFile(Convert.ToString(dtInterior.Rows[numrandomInterior_2 - 1]["Path"]));
                    pictureBox_panelSeeMore_flowLayoutPanelDetailPicture_form1_showingMore_4.Image = Image.FromFile(Convert.ToString(dtInterior.Rows[numrandomInterior_2 - 1]["Path"]));
        
                    lstImageInfoScreenMain.Add("Categorized_main6", dtInterior.Rows[numrandomInterior_2 - 1]["Categorized"].ToString());
                    lstImageInfoScreenMain.Add("Path_main6", dtInterior.Rows[numrandomInterior_2 - 1]["Path"].ToString());
                    lstImageInfoScreenMain.Add("Favourites_main6", dtInterior.Rows[numrandomInterior_2 - 1]["Favorites"].ToString());
                    lstImageInfoScreenMain.Add("Comments_main6", dtInterior.Rows[numrandomInterior_2 - 1]["Comments"].ToString());
                    lstImageInfoScreenMain.Add("Views_main6", dtInterior.Rows[numrandomInterior_2 - 1]["Views"].ToString());
                    lstImageInfoScreenMain.Add("Price_main6", dtInterior.Rows[numrandomInterior_2 - 1]["Price"].ToString());


                }
                else if (j == numrandomInterior_3)
                {
                    pictureBoxShowingMain_7.Image = Image.FromFile(Convert.ToString(dtInterior.Rows[numrandomInterior_3 - 1]["Path"]));
      
                    lstImageInfoScreenMain.Add("Categorized_main7", dtInterior.Rows[numrandomInterior_3 - 1]["Categorized"].ToString());
                    lstImageInfoScreenMain.Add("Path_main7", dtInterior.Rows[numrandomInterior_3 - 1]["Path"].ToString());
                    lstImageInfoScreenMain.Add("Favourites_main7", dtInterior.Rows[numrandomInterior_3 - 1]["Favorites"].ToString());
                    lstImageInfoScreenMain.Add("Comments_main7", dtInterior.Rows[numrandomInterior_3 - 1]["Comments"].ToString());
                    lstImageInfoScreenMain.Add("Views_main7", dtInterior.Rows[numrandomInterior_3 - 1]["Views"].ToString());
                    lstImageInfoScreenMain.Add("Price_main7", dtInterior.Rows[numrandomInterior_3 - 1]["Price"].ToString());

                }
                else if (j == numrandomInterior_4)
                {
                    pictureBoxShowingMain_8.Image = Image.FromFile(Convert.ToString(dtInterior.Rows[numrandomInterior_4 - 1]["Path"]));
                   
    
                    lstImageInfoScreenMain.Add("Categorized_main8", dtInterior.Rows[numrandomInterior_4 - 1]["Categorized"].ToString());
                    lstImageInfoScreenMain.Add("Path_main8", dtInterior.Rows[numrandomInterior_4 - 1]["Path"].ToString());
                    lstImageInfoScreenMain.Add("Favourites_main8", dtInterior.Rows[numrandomInterior_4 - 1]["Favorites"].ToString());
                    lstImageInfoScreenMain.Add("Comments_main8", dtInterior.Rows[numrandomInterior_4 - 1]["Comments"].ToString());
                    lstImageInfoScreenMain.Add("Views_main8", dtInterior.Rows[numrandomInterior_4 - 1]["Views"].ToString());
                    lstImageInfoScreenMain.Add("Price_main8", dtInterior.Rows[numrandomInterior_4- 1]["Price"].ToString());

                }
            }
            for (int l = 1; l < 206; l++)
            {
                if (l == numrandomForest_1)
                {
                    pictureBoxShowingMain_9.Image = Image.FromFile(Convert.ToString(dtForest.Rows[numrandomForest_1 - 1]["Path"]));
                    pictureBox_click_panelExploreTopics_flowLayoutPanelMain_form1_categorizedForest.Image = Image.FromFile(Convert.ToString(dtForest.Rows[numrandomForest_1 - 1]["Path"]));
                    pictureBox_panelSeeMore_flowLayoutPanelDetailPicture_form1_showingMore_5.Image= Image.FromFile(Convert.ToString(dtForest.Rows[numrandomForest_1 - 1]["Path"]));
      
                    lstImageInfoScreenMain.Add("Categorized_main9", dtForest.Rows[numrandomForest_1 - 1]["Categorized"].ToString());
                    lstImageInfoScreenMain.Add("Path_main9", dtForest.Rows[numrandomForest_1 - 1]["Path"].ToString());
                    lstImageInfoScreenMain.Add("Favourites_main9", dtForest.Rows[numrandomForest_1 - 1]["Favorites"].ToString());
                    lstImageInfoScreenMain.Add("Comments_main9", dtForest.Rows[numrandomForest_1 - 1]["Comments"].ToString());
                    lstImageInfoScreenMain.Add("Views_main9", dtForest.Rows[numrandomForest_1 - 1]["Views"].ToString());
                    lstImageInfoScreenMain.Add("Price_main9", dtForest.Rows[numrandomForest_1 - 1]["Price"].ToString());


                }
                else if (l == numrandomForest_2)
                {
                    pictureBoxShowingMain_10.Image = Image.FromFile(Convert.ToString(dtForest.Rows[numrandomForest_2 - 1]["Path"]));
                    pictureBox_panelSeeMore_flowLayoutPanelDetailPicture_form1_showingMore_6.Image = Image.FromFile(Convert.ToString(dtForest.Rows[numrandomForest_2 - 1]["Path"]));
               
                    lstImageInfoScreenMain.Add("Categorized_main10", dtForest.Rows[numrandomForest_2 - 1]["Categorized"].ToString());
                    lstImageInfoScreenMain.Add("Path_main10", dtForest.Rows[numrandomForest_2 - 1]["Path"].ToString());
                    lstImageInfoScreenMain.Add("Favourites_main10", dtForest.Rows[numrandomForest_2 - 1]["Favorites"].ToString());
                    lstImageInfoScreenMain.Add("Comments_main10", dtForest.Rows[numrandomForest_2 - 1]["Comments"].ToString());
                    lstImageInfoScreenMain.Add("Views_main10", dtForest.Rows[numrandomForest_2 - 1]["Views"].ToString());
                    lstImageInfoScreenMain.Add("Price_main10", dtForest.Rows[numrandomForest_2 - 1]["Price"].ToString());

                }
                else if (l == numrandomForest_3)
                {
                    pictureBoxShowingMain_11.Image = Image.FromFile(Convert.ToString(dtForest.Rows[numrandomForest_3 - 1]["Path"]));
      
                    lstImageInfoScreenMain.Add("Categorized_main11", dtForest.Rows[numrandomForest_3 - 1]["Categorized"].ToString());
                    lstImageInfoScreenMain.Add("Path_main11", dtForest.Rows[numrandomForest_3 - 1]["Path"].ToString());
                    lstImageInfoScreenMain.Add("Favourites_main11", dtForest.Rows[numrandomForest_3 - 1]["Favorites"].ToString());
                    lstImageInfoScreenMain.Add("Comments_main11", dtForest.Rows[numrandomForest_3 - 1]["Comments"].ToString());
                    lstImageInfoScreenMain.Add("Views_main11", dtForest.Rows[numrandomForest_3 - 1]["Views"].ToString());
                    lstImageInfoScreenMain.Add("Price_main11", dtForest.Rows[numrandomForest_3 - 1]["Price"].ToString());

                }
                else if (l == numrandomForest_4)
                {
                    pictureBoxShowingMain_12.Image = Image.FromFile(Convert.ToString(dtForest.Rows[numrandomForest_4 - 1]["Path"]));
                 
                    lstImageInfoScreenMain.Add("Categorized_main12", dtForest.Rows[numrandomForest_4 - 1]["Categorized"].ToString());
                    lstImageInfoScreenMain.Add("Path_main12", dtForest.Rows[numrandomForest_4 - 1]["Path"].ToString());
                    lstImageInfoScreenMain.Add("Favourites_main12", dtForest.Rows[numrandomForest_4 - 1]["Favorites"].ToString());
                    lstImageInfoScreenMain.Add("Comments_main12", dtForest.Rows[numrandomForest_4 - 1]["Comments"].ToString());
                    lstImageInfoScreenMain.Add("Views_main12", dtForest.Rows[numrandomForest_4 - 1]["Views"].ToString());
                    lstImageInfoScreenMain.Add("Price_main12", dtForest.Rows[numrandomForest_4 - 1]["Price"].ToString());

                }
            }
            for (int p = 1; p < 187; p++)
            {
                if (p == numrandomOceans1)
                {
                    pictureBoxShowingMain_13.Image = Image.FromFile(Convert.ToString(dtOceans.Rows[numrandomOceans1 - 1]["Path"]));
                    pictureBox_click_panelExploreTopics_flowLayoutPanelMain_form1_categorizedOceans.Image = Image.FromFile(Convert.ToString(dtOceans.Rows[numrandomOceans1 - 1]["Path"]));
                    pictureBox_panelSeeMore_flowLayoutPanelDetailPicture_form1_showingMore_7.Image=Image.FromFile(Convert.ToString(dtOceans.Rows[numrandomOceans1 - 1]["Path"]));
                
                    lstImageInfoScreenMain.Add("Categorized_main13", dtOceans.Rows[numrandomOceans1 - 1]["Categorized"].ToString());
                    lstImageInfoScreenMain.Add("Path_main13", dtOceans.Rows[numrandomOceans1 - 1]["Path"].ToString());
                    lstImageInfoScreenMain.Add("Favourites_main13", dtOceans.Rows[numrandomOceans1 - 1]["Favorites"].ToString());
                    lstImageInfoScreenMain.Add("Comments_main13", dtOceans.Rows[numrandomOceans1 - 1]["Comments"].ToString());
                    lstImageInfoScreenMain.Add("Views_main13", dtOceans.Rows[numrandomOceans1 - 1]["Views"].ToString());
                    lstImageInfoScreenMain.Add("Price_main13", dtOceans.Rows[numrandomOceans1 - 1]["Price"].ToString());

                }
                else if (p == numrandomOceans2)
                {
                    pictureBoxShowingMain_14.Image = Image.FromFile(Convert.ToString(dtOceans.Rows[numrandomOceans2 - 1]["Path"]));
                    pictureBox_panelSeeMore_flowLayoutPanelDetailPicture_form1_showingMore_8.Image = Image.FromFile(Convert.ToString(dtOceans.Rows[numrandomOceans2 - 1]["Path"]));

                    lstImageInfoScreenMain.Add("Categorized_main14", dtOceans.Rows[numrandomOceans2 - 1]["Categorized"].ToString());
                    lstImageInfoScreenMain.Add("Path_main14", dtOceans.Rows[numrandomOceans2 - 1]["Path"].ToString());
                    lstImageInfoScreenMain.Add("Favourites_main14", dtOceans.Rows[numrandomOceans2 - 1]["Favorites"].ToString());
                    lstImageInfoScreenMain.Add("Comments_main14", dtOceans.Rows[numrandomOceans2 - 1]["Comments"].ToString());
                    lstImageInfoScreenMain.Add("Views_main14", dtOceans.Rows[numrandomOceans2 - 1]["Views"].ToString());
                    lstImageInfoScreenMain.Add("Price_main14", dtOceans.Rows[numrandomOceans2 - 1]["Price"].ToString());

                }
                else if (p == numrandomOceans3)
                {
                    pictureBoxShowingMain_15.Image = Image.FromFile(Convert.ToString(dtOceans.Rows[numrandomOceans3 - 1]["Path"]));
                    pictureBox_panelSeeMore_flowLayoutPanelDetailPicture_form1_showingMore_15.Image=Image.FromFile(Convert.ToString(dtOceans.Rows[numrandomOceans3 - 1]["Path"]));

                    lstImageInfoScreenMain.Add("Categorizede_main15", dtOceans.Rows[numrandomOceans3 - 1]["Categorized"].ToString());
                    lstImageInfoScreenMain.Add("Pathe_main15", dtOceans.Rows[numrandomOceans3 - 1]["Path"].ToString());
                    lstImageInfoScreenMain.Add("Favouritese_main15", dtOceans.Rows[numrandomOceans3 - 1]["Favorites"].ToString());
                    lstImageInfoScreenMain.Add("Commentse_main15", dtOceans.Rows[numrandomOceans3 - 1]["Comments"].ToString());
                    lstImageInfoScreenMain.Add("Viewse_main15", dtOceans.Rows[numrandomOceans3 - 1]["Views"].ToString());
                    lstImageInfoScreenMain.Add("Pricee_main15", dtOceans.Rows[numrandomOceans3 - 1]["Price"].ToString());
                  
                }
                else if (p == numrandomOceans4)
                {
                    pictureBoxShowingMain_16.Image = Image.FromFile(Convert.ToString(dtOceans.Rows[numrandomOceans4 - 1]["Path"]));

                    lstImageInfoScreenMain.Add("Categorized_main16", dtOceans.Rows[numrandomOceans4 - 1]["Categorized"].ToString());
                    lstImageInfoScreenMain.Add("Path_main16", dtOceans.Rows[numrandomOceans4 - 1]["Path"].ToString());
                    lstImageInfoScreenMain.Add("Favourites_main16", dtOceans.Rows[numrandomOceans4 - 1]["Favorites"].ToString());
                    lstImageInfoScreenMain.Add("Comments_main16", dtOceans.Rows[numrandomOceans4 - 1]["Comments"].ToString());
                    lstImageInfoScreenMain.Add("Views_main16", dtOceans.Rows[numrandomOceans4 - 1]["Views"].ToString());
                    lstImageInfoScreenMain.Add("Price_main16", dtOceans.Rows[numrandomOceans4 - 1]["Price"].ToString());
                   
                }
            }
            for (int o = 1; o < 243; o++)
            {
                if (o == numrandomMotoBike_1)
                {
                    pictureBoxShowingMain_17.Image = Image.FromFile(Convert.ToString(dtMotoBike.Rows[numrandomMotoBike_1 - 1]["Path"]));
                    pictureBox_click_panelExploreTopics_flowLayoutPanelMain_form1_categorizedMotoBike.Image = Image.FromFile(Convert.ToString(dtMotoBike.Rows[numrandomMotoBike_1 - 1]["Path"]));
                    pictureBox_panelSeeMore_flowLayoutPanelDetailPicture_form1_showingMore_9.Image= Image.FromFile(Convert.ToString(dtMotoBike.Rows[numrandomMotoBike_1 - 1]["Path"]));

                    lstImageInfoScreenMain.Add("Categorized_main17", dtMotoBike.Rows[numrandomMotoBike_1 - 1]["Categorized"].ToString());
                    lstImageInfoScreenMain.Add("Path_main17", dtMotoBike.Rows[numrandomMotoBike_1 - 1]["Path"].ToString());
                    lstImageInfoScreenMain.Add("Favourites_main17", dtMotoBike.Rows[numrandomMotoBike_1 - 1]["Favorites"].ToString());
                    lstImageInfoScreenMain.Add("Comments_main17", dtMotoBike.Rows[numrandomMotoBike_1 - 1]["Comments"].ToString());
                    lstImageInfoScreenMain.Add("Views_main17", dtMotoBike.Rows[numrandomMotoBike_1 - 1]["Views"].ToString());
                    lstImageInfoScreenMain.Add("Price_main17", dtMotoBike.Rows[numrandomMotoBike_1 - 1]["Price"].ToString());
                   


                }
                else if (o == numrandomMotoBike_2)
                {
                    pictureBoxShowingMain_18.Image = Image.FromFile(Convert.ToString(dtMotoBike.Rows[numrandomMotoBike_2 - 1]["Path"]));
                    pictureBox_panelSeeMore_flowLayoutPanelDetailPicture_form1_showingMore_10.Image = Image.FromFile(Convert.ToString(dtMotoBike.Rows[numrandomMotoBike_2 - 1]["Path"]));

                    lstImageInfoScreenMain.Add("Categorized_main18", dtMotoBike.Rows[numrandomMotoBike_2 - 1]["Categorized"].ToString());
                    lstImageInfoScreenMain.Add("Path_main18", dtMotoBike.Rows[numrandomMotoBike_2 - 1]["Path"].ToString());
                    lstImageInfoScreenMain.Add("Favourites_main18", dtMotoBike.Rows[numrandomMotoBike_2 - 1]["Favorites"].ToString());
                    lstImageInfoScreenMain.Add("Comments_main18", dtMotoBike.Rows[numrandomMotoBike_2 - 1]["Comments"].ToString());
                    lstImageInfoScreenMain.Add("Views_main18", dtMotoBike.Rows[numrandomMotoBike_2 - 1]["Views"].ToString());
                    lstImageInfoScreenMain.Add("Price_main18", dtMotoBike.Rows[numrandomMotoBike_2 - 1]["Price"].ToString());
          
                }
                else if (o == numrandomMotoBike_3)
                {
                    pictureBoxShowingMain_19.Image = Image.FromFile(Convert.ToString(dtMotoBike.Rows[numrandomMotoBike_3 - 1]["Path"]));
                    pictureBox_panelSeeMore_flowLayoutPanelDetailPicture_form1_showingMore_14.Image= Image.FromFile(Convert.ToString(dtMotoBike.Rows[numrandomMotoBike_3 - 1]["Path"]));
                    Dictionary<string, string> lstImageInfoScreenMain = new Dictionary<string, string>();
                    lstImageInfoScreenMain.Add("Categorized_main19", dtMotoBike.Rows[numrandomMotoBike_3 - 1]["Categorized"].ToString());
                    lstImageInfoScreenMain.Add("Path_main19", dtMotoBike.Rows[numrandomMotoBike_3 - 1]["Path"].ToString());
                    lstImageInfoScreenMain.Add("Favourites_main19", dtMotoBike.Rows[numrandomMotoBike_3 - 1]["Favorites"].ToString());
                    lstImageInfoScreenMain.Add("Comments_main19", dtMotoBike.Rows[numrandomMotoBike_3 - 1]["Comments"].ToString());
                    lstImageInfoScreenMain.Add("Views_main19", dtMotoBike.Rows[numrandomMotoBike_3 - 1]["Views"].ToString());
                    lstImageInfoScreenMain.Add("Price_main19", dtMotoBike.Rows[numrandomMotoBike_3 - 1]["Price"].ToString());
        
                }
                else if (o == numrandomMotoBike_4)
                {
                    pictureBoxShowingMain_20.Image = Image.FromFile(Convert.ToString(dtMotoBike.Rows[numrandomMotoBike_4 - 1]["Path"]));

                    lstImageInfoScreenMain.Add("Categorized_main20", dtMotoBike.Rows[numrandomMotoBike_4 - 1]["Categorized"].ToString());
                    lstImageInfoScreenMain.Add("Path_main20", dtMotoBike.Rows[numrandomMotoBike_4 - 1]["Path"].ToString());
                    lstImageInfoScreenMain.Add("Favourites_main20", dtMotoBike.Rows[numrandomMotoBike_4 - 1]["Favorites"].ToString());
                    lstImageInfoScreenMain.Add("Comments_main20", dtMotoBike.Rows[numrandomMotoBike_4 - 1]["Comments"].ToString());
                    lstImageInfoScreenMain.Add("Views_main20", dtMotoBike.Rows[numrandomMotoBike_4 - 1]["Views"].ToString());
                    lstImageInfoScreenMain.Add("Price_main20", dtMotoBike.Rows[numrandomMotoBike_4 - 1]["Price"].ToString());
              
                }
            }
            for (int u = 1; u < 160; u++)
            {
                if (u == numrandomFlower_1)
                {
                    pictureBoxShowingMain_21.Image = Image.FromFile(Convert.ToString(dtFlower.Rows[numrandomFlower_1 - 1]["Path"]));
                    pictureBox_click_panelExploreTopics_flowLayoutPanelMain_form1_categorizedFlower.Image = Image.FromFile(Convert.ToString(dtFlower.Rows[numrandomFlower_1 - 1]["Path"]));
                    pictureBox_panelSeeMore_flowLayoutPanelDetailPicture_form1_showingMore_11.Image= Image.FromFile(Convert.ToString(dtFlower.Rows[numrandomFlower_1 - 1]["Path"]));
         
                    lstImageInfoScreenMain.Add("Categorized_main21", dtFlower.Rows[numrandomFlower_1 - 1]["Categorized"].ToString());
                    lstImageInfoScreenMain.Add("Path_main21", dtFlower.Rows[numrandomFlower_1 - 1]["Path"].ToString());
                    lstImageInfoScreenMain.Add("Favourites_main21", dtFlower.Rows[numrandomFlower_1 - 1]["Favorites"].ToString());
                    lstImageInfoScreenMain.Add("Comments_main21", dtFlower.Rows[numrandomFlower_1 - 1]["Comments"].ToString());
                    lstImageInfoScreenMain.Add("Views_main21", dtFlower.Rows[numrandomFlower_1 - 1]["Views"].ToString());
                    lstImageInfoScreenMain.Add("Price_main21", dtFlower.Rows[numrandomFlower_1 - 1]["Price"].ToString());
           
                }
                else if (u == numrandomFlower_2)
                {
                    pictureBoxShowingMain_22.Image = Image.FromFile(Convert.ToString(dtFlower.Rows[numrandomFlower_2 - 1]["Path"]));
                    pictureBox_panelSeeMore_flowLayoutPanelDetailPicture_form1_showingMore_12.Image = Image.FromFile(Convert.ToString(dtFlower.Rows[numrandomFlower_2 - 1]["Path"]));

                    lstImageInfoScreenMain.Add("Categorized_main22", dtFlower.Rows[numrandomFlower_2 - 1]["Categorized"].ToString());
                    lstImageInfoScreenMain.Add("Path_main22", dtFlower.Rows[numrandomFlower_2 - 1]["Path"].ToString());
                    lstImageInfoScreenMain.Add("Favourites_main22", dtFlower.Rows[numrandomFlower_2 - 1]["Favorites"].ToString());
                    lstImageInfoScreenMain.Add("Comments_main22", dtFlower.Rows[numrandomFlower_2 - 1]["Comments"].ToString());
                    lstImageInfoScreenMain.Add("Views_main22", dtFlower.Rows[numrandomFlower_2 - 1]["Views"].ToString());
                    lstImageInfoScreenMain.Add("Price_main22", dtFlower.Rows[numrandomFlower_2 - 1]["Price"].ToString());

                }
                else if (u == numrandomFlower_3)
                {
                    pictureBoxShowingMain_23.Image = Image.FromFile(Convert.ToString(dtFlower.Rows[numrandomFlower_3 - 1]["Path"]));
                    pictureBox_panelSeeMore_flowLayoutPanelDetailPicture_form1_showingMore_13.Image = Image.FromFile(Convert.ToString(dtFlower.Rows[numrandomFlower_3 - 1]["Path"]));
       
                    lstImageInfoScreenMain.Add("Categorized_main23", dtFlower.Rows[numrandomFlower_3 - 1]["Categorized"].ToString());
                    lstImageInfoScreenMain.Add("Path_main23", dtFlower.Rows[numrandomFlower_3 - 1]["Path"].ToString());
                    lstImageInfoScreenMain.Add("Favourites_main23", dtFlower.Rows[numrandomFlower_3 - 1]["Favorites"].ToString());
                    lstImageInfoScreenMain.Add("Comments_main23", dtFlower.Rows[numrandomFlower_3 - 1]["Comments"].ToString());
                    lstImageInfoScreenMain.Add("Views_main23", dtFlower.Rows[numrandomFlower_3 - 1]["Views"].ToString());
                    lstImageInfoScreenMain.Add("Price_main23", dtFlower.Rows[numrandomFlower_3 - 1]["Price"].ToString());

                }
                else if (u == numrandomFlower_4)
                {
                    pictureBoxShowingMain_24.Image = Image.FromFile(Convert.ToString(dtFlower.Rows[numrandomFlower_4 - 1]["Path"]));
               
                    lstImageInfoScreenMain.Add("Categorized_main24", dtFlower.Rows[numrandomFlower_4 - 1]["Categorized"].ToString());
                    lstImageInfoScreenMain.Add("Path_main24", dtFlower.Rows[numrandomFlower_4 - 1]["Path"].ToString());
                    lstImageInfoScreenMain.Add("Favourites_main24", dtFlower.Rows[numrandomFlower_4 - 1]["Favorites"].ToString());
                    lstImageInfoScreenMain.Add("Comments_main24", dtFlower.Rows[numrandomFlower_4 - 1]["Comments"].ToString());
                    lstImageInfoScreenMain.Add("Views_main24", dtFlower.Rows[numrandomFlower_4 - 1]["Views"].ToString());
                    lstImageInfoScreenMain.Add("Price_main24", dtFlower.Rows[numrandomFlower_4 - 1]["Price"].ToString());

                }
            }
        }

        private void pictureBox_click_panelDashBoard_form1_home_MouseEnter(object sender, EventArgs e)
        {
            chatBubbleLeft_form1_home.Visible = true;
        }

        private void pictureBox_click_panelDashBoard_form1_home_MouseLeave(object sender, EventArgs e)
        {
            chatBubbleLeft_form1_home.Visible = false;
        }

        private void pictureBox_click_panelDashBoard_form1_daily_MouseEnter(object sender, EventArgs e)
        {
            chatBubbleLeft_form1_daily.Visible = true;
        }

        private void pictureBox_click_panelDashBoard_form1_daily_MouseLeave(object sender, EventArgs e)
        {
            chatBubbleLeft_form1_daily.Visible = false;
        }

        private void pictureBox_click_panelDashBoard_form1_topics_MouseEnter(object sender, EventArgs e)
        {
            chatBubbleLeft_form1_topics.Visible = true;
        }

        private void pictureBox_click_panelDashBoard_form1_topics_MouseLeave(object sender, EventArgs e)
        {
            chatBubbleLeft_form1_topics.Visible = false;
        }

        private void pictureBox_click_panelDashBoard_form1_trending_MouseEnter(object sender, EventArgs e)
        {
            chatBubbleLeft_form1_trending.Visible = true;
        }

        private void pictureBox_click_panelDashBoard_form1_trending_MouseLeave(object sender, EventArgs e)
        {
            chatBubbleLeft_form1_trending.Visible = false;

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        /// <summary>
        /// KHAI BÁO BIẾN ĐẾM PICTUREBOX ĐỂ XÁC ĐỊNH VỊ TRÍ CỦA PICBOX ĐÃ ĐƯỢC CLICK
        /// </summary>
        int danhgiau_pictureBoxShowing;
        private void pictureBoxShowingMain_1_Click(object sender, EventArgs e)
        {
            flowLayoutPanelDetailPicture_form1.Visible = true;
            flowLayoutPanelMain_form1.Visible = false;
            pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBoxShowingMain_1.Image;
            danhgiau_pictureBoxShowing = 1;
            button_click_panelDetailPicture_flowLayoutPanelDetailPicture_form1_tags_1.Text = "CAR";
            button_click_panelDetailPicture_Favourites.Text = lstImageInfoScreenMain["Favourites_main1"].ToString();
            button_click_panelDetailPicture_Comments.Text= lstImageInfoScreenMain["Comments_main1"].ToString();
            button_click_panelDetailPicture_Views.Text= lstImageInfoScreenMain["Views_main1"].ToString();
            if (lstImageInfoScreenMain["Price_main1"].ToString()=="0")
            {
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Text = "Free";
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Image = Image.FromFile(@"../../UsedForInterface/icon/free.png");

            }
            else if (lstImageInfoScreenMain["Price_main1"].ToString() == "1")
            {
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Text = "Costly";
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Image = Image.FromFile(@"../../UsedForInterface/icon/premium-quality.png");
            }
        }

        private void button_click_panelDetailPicture_flowLayoutPanelDetailPicture_form1_detailPictureBack_Click(object sender, EventArgs e)
        {
            if((danhgiau_pictureBoxShowing>=1 && danhgiau_pictureBoxShowing <=24) || (danhgiau_pictureBoxShowing >= 40 && danhgiau_pictureBoxShowing <= 57))
            {
                flowLayoutPanelDetailPicture_form1.Visible = false;
                flowLayoutPanelMain_form1.Visible = true;
            }
            else if(danhgiau_pictureBoxShowing>=25 && danhgiau_pictureBoxShowing <=30)
            {
                flowLayoutPanelDetailPicture_form1.Visible = false;
                flowLayoutPanelShowingAuthorDetail_form1.Visible = true;
            }
            else if(danhgiau_pictureBoxShowing>=31 && danhgiau_pictureBoxShowing <=39)
            {
                flowLayoutPanelDetailPicture_form1.Visible = false;
                flowLayoutPanelShowingAuthorDetail_form1.Visible = true;
                panelHome_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1.Visible = false;
            }
            else if (danhgiau_pictureBoxShowing >= 64 && danhgiau_pictureBoxShowing <= 75)
            {
                flowLayoutPanelDetailPicture_form1.Visible = false;
                flowLayoutPanelDailyAndTrending_form1.Visible = true;
            }
            else if(danhgiau_pictureBoxShowing>=76 && danhgiau_pictureBoxShowing<=87)
            {
                flowLayoutPanelDetailPicture_form1.Visible = false;
                flowLayoutPanelDetailTopics_form1.Visible = true;
            }
            else if (danhgiau_pictureBoxShowing >= 90 && danhgiau_pictureBoxShowing <= 119)
            {
                flowLayoutPanelDetailPicture_form1.Visible = false;
                flowLayoutPanel_searchResult.Visible = true;
            }




        }

        private void pictureBox_click_panelDetailPicture_flowLayoutPanelDetailPicture_form1_moreActions_MouseEnter(object sender, EventArgs e)
        {
            chatBubbleRight_panelDetailPicture_flowLayoutPanelDetailPicture_form1_moreActions.Visible = true;
        }

        private void pictureBox_click_panelDetailPicture_flowLayoutPanelDetailPicture_form1_moreActions_MouseLeave(object sender, EventArgs e)
        {
            chatBubbleRight_panelDetailPicture_flowLayoutPanelDetailPicture_form1_moreActions.Visible = false;
        }

        private void pictureBox_click_panelDetailPicture_flowLayoutPanelDetailPicture_form1_fullScreen_MouseEnter(object sender, EventArgs e)
        {
            chatBubbleRight_panelDetailPicture_flowLayoutPanelDetailPicture_form1_fullScreen.Visible = true;
        }

        private void pictureBox_click_panelDetailPicture_flowLayoutPanelDetailPicture_form1_fullScreen_MouseLeave(object sender, EventArgs e)
        {
            chatBubbleRight_panelDetailPicture_flowLayoutPanelDetailPicture_form1_fullScreen.Visible = false;
        }

        private void pictureBox28_MouseEnter(object sender, EventArgs e)
        {
            chatBubbleRight_panelDetailPicture_flowLayoutPanelDetailPicture_form1_addGem.Visible = true;
        }

        private void pictureBox28_MouseLeave(object sender, EventArgs e)
        {
            chatBubbleRight_panelDetailPicture_flowLayoutPanelDetailPicture_form1_addGem.Visible = false;
        }

        private void button_click_panelDetailPicture_flowLayoutPanelDetailPicture_form1_detailPictureBack_MouseEnter(object sender, EventArgs e)
        {
            button_click_panelDetailPicture_flowLayoutPanelDetailPicture_form1_detailPictureBack.ForeColor = Color.MediumSpringGreen;
        }

        private void button_click_panelDetailPicture_flowLayoutPanelDetailPicture_form1_detailPictureBack_MouseLeave(object sender, EventArgs e)
        {
            button_click_panelDetailPicture_flowLayoutPanelDetailPicture_form1_detailPictureBack.ForeColor = Color.White;
        }

        private void button_click_panelDetailPicture_flowLayoutPanelDetailPicture_form1_addToFavorite_MouseEnter(object sender, EventArgs e)
        {
            button_click_panelDetailPicture_flowLayoutPanelDetailPicture_form1_addToFavorite.ForeColor = Color.MediumSpringGreen;
        }

        private void button_click_panelDetailPicture_flowLayoutPanelDetailPicture_form1_addToFavorite_MouseLeave(object sender, EventArgs e)
        {
            button_click_panelDetailPicture_flowLayoutPanelDetailPicture_form1_addToFavorite.ForeColor = Color.White;
        }

        private void button_click_panelDetailPicture_flowLayoutPanelDetailPicture_form1_authorThang_1_MouseEnter(object sender, EventArgs e)
        {
            button_click_panelDetailPicture_flowLayoutPanelDetailPicture_form1_authorThang_1.ForeColor = Color.MediumSpringGreen;
        }

        private void button_click_panelDetailPicture_flowLayoutPanelDetailPicture_form1_authorThang_1_MouseLeave(object sender, EventArgs e)
        {
            button_click_panelDetailPicture_flowLayoutPanelDetailPicture_form1_authorThang_1.ForeColor = Color.White;
        }

        private void button_seemore_MouseEnter(object sender, EventArgs e)
        {
            button_seemore.ForeColor = Color.MediumSpringGreen;
        }

        private void button_seemore_MouseLeave(object sender, EventArgs e)
        {
            button_seemore.ForeColor = Color.White;
        }

        private void button_click_panelSeeMore_flowLayoutPanelDetailPicture_form1_authorThang_2_MouseEnter(object sender, EventArgs e)
        {
            button_click_panelSeeMore_flowLayoutPanelDetailPicture_form1_authorThang_2.ForeColor = Color.MediumSpringGreen;
        }

        private void button_click_panelSeeMore_flowLayoutPanelDetailPicture_form1_authorThang_2_MouseLeave(object sender, EventArgs e)
        {
            button_click_panelSeeMore_flowLayoutPanelDetailPicture_form1_authorThang_2.ForeColor = Color.White;
        }

        private void button_distributed_MouseEnter(object sender, EventArgs e)
        {
            button_distributed.ForeColor = Color.MediumSpringGreen;
        }

        private void button_distributed_MouseLeave(object sender, EventArgs e)
        {
            button_distributed.ForeColor = Color.White;
        }

        private void button_click_panelSeeMore_flowLayoutPanelDetailPicture_form1_authorTri_1_MouseEnter(object sender, EventArgs e)
        {
            button_click_panelSeeMore_flowLayoutPanelDetailPicture_form1_authorTri_1.ForeColor = Color.MediumSpringGreen;
        }

        private void button_click_panelSeeMore_flowLayoutPanelDetailPicture_form1_authorTri_1_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void button_click_panelSeeMore_flowLayoutPanelDetailPicture_form1_authorTri_1_MouseLeave(object sender, EventArgs e)
        {
            button_click_panelSeeMore_flowLayoutPanelDetailPicture_form1_authorTri_1.ForeColor = Color.White;
        }

        private void button_click_panelSeeMore_flowLayoutPanelDetailPicture_form1_interior_MouseEnter(object sender, EventArgs e)
        {
            button_click_panelSeeMore_flowLayoutPanelDetailPicture_form1_categorizeRandomByAuthorTri2.ForeColor = Color.MediumSpringGreen;
        }

        private void button_click_panelSeeMore_flowLayoutPanelDetailPicture_form1_interior_MouseLeave(object sender, EventArgs e)
        {
            button_click_panelSeeMore_flowLayoutPanelDetailPicture_form1_categorizeRandomByAuthorTri2.ForeColor = Color.White;
        }

        private void button_click_panelSeeMore_flowLayoutPanelDetailPicture_form1_authorTri_2_MouseEnter(object sender, EventArgs e)
        {
            button_click_panelSeeMore_flowLayoutPanelDetailPicture_form1_authorTri_2.ForeColor = Color.MediumSpringGreen;
        }

        private void button_click_panelSeeMore_flowLayoutPanelDetailPicture_form1_authorTri_2_MouseLeave(object sender, EventArgs e)
        {
            button_click_panelSeeMore_flowLayoutPanelDetailPicture_form1_authorTri_2.ForeColor = Color.White;
        }
        /// <summary>
        /// KHAI BÁO BIẾN COMMENT ĐỂ LẤY SỐ LẦN NGƯỜI DÙNG BẤM NÚT POST COMMENT.NẾU POST 1 LẦN THÌ PANELCOMMENT 1 HIỆN,POST 2 LÀN THÌ PANEL COMMENT 2 HIỆN LÊN...SEE BELOW!!
        /// </summary>



        /// lINKELABEL của button share_panelMoreActions_panelDetailPicture_flowLayoutPanelDetailPicture_form1
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.facebook.com");
        }
        /// <summary>
        /// KHAI BÁO BIẾN MOREACTIONS CHỈ ĐỂ HIỆN THỊ VÀ ẨN CÁI PANEL MORE ACTIONS...SEE BELOW!
        /// </summary>
        int moreactions_panelMoreActions_panelDetailPicture_flowLayoutPanelDetailPicture_form1 = 0;
        private void pictureBox_click_panelDetailPicture_flowLayoutPanelDetailPicture_form1_moreActions_Click(object sender, EventArgs e)
        {
            if (moreactions_panelMoreActions_panelDetailPicture_flowLayoutPanelDetailPicture_form1 % 2 == 0)
            {
                panelMoreActions_panelDetailPicture_flowLayoutPanelDetailPicture_form1.Visible = true;
                moreactions_panelMoreActions_panelDetailPicture_flowLayoutPanelDetailPicture_form1++;
            }
            else if (moreactions_panelMoreActions_panelDetailPicture_flowLayoutPanelDetailPicture_form1 % 2 != 0)
            {
                panelMoreActions_panelDetailPicture_flowLayoutPanelDetailPicture_form1.Visible = false;
                moreactions_panelMoreActions_panelDetailPicture_flowLayoutPanelDetailPicture_form1++;
            }
        }

        private void pictureBox_click_panelDetailPicture_flowLayoutPanelDetailPicture_form1_fullScreen_Click(object sender, EventArgs e)
        {
            panelfullScreen_form1.Visible = true;
            flowLayoutPanelDetailPicture_form1.Visible = false;
            flowLayoutPanelMain_form1.Visible = false;
            pictureBox_panelfullScreen_form1_fullScreen.Image = pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image;
        }

        private void button_click_panelfullScreen_form1_exitFullScreen_Click(object sender, EventArgs e)
        {
            panelfullScreen_form1.Visible = false;
            flowLayoutPanelDetailPicture_form1.Visible = true;
        }
        /// <summary>
        /// KHAI BÁO BIẾN FAVORITE CHỈ ĐỂ THAY ĐỔI MÀU VÀ ẢNH CỦA BUTTON ADD TO FAVOURITES...SEE BELOW!
        /// </summary>
        int fav = 0;
        private void button_click_panelDetailPicture_flowLayoutPanelDetailPicture_form1_addToFavorite_Click(object sender, EventArgs e)
        {
            if (fav % 2 == 0)
            {
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_form1_addToFavorite.Text = "In Favorite";
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_form1_addToFavorite.Image = Image.FromFile(@"../../UsedForInterface/icon/favourite.png");
                fav++;
            }
            else if (fav % 2 != 0)
            {
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_form1_addToFavorite.Text = "Add to favourite";
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_form1_addToFavorite.Image = Image.FromFile(@"../../UsedForInterface/icon/notfavorite.png");
                fav++;
            }
        }

        private void linkLabel_panelProfilesAuthor_panelHome_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_facebook_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.facebook.com");
        }

        private void linkLabel_panelProfilesAuthor_panelHome_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_instar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.instagram.com/clockbirds/");
        }

        private void linkLabel_panelProfilesAuthor_panelHome_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_youtube_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.youtube.com/clockbirds");
        }


        private void pictureBoxShowingMain_2_Click(object sender, EventArgs e)
        {
            flowLayoutPanelDetailPicture_form1.Visible = true;
            flowLayoutPanelMain_form1.Visible = false;
            pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBoxShowingMain_2.Image;
            danhgiau_pictureBoxShowing = 2;
            button_click_panelDetailPicture_flowLayoutPanelDetailPicture_form1_tags_1.Text = "CAR";
            button_click_panelDetailPicture_Favourites.Text = lstImageInfoScreenMain["Favourites_main2"].ToString();
            button_click_panelDetailPicture_Comments.Text = lstImageInfoScreenMain["Comments_main2"].ToString();
            button_click_panelDetailPicture_Views.Text = lstImageInfoScreenMain["Views_main2"].ToString();
            if (lstImageInfoScreenMain["Price_main2"].ToString() == "0")
            {
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Text = "Free";
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Image = Image.FromFile(@"../../UsedForInterface/icon/free.png");

            }
            else if (lstImageInfoScreenMain["Price_main2"].ToString() == "1")
            {
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Text = "Costly";
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Image = Image.FromFile(@"../../UsedForInterface/icon/premium-quality.png");
            }
        }

        private void pictureBoxShowingMain_3_Click(object sender, EventArgs e)
        {
            flowLayoutPanelDetailPicture_form1.Visible = true;
            flowLayoutPanelMain_form1.Visible = false;
            pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBoxShowingMain_3.Image;
            danhgiau_pictureBoxShowing = 3;
            button_click_panelDetailPicture_flowLayoutPanelDetailPicture_form1_tags_1.Text = "CAR";
            button_click_panelDetailPicture_Favourites.Text = lstImageInfoScreenMain["Favourites_main3"].ToString();
            button_click_panelDetailPicture_Comments.Text = lstImageInfoScreenMain["Comments_main3"].ToString();
            button_click_panelDetailPicture_Views.Text = lstImageInfoScreenMain["Views_main3"].ToString();
            if (lstImageInfoScreenMain["Price_main3"].ToString() == "0")
            {
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Text = "Free";
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Image = Image.FromFile(@"../../UsedForInterface/icon/free.png");

            }
            else if (lstImageInfoScreenMain["Price_main3"].ToString() == "1")
            {
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Text = "Costly";
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Image = Image.FromFile(@"../../UsedForInterface/icon/premium-quality.png");
            }
        }

        private void pictureBoxShowingMain_4_Click(object sender, EventArgs e)
        {
            flowLayoutPanelDetailPicture_form1.Visible = true;
            flowLayoutPanelMain_form1.Visible = false;
            pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBoxShowingMain_4.Image;
            danhgiau_pictureBoxShowing = 4;
            button_click_panelDetailPicture_flowLayoutPanelDetailPicture_form1_tags_1.Text = "CAR";
            button_click_panelDetailPicture_Favourites.Text = lstImageInfoScreenMain["Favourites_main4"].ToString();
            button_click_panelDetailPicture_Comments.Text = lstImageInfoScreenMain["Comments_main4"].ToString();
            button_click_panelDetailPicture_Views.Text = lstImageInfoScreenMain["Views_main4"].ToString();
            if (lstImageInfoScreenMain["Price_main4"].ToString() == "0")
            {
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Text = "Free";
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Image = Image.FromFile(@"../../UsedForInterface/icon/free.png");

            }
            else if (lstImageInfoScreenMain["Price_main4"].ToString() == "1")
            {
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Text = "Costly";
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Image = Image.FromFile(@"../../UsedForInterface/icon/premium-quality.png");
            }
        }

        private void pictureBoxShowingMain_5_Click(object sender, EventArgs e)
        {
            flowLayoutPanelDetailPicture_form1.Visible = true;
            flowLayoutPanelMain_form1.Visible = false;
            pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBoxShowingMain_5.Image;
            danhgiau_pictureBoxShowing = 5;
            button_click_panelDetailPicture_flowLayoutPanelDetailPicture_form1_tags_1.Text = "INTERIOR";
            button_click_panelDetailPicture_Favourites.Text = lstImageInfoScreenMain["Favourites_main5"].ToString();
            button_click_panelDetailPicture_Comments.Text = lstImageInfoScreenMain["Comments_main5"].ToString();
            button_click_panelDetailPicture_Views.Text = lstImageInfoScreenMain["Views_main5"].ToString();
            if (lstImageInfoScreenMain["Price_main5"].ToString() == "0")
            {
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Text = "Free";
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Image = Image.FromFile(@"../../UsedForInterface/icon/free.png");

            }
            else if (lstImageInfoScreenMain["Price_main5"].ToString() == "1")
            {
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Text = "Costly";
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Image = Image.FromFile(@"../../UsedForInterface/icon/premium-quality.png");
            }
        }

        private void pictureBoxShowingMain_6_Click(object sender, EventArgs e)
        {
            flowLayoutPanelDetailPicture_form1.Visible = true;
            flowLayoutPanelMain_form1.Visible = false;
            pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBoxShowingMain_6.Image;
            danhgiau_pictureBoxShowing = 6;
            button_click_panelDetailPicture_flowLayoutPanelDetailPicture_form1_tags_1.Text = "INTERIOR";
            button_click_panelDetailPicture_Favourites.Text = lstImageInfoScreenMain["Favourites_main6"].ToString();
            button_click_panelDetailPicture_Comments.Text = lstImageInfoScreenMain["Comments_main6"].ToString();
            button_click_panelDetailPicture_Views.Text = lstImageInfoScreenMain["Views_main6"].ToString();
            if (lstImageInfoScreenMain["Price_main6"].ToString() == "0")
            {
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Text = "Free";
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Image = Image.FromFile(@"../../UsedForInterface/icon/free.png");

            }
            else if (lstImageInfoScreenMain["Price_main6"].ToString() == "1")
            {
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Text = "Costly";
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Image = Image.FromFile(@"../../UsedForInterface/icon/premium-quality.png");
            }
        }

        private void pictureBoxShowingMain_7_Click(object sender, EventArgs e)
        {
            flowLayoutPanelDetailPicture_form1.Visible = true;
            flowLayoutPanelMain_form1.Visible = false;
            pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBoxShowingMain_7.Image;
            danhgiau_pictureBoxShowing = 7;
            button_click_panelDetailPicture_flowLayoutPanelDetailPicture_form1_tags_1.Text = "INTERIOR";
            button_click_panelDetailPicture_Favourites.Text = lstImageInfoScreenMain["Favourites_main7"].ToString();
            button_click_panelDetailPicture_Comments.Text = lstImageInfoScreenMain["Comments_main7"].ToString();
            button_click_panelDetailPicture_Views.Text = lstImageInfoScreenMain["Views_main7"].ToString();
            if (lstImageInfoScreenMain["Price_main7"].ToString() == "0")
            {
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Text = "Free";
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Image = Image.FromFile(@"../../UsedForInterface/icon/free.png");

            }
            else if (lstImageInfoScreenMain["Price_main7"].ToString() == "1")
            {
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Text = "Costly";
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Image = Image.FromFile(@"../../UsedForInterface/icon/premium-quality.png");
            }
        }

        private void pictureBoxShowingMain_8_Click(object sender, EventArgs e)
        {
            flowLayoutPanelDetailPicture_form1.Visible = true;
            flowLayoutPanelMain_form1.Visible = false;
            pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBoxShowingMain_8.Image;
            danhgiau_pictureBoxShowing = 8;
            button_click_panelDetailPicture_flowLayoutPanelDetailPicture_form1_tags_1.Text = "INTERIOR";
            button_click_panelDetailPicture_Favourites.Text = lstImageInfoScreenMain["Favourites_main8"].ToString();
            button_click_panelDetailPicture_Comments.Text = lstImageInfoScreenMain["Comments_main8"].ToString();
            button_click_panelDetailPicture_Views.Text = lstImageInfoScreenMain["Views_main8"].ToString();
            if (lstImageInfoScreenMain["Price_main8"].ToString() == "0")
            {
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Text = "Free";
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Image = Image.FromFile(@"../../UsedForInterface/icon/free.png");

            }
            else if (lstImageInfoScreenMain["Price_main8"].ToString() == "1")
            {
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Text = "Costly";
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Image = Image.FromFile(@"../../UsedForInterface/icon/premium-quality.png");
            }
        }

        private void pictureBoxShowingMain_9_Click(object sender, EventArgs e)
        {
            flowLayoutPanelDetailPicture_form1.Visible = true;
            flowLayoutPanelMain_form1.Visible = false;
            pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBoxShowingMain_9.Image;
            danhgiau_pictureBoxShowing = 9;
            button_click_panelDetailPicture_flowLayoutPanelDetailPicture_form1_tags_1.Text = "FOREST";
            button_click_panelDetailPicture_Favourites.Text = lstImageInfoScreenMain["Favourites_main9"].ToString();
            button_click_panelDetailPicture_Comments.Text = lstImageInfoScreenMain["Comments_main9"].ToString();
            button_click_panelDetailPicture_Views.Text = lstImageInfoScreenMain["Views_main9"].ToString();
            if (lstImageInfoScreenMain["Price_main9"].ToString() == "0")
            {
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Text = "Free";
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Image = Image.FromFile(@"../../UsedForInterface/icon/free.png");

            }
            else if (lstImageInfoScreenMain["Price_main9"].ToString() == "1")
            {
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Text = "Costly";
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Image = Image.FromFile(@"../../UsedForInterface/icon/premium-quality.png");
            }
        }

        private void pictureBoxShowingMain_10_Click(object sender, EventArgs e)
        {
            flowLayoutPanelDetailPicture_form1.Visible = true;
            flowLayoutPanelMain_form1.Visible = false;
            pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBoxShowingMain_10.Image;
            danhgiau_pictureBoxShowing = 10;
            button_click_panelDetailPicture_flowLayoutPanelDetailPicture_form1_tags_1.Text = "FOREST";
            button_click_panelDetailPicture_Favourites.Text = lstImageInfoScreenMain["Favourites_main10"].ToString();
            button_click_panelDetailPicture_Comments.Text = lstImageInfoScreenMain["Comments_main10"].ToString();
            button_click_panelDetailPicture_Views.Text = lstImageInfoScreenMain["Views_main10"].ToString();
            if (lstImageInfoScreenMain["Price_main10"].ToString() == "0")
            {
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Text = "Free";
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Image = Image.FromFile(@"../../UsedForInterface/icon/free.png");

            }
            else if (lstImageInfoScreenMain["Price_main10"].ToString() == "1")
            {
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Text = "Costly";
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Image = Image.FromFile(@"../../UsedForInterface/icon/premium-quality.png");
            }
        }

        private void pictureBoxShowingMain_11_Click(object sender, EventArgs e)
        {
            flowLayoutPanelDetailPicture_form1.Visible = true;
            flowLayoutPanelMain_form1.Visible = false;
            pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBoxShowingMain_11.Image;
            danhgiau_pictureBoxShowing = 11;
            button_click_panelDetailPicture_flowLayoutPanelDetailPicture_form1_tags_1.Text = "FOREST";
            button_click_panelDetailPicture_Favourites.Text = lstImageInfoScreenMain["Favourites_main11"].ToString();
            button_click_panelDetailPicture_Comments.Text = lstImageInfoScreenMain["Comments_main11"].ToString();
            button_click_panelDetailPicture_Views.Text = lstImageInfoScreenMain["Views_main11"].ToString();
            if (lstImageInfoScreenMain["Price_main11"].ToString() == "0")
            {
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Text = "Free";
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Image = Image.FromFile(@"../../UsedForInterface/icon/free.png");

            }
            else if (lstImageInfoScreenMain["Price_main11"].ToString() == "1")
            {
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Text = "Costly";
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Image = Image.FromFile(@"../../UsedForInterface/icon/premium-quality.png");
            }
        }

        private void pictureBoxShowingMain_12_Click(object sender, EventArgs e)
        {
            flowLayoutPanelDetailPicture_form1.Visible = true;
            flowLayoutPanelMain_form1.Visible = false;
            pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBoxShowingMain_12.Image;
            danhgiau_pictureBoxShowing = 12;
            button_click_panelDetailPicture_flowLayoutPanelDetailPicture_form1_tags_1.Text = "FOREST";
            button_click_panelDetailPicture_Favourites.Text = lstImageInfoScreenMain["Favourites_main12"].ToString();
            button_click_panelDetailPicture_Comments.Text = lstImageInfoScreenMain["Comments_main12"].ToString();
            button_click_panelDetailPicture_Views.Text = lstImageInfoScreenMain["Views_main12"].ToString();
            if (lstImageInfoScreenMain["Price_main12"].ToString() == "0")
            {
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Text = "Free";
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Image = Image.FromFile(@"../../UsedForInterface/icon/free.png");

            }
            else if (lstImageInfoScreenMain["Price_main12"].ToString() == "1")
            {
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Text = "Costly";
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Image = Image.FromFile(@"../../UsedForInterface/icon/premium-quality.png");
            }
        }

        private void pictureBoxShowingMain_13_Click(object sender, EventArgs e)
        {
            flowLayoutPanelDetailPicture_form1.Visible = true;
            flowLayoutPanelMain_form1.Visible = false;
            pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBoxShowingMain_13.Image;
            danhgiau_pictureBoxShowing = 13;
            button_click_panelDetailPicture_flowLayoutPanelDetailPicture_form1_tags_1.Text = "OCEANS";
            button_click_panelDetailPicture_Favourites.Text = lstImageInfoScreenMain["Favourites_main13"].ToString();
            button_click_panelDetailPicture_Comments.Text = lstImageInfoScreenMain["Comments_main13"].ToString();
            button_click_panelDetailPicture_Views.Text = lstImageInfoScreenMain["Views_main13"].ToString();
            if (lstImageInfoScreenMain["Price_main13"].ToString() == "0")
            {
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Text = "Free";
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Image = Image.FromFile(@"../../UsedForInterface/icon/free.png");

            }
            else if (lstImageInfoScreenMain["Price_main13"].ToString() == "1")
            {
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Text = "Costly";
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Image = Image.FromFile(@"../../UsedForInterface/icon/premium-quality.png");
            }
        }

        private void pictureBoxShowingMain_14_Click(object sender, EventArgs e)
        {
            flowLayoutPanelDetailPicture_form1.Visible = true;
            flowLayoutPanelMain_form1.Visible = false;
            pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBoxShowingMain_14.Image;
            danhgiau_pictureBoxShowing = 14;
            button_click_panelDetailPicture_flowLayoutPanelDetailPicture_form1_tags_1.Text = "OCEANS";
            button_click_panelDetailPicture_Favourites.Text = lstImageInfoScreenMain["Favourites_main14"].ToString();
            button_click_panelDetailPicture_Comments.Text = lstImageInfoScreenMain["Comments_main14"].ToString();
            button_click_panelDetailPicture_Views.Text = lstImageInfoScreenMain["Views_main1"].ToString();
            if (lstImageInfoScreenMain["Price_main14"].ToString() == "0")
            {
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Text = "Free";
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Image = Image.FromFile(@"../../UsedForInterface/icon/free.png");

            }
            else if (lstImageInfoScreenMain["Price_main14"].ToString() == "1")
            {
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Text = "Costly";
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Image = Image.FromFile(@"../../UsedForInterface/icon/premium-quality.png");
            }
        }

        private void pictureBoxShowingMain_15_Click(object sender, EventArgs e)
        {
            flowLayoutPanelDetailPicture_form1.Visible = true;
            flowLayoutPanelMain_form1.Visible = false;
            pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBoxShowingMain_15.Image;
            danhgiau_pictureBoxShowing = 15;
            button_click_panelDetailPicture_flowLayoutPanelDetailPicture_form1_tags_1.Text = "OCEANS";
            button_click_panelDetailPicture_Favourites.Text = lstImageInfoScreenMain["Favourites_main15"].ToString();
            button_click_panelDetailPicture_Comments.Text = lstImageInfoScreenMain["Comments_main15"].ToString();
            button_click_panelDetailPicture_Views.Text = lstImageInfoScreenMain["Views_main15"].ToString();
            if (lstImageInfoScreenMain["Price_main15"].ToString() == "0")
            {
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Text = "Free";
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Image = Image.FromFile(@"../../UsedForInterface/icon/free.png");

            }
            else if (lstImageInfoScreenMain["Price_main15"].ToString() == "1")
            {
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Text = "Costly";
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Image = Image.FromFile(@"../../UsedForInterface/icon/premium-quality.png");
            }
        }

        private void pictureBoxShowingMain_16_Click(object sender, EventArgs e)
        {
            flowLayoutPanelDetailPicture_form1.Visible = true;
            flowLayoutPanelMain_form1.Visible = false;
            pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBoxShowingMain_16.Image;
            danhgiau_pictureBoxShowing = 16;
            button_click_panelDetailPicture_flowLayoutPanelDetailPicture_form1_tags_1.Text = "OCEANS";
            button_click_panelDetailPicture_Favourites.Text = lstImageInfoScreenMain["Favourites_main16"].ToString();
            button_click_panelDetailPicture_Comments.Text = lstImageInfoScreenMain["Comments_main16"].ToString();
            button_click_panelDetailPicture_Views.Text = lstImageInfoScreenMain["Views_main16"].ToString();
            if (lstImageInfoScreenMain["Price_main16"].ToString() == "0")
            {
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Text = "Free";
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Image = Image.FromFile(@"../../UsedForInterface/icon/free.png");

            }
            else if (lstImageInfoScreenMain["Price_main16"].ToString() == "1")
            {
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Text = "Costly";
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Image = Image.FromFile(@"../../UsedForInterface/icon/premium-quality.png");
            }
        }

        private void pictureBoxShowingMain_17_Click(object sender, EventArgs e)
        {
            flowLayoutPanelDetailPicture_form1.Visible = true;
            flowLayoutPanelMain_form1.Visible = false;
            pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBoxShowingMain_17.Image;
            danhgiau_pictureBoxShowing = 17;
            button_click_panelDetailPicture_flowLayoutPanelDetailPicture_form1_tags_1.Text = "MOTOBIKE";
            button_click_panelDetailPicture_Favourites.Text = lstImageInfoScreenMain["Favourites_main17"].ToString();
            button_click_panelDetailPicture_Comments.Text = lstImageInfoScreenMain["Comments_main17"].ToString();
            button_click_panelDetailPicture_Views.Text = lstImageInfoScreenMain["Views_main17"].ToString();
            if (lstImageInfoScreenMain["Price_main17"].ToString() == "0")
            {
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Text = "Free";
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Image = Image.FromFile(@"../../UsedForInterface/icon/free.png");

            }
            else if (lstImageInfoScreenMain["Price_main17"].ToString() == "1")
            {
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Text = "Costly";
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Image = Image.FromFile(@"../../UsedForInterface/icon/premium-quality.png");
            }
        }

        private void pictureBoxShowingMain_18_Click(object sender, EventArgs e)
        {
            flowLayoutPanelDetailPicture_form1.Visible = true;
            flowLayoutPanelMain_form1.Visible = false;
            pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBoxShowingMain_18.Image;
            danhgiau_pictureBoxShowing = 18;
            button_click_panelDetailPicture_flowLayoutPanelDetailPicture_form1_tags_1.Text = "MOTOBIKE";
            button_click_panelDetailPicture_Favourites.Text = lstImageInfoScreenMain["Favourites_main18"].ToString();
            button_click_panelDetailPicture_Comments.Text = lstImageInfoScreenMain["Comments_main18"].ToString();
            button_click_panelDetailPicture_Views.Text = lstImageInfoScreenMain["Views_main18"].ToString();
            if (lstImageInfoScreenMain["Price_main18"].ToString() == "0")
            {
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Text = "Free";
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Image = Image.FromFile(@"../../UsedForInterface/icon/free.png");

            }
            else if (lstImageInfoScreenMain["Price_main18"].ToString() == "1")
            {
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Text = "Costly";
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Image = Image.FromFile(@"../../UsedForInterface/icon/premium-quality.png");
            }
        }

        private void pictureBoxShowingMain_19_Click(object sender, EventArgs e)
        {
            flowLayoutPanelDetailPicture_form1.Visible = true;
            flowLayoutPanelMain_form1.Visible = false;
            pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBoxShowingMain_19.Image;
            danhgiau_pictureBoxShowing = 19;
            button_click_panelDetailPicture_flowLayoutPanelDetailPicture_form1_tags_1.Text = "MOTOBIKE";
            button_click_panelDetailPicture_Favourites.Text = lstImageInfoScreenMain["Favourites_main19"].ToString();
            button_click_panelDetailPicture_Comments.Text = lstImageInfoScreenMain["Comments_main19"].ToString();
            button_click_panelDetailPicture_Views.Text = lstImageInfoScreenMain["Views_main19"].ToString();
            if (lstImageInfoScreenMain["Price_main19"].ToString() == "0")
            {
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Text = "Free";
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Image = Image.FromFile(@"../../UsedForInterface/icon/free.png");

            }
            else if (lstImageInfoScreenMain["Price_main19"].ToString() == "1")
            {
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Text = "Costly";
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Image = Image.FromFile(@"../../UsedForInterface/icon/premium-quality.png");
            }
        }

        private void pictureBoxShowingMain_20_Click(object sender, EventArgs e)
        {
            flowLayoutPanelDetailPicture_form1.Visible = true;
            flowLayoutPanelMain_form1.Visible = false;
            pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBoxShowingMain_20.Image;
            danhgiau_pictureBoxShowing = 20;
            button_click_panelDetailPicture_flowLayoutPanelDetailPicture_form1_tags_1.Text = "MOTOBIKE";
            button_click_panelDetailPicture_Favourites.Text = lstImageInfoScreenMain["Favourites_main20"].ToString();
            button_click_panelDetailPicture_Comments.Text = lstImageInfoScreenMain["Comments_main20"].ToString();
            button_click_panelDetailPicture_Views.Text = lstImageInfoScreenMain["Views_main20"].ToString();
            if (lstImageInfoScreenMain["Price_main20"].ToString() == "0")
            {
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Text = "Free";
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Image = Image.FromFile(@"../../UsedForInterface/icon/free.png");

            }
            else if (lstImageInfoScreenMain["Price_main20"].ToString() == "1")
            {
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Text = "Costly";
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Image = Image.FromFile(@"../../UsedForInterface/icon/premium-quality.png");
            }

        }

        private void pictureBoxShowingMain_21_Click(object sender, EventArgs e)
        {
            flowLayoutPanelDetailPicture_form1.Visible = true;
            flowLayoutPanelMain_form1.Visible = false;
            pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBoxShowingMain_21.Image;
            danhgiau_pictureBoxShowing = 21;
            button_click_panelDetailPicture_flowLayoutPanelDetailPicture_form1_tags_1.Text = "FLOWER";
            button_click_panelDetailPicture_Favourites.Text = lstImageInfoScreenMain["Favourites_main21"].ToString();
            button_click_panelDetailPicture_Comments.Text = lstImageInfoScreenMain["Comments_main21"].ToString();
            button_click_panelDetailPicture_Views.Text = lstImageInfoScreenMain["Views_main21"].ToString();
            if (lstImageInfoScreenMain["Price_main21"].ToString() == "0")
            {
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Text = "Free";
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Image = Image.FromFile(@"../../UsedForInterface/icon/free.png");

            }
            else if (lstImageInfoScreenMain["Price_main21"].ToString() == "1")
            {
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Text = "Costly";
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Image = Image.FromFile(@"../../UsedForInterface/icon/premium-quality.png");
            }
        }

        private void pictureBoxShowingMain_22_Click(object sender, EventArgs e)
        {
            flowLayoutPanelDetailPicture_form1.Visible = true;
            flowLayoutPanelMain_form1.Visible = false;
            pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBoxShowingMain_22.Image;
            danhgiau_pictureBoxShowing = 22;
            button_click_panelDetailPicture_flowLayoutPanelDetailPicture_form1_tags_1.Text = "FLOWER";
            button_click_panelDetailPicture_Favourites.Text = lstImageInfoScreenMain["Favourites_main22"].ToString();
            button_click_panelDetailPicture_Comments.Text = lstImageInfoScreenMain["Comments_main22"].ToString();
            button_click_panelDetailPicture_Views.Text = lstImageInfoScreenMain["Views_main22"].ToString();
            if (lstImageInfoScreenMain["Price_main22"].ToString() == "0")
            {
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Text = "Free";
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Image = Image.FromFile(@"../../UsedForInterface/icon/free.png");

            }
            else if (lstImageInfoScreenMain["Price_main22"].ToString() == "1")
            {
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Text = "Costly";
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Image = Image.FromFile(@"../../UsedForInterface/icon/premium-quality.png");
            }
        }

        private void pictureBoxShowingMain_23_Click(object sender, EventArgs e)
        {
            flowLayoutPanelDetailPicture_form1.Visible = true;
            flowLayoutPanelMain_form1.Visible = false;
            pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBoxShowingMain_23.Image;
            danhgiau_pictureBoxShowing = 23;
            button_click_panelDetailPicture_flowLayoutPanelDetailPicture_form1_tags_1.Text = "FLOWER";
            button_click_panelDetailPicture_Favourites.Text = lstImageInfoScreenMain["Favourites_main23"].ToString();
            button_click_panelDetailPicture_Comments.Text = lstImageInfoScreenMain["Comments_main23"].ToString();
            button_click_panelDetailPicture_Views.Text = lstImageInfoScreenMain["Views_main23"].ToString();
            if (lstImageInfoScreenMain["Price_main23"].ToString() == "0")
            {
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Text = "Free";
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Image = Image.FromFile(@"../../UsedForInterface/icon/free.png");

            }
            else if (lstImageInfoScreenMain["Price_main23"].ToString() == "1")
            {
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Text = "Costly";
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Image = Image.FromFile(@"../../UsedForInterface/icon/premium-quality.png");
            }
        }

        private void pictureBoxShowingMain_24_Click(object sender, EventArgs e)
        {
            flowLayoutPanelDetailPicture_form1.Visible = true;
            flowLayoutPanelMain_form1.Visible = false;
            pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBoxShowingMain_24.Image;
            danhgiau_pictureBoxShowing = 24;
            button_click_panelDetailPicture_flowLayoutPanelDetailPicture_form1_tags_1.Text = "FLOWER";
            button_click_panelDetailPicture_Favourites.Text = lstImageInfoScreenMain["Favourites_main24"].ToString();
            button_click_panelDetailPicture_Comments.Text = lstImageInfoScreenMain["Comments_main24"].ToString();
            button_click_panelDetailPicture_Views.Text = lstImageInfoScreenMain["Views_main24"].ToString();
            if (lstImageInfoScreenMain["Price_main24"].ToString() == "0")
            {
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Text = "Free";
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Image = Image.FromFile(@"../../UsedForInterface/icon/free.png");

            }
            else if (lstImageInfoScreenMain["Price_main24"].ToString() == "1")
            {
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Text = "Costly";
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Image = Image.FromFile(@"../../UsedForInterface/icon/premium-quality.png");
            }
        }
        private void label2_MouseEnter(object sender, EventArgs e)
        {
            label2.ForeColor = Color.MediumSpringGreen;
        }
        private void label2_MouseLeave(object sender, EventArgs e)
        {
            label2.ForeColor = Color.White;
        }
        private void button_click_panelDetailPicture_flowLayoutPanelDetailPicture_form1_back_Click(object sender, EventArgs e)
        {
            int back;
            --danhgiau_pictureBoxShowing;
            back = danhgiau_pictureBoxShowing;

            switch (back)
            {
                case 1:
                    pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBoxShowingMain_1.Image;
                    break;
                case 2:
                    pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBoxShowingMain_2.Image;
                    break;
                case 3:
                    pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBoxShowingMain_3.Image;
                    break;
                case 4:
                    pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBoxShowingMain_4.Image;
                    break;
                case 5:
                    pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBoxShowingMain_5.Image;
                    break;
                case 6:
                    pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBoxShowingMain_6.Image;
                    break;
                case 7:
                    pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBoxShowingMain_7.Image;
                    break;
                case 8:
                    pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBoxShowingMain_8.Image;
                    break;
                case 9:
                    pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBoxShowingMain_9.Image;
                    break;
                case 10:
                    pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBoxShowingMain_10.Image;
                    break;
                case 11:
                    pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBoxShowingMain_11.Image;
                    break;
                case 12:
                    pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBoxShowingMain_12.Image;
                    break;
                case 13:
                    pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBoxShowingMain_13.Image;
                    break;
                case 14:
                    pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBoxShowingMain_14.Image;
                    break;
                case 15:
                    pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBoxShowingMain_15.Image;
                    break;
                case 16:
                    pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBoxShowingMain_16.Image;
                    break;
                case 17:
                    pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBoxShowingMain_17.Image;
                    break;
                case 18:
                    pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBoxShowingMain_18.Image;
                    break;
                case 19:
                    pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBoxShowingMain_19.Image;
                    break;
                case 20:
                    pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBoxShowingMain_20.Image;
                    break;
                case 21:
                    pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBoxShowingMain_21.Image;
                    break;
                case 22:
                    pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBoxShowingMain_22.Image;
                    break;
                case 23:
                    pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBoxShowingMain_23.Image;
                    break;
                case 24:
                    pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBoxShowingMain_24.Image;
                    break;
                case 25:
                    pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBox_panelHome_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_showingHome_1.Image;
                    break;
                case 26:
                    pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBox_panelHome_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_showingHome_2.Image;
                    break;
                case 27:
                    pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBox_panelHome_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_showingHome_3.Image;
                    break;
                case 28:
                    pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBox_panelHome_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_showingHome_4.Image;
                    break;
                case 29:
                    pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBox_panelHome_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_showingHome_5.Image;
                    break;
                case 30:
                    pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBox_panelHome_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_showingHome_6.Image;
                    break;
                case 31:
                    pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBox_click_panelGallery_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_showingGallery_1.Image;
                    break;
                case 32:
                    pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBox_click_panelGallery_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_showingGallery_2.Image;
                    break;
                case 33:
                    pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBox_click_panelGallery_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_showingGallery_3.Image;
                    break;
                case 34:
                    pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBox_click_panelGallery_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_showingGallery_4.Image;
                    break;
                case 35:
                    pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBox_click_panelGallery_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_showingGallery_5.Image;
                    break;
                case 36:
                    pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBox_click_panelGallery_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_showingGallery_6.Image;
                    break;
                case 37:
                    pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBox_click_panelGallery_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_showingGallery_7.Image;
                    break;
                case 38:
                    pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBox_click_panelGallery_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_showingGallery_8.Image;
                    break;
                case 39:
                    pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBox_click_panelGallery_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_showingGallery_9.Image;
                    break;
                case 40:
                    pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image=pictureBox_panelSeeMore_flowLayoutPanelDetailPicture_form1_showingMore_1.Image;
                    break;
                case 41:
                    pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBox_panelSeeMore_flowLayoutPanelDetailPicture_form1_showingMore_2.Image;
                    break;
                case 42:
                    pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBox_panelSeeMore_flowLayoutPanelDetailPicture_form1_showingMore_3.Image;
                    break;
                case 43:
                    pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBox_panelSeeMore_flowLayoutPanelDetailPicture_form1_showingMore_4.Image;
                    break;
                case 44:
                    pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBox_panelSeeMore_flowLayoutPanelDetailPicture_form1_showingMore_5.Image;
                    break;
                case 45:
                    pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBox_panelSeeMore_flowLayoutPanelDetailPicture_form1_showingMore_6.Image;
                    break;
                case 46:
                    pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBox_panelSeeMore_flowLayoutPanelDetailPicture_form1_showingMore_7.Image;
                    break;
                case 47:
                    pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBox_panelSeeMore_flowLayoutPanelDetailPicture_form1_showingMore_8.Image;
                    break;
                case 48:
                    pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBox_panelSeeMore_flowLayoutPanelDetailPicture_form1_showingMore_9.Image;
                    break;
                case 49:
                    pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBox_panelSeeMore_flowLayoutPanelDetailPicture_form1_showingMore_10.Image;
                    break;
                case 50:
                    pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBox_panelSeeMore_flowLayoutPanelDetailPicture_form1_showingMore_11.Image;
                    break;
                case 51:
                    pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBox_panelSeeMore_flowLayoutPanelDetailPicture_form1_showingMore_12.Image;
                    break;
                case 52:
                    pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBox_panelSeeMore_flowLayoutPanelDetailPicture_form1_showingMore_13.Image;
                    break;
                case 53:
                    pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBox_panelSeeMore_flowLayoutPanelDetailPicture_form1_showingMore_14.Image;
                    break;
                case 54:
                    pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBox_panelSeeMore_flowLayoutPanelDetailPicture_form1_showingMore_15.Image;
                    break;
                case 55:
                    pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBox_panelSeeMore_flowLayoutPanelDetailPicture_form1_showingMore_16.Image;
                    break;
                case 56:
                    pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBox_panelSeeMore_flowLayoutPanelDetailPicture_form1_showingMore_17.Image;
                    break;
                case 57:
                    pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBox_panelSeeMore_flowLayoutPanelDetailPicture_form1_showingMore_18.Image;
                    break;
                case 64:
                    pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_1.Image;
                    break;
                case 65:
                    pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_2.Image;
                    break;
                case 66:
                    pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_3.Image;
                    break;
                case 67:
                    pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_4.Image;
                    break;
                case 68:
                    pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_5.Image;
                    break;
                case 69:
                    pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_6.Image;
                    break;
                case 70:
                    pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_7.Image;
                    break;
                case 71:
                    pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_8.Image;
                    break;
                case 72:
                    pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_9.Image;
                    break;
                case 73:
                    pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_10.Image;
                    break;
                case 74:
                    pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_11.Image;
                    break;
                case 75:
                    pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_12.Image;
                    break;
                case 76:
                    pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBox_click_panelShowPics_flowLayoutPanelDetailTopics_form1_showingTopics_1.Image;
                    break;
                case 77:
                    pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBox_click_panelShowPics_flowLayoutPanelDetailTopics_form1_showingTopics_2.Image;
                    break;
                case 78:
                    pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBox_click_panelShowPics_flowLayoutPanelDetailTopics_form1_showingTopics_3.Image;
                    break;
                case 79:
                    pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBox_click_panelShowPics_flowLayoutPanelDetailTopics_form1_showingTopics_4.Image;
                    break;
                case 80:
                    pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBox_click_panelShowPics_flowLayoutPanelDetailTopics_form1_showingTopics_5.Image;
                    break;
                case 81:
                    pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBox_click_panelShowPics_flowLayoutPanelDetailTopics_form1_showingTopics_6.Image;
                    break;
                case 82:
                    pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBox_click_panelShowPics_flowLayoutPanelDetailTopics_form1_showingTopics_7.Image;
                    break;
                case 83:
                    pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBox_click_panelShowPics_flowLayoutPanelDetailTopics_form1_showingTopics_8.Image;
                    break;
                case 84:
                    pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBox_click_panelShowPics_flowLayoutPanelDetailTopics_form1_showingTopics_9.Image;
                    break;
                case 85:
                    pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBox_click_panelShowPics_flowLayoutPanelDetailTopics_form1_showingTopics_10.Image;
                    break;
                case 86:
                    pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBox_click_panelShowPics_flowLayoutPanelDetailTopics_form1_showingTopics_11.Image;
                    break;
                case 87:
                    pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBox_click_panelShowPics_flowLayoutPanelDetailTopics_form1_showingTopics_12.Image;
                    break;




                default:
                    back = 1;
                    break;
            }
        }

        private void button_click_panelDetailPicture_flowLayoutPanelDetailPicture_form1_next_Click(object sender, EventArgs e)
        {
            int next;
            ++danhgiau_pictureBoxShowing;
            next = danhgiau_pictureBoxShowing;
            switch (next)
            {
                case 1:
                    pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBoxShowingMain_1.Image;
                    break;
                case 2:
                    pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBoxShowingMain_2.Image;
                    break;
                case 3:
                    pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBoxShowingMain_3.Image;
                    break;
                case 4:
                    pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBoxShowingMain_4.Image;
                    break;
                case 5:
                    pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBoxShowingMain_5.Image;
                    break;
                case 6:
                    pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBoxShowingMain_6.Image;
                    break;
                case 7:
                    pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBoxShowingMain_7.Image;
                    break;
                case 8:
                    pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBoxShowingMain_8.Image;
                    break;
                case 9:
                    pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBoxShowingMain_9.Image;
                    break;
                case 10:
                    pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBoxShowingMain_10.Image;
                    break;
                case 11:
                    pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBoxShowingMain_11.Image;
                    break;
                case 12:
                    pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBoxShowingMain_12.Image;
                    break;
                case 13:
                    pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBoxShowingMain_13.Image;
                    break;
                case 14:
                    pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBoxShowingMain_14.Image;
                    break;
                case 15:
                    pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBoxShowingMain_15.Image;
                    break;
                case 16:
                    pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBoxShowingMain_16.Image;
                    break;
                case 17:
                    pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBoxShowingMain_17.Image;
                    break;
                case 18:
                    pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBoxShowingMain_18.Image;
                    break;
                case 19:
                    pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBoxShowingMain_19.Image;
                    break;
                case 20:
                    pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBoxShowingMain_20.Image;
                    break;
                case 21:
                    pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBoxShowingMain_21.Image;
                    break;
                case 22:
                    pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBoxShowingMain_22.Image;
                    break;
                case 23:
                    pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBoxShowingMain_23.Image;
                    break;
                case 24:
                    pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBoxShowingMain_24.Image;
                    break;
                case 25:
                    pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBox_panelHome_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_showingHome_1.Image;
                    break;
                case 26:
                    pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBox_panelHome_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_showingHome_2.Image;
                    break;
                case 27:
                    pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBox_panelHome_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_showingHome_3.Image;
                    break;
                case 28:
                    pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBox_panelHome_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_showingHome_4.Image;
                    break;
                case 29:
                    pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBox_panelHome_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_showingHome_5.Image;
                    break;
                case 30:
                    pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBox_panelHome_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_showingHome_6.Image;
                    break;
                case 31:
                    pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBox_click_panelGallery_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_showingGallery_1.Image;
                    break;
                case 32:
                    pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBox_click_panelGallery_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_showingGallery_2.Image;
                    break;
                case 33:
                    pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBox_click_panelGallery_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_showingGallery_3.Image;
                    break;
                case 34:
                    pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBox_click_panelGallery_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_showingGallery_4.Image;
                    break;
                case 35:
                    pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBox_click_panelGallery_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_showingGallery_5.Image;
                    break;
                case 36:
                    pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBox_click_panelGallery_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_showingGallery_6.Image;
                    break;
                case 37:
                    pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBox_click_panelGallery_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_showingGallery_7.Image;
                    break;
                case 38:
                    pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBox_click_panelGallery_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_showingGallery_8.Image;
                    break;
                case 39:
                    pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBox_click_panelGallery_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_showingGallery_9.Image;
                    break;
                case 40:
                    pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBox_panelSeeMore_flowLayoutPanelDetailPicture_form1_showingMore_1.Image;
                    break;
                case 41:
                    pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBox_panelSeeMore_flowLayoutPanelDetailPicture_form1_showingMore_2.Image;
                    break;
                case 42:
                    pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBox_panelSeeMore_flowLayoutPanelDetailPicture_form1_showingMore_3.Image;
                    break;
                case 43:
                    pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBox_panelSeeMore_flowLayoutPanelDetailPicture_form1_showingMore_4.Image;
                    break;
                case 44:
                    pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBox_panelSeeMore_flowLayoutPanelDetailPicture_form1_showingMore_5.Image;
                    break;
                case 45:
                    pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBox_panelSeeMore_flowLayoutPanelDetailPicture_form1_showingMore_6.Image;
                    break;
                case 46:
                    pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBox_panelSeeMore_flowLayoutPanelDetailPicture_form1_showingMore_7.Image;
                    break;
                case 47:
                    pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBox_panelSeeMore_flowLayoutPanelDetailPicture_form1_showingMore_8.Image;
                    break;
                case 48:
                    pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBox_panelSeeMore_flowLayoutPanelDetailPicture_form1_showingMore_9.Image;
                    break;
                case 49:
                    pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBox_panelSeeMore_flowLayoutPanelDetailPicture_form1_showingMore_10.Image;
                    break;
                case 50:
                    pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBox_panelSeeMore_flowLayoutPanelDetailPicture_form1_showingMore_11.Image;
                    break;
                case 51:
                    pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBox_panelSeeMore_flowLayoutPanelDetailPicture_form1_showingMore_12.Image;
                    break;
                case 52:
                    pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBox_panelSeeMore_flowLayoutPanelDetailPicture_form1_showingMore_13.Image;
                    break;
                case 53:
                    pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBox_panelSeeMore_flowLayoutPanelDetailPicture_form1_showingMore_14.Image;
                    break;
                case 54:
                    pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBox_panelSeeMore_flowLayoutPanelDetailPicture_form1_showingMore_15.Image;
                    break;
                case 55:
                    pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBox_panelSeeMore_flowLayoutPanelDetailPicture_form1_showingMore_16.Image;
                    break;
                case 56:
                    pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBox_panelSeeMore_flowLayoutPanelDetailPicture_form1_showingMore_17.Image;
                    break;
                case 57:
                    pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBox_panelSeeMore_flowLayoutPanelDetailPicture_form1_showingMore_18.Image;
                    break;
                case 64:
                    pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_1.Image;
                    break;
                case 65:
                    pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_2.Image;
                    break;
                case 66:
                    pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_3.Image;
                    break;
                case 67:
                    pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_4.Image;
                    break;
                case 68:
                    pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_5.Image;
                    break;
                case 69:
                    pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_6.Image;
                    break;
                case 70:
                    pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_7.Image;
                    break;
                case 71:
                    pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_8.Image;
                    break;
                case 72:
                    pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_9.Image;
                    break;
                case 73:
                    pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_10.Image;
                    break;
                case 74:
                    pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_11.Image;
                    break;
                case 75:
                    pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_12.Image;
                    break;
                case 76:
                    pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBox_click_panelShowPics_flowLayoutPanelDetailTopics_form1_showingTopics_1.Image;
                    break;
                case 77:
                    pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBox_click_panelShowPics_flowLayoutPanelDetailTopics_form1_showingTopics_2.Image;
                    break;
                case 78:
                    pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBox_click_panelShowPics_flowLayoutPanelDetailTopics_form1_showingTopics_3.Image;
                    break;
                case 79:
                    pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBox_click_panelShowPics_flowLayoutPanelDetailTopics_form1_showingTopics_4.Image;
                    break;
                case 80:
                    pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBox_click_panelShowPics_flowLayoutPanelDetailTopics_form1_showingTopics_5.Image;
                    break;
                case 81:
                    pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBox_click_panelShowPics_flowLayoutPanelDetailTopics_form1_showingTopics_6.Image;
                    break;
                case 82:
                    pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBox_click_panelShowPics_flowLayoutPanelDetailTopics_form1_showingTopics_7.Image;
                    break;
                case 83:
                    pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBox_click_panelShowPics_flowLayoutPanelDetailTopics_form1_showingTopics_8.Image;
                    break;
                case 84:
                    pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBox_click_panelShowPics_flowLayoutPanelDetailTopics_form1_showingTopics_9.Image;
                    break;
                case 85:
                    pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBox_click_panelShowPics_flowLayoutPanelDetailTopics_form1_showingTopics_10.Image;
                    break;
                case 86:
                    pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBox_click_panelShowPics_flowLayoutPanelDetailTopics_form1_showingTopics_11.Image;
                    break;
                case 87:
                    pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBox_click_panelShowPics_flowLayoutPanelDetailTopics_form1_showingTopics_12.Image;
                    break;

                default:
                    next = 1;
                    break;
            }
        }

        private void pictureBox_click_panelDashBoard_form1_home_Click(object sender, EventArgs e)
        {

            flowLayoutPanelMain_form1.Visible = true;
            flowLayoutPanelDailyAndTrending_form1.Visible = false;
            flowLayoutPanelTopics_form1.Visible = false;

        }

        private void button_click_panelFunction_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_Gallery_Click(object sender, EventArgs e)
        {
            panelGallery_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1.Visible = true;
            panelHome_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1.Visible = false;
            if(label_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_showingAuthorName.Text== "TheMandarialThangFAT")
            {
                label_panelGallery_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_firstCategorized.Text = "Flower";
                label_panelGallery_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_secondCategorized.Text = "Oceans";
                label_panelGallery_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_thirdCategorized.Text = "Flower";
                pictureBox_click_panelGallery_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_firstCategorized.Image = Image.FromFile(Convert.ToString(dtFlower.Rows[1]["Path"]));
                pictureBox_click_panelGallery_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_secondCategorized.Image = Image.FromFile(Convert.ToString(dtOceans.Rows[2]["Path"]));
                pictureBox_click_panelGallery_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_showingGallery_1.Image = Image.FromFile(Convert.ToString(dtFlower.Rows[2]["Path"]));
                pictureBox_click_panelGallery_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_showingGallery_2.Image = Image.FromFile(Convert.ToString(dtFlower.Rows[3]["Path"]));
                pictureBox_click_panelGallery_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_showingGallery_3.Image = Image.FromFile(Convert.ToString(dtFlower.Rows[4]["Path"]));
                pictureBox_click_panelGallery_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_showingGallery_4.Image = Image.FromFile(Convert.ToString(dtFlower.Rows[5]["Path"]));
                pictureBox_click_panelGallery_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_showingGallery_5.Image = Image.FromFile(Convert.ToString(dtFlower.Rows[6]["Path"]));
                pictureBox_click_panelGallery_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_showingGallery_6.Image = Image.FromFile(Convert.ToString(dtFlower.Rows[7]["Path"]));
                pictureBox_click_panelGallery_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_showingGallery_7.Image = Image.FromFile(Convert.ToString(dtFlower.Rows[8]["Path"]));
                pictureBox_click_panelGallery_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_showingGallery_8.Image = Image.FromFile(Convert.ToString(dtFlower.Rows[9]["Path"]));
                pictureBox_click_panelGallery_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_showingGallery_9.Image = Image.FromFile(Convert.ToString(dtFlower.Rows[10]["Path"]));

            }
            else if(label_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_showingAuthorName.Text == "NarukamiTriTaiBAR")
            {
                label_panelGallery_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_firstCategorized.Text = "Car";
                label_panelGallery_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_secondCategorized.Text = "MotoBike";
                label_panelGallery_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_thirdCategorized.Text = "Car";
                pictureBox_click_panelGallery_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_firstCategorized.Image = Image.FromFile(Convert.ToString(dtCar.Rows[1]["Path"]));
                pictureBox_click_panelGallery_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_secondCategorized.Image = Image.FromFile(Convert.ToString(dtMotoBike.Rows[2]["Path"]));
                pictureBox_click_panelGallery_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_showingGallery_1.Image = Image.FromFile(Convert.ToString(dtCar.Rows[2]["Path"]));
                pictureBox_click_panelGallery_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_showingGallery_2.Image = Image.FromFile(Convert.ToString(dtCar.Rows[3]["Path"]));
                pictureBox_click_panelGallery_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_showingGallery_3.Image = Image.FromFile(Convert.ToString(dtCar.Rows[4]["Path"]));
                pictureBox_click_panelGallery_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_showingGallery_4.Image = Image.FromFile(Convert.ToString(dtCar.Rows[5]["Path"]));
                pictureBox_click_panelGallery_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_showingGallery_5.Image = Image.FromFile(Convert.ToString(dtCar.Rows[6]["Path"]));
                pictureBox_click_panelGallery_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_showingGallery_6.Image = Image.FromFile(Convert.ToString(dtCar.Rows[7]["Path"]));
                pictureBox_click_panelGallery_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_showingGallery_7.Image = Image.FromFile(Convert.ToString(dtCar.Rows[8]["Path"]));
                pictureBox_click_panelGallery_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_showingGallery_8.Image = Image.FromFile(Convert.ToString(dtCar.Rows[9]["Path"]));
                pictureBox_click_panelGallery_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_showingGallery_9.Image = Image.FromFile(Convert.ToString(dtCar.Rows[10]["Path"]));
            }
        }

        private void panelGallery_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void linkLabel_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_share_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.deviantart.com/clockbirds");
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBox_click_panelShowPics_flowLayoutPanelDetailTopics_form1_showingTopics_8.Image;
            flowLayoutPanelDetailPicture_form1.Visible = true;
            flowLayoutPanelDetailTopics_form1.Visible = false;
            danhgiau_pictureBoxShowing = 83;
        }
        private static bool IsDup(int tmp, int[] arr)
        {
            foreach (var item in arr)
            {
                if (tmp == item)
                {
                    return true;
                }

            }
            return false;
        }
        private static void LetNotDup(int min, int max, int[] ar)
        {

            Random dr = new Random();
            int tmp;
            for (int i = 0; i < ar.Length; i++)
            {
                tmp = dr.Next(min, max);
                while (IsDup(tmp, ar))
                {
                    tmp = dr.Next(min, max);
                }
                ar[i] = tmp;
            }

        }
        private void load_random_image(DataTable dt,int numOfImages,int x1,int x2,int x3,int x4,int x5,int x6,int x7,int x8,int x9,int x10,int x11,int x12)
        {
            for (int randomPictureToPutInPictureBoxInPanelShowPicsOfflowLayoutPanelDetailTopics = 1; randomPictureToPutInPictureBoxInPanelShowPicsOfflowLayoutPanelDetailTopics <= numOfImages; randomPictureToPutInPictureBoxInPanelShowPicsOfflowLayoutPanelDetailTopics++)
            {
                if (randomPictureToPutInPictureBoxInPanelShowPicsOfflowLayoutPanelDetailTopics == x1)
                {
                    pictureBox_click_panelShowPics_flowLayoutPanelDetailTopics_form1_showingTopics_1.Image = Image.FromFile(Convert.ToString(dt.Rows[x1 - 1]["Path"]));
                    Dictionary<string, string> lstImageInfoScreenMain = new Dictionary<string, string>();
                    lstImageInfoScreenMain.Add("Categorized", dt.Rows[x1 - 1]["Categorized"].ToString());
                    lstImageInfoScreenMain.Add("Path", dt.Rows[x1 - 1]["Path"].ToString());
                    lstImageInfoScreenMain.Add("Favourites", dt.Rows[x1 - 1]["Favorites"].ToString());
                    lstImageInfoScreenMain.Add("Comments", dt.Rows[x1 - 1]["Comments"].ToString());
                    lstImageInfoScreenMain.Add("Views", dt.Rows[x1 - 1]["Views"].ToString());
                    lstImageInfoScreenMain.Add("Price", dt.Rows[x1 - 1]["Price"].ToString());

                }
                else if (randomPictureToPutInPictureBoxInPanelShowPicsOfflowLayoutPanelDetailTopics == x2)
                {
                    pictureBox_click_panelShowPics_flowLayoutPanelDetailTopics_form1_showingTopics_2.Image = Image.FromFile(Convert.ToString(dt.Rows[x2 - 1]["Path"]));


                }
                else if (randomPictureToPutInPictureBoxInPanelShowPicsOfflowLayoutPanelDetailTopics == x3)
                {
                    pictureBox_click_panelShowPics_flowLayoutPanelDetailTopics_form1_showingTopics_3.Image = Image.FromFile(Convert.ToString(dt.Rows[x3 - 1]["Path"]));


                }
                else if (randomPictureToPutInPictureBoxInPanelShowPicsOfflowLayoutPanelDetailTopics == x4)
                {
                    pictureBox_click_panelShowPics_flowLayoutPanelDetailTopics_form1_showingTopics_4.Image = Image.FromFile(Convert.ToString(dt.Rows[x4 - 1]["Path"]));

                }
                else if (randomPictureToPutInPictureBoxInPanelShowPicsOfflowLayoutPanelDetailTopics == x5)
                {
                    pictureBox_click_panelShowPics_flowLayoutPanelDetailTopics_form1_showingTopics_5.Image = Image.FromFile(Convert.ToString(dt.Rows[x5 - 1]["Path"]));



                }
                else if (randomPictureToPutInPictureBoxInPanelShowPicsOfflowLayoutPanelDetailTopics == x6)
                {
                    pictureBox_click_panelShowPics_flowLayoutPanelDetailTopics_form1_showingTopics_6.Image = Image.FromFile(Convert.ToString(dt.Rows[x6 - 1]["Path"]));

   
                }
                else if (randomPictureToPutInPictureBoxInPanelShowPicsOfflowLayoutPanelDetailTopics == x7)
                {
                    pictureBox_click_panelShowPics_flowLayoutPanelDetailTopics_form1_showingTopics_7.Image = Image.FromFile(Convert.ToString(dt.Rows[x7 - 1]["Path"]));

  
                }
                else if (randomPictureToPutInPictureBoxInPanelShowPicsOfflowLayoutPanelDetailTopics == x8)
                {
                    pictureBox_click_panelShowPics_flowLayoutPanelDetailTopics_form1_showingTopics_8.Image = Image.FromFile(Convert.ToString(dt.Rows[x8 - 1]["Path"]));

     
                }
                else if (randomPictureToPutInPictureBoxInPanelShowPicsOfflowLayoutPanelDetailTopics == x9)
                {
                    pictureBox_click_panelShowPics_flowLayoutPanelDetailTopics_form1_showingTopics_9.Image = Image.FromFile(Convert.ToString(dt.Rows[x9 - 1]["Path"]));

     
                }
                else if (randomPictureToPutInPictureBoxInPanelShowPicsOfflowLayoutPanelDetailTopics == x10)
                {
                    pictureBox_click_panelShowPics_flowLayoutPanelDetailTopics_form1_showingTopics_10.Image = Image.FromFile(Convert.ToString(dt.Rows[x10 - 1]["Path"]));


                }
                else if (randomPictureToPutInPictureBoxInPanelShowPicsOfflowLayoutPanelDetailTopics ==x11)
                {
                    pictureBox_click_panelShowPics_flowLayoutPanelDetailTopics_form1_showingTopics_11.Image = Image.FromFile(Convert.ToString(dt.Rows[x11 - 1]["Path"]));

              
                }
                else if (randomPictureToPutInPictureBoxInPanelShowPicsOfflowLayoutPanelDetailTopics == x12)
                {
                    pictureBox_click_panelShowPics_flowLayoutPanelDetailTopics_form1_showingTopics_12.Image = Image.FromFile(Convert.ToString(dt.Rows[x12 - 1]["Path"]));
 
               
                }
            }
        }
        private void pictureBox_click_panelExploreTopics_flowLayoutPanelMain_form1_categorizedInterior_Click(object sender, EventArgs e)
        {
            flowLayoutPanelDetailTopics_form1.Visible = true;
            pictureBox_panelBackGround_flowLayoutPanelDetailTopics_form1_showingBackGroundTopics.Image = Image.FromFile(@"../../UsedForInterface/Interiorbackground.jpg");
            label_panelBackGround_flowLayoutPanelDetailTopics_form1_nameTopics.Text = "INTERIOR";
            label_panelBackGround_flowLayoutPanelDetailTopics_form1_describetopics.Text = "Discovery the most modern interior in 2021,eyes catching interior";
            int[] arr=new int[12];
            LetNotDup(1, 230, arr);
            load_random_image(dtInterior, 229, arr[0], arr[1], arr[2], arr[3], arr[4], arr[5], arr[6], arr[7], arr[8], arr[9], arr[10], arr[11]);  
        }
        private void pictureBox_click_panelExploreTopics_flowLayoutPanelMain_form1_categorizedCar_Click(object sender, EventArgs e)
        {
            flowLayoutPanelDetailTopics_form1.Visible = true;
            pictureBox_panelBackGround_flowLayoutPanelDetailTopics_form1_showingBackGroundTopics.Image = Image.FromFile(@"../../UsedForInterface/CarBackGround.png");
            label_panelBackGround_flowLayoutPanelDetailTopics_form1_nameTopics.Text = "CAR";
            label_panelBackGround_flowLayoutPanelDetailTopics_form1_describetopics.Text = "Explore the best car that ever exist,with the most modern design and technology";
            int[] arr1 = new int[12];
            LetNotDup(1, 158, arr1);
            load_random_image(dtCar, 157, arr1[0], arr1[1], arr1[2], arr1[3], arr1[4], arr1[5], arr1[6], arr1[7], arr1[8], arr1[9], arr1[10], arr1[11]);
        }
        private void pictureBox_click_panelExploreTopics_flowLayoutPanelMain_form1_categorizedMotoBike_Click(object sender, EventArgs e)
        {
            flowLayoutPanelDetailTopics_form1.Visible = true;
            pictureBox_panelBackGround_flowLayoutPanelDetailTopics_form1_showingBackGroundTopics.Image = Image.FromFile(@"../../UsedForInterface/MotoBikebackGround.png");
            label_panelBackGround_flowLayoutPanelDetailTopics_form1_nameTopics.Text = "MOTOBIKE";
            label_panelBackGround_flowLayoutPanelDetailTopics_form1_describetopics.Text = "Here is the most significant image for motobike";
            int[] arr2 = new int[12];
            LetNotDup(1, 243, arr2);
            load_random_image(dtMotoBike, 242, arr2[0], arr2[1], arr2[2], arr2[3], arr2[4], arr2[5], arr2[6], arr2[7], arr2[8], arr2[9], arr2[10], arr2[11]);
        }
        private void pictureBox_click_panelExploreTopics_flowLayoutPanelMain_form1_categorizedForest_Click(object sender, EventArgs e)
        {
            flowLayoutPanelDetailTopics_form1.Visible = true;
            pictureBox_panelBackGround_flowLayoutPanelDetailTopics_form1_showingBackGroundTopics.Image = Image.FromFile(@"../../UsedForInterface/ForestBackGround.png");
            label_panelBackGround_flowLayoutPanelDetailTopics_form1_nameTopics.Text = "FOREST";
            label_panelBackGround_flowLayoutPanelDetailTopics_form1_describetopics.Text = "Explore the most beautiful forest in the world";
            int[] arr3 = new int[12];
            LetNotDup(1, 206, arr3);
            load_random_image(dtForest, 205, arr3[0], arr3[1], arr3[2], arr3[3], arr3[4], arr3[5], arr3[6], arr3[7], arr3[8], arr3[9], arr3[10], arr3[11]);
        }
        private void pictureBox_click_panelExploreTopics_flowLayoutPanelMain_form1_categorizedOceans_Click(object sender, EventArgs e)
        {
            flowLayoutPanelDetailTopics_form1.Visible = true;
            pictureBox_panelBackGround_flowLayoutPanelDetailTopics_form1_showingBackGroundTopics.Image = Image.FromFile(@"../../UsedForInterface/OceansBackground.png");
            label_panelBackGround_flowLayoutPanelDetailTopics_form1_nameTopics.Text = "OCEANS";
            label_panelBackGround_flowLayoutPanelDetailTopics_form1_describetopics.Text = "A real-world example of a zero-entry swimming pool. Swim in the peaceful waves, lunch under a thatch-roof cabana under the palms";
            int[] arr4 = new int[12];
            LetNotDup(1, 187, arr4);
            load_random_image(dtOceans, 186, arr4[0], arr4[1], arr4[2], arr4[3], arr4[4], arr4[5], arr4[6], arr4[7], arr4[8], arr4[9], arr4[10], arr4[11]);
        }
        private void pictureBox_click_panelExploreTopics_flowLayoutPanelMain_form1_categorizedFlower_Click(object sender, EventArgs e)
        {
            flowLayoutPanelDetailTopics_form1.Visible = true;
            pictureBox_panelBackGround_flowLayoutPanelDetailTopics_form1_showingBackGroundTopics.Image = Image.FromFile(@"../../UsedForInterface/FlowerBackGround.png");
            label_panelBackGround_flowLayoutPanelDetailTopics_form1_nameTopics.Text = "FLOWER";
            label_panelBackGround_flowLayoutPanelDetailTopics_form1_describetopics.Text = "Beautiful and special flower on the planet";
            int[] arr5 = new int[12];
            LetNotDup(1, 160, arr5);
            load_random_image(dtFlower, 159, arr5[0], arr5[1], arr5[2], arr5[3], arr5[4], arr5[5], arr5[6], arr5[7], arr5[8], arr5[9], arr5[10], arr5[11]);
        }

        private void button_click_panelDetailPicture_flowLayoutPanelDetailPicture_form1_authorThang_1_Click(object sender, EventArgs e)
        {
            flowLayoutPanelShowingAuthorDetail_form1.Visible = true;
            panelHome_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1.Visible = true;
            flowLayoutPanelDailyAndTrending_form1.Visible = false;
            flowLayoutPanelDetailTopics_form1.Visible = false;
            flowLayoutPanelMain_form1.Visible = false;
            flowLayoutPanelDetailPicture_form1.Visible = false;
            panelGallery_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1.Visible = false;
            label_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_showingAuthorName.Text = "TheMandarialThangFAT";
            pictureBox_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_showingAuthorBackground.Image = Image.FromFile(@"../../UsedForInterface/icon/dragon.jpg");
            pictureBox_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_showingAuthorAvatar.Image=Image.FromFile(@"../../UsedForInterface/icon/bird.png");
            label_panelProfilesAuthor_panelHome_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_introdution.Text = "Artist  //  Hobbyist   //   DigitalArt  //   Professional  ";
            label_panelProfilesAuthor_panelHome_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_birthday.Text = "Feb,25";
            label_panelProfilesAuthor_panelHome_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_location.Text = "Ho Chi Minh City.";
            label_panelHome_panelShowingAuthorDetail_form1_aboutThisAuthor.Text = "TheMandarialThangFAT";
            label_panelProfilesAuthor_panelHome_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_joinseen.Text = "Join seen 2005";
            Random randomCategorizedToPutPictureInPanelHomeOfAuthorDetail = new Random();
            int randomCar = randomCategorizedToPutPictureInPanelHomeOfAuthorDetail.Next(1, 158);
            int randomInterior= randomCategorizedToPutPictureInPanelHomeOfAuthorDetail.Next(1, 230);
            int randomOceans= randomCategorizedToPutPictureInPanelHomeOfAuthorDetail.Next(1, 187);
            int randomFlower= randomCategorizedToPutPictureInPanelHomeOfAuthorDetail.Next(1, 160);
            int randomMotoBike= randomCategorizedToPutPictureInPanelHomeOfAuthorDetail.Next(1, 243);
            int randomForest = randomCategorizedToPutPictureInPanelHomeOfAuthorDetail.Next(1, 206);
            for(int i=1;i<=157;i++)
            {
                if(randomCar==i)
                {
                    pictureBox_panelHome_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_showingHome_1.Image = Image.FromFile(Convert.ToString(dtCar.Rows[randomCar - 1]["Path"]));

                    lstImageInfoScreenMain.Add("Categorized_authorThang_1", dtCar.Rows[randomCar - 1]["Categorized"].ToString());
                    lstImageInfoScreenMain.Add("Path_authorThang_1", dtCar.Rows[randomCar - 1]["Path"].ToString());
                    lstImageInfoScreenMain.Add("Favourites_authorThang_1", dtCar.Rows[randomCar - 1]["Favorites"].ToString());
                    lstImageInfoScreenMain.Add("Comments_authorThang_1", dtCar.Rows[randomCar - 1]["Comments"].ToString());
                    lstImageInfoScreenMain.Add("Views_authorThang_1", dtCar.Rows[randomCar - 1]["Views"].ToString());
                    lstImageInfoScreenMain.Add("Price_authorThang_1", dtCar.Rows[randomCar - 1]["Price"].ToString());
          
                }

            }
            for(int j=1;j<=229;j++)
            {
                if (randomInterior == j)
                {
                    pictureBox_panelHome_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_showingHome_2.Image = Image.FromFile(Convert.ToString(dtInterior.Rows[randomInterior - 1]["Path"]));
                    
                    lstImageInfoScreenMain.Add("Categorized_authorThang_2", dtInterior.Rows[randomInterior - 1]["Categorized"].ToString());
                    lstImageInfoScreenMain.Add("Path_authorThang_2", dtInterior.Rows[randomInterior - 1]["Path"].ToString());
                    lstImageInfoScreenMain.Add("Favourites_authorThang_2", dtInterior.Rows[randomInterior - 1]["Favorites"].ToString());
                    lstImageInfoScreenMain.Add("Comments_authorThang_2", dtInterior.Rows[randomInterior - 1]["Comments"].ToString());
                    lstImageInfoScreenMain.Add("Views_authorThang_2", dtInterior.Rows[randomInterior - 1]["Views"].ToString());
                    lstImageInfoScreenMain.Add("Price_authorThang_2", dtInterior.Rows[randomInterior - 1]["Price"].ToString());
    
                }
            }
            for(int k=1;k<=186;k++)
            {
                if (randomOceans == k)
                {
                    pictureBox_panelHome_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_showingHome_3.Image = Image.FromFile(Convert.ToString(dtOceans.Rows[randomOceans - 1]["Path"]));
                 
                    lstImageInfoScreenMain.Add("Categorized_authorThang_3", dtOceans.Rows[randomOceans - 1]["Categorized"].ToString());
                    lstImageInfoScreenMain.Add("Path_authorThang_3", dtOceans.Rows[randomOceans - 1]["Path"].ToString());
                    lstImageInfoScreenMain.Add("Favourites_authorThang_3", dtOceans.Rows[randomOceans - 1]["Favorites"].ToString());
                    lstImageInfoScreenMain.Add("Comments_authorThang_3", dtOceans.Rows[randomOceans - 1]["Comments"].ToString());
                    lstImageInfoScreenMain.Add("Views_authorThang_3", dtOceans.Rows[randomOceans - 1]["Views"].ToString());
                    lstImageInfoScreenMain.Add("Price_authorThang_3", dtOceans.Rows[randomOceans - 1]["Price"].ToString());

                }
            }
            for (int p = 1; p <= 159;p++)
            {
                if (randomFlower == p)
                {
                    pictureBox_panelHome_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_showingHome_4.Image = Image.FromFile(Convert.ToString(dtFlower.Rows[randomFlower - 1]["Path"]));
            
                    lstImageInfoScreenMain.Add("Categorized_authorThang_4", dtFlower.Rows[randomFlower - 1]["Categorized"].ToString());
                    lstImageInfoScreenMain.Add("Path_authorThang_4", dtFlower.Rows[randomFlower - 1]["Path"].ToString());
                    lstImageInfoScreenMain.Add("Favourites_authorThang_4", dtFlower.Rows[randomFlower - 1]["Favorites"].ToString());
                    lstImageInfoScreenMain.Add("Comments_authorThang_4", dtFlower.Rows[randomFlower - 1]["Comments"].ToString());
                    lstImageInfoScreenMain.Add("Views_authorThang_4", dtFlower.Rows[randomFlower - 1]["Views"].ToString());
                    lstImageInfoScreenMain.Add("Price_authorThang_4", dtFlower.Rows[randomFlower - 1]["Price"].ToString());
             
                }
            }
            for (int o=1;o<=242;o++)
            {
                if (randomMotoBike == o)
                {
                    pictureBox_panelHome_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_showingHome_5.Image = Image.FromFile(Convert.ToString(dtMotoBike.Rows[randomMotoBike - 1]["Path"]));
         
                    lstImageInfoScreenMain.Add("Categorized_authorThang_5", dtMotoBike.Rows[randomMotoBike - 1]["Categorized"].ToString());
                    lstImageInfoScreenMain.Add("Path_authorThang_5", dtMotoBike.Rows[randomMotoBike - 1]["Path"].ToString());
                    lstImageInfoScreenMain.Add("Favourites_authorThang_5", dtMotoBike.Rows[randomMotoBike - 1]["Favorites"].ToString());
                    lstImageInfoScreenMain.Add("Comments_authorThang_5", dtMotoBike.Rows[randomMotoBike - 1]["Comments"].ToString());
                    lstImageInfoScreenMain.Add("Views_authorThang_5", dtMotoBike.Rows[randomMotoBike - 1]["Views"].ToString());
                    lstImageInfoScreenMain.Add("Price_authorThang_5", dtMotoBike.Rows[randomMotoBike - 1]["Price"].ToString());
            
                }
            }
            for(int u=1;u<=205;u++)
            {
                if (randomForest == u)
                {
                    pictureBox_panelHome_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_showingHome_6.Image = Image.FromFile(Convert.ToString(dtForest.Rows[randomForest - 1]["Path"]));
 
                    lstImageInfoScreenMain.Add("Categorized_authorThang_6", dtForest.Rows[randomForest - 1]["Categorized"].ToString());
                    lstImageInfoScreenMain.Add("Path_authorThang_6", dtForest.Rows[randomForest - 1]["Path"].ToString());
                    lstImageInfoScreenMain.Add("Favourites_authorThang_6", dtForest.Rows[randomForest - 1]["Favorites"].ToString());
                    lstImageInfoScreenMain.Add("Comments_authorThang_6", dtForest.Rows[randomForest - 1]["Comments"].ToString());
                    lstImageInfoScreenMain.Add("Views_authorThang_6", dtForest.Rows[randomForest - 1]["Views"].ToString());
                    lstImageInfoScreenMain.Add("Price_authorThang_6", dtForest.Rows[randomForest - 1]["Price"].ToString());
              
                }
            }

        }
        private void button_click_panelFunction_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_Home_Click(object sender, EventArgs e)
        {
            panelHome_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1.Visible = true;
            panelGallery_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1.Visible = false;
        }

        private void linkLabel_panelProfilesAuthor_panelHome_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_twit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://twitter.com/clockbirdsART");
        }

        private void pictureBox_click_panelGallery_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_firstCategorized_Click(object sender, EventArgs e)
        {
            if(label_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_showingAuthorName.Text== "TheMandarialThangFAT")
            {
                label_panelGallery_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_thirdCategorized.Text = "Flower";
                pictureBox_click_panelGallery_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_showingGallery_1.Image = Image.FromFile(Convert.ToString(dtFlower.Rows[2]["Path"]));
                pictureBox_click_panelGallery_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_showingGallery_2.Image = Image.FromFile(Convert.ToString(dtFlower.Rows[3]["Path"]));
                pictureBox_click_panelGallery_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_showingGallery_3.Image = Image.FromFile(Convert.ToString(dtFlower.Rows[4]["Path"]));
                pictureBox_click_panelGallery_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_showingGallery_4.Image = Image.FromFile(Convert.ToString(dtFlower.Rows[5]["Path"]));
                pictureBox_click_panelGallery_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_showingGallery_5.Image = Image.FromFile(Convert.ToString(dtFlower.Rows[6]["Path"]));
                pictureBox_click_panelGallery_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_showingGallery_6.Image = Image.FromFile(Convert.ToString(dtFlower.Rows[7]["Path"]));
                pictureBox_click_panelGallery_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_showingGallery_7.Image = Image.FromFile(Convert.ToString(dtFlower.Rows[8]["Path"]));
                pictureBox_click_panelGallery_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_showingGallery_8.Image = Image.FromFile(Convert.ToString(dtFlower.Rows[9]["Path"]));
                pictureBox_click_panelGallery_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_showingGallery_9.Image = Image.FromFile(Convert.ToString(dtFlower.Rows[10]["Path"]));
            }
            else if (label_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_showingAuthorName.Text == "NarukamiTriTaiBAR")
            {
                label_panelGallery_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_thirdCategorized.Text = "Car";
                pictureBox_click_panelGallery_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_showingGallery_1.Image = Image.FromFile(Convert.ToString(dtCar.Rows[2]["Path"]));
                pictureBox_click_panelGallery_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_showingGallery_2.Image = Image.FromFile(Convert.ToString(dtCar.Rows[3]["Path"]));
                pictureBox_click_panelGallery_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_showingGallery_3.Image = Image.FromFile(Convert.ToString(dtCar.Rows[4]["Path"]));
                pictureBox_click_panelGallery_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_showingGallery_4.Image = Image.FromFile(Convert.ToString(dtCar.Rows[5]["Path"]));
                pictureBox_click_panelGallery_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_showingGallery_5.Image = Image.FromFile(Convert.ToString(dtCar.Rows[6]["Path"]));
                pictureBox_click_panelGallery_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_showingGallery_6.Image = Image.FromFile(Convert.ToString(dtCar.Rows[7]["Path"]));
                pictureBox_click_panelGallery_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_showingGallery_7.Image = Image.FromFile(Convert.ToString(dtCar.Rows[8]["Path"]));
                pictureBox_click_panelGallery_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_showingGallery_8.Image = Image.FromFile(Convert.ToString(dtCar.Rows[9]["Path"]));
                pictureBox_click_panelGallery_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_showingGallery_9.Image = Image.FromFile(Convert.ToString(dtCar.Rows[10]["Path"]));
            }
        }

        private void pictureBox_click_panelGallery_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_secondCategorized_Click(object sender, EventArgs e)
        {
            if (label_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_showingAuthorName.Text == "TheMandarialThangFAT")
            {
                label_panelGallery_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_thirdCategorized.Text = "OCeans";
                pictureBox_click_panelGallery_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_showingGallery_1.Image = Image.FromFile(Convert.ToString(dtOceans.Rows[2]["Path"]));
                pictureBox_click_panelGallery_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_showingGallery_2.Image = Image.FromFile(Convert.ToString(dtOceans.Rows[3]["Path"]));
                pictureBox_click_panelGallery_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_showingGallery_3.Image = Image.FromFile(Convert.ToString(dtOceans.Rows[4]["Path"]));
                pictureBox_click_panelGallery_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_showingGallery_4.Image = Image.FromFile(Convert.ToString(dtOceans.Rows[5]["Path"]));
                pictureBox_click_panelGallery_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_showingGallery_5.Image = Image.FromFile(Convert.ToString(dtOceans.Rows[6]["Path"]));
                pictureBox_click_panelGallery_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_showingGallery_6.Image = Image.FromFile(Convert.ToString(dtOceans.Rows[7]["Path"]));
                pictureBox_click_panelGallery_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_showingGallery_7.Image = Image.FromFile(Convert.ToString(dtOceans.Rows[8]["Path"]));
                pictureBox_click_panelGallery_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_showingGallery_8.Image = Image.FromFile(Convert.ToString(dtOceans.Rows[9]["Path"]));
                pictureBox_click_panelGallery_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_showingGallery_9.Image = Image.FromFile(Convert.ToString(dtOceans.Rows[10]["Path"]));
            }
            else if (label_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_showingAuthorName.Text == "NarukamiTriTaiBAR")
            {
                label_panelGallery_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_thirdCategorized.Text = "MotoBike";
                pictureBox_click_panelGallery_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_showingGallery_1.Image = Image.FromFile(Convert.ToString(dtMotoBike.Rows[2]["Path"]));
                pictureBox_click_panelGallery_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_showingGallery_2.Image = Image.FromFile(Convert.ToString(dtMotoBike.Rows[3]["Path"]));
                pictureBox_click_panelGallery_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_showingGallery_3.Image = Image.FromFile(Convert.ToString(dtMotoBike.Rows[4]["Path"]));
                pictureBox_click_panelGallery_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_showingGallery_4.Image = Image.FromFile(Convert.ToString(dtMotoBike.Rows[5]["Path"]));
                pictureBox_click_panelGallery_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_showingGallery_5.Image = Image.FromFile(Convert.ToString(dtMotoBike.Rows[6]["Path"]));
                pictureBox_click_panelGallery_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_showingGallery_6.Image = Image.FromFile(Convert.ToString(dtMotoBike.Rows[7]["Path"]));
                pictureBox_click_panelGallery_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_showingGallery_7.Image = Image.FromFile(Convert.ToString(dtMotoBike.Rows[8]["Path"]));
                pictureBox_click_panelGallery_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_showingGallery_8.Image = Image.FromFile(Convert.ToString(dtMotoBike.Rows[9]["Path"]));
                pictureBox_click_panelGallery_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_showingGallery_9.Image = Image.FromFile(Convert.ToString(dtMotoBike.Rows[10]["Path"]));
            }
        }

        int share_showingAuthorDetail = 0;
        private void button_click_panelFunction_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_share_Click(object sender, EventArgs e)
        {
            if(share_showingAuthorDetail %2 ==0)
            {
                linkLabel_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_share.Visible = true;
                share_showingAuthorDetail++;

            }
            else if (share_showingAuthorDetail % 2 != 0)
            {
                linkLabel_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_share.Visible = false;
                share_showingAuthorDetail++;
            }


        }

        private void pictureBox_panelHome_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_showingHome_1_Click(object sender, EventArgs e)
        {
            pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image=pictureBox_panelHome_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_showingHome_1.Image;
            danhgiau_pictureBoxShowing = 25;
            button_click_panelDetailPicture_flowLayoutPanelDetailPicture_form1_tags_1.Text = "CAR";
            flowLayoutPanelShowingAuthorDetail_form1.Visible = false;
            flowLayoutPanelDetailPicture_form1.Visible = true;
            if(label_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_showingAuthorName.Text== "TheMandarialThangFAT")
            {
                button_click_panelDetailPicture_Favourites.Text = lstImageInfoScreenMain["Favourites_authorThang_1"].ToString();
                button_click_panelDetailPicture_Comments.Text = lstImageInfoScreenMain["Comments_authorThang_1"].ToString();
                button_click_panelDetailPicture_Views.Text = lstImageInfoScreenMain["Views_authorThang_1"].ToString();
                if (lstImageInfoScreenMain["Price_authorThang_1"].ToString() == "0")
                {
                    button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Text = "Free";
                    button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Image = Image.FromFile(@"../../UsedForInterface/icon/free.png");

                }
                else if (lstImageInfoScreenMain["Price_authorThang_1"].ToString() == "1")
                {
                    button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Text = "Costly";
                    button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Image = Image.FromFile(@"../../UsedForInterface/icon/premium-quality.png");
                }
            }
            else if(label_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_showingAuthorName.Text == "NarukamiTriTaiBAR")
            {
                button_click_panelDetailPicture_Favourites.Text = lstImageInfoScreenMain["Categorized_authorTri_1"].ToString();
                button_click_panelDetailPicture_Comments.Text = lstImageInfoScreenMain["Comments_authorTri_1"].ToString();
                button_click_panelDetailPicture_Views.Text = lstImageInfoScreenMain["Views_authorTri_1"].ToString();
                if (lstImageInfoScreenMain["Price_authorTri_1"].ToString() == "0")
                {
                    button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Text = "Free";
                    button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Image = Image.FromFile(@"../../UsedForInterface/icon/free.png");

                }
                else if (lstImageInfoScreenMain["Price_authorTri_1"].ToString() == "1")
                {
                    button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Text = "Costly";
                    button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Image = Image.FromFile(@"../../UsedForInterface/icon/premium-quality.png");
                }
            }





        }

        private void pictureBox_panelHome_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_showingHome_2_Click(object sender, EventArgs e)
        {
            pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBox_panelHome_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_showingHome_2.Image;
            danhgiau_pictureBoxShowing = 26;
            button_click_panelDetailPicture_flowLayoutPanelDetailPicture_form1_tags_1.Text = "INTERIOR";
            flowLayoutPanelShowingAuthorDetail_form1.Visible = false;
            flowLayoutPanelDetailPicture_form1.Visible = true;
            if (label_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_showingAuthorName.Text == "TheMandarialThangFAT")
            {
                button_click_panelDetailPicture_Favourites.Text = lstImageInfoScreenMain["Favourites_authorThang_2"].ToString();
                button_click_panelDetailPicture_Comments.Text = lstImageInfoScreenMain["Comments_authorThang_2"].ToString();
                button_click_panelDetailPicture_Views.Text = lstImageInfoScreenMain["Views_authorThang_2"].ToString();
                if (lstImageInfoScreenMain["Price_authorThang_2"].ToString() == "0")
                {
                    button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Text = "Free";
                    button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Image = Image.FromFile(@"../../UsedForInterface/icon/free.png");

                }
                else if (lstImageInfoScreenMain["Price_authorThang_2"].ToString() == "1")
                {
                    button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Text = "Costly";
                    button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Image = Image.FromFile(@"../../UsedForInterface/icon/premium-quality.png");
                }
            }
            else if (label_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_showingAuthorName.Text == "NarukamiTriTaiBAR")
            {
                button_click_panelDetailPicture_Favourites.Text = lstImageInfoScreenMain["Categorized_authorTri_2"].ToString();
                button_click_panelDetailPicture_Comments.Text = lstImageInfoScreenMain["Comments_authorTri_2"].ToString();
                button_click_panelDetailPicture_Views.Text = lstImageInfoScreenMain["Views_authorTri_2"].ToString();
                if (lstImageInfoScreenMain["Price_authorTri_2"].ToString() == "0")
                {
                    button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Text = "Free";
                    button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Image = Image.FromFile(@"../../UsedForInterface/icon/free.png");

                }
                else if (lstImageInfoScreenMain["Price_authorTri_2"].ToString() == "1")
                {
                    button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Text = "Costly";
                    button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Image = Image.FromFile(@"../../UsedForInterface/icon/premium-quality.png");
                }
            }
        }

        private void pictureBox_panelHome_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_showingHome_3_Click(object sender, EventArgs e)
        {
            pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBox_panelHome_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_showingHome_3.Image;
            danhgiau_pictureBoxShowing = 27;
            button_click_panelDetailPicture_flowLayoutPanelDetailPicture_form1_tags_1.Text = "OCEANS";
            flowLayoutPanelShowingAuthorDetail_form1.Visible = false;
            flowLayoutPanelDetailPicture_form1.Visible = true;
            if (label_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_showingAuthorName.Text == "TheMandarialThangFAT")
            {
                button_click_panelDetailPicture_Favourites.Text = lstImageInfoScreenMain["Favourites_authorThang_3"].ToString();
                button_click_panelDetailPicture_Comments.Text = lstImageInfoScreenMain["Comments_authorThang_3"].ToString();
                button_click_panelDetailPicture_Views.Text = lstImageInfoScreenMain["Views_authorThang_3"].ToString();
                if (lstImageInfoScreenMain["Price_authorThang_3"].ToString() == "0")
                {
                    button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Text = "Free";
                    button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Image = Image.FromFile(@"../../UsedForInterface/icon/free.png");

                }
                else if (lstImageInfoScreenMain["Price_authorThang_3"].ToString() == "1")
                {
                    button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Text = "Costly";
                    button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Image = Image.FromFile(@"../../UsedForInterface/icon/premium-quality.png");
                }
            }
            else if (label_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_showingAuthorName.Text == "NarukamiTriTaiBAR")
            {
                button_click_panelDetailPicture_Favourites.Text = lstImageInfoScreenMain["Categorized_authorTri_3"].ToString();
                button_click_panelDetailPicture_Comments.Text = lstImageInfoScreenMain["Comments_authorTri_3"].ToString();
                button_click_panelDetailPicture_Views.Text = lstImageInfoScreenMain["Views_authorTri_3"].ToString();
                if (lstImageInfoScreenMain["Price_authorTri_3"].ToString() == "0")
                {
                    button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Text = "Free";
                    button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Image = Image.FromFile(@"../../UsedForInterface/icon/free.png");

                }
                else if (lstImageInfoScreenMain["Price_authorTri_3"].ToString() == "1")
                {
                    button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Text = "Costly";
                    button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Image = Image.FromFile(@"../../UsedForInterface/icon/premium-quality.png");
                }
            }
        }

        private void pictureBox_panelHome_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_showingHome_4_Click(object sender, EventArgs e)
        {
            pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBox_panelHome_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_showingHome_4.Image;
            danhgiau_pictureBoxShowing = 28;
            button_click_panelDetailPicture_flowLayoutPanelDetailPicture_form1_tags_1.Text = "FLOWER";
            flowLayoutPanelShowingAuthorDetail_form1.Visible = false;
            flowLayoutPanelDetailPicture_form1.Visible = true;
            if (label_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_showingAuthorName.Text == "TheMandarialThangFAT")
            {
                button_click_panelDetailPicture_Favourites.Text = lstImageInfoScreenMain["Favourites_authorThang_4"].ToString();
                button_click_panelDetailPicture_Comments.Text = lstImageInfoScreenMain["Comments_authorThang_4"].ToString();
                button_click_panelDetailPicture_Views.Text = lstImageInfoScreenMain["Views_authorThang_4"].ToString();
                if (lstImageInfoScreenMain["Price_authorThang_4"].ToString() == "0")
                {
                    button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Text = "Free";
                    button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Image = Image.FromFile(@"../../UsedForInterface/icon/free.png");

                }
                else if (lstImageInfoScreenMain["Price_authorThang_4"].ToString() == "1")
                {
                    button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Text = "Costly";
                    button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Image = Image.FromFile(@"../../UsedForInterface/icon/premium-quality.png");
                }
            }
            else if (label_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_showingAuthorName.Text == "NarukamiTriTaiBAR")
            {
                button_click_panelDetailPicture_Favourites.Text = lstImageInfoScreenMain["Categorized_authorTri_4"].ToString();
                button_click_panelDetailPicture_Comments.Text = lstImageInfoScreenMain["Comments_authorTri_4"].ToString();
                button_click_panelDetailPicture_Views.Text = lstImageInfoScreenMain["Views_authorTri_4"].ToString();
                if (lstImageInfoScreenMain["Price_authorTri_4"].ToString() == "0")
                {
                    button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Text = "Free";
                    button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Image = Image.FromFile(@"../../UsedForInterface/icon/free.png");

                }
                else if (lstImageInfoScreenMain["Price_authorTri_4"].ToString() == "1")
                {
                    button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Text = "Costly";
                    button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Image = Image.FromFile(@"../../UsedForInterface/icon/premium-quality.png");
                }
            }
        }

        private void pictureBox_panelHome_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_showingHome_5_Click(object sender, EventArgs e)
        {
            pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBox_panelHome_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_showingHome_5.Image;
            danhgiau_pictureBoxShowing = 29;
            button_click_panelDetailPicture_flowLayoutPanelDetailPicture_form1_tags_1.Text = "MOTOBIKE";
            flowLayoutPanelShowingAuthorDetail_form1.Visible = false;
            flowLayoutPanelDetailPicture_form1.Visible = true;
            if (label_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_showingAuthorName.Text == "TheMandarialThangFAT")
            {
                button_click_panelDetailPicture_Favourites.Text = lstImageInfoScreenMain["Favourites_authorThang_5"].ToString();
                button_click_panelDetailPicture_Comments.Text = lstImageInfoScreenMain["Comments_authorThang_5"].ToString();
                button_click_panelDetailPicture_Views.Text = lstImageInfoScreenMain["Views_authorThang_5"].ToString();
                if (lstImageInfoScreenMain["Price_authorThang_5"].ToString() == "0")
                {
                    button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Text = "Free";
                    button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Image = Image.FromFile(@"../../UsedForInterface/icon/free.png");

                }
                else if (lstImageInfoScreenMain["Price_authorThang_5"].ToString() == "1")
                {
                    button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Text = "Costly";
                    button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Image = Image.FromFile(@"../../UsedForInterface/icon/premium-quality.png");
                }
            }
            else if (label_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_showingAuthorName.Text == "NarukamiTriTaiBAR")
            {
                button_click_panelDetailPicture_Favourites.Text = lstImageInfoScreenMain["Categorized_authorTri_5"].ToString();
                button_click_panelDetailPicture_Comments.Text = lstImageInfoScreenMain["Comments_authorTri_5"].ToString();
                button_click_panelDetailPicture_Views.Text = lstImageInfoScreenMain["Views_authorTri_5"].ToString();
                if (lstImageInfoScreenMain["Price_authorTri_5"].ToString() == "0")
                {
                    button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Text = "Free";
                    button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Image = Image.FromFile(@"../../UsedForInterface/icon/free.png");

                }
                else if (lstImageInfoScreenMain["Price_authorTri_5"].ToString() == "1")
                {
                    button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Text = "Costly";
                    button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Image = Image.FromFile(@"../../UsedForInterface/icon/premium-quality.png");
                }
            }
        }

        private void pictureBox_panelHome_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_showingHome_6_Click(object sender, EventArgs e)
        {
            pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBox_panelHome_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_showingHome_6.Image;
            danhgiau_pictureBoxShowing = 30;
            button_click_panelDetailPicture_flowLayoutPanelDetailPicture_form1_tags_1.Text = "FOREST";
            flowLayoutPanelShowingAuthorDetail_form1.Visible = false;
            flowLayoutPanelDetailPicture_form1.Visible = true;
            if (label_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_showingAuthorName.Text == "TheMandarialThangFAT")
            {
                button_click_panelDetailPicture_Favourites.Text = lstImageInfoScreenMain["Favourites_authorThang_6"].ToString();
                button_click_panelDetailPicture_Comments.Text = lstImageInfoScreenMain["Comments_authorThang_6"].ToString();
                button_click_panelDetailPicture_Views.Text = lstImageInfoScreenMain["Views_authorThang_6"].ToString();
                if (lstImageInfoScreenMain["Price_authorThang_6"].ToString() == "0")
                {
                    button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Text = "Free";
                    button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Image = Image.FromFile(@"../../UsedForInterface/icon/free.png");

                }
                else if (lstImageInfoScreenMain["Price_authorThang_6"].ToString() == "1")
                {
                    button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Text = "Costly";
                    button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Image = Image.FromFile(@"../../UsedForInterface/icon/premium-quality.png");
                }
            }
            else if (label_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_showingAuthorName.Text == "NarukamiTriTaiBAR")
            {
                button_click_panelDetailPicture_Favourites.Text = lstImageInfoScreenMain["Categorized_authorTri_6"].ToString();
                button_click_panelDetailPicture_Comments.Text = lstImageInfoScreenMain["Comments_authorTri_6"].ToString();
                button_click_panelDetailPicture_Views.Text = lstImageInfoScreenMain["Views_authorTri_6"].ToString();
                if (lstImageInfoScreenMain["Price_authorTri_6"].ToString() == "0")
                {
                    button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Text = "Free";
                    button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Image = Image.FromFile(@"../../UsedForInterface/icon/free.png");

                }
                else if (lstImageInfoScreenMain["Price_authorTri_6"].ToString() == "1")
                {
                    button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Text = "Costly";
                    button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Image = Image.FromFile(@"../../UsedForInterface/icon/premium-quality.png");
                }
            }
        }

        private void pictureBox_click_panelGallery_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_showingGallery_1_Click(object sender, EventArgs e)
        {
            
            pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBox_click_panelGallery_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_showingGallery_1.Image;
            danhgiau_pictureBoxShowing = 31;
            if(label_panelGallery_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_thirdCategorized.Text == "Flower")
            {
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_form1_tags_1.Text = "FLOWER";
            }
            else if(label_panelGallery_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_thirdCategorized.Text == "OCeans")
            {
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_form1_tags_1.Text = "OCEANS";
            }
            else if (label_panelGallery_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_thirdCategorized.Text == "Car")
            {
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_form1_tags_1.Text = "CAR";
            }
            else if (label_panelGallery_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_thirdCategorized.Text == "MotoBike")
            {
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_form1_tags_1.Text = "MOTOBIKE";
            }

            flowLayoutPanelShowingAuthorDetail_form1.Visible = false;
            flowLayoutPanelDetailPicture_form1.Visible = true;

        }

        private void label29_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox_click_panelGallery_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_showingGallery_2_Click(object sender, EventArgs e)
        {
            pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBox_click_panelGallery_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_showingGallery_2.Image;
            danhgiau_pictureBoxShowing = 32;
            if (label_panelGallery_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_thirdCategorized.Text == "Flower")
            {
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_form1_tags_1.Text = "FLOWER";
            }
            else if (label_panelGallery_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_thirdCategorized.Text == "OCeans")
            {
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_form1_tags_1.Text = "OCEANS";
            }
            else if (label_panelGallery_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_thirdCategorized.Text == "Car")
            {
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_form1_tags_1.Text = "CAR";
            }
            else if (label_panelGallery_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_thirdCategorized.Text == "MotoBike")
            {
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_form1_tags_1.Text = "MOTOBIKE";
            }
            flowLayoutPanelShowingAuthorDetail_form1.Visible = false;
            flowLayoutPanelDetailPicture_form1.Visible = true;
        }

        private void pictureBox_click_panelGallery_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_showingGallery_3_Click(object sender, EventArgs e)
        {
            pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBox_click_panelGallery_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_showingGallery_3.Image;
            danhgiau_pictureBoxShowing = 33;
            if (label_panelGallery_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_thirdCategorized.Text == "Flower")
            {
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_form1_tags_1.Text = "FLOWER";
            }
            else if (label_panelGallery_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_thirdCategorized.Text == "OCeans")
            {
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_form1_tags_1.Text = "OCEANS";
            }
            else if (label_panelGallery_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_thirdCategorized.Text == "Car")
            {
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_form1_tags_1.Text = "CAR";
            }
            else if (label_panelGallery_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_thirdCategorized.Text == "MotoBike")
            {
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_form1_tags_1.Text = "MOTOBIKE";
            }
            flowLayoutPanelShowingAuthorDetail_form1.Visible = false;
            flowLayoutPanelDetailPicture_form1.Visible = true;
        }

        private void pictureBox_click_panelGallery_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_showingGallery_4_Click(object sender, EventArgs e)
        {
            pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBox_click_panelGallery_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_showingGallery_4.Image;
            danhgiau_pictureBoxShowing = 34;
            if (label_panelGallery_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_thirdCategorized.Text == "Flower")
            {
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_form1_tags_1.Text = "FLOWER";
            }
            else if (label_panelGallery_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_thirdCategorized.Text == "OCeans")
            {
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_form1_tags_1.Text = "OCEANS";
            }
            else if (label_panelGallery_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_thirdCategorized.Text == "Car")
            {
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_form1_tags_1.Text = "CAR";
            }
            else if (label_panelGallery_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_thirdCategorized.Text == "MotoBike")
            {
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_form1_tags_1.Text = "MOTOBIKE";
            }
            flowLayoutPanelShowingAuthorDetail_form1.Visible = false;
            flowLayoutPanelDetailPicture_form1.Visible = true;
        }

        private void pictureBox_click_panelGallery_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_showingGallery_5_Click(object sender, EventArgs e)
        {
            pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBox_click_panelGallery_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_showingGallery_5.Image;
            danhgiau_pictureBoxShowing = 35;
            if (label_panelGallery_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_thirdCategorized.Text == "Flower")
            {
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_form1_tags_1.Text = "FLOWER";
            }
            else if (label_panelGallery_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_thirdCategorized.Text == "OCeans")
            {
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_form1_tags_1.Text = "OCEANS";
            }
            else if (label_panelGallery_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_thirdCategorized.Text == "Car")
            {
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_form1_tags_1.Text = "CAR";
            }
            else if (label_panelGallery_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_thirdCategorized.Text == "MotoBike")
            {
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_form1_tags_1.Text = "MOTOBIKE";
            }
            flowLayoutPanelShowingAuthorDetail_form1.Visible = false;
            flowLayoutPanelDetailPicture_form1.Visible = true;
        }

        private void pictureBox_click_panelGallery_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_showingGallery_6_Click(object sender, EventArgs e)
        {
            pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBox_click_panelGallery_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_showingGallery_6.Image;
            danhgiau_pictureBoxShowing = 36;
            if (label_panelGallery_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_thirdCategorized.Text == "Flower")
            {
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_form1_tags_1.Text = "FLOWER";
            }
            else if (label_panelGallery_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_thirdCategorized.Text == "OCeans")
            {
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_form1_tags_1.Text = "OCEANS";
            }
            else if (label_panelGallery_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_thirdCategorized.Text == "Car")
            {
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_form1_tags_1.Text = "CAR";
            }
            else if (label_panelGallery_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_thirdCategorized.Text == "MotoBike")
            {
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_form1_tags_1.Text = "MOTOBIKE";
            }
            flowLayoutPanelShowingAuthorDetail_form1.Visible = false;
            flowLayoutPanelDetailPicture_form1.Visible = true;
        }

        private void pictureBox_click_panelGallery_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_showingGallery_7_Click(object sender, EventArgs e)
        {
            pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBox_click_panelGallery_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_showingGallery_7.Image;
            danhgiau_pictureBoxShowing = 37;
            if (label_panelGallery_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_thirdCategorized.Text == "Flower")
            {
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_form1_tags_1.Text = "FLOWER";
            }
            else if (label_panelGallery_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_thirdCategorized.Text == "OCeans")
            {
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_form1_tags_1.Text = "OCEANS";
            }
            else if (label_panelGallery_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_thirdCategorized.Text == "Car")
            {
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_form1_tags_1.Text = "CAR";
            }
            else if (label_panelGallery_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_thirdCategorized.Text == "MotoBike")
            {
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_form1_tags_1.Text = "MOTOBIKE";
            }
            flowLayoutPanelShowingAuthorDetail_form1.Visible = false;
            flowLayoutPanelDetailPicture_form1.Visible = true;
        }

        private void pictureBox_click_panelGallery_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_showingGallery_8_Click(object sender, EventArgs e)
        {
            pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBox_click_panelGallery_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_showingGallery_8.Image;
            danhgiau_pictureBoxShowing = 38;
            if (label_panelGallery_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_thirdCategorized.Text == "Flower")
            {
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_form1_tags_1.Text = "FLOWER";
            }
            else if (label_panelGallery_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_thirdCategorized.Text == "OCeans")
            {
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_form1_tags_1.Text = "OCEANS";
            }
            else if (label_panelGallery_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_thirdCategorized.Text == "Car")
            {
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_form1_tags_1.Text = "CAR";
            }
            else if (label_panelGallery_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_thirdCategorized.Text == "MotoBike")
            {
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_form1_tags_1.Text = "MOTOBIKE";
            }
            flowLayoutPanelShowingAuthorDetail_form1.Visible = false;
            flowLayoutPanelDetailPicture_form1.Visible = true;
        }

        private void pictureBox_click_panelGallery_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_showingGallery_9_Click(object sender, EventArgs e)
        {
            pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBox_click_panelGallery_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_showingGallery_9.Image;
            danhgiau_pictureBoxShowing = 39;
            if (label_panelGallery_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_thirdCategorized.Text == "Flower")
            {
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_form1_tags_1.Text = "FLOWER";
            }
            else if (label_panelGallery_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_thirdCategorized.Text == "OCeans")
            {
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_form1_tags_1.Text = "OCEANS";
            }
            else if (label_panelGallery_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_thirdCategorized.Text == "Car")
            {
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_form1_tags_1.Text = "CAR";
            }
            else if (label_panelGallery_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_thirdCategorized.Text == "MotoBike")
            {
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_form1_tags_1.Text = "MOTOBIKE";
            }
            flowLayoutPanelShowingAuthorDetail_form1.Visible = false;
            flowLayoutPanelDetailPicture_form1.Visible = true;
        }

        private void button_click_panelDetailPicture_flowLayoutPanelDetailPicture_form1_tags_1_Click(object sender, EventArgs e)
        {
            flowLayoutPanelDetailPicture_form1.Visible = false;
            if(button_click_panelDetailPicture_flowLayoutPanelDetailPicture_form1_tags_1.Text=="CAR")
            {
                flowLayoutPanelDetailTopics_form1.Visible = true;
                pictureBox_panelBackGround_flowLayoutPanelDetailTopics_form1_showingBackGroundTopics.Image = Image.FromFile(@"../../UsedForInterface/CarBackGround.png");
                label_panelBackGround_flowLayoutPanelDetailTopics_form1_nameTopics.Text = "CAR";
                label_panelBackGround_flowLayoutPanelDetailTopics_form1_describetopics.Text = "Explore the best car that ever exist,with the most modern design and technology";
                int[] arr1 = new int[12];
                LetNotDup(1, 158, arr1);
                load_random_image(dtCar, 157, arr1[0], arr1[1], arr1[2], arr1[3], arr1[4], arr1[5], arr1[6], arr1[7], arr1[8], arr1[9], arr1[10], arr1[11]);
            }
            else if (button_click_panelDetailPicture_flowLayoutPanelDetailPicture_form1_tags_1.Text == "INTERIOR")
            {
                flowLayoutPanelDetailTopics_form1.Visible = true;
                pictureBox_panelBackGround_flowLayoutPanelDetailTopics_form1_showingBackGroundTopics.Image = Image.FromFile(@"../../UsedForInterface/Interiorbackground.jpg");
                label_panelBackGround_flowLayoutPanelDetailTopics_form1_nameTopics.Text = "INTERIOR";
                label_panelBackGround_flowLayoutPanelDetailTopics_form1_describetopics.Text = "Discovery the most modern interior in 2021,eyes catching interior";
                int[] arr = new int[12];
                LetNotDup(1, 230, arr);
                load_random_image(dtInterior, 229, arr[0], arr[1], arr[2], arr[3], arr[4], arr[5], arr[6], arr[7], arr[8], arr[9], arr[10], arr[11]);
            }
            else if (button_click_panelDetailPicture_flowLayoutPanelDetailPicture_form1_tags_1.Text == "FOREST")
            {
                flowLayoutPanelDetailTopics_form1.Visible = true;
                pictureBox_panelBackGround_flowLayoutPanelDetailTopics_form1_showingBackGroundTopics.Image = Image.FromFile(@"../../UsedForInterface/ForestBackGround.png");
                label_panelBackGround_flowLayoutPanelDetailTopics_form1_nameTopics.Text = "FOREST";
                label_panelBackGround_flowLayoutPanelDetailTopics_form1_describetopics.Text = "Explore the most beautiful forest in the world";
                int[] arr3 = new int[12];
                LetNotDup(1, 206, arr3);
                load_random_image(dtForest, 205, arr3[0], arr3[1], arr3[2], arr3[3], arr3[4], arr3[5], arr3[6], arr3[7], arr3[8], arr3[9], arr3[10], arr3[11]);
            }
            else if (button_click_panelDetailPicture_flowLayoutPanelDetailPicture_form1_tags_1.Text == "OCEANS")
            {
                flowLayoutPanelDetailTopics_form1.Visible = true;
                pictureBox_panelBackGround_flowLayoutPanelDetailTopics_form1_showingBackGroundTopics.Image = Image.FromFile(@"../../UsedForInterface/OceansBackground.png");
                label_panelBackGround_flowLayoutPanelDetailTopics_form1_nameTopics.Text = "OCEANS";
                label_panelBackGround_flowLayoutPanelDetailTopics_form1_describetopics.Text = "A real-world example of a zero-entry swimming pool. Swim in the peaceful waves, lunch under a thatch-roof cabana under the palms";
                int[] arr4 = new int[12];
                LetNotDup(1, 187, arr4);
                load_random_image(dtOceans, 186, arr4[0], arr4[1], arr4[2], arr4[3], arr4[4], arr4[5], arr4[6], arr4[7], arr4[8], arr4[9], arr4[10], arr4[11]);
            }
            else if(button_click_panelDetailPicture_flowLayoutPanelDetailPicture_form1_tags_1.Text == "MOTOBIKE")
            {
                flowLayoutPanelDetailTopics_form1.Visible = true;
                pictureBox_panelBackGround_flowLayoutPanelDetailTopics_form1_showingBackGroundTopics.Image = Image.FromFile(@"../../UsedForInterface/MotoBikebackGround.png");
                label_panelBackGround_flowLayoutPanelDetailTopics_form1_nameTopics.Text = "MOTOBIKE";
                label_panelBackGround_flowLayoutPanelDetailTopics_form1_describetopics.Text = "Here is the most significant image for motobike";
                int[] arr2 = new int[12];
                LetNotDup(1, 243, arr2);
                load_random_image(dtMotoBike, 242, arr2[0], arr2[1], arr2[2], arr2[3], arr2[4], arr2[5], arr2[6], arr2[7], arr2[8], arr2[9], arr2[10], arr2[11]);
            }
            else if (button_click_panelDetailPicture_flowLayoutPanelDetailPicture_form1_tags_1.Text == "FLOWER")
            {
                flowLayoutPanelDetailTopics_form1.Visible = true;
                pictureBox_panelBackGround_flowLayoutPanelDetailTopics_form1_showingBackGroundTopics.Image = Image.FromFile(@"../../UsedForInterface/FlowerBackGround.png");
                label_panelBackGround_flowLayoutPanelDetailTopics_form1_nameTopics.Text = "FLOWER";
                label_panelBackGround_flowLayoutPanelDetailTopics_form1_describetopics.Text = "Beautiful and special flower on the planet";
                int[] arr5 = new int[12];
                LetNotDup(1, 160, arr5);
                load_random_image(dtFlower, 159, arr5[0], arr5[1], arr5[2], arr5[3], arr5[4], arr5[5], arr5[6], arr5[7], arr5[8], arr5[9], arr5[10], arr5[11]);
            }
        }

        private void button_click_panelSeeMore_flowLayoutPanelDetailPicture_form1_authorThang_2_Click(object sender, EventArgs e)
        {
            flowLayoutPanelShowingAuthorDetail_form1.Visible = true;
            panelHome_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1.Visible = true;
            flowLayoutPanelDailyAndTrending_form1.Visible = false;
            flowLayoutPanelDetailTopics_form1.Visible = false;
            flowLayoutPanelMain_form1.Visible = false;
            flowLayoutPanelDetailPicture_form1.Visible = false;
            panelGallery_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1.Visible = false;
            label_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_showingAuthorName.Text = "TheMandarialThangFAT";
            pictureBox_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_showingAuthorBackground.Image = Image.FromFile(@"../../UsedForInterface/icon/dragon.jpg");
            pictureBox_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_showingAuthorAvatar.Image = Image.FromFile(@"../../UsedForInterface/icon/bird.png");
            label_panelProfilesAuthor_panelHome_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_introdution.Text = "Artist  //  Hobbyist   //   DigitalArt  //   Professional  ";
            label_panelProfilesAuthor_panelHome_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_birthday.Text = "Feb,25";
            label_panelProfilesAuthor_panelHome_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_location.Text = "Ho Chi Minh City.";
            label_panelHome_panelShowingAuthorDetail_form1_aboutThisAuthor.Text = "TheMandarialThangFAT";
            label_panelProfilesAuthor_panelHome_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_joinseen.Text = "Join seen 2005";
            Random randomCategorizedToPutPictureInPanelHomeOfAuthorDetail = new Random();
            int randomCar = randomCategorizedToPutPictureInPanelHomeOfAuthorDetail.Next(1, 158);
            int randomInterior = randomCategorizedToPutPictureInPanelHomeOfAuthorDetail.Next(1, 230);
            int randomOceans = randomCategorizedToPutPictureInPanelHomeOfAuthorDetail.Next(1, 187);
            int randomFlower = randomCategorizedToPutPictureInPanelHomeOfAuthorDetail.Next(1, 160);
            int randomMotoBike = randomCategorizedToPutPictureInPanelHomeOfAuthorDetail.Next(1, 243);
            int randomForest = randomCategorizedToPutPictureInPanelHomeOfAuthorDetail.Next(1, 206);
            for (int i = 1; i <= 157; i++)
            {
                if (randomCar == i)
                {
                    pictureBox_panelHome_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_showingHome_1.Image = Image.FromFile(Convert.ToString(dtCar.Rows[randomCar - 1]["Path"]));
                }

            }
            for (int j = 1; j <= 229; j++)
            {
                if (randomInterior == j)
                {
                    pictureBox_panelHome_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_showingHome_2.Image = Image.FromFile(Convert.ToString(dtInterior.Rows[randomInterior - 1]["Path"]));
                }
            }
            for (int k = 1; k <= 186; k++)
            {
                if (randomOceans == k)
                {
                    pictureBox_panelHome_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_showingHome_3.Image = Image.FromFile(Convert.ToString(dtOceans.Rows[randomOceans - 1]["Path"]));
                }
            }
            for (int p = 1; p <= 159; p++)
            {
                if (randomFlower == p)
                {
                    pictureBox_panelHome_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_showingHome_4.Image = Image.FromFile(Convert.ToString(dtFlower.Rows[randomFlower - 1]["Path"]));
                }
            }
            for (int o = 1; o <= 242; o++)
            {
                if (randomMotoBike == o)
                {
                    pictureBox_panelHome_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_showingHome_5.Image = Image.FromFile(Convert.ToString(dtMotoBike.Rows[randomMotoBike - 1]["Path"]));
                }
            }
            for (int u = 1; u <= 205; u++)
            {
                if (randomForest == u)
                {
                    pictureBox_panelHome_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_showingHome_6.Image = Image.FromFile(Convert.ToString(dtForest.Rows[randomForest - 1]["Path"]));
                }
            }

        }

        private void pictureBox_panelSeeMore_flowLayoutPanelDetailPicture_form1_showingMore_1_Click(object sender, EventArgs e)
        {
            pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBox_panelSeeMore_flowLayoutPanelDetailPicture_form1_showingMore_1.Image;
            button_click_panelDetailPicture_flowLayoutPanelDetailPicture_form1_tags_1.Text = "CAR";
            danhgiau_pictureBoxShowing = 40;
            button_click_panelDetailPicture_Favourites.Text = lstImageInfoScreenMain["Favourites_main1"].ToString();
            button_click_panelDetailPicture_Comments.Text = lstImageInfoScreenMain["Comments_main1"].ToString();
            button_click_panelDetailPicture_Views.Text = lstImageInfoScreenMain["Views_main1"].ToString();
            if (lstImageInfoScreenMain["Price_main1"].ToString() == "0")
            {
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Text = "Free";
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Image = Image.FromFile(@"../../UsedForInterface/icon/free.png");

            }
            else if (lstImageInfoScreenMain["Price_main1"].ToString() == "1")
            {
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Text = "Costly";
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Image = Image.FromFile(@"../../UsedForInterface/icon/premium-quality.png");
            }
        }

        private void pictureBox_panelSeeMore_flowLayoutPanelDetailPicture_form1_showingMore_2_Click(object sender, EventArgs e)
        {
            pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBox_panelSeeMore_flowLayoutPanelDetailPicture_form1_showingMore_2.Image;
            button_click_panelDetailPicture_flowLayoutPanelDetailPicture_form1_tags_1.Text = "CAR";
            danhgiau_pictureBoxShowing = 41;
            button_click_panelDetailPicture_Favourites.Text = lstImageInfoScreenMain["Favourites_main2"].ToString();
            button_click_panelDetailPicture_Comments.Text = lstImageInfoScreenMain["Comments_main2"].ToString();
            button_click_panelDetailPicture_Views.Text = lstImageInfoScreenMain["Views_main2"].ToString();
            if (lstImageInfoScreenMain["Price_main2"].ToString() == "0")
            {
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Text = "Free";
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Image = Image.FromFile(@"../../UsedForInterface/icon/free.png");

            }
            else if (lstImageInfoScreenMain["Price_main2"].ToString() == "1")
            {
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Text = "Costly";
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Image = Image.FromFile(@"../../UsedForInterface/icon/premium-quality.png");
            }
        }

        private void pictureBox_panelSeeMore_flowLayoutPanelDetailPicture_form1_showingMore_3_Click(object sender, EventArgs e)
        {
            pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBox_panelSeeMore_flowLayoutPanelDetailPicture_form1_showingMore_3.Image;
            button_click_panelDetailPicture_flowLayoutPanelDetailPicture_form1_tags_1.Text = "INTERIOR";
            danhgiau_pictureBoxShowing = 42;
            button_click_panelDetailPicture_Favourites.Text = lstImageInfoScreenMain["Favourites_main5"].ToString();
            button_click_panelDetailPicture_Comments.Text = lstImageInfoScreenMain["Comments_main5"].ToString();
            button_click_panelDetailPicture_Views.Text = lstImageInfoScreenMain["Views_main5"].ToString();
            if (lstImageInfoScreenMain["Price_main5"].ToString() == "0")
            {
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Text = "Free";
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Image = Image.FromFile(@"../../UsedForInterface/icon/free.png");

            }
            else if (lstImageInfoScreenMain["Price_main5"].ToString() == "1")
            {
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Text = "Costly";
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Image = Image.FromFile(@"../../UsedForInterface/icon/premium-quality.png");
            }
        }

        private void pictureBox_panelSeeMore_flowLayoutPanelDetailPicture_form1_showingMore_4_Click(object sender, EventArgs e)
        {
            pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBox_panelSeeMore_flowLayoutPanelDetailPicture_form1_showingMore_4.Image;
            button_click_panelDetailPicture_flowLayoutPanelDetailPicture_form1_tags_1.Text = "INTERIOR";
            danhgiau_pictureBoxShowing = 43;
            button_click_panelDetailPicture_Favourites.Text = lstImageInfoScreenMain["Favourites_main6"].ToString();
            button_click_panelDetailPicture_Comments.Text = lstImageInfoScreenMain["Comments_main6"].ToString();
            button_click_panelDetailPicture_Views.Text = lstImageInfoScreenMain["Views_main6"].ToString();
            if (lstImageInfoScreenMain["Price_main6"].ToString() == "0")
            {
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Text = "Free";
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Image = Image.FromFile(@"../../UsedForInterface/icon/free.png");

            }
            else if (lstImageInfoScreenMain["Price_main6"].ToString() == "1")
            {
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Text = "Costly";
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Image = Image.FromFile(@"../../UsedForInterface/icon/premium-quality.png");
            }
        }

        private void pictureBox_panelSeeMore_flowLayoutPanelDetailPicture_form1_showingMore_5_Click(object sender, EventArgs e)
        {
            pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBox_panelSeeMore_flowLayoutPanelDetailPicture_form1_showingMore_5.Image;
            button_click_panelDetailPicture_flowLayoutPanelDetailPicture_form1_tags_1.Text = "FOREST";
            danhgiau_pictureBoxShowing = 44;
            button_click_panelDetailPicture_Favourites.Text = lstImageInfoScreenMain["Favourites_main9"].ToString();
            button_click_panelDetailPicture_Comments.Text = lstImageInfoScreenMain["Comments_main9"].ToString();
            button_click_panelDetailPicture_Views.Text = lstImageInfoScreenMain["Views_main9"].ToString();
            if (lstImageInfoScreenMain["Price_main9"].ToString() == "0")
            {
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Text = "Free";
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Image = Image.FromFile(@"../../UsedForInterface/icon/free.png");

            }
            else if (lstImageInfoScreenMain["Price_main9"].ToString() == "1")
            {
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Text = "Costly";
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Image = Image.FromFile(@"../../UsedForInterface/icon/premium-quality.png");
            }
        }

        private void pictureBox_panelSeeMore_flowLayoutPanelDetailPicture_form1_showingMore_6_Click(object sender, EventArgs e)
        {
            pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBox_panelSeeMore_flowLayoutPanelDetailPicture_form1_showingMore_6.Image;
            button_click_panelDetailPicture_flowLayoutPanelDetailPicture_form1_tags_1.Text = "FOREST";
            danhgiau_pictureBoxShowing = 45;
            button_click_panelDetailPicture_Favourites.Text = lstImageInfoScreenMain["Favourites_main10"].ToString();
            button_click_panelDetailPicture_Comments.Text = lstImageInfoScreenMain["Comments_main10"].ToString();
            button_click_panelDetailPicture_Views.Text = lstImageInfoScreenMain["Views_main10"].ToString();
            if (lstImageInfoScreenMain["Price_main10"].ToString() == "0")
            {
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Text = "Free";
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Image = Image.FromFile(@"../../UsedForInterface/icon/free.png");

            }
            else if (lstImageInfoScreenMain["Price_main10"].ToString() == "1")
            {
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Text = "Costly";
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Image = Image.FromFile(@"../../UsedForInterface/icon/premium-quality.png");
            }
        }

        private void pictureBox_panelSeeMore_flowLayoutPanelDetailPicture_form1_showingMore_7_Click(object sender, EventArgs e)
        {
            pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBox_panelSeeMore_flowLayoutPanelDetailPicture_form1_showingMore_7.Image;
            button_click_panelDetailPicture_flowLayoutPanelDetailPicture_form1_tags_1.Text = "OCEANS";
            danhgiau_pictureBoxShowing = 46;
            button_click_panelDetailPicture_Favourites.Text = lstImageInfoScreenMain["Favourites_main13"].ToString();
            button_click_panelDetailPicture_Comments.Text = lstImageInfoScreenMain["Comments_main13"].ToString();
            button_click_panelDetailPicture_Views.Text = lstImageInfoScreenMain["Views_main13"].ToString();
            if (lstImageInfoScreenMain["Price_main13"].ToString() == "0")
            {
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Text = "Free";
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Image = Image.FromFile(@"../../UsedForInterface/icon/free.png");

            }
            else if (lstImageInfoScreenMain["Price_main13"].ToString() == "1")
            {
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Text = "Costly";
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Image = Image.FromFile(@"../../UsedForInterface/icon/premium-quality.png");
            }
        }

        private void pictureBox_panelSeeMore_flowLayoutPanelDetailPicture_form1_showingMore_8_Click(object sender, EventArgs e)
        {
            pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBox_panelSeeMore_flowLayoutPanelDetailPicture_form1_showingMore_8.Image;
            button_click_panelDetailPicture_flowLayoutPanelDetailPicture_form1_tags_1.Text = "OCEANS";
            danhgiau_pictureBoxShowing = 47;
            button_click_panelDetailPicture_Favourites.Text = lstImageInfoScreenMain["Favourites_main14"].ToString();
            button_click_panelDetailPicture_Comments.Text = lstImageInfoScreenMain["Comments_main14"].ToString();
            button_click_panelDetailPicture_Views.Text = lstImageInfoScreenMain["Views_main14"].ToString();
            if (lstImageInfoScreenMain["Price_main14"].ToString() == "0")
            {
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Text = "Free";
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Image = Image.FromFile(@"../../UsedForInterface/icon/free.png");

            }
            else if (lstImageInfoScreenMain["Price_main14"].ToString() == "1")
            {
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Text = "Costly";
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Image = Image.FromFile(@"../../UsedForInterface/icon/premium-quality.png");
            }
        }

        private void pictureBox_panelSeeMore_flowLayoutPanelDetailPicture_form1_showingMore_9_Click(object sender, EventArgs e)
        {
            pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBox_panelSeeMore_flowLayoutPanelDetailPicture_form1_showingMore_9.Image;
            button_click_panelDetailPicture_flowLayoutPanelDetailPicture_form1_tags_1.Text = "MOTOBIKE";
            danhgiau_pictureBoxShowing = 48;
            button_click_panelDetailPicture_Favourites.Text = lstImageInfoScreenMain["Favourites_main17"].ToString();
            button_click_panelDetailPicture_Comments.Text = lstImageInfoScreenMain["Comments_main17"].ToString();
            button_click_panelDetailPicture_Views.Text = lstImageInfoScreenMain["Views_main17"].ToString();
            if (lstImageInfoScreenMain["Price_main17"].ToString() == "0")
            {
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Text = "Free";
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Image = Image.FromFile(@"../../UsedForInterface/icon/free.png");

            }
            else if (lstImageInfoScreenMain["Price_main17"].ToString() == "1")
            {
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Text = "Costly";
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Image = Image.FromFile(@"../../UsedForInterface/icon/premium-quality.png");
            }
        }

        private void pictureBox_panelSeeMore_flowLayoutPanelDetailPicture_form1_showingMore_10_Click(object sender, EventArgs e)
        {
            pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBox_panelSeeMore_flowLayoutPanelDetailPicture_form1_showingMore_10.Image;
            button_click_panelDetailPicture_flowLayoutPanelDetailPicture_form1_tags_1.Text = "MOTOBIKE";
            danhgiau_pictureBoxShowing = 49;
            button_click_panelDetailPicture_Favourites.Text = lstImageInfoScreenMain["Favourites_main18"].ToString();
            button_click_panelDetailPicture_Comments.Text = lstImageInfoScreenMain["Comments_main18"].ToString();
            button_click_panelDetailPicture_Views.Text = lstImageInfoScreenMain["Views_main18"].ToString();
            if (lstImageInfoScreenMain["Price_main18"].ToString() == "0")
            {
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Text = "Free";
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Image = Image.FromFile(@"../../UsedForInterface/icon/free.png");

            }
            else if (lstImageInfoScreenMain["Price_main18"].ToString() == "1")
            {
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Text = "Costly";
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Image = Image.FromFile(@"../../UsedForInterface/icon/premium-quality.png");
            }
        }

        private void pictureBox_panelSeeMore_flowLayoutPanelDetailPicture_form1_showingMore_11_Click(object sender, EventArgs e)
        {
            pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBox_panelSeeMore_flowLayoutPanelDetailPicture_form1_showingMore_11.Image;
            button_click_panelDetailPicture_flowLayoutPanelDetailPicture_form1_tags_1.Text = "FLOWER";
            danhgiau_pictureBoxShowing = 50;
            button_click_panelDetailPicture_Favourites.Text = lstImageInfoScreenMain["Favourites_main21"].ToString();
            button_click_panelDetailPicture_Comments.Text = lstImageInfoScreenMain["Comments_main21"].ToString();
            button_click_panelDetailPicture_Views.Text = lstImageInfoScreenMain["Views_main21"].ToString();
            if (lstImageInfoScreenMain["Price_main21"].ToString() == "0")
            {
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Text = "Free";
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Image = Image.FromFile(@"../../UsedForInterface/icon/free.png");

            }
            else if (lstImageInfoScreenMain["Price_main21"].ToString() == "1")
            {
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Text = "Costly";
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Image = Image.FromFile(@"../../UsedForInterface/icon/premium-quality.png");
            }
        }

        private void pictureBox_panelSeeMore_flowLayoutPanelDetailPicture_form1_showingMore_12_Click(object sender, EventArgs e)
        {
            pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBox_panelSeeMore_flowLayoutPanelDetailPicture_form1_showingMore_12.Image;
            button_click_panelDetailPicture_flowLayoutPanelDetailPicture_form1_tags_1.Text = "FLOWER";
            danhgiau_pictureBoxShowing = 51;
            button_click_panelDetailPicture_Favourites.Text = lstImageInfoScreenMain["Favourites_main22"].ToString();
            button_click_panelDetailPicture_Comments.Text = lstImageInfoScreenMain["Comments_main22"].ToString();
            button_click_panelDetailPicture_Views.Text = lstImageInfoScreenMain["Views_main22"].ToString();
            if (lstImageInfoScreenMain["Price_main22"].ToString() == "0")
            {
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Text = "Free";
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Image = Image.FromFile(@"../../UsedForInterface/icon/free.png");

            }
            else if (lstImageInfoScreenMain["Price_main22"].ToString() == "1")
            {
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Text = "Costly";
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Image = Image.FromFile(@"../../UsedForInterface/icon/premium-quality.png");
            }
        }

        private void pictureBox_panelSeeMore_flowLayoutPanelDetailPicture_form1_showingMore_13_Click(object sender, EventArgs e)
        {
            pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBox_panelSeeMore_flowLayoutPanelDetailPicture_form1_showingMore_13.Image;
            button_click_panelDetailPicture_flowLayoutPanelDetailPicture_form1_tags_1.Text = "FLOWER";
            danhgiau_pictureBoxShowing = 52;
            button_click_panelDetailPicture_Favourites.Text = lstImageInfoScreenMain["Favourites_main23"].ToString();
            button_click_panelDetailPicture_Comments.Text = lstImageInfoScreenMain["Comments_main23"].ToString();
            button_click_panelDetailPicture_Views.Text = lstImageInfoScreenMain["Views_main23"].ToString();
            if (lstImageInfoScreenMain["Price_main23"].ToString() == "0")
            {
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Text = "Free";
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Image = Image.FromFile(@"../../UsedForInterface/icon/free.png");

            }
            else if (lstImageInfoScreenMain["Price_main23"].ToString() == "1")
            {
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Text = "Costly";
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Image = Image.FromFile(@"../../UsedForInterface/icon/premium-quality.png");
            }
        }

        private void pictureBox_panelSeeMore_flowLayoutPanelDetailPicture_form1_showingMore_14_Click(object sender, EventArgs e)
        {
            pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBox_panelSeeMore_flowLayoutPanelDetailPicture_form1_showingMore_14.Image;
            button_click_panelDetailPicture_flowLayoutPanelDetailPicture_form1_tags_1.Text = "MOTOBIKE";
            danhgiau_pictureBoxShowing = 53;
            button_click_panelDetailPicture_Favourites.Text = lstImageInfoScreenMain["Favourites_main19"].ToString();
            button_click_panelDetailPicture_Comments.Text = lstImageInfoScreenMain["Comments_main19"].ToString();
            button_click_panelDetailPicture_Views.Text = lstImageInfoScreenMain["Views_main19"].ToString();
            if (lstImageInfoScreenMain["Price_main19"].ToString() == "0")
            {
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Text = "Free";
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Image = Image.FromFile(@"../../UsedForInterface/icon/free.png");

            }
            else if (lstImageInfoScreenMain["Price_main19"].ToString() == "1")
            {
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Text = "Costly";
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Image = Image.FromFile(@"../../UsedForInterface/icon/premium-quality.png");
            }
        }

        private void pictureBox_panelSeeMore_flowLayoutPanelDetailPicture_form1_showingMore_15_Click(object sender, EventArgs e)
        {
            pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBox_panelSeeMore_flowLayoutPanelDetailPicture_form1_showingMore_15.Image;
            button_click_panelDetailPicture_flowLayoutPanelDetailPicture_form1_tags_1.Text = "OCEANS";
            danhgiau_pictureBoxShowing = 54;
            button_click_panelDetailPicture_Favourites.Text = lstImageInfoScreenMain["Favourites_main16"].ToString();
            button_click_panelDetailPicture_Comments.Text = lstImageInfoScreenMain["Comments_main16"].ToString();
            button_click_panelDetailPicture_Views.Text = lstImageInfoScreenMain["Views_main16"].ToString();
            if (lstImageInfoScreenMain["Price_main16"].ToString() == "0")
            {
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Text = "Free";
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Image = Image.FromFile(@"../../UsedForInterface/icon/free.png");

            }
            else if (lstImageInfoScreenMain["Price_main16"].ToString() == "1")
            {
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Text = "Costly";
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Image = Image.FromFile(@"../../UsedForInterface/icon/premium-quality.png");
            }
        }

        private void pictureBox_panelSeeMore_flowLayoutPanelDetailPicture_form1_showingMore_16_Click(object sender, EventArgs e)
        {
            pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBox_panelSeeMore_flowLayoutPanelDetailPicture_form1_showingMore_16.Image;
            button_click_panelDetailPicture_flowLayoutPanelDetailPicture_form1_tags_1.Text = "INTERIOR";
            danhgiau_pictureBoxShowing = 55;
        }

        private void pictureBox_panelSeeMore_flowLayoutPanelDetailPicture_form1_showingMore_17_Click(object sender, EventArgs e)
        {
            pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBox_panelSeeMore_flowLayoutPanelDetailPicture_form1_showingMore_17.Image;
            button_click_panelDetailPicture_flowLayoutPanelDetailPicture_form1_tags_1.Text = "INTERIOR";
            danhgiau_pictureBoxShowing = 56;
        }

        private void pictureBox_panelSeeMore_flowLayoutPanelDetailPicture_form1_showingMore_18_Click(object sender, EventArgs e)
        {
            pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBox_panelSeeMore_flowLayoutPanelDetailPicture_form1_showingMore_18.Image;
            button_click_panelDetailPicture_flowLayoutPanelDetailPicture_form1_tags_1.Text = "INTERIOR";
            danhgiau_pictureBoxShowing = 57;
        }

        private void button_click_panelSeeMore_flowLayoutPanelDetailPicture_form1_authorTri_1_Click(object sender, EventArgs e)
        {
            flowLayoutPanelShowingAuthorDetail_form1.Visible = true;
            panelHome_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1.Visible = true;
            flowLayoutPanelDailyAndTrending_form1.Visible = false;
            flowLayoutPanelDetailTopics_form1.Visible = false;
            flowLayoutPanelMain_form1.Visible = false;
            flowLayoutPanelDetailPicture_form1.Visible = false;
            panelGallery_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1.Visible = false;
            label_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_showingAuthorName.Text = "NarukamiTriTaiBAR";
            pictureBox_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_showingAuthorBackground.Image = Image.FromFile(@"../../UsedForInterface/icon/themaldarin.jpg");
            pictureBox_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_showingAuthorAvatar.Image = Image.FromFile(@"../../UsedForInterface/icon/girl.png");
            label_panelProfilesAuthor_panelHome_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_introdution.Text = "Artist  //  Hobbyist   //   DigitalArt  //   Professional  ";
            label_panelProfilesAuthor_panelHome_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_birthday.Text = "August,24";
            label_panelProfilesAuthor_panelHome_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_location.Text = "Ha Noi City.";
            label_panelHome_panelShowingAuthorDetail_form1_aboutThisAuthor.Text = "NarukamiTriTaiBAR";
            label_panelProfilesAuthor_panelHome_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_joinseen.Text = "Join seen 2015";
            Random randomCategorizedToPutPictureInPanelHomeOfAuthorDetail = new Random();
            int randomCar = randomCategorizedToPutPictureInPanelHomeOfAuthorDetail.Next(1, 158);
            int randomInterior = randomCategorizedToPutPictureInPanelHomeOfAuthorDetail.Next(1, 230);
            int randomOceans = randomCategorizedToPutPictureInPanelHomeOfAuthorDetail.Next(1, 187);
            int randomFlower = randomCategorizedToPutPictureInPanelHomeOfAuthorDetail.Next(1, 160);
            int randomMotoBike = randomCategorizedToPutPictureInPanelHomeOfAuthorDetail.Next(1, 243);
            int randomForest = randomCategorizedToPutPictureInPanelHomeOfAuthorDetail.Next(1, 206);
            for (int i = 1; i <= 157; i++)
            {
                if (randomCar == i)
                {
                    pictureBox_panelHome_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_showingHome_1.Image = Image.FromFile(Convert.ToString(dtCar.Rows[randomCar - 1]["Path"]));

                    lstImageInfoScreenMain.Add("Categorized_authorTri_1", dtCar.Rows[randomCar - 1]["Categorized"].ToString());
                    lstImageInfoScreenMain.Add("Path_authorTri_1", dtCar.Rows[randomCar - 1]["Path"].ToString());
                    lstImageInfoScreenMain.Add("Favourites_authorTri_1", dtCar.Rows[randomCar - 1]["Favorites"].ToString());
                    lstImageInfoScreenMain.Add("Comments_authorTri_1", dtCar.Rows[randomCar - 1]["Comments"].ToString());
                    lstImageInfoScreenMain.Add("Views_authorTri_1", dtCar.Rows[randomCar - 1]["Views"].ToString());
                    lstImageInfoScreenMain.Add("Price_authorTri_1", dtCar.Rows[randomCar - 1]["Price"].ToString());
            

                }

            }
            for (int j = 1; j <= 229; j++)
            {
                if (randomInterior == j)
                {
                    pictureBox_panelHome_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_showingHome_2.Image = Image.FromFile(Convert.ToString(dtInterior.Rows[randomInterior - 1]["Path"]));
       
                    lstImageInfoScreenMain.Add("Categorized_authorTri_2", dtInterior.Rows[randomInterior - 1]["Categorized"].ToString());
                    lstImageInfoScreenMain.Add("Path_authorTri_2", dtInterior.Rows[randomInterior - 1]["Path"].ToString());
                    lstImageInfoScreenMain.Add("Favourites_authorTri_2", dtInterior.Rows[randomInterior - 1]["Favorites"].ToString());
                    lstImageInfoScreenMain.Add("Comments_authorTri_2", dtInterior.Rows[randomInterior - 1]["Comments"].ToString());
                    lstImageInfoScreenMain.Add("Views_authorTri_2", dtInterior.Rows[randomInterior - 1]["Views"].ToString());
                    lstImageInfoScreenMain.Add("Price_authorTri_2", dtInterior.Rows[randomInterior - 1]["Price"].ToString());
              
                }
            }
            for (int k = 1; k <= 186; k++)
            {
                if (randomOceans == k)
                {
                    pictureBox_panelHome_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_showingHome_3.Image = Image.FromFile(Convert.ToString(dtOceans.Rows[randomOceans - 1]["Path"]));
     
                    lstImageInfoScreenMain.Add("Categorized_authorTri_3", dtOceans.Rows[randomOceans - 1]["Categorized"].ToString());
                    lstImageInfoScreenMain.Add("Path_authorTri_3", dtOceans.Rows[randomOceans - 1]["Path"].ToString());
                    lstImageInfoScreenMain.Add("Favourites_authorTri_3", dtOceans.Rows[randomOceans - 1]["Favorites"].ToString());
                    lstImageInfoScreenMain.Add("Comments_authorTri_3", dtOceans.Rows[randomOceans - 1]["Comments"].ToString());
                    lstImageInfoScreenMain.Add("Views_authorTri_3", dtOceans.Rows[randomOceans - 1]["Views"].ToString());
                    lstImageInfoScreenMain.Add("Price_authorTri_3", dtOceans.Rows[randomOceans - 1]["Price"].ToString());
                
                }
            }
            for (int p = 1; p <= 159; p++)
            {
                if (randomFlower == p)
                {
                    pictureBox_panelHome_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_showingHome_4.Image = Image.FromFile(Convert.ToString(dtFlower.Rows[randomFlower - 1]["Path"]));
 
                    lstImageInfoScreenMain.Add("Categorized_authorTri_4", dtFlower.Rows[randomFlower - 1]["Categorized"].ToString());
                    lstImageInfoScreenMain.Add("Path_authorTri_4", dtFlower.Rows[randomFlower - 1]["Path"].ToString());
                    lstImageInfoScreenMain.Add("Favourites_authorTri_4", dtFlower.Rows[randomFlower - 1]["Favorites"].ToString());
                    lstImageInfoScreenMain.Add("Comments_authorTri_4", dtFlower.Rows[randomFlower - 1]["Comments"].ToString());
                    lstImageInfoScreenMain.Add("Views_authorTri_4", dtFlower.Rows[randomFlower - 1]["Views"].ToString());
                    lstImageInfoScreenMain.Add("Price_authorTri_4", dtFlower.Rows[randomFlower - 1]["Price"].ToString());
          
                }
            }
            for (int o = 1; o <= 242; o++)
            {
                if (randomMotoBike == o)
                {
                    pictureBox_panelHome_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_showingHome_5.Image = Image.FromFile(Convert.ToString(dtMotoBike.Rows[randomMotoBike - 1]["Path"]));
        
                    lstImageInfoScreenMain.Add("Categorized_authorTri_5", dtMotoBike.Rows[randomMotoBike - 1]["Categorized"].ToString());
                    lstImageInfoScreenMain.Add("Path_authorTri_5", dtMotoBike.Rows[randomMotoBike - 1]["Path"].ToString());
                    lstImageInfoScreenMain.Add("Favourites_authorTri_5", dtMotoBike.Rows[randomMotoBike - 1]["Favorites"].ToString());
                    lstImageInfoScreenMain.Add("Comments_authorTri_5", dtMotoBike.Rows[randomMotoBike - 1]["Comments"].ToString());
                    lstImageInfoScreenMain.Add("Views_authorTri_5", dtMotoBike.Rows[randomMotoBike - 1]["Views"].ToString());
                    lstImageInfoScreenMain.Add("Price_authorTri_5", dtMotoBike.Rows[randomMotoBike - 1]["Price"].ToString());
                 
                }
            }
            for (int u = 1; u <= 205; u++)
            {
                if (randomForest == u)
                {
                    pictureBox_panelHome_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_showingHome_6.Image = Image.FromFile(Convert.ToString(dtForest.Rows[randomForest - 1]["Path"]));
          
                    lstImageInfoScreenMain.Add("Categorized_authorTri_6", dtForest.Rows[randomForest - 1]["Categorized"].ToString());
                    lstImageInfoScreenMain.Add("Path_authorTri_6", dtForest.Rows[randomForest - 1]["Path"].ToString());
                    lstImageInfoScreenMain.Add("Favourites_authorTri_6", dtForest.Rows[randomForest - 1]["Favorites"].ToString());
                    lstImageInfoScreenMain.Add("Comments_authorTri_6", dtForest.Rows[randomForest - 1]["Comments"].ToString());
                    lstImageInfoScreenMain.Add("Views_authorTri_6", dtForest.Rows[randomForest - 1]["Views"].ToString());
                    lstImageInfoScreenMain.Add("Price_authorTri_6", dtForest.Rows[randomForest - 1]["Price"].ToString());
                    


                }
            }
        }

        private void button_click_panelSeeMore_flowLayoutPanelDetailPicture_form1_authorTri_2_Click(object sender, EventArgs e)
        {
            flowLayoutPanelShowingAuthorDetail_form1.Visible = true;
            panelHome_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1.Visible = true;
            flowLayoutPanelDailyAndTrending_form1.Visible = false;
            flowLayoutPanelDetailTopics_form1.Visible = false;
            flowLayoutPanelMain_form1.Visible = false;
            flowLayoutPanelDetailPicture_form1.Visible = false;
            panelGallery_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1.Visible = false;
            label_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_showingAuthorName.Text = "NarukamiTriTaiBAR";
            pictureBox_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_showingAuthorBackground.Image = Image.FromFile(@"../../UsedForInterface/icon/themaldarin.jpg");
            pictureBox_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_showingAuthorAvatar.Image = Image.FromFile(@"../../UsedForInterface/icon/girl.png");
            label_panelProfilesAuthor_panelHome_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_introdution.Text = "Artist  //  Hobbyist   //   DigitalArt  //   Professional  ";
            label_panelProfilesAuthor_panelHome_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_birthday.Text = "August,24";
            label_panelProfilesAuthor_panelHome_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_location.Text = "Ha Noi City.";
            label_panelHome_panelShowingAuthorDetail_form1_aboutThisAuthor.Text = "NarukamiTriTaiBAR";
            label_panelProfilesAuthor_panelHome_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_joinseen.Text = "Join seen 2015";
            Random randomCategorizedToPutPictureInPanelHomeOfAuthorDetail = new Random();
            int randomCar = randomCategorizedToPutPictureInPanelHomeOfAuthorDetail.Next(1, 158);
            int randomInterior = randomCategorizedToPutPictureInPanelHomeOfAuthorDetail.Next(1, 230);
            int randomOceans = randomCategorizedToPutPictureInPanelHomeOfAuthorDetail.Next(1, 187);
            int randomFlower = randomCategorizedToPutPictureInPanelHomeOfAuthorDetail.Next(1, 160);
            int randomMotoBike = randomCategorizedToPutPictureInPanelHomeOfAuthorDetail.Next(1, 243);
            int randomForest = randomCategorizedToPutPictureInPanelHomeOfAuthorDetail.Next(1, 206);
            for (int i = 1; i <= 157; i++)
            {
                if (randomCar == i)
                {
                    pictureBox_panelHome_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_showingHome_1.Image = Image.FromFile(Convert.ToString(dtCar.Rows[randomCar - 1]["Path"]));
                }

            }
            for (int j = 1; j <= 229; j++)
            {
                if (randomInterior == j)
                {
                    pictureBox_panelHome_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_showingHome_2.Image = Image.FromFile(Convert.ToString(dtInterior.Rows[randomInterior - 1]["Path"]));
                }
            }
            for (int k = 1; k <= 186; k++)
            {
                if (randomOceans == k)
                {
                    pictureBox_panelHome_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_showingHome_3.Image = Image.FromFile(Convert.ToString(dtOceans.Rows[randomOceans - 1]["Path"]));
                }
            }
            for (int p = 1; p <= 159; p++)
            {
                if (randomFlower == p)
                {
                    pictureBox_panelHome_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_showingHome_4.Image = Image.FromFile(Convert.ToString(dtFlower.Rows[randomFlower - 1]["Path"]));
                }
            }
            for (int o = 1; o <= 242; o++)
            {
                if (randomMotoBike == o)
                {
                    pictureBox_panelHome_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_showingHome_5.Image = Image.FromFile(Convert.ToString(dtMotoBike.Rows[randomMotoBike - 1]["Path"]));
                }
            }
            for (int u = 1; u <= 205; u++)
            {
                if (randomForest == u)
                {
                    pictureBox_panelHome_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_showingHome_6.Image = Image.FromFile(Convert.ToString(dtForest.Rows[randomForest - 1]["Path"]));
                }
            }
        }


        private void button_click_panelSeeMore_flowLayoutPanelDetailPicture_form1_categorizeRandomByAuthorTri2_Click(object sender, EventArgs e)
        {
            flowLayoutPanelDetailTopics_form1.Visible = true;
            flowLayoutPanelDetailPicture_form1.Visible = false;
            pictureBox_panelBackGround_flowLayoutPanelDetailTopics_form1_showingBackGroundTopics.Image = Image.FromFile(@"../../UsedForInterface/Interiorbackground.jpg");
            label_panelBackGround_flowLayoutPanelDetailTopics_form1_nameTopics.Text = "INTERIOR";
            label_panelBackGround_flowLayoutPanelDetailTopics_form1_describetopics.Text = "Discovery the most modern interior in 2021,eyes catching interior";
            int[] arr = new int[12];
            LetNotDup(1, 230, arr);
            load_random_image(dtInterior, 229, arr[0], arr[1], arr[2], arr[3], arr[4], arr[5], arr[6], arr[7], arr[8], arr[9], arr[10], arr[11]);
        }

        private void button_cliclk_panelDetailAuthor_flowLayoutPanelDetailAuthor_back_Click(object sender, EventArgs e)
        {
            flowLayoutPanelShowingAuthorDetail_form1.Visible = false;
            flowLayoutPanelMain_form1.Visible = true;
        }
        bool Daily = true;
        private void pictureBox_click_panelDashBoard_form1_daily_Click(object sender, EventArgs e)
        {
            flowLayoutPanelDailyAndTrending_form1.Visible = true;
            Daily = true;
            pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_1.Image = Image.FromFile(Convert.ToString(dtCar.Rows[10]["Path"]));
            pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_2.Image = Image.FromFile(Convert.ToString(dtCar.Rows[11]["Path"]));
            pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_3.Image = Image.FromFile(Convert.ToString(dtInterior.Rows[10]["Path"]));
            pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_4.Image = Image.FromFile(Convert.ToString(dtInterior.Rows[11]["Path"]));
            pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_5.Image = Image.FromFile(Convert.ToString(dtForest.Rows[10]["Path"]));
            pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_6.Image = Image.FromFile(Convert.ToString(dtForest.Rows[11]["Path"]));
            pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_7.Image = Image.FromFile(Convert.ToString(dtOceans.Rows[10]["Path"]));
            pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_8.Image = Image.FromFile(Convert.ToString(dtOceans.Rows[11]["Path"]));
            pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_9.Image = Image.FromFile(Convert.ToString(dtMotoBike.Rows[10]["Path"]));
            pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_10.Image = Image.FromFile(Convert.ToString(dtMotoBike.Rows[11]["Path"]));
            pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_11.Image = Image.FromFile(Convert.ToString(dtFlower.Rows[10]["Path"]));
            pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_12.Image = Image.FromFile(Convert.ToString(dtFlower.Rows[11]["Path"]));
            /////////Dic1daily
            
            lstImageInfoScreenMain.Add("Categorized_dailytrending1", dtCar.Rows[10]["Categorized"].ToString());
            lstImageInfoScreenMain.Add("Path_dailytrending1", dtCar.Rows[10]["Path"].ToString());
            lstImageInfoScreenMain.Add("Favourites_dailytrending1", dtCar.Rows[10]["Favorites"].ToString());
            lstImageInfoScreenMain.Add("Comments_dailytrending1", dtCar.Rows[10]["Comments"].ToString());
            lstImageInfoScreenMain.Add("Views_dailytrending1", dtCar.Rows[10]["Views"].ToString());
            lstImageInfoScreenMain.Add("Price_dailytrending1", dtCar.Rows[10]["Price"].ToString());
 
            /////////Dic2daily
            lstImageInfoScreenMain.Add("Categorized_dailytrending2", dtCar.Rows[11]["Categorized"].ToString());
            lstImageInfoScreenMain.Add("Path_dailytrending2", dtCar.Rows[11]["Path"].ToString());
            lstImageInfoScreenMain.Add("Favourites_dailytrending2", dtCar.Rows[11]["Favorites"].ToString());
            lstImageInfoScreenMain.Add("Comments_dailytrending2", dtCar.Rows[11]["Comments"].ToString());
            lstImageInfoScreenMain.Add("Views_dailytrending2", dtCar.Rows[11]["Views"].ToString());
            lstImageInfoScreenMain.Add("Price_dailytrending2", dtCar.Rows[11]["Price"].ToString());
     
            /////////Dic3daily
            lstImageInfoScreenMain.Add("Categorized_dailytreding3", dtInterior.Rows[10]["Categorized"].ToString());
            lstImageInfoScreenMain.Add("Path_dailytrending3", dtInterior.Rows[10]["Path"].ToString());
            lstImageInfoScreenMain.Add("Favourites_dailytrending3", dtInterior.Rows[10]["Favorites"].ToString());
            lstImageInfoScreenMain.Add("Comments_dailytrending3", dtInterior.Rows[10]["Comments"].ToString());
            lstImageInfoScreenMain.Add("Views_dailytrending3", dtInterior.Rows[10]["Views"].ToString());
            lstImageInfoScreenMain.Add("Price_dailytrending3", dtInterior.Rows[10]["Price"].ToString());
    
            /////////Dic4daily
            lstImageInfoScreenMain.Add("Categorized_dailytrending", dtInterior.Rows[11]["Categorized"].ToString());
            lstImageInfoScreenMain.Add("Path_dailytrending4", dtInterior.Rows[11]["Path"].ToString());
            lstImageInfoScreenMain.Add("Favourites_dailytrending4", dtInterior.Rows[11]["Favorites"].ToString());
            lstImageInfoScreenMain.Add("Comments_dailytrending4", dtInterior.Rows[11]["Comments"].ToString());
            lstImageInfoScreenMain.Add("Views_dailytrending4", dtInterior.Rows[11]["Views"].ToString());
            lstImageInfoScreenMain.Add("Price_dailytrending4", dtInterior.Rows[11]["Price"].ToString());
        
            /////////Dic5daily
            lstImageInfoScreenMain.Add("Categorized_dailytrending5", dtForest.Rows[10]["Categorized"].ToString());
            lstImageInfoScreenMain.Add("Path_dailytrending5", dtForest.Rows[10]["Path"].ToString());
            lstImageInfoScreenMain.Add("Favourites_dailytrending5", dtForest.Rows[10]["Favorites"].ToString());
            lstImageInfoScreenMain.Add("Comments_dailytrending5", dtForest.Rows[10]["Comments"].ToString());
            lstImageInfoScreenMain.Add("Views_dailytrending5", dtForest.Rows[10]["Views"].ToString());
            lstImageInfoScreenMain.Add("Price_dailytrending5", dtForest.Rows[10]["Price"].ToString());

            /////////Dic6daily
            lstImageInfoScreenMain.Add("Categorized_dailytrending6", dtForest.Rows[11]["Categorized"].ToString());
            lstImageInfoScreenMain.Add("Path_dailytrending6", dtForest.Rows[11]["Path"].ToString());
            lstImageInfoScreenMain.Add("Favourites_dailytrending6", dtForest.Rows[11]["Favorites"].ToString());
            lstImageInfoScreenMain.Add("Comments_dailytrending6", dtForest.Rows[11]["Comments"].ToString());
            lstImageInfoScreenMain.Add("Views_dailytrending6", dtForest.Rows[11]["Views"].ToString());
            lstImageInfoScreenMain.Add("Price_dailytrending6", dtForest.Rows[11]["Price"].ToString());

            /////////Dic7daily
            lstImageInfoScreenMain.Add("Categorized_dailytrending7", dtOceans.Rows[10]["Categorized"].ToString());
            lstImageInfoScreenMain.Add("Path_dailytrending7", dtOceans.Rows[10]["Path"].ToString());
            lstImageInfoScreenMain.Add("Favourites_dailytrending7", dtOceans.Rows[10]["Favorites"].ToString());
            lstImageInfoScreenMain.Add("Comments_dailytrending7", dtOceans.Rows[10]["Comments"].ToString());
            lstImageInfoScreenMain.Add("Views_dailytrending7", dtOceans.Rows[10]["Views"].ToString());
            lstImageInfoScreenMain.Add("Price_dailytrending7", dtOceans.Rows[10]["Price"].ToString());

            /////////Dic8daily
            lstImageInfoScreenMain.Add("Categorized_dailytrending8", dtOceans.Rows[11]["Categorized"].ToString());
            lstImageInfoScreenMain.Add("Path_dailytrending8", dtOceans.Rows[11]["Path"].ToString());
            lstImageInfoScreenMain.Add("Favourites_dailytrending8", dtOceans.Rows[11]["Favorites"].ToString());
            lstImageInfoScreenMain.Add("Comments_dailytrending8", dtOceans.Rows[11]["Comments"].ToString());
            lstImageInfoScreenMain.Add("Views_dailytrending8", dtOceans.Rows[11]["Views"].ToString());
            lstImageInfoScreenMain.Add("Price_dailytrending8", dtOceans.Rows[11]["Price"].ToString());

            /////////Dic9daily
            lstImageInfoScreenMain.Add("Categorized_dailytrending9", dtMotoBike.Rows[10]["Categorized"].ToString());
            lstImageInfoScreenMain.Add("Path_dailytrending9", dtMotoBike.Rows[10]["Path"].ToString());
            lstImageInfoScreenMain.Add("Favourites_dailytrending9", dtMotoBike.Rows[10]["Favorites"].ToString());
            lstImageInfoScreenMain.Add("Comments_dailytrending9", dtMotoBike.Rows[10]["Comments"].ToString());
            lstImageInfoScreenMain.Add("Views_dailytrending9", dtMotoBike.Rows[10]["Views"].ToString());
            lstImageInfoScreenMain.Add("Price_dailytrending9", dtMotoBike.Rows[10]["Price"].ToString());

            /////////Dic10daily
            lstImageInfoScreenMain.Add("Categorized_dailytrending10", dtMotoBike.Rows[11]["Categorized"].ToString());
            lstImageInfoScreenMain.Add("Path_dailytrending10", dtMotoBike.Rows[11]["Path"].ToString());
            lstImageInfoScreenMain.Add("Favourites_dailytrending10", dtMotoBike.Rows[11]["Favorites"].ToString());
            lstImageInfoScreenMain.Add("Comments_dailytrending10", dtMotoBike.Rows[11]["Comments"].ToString());
            lstImageInfoScreenMain.Add("Views_dailytrending10", dtMotoBike.Rows[11]["Views"].ToString());
            lstImageInfoScreenMain.Add("Price_dailytrending10", dtMotoBike.Rows[11]["Price"].ToString());
      
            /////////Dic11daily
            lstImageInfoScreenMain.Add("Categorized_dailytrending11", dtFlower.Rows[10]["Categorized"].ToString());
            lstImageInfoScreenMain.Add("Path_dailytrending11", dtFlower.Rows[10]["Path"].ToString());
            lstImageInfoScreenMain.Add("Favourites_dailytrending11", dtFlower.Rows[10]["Favorites"].ToString());
            lstImageInfoScreenMain.Add("Comments_dailytrending11", dtFlower.Rows[10]["Comments"].ToString());
            lstImageInfoScreenMain.Add("Views_dailytrending11", dtFlower.Rows[10]["Views"].ToString());
            lstImageInfoScreenMain.Add("Price_dailytrending11", dtFlower.Rows[10]["Price"].ToString());
           
            /////////Dic12daily
            lstImageInfoScreenMain.Add("Categorized_dailytreding12", dtFlower.Rows[11]["Categorized"].ToString());
            lstImageInfoScreenMain.Add("Path_dailytrending12", dtFlower.Rows[11]["Path"].ToString());
            lstImageInfoScreenMain.Add("Favourites_dailytrending12", dtFlower.Rows[11]["Favorites"].ToString());
            lstImageInfoScreenMain.Add("Comments_dailytrending12", dtFlower.Rows[11]["Comments"].ToString());
            lstImageInfoScreenMain.Add("Views_dailytrending12", dtFlower.Rows[11]["Views"].ToString());
            lstImageInfoScreenMain.Add("Price_dailytrending12", dtFlower.Rows[11]["Price"].ToString());

        }

        private void pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_1_Click(object sender, EventArgs e)
        {
            flowLayoutPanelDetailPicture_form1.Visible = true;
            flowLayoutPanelDailyAndTrending_form1.Visible = false;
            pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_1.Image;
            danhgiau_pictureBoxShowing = 64;
            button_click_panelDetailPicture_flowLayoutPanelDetailPicture_form1_tags_1.Text = "CAR";
            button_click_panelDetailPicture_Favourites.Text = lstImageInfoScreenMain["Favourites_dailytrending1"].ToString();
            button_click_panelDetailPicture_Comments.Text = lstImageInfoScreenMain["Comments_dailytrending1"].ToString();
            button_click_panelDetailPicture_Views.Text = lstImageInfoScreenMain["Views_dailytrending1"].ToString();
            if (lstImageInfoScreenMain["Price_dailytrending1"].ToString() == "0")
            {
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Text = "Free";
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Image = Image.FromFile(@"../../UsedForInterface/icon/free.png");

            }
            else if (lstImageInfoScreenMain["Price_dailytrending1"].ToString() == "1")
            {
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Text = "Costly";
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Image = Image.FromFile(@"../../UsedForInterface/icon/premium-quality.png");
            }
        }

        private void pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_2_Click(object sender, EventArgs e)
        {
            flowLayoutPanelDetailPicture_form1.Visible = true;
            flowLayoutPanelDailyAndTrending_form1.Visible = false;
            pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_2.Image;
            danhgiau_pictureBoxShowing = 65;
            button_click_panelDetailPicture_flowLayoutPanelDetailPicture_form1_tags_1.Text = "CAR";
            button_click_panelDetailPicture_Favourites.Text = lstImageInfoScreenMain["Favourites_dailytrending2"].ToString();
            button_click_panelDetailPicture_Comments.Text = lstImageInfoScreenMain["Comments_dailytrending2"].ToString();
            button_click_panelDetailPicture_Views.Text = lstImageInfoScreenMain["Views_dailytrending2"].ToString();
            if (lstImageInfoScreenMain["Price_dailytrending2"].ToString() == "0")
            {
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Text = "Free";
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Image = Image.FromFile(@"../../UsedForInterface/icon/free.png");

            }
            else if (lstImageInfoScreenMain["Price_dailytrending2"].ToString() == "1")
            {
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Text = "Costly";
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Image = Image.FromFile(@"../../UsedForInterface/icon/premium-quality.png");
            }
        }

        private void pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_3_Click(object sender, EventArgs e)
        {
            flowLayoutPanelDetailPicture_form1.Visible = true;
            flowLayoutPanelDailyAndTrending_form1.Visible = false;
            pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_3.Image;
            danhgiau_pictureBoxShowing = 66;
            button_click_panelDetailPicture_flowLayoutPanelDetailPicture_form1_tags_1.Text = "INTERIOR";
            button_click_panelDetailPicture_Favourites.Text = lstImageInfoScreenMain["Favourites_dailytrending3"].ToString();
            button_click_panelDetailPicture_Comments.Text = lstImageInfoScreenMain["Comments_dailytrending3"].ToString();
            button_click_panelDetailPicture_Views.Text = lstImageInfoScreenMain["Views_dailytrending3"].ToString();
            if (lstImageInfoScreenMain["Price_dailytrending3"].ToString() == "0")
            {
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Text = "Free";
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Image = Image.FromFile(@"../../UsedForInterface/icon/free.png");

            }
            else if (lstImageInfoScreenMain["Price_dailytrending3"].ToString() == "1")
            {
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Text = "Costly";
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Image = Image.FromFile(@"../../UsedForInterface/icon/premium-quality.png");
            }
        }

        private void pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_4_Click(object sender, EventArgs e)
        {
            flowLayoutPanelDetailPicture_form1.Visible = true;
            flowLayoutPanelDailyAndTrending_form1.Visible = false;
            pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_4.Image;
            danhgiau_pictureBoxShowing = 67;
            button_click_panelDetailPicture_flowLayoutPanelDetailPicture_form1_tags_1.Text = "INTERIOR";
            button_click_panelDetailPicture_Favourites.Text = lstImageInfoScreenMain["Favourites_dailytrending4"].ToString();
            button_click_panelDetailPicture_Comments.Text = lstImageInfoScreenMain["Comments_dailytrending4"].ToString();
            button_click_panelDetailPicture_Views.Text = lstImageInfoScreenMain["Views_dailytrending4"].ToString();
            if (lstImageInfoScreenMain["Price_dailytrending4"].ToString() == "0")
            {
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Text = "Free";
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Image = Image.FromFile(@"../../UsedForInterface/icon/free.png");

            }
            else if (lstImageInfoScreenMain["Price_dailytrending4"].ToString() == "1")
            {
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Text = "Costly";
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Image = Image.FromFile(@"../../UsedForInterface/icon/premium-quality.png");
            }
        }

        private void pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_5_Click(object sender, EventArgs e)
        {
            flowLayoutPanelDetailPicture_form1.Visible = true;
            flowLayoutPanelDailyAndTrending_form1.Visible = false;
            pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_5.Image;
            danhgiau_pictureBoxShowing = 68;
            button_click_panelDetailPicture_flowLayoutPanelDetailPicture_form1_tags_1.Text = "FOREST";
            button_click_panelDetailPicture_Favourites.Text = lstImageInfoScreenMain["Favourites_dailytrending5"].ToString();
            button_click_panelDetailPicture_Comments.Text = lstImageInfoScreenMain["Comments_dailytrending5"].ToString();
            button_click_panelDetailPicture_Views.Text = lstImageInfoScreenMain["Views_dailytrending5"].ToString();
            if (lstImageInfoScreenMain["Price_dailytrending5"].ToString() == "0")
            {
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Text = "Free";
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Image = Image.FromFile(@"../../UsedForInterface/icon/free.png");

            }
            else if (lstImageInfoScreenMain["Price_dailytrending5"].ToString() == "1")
            {
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Text = "Costly";
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Image = Image.FromFile(@"../../UsedForInterface/icon/premium-quality.png");
            }
        }

        private void pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_6_Click(object sender, EventArgs e)
        {
            flowLayoutPanelDetailPicture_form1.Visible = true;
            flowLayoutPanelDailyAndTrending_form1.Visible = false;
            pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_6.Image;
            danhgiau_pictureBoxShowing = 69;
            button_click_panelDetailPicture_flowLayoutPanelDetailPicture_form1_tags_1.Text = "FOREST";
            button_click_panelDetailPicture_Favourites.Text = lstImageInfoScreenMain["Favourites_dailytrending6"].ToString();
            button_click_panelDetailPicture_Comments.Text = lstImageInfoScreenMain["Comments_dailytrending6"].ToString();
            button_click_panelDetailPicture_Views.Text = lstImageInfoScreenMain["Views_dailytrending6"].ToString();
            if (lstImageInfoScreenMain["Price_dailytrending6"].ToString() == "0")
            {
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Text = "Free";
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Image = Image.FromFile(@"../../UsedForInterface/icon/free.png");

            }
            else if (lstImageInfoScreenMain["Price_dailytrending6"].ToString() == "1")
            {
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Text = "Costly";
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Image = Image.FromFile(@"../../UsedForInterface/icon/premium-quality.png");
            }
        }

        private void pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_7_Click(object sender, EventArgs e)
        {
            flowLayoutPanelDetailPicture_form1.Visible = true;
            flowLayoutPanelDailyAndTrending_form1.Visible = false;
            pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_7.Image;
            danhgiau_pictureBoxShowing = 70;
            button_click_panelDetailPicture_flowLayoutPanelDetailPicture_form1_tags_1.Text = "OCEANS";
            button_click_panelDetailPicture_Favourites.Text = lstImageInfoScreenMain["Favourites_dailytrending7"].ToString();
            button_click_panelDetailPicture_Comments.Text = lstImageInfoScreenMain["Comments_dailytrending7"].ToString();
            button_click_panelDetailPicture_Views.Text = lstImageInfoScreenMain["Views_dailytrending7"].ToString();
            if (lstImageInfoScreenMain["Price_dailytrending7"].ToString() == "0")
            {
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Text = "Free";
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Image = Image.FromFile(@"../../UsedForInterface/icon/free.png");

            }
            else if (lstImageInfoScreenMain["Price_dailytrending7"].ToString() == "1")
            {
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Text = "Costly";
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Image = Image.FromFile(@"../../UsedForInterface/icon/premium-quality.png");
            }
        }

        private void pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_8_Click(object sender, EventArgs e)
        {
            flowLayoutPanelDetailPicture_form1.Visible = true;
            flowLayoutPanelDailyAndTrending_form1.Visible = false;
            pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_8.Image;
            danhgiau_pictureBoxShowing = 71;
            button_click_panelDetailPicture_flowLayoutPanelDetailPicture_form1_tags_1.Text = "OCEANS";
            button_click_panelDetailPicture_Favourites.Text = lstImageInfoScreenMain["Favourites_dailytrending8"].ToString();
            button_click_panelDetailPicture_Comments.Text = lstImageInfoScreenMain["Comments_dailytrending8"].ToString();
            button_click_panelDetailPicture_Views.Text = lstImageInfoScreenMain["Views_dailytrending8"].ToString();
            if (lstImageInfoScreenMain["Price_dailytrending8"].ToString() == "0")
            {
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Text = "Free";
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Image = Image.FromFile(@"../../UsedForInterface/icon/free.png");

            }
            else if (lstImageInfoScreenMain["Price_dailytrending8"].ToString() == "1")
            {
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Text = "Costly";
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Image = Image.FromFile(@"../../UsedForInterface/icon/premium-quality.png");
            }
        }

        private void pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_9_Click(object sender, EventArgs e)
        {
            flowLayoutPanelDetailPicture_form1.Visible = true;
            flowLayoutPanelDailyAndTrending_form1.Visible = false;
            pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_9.Image;
            danhgiau_pictureBoxShowing = 72;
            button_click_panelDetailPicture_flowLayoutPanelDetailPicture_form1_tags_1.Text = "MOTOBIKE";
            button_click_panelDetailPicture_Favourites.Text = lstImageInfoScreenMain["Favourites_dailytrending9"].ToString();
            button_click_panelDetailPicture_Comments.Text = lstImageInfoScreenMain["Comments_dailytrending9"].ToString();
            button_click_panelDetailPicture_Views.Text = lstImageInfoScreenMain["Views_dailytrending9"].ToString();
            if (lstImageInfoScreenMain["Price_dailytrending9"].ToString() == "0")
            {
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Text = "Free";
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Image = Image.FromFile(@"../../UsedForInterface/icon/free.png");

            }
            else if (lstImageInfoScreenMain["Price_dailytrending9"].ToString() == "1")
            {
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Text = "Costly";
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Image = Image.FromFile(@"../../UsedForInterface/icon/premium-quality.png");
            }
        }

        private void pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_10_Click(object sender, EventArgs e)
        {
            flowLayoutPanelDetailPicture_form1.Visible = true;
            flowLayoutPanelDailyAndTrending_form1.Visible = false;
            pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_10.Image;
            danhgiau_pictureBoxShowing = 73;
            button_click_panelDetailPicture_flowLayoutPanelDetailPicture_form1_tags_1.Text = "MOTOBIKE";
            button_click_panelDetailPicture_Favourites.Text = lstImageInfoScreenMain["Favourites_dailytrending10"].ToString();
            button_click_panelDetailPicture_Comments.Text = lstImageInfoScreenMain["Comments_dailytrending10"].ToString();
            button_click_panelDetailPicture_Views.Text = lstImageInfoScreenMain["Views_dailytrending10"].ToString();
            if (lstImageInfoScreenMain["Price_dailytrending10"].ToString() == "0")
            {
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Text = "Free";
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Image = Image.FromFile(@"../../UsedForInterface/icon/free.png");

            }
            else if (lstImageInfoScreenMain["Price_dailytrending10"].ToString() == "1")
            {
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Text = "Costly";
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Image = Image.FromFile(@"../../UsedForInterface/icon/premium-quality.png");
            }
        }

        private void pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_11_Click(object sender, EventArgs e)
        {
            flowLayoutPanelDetailPicture_form1.Visible = true;
            flowLayoutPanelDailyAndTrending_form1.Visible = false;
            pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_11.Image;
            danhgiau_pictureBoxShowing = 74;
            button_click_panelDetailPicture_flowLayoutPanelDetailPicture_form1_tags_1.Text = "FLOWER";
            button_click_panelDetailPicture_Favourites.Text = lstImageInfoScreenMain["Favourites_dailytrending11"].ToString();
            button_click_panelDetailPicture_Comments.Text = lstImageInfoScreenMain["Comments_dailytrending11"].ToString();
            button_click_panelDetailPicture_Views.Text = lstImageInfoScreenMain["Views_dailytrending11"].ToString();
            if (lstImageInfoScreenMain["Price_dailytrending11"].ToString() == "0")
            {
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Text = "Free";
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Image = Image.FromFile(@"../../UsedForInterface/icon/free.png");

            }
            else if (lstImageInfoScreenMain["Price_dailytrending11"].ToString() == "1")
            {
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Text = "Costly";
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Image = Image.FromFile(@"../../UsedForInterface/icon/premium-quality.png");
            }
        }

        private void pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_12_Click(object sender, EventArgs e)
        {
            flowLayoutPanelDetailPicture_form1.Visible = true;
            flowLayoutPanelDailyAndTrending_form1.Visible = false;
            pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_12.Image;
            danhgiau_pictureBoxShowing = 75;

            button_click_panelDetailPicture_flowLayoutPanelDetailPicture_form1_tags_1.Text = "FLOWER";
            button_click_panelDetailPicture_Favourites.Text = lstImageInfoScreenMain["Favourites_dailytrending12"].ToString();
            button_click_panelDetailPicture_Comments.Text = lstImageInfoScreenMain["Comments_dailytrending12"].ToString();
            button_click_panelDetailPicture_Views.Text = lstImageInfoScreenMain["Views_dailytrending12"].ToString();
            if (lstImageInfoScreenMain["Price_dailytrending12"].ToString() == "0")
            {
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Text = "Free";
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Image = Image.FromFile(@"../../UsedForInterface/icon/free.png");

            }
            else if (lstImageInfoScreenMain["Price_dailytrending12"].ToString() == "1")
            {
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Text = "Costly";
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Image = Image.FromFile(@"../../UsedForInterface/icon/premium-quality.png");
            }
        }

        private void pictureBox_click_panelDashBoard_form1_trending_Click(object sender, EventArgs e)
        {
            flowLayoutPanelDailyAndTrending_form1.Visible = true;
            Daily = false;
            pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_1.Image = Image.FromFile(Convert.ToString(dtCar.Rows[50]["Path"]));
            pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_2.Image = Image.FromFile(Convert.ToString(dtCar.Rows[51]["Path"]));
            pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_3.Image = Image.FromFile(Convert.ToString(dtInterior.Rows[50]["Path"]));
            pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_4.Image = Image.FromFile(Convert.ToString(dtInterior.Rows[51]["Path"]));
            pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_5.Image = Image.FromFile(Convert.ToString(dtForest.Rows[50]["Path"]));
            pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_6.Image = Image.FromFile(Convert.ToString(dtForest.Rows[51]["Path"]));
            pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_7.Image = Image.FromFile(Convert.ToString(dtOceans.Rows[50]["Path"]));
            pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_8.Image = Image.FromFile(Convert.ToString(dtOceans.Rows[51]["Path"]));
            pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_9.Image = Image.FromFile(Convert.ToString(dtMotoBike.Rows[50]["Path"]));
            pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_10.Image = Image.FromFile(Convert.ToString(dtMotoBike.Rows[51]["Path"]));
            pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_11.Image = Image.FromFile(Convert.ToString(dtFlower.Rows[50]["Path"]));
            pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_12.Image = Image.FromFile(Convert.ToString(dtFlower.Rows[51]["Path"]));
        }
        int PageDailyAndTrending = 1;
        private void button_click_panelPageChange_flowLayoutPanelDailyAndTrending_form1_left_Click(object sender, EventArgs e)
        {
            --PageDailyAndTrending;
            if(PageDailyAndTrending<1)
            {
                PageDailyAndTrending = 1;
            }
            int left = PageDailyAndTrending;
            button_click_panelPageChange_flowLayoutPanelDailyAndTrending_form1_page.Text = Convert.ToString(left);
            flowLayoutPanelDailyAndTrending_form1.Visible = true;
            if (Daily)
            {
                switch (PageDailyAndTrending)
                {
                    case 1:
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_1.Image = Image.FromFile(Convert.ToString(dtCar.Rows[10]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_2.Image = Image.FromFile(Convert.ToString(dtCar.Rows[11]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_3.Image = Image.FromFile(Convert.ToString(dtInterior.Rows[10]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_4.Image = Image.FromFile(Convert.ToString(dtInterior.Rows[11]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_5.Image = Image.FromFile(Convert.ToString(dtForest.Rows[10]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_6.Image = Image.FromFile(Convert.ToString(dtForest.Rows[11]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_7.Image = Image.FromFile(Convert.ToString(dtOceans.Rows[10]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_8.Image = Image.FromFile(Convert.ToString(dtOceans.Rows[11]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_9.Image = Image.FromFile(Convert.ToString(dtMotoBike.Rows[10]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_10.Image = Image.FromFile(Convert.ToString(dtMotoBike.Rows[11]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_11.Image = Image.FromFile(Convert.ToString(dtFlower.Rows[10]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_12.Image = Image.FromFile(Convert.ToString(dtFlower.Rows[11]["Path"]));
                        break;
                    case 2:
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_1.Image = Image.FromFile(Convert.ToString(dtCar.Rows[12]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_2.Image = Image.FromFile(Convert.ToString(dtCar.Rows[13]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_3.Image = Image.FromFile(Convert.ToString(dtInterior.Rows[12]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_4.Image = Image.FromFile(Convert.ToString(dtInterior.Rows[13]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_5.Image = Image.FromFile(Convert.ToString(dtForest.Rows[12]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_6.Image = Image.FromFile(Convert.ToString(dtForest.Rows[13]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_7.Image = Image.FromFile(Convert.ToString(dtOceans.Rows[12]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_8.Image = Image.FromFile(Convert.ToString(dtOceans.Rows[13]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_9.Image = Image.FromFile(Convert.ToString(dtMotoBike.Rows[12]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_10.Image = Image.FromFile(Convert.ToString(dtMotoBike.Rows[13]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_11.Image = Image.FromFile(Convert.ToString(dtFlower.Rows[12]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_12.Image = Image.FromFile(Convert.ToString(dtFlower.Rows[13]["Path"]));
                        break;
                    case 3:
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_1.Image = Image.FromFile(Convert.ToString(dtCar.Rows[14]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_2.Image = Image.FromFile(Convert.ToString(dtCar.Rows[15]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_3.Image = Image.FromFile(Convert.ToString(dtInterior.Rows[14]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_4.Image = Image.FromFile(Convert.ToString(dtInterior.Rows[15]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_5.Image = Image.FromFile(Convert.ToString(dtForest.Rows[14]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_6.Image = Image.FromFile(Convert.ToString(dtForest.Rows[15]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_7.Image = Image.FromFile(Convert.ToString(dtOceans.Rows[14]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_8.Image = Image.FromFile(Convert.ToString(dtOceans.Rows[15]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_9.Image = Image.FromFile(Convert.ToString(dtMotoBike.Rows[14]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_10.Image = Image.FromFile(Convert.ToString(dtMotoBike.Rows[15]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_11.Image = Image.FromFile(Convert.ToString(dtFlower.Rows[14]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_12.Image = Image.FromFile(Convert.ToString(dtFlower.Rows[15]["Path"]));
                        break;
                    case 4:
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_1.Image = Image.FromFile(Convert.ToString(dtCar.Rows[16]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_2.Image = Image.FromFile(Convert.ToString(dtCar.Rows[17]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_3.Image = Image.FromFile(Convert.ToString(dtInterior.Rows[16]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_4.Image = Image.FromFile(Convert.ToString(dtInterior.Rows[17]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_5.Image = Image.FromFile(Convert.ToString(dtForest.Rows[16]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_6.Image = Image.FromFile(Convert.ToString(dtForest.Rows[17]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_7.Image = Image.FromFile(Convert.ToString(dtOceans.Rows[16]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_8.Image = Image.FromFile(Convert.ToString(dtOceans.Rows[17]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_9.Image = Image.FromFile(Convert.ToString(dtMotoBike.Rows[16]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_10.Image = Image.FromFile(Convert.ToString(dtMotoBike.Rows[17]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_11.Image = Image.FromFile(Convert.ToString(dtFlower.Rows[16]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_12.Image = Image.FromFile(Convert.ToString(dtFlower.Rows[17]["Path"]));
                        break;
                    case 5:
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_1.Image = Image.FromFile(Convert.ToString(dtCar.Rows[18]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_2.Image = Image.FromFile(Convert.ToString(dtCar.Rows[19]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_3.Image = Image.FromFile(Convert.ToString(dtInterior.Rows[18]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_4.Image = Image.FromFile(Convert.ToString(dtInterior.Rows[19]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_5.Image = Image.FromFile(Convert.ToString(dtForest.Rows[18]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_6.Image = Image.FromFile(Convert.ToString(dtForest.Rows[19]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_7.Image = Image.FromFile(Convert.ToString(dtOceans.Rows[18]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_8.Image = Image.FromFile(Convert.ToString(dtOceans.Rows[19]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_9.Image = Image.FromFile(Convert.ToString(dtMotoBike.Rows[18]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_10.Image = Image.FromFile(Convert.ToString(dtMotoBike.Rows[19]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_11.Image = Image.FromFile(Convert.ToString(dtFlower.Rows[18]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_12.Image = Image.FromFile(Convert.ToString(dtFlower.Rows[19]["Path"]));
                        break;
                    case 6:
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_1.Image = Image.FromFile(Convert.ToString(dtCar.Rows[20]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_2.Image = Image.FromFile(Convert.ToString(dtCar.Rows[21]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_3.Image = Image.FromFile(Convert.ToString(dtInterior.Rows[20]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_4.Image = Image.FromFile(Convert.ToString(dtInterior.Rows[21]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_5.Image = Image.FromFile(Convert.ToString(dtForest.Rows[20]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_6.Image = Image.FromFile(Convert.ToString(dtForest.Rows[21]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_7.Image = Image.FromFile(Convert.ToString(dtOceans.Rows[20]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_8.Image = Image.FromFile(Convert.ToString(dtOceans.Rows[21]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_9.Image = Image.FromFile(Convert.ToString(dtMotoBike.Rows[20]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_10.Image = Image.FromFile(Convert.ToString(dtMotoBike.Rows[21]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_11.Image = Image.FromFile(Convert.ToString(dtFlower.Rows[20]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_12.Image = Image.FromFile(Convert.ToString(dtFlower.Rows[21]["Path"]));
                        break;
                    case 7:
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_1.Image = Image.FromFile(Convert.ToString(dtCar.Rows[22]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_2.Image = Image.FromFile(Convert.ToString(dtCar.Rows[23]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_3.Image = Image.FromFile(Convert.ToString(dtInterior.Rows[22]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_4.Image = Image.FromFile(Convert.ToString(dtInterior.Rows[23]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_5.Image = Image.FromFile(Convert.ToString(dtForest.Rows[22]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_6.Image = Image.FromFile(Convert.ToString(dtForest.Rows[23]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_7.Image = Image.FromFile(Convert.ToString(dtOceans.Rows[22]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_8.Image = Image.FromFile(Convert.ToString(dtOceans.Rows[23]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_9.Image = Image.FromFile(Convert.ToString(dtMotoBike.Rows[22]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_10.Image = Image.FromFile(Convert.ToString(dtMotoBike.Rows[23]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_11.Image = Image.FromFile(Convert.ToString(dtFlower.Rows[22]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_12.Image = Image.FromFile(Convert.ToString(dtFlower.Rows[23]["Path"]));
                        break;
                    default:
                        PageDailyAndTrending = 0;
                        break;
                }
            }
            else if(Daily==false)
            {
                switch (PageDailyAndTrending)
                {
                    case 1:
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_1.Image = Image.FromFile(Convert.ToString(dtCar.Rows[50]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_2.Image = Image.FromFile(Convert.ToString(dtCar.Rows[51]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_3.Image = Image.FromFile(Convert.ToString(dtInterior.Rows[50]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_4.Image = Image.FromFile(Convert.ToString(dtInterior.Rows[51]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_5.Image = Image.FromFile(Convert.ToString(dtForest.Rows[50]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_6.Image = Image.FromFile(Convert.ToString(dtForest.Rows[51]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_7.Image = Image.FromFile(Convert.ToString(dtOceans.Rows[50]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_8.Image = Image.FromFile(Convert.ToString(dtOceans.Rows[51]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_9.Image = Image.FromFile(Convert.ToString(dtMotoBike.Rows[50]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_10.Image = Image.FromFile(Convert.ToString(dtMotoBike.Rows[51]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_11.Image = Image.FromFile(Convert.ToString(dtFlower.Rows[50]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_12.Image = Image.FromFile(Convert.ToString(dtFlower.Rows[51]["Path"]));
                        break;
                    case 2:
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_1.Image = Image.FromFile(Convert.ToString(dtCar.Rows[52]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_2.Image = Image.FromFile(Convert.ToString(dtCar.Rows[53]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_3.Image = Image.FromFile(Convert.ToString(dtInterior.Rows[52]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_4.Image = Image.FromFile(Convert.ToString(dtInterior.Rows[53]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_5.Image = Image.FromFile(Convert.ToString(dtForest.Rows[52]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_6.Image = Image.FromFile(Convert.ToString(dtForest.Rows[53]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_7.Image = Image.FromFile(Convert.ToString(dtOceans.Rows[52]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_8.Image = Image.FromFile(Convert.ToString(dtOceans.Rows[53]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_9.Image = Image.FromFile(Convert.ToString(dtMotoBike.Rows[52]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_10.Image = Image.FromFile(Convert.ToString(dtMotoBike.Rows[53]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_11.Image = Image.FromFile(Convert.ToString(dtFlower.Rows[52]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_12.Image = Image.FromFile(Convert.ToString(dtFlower.Rows[53]["Path"]));
                        break;
                    case 3:
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_1.Image = Image.FromFile(Convert.ToString(dtCar.Rows[54]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_2.Image = Image.FromFile(Convert.ToString(dtCar.Rows[55]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_3.Image = Image.FromFile(Convert.ToString(dtInterior.Rows[54]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_4.Image = Image.FromFile(Convert.ToString(dtInterior.Rows[55]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_5.Image = Image.FromFile(Convert.ToString(dtForest.Rows[54]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_6.Image = Image.FromFile(Convert.ToString(dtForest.Rows[55]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_7.Image = Image.FromFile(Convert.ToString(dtOceans.Rows[54]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_8.Image = Image.FromFile(Convert.ToString(dtOceans.Rows[55]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_9.Image = Image.FromFile(Convert.ToString(dtMotoBike.Rows[54]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_10.Image = Image.FromFile(Convert.ToString(dtMotoBike.Rows[55]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_11.Image = Image.FromFile(Convert.ToString(dtFlower.Rows[54]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_12.Image = Image.FromFile(Convert.ToString(dtFlower.Rows[55]["Path"]));
                        break;
                    case 4:
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_1.Image = Image.FromFile(Convert.ToString(dtCar.Rows[56]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_2.Image = Image.FromFile(Convert.ToString(dtCar.Rows[57]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_3.Image = Image.FromFile(Convert.ToString(dtInterior.Rows[56]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_4.Image = Image.FromFile(Convert.ToString(dtInterior.Rows[57]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_5.Image = Image.FromFile(Convert.ToString(dtForest.Rows[56]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_6.Image = Image.FromFile(Convert.ToString(dtForest.Rows[57]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_7.Image = Image.FromFile(Convert.ToString(dtOceans.Rows[56]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_8.Image = Image.FromFile(Convert.ToString(dtOceans.Rows[57]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_9.Image = Image.FromFile(Convert.ToString(dtMotoBike.Rows[56]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_10.Image = Image.FromFile(Convert.ToString(dtMotoBike.Rows[57]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_11.Image = Image.FromFile(Convert.ToString(dtFlower.Rows[56]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_12.Image = Image.FromFile(Convert.ToString(dtFlower.Rows[57]["Path"]));
                        break;
                    case 5:
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_1.Image = Image.FromFile(Convert.ToString(dtCar.Rows[58]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_2.Image = Image.FromFile(Convert.ToString(dtCar.Rows[59]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_3.Image = Image.FromFile(Convert.ToString(dtInterior.Rows[58]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_4.Image = Image.FromFile(Convert.ToString(dtInterior.Rows[59]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_5.Image = Image.FromFile(Convert.ToString(dtForest.Rows[58]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_6.Image = Image.FromFile(Convert.ToString(dtForest.Rows[59]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_7.Image = Image.FromFile(Convert.ToString(dtOceans.Rows[58]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_8.Image = Image.FromFile(Convert.ToString(dtOceans.Rows[59]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_9.Image = Image.FromFile(Convert.ToString(dtMotoBike.Rows[58]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_10.Image = Image.FromFile(Convert.ToString(dtMotoBike.Rows[59]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_11.Image = Image.FromFile(Convert.ToString(dtFlower.Rows[58]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_12.Image = Image.FromFile(Convert.ToString(dtFlower.Rows[59]["Path"]));
                        break;
                    case 6:
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_1.Image = Image.FromFile(Convert.ToString(dtCar.Rows[60]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_2.Image = Image.FromFile(Convert.ToString(dtCar.Rows[61]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_3.Image = Image.FromFile(Convert.ToString(dtInterior.Rows[60]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_4.Image = Image.FromFile(Convert.ToString(dtInterior.Rows[61]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_5.Image = Image.FromFile(Convert.ToString(dtForest.Rows[60]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_6.Image = Image.FromFile(Convert.ToString(dtForest.Rows[61]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_7.Image = Image.FromFile(Convert.ToString(dtOceans.Rows[60]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_8.Image = Image.FromFile(Convert.ToString(dtOceans.Rows[61]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_9.Image = Image.FromFile(Convert.ToString(dtMotoBike.Rows[60]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_10.Image = Image.FromFile(Convert.ToString(dtMotoBike.Rows[61]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_11.Image = Image.FromFile(Convert.ToString(dtFlower.Rows[60]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_12.Image = Image.FromFile(Convert.ToString(dtFlower.Rows[61]["Path"]));
                        break;
                    case 7:
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_1.Image = Image.FromFile(Convert.ToString(dtCar.Rows[62]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_2.Image = Image.FromFile(Convert.ToString(dtCar.Rows[63]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_3.Image = Image.FromFile(Convert.ToString(dtInterior.Rows[62]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_4.Image = Image.FromFile(Convert.ToString(dtInterior.Rows[63]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_5.Image = Image.FromFile(Convert.ToString(dtForest.Rows[62]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_6.Image = Image.FromFile(Convert.ToString(dtForest.Rows[63]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_7.Image = Image.FromFile(Convert.ToString(dtOceans.Rows[62]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_8.Image = Image.FromFile(Convert.ToString(dtOceans.Rows[63]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_9.Image = Image.FromFile(Convert.ToString(dtMotoBike.Rows[62]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_10.Image = Image.FromFile(Convert.ToString(dtMotoBike.Rows[63]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_11.Image = Image.FromFile(Convert.ToString(dtFlower.Rows[62]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_12.Image = Image.FromFile(Convert.ToString(dtFlower.Rows[63]["Path"]));
                        break;
                    default:
                        PageDailyAndTrending = 0;
                        break;
                }
            }

        }

        private void button_click_panelPageChange_flowLayoutPanelDailyAndTrending_form1_right_Click(object sender, EventArgs e)
        {
            ++PageDailyAndTrending;
            if(PageDailyAndTrending>7)
            {
                PageDailyAndTrending = 7;
            }
            int right = PageDailyAndTrending;
            button_click_panelPageChange_flowLayoutPanelDailyAndTrending_form1_page.Text = Convert.ToString(right);
            flowLayoutPanelDailyAndTrending_form1.Visible = true;
            if (Daily)
            {
                switch (PageDailyAndTrending)
                {
                    case 1:
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_1.Image = Image.FromFile(Convert.ToString(dtCar.Rows[10]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_2.Image = Image.FromFile(Convert.ToString(dtCar.Rows[11]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_3.Image = Image.FromFile(Convert.ToString(dtInterior.Rows[10]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_4.Image = Image.FromFile(Convert.ToString(dtInterior.Rows[11]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_5.Image = Image.FromFile(Convert.ToString(dtForest.Rows[10]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_6.Image = Image.FromFile(Convert.ToString(dtForest.Rows[11]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_7.Image = Image.FromFile(Convert.ToString(dtOceans.Rows[10]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_8.Image = Image.FromFile(Convert.ToString(dtOceans.Rows[11]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_9.Image = Image.FromFile(Convert.ToString(dtMotoBike.Rows[10]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_10.Image = Image.FromFile(Convert.ToString(dtMotoBike.Rows[11]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_11.Image = Image.FromFile(Convert.ToString(dtFlower.Rows[10]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_12.Image = Image.FromFile(Convert.ToString(dtFlower.Rows[11]["Path"]));
                        break;
                    case 2:
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_1.Image = Image.FromFile(Convert.ToString(dtCar.Rows[12]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_2.Image = Image.FromFile(Convert.ToString(dtCar.Rows[13]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_3.Image = Image.FromFile(Convert.ToString(dtInterior.Rows[12]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_4.Image = Image.FromFile(Convert.ToString(dtInterior.Rows[13]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_5.Image = Image.FromFile(Convert.ToString(dtForest.Rows[12]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_6.Image = Image.FromFile(Convert.ToString(dtForest.Rows[13]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_7.Image = Image.FromFile(Convert.ToString(dtOceans.Rows[12]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_8.Image = Image.FromFile(Convert.ToString(dtOceans.Rows[13]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_9.Image = Image.FromFile(Convert.ToString(dtMotoBike.Rows[12]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_10.Image = Image.FromFile(Convert.ToString(dtMotoBike.Rows[13]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_11.Image = Image.FromFile(Convert.ToString(dtFlower.Rows[12]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_12.Image = Image.FromFile(Convert.ToString(dtFlower.Rows[13]["Path"]));
                        break;
                    case 3:
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_1.Image = Image.FromFile(Convert.ToString(dtCar.Rows[14]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_2.Image = Image.FromFile(Convert.ToString(dtCar.Rows[15]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_3.Image = Image.FromFile(Convert.ToString(dtInterior.Rows[14]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_4.Image = Image.FromFile(Convert.ToString(dtInterior.Rows[15]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_5.Image = Image.FromFile(Convert.ToString(dtForest.Rows[14]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_6.Image = Image.FromFile(Convert.ToString(dtForest.Rows[15]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_7.Image = Image.FromFile(Convert.ToString(dtOceans.Rows[14]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_8.Image = Image.FromFile(Convert.ToString(dtOceans.Rows[15]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_9.Image = Image.FromFile(Convert.ToString(dtMotoBike.Rows[14]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_10.Image = Image.FromFile(Convert.ToString(dtMotoBike.Rows[15]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_11.Image = Image.FromFile(Convert.ToString(dtFlower.Rows[14]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_12.Image = Image.FromFile(Convert.ToString(dtFlower.Rows[15]["Path"]));
                        break;
                    case 4:
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_1.Image = Image.FromFile(Convert.ToString(dtCar.Rows[16]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_2.Image = Image.FromFile(Convert.ToString(dtCar.Rows[17]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_3.Image = Image.FromFile(Convert.ToString(dtInterior.Rows[16]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_4.Image = Image.FromFile(Convert.ToString(dtInterior.Rows[17]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_5.Image = Image.FromFile(Convert.ToString(dtForest.Rows[16]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_6.Image = Image.FromFile(Convert.ToString(dtForest.Rows[17]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_7.Image = Image.FromFile(Convert.ToString(dtOceans.Rows[16]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_8.Image = Image.FromFile(Convert.ToString(dtOceans.Rows[17]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_9.Image = Image.FromFile(Convert.ToString(dtMotoBike.Rows[16]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_10.Image = Image.FromFile(Convert.ToString(dtMotoBike.Rows[17]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_11.Image = Image.FromFile(Convert.ToString(dtFlower.Rows[16]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_12.Image = Image.FromFile(Convert.ToString(dtFlower.Rows[17]["Path"]));
                        break;
                    case 5:
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_1.Image = Image.FromFile(Convert.ToString(dtCar.Rows[18]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_2.Image = Image.FromFile(Convert.ToString(dtCar.Rows[19]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_3.Image = Image.FromFile(Convert.ToString(dtInterior.Rows[18]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_4.Image = Image.FromFile(Convert.ToString(dtInterior.Rows[19]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_5.Image = Image.FromFile(Convert.ToString(dtForest.Rows[18]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_6.Image = Image.FromFile(Convert.ToString(dtForest.Rows[19]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_7.Image = Image.FromFile(Convert.ToString(dtOceans.Rows[18]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_8.Image = Image.FromFile(Convert.ToString(dtOceans.Rows[19]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_9.Image = Image.FromFile(Convert.ToString(dtMotoBike.Rows[18]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_10.Image = Image.FromFile(Convert.ToString(dtMotoBike.Rows[19]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_11.Image = Image.FromFile(Convert.ToString(dtFlower.Rows[18]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_12.Image = Image.FromFile(Convert.ToString(dtFlower.Rows[19]["Path"]));
                        break;
                    case 6:
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_1.Image = Image.FromFile(Convert.ToString(dtCar.Rows[20]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_2.Image = Image.FromFile(Convert.ToString(dtCar.Rows[21]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_3.Image = Image.FromFile(Convert.ToString(dtInterior.Rows[20]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_4.Image = Image.FromFile(Convert.ToString(dtInterior.Rows[21]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_5.Image = Image.FromFile(Convert.ToString(dtForest.Rows[20]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_6.Image = Image.FromFile(Convert.ToString(dtForest.Rows[21]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_7.Image = Image.FromFile(Convert.ToString(dtOceans.Rows[20]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_8.Image = Image.FromFile(Convert.ToString(dtOceans.Rows[21]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_9.Image = Image.FromFile(Convert.ToString(dtMotoBike.Rows[20]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_10.Image = Image.FromFile(Convert.ToString(dtMotoBike.Rows[21]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_11.Image = Image.FromFile(Convert.ToString(dtFlower.Rows[20]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_12.Image = Image.FromFile(Convert.ToString(dtFlower.Rows[21]["Path"]));
                        break;
                    case 7:
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_1.Image = Image.FromFile(Convert.ToString(dtCar.Rows[22]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_2.Image = Image.FromFile(Convert.ToString(dtCar.Rows[23]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_3.Image = Image.FromFile(Convert.ToString(dtInterior.Rows[22]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_4.Image = Image.FromFile(Convert.ToString(dtInterior.Rows[23]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_5.Image = Image.FromFile(Convert.ToString(dtForest.Rows[22]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_6.Image = Image.FromFile(Convert.ToString(dtForest.Rows[23]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_7.Image = Image.FromFile(Convert.ToString(dtOceans.Rows[22]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_8.Image = Image.FromFile(Convert.ToString(dtOceans.Rows[23]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_9.Image = Image.FromFile(Convert.ToString(dtMotoBike.Rows[22]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_10.Image = Image.FromFile(Convert.ToString(dtMotoBike.Rows[23]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_11.Image = Image.FromFile(Convert.ToString(dtFlower.Rows[22]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_12.Image = Image.FromFile(Convert.ToString(dtFlower.Rows[23]["Path"]));
                        break;
                    default:
                        PageDailyAndTrending = 0;
                        break;
                }
            }
            else if (Daily == false)
            {
                switch (PageDailyAndTrending)
                {
                    case 1:
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_1.Image = Image.FromFile(Convert.ToString(dtCar.Rows[50]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_2.Image = Image.FromFile(Convert.ToString(dtCar.Rows[51]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_3.Image = Image.FromFile(Convert.ToString(dtInterior.Rows[50]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_4.Image = Image.FromFile(Convert.ToString(dtInterior.Rows[51]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_5.Image = Image.FromFile(Convert.ToString(dtForest.Rows[50]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_6.Image = Image.FromFile(Convert.ToString(dtForest.Rows[51]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_7.Image = Image.FromFile(Convert.ToString(dtOceans.Rows[50]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_8.Image = Image.FromFile(Convert.ToString(dtOceans.Rows[51]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_9.Image = Image.FromFile(Convert.ToString(dtMotoBike.Rows[50]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_10.Image = Image.FromFile(Convert.ToString(dtMotoBike.Rows[51]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_11.Image = Image.FromFile(Convert.ToString(dtFlower.Rows[50]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_12.Image = Image.FromFile(Convert.ToString(dtFlower.Rows[51]["Path"]));
                        break;
                    case 2:
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_1.Image = Image.FromFile(Convert.ToString(dtCar.Rows[52]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_2.Image = Image.FromFile(Convert.ToString(dtCar.Rows[53]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_3.Image = Image.FromFile(Convert.ToString(dtInterior.Rows[52]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_4.Image = Image.FromFile(Convert.ToString(dtInterior.Rows[53]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_5.Image = Image.FromFile(Convert.ToString(dtForest.Rows[52]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_6.Image = Image.FromFile(Convert.ToString(dtForest.Rows[53]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_7.Image = Image.FromFile(Convert.ToString(dtOceans.Rows[52]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_8.Image = Image.FromFile(Convert.ToString(dtOceans.Rows[53]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_9.Image = Image.FromFile(Convert.ToString(dtMotoBike.Rows[52]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_10.Image = Image.FromFile(Convert.ToString(dtMotoBike.Rows[53]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_11.Image = Image.FromFile(Convert.ToString(dtFlower.Rows[52]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_12.Image = Image.FromFile(Convert.ToString(dtFlower.Rows[53]["Path"]));
                        break;
                    case 3:
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_1.Image = Image.FromFile(Convert.ToString(dtCar.Rows[54]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_2.Image = Image.FromFile(Convert.ToString(dtCar.Rows[55]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_3.Image = Image.FromFile(Convert.ToString(dtInterior.Rows[54]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_4.Image = Image.FromFile(Convert.ToString(dtInterior.Rows[55]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_5.Image = Image.FromFile(Convert.ToString(dtForest.Rows[54]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_6.Image = Image.FromFile(Convert.ToString(dtForest.Rows[55]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_7.Image = Image.FromFile(Convert.ToString(dtOceans.Rows[54]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_8.Image = Image.FromFile(Convert.ToString(dtOceans.Rows[55]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_9.Image = Image.FromFile(Convert.ToString(dtMotoBike.Rows[54]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_10.Image = Image.FromFile(Convert.ToString(dtMotoBike.Rows[55]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_11.Image = Image.FromFile(Convert.ToString(dtFlower.Rows[54]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_12.Image = Image.FromFile(Convert.ToString(dtFlower.Rows[55]["Path"]));
                        break;
                    case 4:
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_1.Image = Image.FromFile(Convert.ToString(dtCar.Rows[56]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_2.Image = Image.FromFile(Convert.ToString(dtCar.Rows[57]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_3.Image = Image.FromFile(Convert.ToString(dtInterior.Rows[56]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_4.Image = Image.FromFile(Convert.ToString(dtInterior.Rows[57]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_5.Image = Image.FromFile(Convert.ToString(dtForest.Rows[56]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_6.Image = Image.FromFile(Convert.ToString(dtForest.Rows[57]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_7.Image = Image.FromFile(Convert.ToString(dtOceans.Rows[56]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_8.Image = Image.FromFile(Convert.ToString(dtOceans.Rows[57]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_9.Image = Image.FromFile(Convert.ToString(dtMotoBike.Rows[56]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_10.Image = Image.FromFile(Convert.ToString(dtMotoBike.Rows[57]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_11.Image = Image.FromFile(Convert.ToString(dtFlower.Rows[56]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_12.Image = Image.FromFile(Convert.ToString(dtFlower.Rows[57]["Path"]));
                        break;
                    case 5:
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_1.Image = Image.FromFile(Convert.ToString(dtCar.Rows[58]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_2.Image = Image.FromFile(Convert.ToString(dtCar.Rows[59]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_3.Image = Image.FromFile(Convert.ToString(dtInterior.Rows[58]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_4.Image = Image.FromFile(Convert.ToString(dtInterior.Rows[59]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_5.Image = Image.FromFile(Convert.ToString(dtForest.Rows[58]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_6.Image = Image.FromFile(Convert.ToString(dtForest.Rows[59]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_7.Image = Image.FromFile(Convert.ToString(dtOceans.Rows[58]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_8.Image = Image.FromFile(Convert.ToString(dtOceans.Rows[59]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_9.Image = Image.FromFile(Convert.ToString(dtMotoBike.Rows[58]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_10.Image = Image.FromFile(Convert.ToString(dtMotoBike.Rows[59]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_11.Image = Image.FromFile(Convert.ToString(dtFlower.Rows[58]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_12.Image = Image.FromFile(Convert.ToString(dtFlower.Rows[59]["Path"]));
                        break;
                    case 6:
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_1.Image = Image.FromFile(Convert.ToString(dtCar.Rows[60]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_2.Image = Image.FromFile(Convert.ToString(dtCar.Rows[61]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_3.Image = Image.FromFile(Convert.ToString(dtInterior.Rows[60]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_4.Image = Image.FromFile(Convert.ToString(dtInterior.Rows[61]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_5.Image = Image.FromFile(Convert.ToString(dtForest.Rows[60]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_6.Image = Image.FromFile(Convert.ToString(dtForest.Rows[61]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_7.Image = Image.FromFile(Convert.ToString(dtOceans.Rows[60]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_8.Image = Image.FromFile(Convert.ToString(dtOceans.Rows[61]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_9.Image = Image.FromFile(Convert.ToString(dtMotoBike.Rows[60]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_10.Image = Image.FromFile(Convert.ToString(dtMotoBike.Rows[61]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_11.Image = Image.FromFile(Convert.ToString(dtFlower.Rows[60]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_12.Image = Image.FromFile(Convert.ToString(dtFlower.Rows[61]["Path"]));
                        break;
                    case 7:
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_1.Image = Image.FromFile(Convert.ToString(dtCar.Rows[62]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_2.Image = Image.FromFile(Convert.ToString(dtCar.Rows[63]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_3.Image = Image.FromFile(Convert.ToString(dtInterior.Rows[62]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_4.Image = Image.FromFile(Convert.ToString(dtInterior.Rows[63]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_5.Image = Image.FromFile(Convert.ToString(dtForest.Rows[62]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_6.Image = Image.FromFile(Convert.ToString(dtForest.Rows[63]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_7.Image = Image.FromFile(Convert.ToString(dtOceans.Rows[62]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_8.Image = Image.FromFile(Convert.ToString(dtOceans.Rows[63]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_9.Image = Image.FromFile(Convert.ToString(dtMotoBike.Rows[62]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_10.Image = Image.FromFile(Convert.ToString(dtMotoBike.Rows[63]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_11.Image = Image.FromFile(Convert.ToString(dtFlower.Rows[62]["Path"]));
                        pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_12.Image = Image.FromFile(Convert.ToString(dtFlower.Rows[63]["Path"]));
                        break;
                    default:
                        PageDailyAndTrending = 0;
                        break;
                }
            }

        }

        private void button_click_panelGallery_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_changePage1_Click(object sender, EventArgs e)
        {
            if (label_panelGallery_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_thirdCategorized.Text == "Flower")
            {
                pictureBox_click_panelGallery_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_showingGallery_1.Image = Image.FromFile(Convert.ToString(dtFlower.Rows[2]["Path"]));
                pictureBox_click_panelGallery_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_showingGallery_2.Image = Image.FromFile(Convert.ToString(dtFlower.Rows[3]["Path"]));
                pictureBox_click_panelGallery_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_showingGallery_3.Image = Image.FromFile(Convert.ToString(dtFlower.Rows[4]["Path"]));
                pictureBox_click_panelGallery_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_showingGallery_4.Image = Image.FromFile(Convert.ToString(dtFlower.Rows[5]["Path"]));
                pictureBox_click_panelGallery_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_showingGallery_5.Image = Image.FromFile(Convert.ToString(dtFlower.Rows[6]["Path"]));
                pictureBox_click_panelGallery_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_showingGallery_6.Image = Image.FromFile(Convert.ToString(dtFlower.Rows[7]["Path"]));
                pictureBox_click_panelGallery_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_showingGallery_7.Image = Image.FromFile(Convert.ToString(dtFlower.Rows[8]["Path"]));
                pictureBox_click_panelGallery_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_showingGallery_8.Image = Image.FromFile(Convert.ToString(dtFlower.Rows[9]["Path"]));
                pictureBox_click_panelGallery_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_showingGallery_9.Image = Image.FromFile(Convert.ToString(dtFlower.Rows[10]["Path"]));
            }
            else if(label_panelGallery_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_thirdCategorized.Text == "OCeans")
            {
               pictureBox_click_panelGallery_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_showingGallery_1.Image = Image.FromFile(Convert.ToString(dtOceans.Rows[2]["Path"]));
               pictureBox_click_panelGallery_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_showingGallery_2.Image = Image.FromFile(Convert.ToString(dtOceans.Rows[3]["Path"]));
               pictureBox_click_panelGallery_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_showingGallery_3.Image = Image.FromFile(Convert.ToString(dtOceans.Rows[4]["Path"]));
               pictureBox_click_panelGallery_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_showingGallery_4.Image = Image.FromFile(Convert.ToString(dtOceans.Rows[5]["Path"]));
               pictureBox_click_panelGallery_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_showingGallery_5.Image = Image.FromFile(Convert.ToString(dtOceans.Rows[6]["Path"]));
               pictureBox_click_panelGallery_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_showingGallery_6.Image = Image.FromFile(Convert.ToString(dtOceans.Rows[7]["Path"]));
               pictureBox_click_panelGallery_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_showingGallery_7.Image = Image.FromFile(Convert.ToString(dtOceans.Rows[8]["Path"]));
               pictureBox_click_panelGallery_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_showingGallery_8.Image = Image.FromFile(Convert.ToString(dtOceans.Rows[9]["Path"]));
               pictureBox_click_panelGallery_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_showingGallery_9.Image = Image.FromFile(Convert.ToString(dtOceans.Rows[10]["Path"]));
         
            }
            else if (label_panelGallery_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_thirdCategorized.Text == "Car")
            {
                pictureBox_click_panelGallery_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_showingGallery_1.Image = Image.FromFile(Convert.ToString(dtCar.Rows[2]["Path"]));
                pictureBox_click_panelGallery_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_showingGallery_2.Image = Image.FromFile(Convert.ToString(dtCar.Rows[3]["Path"]));
                pictureBox_click_panelGallery_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_showingGallery_3.Image = Image.FromFile(Convert.ToString(dtCar.Rows[4]["Path"]));
                pictureBox_click_panelGallery_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_showingGallery_4.Image = Image.FromFile(Convert.ToString(dtCar.Rows[5]["Path"]));
                pictureBox_click_panelGallery_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_showingGallery_5.Image = Image.FromFile(Convert.ToString(dtCar.Rows[6]["Path"]));
                pictureBox_click_panelGallery_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_showingGallery_6.Image = Image.FromFile(Convert.ToString(dtCar.Rows[7]["Path"]));
                pictureBox_click_panelGallery_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_showingGallery_7.Image = Image.FromFile(Convert.ToString(dtCar.Rows[8]["Path"]));
                pictureBox_click_panelGallery_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_showingGallery_8.Image = Image.FromFile(Convert.ToString(dtCar.Rows[9]["Path"]));
                pictureBox_click_panelGallery_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_showingGallery_9.Image = Image.FromFile(Convert.ToString(dtCar.Rows[10]["Path"]));


            }
            else if(label_panelGallery_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_thirdCategorized.Text == "MotoBike")
            {
                pictureBox_click_panelGallery_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_showingGallery_1.Image = Image.FromFile(Convert.ToString(dtMotoBike.Rows[2]["Path"]));
                pictureBox_click_panelGallery_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_showingGallery_2.Image = Image.FromFile(Convert.ToString(dtMotoBike.Rows[3]["Path"]));
                pictureBox_click_panelGallery_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_showingGallery_3.Image = Image.FromFile(Convert.ToString(dtMotoBike.Rows[4]["Path"]));
                pictureBox_click_panelGallery_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_showingGallery_4.Image = Image.FromFile(Convert.ToString(dtMotoBike.Rows[5]["Path"]));
                pictureBox_click_panelGallery_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_showingGallery_5.Image = Image.FromFile(Convert.ToString(dtMotoBike.Rows[6]["Path"]));
                pictureBox_click_panelGallery_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_showingGallery_6.Image = Image.FromFile(Convert.ToString(dtMotoBike.Rows[7]["Path"]));
                pictureBox_click_panelGallery_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_showingGallery_7.Image = Image.FromFile(Convert.ToString(dtMotoBike.Rows[8]["Path"]));
                pictureBox_click_panelGallery_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_showingGallery_8.Image = Image.FromFile(Convert.ToString(dtMotoBike.Rows[9]["Path"]));
                pictureBox_click_panelGallery_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_showingGallery_9.Image = Image.FromFile(Convert.ToString(dtMotoBike.Rows[10]["Path"]));
            }
        }

        private void button_click_panelGallery_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_changePage2_Click(object sender, EventArgs e)
        {
            if (label_panelGallery_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_thirdCategorized.Text == "Flower")
            {
                pictureBox_click_panelGallery_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_showingGallery_1.Image = Image.FromFile(Convert.ToString(dtFlower.Rows[20]["Path"]));
                pictureBox_click_panelGallery_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_showingGallery_2.Image = Image.FromFile(Convert.ToString(dtFlower.Rows[21]["Path"]));
                pictureBox_click_panelGallery_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_showingGallery_3.Image = Image.FromFile(Convert.ToString(dtFlower.Rows[22]["Path"]));
                pictureBox_click_panelGallery_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_showingGallery_4.Image = Image.FromFile(Convert.ToString(dtFlower.Rows[23]["Path"]));
                pictureBox_click_panelGallery_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_showingGallery_5.Image = Image.FromFile(Convert.ToString(dtFlower.Rows[24]["Path"]));
                pictureBox_click_panelGallery_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_showingGallery_6.Image = Image.FromFile(Convert.ToString(dtFlower.Rows[25]["Path"]));
                pictureBox_click_panelGallery_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_showingGallery_7.Image = Image.FromFile(Convert.ToString(dtFlower.Rows[26]["Path"]));
                pictureBox_click_panelGallery_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_showingGallery_8.Image = Image.FromFile(Convert.ToString(dtFlower.Rows[27]["Path"]));
                pictureBox_click_panelGallery_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_showingGallery_9.Image = Image.FromFile(Convert.ToString(dtFlower.Rows[28]["Path"]));
            }
            else if (label_panelGallery_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_thirdCategorized.Text == "OCeans")
            {
                pictureBox_click_panelGallery_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_showingGallery_1.Image = Image.FromFile(Convert.ToString(dtOceans.Rows[20]["Path"]));
                pictureBox_click_panelGallery_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_showingGallery_2.Image = Image.FromFile(Convert.ToString(dtOceans.Rows[21]["Path"]));
                pictureBox_click_panelGallery_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_showingGallery_3.Image = Image.FromFile(Convert.ToString(dtOceans.Rows[22]["Path"]));
                pictureBox_click_panelGallery_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_showingGallery_4.Image = Image.FromFile(Convert.ToString(dtOceans.Rows[23]["Path"]));
                pictureBox_click_panelGallery_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_showingGallery_5.Image = Image.FromFile(Convert.ToString(dtOceans.Rows[24]["Path"]));
                pictureBox_click_panelGallery_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_showingGallery_6.Image = Image.FromFile(Convert.ToString(dtOceans.Rows[25]["Path"]));
                pictureBox_click_panelGallery_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_showingGallery_7.Image = Image.FromFile(Convert.ToString(dtOceans.Rows[26]["Path"]));
                pictureBox_click_panelGallery_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_showingGallery_8.Image = Image.FromFile(Convert.ToString(dtOceans.Rows[27]["Path"]));
                pictureBox_click_panelGallery_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_showingGallery_9.Image = Image.FromFile(Convert.ToString(dtOceans.Rows[28]["Path"]));

            }
            else if (label_panelGallery_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_thirdCategorized.Text == "Car")
            {
                pictureBox_click_panelGallery_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_showingGallery_1.Image = Image.FromFile(Convert.ToString(dtCar.Rows[20]["Path"]));
                pictureBox_click_panelGallery_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_showingGallery_2.Image = Image.FromFile(Convert.ToString(dtCar.Rows[21]["Path"]));
                pictureBox_click_panelGallery_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_showingGallery_3.Image = Image.FromFile(Convert.ToString(dtCar.Rows[22]["Path"]));
                pictureBox_click_panelGallery_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_showingGallery_4.Image = Image.FromFile(Convert.ToString(dtCar.Rows[23]["Path"]));
                pictureBox_click_panelGallery_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_showingGallery_5.Image = Image.FromFile(Convert.ToString(dtCar.Rows[24]["Path"]));
                pictureBox_click_panelGallery_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_showingGallery_6.Image = Image.FromFile(Convert.ToString(dtCar.Rows[25]["Path"]));
                pictureBox_click_panelGallery_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_showingGallery_7.Image = Image.FromFile(Convert.ToString(dtCar.Rows[26]["Path"]));
                pictureBox_click_panelGallery_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_showingGallery_8.Image = Image.FromFile(Convert.ToString(dtCar.Rows[27]["Path"]));
                pictureBox_click_panelGallery_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_showingGallery_9.Image = Image.FromFile(Convert.ToString(dtCar.Rows[28]["Path"]));


            }
            else if (label_panelGallery_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_thirdCategorized.Text == "MotoBike")
            {
                pictureBox_click_panelGallery_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_showingGallery_1.Image = Image.FromFile(Convert.ToString(dtMotoBike.Rows[20]["Path"]));
                pictureBox_click_panelGallery_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_showingGallery_2.Image = Image.FromFile(Convert.ToString(dtMotoBike.Rows[21]["Path"]));
                pictureBox_click_panelGallery_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_showingGallery_3.Image = Image.FromFile(Convert.ToString(dtMotoBike.Rows[22]["Path"]));
                pictureBox_click_panelGallery_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_showingGallery_4.Image = Image.FromFile(Convert.ToString(dtMotoBike.Rows[23]["Path"]));
                pictureBox_click_panelGallery_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_showingGallery_5.Image = Image.FromFile(Convert.ToString(dtMotoBike.Rows[24]["Path"]));
                pictureBox_click_panelGallery_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_showingGallery_6.Image = Image.FromFile(Convert.ToString(dtMotoBike.Rows[25]["Path"]));
                pictureBox_click_panelGallery_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_showingGallery_7.Image = Image.FromFile(Convert.ToString(dtMotoBike.Rows[26]["Path"]));
                pictureBox_click_panelGallery_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_showingGallery_8.Image = Image.FromFile(Convert.ToString(dtMotoBike.Rows[27]["Path"]));
                pictureBox_click_panelGallery_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_showingGallery_9.Image = Image.FromFile(Convert.ToString(dtMotoBike.Rows[28]["Path"]));
            }
        }

        private void pictureBox_click_panelDashBoard_form1_topics_Click(object sender, EventArgs e)
        {
            flowLayoutPanelTopics_form1.Visible = true;
            flowLayoutPanelDailyAndTrending_form1.Visible = false;
            Random RandomTopics = new Random();
            int RandomToPutInFlowLayOutPanelTopics_Car = RandomTopics.Next(1, 158);
            int RandomToPutInFlowLayOutPanelTopics_Interior = RandomTopics.Next(1, 230);
            int RandomToPutInFlowLayOutPanelTopics_Oceans = RandomTopics.Next(1, 187);
            int RandomToPutInFlowLayOutPanelTopics_Forest = RandomTopics.Next(1, 206);
            int RandomToPutInFlowLayOutPanelTopics_Flower = RandomTopics.Next(1, 160);
            int RandomToPutInFlowLayOutPanelTopics_MotoBike = RandomTopics.Next(1, 243);
            for(int i=1;i<=157;i++)
            {
                if(RandomToPutInFlowLayOutPanelTopics_Car==i)
                {
                    pictureBox_click_panelTopTopics_flowLayoutPanelTopics_form1_categorizedCar.Image = Image.FromFile(Convert.ToString(dtCar.Rows[RandomToPutInFlowLayOutPanelTopics_Car - 1]["Path"]));
                    pictureBox_click_panelAllTopics_flowLayoutPanelTopics_form1_categorizedCar.Image=Image.FromFile(Convert.ToString(dtCar.Rows[RandomToPutInFlowLayOutPanelTopics_Car - 1]["Path"]));
                }
            }
            for(int j=1;j<=186;j++)
            {
                if (RandomToPutInFlowLayOutPanelTopics_Oceans == j)
                {
                    pictureBox_click_panelTopTopics_flowLayoutPanelTopics_form1_categorizedOceans.Image = Image.FromFile(Convert.ToString(dtOceans.Rows[RandomToPutInFlowLayOutPanelTopics_Oceans - 1]["Path"]));
                    pictureBox_click_panelAllTopics_flowLayoutPanelTopics_form1_categorizedOceans.Image = Image.FromFile(Convert.ToString(dtOceans.Rows[RandomToPutInFlowLayOutPanelTopics_Oceans - 1]["Path"]));
                }
            }
            for(int k=1;k<=159;k++)
            {
                if (RandomToPutInFlowLayOutPanelTopics_Flower == k)
                {
                    pictureBox_click_panelTopTopics_flowLayoutPanelTopics_form1_categorizedFlower.Image = Image.FromFile(Convert.ToString(dtFlower.Rows[RandomToPutInFlowLayOutPanelTopics_Flower - 1]["Path"]));
                    pictureBox_click_panelAllTopics_flowLayoutPanelTopics_form1_categorizedFlower.Image = Image.FromFile(Convert.ToString(dtFlower.Rows[RandomToPutInFlowLayOutPanelTopics_Flower - 1]["Path"]));
                }
            }
            for (int h=1;h<=229;h++)
            {
                if(RandomToPutInFlowLayOutPanelTopics_Interior==h)
                {
                    pictureBox_click_panelAllTopics_flowLayoutPanelTopics_form1_categorizedInterior.Image= Image.FromFile(Convert.ToString(dtInterior.Rows[RandomToPutInFlowLayOutPanelTopics_Interior - 1]["Path"]));
                }
            }
            for(int p=1;p<=205;p++)
            {
                if(RandomToPutInFlowLayOutPanelTopics_Forest==p)
                {
                    pictureBox_click_panelAllTopics_flowLayoutPanelTopics_form1_categorizedForest.Image = Image.FromFile(Convert.ToString(dtForest.Rows[RandomToPutInFlowLayOutPanelTopics_Forest - 1]["Path"]));
                }
            }
            for(int o=1;o<=242;o++)
            {
                if(RandomToPutInFlowLayOutPanelTopics_MotoBike==o)
                {
                    pictureBox_click_panelAllTopics_flowLayoutPanelTopics_form1_categorizedMotoBike.Image = Image.FromFile(Convert.ToString(dtMotoBike.Rows[RandomToPutInFlowLayOutPanelTopics_Forest - 1]["Path"]));
                }
            }

        }

        private void pictureBox_click_panelTopTopics_flowLayoutPanelTopics_form1_categorizedCar_Click(object sender, EventArgs e)
        {
            flowLayoutPanelDetailTopics_form1.Visible = true;
            flowLayoutPanelTopics_form1.Visible = false;
            pictureBox_panelBackGround_flowLayoutPanelDetailTopics_form1_showingBackGroundTopics.Image = Image.FromFile(@"../../UsedForInterface/CarBackGround.png");
            label_panelBackGround_flowLayoutPanelDetailTopics_form1_nameTopics.Text = "CAR";
            label_panelBackGround_flowLayoutPanelDetailTopics_form1_describetopics.Text = "Explore the best car that ever exist,with the most modern design and technology";
            int[] arr1 = new int[12];
            LetNotDup(1, 158, arr1);
            load_random_image(dtCar, 157, arr1[0], arr1[1], arr1[2], arr1[3], arr1[4], arr1[5], arr1[6], arr1[7], arr1[8], arr1[9], arr1[10], arr1[11]);
            button_click_panelDetailPicture_flowLayoutPanelDetailPicture_form1_tags_1.Text = "CAR";
        }

        private void pictureBox_click_panelTopTopics_flowLayoutPanelTopics_form1_categorizedOceans_Click(object sender, EventArgs e)
        {
            flowLayoutPanelDetailTopics_form1.Visible = true;
            flowLayoutPanelTopics_form1.Visible = false;
            pictureBox_panelBackGround_flowLayoutPanelDetailTopics_form1_showingBackGroundTopics.Image = Image.FromFile(@"../../UsedForInterface/OceansBackground.png");
            label_panelBackGround_flowLayoutPanelDetailTopics_form1_nameTopics.Text = "OCEANS";
            label_panelBackGround_flowLayoutPanelDetailTopics_form1_describetopics.Text = "A real-world example of a zero-entry swimming pool. Swim in the peaceful waves, lunch under a thatch-roof cabana under the palms";
            int[] arr4 = new int[12];
            LetNotDup(1, 187, arr4);
            load_random_image(dtOceans, 186, arr4[0], arr4[1], arr4[2], arr4[3], arr4[4], arr4[5], arr4[6], arr4[7], arr4[8], arr4[9], arr4[10], arr4[11]);
            button_click_panelDetailPicture_flowLayoutPanelDetailPicture_form1_tags_1.Text = "OCEANS";
        }

        private void pictureBox_click_panelTopTopics_flowLayoutPanelTopics_form1_categorizedFlower_Click(object sender, EventArgs e)
        {
            flowLayoutPanelDetailTopics_form1.Visible = true;
            flowLayoutPanelTopics_form1.Visible = false;
            pictureBox_panelBackGround_flowLayoutPanelDetailTopics_form1_showingBackGroundTopics.Image = Image.FromFile(@"../../UsedForInterface/FlowerBackGround.png");
            label_panelBackGround_flowLayoutPanelDetailTopics_form1_nameTopics.Text = "FLOWER";
            label_panelBackGround_flowLayoutPanelDetailTopics_form1_describetopics.Text = "Beautiful and special flower on the planet";
            int[] arr5 = new int[12];
            LetNotDup(1, 160, arr5);
            load_random_image(dtFlower, 159, arr5[0], arr5[1], arr5[2], arr5[3], arr5[4], arr5[5], arr5[6], arr5[7], arr5[8], arr5[9], arr5[10], arr5[11]);
            button_click_panelDetailPicture_flowLayoutPanelDetailPicture_form1_tags_1.Text = "FLOWER";
        }

        private void pictureBox_click_panelAllTopics_flowLayoutPanelTopics_form1_categorizedFlower_Click(object sender, EventArgs e)
        {
            flowLayoutPanelDetailTopics_form1.Visible = true;
            flowLayoutPanelTopics_form1.Visible = false;
            pictureBox_panelBackGround_flowLayoutPanelDetailTopics_form1_showingBackGroundTopics.Image = Image.FromFile(@"../../UsedForInterface/FlowerBackGround.png");
            label_panelBackGround_flowLayoutPanelDetailTopics_form1_nameTopics.Text = "FLOWER";
            label_panelBackGround_flowLayoutPanelDetailTopics_form1_describetopics.Text = "Beautiful and special flower on the planet";
            int[] arr5 = new int[12];
            LetNotDup(1, 160, arr5);
            load_random_image(dtFlower, 159, arr5[0], arr5[1], arr5[2], arr5[3], arr5[4], arr5[5], arr5[6], arr5[7], arr5[8], arr5[9], arr5[10], arr5[11]);
            button_click_panelDetailPicture_flowLayoutPanelDetailPicture_form1_tags_1.Text = "FLOWER";
        }

        private void pictureBox_click_panelAllTopics_flowLayoutPanelTopics_form1_categorizedCar_Click(object sender, EventArgs e)
        {
            flowLayoutPanelDetailTopics_form1.Visible = true;
            flowLayoutPanelTopics_form1.Visible = false;
            pictureBox_panelBackGround_flowLayoutPanelDetailTopics_form1_showingBackGroundTopics.Image = Image.FromFile(@"../../UsedForInterface/CarBackGround.png");
            label_panelBackGround_flowLayoutPanelDetailTopics_form1_nameTopics.Text = "CAR";
            label_panelBackGround_flowLayoutPanelDetailTopics_form1_describetopics.Text = "Explore the best car that ever exist,with the most modern design and technology";
            int[] arr1 = new int[12];
            LetNotDup(1, 158, arr1);
            load_random_image(dtCar, 157, arr1[0], arr1[1], arr1[2], arr1[3], arr1[4], arr1[5], arr1[6], arr1[7], arr1[8], arr1[9], arr1[10], arr1[11]);
            button_click_panelDetailPicture_flowLayoutPanelDetailPicture_form1_tags_1.Text = "CAR";
        }

        private void pictureBox_click_panelAllTopics_flowLayoutPanelTopics_form1_categorizedOceans_Click(object sender, EventArgs e)
        {
            flowLayoutPanelDetailTopics_form1.Visible = true;
            flowLayoutPanelTopics_form1.Visible = false;
            pictureBox_panelBackGround_flowLayoutPanelDetailTopics_form1_showingBackGroundTopics.Image = Image.FromFile(@"../../UsedForInterface/OceansBackground.png");
            label_panelBackGround_flowLayoutPanelDetailTopics_form1_nameTopics.Text = "OCEANS";
            label_panelBackGround_flowLayoutPanelDetailTopics_form1_describetopics.Text = "A real-world example of a zero-entry swimming pool. Swim in the peaceful waves, lunch under a thatch-roof cabana under the palms";
            int[] arr4 = new int[12];
            LetNotDup(1, 187, arr4);
            load_random_image(dtOceans, 186, arr4[0], arr4[1], arr4[2], arr4[3], arr4[4], arr4[5], arr4[6], arr4[7], arr4[8], arr4[9], arr4[10], arr4[11]);
            button_click_panelDetailPicture_flowLayoutPanelDetailPicture_form1_tags_1.Text = "OCEANS";
        }

        private void pictureBox_click_panelAllTopics_flowLayoutPanelTopics_form1_categorizedForest_Click(object sender, EventArgs e)
        {
            flowLayoutPanelDetailTopics_form1.Visible = true;
            flowLayoutPanelTopics_form1.Visible = false;
            pictureBox_panelBackGround_flowLayoutPanelDetailTopics_form1_showingBackGroundTopics.Image = Image.FromFile(@"../../UsedForInterface/ForestBackGround.png");
            label_panelBackGround_flowLayoutPanelDetailTopics_form1_nameTopics.Text = "FOREST";
            label_panelBackGround_flowLayoutPanelDetailTopics_form1_describetopics.Text = "Explore the most beautiful forest in the world";
            int[] arr3 = new int[12];
            LetNotDup(1, 206, arr3);
            load_random_image(dtForest, 205, arr3[0], arr3[1], arr3[2], arr3[3], arr3[4], arr3[5], arr3[6], arr3[7], arr3[8], arr3[9], arr3[10], arr3[11]);
            button_click_panelDetailPicture_flowLayoutPanelDetailPicture_form1_tags_1.Text = "FOREST";
        }

        private void pictureBox_click_panelAllTopics_flowLayoutPanelTopics_form1_categorizedInterior_Click(object sender, EventArgs e)
        {
            flowLayoutPanelDetailTopics_form1.Visible = true;
            flowLayoutPanelTopics_form1.Visible = false;
            pictureBox_panelBackGround_flowLayoutPanelDetailTopics_form1_showingBackGroundTopics.Image = Image.FromFile(@"../../UsedForInterface/Interiorbackground.jpg");
            label_panelBackGround_flowLayoutPanelDetailTopics_form1_nameTopics.Text = "INTERIOR";
            label_panelBackGround_flowLayoutPanelDetailTopics_form1_describetopics.Text = "Discovery the most modern interior in 2021,eyes catching interior";
            int[] arr = new int[12];
            LetNotDup(1, 230, arr);
            load_random_image(dtInterior, 229, arr[0], arr[1], arr[2], arr[3], arr[4], arr[5], arr[6], arr[7], arr[8], arr[9], arr[10], arr[11]);
            button_click_panelDetailPicture_flowLayoutPanelDetailPicture_form1_tags_1.Text = "INTERIOR";
        }

        private void pictureBox_click_panelAllTopics_flowLayoutPanelTopics_form1_categorizedMotoBike_Click(object sender, EventArgs e)
        {
            flowLayoutPanelDetailTopics_form1.Visible = true;
            flowLayoutPanelTopics_form1.Visible = false;
            pictureBox_panelBackGround_flowLayoutPanelDetailTopics_form1_showingBackGroundTopics.Image = Image.FromFile(@"../../UsedForInterface/MotoBikebackGround.png");
            label_panelBackGround_flowLayoutPanelDetailTopics_form1_nameTopics.Text = "MOTOBIKE";
            label_panelBackGround_flowLayoutPanelDetailTopics_form1_describetopics.Text = "Here is the most significant image for motobike";
            int[] arr2 = new int[12];
            LetNotDup(1, 243, arr2);
            load_random_image(dtMotoBike, 242, arr2[0], arr2[1], arr2[2], arr2[3], arr2[4], arr2[5], arr2[6], arr2[7], arr2[8], arr2[9], arr2[10], arr2[11]);
            button_click_panelDetailPicture_flowLayoutPanelDetailPicture_form1_tags_1.Text = "MOTOBIKE";
        }

        private void pictureBox_click_panelShowPics_flowLayoutPanelDetailTopics_form1_showingTopics_1_Click(object sender, EventArgs e)
        {
            pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBox_click_panelShowPics_flowLayoutPanelDetailTopics_form1_showingTopics_1.Image;
            flowLayoutPanelDetailPicture_form1.Visible = true;
            flowLayoutPanelDetailTopics_form1.Visible = false;
            danhgiau_pictureBoxShowing = 76;
        }

        private void pictureBox_click_panelShowPics_flowLayoutPanelDetailTopics_form1_showingTopics_2_Click(object sender, EventArgs e)
        {
            pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBox_click_panelShowPics_flowLayoutPanelDetailTopics_form1_showingTopics_2.Image;
            flowLayoutPanelDetailPicture_form1.Visible = true;
            flowLayoutPanelDetailTopics_form1.Visible = false;
            danhgiau_pictureBoxShowing = 77;
        }

        private void pictureBox_click_panelShowPics_flowLayoutPanelDetailTopics_form1_showingTopics_3_Click(object sender, EventArgs e)
        {
            pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBox_click_panelShowPics_flowLayoutPanelDetailTopics_form1_showingTopics_3.Image;
            flowLayoutPanelDetailPicture_form1.Visible = true;
            flowLayoutPanelDetailTopics_form1.Visible = false;
            danhgiau_pictureBoxShowing = 78;
        }

        private void pictureBox_click_panelShowPics_flowLayoutPanelDetailTopics_form1_showingTopics_4_Click(object sender, EventArgs e)
        {
            pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBox_click_panelShowPics_flowLayoutPanelDetailTopics_form1_showingTopics_4.Image;
            flowLayoutPanelDetailPicture_form1.Visible = true;
            flowLayoutPanelDetailTopics_form1.Visible = false;
            danhgiau_pictureBoxShowing = 79;
        }

        private void pictureBox_click_panelShowPics_flowLayoutPanelDetailTopics_form1_showingTopics_5_Click(object sender, EventArgs e)
        {
            pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBox_click_panelShowPics_flowLayoutPanelDetailTopics_form1_showingTopics_5.Image;
            flowLayoutPanelDetailPicture_form1.Visible = true;
            flowLayoutPanelDetailTopics_form1.Visible = false;
            danhgiau_pictureBoxShowing = 80;
        }

        private void pictureBox_click_panelShowPics_flowLayoutPanelDetailTopics_form1_showingTopics_6_Click(object sender, EventArgs e)
        {
            pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBox_click_panelShowPics_flowLayoutPanelDetailTopics_form1_showingTopics_6.Image;
            flowLayoutPanelDetailPicture_form1.Visible = true;
            flowLayoutPanelDetailTopics_form1.Visible = false;
            danhgiau_pictureBoxShowing = 81;
        }

        private void pictureBox_click_panelShowPics_flowLayoutPanelDetailTopics_form1_showingTopics_7_Click(object sender, EventArgs e)
        {
            pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBox_click_panelShowPics_flowLayoutPanelDetailTopics_form1_showingTopics_7.Image;
            flowLayoutPanelDetailPicture_form1.Visible = true;
            flowLayoutPanelDetailTopics_form1.Visible = false;
            danhgiau_pictureBoxShowing = 82;
        }

        private void pictureBox_click_panelShowPics_flowLayoutPanelDetailTopics_form1_showingTopics_9_Click(object sender, EventArgs e)
        {
            pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBox_click_panelShowPics_flowLayoutPanelDetailTopics_form1_showingTopics_9.Image;
            flowLayoutPanelDetailPicture_form1.Visible = true;
            flowLayoutPanelDetailTopics_form1.Visible = false;
            danhgiau_pictureBoxShowing = 84;
        }

        private void pictureBox_click_panelShowPics_flowLayoutPanelDetailTopics_form1_showingTopics_10_Click(object sender, EventArgs e)
        {
            pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBox_click_panelShowPics_flowLayoutPanelDetailTopics_form1_showingTopics_10.Image;
            flowLayoutPanelDetailPicture_form1.Visible = true;
            flowLayoutPanelDetailTopics_form1.Visible = false;
            danhgiau_pictureBoxShowing = 85;
        }

        private void pictureBox_click_panelShowPics_flowLayoutPanelDetailTopics_form1_showingTopics_11_Click(object sender, EventArgs e)
        {
            pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBox_click_panelShowPics_flowLayoutPanelDetailTopics_form1_showingTopics_11.Image;
            flowLayoutPanelDetailPicture_form1.Visible = true;
            flowLayoutPanelDetailTopics_form1.Visible = false;
            danhgiau_pictureBoxShowing = 86;
        }

        private void pictureBox_click_panelShowPics_flowLayoutPanelDetailTopics_form1_showingTopics_12_Click(object sender, EventArgs e)
        {

            pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBox_click_panelShowPics_flowLayoutPanelDetailTopics_form1_showingTopics_11.Image;
            flowLayoutPanelDetailPicture_form1.Visible = true;
            flowLayoutPanelDetailTopics_form1.Visible = false;
            danhgiau_pictureBoxShowing = 87;
        }

        private void button_click_panelShowPics_flowLayoutPanelDetailTopics_form1_back_Click(object sender, EventArgs e)
        {
            flowLayoutPanelDetailTopics_form1.Visible = false;
            flowLayoutPanelMain_form1.Visible = true;
        }
        int down = 0;
        private void button_click_panelDetailPicture_flowLayoutPanelDetailPicture_Download_Click(object sender, EventArgs e)
        {

            if(down  %2 ==0)
            {
                panelTypeDownLoad_panelDetailPicture_flowLayoutPanelDetailPicture.Visible = true;
                down++;
            }
            else
            {
                panelTypeDownLoad_panelDetailPicture_flowLayoutPanelDetailPicture.Visible = false;
                down++;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            FolderBrowserDialog fd = new FolderBrowserDialog();
            if (fd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                ++saveimgnumber;
                string imgname = " ";
                if (saveimgnumber == 1)
                {
                    imgname = "download.jpg";
                }
                else
                {
                    int index = saveimgnumber - 1;
                    imgname = "download (" + index.ToString() + ").jpg";
                }
                string savepath = Path.Combine(fd.SelectedPath, imgname);
                pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image.Save(@savepath, ImageFormat.Jpeg);
            }

        }

        private void button_click_panelTypeDownLoad_panelDetailPicture_flowLayoutPanelDetailPicture_PNG_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fd = new FolderBrowserDialog();
            if (fd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                ++saveimgnumber;
                string imgname = " ";
                if (saveimgnumber == 1)
                {
                    imgname = "download.png";
                }
                else
                {
                    int index = saveimgnumber - 1;
                    imgname = "download (" + index.ToString() + ").png";
                }
                string savepath = Path.Combine(fd.SelectedPath, imgname);
                pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image.Save(@savepath, ImageFormat.Png);
            }

        }

        private void neddToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void panelSortBySize_flowLayoutPanelResult_form1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void button_click_panelFuntion_form1_search_Click(object sender, EventArgs e)
        {

        }


        private void richTextBox_panelFunction_form1_search_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                
                string Search_string = richTextBox_panelFunction_form1_search.Text;
                Search_string = Search_string.ToUpper();
                Search_string = Search_string.Trim();
                flowLayoutPanel_searchResult.Visible = true;
                string search_expression = "Categorized='" + Search_string + "'";
                DataRow[] Found_Rows = dtAll.Select(search_expression);
                int i = 0;
                foreach(Control control1 in this.panelShowResult_flowLayoutPanelResult_form1.Controls)
                {
                    if(control1 is PictureBox)
                    {
                        ((PictureBox)control1).Image = Image.FromFile(Found_Rows[i]["Path"].ToString());
                        i += 1;
                    }
                }
                dtSearched = new DataTable();
                dtSearched = Found_Rows.CopyToDataTable();
                dtFiltered.Clear();
                dtFiltered = dtSearched.Copy();

            }
        }



        public void updateDtFiltered()
        {
            dtFiltered.Clear();
            dtFiltered = dtSearched.Copy();

            // Filter by image size
            if(materialComboBox1.Text == "Large")
            {
            int Count_rows_dtSearch = dtFiltered.Rows.Count;
                for (int j = 0; j < Count_rows_dtSearch ; j++)
                { 
                    Image img = Image.FromFile(dtFiltered.Rows[j]["Path"].ToString());
                    if(img.Width<250 && img.Height<300)
                    {
                        dtFiltered.Rows.RemoveAt(j);
                    }    
                }
            }
            else if(materialComboBox1.Text == "Medium")
            {
                int Count_rows_dtSearch = dtFiltered.Rows.Count;
                for (int j = 0; j < Count_rows_dtSearch; j++)
                {
                    Image img = Image.FromFile(dtFiltered.Rows[j]["Path"].ToString());
                    if (img.Width < 150 && img.Height < 200)  
                    {
                        dtFiltered.Rows.RemoveAt(j);
                    }

                }
            }
            else if (materialComboBox1.Text == "Small")
            {
                int Count_rows_dtSearch = dtFiltered.Rows.Count;
                for (int j = 0; j < Count_rows_dtSearch; j++)
                {
                    Image img = Image.FromFile(dtFiltered.Rows[j]["Path"].ToString());
                    if (img.Width < 50 && img.Height < 100)
                    {
                        dtFiltered.Rows.RemoveAt(j);
                    }

                }
            }

            // Filter by image format
            if (materialComboBox2.Text == "JPG")
            {
                int Count_rows_dtSearch = dtFiltered.Rows.Count;
                for (int j = 0; j < Count_rows_dtSearch; j++)
                {
                    if (dtFiltered.Rows[j]["Path"].ToString().ToLower().Contains(".jpg"))
                    {
                        dtFiltered.Rows.RemoveAt(j);
                    }
                }
            }
            else if (materialComboBox2.Text == "PNG")
            {
                int Count_rows_dtSearch = dtFiltered.Rows.Count;
                for (int j = 0; j < Count_rows_dtSearch; j++)
                {
                    if (dtFiltered.Rows[j]["Path"].ToString().ToLower().Contains(".png"))
                    {
                        dtFiltered.Rows.RemoveAt(j);
                    }
                }
            }

            // Filter by ranking
            if (materialComboBox3.Text == "Favorites")
            {
                dtFiltered.DefaultView.Sort = "Favorites DESC";
            }
            else if (materialComboBox3.Text == "Comments")
            {
                dtFiltered.DefaultView.Sort = "Comments DESC";
            }
            else if (materialComboBox3.Text == "Views")
            {
                dtFiltered.DefaultView.Sort = "Views DESC";
            }

            // Filter by image price
            if (materialComboBox4.Text == "Free")
            {
                int Count_rows_dtSearch = dtFiltered.Rows.Count;
                for (int j = 0; j < Count_rows_dtSearch; j++)
                {
                    if (dtFiltered.Rows[j]["Price"].ToString() == "0")
                    {
                        dtFiltered.Rows.RemoveAt(j);
                    }
                }
            }
            else if (materialComboBox4.Text == "Premium")
            {
                int Count_rows_dtSearch = dtFiltered.Rows.Count;
                for (int j = 0; j < Count_rows_dtSearch; j++)
                {
                    if (dtFiltered.Rows[j]["Price"].ToString() == "1")
                    {
                        dtFiltered.Rows.RemoveAt(j);
                    }
                }
            }

            int i = 0;
            foreach (Control control1 in this.panelShowResult_flowLayoutPanelResult_form1.Controls)
            {
                if (control1 is PictureBox)
                {
                    ((PictureBox)control1).Image = Image.FromFile(dtFiltered.Rows[i]["Path"].ToString());
                    i += 1;
                }
            }
            if (i < 29)
            {
                foreach (Control control1 in this.panelShowResult_flowLayoutPanelResult_form1.Controls)
                {
                    if (control1 is PictureBox && this.panelShowResult_flowLayoutPanelResult_form1.Controls.IndexOf(control1) == i)
                    {
                        ((PictureBox)control1).Visible = false; 
                        i += 1;
                    }
                }
            }
        }
        private void materialComboBox4_SelectionChangeCommitted(object sender, EventArgs e)
        {
            dtFiltered = new DataTable();
            updateDtFiltered();
            int count_filter_rows = dtFiltered.Rows.Count;
 
        }
        private void materialComboBox3_SelectionChangeCommitted(object sender, EventArgs e)
        {
            dtFiltered = new DataTable();

            updateDtFiltered();
            int count_filter_rows = dtFiltered.Rows.Count;
    
        }
        private void materialComboBox2_SelectionChangeCommitted(object sender, EventArgs e)
        {
            dtFiltered = new DataTable();
            updateDtFiltered();

        }
        private void materialComboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            dtFiltered = new DataTable();

            updateDtFiltered();

    
        }
        private void pictureBox_click_panelShowResult_flowLayoutPanelResult_form1_ShowingResult_1_Click(object sender, EventArgs e)
        {
            flowLayoutPanel_searchResult.Visible = false;
            flowLayoutPanelDetailPicture_form1.Visible = true;
            pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBox_click_panelShowResult_flowLayoutPanelResult_form1_ShowingResult_1.Image;
            button_click_panelDetailPicture_Favourites.Text = dtFiltered.Rows[0]["Favorites"].ToString() + "K Favourites";
            button_click_panelDetailPicture_Comments.Text = dtFiltered.Rows[0]["Comments"].ToString() + "K Comments";
            if (dtFiltered.Rows[0]["Price"].ToString() == "0")
            {
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Text = "Free";
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Image = Image.FromFile(@"../../UsedForInterface/icon/free.png");

            }
            else if (dtFiltered.Rows[0]["Price"].ToString() == "1")
            {
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Text = "Costly";
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Image = Image.FromFile(@"../../UsedForInterface/icon/premium-quality.png");
            }

            danhgiau_pictureBoxShowing = 90;
        }
        private void pictureBox_click_panelShowResult_flowLayoutPanelResult_form1_ShowingResult_2_Click(object sender, EventArgs e)
        {
            flowLayoutPanel_searchResult.Visible = false;
            flowLayoutPanelDetailPicture_form1.Visible = true;
            pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBox_click_panelShowResult_flowLayoutPanelResult_form1_ShowingResult_2.Image;
            button_click_panelDetailPicture_Favourites.Text = dtFiltered.Rows[1]["Favorites"].ToString() + "K Favourites";
            button_click_panelDetailPicture_Comments.Text = dtFiltered.Rows[1]["Comments"].ToString() + "K Comments";
            if (dtFiltered.Rows[1]["Price"].ToString() == "0")
            {
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Text = "Free";
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Image = Image.FromFile(@"../../UsedForInterface/icon/free.png");

            }
            else if (dtFiltered.Rows[1]["Price"].ToString() == "1")
            {
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Text = "Costly";
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Image = Image.FromFile(@"../../UsedForInterface/icon/premium-quality.png");
            }

            danhgiau_pictureBoxShowing = 91;
        }

        private void pictureBox_click_panelShowResult_flowLayoutPanelResult_form1_ShowingResult_3_Click(object sender, EventArgs e)
        {
            flowLayoutPanel_searchResult.Visible = false;
            flowLayoutPanelDetailPicture_form1.Visible = true;
            pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBox_click_panelShowResult_flowLayoutPanelResult_form1_ShowingResult_3.Image;
            button_click_panelDetailPicture_Favourites.Text = dtFiltered.Rows[2]["Favorites"].ToString() + "K Favourites";
            button_click_panelDetailPicture_Comments.Text = dtFiltered.Rows[2]["Comments"].ToString() + "K Comments";
            if (dtFiltered.Rows[2]["Price"].ToString() == "0")
            {
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Text = "Free";
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Image = Image.FromFile(@"../../UsedForInterface/icon/free.png");

            }
            else if (dtFiltered.Rows[2]["Price"].ToString() == "1")
            {
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Text = "Costly";
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Image = Image.FromFile(@"../../UsedForInterface/icon/premium-quality.png");
            }

            danhgiau_pictureBoxShowing = 92;
        }

        private void pictureBox_click_panelShowResult_flowLayoutPanelResult_form1_ShowingResult_4_Click(object sender, EventArgs e)
        {
            flowLayoutPanel_searchResult.Visible = false;
            flowLayoutPanelDetailPicture_form1.Visible = true;
            pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBox_click_panelShowResult_flowLayoutPanelResult_form1_ShowingResult_4.Image;
            button_click_panelDetailPicture_Favourites.Text = dtFiltered.Rows[3]["Favorites"].ToString() + "K Favourites";
            button_click_panelDetailPicture_Comments.Text = dtFiltered.Rows[3]["Comments"].ToString() + "K Comments";
            if (dtFiltered.Rows[3]["Price"].ToString() == "0")
            {
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Text = "Free";
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Image = Image.FromFile(@"../../UsedForInterface/icon/free.png");

            }
            else if (dtFiltered.Rows[3]["Price"].ToString() == "1")
            {
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Text = "Costly";
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Image = Image.FromFile(@"../../UsedForInterface/icon/premium-quality.png");
            }

            danhgiau_pictureBoxShowing = 93;
        }

        private void pictureBox_click_panelShowResult_flowLayoutPanelResult_form1_ShowingResult_5_Click(object sender, EventArgs e)
        {
            flowLayoutPanel_searchResult.Visible = false;
            flowLayoutPanelDetailPicture_form1.Visible = true;
            pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBox_click_panelShowResult_flowLayoutPanelResult_form1_ShowingResult_5.Image;
            button_click_panelDetailPicture_Favourites.Text = dtFiltered.Rows[4]["Favorites"].ToString() + "K Favourites";
            button_click_panelDetailPicture_Comments.Text = dtFiltered.Rows[4]["Comments"].ToString() + "K Comments";
            if (dtFiltered.Rows[4]["Price"].ToString() == "0")
            {
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Text = "Free";
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Image = Image.FromFile(@"../../UsedForInterface/icon/free.png");

            }
            else if (dtFiltered.Rows[4]["Price"].ToString() == "1")
            {
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Text = "Costly";
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Image = Image.FromFile(@"../../UsedForInterface/icon/premium-quality.png");
            }

            danhgiau_pictureBoxShowing = 94;
        }

        private void pictureBox_click_panelShowResult_flowLayoutPanelResult_form1_ShowingResult_6_Click(object sender, EventArgs e)
        {
            flowLayoutPanel_searchResult.Visible = false;
            flowLayoutPanelDetailPicture_form1.Visible = true;
            pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBox_click_panelShowResult_flowLayoutPanelResult_form1_ShowingResult_6.Image;
            button_click_panelDetailPicture_Favourites.Text = dtFiltered.Rows[5]["Favorites"].ToString() + "K Favourites";
            button_click_panelDetailPicture_Comments.Text = dtFiltered.Rows[5]["Comments"].ToString() + "K Comments";
            if (dtFiltered.Rows[5]["Price"].ToString() == "0")
            {
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Text = "Free";
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Image = Image.FromFile(@"../../UsedForInterface/icon/free.png");

            }
            else if (dtFiltered.Rows[5]["Price"].ToString() == "1")
            {
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Text = "Costly";
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Image = Image.FromFile(@"../../UsedForInterface/icon/premium-quality.png");
            }

            danhgiau_pictureBoxShowing = 95;
        }

        private void pictureBox_click_panelShowResult_flowLayoutPanelResult_form1_ShowingResult_7_Click(object sender, EventArgs e)
        {
            flowLayoutPanel_searchResult.Visible = false;
            flowLayoutPanelDetailPicture_form1.Visible = true;
            pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBox_click_panelShowResult_flowLayoutPanelResult_form1_ShowingResult_7.Image;
            button_click_panelDetailPicture_Favourites.Text = dtFiltered.Rows[6]["Favorites"].ToString() + "K Favourites";
            button_click_panelDetailPicture_Comments.Text = dtFiltered.Rows[6]["Comments"].ToString() + "K Comments";
            if (dtFiltered.Rows[6]["Price"].ToString() == "0")
            {
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Text = "Free";
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Image = Image.FromFile(@"../../UsedForInterface/icon/free.png");

            }
            else if (dtFiltered.Rows[6]["Price"].ToString() == "1")
            {
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Text = "Costly";
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Image = Image.FromFile(@"../../UsedForInterface/icon/premium-quality.png");
            }

            danhgiau_pictureBoxShowing = 96;
        }

        private void pictureBox_click_panelShowResult_flowLayoutPanelResult_form1_ShowingResult_8_Click(object sender, EventArgs e)
        {
            flowLayoutPanel_searchResult.Visible = false;
            flowLayoutPanelDetailPicture_form1.Visible = true;
            pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBox_click_panelShowResult_flowLayoutPanelResult_form1_ShowingResult_8.Image;
            button_click_panelDetailPicture_Favourites.Text = dtFiltered.Rows[7]["Favorites"].ToString() + "K Favourites";
            button_click_panelDetailPicture_Comments.Text = dtFiltered.Rows[7]["Comments"].ToString() + "K Comments";
            if (dtFiltered.Rows[7]["Price"].ToString() == "0")
            {
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Text = "Free";
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Image = Image.FromFile(@"../../UsedForInterface/icon/free.png");

            }
            else if (dtFiltered.Rows[7]["Price"].ToString() == "1")
            {
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Text = "Costly";
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Image = Image.FromFile(@"../../UsedForInterface/icon/premium-quality.png");
            }

            danhgiau_pictureBoxShowing = 97;
        }

        private void pictureBox_click_panelShowResult_flowLayoutPanelResult_form1_ShowingResult_9_Click(object sender, EventArgs e)
        {
            flowLayoutPanel_searchResult.Visible = false;
            flowLayoutPanelDetailPicture_form1.Visible = true;
            pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBox_click_panelShowResult_flowLayoutPanelResult_form1_ShowingResult_9.Image;
            button_click_panelDetailPicture_Favourites.Text = dtFiltered.Rows[8]["Favorites"].ToString() + "K Favourites";
            button_click_panelDetailPicture_Comments.Text = dtFiltered.Rows[8]["Comments"].ToString() + "K Comments";
            if (dtFiltered.Rows[8]["Price"].ToString() == "0")
            {
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Text = "Free";
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Image = Image.FromFile(@"../../UsedForInterface/icon/free.png");

            }
            else if (dtFiltered.Rows[8]["Price"].ToString() == "1")
            {
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Text = "Costly";
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Image = Image.FromFile(@"../../UsedForInterface/icon/premium-quality.png");
            }

            danhgiau_pictureBoxShowing = 98;
        }

        private void pictureBox_click_panelShowResult_flowLayoutPanelResult_form1_ShowingResult_10_Click(object sender, EventArgs e)
        {
            flowLayoutPanel_searchResult.Visible = false;
            flowLayoutPanelDetailPicture_form1.Visible = true;
            pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBox_click_panelShowResult_flowLayoutPanelResult_form1_ShowingResult_10.Image;
            button_click_panelDetailPicture_Favourites.Text = dtFiltered.Rows[9]["Favorites"].ToString() + "K Favourites";
            button_click_panelDetailPicture_Comments.Text = dtFiltered.Rows[9]["Comments"].ToString() + "K Comments";
            if (dtFiltered.Rows[9]["Price"].ToString() == "0")
            {
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Text = "Free";
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Image = Image.FromFile(@"../../UsedForInterface/icon/free.png");

            }
            else if (dtFiltered.Rows[9]["Price"].ToString() == "1")
            {
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Text = "Costly";
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Image = Image.FromFile(@"../../UsedForInterface/icon/premium-quality.png");
            }

            danhgiau_pictureBoxShowing = 99;
        }

        private void pictureBox_click_panelShowResult_flowLayoutPanelResult_form1_ShowingResult_11_Click(object sender, EventArgs e)
        {
            flowLayoutPanel_searchResult.Visible = false;
            flowLayoutPanelDetailPicture_form1.Visible = true;
            pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBox_click_panelShowResult_flowLayoutPanelResult_form1_ShowingResult_11.Image;
            button_click_panelDetailPicture_Favourites.Text = dtFiltered.Rows[10]["Favorites"].ToString() + "K Favourites";
            button_click_panelDetailPicture_Comments.Text = dtFiltered.Rows[10]["Comments"].ToString() + "K Comments";
            if (dtFiltered.Rows[10]["Price"].ToString() == "0")
            {
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Text = "Free";
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Image = Image.FromFile(@"../../UsedForInterface/icon/free.png");

            }
            else if (dtFiltered.Rows[10]["Price"].ToString() == "1")
            {
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Text = "Costly";
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Image = Image.FromFile(@"../../UsedForInterface/icon/premium-quality.png");
            }

            danhgiau_pictureBoxShowing = 100;
        }

        private void pictureBox_click_panelShowResult_flowLayoutPanelResult_form1_ShowingResult_12_Click(object sender, EventArgs e)
        {
            flowLayoutPanel_searchResult.Visible = false;
            flowLayoutPanelDetailPicture_form1.Visible = true;
            pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBox_click_panelShowResult_flowLayoutPanelResult_form1_ShowingResult_12.Image;
            button_click_panelDetailPicture_Favourites.Text = dtFiltered.Rows[11]["Favorites"].ToString() + "K Favourites";
            button_click_panelDetailPicture_Comments.Text = dtFiltered.Rows[11]["Comments"].ToString() + "K Comments";
            if (dtFiltered.Rows[11]["Price"].ToString() == "0")
            {
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Text = "Free";
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Image = Image.FromFile(@"../../UsedForInterface/icon/free.png");

            }
            else if (dtFiltered.Rows[11]["Price"].ToString() == "1")
            {
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Text = "Costly";
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Image = Image.FromFile(@"../../UsedForInterface/icon/premium-quality.png");
            }

            danhgiau_pictureBoxShowing = 101;
        }

        private void pictureBox_click_panelShowResult_flowLayoutPanelResult_form1_ShowingResult_13_Click(object sender, EventArgs e)
        {

            flowLayoutPanel_searchResult.Visible = false;
            flowLayoutPanelDetailPicture_form1.Visible = true;
            pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBox_click_panelShowResult_flowLayoutPanelResult_form1_ShowingResult_13.Image;
            button_click_panelDetailPicture_Favourites.Text = dtFiltered.Rows[12]["Favorites"].ToString() + "K Favourites";
            button_click_panelDetailPicture_Comments.Text = dtFiltered.Rows[12]["Comments"].ToString() + "K Comments";
            if (dtFiltered.Rows[12]["Price"].ToString() == "0")
            {
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Text = "Free";
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Image = Image.FromFile(@"../../UsedForInterface/icon/free.png");

            }
            else if (dtFiltered.Rows[12]["Price"].ToString() == "1")
            {
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Text = "Costly";
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Image = Image.FromFile(@"../../UsedForInterface/icon/premium-quality.png");
            }

            danhgiau_pictureBoxShowing = 102;

        }

        private void pictureBox_click_panelShowResult_flowLayoutPanelResult_form1_ShowingResult_14_Click(object sender, EventArgs e)
        {
            flowLayoutPanel_searchResult.Visible = false;
            flowLayoutPanelDetailPicture_form1.Visible = true;
            pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBox_click_panelShowResult_flowLayoutPanelResult_form1_ShowingResult_14.Image;
            button_click_panelDetailPicture_Favourites.Text = dtFiltered.Rows[13]["Favorites"].ToString() + "K Favourites";
            button_click_panelDetailPicture_Comments.Text = dtFiltered.Rows[13]["Comments"].ToString() + "K Comments";
            if (dtFiltered.Rows[13]["Price"].ToString() == "0")
            {
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Text = "Free";
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Image = Image.FromFile(@"../../UsedForInterface/icon/free.png");

            }
            else if (dtFiltered.Rows[13]["Price"].ToString() == "1")
            {
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Text = "Costly";
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Image = Image.FromFile(@"../../UsedForInterface/icon/premium-quality.png");
            }

            danhgiau_pictureBoxShowing = 103;
        }

        private void pictureBox_click_panelShowResult_flowLayoutPanelResult_form1_ShowingResult_15_Click(object sender, EventArgs e)
        {
            flowLayoutPanel_searchResult.Visible = false;
            flowLayoutPanelDetailPicture_form1.Visible = true;
            pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBox_click_panelShowResult_flowLayoutPanelResult_form1_ShowingResult_15.Image;
            button_click_panelDetailPicture_Favourites.Text = dtFiltered.Rows[14]["Favorites"].ToString() + "K Favourites";
            button_click_panelDetailPicture_Comments.Text = dtFiltered.Rows[14]["Comments"].ToString() + "K Comments";
            if (dtFiltered.Rows[14]["Price"].ToString() == "0")
            {
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Text = "Free";
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Image = Image.FromFile(@"../../UsedForInterface/icon/free.png");

            }
            else if (dtFiltered.Rows[14]["Price"].ToString() == "1")
            {
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Text = "Costly";
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Image = Image.FromFile(@"../../UsedForInterface/icon/premium-quality.png");
            }

            danhgiau_pictureBoxShowing = 104;
        }

        private void pictureBox_click_panelShowResult_flowLayoutPanelResult_form1_ShowingResult_16_Click(object sender, EventArgs e)
        {
            flowLayoutPanel_searchResult.Visible = false;
            flowLayoutPanelDetailPicture_form1.Visible = true;
            pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBox_click_panelShowResult_flowLayoutPanelResult_form1_ShowingResult_16.Image;
            button_click_panelDetailPicture_Favourites.Text = dtFiltered.Rows[15]["Favorites"].ToString() + "K Favourites";
            button_click_panelDetailPicture_Comments.Text = dtFiltered.Rows[15]["Comments"].ToString() + "K Comments";
            if (dtFiltered.Rows[15]["Price"].ToString() == "0")
            {
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Text = "Free";
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Image = Image.FromFile(@"../../UsedForInterface/icon/free.png");

            }
            else if (dtFiltered.Rows[15]["Price"].ToString() == "1")
            {
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Text = "Costly";
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Image = Image.FromFile(@"../../UsedForInterface/icon/premium-quality.png");
            }

            danhgiau_pictureBoxShowing = 105;
        }

        private void pictureBox_click_panelShowResult_flowLayoutPanelResult_form1_ShowingResult_17_Click(object sender, EventArgs e)
        {
            flowLayoutPanel_searchResult.Visible = false;
            flowLayoutPanelDetailPicture_form1.Visible = true;
            pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBox_click_panelShowResult_flowLayoutPanelResult_form1_ShowingResult_17.Image;
            button_click_panelDetailPicture_Favourites.Text = dtFiltered.Rows[16]["Favorites"].ToString() + "K Favourites";
            button_click_panelDetailPicture_Comments.Text = dtFiltered.Rows[16]["Comments"].ToString() + "K Comments";
            if (dtFiltered.Rows[16]["Price"].ToString() == "0")
            {
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Text = "Free";
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Image = Image.FromFile(@"../../UsedForInterface/icon/free.png");

            }
            else if (dtFiltered.Rows[16]["Price"].ToString() == "1")
            {
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Text = "Costly";
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Image = Image.FromFile(@"../../UsedForInterface/icon/premium-quality.png");
            }

            danhgiau_pictureBoxShowing = 106;
        }

        private void pictureBox_click_panelShowResult_flowLayoutPanelResult_form1_ShowingResult_18_Click(object sender, EventArgs e)
        {
            flowLayoutPanel_searchResult.Visible = false;
            flowLayoutPanelDetailPicture_form1.Visible = true;
            pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBox_click_panelShowResult_flowLayoutPanelResult_form1_ShowingResult_18.Image;
            button_click_panelDetailPicture_Favourites.Text = dtFiltered.Rows[17]["Favorites"].ToString() + "K Favourites";
            button_click_panelDetailPicture_Comments.Text = dtFiltered.Rows[17]["Comments"].ToString() + "K Comments";
            if (dtFiltered.Rows[17]["Price"].ToString() == "0")
            {
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Text = "Free";
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Image = Image.FromFile(@"../../UsedForInterface/icon/free.png");

            }
            else if (dtFiltered.Rows[17]["Price"].ToString() == "1")
            {
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Text = "Costly";
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Image = Image.FromFile(@"../../UsedForInterface/icon/premium-quality.png");
            }

            danhgiau_pictureBoxShowing = 107;
        }

        private void pictureBox_click_panelShowResult_flowLayoutPanelResult_form1_ShowingResult_19_Click(object sender, EventArgs e)
        {
            flowLayoutPanel_searchResult.Visible = false;
            flowLayoutPanelDetailPicture_form1.Visible = true;
            pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBox_click_panelShowResult_flowLayoutPanelResult_form1_ShowingResult_19.Image;
            button_click_panelDetailPicture_Favourites.Text = dtFiltered.Rows[18]["Favorites"].ToString() + "K Favourites";
            button_click_panelDetailPicture_Comments.Text = dtFiltered.Rows[18]["Comments"].ToString() + "K Comments";
            if (dtFiltered.Rows[18]["Price"].ToString() == "0")
            {
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Text = "Free";
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Image = Image.FromFile(@"../../UsedForInterface/icon/free.png");

            }
            else if (dtFiltered.Rows[18]["Price"].ToString() == "1")
            {
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Text = "Costly";
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Image = Image.FromFile(@"../../UsedForInterface/icon/premium-quality.png");
            }
        
            danhgiau_pictureBoxShowing = 108;
        }

        private void pictureBox_click_panelShowResult_flowLayoutPanelResult_form1_ShowingResult_20_Click(object sender, EventArgs e)
        {
            flowLayoutPanel_searchResult.Visible = false;
            flowLayoutPanelDetailPicture_form1.Visible = true;
            pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBox_click_panelShowResult_flowLayoutPanelResult_form1_ShowingResult_20.Image;
            button_click_panelDetailPicture_Favourites.Text = dtFiltered.Rows[19]["Favorites"].ToString() + "K Favourites";
            button_click_panelDetailPicture_Comments.Text = dtFiltered.Rows[19]["Comments"].ToString() + "K Comments";
            if (dtFiltered.Rows[19]["Price"].ToString() == "0")
            {
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Text = "Free";
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Image = Image.FromFile(@"../../UsedForInterface/icon/free.png");

            }
            else if (dtFiltered.Rows[19]["Price"].ToString() == "1")
            {
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Text = "Costly";
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Image = Image.FromFile(@"../../UsedForInterface/icon/premium-quality.png");
            }

            danhgiau_pictureBoxShowing = 109;
        }

        private void pictureBox_click_panelShowResult_flowLayoutPanelResult_form1_ShowingResult_21_Click(object sender, EventArgs e)
        {
            flowLayoutPanel_searchResult.Visible = false;
            flowLayoutPanelDetailPicture_form1.Visible = true;
            pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBox_click_panelShowResult_flowLayoutPanelResult_form1_ShowingResult_21.Image;
            button_click_panelDetailPicture_Favourites.Text = dtFiltered.Rows[20]["Favorites"].ToString() + "K Favourites";
            button_click_panelDetailPicture_Comments.Text = dtFiltered.Rows[20]["Comments"].ToString() + "K Comments";
            if (dtFiltered.Rows[20]["Price"].ToString() == "0")
            {
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Text = "Free";
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Image = Image.FromFile(@"../../UsedForInterface/icon/free.png");

            }
            else if (dtFiltered.Rows[20]["Price"].ToString() == "1")
            {
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Text = "Costly";
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Image = Image.FromFile(@"../../UsedForInterface/icon/premium-quality.png");
            }

            danhgiau_pictureBoxShowing = 110;
        }

        private void pictureBox_click_panelShowResult_flowLayoutPanelResult_form1_ShowingResult_22_Click(object sender, EventArgs e)
        {
            flowLayoutPanel_searchResult.Visible = false;
            flowLayoutPanelDetailPicture_form1.Visible = true;
            pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBox_click_panelShowResult_flowLayoutPanelResult_form1_ShowingResult_22.Image;
            button_click_panelDetailPicture_Favourites.Text = dtFiltered.Rows[21]["Favorites"].ToString() + "K Favourites";
            button_click_panelDetailPicture_Comments.Text = dtFiltered.Rows[21]["Comments"].ToString() + "K Comments";
            if (dtFiltered.Rows[21]["Price"].ToString() == "0")
            {
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Text = "Free";
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Image = Image.FromFile(@"../../UsedForInterface/icon/free.png");

            }
            else if (dtFiltered.Rows[21]["Price"].ToString() == "1")
            {
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Text = "Costly";
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Image = Image.FromFile(@"../../UsedForInterface/icon/premium-quality.png");
            }

            danhgiau_pictureBoxShowing = 111;
        }

        private void pictureBox_click_panelShowResult_flowLayoutPanelResult_form1_ShowingResult_23_Click(object sender, EventArgs e)
        {
            flowLayoutPanel_searchResult.Visible = false;
            flowLayoutPanelDetailPicture_form1.Visible = true;
            pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBox_click_panelShowResult_flowLayoutPanelResult_form1_ShowingResult_23.Image;
            button_click_panelDetailPicture_Favourites.Text = dtFiltered.Rows[22]["Favorites"].ToString() + "K Favourites";
            button_click_panelDetailPicture_Comments.Text = dtFiltered.Rows[22]["Comments"].ToString() + "K Comments";
            if (dtFiltered.Rows[22]["Price"].ToString() == "0")
            {
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Text = "Free";
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Image = Image.FromFile(@"../../UsedForInterface/icon/free.png");

            }
            else if (dtFiltered.Rows[22]["Price"].ToString() == "1")
            {
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Text = "Costly";
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Image = Image.FromFile(@"../../UsedForInterface/icon/premium-quality.png");
            }

            danhgiau_pictureBoxShowing = 112;
        }

        private void pictureBox_click_panelShowResult_flowLayoutPanelResult_form1_ShowingResult_24_Click(object sender, EventArgs e)
        {
            flowLayoutPanel_searchResult.Visible = false;
            flowLayoutPanelDetailPicture_form1.Visible = true;
            pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBox_click_panelShowResult_flowLayoutPanelResult_form1_ShowingResult_24.Image;
            button_click_panelDetailPicture_Favourites.Text = dtFiltered.Rows[23]["Favorites"].ToString() + "K Favourites";
            button_click_panelDetailPicture_Comments.Text = dtFiltered.Rows[23]["Comments"].ToString() + "K Comments";
            if (dtFiltered.Rows[23]["Price"].ToString() == "0")
            {
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Text = "Free";
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Image = Image.FromFile(@"../../UsedForInterface/icon/free.png");

            }
            else if (dtFiltered.Rows[23]["Price"].ToString() == "1")
            {
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Text = "Costly";
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Image = Image.FromFile(@"../../UsedForInterface/icon/premium-quality.png");
            }

            danhgiau_pictureBoxShowing = 113;
        }

        private void pictureBox_click_panelShowResult_flowLayoutPanelResult_form1_ShowingResult_25_Click(object sender, EventArgs e)
        {
            flowLayoutPanel_searchResult.Visible = false;
            flowLayoutPanelDetailPicture_form1.Visible = true;
            pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBox_click_panelShowResult_flowLayoutPanelResult_form1_ShowingResult_25.Image;
            button_click_panelDetailPicture_Favourites.Text = dtFiltered.Rows[24]["Favorites"].ToString() + "K Favourites";
            button_click_panelDetailPicture_Comments.Text = dtFiltered.Rows[24]["Comments"].ToString() + "K Comments";
            if (dtFiltered.Rows[24]["Price"].ToString() == "0")
            {
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Text = "Free";
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Image = Image.FromFile(@"../../UsedForInterface/icon/free.png");

            }
            else if (dtFiltered.Rows[24]["Price"].ToString() == "1")
            {
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Text = "Costly";
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Image = Image.FromFile(@"../../UsedForInterface/icon/premium-quality.png");
            }

            danhgiau_pictureBoxShowing = 114;
        }

        private void pictureBox_click_panelShowResult_flowLayoutPanelResult_form1_ShowingResult_26_Click(object sender, EventArgs e)
        {
            flowLayoutPanel_searchResult.Visible = false;
            flowLayoutPanelDetailPicture_form1.Visible = true;
            pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBox_click_panelShowResult_flowLayoutPanelResult_form1_ShowingResult_26.Image;
            button_click_panelDetailPicture_Favourites.Text = dtFiltered.Rows[25]["Favorites"].ToString() + "K Favourites";
            button_click_panelDetailPicture_Comments.Text = dtFiltered.Rows[25]["Comments"].ToString() + "K Comments";
            if (dtFiltered.Rows[25]["Price"].ToString() == "0")
            {
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Text = "Free";
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Image = Image.FromFile(@"../../UsedForInterface/icon/free.png");

            }
            else if (dtFiltered.Rows[25]["Price"].ToString() == "1")
            {
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Text = "Costly";
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Image = Image.FromFile(@"../../UsedForInterface/icon/premium-quality.png");
            }

            danhgiau_pictureBoxShowing = 115;
        }

        private void pictureBox_click_panelShowResult_flowLayoutPanelResult_form1_ShowingResult_27_Click(object sender, EventArgs e)
        {
            flowLayoutPanel_searchResult.Visible = false;
            flowLayoutPanelDetailPicture_form1.Visible = true;
            pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBox_click_panelShowResult_flowLayoutPanelResult_form1_ShowingResult_27.Image;
            button_click_panelDetailPicture_Favourites.Text = dtFiltered.Rows[26]["Favorites"].ToString() + "K Favourites";
            button_click_panelDetailPicture_Comments.Text = dtFiltered.Rows[26]["Comments"].ToString() + "K Comments";
            if (dtFiltered.Rows[26]["Price"].ToString() == "0")
            {
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Text = "Free";
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Image = Image.FromFile(@"../../UsedForInterface/icon/free.png");

            }
            else if (dtFiltered.Rows[26]["Price"].ToString() == "1")
            {
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Text = "Costly";
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Image = Image.FromFile(@"../../UsedForInterface/icon/premium-quality.png");
            }

            danhgiau_pictureBoxShowing = 116;
        }

        private void pictureBox_click_panelShowResult_flowLayoutPanelResult_form1_ShowingResult_28_Click(object sender, EventArgs e)
        {
            flowLayoutPanel_searchResult.Visible = false;
            flowLayoutPanelDetailPicture_form1.Visible = true;
            pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBox_click_panelShowResult_flowLayoutPanelResult_form1_ShowingResult_28.Image;
            button_click_panelDetailPicture_Favourites.Text = dtFiltered.Rows[27]["Favorites"].ToString() + "K Favourites";
            button_click_panelDetailPicture_Comments.Text = dtFiltered.Rows[27]["Comments"].ToString() + "K Comments";
            if (dtFiltered.Rows[27]["Price"].ToString() == "0")
            {
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Text = "Free";
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Image = Image.FromFile(@"../../UsedForInterface/icon/free.png");

            }
            else if (dtFiltered.Rows[27]["Price"].ToString() == "1")
            {
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Text = "Costly";
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Image = Image.FromFile(@"../../UsedForInterface/icon/premium-quality.png");
            }

            danhgiau_pictureBoxShowing = 117;
        }

        private void pictureBox_click_panelShowResult_flowLayoutPanelResult_form1_ShowingResult_29_Click(object sender, EventArgs e)
        {
            flowLayoutPanel_searchResult.Visible = false;
            flowLayoutPanelDetailPicture_form1.Visible = true;
            pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBox_click_panelShowResult_flowLayoutPanelResult_form1_ShowingResult_29.Image;
            button_click_panelDetailPicture_Favourites.Text = dtFiltered.Rows[28]["Favorites"].ToString() + "K Favourites";
            button_click_panelDetailPicture_Comments.Text = dtFiltered.Rows[28]["Comments"].ToString() + "K Comments";
            if (dtFiltered.Rows[28]["Price"].ToString() == "0")
            {
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Text = "Free";
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Image = Image.FromFile(@"../../UsedForInterface/icon/free.png");

            }
            else if (dtFiltered.Rows[28]["Price"].ToString() == "1")
            {
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Text = "Costly";
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Image = Image.FromFile(@"../../UsedForInterface/icon/premium-quality.png");
            }

            danhgiau_pictureBoxShowing = 118;
        }

        private void pictureBox_click_panelShowResult_flowLayoutPanelResult_form1_ShowingResult_30_Click(object sender, EventArgs e)
        {
            flowLayoutPanel_searchResult.Visible = false;
            flowLayoutPanelDetailPicture_form1.Visible = true;
            pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBox_click_panelShowResult_flowLayoutPanelResult_form1_ShowingResult_30.Image;
            button_click_panelDetailPicture_Favourites.Text = dtFiltered.Rows[29]["Favorites"].ToString() + "K Favourites";
            button_click_panelDetailPicture_Comments.Text = dtFiltered.Rows[29]["Comments"].ToString() + "K Comments";
            if (dtFiltered.Rows[29]["Price"].ToString() == "0")
            {
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Text = "Free";
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Image = Image.FromFile(@"../../UsedForInterface/icon/free.png");

            }
            else if (dtFiltered.Rows[29]["Price"].ToString() == "1")
            {
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Text = "Costly";
                button_click_panelDetailPicture_flowLayoutPanelDetailPicture_PRICE.Image = Image.FromFile(@"../../UsedForInterface/icon/premium-quality.png");
            }

            danhgiau_pictureBoxShowing = 119;
        }
    }
}

