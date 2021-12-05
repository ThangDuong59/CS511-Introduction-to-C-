using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace doAnC_Sharp_Finale
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        DataTable dtCar = new DataTable();
        DataTable dtInterior = new DataTable();
        DataTable dtOceans = new DataTable();
        DataTable dtMotoBike = new DataTable();
        DataTable dtForest = new DataTable();
        DataTable dtFlower = new DataTable();


        private void Form1_Load(object sender, EventArgs e)
        {

            ///DataTable cho Categorized Car
            dtCar.Columns.Add("STT", typeof(string));
            dtCar.Columns.Add("Categorized", typeof(string));
            dtCar.Columns.Add("Path", typeof(string));
            ///DataTable cho Categorized Interior
            dtInterior.Columns.Add("STT", typeof(string));
            dtInterior.Columns.Add("Categorized", typeof(string));
            dtInterior.Columns.Add("Path", typeof(string));
            ///DataTable cho Categorized Oceans
            dtOceans.Columns.Add("STT", typeof(string));
            dtOceans.Columns.Add("Categorized", typeof(string));
            dtOceans.Columns.Add("Path", typeof(string));
            ///DataTable cho Categorized MotoBike
            dtMotoBike.Columns.Add("STT", typeof(string));
            dtMotoBike.Columns.Add("Categorized", typeof(string));
            dtMotoBike.Columns.Add("Path", typeof(string));
            ///DataTable cho Categorized Forest
            dtForest.Columns.Add("STT", typeof(string));
            dtForest.Columns.Add("Categorized", typeof(string));
            dtForest.Columns.Add("Path", typeof(string));
            ///DataTable cho Categorized Flower
            dtFlower.Columns.Add("STT", typeof(string));
            dtFlower.Columns.Add("Categorized", typeof(string));
            dtFlower.Columns.Add("Path", typeof(string));
            //////////////////////////////////////////// ADD THE DATA FOR CAR CATEGORIZED /////////////////////////////////////////////////////////////
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            dtCar.Rows.Add("1", "CAR", @"../../UsedForResource/Car/Car_1.jpg");


            dtCar.Rows.Add("2", "CAR", @"../../UsedForResource/Car/Car_2.jpg");

            dtCar.Rows.Add("3", "CAR", @"../../UsedForResource/Car/Car_3.jpg");

            dtCar.Rows.Add("4", "CAR", @"../../UsedForResource/Car/Car_4.jpg");
            dtCar.Rows.Add("5", "CAR", @"../../UsedForResource/Car/Car_5.jpg");

            dtCar.Rows.Add("6", "CAR", @"../../UsedForResource/Car/Car_6.jpg");

            dtCar.Rows.Add("7", "CAR", @"../../UsedForResource/Car/Car_7.jpg");

            dtCar.Rows.Add("8", "CAR", @"../../UsedForResource/Car/Car_8.jpg");

            dtCar.Rows.Add("9", "CAR", @"../../UsedForResource/Car/Car_9.jpg");

            dtCar.Rows.Add("10", "CAR", @"../../UsedForResource/Car/Car_10.jpg");

            dtCar.Rows.Add("11", "CAR", @"../../UsedForResource/Car/Car_11.jpg");

            dtCar.Rows.Add("12", "CAR", @"../../UsedForResource/Car/Car_12.jpg");

            dtCar.Rows.Add("13", "CAR", @"../../UsedForResource/Car/Car_13.jpg");

            dtCar.Rows.Add("14", "CAR", @"../../UsedForResource/Car/Car_14.jpg");

            dtCar.Rows.Add("15", "CAR", @"../../UsedForResource/Car/Car_15.jpg");

            dtCar.Rows.Add("16", "CAR", @"../../UsedForResource/Car/Car_16.jpg");

            dtCar.Rows.Add("17", "CAR", @"../../UsedForResource/Car/Car_17.jpg");

            dtCar.Rows.Add("18", "CAR", @"../../UsedForResource/Car/Car_18.jpg");

            dtCar.Rows.Add("19", "CAR", @"../../UsedForResource/Car/Car_19.jpg");

            dtCar.Rows.Add("20", "CAR", @"../../UsedForResource/Car/Car_20.jpg");

            dtCar.Rows.Add("21", "CAR", @"../../UsedForResource/Car/Car_21.jpg");

            dtCar.Rows.Add("22", "CAR", @"../../UsedForResource/Car/Car_22.jpg");

            dtCar.Rows.Add("23", "CAR", @"../../UsedForResource/Car/Car_23.jpg");

            dtCar.Rows.Add("24", "CAR", @"../../UsedForResource/Car/Car_24.jpg");

            dtCar.Rows.Add("25", "CAR", @"../../UsedForResource/Car/Car_25.jpg");

            dtCar.Rows.Add("26", "CAR", @"../../UsedForResource/Car/Car_26.jpg");

            dtCar.Rows.Add("27", "CAR", @"../../UsedForResource/Car/Car_27.jpg");

            dtCar.Rows.Add("28", "CAR", @"../../UsedForResource/Car/Car_28.jpg");

            dtCar.Rows.Add("29", "CAR", @"../../UsedForResource/Car/Car_29.jpg");

            dtCar.Rows.Add("30", "CAR", @"../../UsedForResource/Car/Car_30.jpg");

            dtCar.Rows.Add("31", "CAR", @"../../UsedForResource/Car/Car_31.jpg");

            dtCar.Rows.Add("32", "CAR", @"../../UsedForResource/Car/Car_32.jpg");

            dtCar.Rows.Add("33", "CAR", @"../../UsedForResource/Car/Car_33.jpg");

            dtCar.Rows.Add("34", "CAR", @"../../UsedForResource/Car/Car_34.jpg");

            dtCar.Rows.Add("35", "CAR", @"../../UsedForResource/Car/Car_35.jpg");

            dtCar.Rows.Add("36", "CAR", @"../../UsedForResource/Car/Car_36.jpg");

            dtCar.Rows.Add("37", "CAR", @"../../UsedForResource/Car/Car_37.jpg");

            dtCar.Rows.Add("38", "CAR", @"../../UsedForResource/Car/Car_38.jpg");

            dtCar.Rows.Add("39", "CAR", @"../../UsedForResource/Car/Car_39.jpg");

            dtCar.Rows.Add("40", "CAR", @"../../UsedForResource/Car/Car_40.jpg");

            dtCar.Rows.Add("41", "CAR", @"../../UsedForResource/Car/Car_41.jpg");

            dtCar.Rows.Add("42", "CAR", @"../../UsedForResource/Car/Car_42.jpg");

            dtCar.Rows.Add("43", "CAR", @"../../UsedForResource/Car/Car_43.jpg");

            dtCar.Rows.Add("44", "CAR", @"../../UsedForResource/Car/Car_44.jpg");

            dtCar.Rows.Add("45", "CAR", @"../../UsedForResource/Car/Car_45.jpg");

            dtCar.Rows.Add("46", "CAR", @"../../UsedForResource/Car/Car_46.jpg");

            dtCar.Rows.Add("47", "CAR", @"../../UsedForResource/Car/Car_47.jpg");

            dtCar.Rows.Add("48", "CAR", @"../../UsedForResource/Car/Car_48.jpg");

            dtCar.Rows.Add("49", "CAR", @"../../UsedForResource/Car/Car_49.jpg");

            dtCar.Rows.Add("50", "CAR", @"../../UsedForResource/Car/Car_50.jpg");

            dtCar.Rows.Add("51", "CAR", @"../../UsedForResource/Car/Car_51.jpg");

            dtCar.Rows.Add("52", "CAR", @"../../UsedForResource/Car/Car_52.jpg");

            dtCar.Rows.Add("53", "CAR", @"../../UsedForResource/Car/Car_53.jpg");

            dtCar.Rows.Add("54", "CAR", @"../../UsedForResource/Car/Car_54.jpg");

            dtCar.Rows.Add("55", "CAR", @"../../UsedForResource/Car/Car_55.jpg");

            dtCar.Rows.Add("56", "CAR", @"../../UsedForResource/Car/Car_56.jpg");

            dtCar.Rows.Add("57", "CAR", @"../../UsedForResource/Car/Car_57.jpg");

            dtCar.Rows.Add("58", "CAR", @"../../UsedForResource/Car/Car_58.jpg");

            dtCar.Rows.Add("59", "CAR", @"../../UsedForResource/Car/Car_59.jpg");

            dtCar.Rows.Add("60", "CAR", @"../../UsedForResource/Car/Car_60.jpg");

            dtCar.Rows.Add("61", "CAR", @"../../UsedForResource/Car/Car_61.jpg");

            dtCar.Rows.Add("62", "CAR", @"../../UsedForResource/Car/Car_62.jpg");

            dtCar.Rows.Add("63", "CAR", @"../../UsedForResource/Car/Car_63.jpg");

            dtCar.Rows.Add("64", "CAR", @"../../UsedForResource/Car/Car_64.jpg");

            dtCar.Rows.Add("65", "CAR", @"../../UsedForResource/Car/Car_65.jpg");

            dtCar.Rows.Add("66", "CAR", @"../../UsedForResource/Car/Car_66.jpg");

            dtCar.Rows.Add("67", "CAR", @"../../UsedForResource/Car/Car_67.jpg");

            dtCar.Rows.Add("68", "CAR", @"../../UsedForResource/Car/Car_68.jpg");

            dtCar.Rows.Add("69", "CAR", @"../../UsedForResource/Car/Car_69.jpg");

            dtCar.Rows.Add("70", "CAR", @"../../UsedForResource/Car/Car_70.jpg");

            dtCar.Rows.Add("71", "CAR", @"../../UsedForResource/Car/Car_71.jpg");

            dtCar.Rows.Add("72", "CAR", @"../../UsedForResource/Car/Car_72.jpg");

            dtCar.Rows.Add("73", "CAR", @"../../UsedForResource/Car/Car_73.jpg");

            dtCar.Rows.Add("74", "CAR", @"../../UsedForResource/Car/Car_74.jpg");

            dtCar.Rows.Add("75", "CAR", @"../../UsedForResource/Car/Car_75.jpg");

            dtCar.Rows.Add("76", "CAR", @"../../UsedForResource/Car/Car_76.jpg");

            dtCar.Rows.Add("77", "CAR", @"../../UsedForResource/Car/Car_77.jpg");

            dtCar.Rows.Add("78", "CAR", @"../../UsedForResource/Car/Car_78.jpg");

            dtCar.Rows.Add("79", "CAR", @"../../UsedForResource/Car/Car_79.jpg");

            dtCar.Rows.Add("80", "CAR", @"../../UsedForResource/Car/Car_80.jpg");

            dtCar.Rows.Add("81", "CAR", @"../../UsedForResource/Car/Car_81.jpg");

            dtCar.Rows.Add("82", "CAR", @"../../UsedForResource/Car/Car_82.jpg");

            dtCar.Rows.Add("83", "CAR", @"../../UsedForResource/Car/Car_83.jpg");

            dtCar.Rows.Add("84", "CAR", @"../../UsedForResource/Car/Car_84.jpg");

            dtCar.Rows.Add("85", "CAR", @"../../UsedForResource/Car/Car_85.jpg");

            dtCar.Rows.Add("86", "CAR", @"../../UsedForResource/Car/Car_86.jpg");

            dtCar.Rows.Add("87", "CAR", @"../../UsedForResource/Car/Car_87.jpg");

            dtCar.Rows.Add("88", "CAR", @"../../UsedForResource/Car/Car_88.jpg");

            dtCar.Rows.Add("89", "CAR", @"../../UsedForResource/Car/Car_89.jpg");

            dtCar.Rows.Add("90", "CAR", @"../../UsedForResource/Car/Car_90.jpg");

            dtCar.Rows.Add("91", "CAR", @"../../UsedForResource/Car/Car_91.jpg");

            dtCar.Rows.Add("92", "CAR", @"../../UsedForResource/Car/Car_92.jpg");

            dtCar.Rows.Add("93", "CAR", @"../../UsedForResource/Car/Car_93.jpg");

            dtCar.Rows.Add("94", "CAR", @"../../UsedForResource/Car/Car_94.jpg");

            dtCar.Rows.Add("95", "CAR", @"../../UsedForResource/Car/Car_95.jpg");

            dtCar.Rows.Add("96", "CAR", @"../../UsedForResource/Car/Car_96.jpg");

            dtCar.Rows.Add("97", "CAR", @"../../UsedForResource/Car/Car_97.jpg");

            dtCar.Rows.Add("98", "CAR", @"../../UsedForResource/Car/Car_98.jpg");

            dtCar.Rows.Add("99", "CAR", @"../../UsedForResource/Car/Car_99.jpg");

            dtCar.Rows.Add("100", "CAR", @"../../UsedForResource/Car/Car_100.jpg");

            dtCar.Rows.Add("101", "CAR", @"../../UsedForResource/Car/Car_101.jpg");

            dtCar.Rows.Add("102", "CAR", @"../../UsedForResource/Car/Car_102.jpg");

            dtCar.Rows.Add("103", "CAR", @"../../UsedForResource/Car/Car_103.jpg");

            dtCar.Rows.Add("104", "CAR", @"../../UsedForResource/Car/Car_104.jpg");

            dtCar.Rows.Add("105", "CAR", @"../../UsedForResource/Car/Car_105.jpg");

            dtCar.Rows.Add("106", "CAR", @"../../UsedForResource/Car/Car_106.jpg");

            dtCar.Rows.Add("107", "CAR", @"../../UsedForResource/Car/Car_107.jpg");

            dtCar.Rows.Add("108", "CAR", @"../../UsedForResource/Car/Car_108.jpg");

            dtCar.Rows.Add("109", "CAR", @"../../UsedForResource/Car/Car_109.jpg");

            dtCar.Rows.Add("110", "CAR", @"../../UsedForResource/Car/Car_110.jpg");

            dtCar.Rows.Add("111", "CAR", @"../../UsedForResource/Car/Car_111.jpg");

            dtCar.Rows.Add("112", "CAR", @"../../UsedForResource/Car/Car_112.jpg");

            dtCar.Rows.Add("113", "CAR", @"../../UsedForResource/Car/Car_113.jpg");

            dtCar.Rows.Add("114", "CAR", @"../../UsedForResource/Car/Car_114.jpg");

            dtCar.Rows.Add("115", "CAR", @"../../UsedForResource/Car/Car_115.jpg");

            dtCar.Rows.Add("116", "CAR", @"../../UsedForResource/Car/Car_116.jpg");

            dtCar.Rows.Add("117", "CAR", @"../../UsedForResource/Car/Car_117.jpg");

            dtCar.Rows.Add("118", "CAR", @"../../UsedForResource/Car/Car_118.jpg");

            dtCar.Rows.Add("119", "CAR", @"../../UsedForResource/Car/Car_119.jpg");

            dtCar.Rows.Add("120", "CAR", @"../../UsedForResource/Car/Car_120.jpg");

            dtCar.Rows.Add("121", "CAR", @"../../UsedForResource/Car/Car_121.jpg");

            dtCar.Rows.Add("122", "CAR", @"../../UsedForResource/Car/Car_122.jpg");

            dtCar.Rows.Add("123", "CAR", @"../../UsedForResource/Car/Car_123.jpg");

            dtCar.Rows.Add("124", "CAR", @"../../UsedForResource/Car/Car_124.jpg");

            dtCar.Rows.Add("125", "CAR", @"../../UsedForResource/Car/Car_125.jpg");

            dtCar.Rows.Add("126", "CAR", @"../../UsedForResource/Car/Car_126.jpg");

            dtCar.Rows.Add("127", "CAR", @"../../UsedForResource/Car/Car_127.jpg");

            dtCar.Rows.Add("128", "CAR", @"../../UsedForResource/Car/Car_128.jpg");

            dtCar.Rows.Add("129", "CAR", @"../../UsedForResource/Car/Car_129.jpg");

            dtCar.Rows.Add("130", "CAR", @"../../UsedForResource/Car/Car_130.jpg");

            dtCar.Rows.Add("131", "CAR", @"../../UsedForResource/Car/Car_131.jpg");

            dtCar.Rows.Add("132", "CAR", @"../../UsedForResource/Car/Car_132.jpg");

            dtCar.Rows.Add("133", "CAR", @"../../UsedForResource/Car/Car_133.jpg");

            dtCar.Rows.Add("134", "CAR", @"../../UsedForResource/Car/Car_134.jpg");

            dtCar.Rows.Add("135", "CAR", @"../../UsedForResource/Car/Car_135.jpg");

            dtCar.Rows.Add("136", "CAR", @"../../UsedForResource/Car/Car_136.jpg");

            dtCar.Rows.Add("137", "CAR", @"../../UsedForResource/Car/Car_137.jpg");

            dtCar.Rows.Add("138", "CAR", @"../../UsedForResource/Car/Car_138.jpg");

            dtCar.Rows.Add("139", "CAR", @"../../UsedForResource/Car/Car_139.jpg");

            dtCar.Rows.Add("140", "CAR", @"../../UsedForResource/Car/Car_140.jpg");

            dtCar.Rows.Add("141", "CAR", @"../../UsedForResource/Car/Car_141.jpg");

            dtCar.Rows.Add("142", "CAR", @"../../UsedForResource/Car/Car_142.jpg");

            dtCar.Rows.Add("143", "CAR", @"../../UsedForResource/Car/Car_143.jpg");

            dtCar.Rows.Add("144", "CAR", @"../../UsedForResource/Car/Car_144.jpg");

            dtCar.Rows.Add("145", "CAR", @"../../UsedForResource/Car/Car_145.jpg");

            dtCar.Rows.Add("146", "CAR", @"../../UsedForResource/Car/Car_146.jpg");

            dtCar.Rows.Add("147", "CAR", @"../../UsedForResource/Car/Car_147.jpg");

            dtCar.Rows.Add("148", "CAR", @"../../UsedForResource/Car/Car_148.jpg");

            dtCar.Rows.Add("149", "CAR", @"../../UsedForResource/Car/Car_149.jpg");

            dtCar.Rows.Add("150", "CAR", @"../../UsedForResource/Car/Car_150.jpg");

            dtCar.Rows.Add("151", "CAR", @"../../UsedForResource/Car/Car_151.jpg");

            dtCar.Rows.Add("152", "CAR", @"../../UsedForResource/Car/Car_152.jpg");

            dtCar.Rows.Add("153", "CAR", @"../../UsedForResource/Car/Car_153.jpg");

            dtCar.Rows.Add("154", "CAR", @"../../UsedForResource/Car/Car_154.jpg");

            dtCar.Rows.Add("155", "CAR", @"../../UsedForResource/Car/Car_155.jpg");

            dtCar.Rows.Add("156", "CAR", @"../../UsedForResource/Car/Car_156.jpg");

            dtCar.Rows.Add("157", "CAR", @"../../UsedForResource/Car/Car_157.jpg");
            //////////////////////////////////////////// ADD THE DATA FOR INTERIOR CATEGORIZED ////////////////////////////////////////////////////////
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            dtInterior.Rows.Add("1", "INTERIOR", @"../../UsedForResource/Interior/Interior_1.jpg");

            dtInterior.Rows.Add("2", "INTERIOR", @"../../UsedForResource/Interior/Interior_2.jpg");

            dtInterior.Rows.Add("3", "INTERIOR", @"../../UsedForResource/Interior/Interior_3.jpg");

            dtInterior.Rows.Add("4", "INTERIOR", @"../../UsedForResource/Interior/Interior_4.jpg");

            dtInterior.Rows.Add("5", "INTERIOR", @"../../UsedForResource/Interior/Interior_5.jpg");

            dtInterior.Rows.Add("6", "INTERIOR", @"../../UsedForResource/Interior/Interior_6.jpg");

            dtInterior.Rows.Add("7", "INTERIOR", @"../../UsedForResource/Interior/Interior_7.jpg");

            dtInterior.Rows.Add("8", "INTERIOR", @"../../UsedForResource/Interior/Interior_8.jpg");

            dtInterior.Rows.Add("9", "INTERIOR", @"../../UsedForResource/Interior/Interior_9.jpg");

            dtInterior.Rows.Add("10", "INTERIOR", @"../../UsedForResource/Interior/Interior_10.jpg");

            dtInterior.Rows.Add("11", "INTERIOR", @"../../UsedForResource/Interior/Interior_11.jpg");

            dtInterior.Rows.Add("12", "INTERIOR", @"../../UsedForResource/Interior/Interior_12.jpg");

            dtInterior.Rows.Add("13", "INTERIOR", @"../../UsedForResource/Interior/Interior_13.jpg");

            dtInterior.Rows.Add("14", "INTERIOR", @"../../UsedForResource/Interior/Interior_14.jpg");

            dtInterior.Rows.Add("15", "INTERIOR", @"../../UsedForResource/Interior/Interior_15.jpg");

            dtInterior.Rows.Add("16", "INTERIOR", @"../../UsedForResource/Interior/Interior_16.jpg");

            dtInterior.Rows.Add("17", "INTERIOR", @"../../UsedForResource/Interior/Interior_17.jpg");

            dtInterior.Rows.Add("18", "INTERIOR", @"../../UsedForResource/Interior/Interior_18.jpg");

            dtInterior.Rows.Add("19", "INTERIOR", @"../../UsedForResource/Interior/Interior_19.jpg");

            dtInterior.Rows.Add("20", "INTERIOR", @"../../UsedForResource/Interior/Interior_20.jpg");

            dtInterior.Rows.Add("21", "INTERIOR", @"../../UsedForResource/Interior/Interior_21.jpg");

            dtInterior.Rows.Add("22", "INTERIOR", @"../../UsedForResource/Interior/Interior_22.jpg");

            dtInterior.Rows.Add("23", "INTERIOR", @"../../UsedForResource/Interior/Interior_23.jpg");

            dtInterior.Rows.Add("24", "INTERIOR", @"../../UsedForResource/Interior/Interior_24.jpg");

            dtInterior.Rows.Add("25", "INTERIOR", @"../../UsedForResource/Interior/Interior_25.jpg");

            dtInterior.Rows.Add("26", "INTERIOR", @"../../UsedForResource/Interior/Interior_26.jpg");

            dtInterior.Rows.Add("27", "INTERIOR", @"../../UsedForResource/Interior/Interior_27.jpg");

            dtInterior.Rows.Add("28", "INTERIOR", @"../../UsedForResource/Interior/Interior_28.jpg");

            dtInterior.Rows.Add("29", "INTERIOR", @"../../UsedForResource/Interior/Interior_29.jpg");

            dtInterior.Rows.Add("30", "INTERIOR", @"../../UsedForResource/Interior/Interior_30.jpg");

            dtInterior.Rows.Add("31", "INTERIOR", @"../../UsedForResource/Interior/Interior_31.jpg");

            dtInterior.Rows.Add("32", "INTERIOR", @"../../UsedForResource/Interior/Interior_32.jpg");

            dtInterior.Rows.Add("33", "INTERIOR", @"../../UsedForResource/Interior/Interior_33.jpg");

            dtInterior.Rows.Add("34", "INTERIOR", @"../../UsedForResource/Interior/Interior_34.jpg");

            dtInterior.Rows.Add("35", "INTERIOR", @"../../UsedForResource/Interior/Interior_35.jpg");

            dtInterior.Rows.Add("36", "INTERIOR", @"../../UsedForResource/Interior/Interior_36.jpg");

            dtInterior.Rows.Add("37", "INTERIOR", @"../../UsedForResource/Interior/Interior_37.jpg");

            dtInterior.Rows.Add("38", "INTERIOR", @"../../UsedForResource/Interior/Interior_38.jpg");

            dtInterior.Rows.Add("39", "INTERIOR", @"../../UsedForResource/Interior/Interior_39.jpg");

            dtInterior.Rows.Add("40", "INTERIOR", @"../../UsedForResource/Interior/Interior_40.jpg");

            dtInterior.Rows.Add("41", "INTERIOR", @"../../UsedForResource/Interior/Interior_41.jpg");

            dtInterior.Rows.Add("42", "INTERIOR", @"../../UsedForResource/Interior/Interior_42.jpg");

            dtInterior.Rows.Add("43", "INTERIOR", @"../../UsedForResource/Interior/Interior_43.jpg");

            dtInterior.Rows.Add("44", "INTERIOR", @"../../UsedForResource/Interior/Interior_44.jpg");

            dtInterior.Rows.Add("45", "INTERIOR", @"../../UsedForResource/Interior/Interior_45.jpg");

            dtInterior.Rows.Add("46", "INTERIOR", @"../../UsedForResource/Interior/Interior_46.jpg");

            dtInterior.Rows.Add("47", "INTERIOR", @"../../UsedForResource/Interior/Interior_47.jpg");

            dtInterior.Rows.Add("48", "INTERIOR", @"../../UsedForResource/Interior/Interior_48.jpg");

            dtInterior.Rows.Add("49", "INTERIOR", @"../../UsedForResource/Interior/Interior_49.jpg");

            dtInterior.Rows.Add("50", "INTERIOR", @"../../UsedForResource/Interior/Interior_50.jpg");

            dtInterior.Rows.Add("51", "INTERIOR", @"../../UsedForResource/Interior/Interior_51.jpg");

            dtInterior.Rows.Add("52", "INTERIOR", @"../../UsedForResource/Interior/Interior_52.jpg");

            dtInterior.Rows.Add("53", "INTERIOR", @"../../UsedForResource/Interior/Interior_53.jpg");

            dtInterior.Rows.Add("54", "INTERIOR", @"../../UsedForResource/Interior/Interior_54.jpg");

            dtInterior.Rows.Add("55", "INTERIOR", @"../../UsedForResource/Interior/Interior_55.jpg");

            dtInterior.Rows.Add("56", "INTERIOR", @"../../UsedForResource/Interior/Interior_56.jpg");

            dtInterior.Rows.Add("57", "INTERIOR", @"../../UsedForResource/Interior/Interior_57.jpg");

            dtInterior.Rows.Add("58", "INTERIOR", @"../../UsedForResource/Interior/Interior_58.jpg");

            dtInterior.Rows.Add("59", "INTERIOR", @"../../UsedForResource/Interior/Interior_59.jpg");

            dtInterior.Rows.Add("60", "INTERIOR", @"../../UsedForResource/Interior/Interior_60.jpg");

            dtInterior.Rows.Add("61", "INTERIOR", @"../../UsedForResource/Interior/Interior_61.jpg");

            dtInterior.Rows.Add("62", "INTERIOR", @"../../UsedForResource/Interior/Interior_62.jpg");

            dtInterior.Rows.Add("63", "INTERIOR", @"../../UsedForResource/Interior/Interior_63.jpg");

            dtInterior.Rows.Add("64", "INTERIOR", @"../../UsedForResource/Interior/Interior_64.jpg");

            dtInterior.Rows.Add("65", "INTERIOR", @"../../UsedForResource/Interior/Interior_65.jpg");

            dtInterior.Rows.Add("66", "INTERIOR", @"../../UsedForResource/Interior/Interior_66.jpg");

            dtInterior.Rows.Add("67", "INTERIOR", @"../../UsedForResource/Interior/Interior_67.jpg");

            dtInterior.Rows.Add("68", "INTERIOR", @"../../UsedForResource/Interior/Interior_68.jpg");

            dtInterior.Rows.Add("69", "INTERIOR", @"../../UsedForResource/Interior/Interior_69.jpg");

            dtInterior.Rows.Add("70", "INTERIOR", @"../../UsedForResource/Interior/Interior_70.jpg");

            dtInterior.Rows.Add("71", "INTERIOR", @"../../UsedForResource/Interior/Interior_71.jpg");

            dtInterior.Rows.Add("72", "INTERIOR", @"../../UsedForResource/Interior/Interior_72.jpg");

            dtInterior.Rows.Add("73", "INTERIOR", @"../../UsedForResource/Interior/Interior_73.jpg");

            dtInterior.Rows.Add("74", "INTERIOR", @"../../UsedForResource/Interior/Interior_74.jpg");

            dtInterior.Rows.Add("75", "INTERIOR", @"../../UsedForResource/Interior/Interior_75.jpg");

            dtInterior.Rows.Add("76", "INTERIOR", @"../../UsedForResource/Interior/Interior_76.jpg");

            dtInterior.Rows.Add("77", "INTERIOR", @"../../UsedForResource/Interior/Interior_77.jpg");

            dtInterior.Rows.Add("78", "INTERIOR", @"../../UsedForResource/Interior/Interior_78.jpg");

            dtInterior.Rows.Add("79", "INTERIOR", @"../../UsedForResource/Interior/Interior_79.jpg");

            dtInterior.Rows.Add("80", "INTERIOR", @"../../UsedForResource/Interior/Interior_80.jpg");

            dtInterior.Rows.Add("81", "INTERIOR", @"../../UsedForResource/Interior/Interior_81.jpg");

            dtInterior.Rows.Add("82", "INTERIOR", @"../../UsedForResource/Interior/Interior_82.jpg");

            dtInterior.Rows.Add("83", "INTERIOR", @"../../UsedForResource/Interior/Interior_83.jpg");

            dtInterior.Rows.Add("84", "INTERIOR", @"../../UsedForResource/Interior/Interior_84.jpg");

            dtInterior.Rows.Add("85", "INTERIOR", @"../../UsedForResource/Interior/Interior_85.jpg");

            dtInterior.Rows.Add("86", "INTERIOR", @"../../UsedForResource/Interior/Interior_86.jpg");

            dtInterior.Rows.Add("87", "INTERIOR", @"../../UsedForResource/Interior/Interior_87.jpg");

            dtInterior.Rows.Add("88", "INTERIOR", @"../../UsedForResource/Interior/Interior_88.jpg");

            dtInterior.Rows.Add("89", "INTERIOR", @"../../UsedForResource/Interior/Interior_89.jpg");

            dtInterior.Rows.Add("90", "INTERIOR", @"../../UsedForResource/Interior/Interior_90.jpg");

            dtInterior.Rows.Add("91", "INTERIOR", @"../../UsedForResource/Interior/Interior_91.jpg");

            dtInterior.Rows.Add("92", "INTERIOR", @"../../UsedForResource/Interior/Interior_92.jpg");

            dtInterior.Rows.Add("93", "INTERIOR", @"../../UsedForResource/Interior/Interior_93.jpg");

            dtInterior.Rows.Add("94", "INTERIOR", @"../../UsedForResource/Interior/Interior_94.jpg");

            dtInterior.Rows.Add("95", "INTERIOR", @"../../UsedForResource/Interior/Interior_95.jpg");

            dtInterior.Rows.Add("96", "INTERIOR", @"../../UsedForResource/Interior/Interior_96.jpg");

            dtInterior.Rows.Add("97", "INTERIOR", @"../../UsedForResource/Interior/Interior_97.jpg");

            dtInterior.Rows.Add("98", "INTERIOR", @"../../UsedForResource/Interior/Interior_98.jpg");

            dtInterior.Rows.Add("99", "INTERIOR", @"../../UsedForResource/Interior/Interior_99.jpg");

            dtInterior.Rows.Add("100", "INTERIOR", @"../../UsedForResource/Interior/Interior_100.jpg");

            dtInterior.Rows.Add("101", "INTERIOR", @"../../UsedForResource/Interior/Interior_101.jpg");

            dtInterior.Rows.Add("102", "INTERIOR", @"../../UsedForResource/Interior/Interior_102.jpg");

            dtInterior.Rows.Add("103", "INTERIOR", @"../../UsedForResource/Interior/Interior_103.jpg");

            dtInterior.Rows.Add("104", "INTERIOR", @"../../UsedForResource/Interior/Interior_104.jpg");

            dtInterior.Rows.Add("105", "INTERIOR", @"../../UsedForResource/Interior/Interior_105.jpg");

            dtInterior.Rows.Add("106", "INTERIOR", @"../../UsedForResource/Interior/Interior_106.jpg");

            dtInterior.Rows.Add("107", "INTERIOR", @"../../UsedForResource/Interior/Interior_107.jpg");

            dtInterior.Rows.Add("108", "INTERIOR", @"../../UsedForResource/Interior/Interior_108.jpg");

            dtInterior.Rows.Add("109", "INTERIOR", @"../../UsedForResource/Interior/Interior_109.jpg");

            dtInterior.Rows.Add("110", "INTERIOR", @"../../UsedForResource/Interior/Interior_110.jpg");

            dtInterior.Rows.Add("111", "INTERIOR", @"../../UsedForResource/Interior/Interior_111.jpg");

            dtInterior.Rows.Add("112", "INTERIOR", @"../../UsedForResource/Interior/Interior_112.jpg");

            dtInterior.Rows.Add("113", "INTERIOR", @"../../UsedForResource/Interior/Interior_113.jpg");

            dtInterior.Rows.Add("114", "INTERIOR", @"../../UsedForResource/Interior/Interior_114.jpg");

            dtInterior.Rows.Add("115", "INTERIOR", @"../../UsedForResource/Interior/Interior_115.jpg");

            dtInterior.Rows.Add("116", "INTERIOR", @"../../UsedForResource/Interior/Interior_116.jpg");

            dtInterior.Rows.Add("117", "INTERIOR", @"../../UsedForResource/Interior/Interior_117.jpg");

            dtInterior.Rows.Add("118", "INTERIOR", @"../../UsedForResource/Interior/Interior_118.jpg");

            dtInterior.Rows.Add("119", "INTERIOR", @"../../UsedForResource/Interior/Interior_119.jpg");

            dtInterior.Rows.Add("120", "INTERIOR", @"../../UsedForResource/Interior/Interior_120.jpg");

            dtInterior.Rows.Add("121", "INTERIOR", @"../../UsedForResource/Interior/Interior_121.jpg");

            dtInterior.Rows.Add("122", "INTERIOR", @"../../UsedForResource/Interior/Interior_122.jpg");

            dtInterior.Rows.Add("123", "INTERIOR", @"../../UsedForResource/Interior/Interior_123.jpg");

            dtInterior.Rows.Add("124", "INTERIOR", @"../../UsedForResource/Interior/Interior_124.jpg");

            dtInterior.Rows.Add("125", "INTERIOR", @"../../UsedForResource/Interior/Interior_125.jpg");

            dtInterior.Rows.Add("126", "INTERIOR", @"../../UsedForResource/Interior/Interior_126.jpg");

            dtInterior.Rows.Add("127", "INTERIOR", @"../../UsedForResource/Interior/Interior_127.jpg");

            dtInterior.Rows.Add("128", "INTERIOR", @"../../UsedForResource/Interior/Interior_128.jpg");

            dtInterior.Rows.Add("129", "INTERIOR", @"../../UsedForResource/Interior/Interior_129.jpg");

            dtInterior.Rows.Add("130", "INTERIOR", @"../../UsedForResource/Interior/Interior_130.jpg");

            dtInterior.Rows.Add("131", "INTERIOR", @"../../UsedForResource/Interior/Interior_131.jpg");

            dtInterior.Rows.Add("132", "INTERIOR", @"../../UsedForResource/Interior/Interior_132.jpg");

            dtInterior.Rows.Add("133", "INTERIOR", @"../../UsedForResource/Interior/Interior_133.jpg");

            dtInterior.Rows.Add("134", "INTERIOR", @"../../UsedForResource/Interior/Interior_134.jpg");

            dtInterior.Rows.Add("135", "INTERIOR", @"../../UsedForResource/Interior/Interior_135.jpg");

            dtInterior.Rows.Add("136", "INTERIOR", @"../../UsedForResource/Interior/Interior_136.jpg");

            dtInterior.Rows.Add("137", "INTERIOR", @"../../UsedForResource/Interior/Interior_137.jpg");

            dtInterior.Rows.Add("138", "INTERIOR", @"../../UsedForResource/Interior/Interior_138.jpg");

            dtInterior.Rows.Add("139", "INTERIOR", @"../../UsedForResource/Interior/Interior_139.jpg");

            dtInterior.Rows.Add("140", "INTERIOR", @"../../UsedForResource/Interior/Interior_140.jpg");

            dtInterior.Rows.Add("141", "INTERIOR", @"../../UsedForResource/Interior/Interior_141.jpg");

            dtInterior.Rows.Add("142", "INTERIOR", @"../../UsedForResource/Interior/Interior_142.jpg");

            dtInterior.Rows.Add("143", "INTERIOR", @"../../UsedForResource/Interior/Interior_143.jpg");

            dtInterior.Rows.Add("144", "INTERIOR", @"../../UsedForResource/Interior/Interior_144.jpg");

            dtInterior.Rows.Add("145", "INTERIOR", @"../../UsedForResource/Interior/Interior_145.jpg");

            dtInterior.Rows.Add("146", "INTERIOR", @"../../UsedForResource/Interior/Interior_146.jpg");

            dtInterior.Rows.Add("147", "INTERIOR", @"../../UsedForResource/Interior/Interior_147.jpg");

            dtInterior.Rows.Add("148", "INTERIOR", @"../../UsedForResource/Interior/Interior_148.jpg");

            dtInterior.Rows.Add("149", "INTERIOR", @"../../UsedForResource/Interior/Interior_149.jpg");

            dtInterior.Rows.Add("150", "INTERIOR", @"../../UsedForResource/Interior/Interior_150.jpg");

            dtInterior.Rows.Add("151", "INTERIOR", @"../../UsedForResource/Interior/Interior_151.jpg");

            dtInterior.Rows.Add("152", "INTERIOR", @"../../UsedForResource/Interior/Interior_152.jpg");

            dtInterior.Rows.Add("153", "INTERIOR", @"../../UsedForResource/Interior/Interior_153.jpg");

            dtInterior.Rows.Add("154", "INTERIOR", @"../../UsedForResource/Interior/Interior_154.jpg");

            dtInterior.Rows.Add("155", "INTERIOR", @"../../UsedForResource/Interior/Interior_155.jpg");

            dtInterior.Rows.Add("156", "INTERIOR", @"../../UsedForResource/Interior/Interior_156.jpg");

            dtInterior.Rows.Add("157", "INTERIOR", @"../../UsedForResource/Interior/Interior_157.jpg");

            dtInterior.Rows.Add("158", "INTERIOR", @"../../UsedForResource/Interior/Interior_158.jpg");

            dtInterior.Rows.Add("159", "INTERIOR", @"../../UsedForResource/Interior/Interior_159.jpg");

            dtInterior.Rows.Add("160", "INTERIOR", @"../../UsedForResource/Interior/Interior_160.jpg");

            dtInterior.Rows.Add("161", "INTERIOR", @"../../UsedForResource/Interior/Interior_161.jpg");

            dtInterior.Rows.Add("162", "INTERIOR", @"../../UsedForResource/Interior/Interior_162.jpg");

            dtInterior.Rows.Add("163", "INTERIOR", @"../../UsedForResource/Interior/Interior_163.jpg");

            dtInterior.Rows.Add("164", "INTERIOR", @"../../UsedForResource/Interior/Interior_164.jpg");

            dtInterior.Rows.Add("165", "INTERIOR", @"../../UsedForResource/Interior/Interior_165.jpg");

            dtInterior.Rows.Add("166", "INTERIOR", @"../../UsedForResource/Interior/Interior_166.jpg");

            dtInterior.Rows.Add("167", "INTERIOR", @"../../UsedForResource/Interior/Interior_167.jpg");

            dtInterior.Rows.Add("168", "INTERIOR", @"../../UsedForResource/Interior/Interior_168.jpg");

            dtInterior.Rows.Add("169", "INTERIOR", @"../../UsedForResource/Interior/Interior_169.jpg");

            dtInterior.Rows.Add("170", "INTERIOR", @"../../UsedForResource/Interior/Interior_170.jpg");

            dtInterior.Rows.Add("171", "INTERIOR", @"../../UsedForResource/Interior/Interior_171.jpg");

            dtInterior.Rows.Add("172", "INTERIOR", @"../../UsedForResource/Interior/Interior_172.jpg");

            dtInterior.Rows.Add("173", "INTERIOR", @"../../UsedForResource/Interior/Interior_173.jpg");

            dtInterior.Rows.Add("174", "INTERIOR", @"../../UsedForResource/Interior/Interior_174.jpg");

            dtInterior.Rows.Add("175", "INTERIOR", @"../../UsedForResource/Interior/Interior_175.jpg");

            dtInterior.Rows.Add("176", "INTERIOR", @"../../UsedForResource/Interior/Interior_176.jpg");

            dtInterior.Rows.Add("177", "INTERIOR", @"../../UsedForResource/Interior/Interior_177.jpg");

            dtInterior.Rows.Add("178", "INTERIOR", @"../../UsedForResource/Interior/Interior_178.jpg");

            dtInterior.Rows.Add("179", "INTERIOR", @"../../UsedForResource/Interior/Interior_179.jpg");

            dtInterior.Rows.Add("180", "INTERIOR", @"../../UsedForResource/Interior/Interior_180.jpg");

            dtInterior.Rows.Add("181", "INTERIOR", @"../../UsedForResource/Interior/Interior_181.jpg");

            dtInterior.Rows.Add("182", "INTERIOR", @"../../UsedForResource/Interior/Interior_182.jpg");

            dtInterior.Rows.Add("183", "INTERIOR", @"../../UsedForResource/Interior/Interior_183.jpg");

            dtInterior.Rows.Add("184", "INTERIOR", @"../../UsedForResource/Interior/Interior_184.jpg");

            dtInterior.Rows.Add("185", "INTERIOR", @"../../UsedForResource/Interior/Interior_185.jpg");

            dtInterior.Rows.Add("186", "INTERIOR", @"../../UsedForResource/Interior/Interior_186.jpg");

            dtInterior.Rows.Add("187", "INTERIOR", @"../../UsedForResource/Interior/Interior_187.jpg");

            dtInterior.Rows.Add("188", "INTERIOR", @"../../UsedForResource/Interior/Interior_188.jpg");

            dtInterior.Rows.Add("189", "INTERIOR", @"../../UsedForResource/Interior/Interior_189.jpg");

            dtInterior.Rows.Add("190", "INTERIOR", @"../../UsedForResource/Interior/Interior_190.jpg");

            dtInterior.Rows.Add("191", "INTERIOR", @"../../UsedForResource/Interior/Interior_191.jpg");

            dtInterior.Rows.Add("192", "INTERIOR", @"../../UsedForResource/Interior/Interior_192.jpg");

            dtInterior.Rows.Add("193", "INTERIOR", @"../../UsedForResource/Interior/Interior_193.jpg");

            dtInterior.Rows.Add("194", "INTERIOR", @"../../UsedForResource/Interior/Interior_194.jpg");

            dtInterior.Rows.Add("195", "INTERIOR", @"../../UsedForResource/Interior/Interior_195.jpg");

            dtInterior.Rows.Add("196", "INTERIOR", @"../../UsedForResource/Interior/Interior_196.jpg");

            dtInterior.Rows.Add("197", "INTERIOR", @"../../UsedForResource/Interior/Interior_197.jpg");

            dtInterior.Rows.Add("198", "INTERIOR", @"../../UsedForResource/Interior/Interior_198.jpg");

            dtInterior.Rows.Add("199", "INTERIOR", @"../../UsedForResource/Interior/Interior_199.jpg");

            dtInterior.Rows.Add("200", "INTERIOR", @"../../UsedForResource/Interior/Interior_200.jpg");

            dtInterior.Rows.Add("201", "INTERIOR", @"../../UsedForResource/Interior/Interior_201.jpg");

            dtInterior.Rows.Add("202", "INTERIOR", @"../../UsedForResource/Interior/Interior_202.jpg");

            dtInterior.Rows.Add("203", "INTERIOR", @"../../UsedForResource/Interior/Interior_203.jpg");

            dtInterior.Rows.Add("204", "INTERIOR", @"../../UsedForResource/Interior/Interior_204.jpg");

            dtInterior.Rows.Add("205", "INTERIOR", @"../../UsedForResource/Interior/Interior_205.jpg");

            dtInterior.Rows.Add("206", "INTERIOR", @"../../UsedForResource/Interior/Interior_206.jpg");

            dtInterior.Rows.Add("207", "INTERIOR", @"../../UsedForResource/Interior/Interior_207.jpg");

            dtInterior.Rows.Add("208", "INTERIOR", @"../../UsedForResource/Interior/Interior_208.jpg");

            dtInterior.Rows.Add("209", "INTERIOR", @"../../UsedForResource/Interior/Interior_209.jpg");

            dtInterior.Rows.Add("210", "INTERIOR", @"../../UsedForResource/Interior/Interior_210.jpg");

            dtInterior.Rows.Add("211", "INTERIOR", @"../../UsedForResource/Interior/Interior_211.jpg");

            dtInterior.Rows.Add("212", "INTERIOR", @"../../UsedForResource/Interior/Interior_212.jpg");

            dtInterior.Rows.Add("213", "INTERIOR", @"../../UsedForResource/Interior/Interior_213.jpg");

            dtInterior.Rows.Add("214", "INTERIOR", @"../../UsedForResource/Interior/Interior_214.jpg");

            dtInterior.Rows.Add("215", "INTERIOR", @"../../UsedForResource/Interior/Interior_215.jpg");

            dtInterior.Rows.Add("216", "INTERIOR", @"../../UsedForResource/Interior/Interior_216.jpg");

            dtInterior.Rows.Add("217", "INTERIOR", @"../../UsedForResource/Interior/Interior_217.jpg");

            dtInterior.Rows.Add("218", "INTERIOR", @"../../UsedForResource/Interior/Interior_218.jpg");

            dtInterior.Rows.Add("219", "INTERIOR", @"../../UsedForResource/Interior/Interior_219.jpg");

            dtInterior.Rows.Add("220", "INTERIOR", @"../../UsedForResource/Interior/Interior_220.jpg");

            dtInterior.Rows.Add("221", "INTERIOR", @"../../UsedForResource/Interior/Interior_221.jpg");

            dtInterior.Rows.Add("222", "INTERIOR", @"../../UsedForResource/Interior/Interior_222.jpg");

            dtInterior.Rows.Add("223", "INTERIOR", @"../../UsedForResource/Interior/Interior_223.jpg");

            dtInterior.Rows.Add("224", "INTERIOR", @"../../UsedForResource/Interior/Interior_224.jpg");

            dtInterior.Rows.Add("225", "INTERIOR", @"../../UsedForResource/Interior/Interior_225.jpg");

            dtInterior.Rows.Add("226", "INTERIOR", @"../../UsedForResource/Interior/Interior_226.jpg");

            dtInterior.Rows.Add("227", "INTERIOR", @"../../UsedForResource/Interior/Interior_227.jpg");

            dtInterior.Rows.Add("228", "INTERIOR", @"../../UsedForResource/Interior/Interior_228.jpg");

            dtInterior.Rows.Add("229", "INTERIOR", @"../../UsedForResource/Interior/Interior_229.jpg");
            //////////////////////////////////////////// ADD THE DATA FOR OCEANS CATEGORIZED ////////////////////////////////////////////////////////
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            dtOceans.Rows.Add("1", "OCEANS", @"../../UsedForResource/Ocean/Ocean_1.jpg");

            dtOceans.Rows.Add("2", "OCEANS", @"../../UsedForResource/Ocean/Ocean_2.jpg");

            dtOceans.Rows.Add("3", "OCEANS", @"../../UsedForResource/Ocean/Ocean_3.jpg");

            dtOceans.Rows.Add("4", "OCEANS", @"../../UsedForResource/Ocean/Ocean_4.jpg");

            dtOceans.Rows.Add("5", "OCEANS", @"../../UsedForResource/Ocean/Ocean_5.jpg");

            dtOceans.Rows.Add("6", "OCEANS", @"../../UsedForResource/Ocean/Ocean_6.jpg");

            dtOceans.Rows.Add("7", "OCEANS", @"../../UsedForResource/Ocean/Ocean_7.jpg");

            dtOceans.Rows.Add("8", "OCEANS", @"../../UsedForResource/Ocean/Ocean_8.jpg");

            dtOceans.Rows.Add("9", "OCEANS", @"../../UsedForResource/Ocean/Ocean_9.jpg");

            dtOceans.Rows.Add("10", "OCEANS", @"../../UsedForResource/Ocean/Ocean_10.jpg");

            dtOceans.Rows.Add("11", "OCEANS", @"../../UsedForResource/Ocean/Ocean_11.jpg");

            dtOceans.Rows.Add("12", "OCEANS", @"../../UsedForResource/Ocean/Ocean_12.jpg");

            dtOceans.Rows.Add("13", "OCEANS", @"../../UsedForResource/Ocean/Ocean_13.jpg");

            dtOceans.Rows.Add("14", "OCEANS", @"../../UsedForResource/Ocean/Ocean_14.jpg");

            dtOceans.Rows.Add("15", "OCEANS", @"../../UsedForResource/Ocean/Ocean_15.jpg");

            dtOceans.Rows.Add("16", "OCEANS", @"../../UsedForResource/Ocean/Ocean_16.jpg");

            dtOceans.Rows.Add("17", "OCEANS", @"../../UsedForResource/Ocean/Ocean_17.jpg");

            dtOceans.Rows.Add("18", "OCEANS", @"../../UsedForResource/Ocean/Ocean_18.jpg");

            dtOceans.Rows.Add("19", "OCEANS", @"../../UsedForResource/Ocean/Ocean_19.jpg");

            dtOceans.Rows.Add("20", "OCEANS", @"../../UsedForResource/Ocean/Ocean_20.jpg");

            dtOceans.Rows.Add("21", "OCEANS", @"../../UsedForResource/Ocean/Ocean_21.jpg");

            dtOceans.Rows.Add("22", "OCEANS", @"../../UsedForResource/Ocean/Ocean_22.jpg");

            dtOceans.Rows.Add("23", "OCEANS", @"../../UsedForResource/Ocean/Ocean_23.jpg");

            dtOceans.Rows.Add("24", "OCEANS", @"../../UsedForResource/Ocean/Ocean_24.jpg");

            dtOceans.Rows.Add("25", "OCEANS", @"../../UsedForResource/Ocean/Ocean_25.jpg");

            dtOceans.Rows.Add("26", "OCEANS", @"../../UsedForResource/Ocean/Ocean_26.jpg");

            dtOceans.Rows.Add("27", "OCEANS", @"../../UsedForResource/Ocean/Ocean_27.jpg");

            dtOceans.Rows.Add("28", "OCEANS", @"../../UsedForResource/Ocean/Ocean_28.jpg");

            dtOceans.Rows.Add("29", "OCEANS", @"../../UsedForResource/Ocean/Ocean_29.jpg");

            dtOceans.Rows.Add("30", "OCEANS", @"../../UsedForResource/Ocean/Ocean_30.jpg");

            dtOceans.Rows.Add("31", "OCEANS", @"../../UsedForResource/Ocean/Ocean_31.jpg");

            dtOceans.Rows.Add("32", "OCEANS", @"../../UsedForResource/Ocean/Ocean_32.jpg");

            dtOceans.Rows.Add("33", "OCEANS", @"../../UsedForResource/Ocean/Ocean_33.jpg");

            dtOceans.Rows.Add("34", "OCEANS", @"../../UsedForResource/Ocean/Ocean_34.jpg");

            dtOceans.Rows.Add("35", "OCEANS", @"../../UsedForResource/Ocean/Ocean_35.jpg");

            dtOceans.Rows.Add("36", "OCEANS", @"../../UsedForResource/Ocean/Ocean_36.jpg");

            dtOceans.Rows.Add("37", "OCEANS", @"../../UsedForResource/Ocean/Ocean_37.jpg");

            dtOceans.Rows.Add("38", "OCEANS", @"../../UsedForResource/Ocean/Ocean_38.jpg");

            dtOceans.Rows.Add("39", "OCEANS", @"../../UsedForResource/Ocean/Ocean_39.jpg");

            dtOceans.Rows.Add("40", "OCEANS", @"../../UsedForResource/Ocean/Ocean_40.jpg");

            dtOceans.Rows.Add("41", "OCEANS", @"../../UsedForResource/Ocean/Ocean_41.jpg");

            dtOceans.Rows.Add("42", "OCEANS", @"../../UsedForResource/Ocean/Ocean_42.jpg");

            dtOceans.Rows.Add("43", "OCEANS", @"../../UsedForResource/Ocean/Ocean_43.jpg");

            dtOceans.Rows.Add("44", "OCEANS", @"../../UsedForResource/Ocean/Ocean_44.jpg");

            dtOceans.Rows.Add("45", "OCEANS", @"../../UsedForResource/Ocean/Ocean_45.jpg");

            dtOceans.Rows.Add("46", "OCEANS", @"../../UsedForResource/Ocean/Ocean_46.jpg");

            dtOceans.Rows.Add("47", "OCEANS", @"../../UsedForResource/Ocean/Ocean_47.jpg");

            dtOceans.Rows.Add("48", "OCEANS", @"../../UsedForResource/Ocean/Ocean_48.jpg");

            dtOceans.Rows.Add("49", "OCEANS", @"../../UsedForResource/Ocean/Ocean_49.jpg");

            dtOceans.Rows.Add("50", "OCEANS", @"../../UsedForResource/Ocean/Ocean_50.jpg");

            dtOceans.Rows.Add("51", "OCEANS", @"../../UsedForResource/Ocean/Ocean_51.jpg");

            dtOceans.Rows.Add("52", "OCEANS", @"../../UsedForResource/Ocean/Ocean_52.jpg");

            dtOceans.Rows.Add("53", "OCEANS", @"../../UsedForResource/Ocean/Ocean_53.jpg");

            dtOceans.Rows.Add("54", "OCEANS", @"../../UsedForResource/Ocean/Ocean_54.jpg");

            dtOceans.Rows.Add("55", "OCEANS", @"../../UsedForResource/Ocean/Ocean_55.jpg");

            dtOceans.Rows.Add("56", "OCEANS", @"../../UsedForResource/Ocean/Ocean_56.jpg");

            dtOceans.Rows.Add("57", "OCEANS", @"../../UsedForResource/Ocean/Ocean_57.jpg");

            dtOceans.Rows.Add("58", "OCEANS", @"../../UsedForResource/Ocean/Ocean_58.jpg");

            dtOceans.Rows.Add("59", "OCEANS", @"../../UsedForResource/Ocean/Ocean_59.jpg");

            dtOceans.Rows.Add("60", "OCEANS", @"../../UsedForResource/Ocean/Ocean_60.jpg");

            dtOceans.Rows.Add("61", "OCEANS", @"../../UsedForResource/Ocean/Ocean_61.jpg");

            dtOceans.Rows.Add("62", "OCEANS", @"../../UsedForResource/Ocean/Ocean_62.jpg");

            dtOceans.Rows.Add("63", "OCEANS", @"../../UsedForResource/Ocean/Ocean_63.jpg");

            dtOceans.Rows.Add("64", "OCEANS", @"../../UsedForResource/Ocean/Ocean_64.jpg");

            dtOceans.Rows.Add("65", "OCEANS", @"../../UsedForResource/Ocean/Ocean_65.jpg");

            dtOceans.Rows.Add("66", "OCEANS", @"../../UsedForResource/Ocean/Ocean_66.jpg");

            dtOceans.Rows.Add("67", "OCEANS", @"../../UsedForResource/Ocean/Ocean_67.jpg");

            dtOceans.Rows.Add("68", "OCEANS", @"../../UsedForResource/Ocean/Ocean_68.jpg");

            dtOceans.Rows.Add("69", "OCEANS", @"../../UsedForResource/Ocean/Ocean_69.jpg");

            dtOceans.Rows.Add("70", "OCEANS", @"../../UsedForResource/Ocean/Ocean_70.jpg");

            dtOceans.Rows.Add("71", "OCEANS", @"../../UsedForResource/Ocean/Ocean_71.jpg");

            dtOceans.Rows.Add("72", "OCEANS", @"../../UsedForResource/Ocean/Ocean_72.jpg");

            dtOceans.Rows.Add("73", "OCEANS", @"../../UsedForResource/Ocean/Ocean_73.jpg");

            dtOceans.Rows.Add("74", "OCEANS", @"../../UsedForResource/Ocean/Ocean_74.jpg");

            dtOceans.Rows.Add("75", "OCEANS", @"../../UsedForResource/Ocean/Ocean_75.jpg");

            dtOceans.Rows.Add("76", "OCEANS", @"../../UsedForResource/Ocean/Ocean_76.jpg");

            dtOceans.Rows.Add("77", "OCEANS", @"../../UsedForResource/Ocean/Ocean_77.jpg");

            dtOceans.Rows.Add("78", "OCEANS", @"../../UsedForResource/Ocean/Ocean_78.jpg");

            dtOceans.Rows.Add("79", "OCEANS", @"../../UsedForResource/Ocean/Ocean_79.jpg");

            dtOceans.Rows.Add("80", "OCEANS", @"../../UsedForResource/Ocean/Ocean_80.jpg");

            dtOceans.Rows.Add("81", "OCEANS", @"../../UsedForResource/Ocean/Ocean_81.jpg");

            dtOceans.Rows.Add("82", "OCEANS", @"../../UsedForResource/Ocean/Ocean_82.jpg");

            dtOceans.Rows.Add("83", "OCEANS", @"../../UsedForResource/Ocean/Ocean_83.jpg");

            dtOceans.Rows.Add("84", "OCEANS", @"../../UsedForResource/Ocean/Ocean_84.jpg");

            dtOceans.Rows.Add("85", "OCEANS", @"../../UsedForResource/Ocean/Ocean_85.jpg");

            dtOceans.Rows.Add("86", "OCEANS", @"../../UsedForResource/Ocean/Ocean_86.jpg");

            dtOceans.Rows.Add("87", "OCEANS", @"../../UsedForResource/Ocean/Ocean_87.jpg");

            dtOceans.Rows.Add("88", "OCEANS", @"../../UsedForResource/Ocean/Ocean_88.jpg");

            dtOceans.Rows.Add("89", "OCEANS", @"../../UsedForResource/Ocean/Ocean_89.jpg");

            dtOceans.Rows.Add("90", "OCEANS", @"../../UsedForResource/Ocean/Ocean_90.jpg");

            dtOceans.Rows.Add("91", "OCEANS", @"../../UsedForResource/Ocean/Ocean_91.jpg");

            dtOceans.Rows.Add("92", "OCEANS", @"../../UsedForResource/Ocean/Ocean_92.jpg");

            dtOceans.Rows.Add("93", "OCEANS", @"../../UsedForResource/Ocean/Ocean_93.jpg");

            dtOceans.Rows.Add("94", "OCEANS", @"../../UsedForResource/Ocean/Ocean_94.jpg");

            dtOceans.Rows.Add("95", "OCEANS", @"../../UsedForResource/Ocean/Ocean_95.jpg");

            dtOceans.Rows.Add("96", "OCEANS", @"../../UsedForResource/Ocean/Ocean_96.jpg");

            dtOceans.Rows.Add("97", "OCEANS", @"../../UsedForResource/Ocean/Ocean_97.jpg");

            dtOceans.Rows.Add("98", "OCEANS", @"../../UsedForResource/Ocean/Ocean_98.jpg");

            dtOceans.Rows.Add("99", "OCEANS", @"../../UsedForResource/Ocean/Ocean_99.jpg");

            dtOceans.Rows.Add("100", "OCEANS", @"../../UsedForResource/Ocean/Ocean_100.jpg");

            dtOceans.Rows.Add("101", "OCEANS", @"../../UsedForResource/Ocean/Ocean_101.jpg");

            dtOceans.Rows.Add("102", "OCEANS", @"../../UsedForResource/Ocean/Ocean_102.jpg");

            dtOceans.Rows.Add("103", "OCEANS", @"../../UsedForResource/Ocean/Ocean_103.jpg");

            dtOceans.Rows.Add("104", "OCEANS", @"../../UsedForResource/Ocean/Ocean_104.jpg");

            dtOceans.Rows.Add("105", "OCEANS", @"../../UsedForResource/Ocean/Ocean_105.jpg");

            dtOceans.Rows.Add("106", "OCEANS", @"../../UsedForResource/Ocean/Ocean_106.jpg");

            dtOceans.Rows.Add("107", "OCEANS", @"../../UsedForResource/Ocean/Ocean_107.jpg");

            dtOceans.Rows.Add("108", "OCEANS", @"../../UsedForResource/Ocean/Ocean_108.jpg");

            dtOceans.Rows.Add("109", "OCEANS", @"../../UsedForResource/Ocean/Ocean_109.jpg");

            dtOceans.Rows.Add("110", "OCEANS", @"../../UsedForResource/Ocean/Ocean_110.jpg");

            dtOceans.Rows.Add("111", "OCEANS", @"../../UsedForResource/Ocean/Ocean_111.jpg");

            dtOceans.Rows.Add("112", "OCEANS", @"../../UsedForResource/Ocean/Ocean_112.jpg");

            dtOceans.Rows.Add("113", "OCEANS", @"../../UsedForResource/Ocean/Ocean_113.jpg");

            dtOceans.Rows.Add("114", "OCEANS", @"../../UsedForResource/Ocean/Ocean_114.jpg");

            dtOceans.Rows.Add("115", "OCEANS", @"../../UsedForResource/Ocean/Ocean_115.jpg");

            dtOceans.Rows.Add("116", "OCEANS", @"../../UsedForResource/Ocean/Ocean_116.jpg");

            dtOceans.Rows.Add("117", "OCEANS", @"../../UsedForResource/Ocean/Ocean_117.jpg");

            dtOceans.Rows.Add("118", "OCEANS", @"../../UsedForResource/Ocean/Ocean_118.jpg");

            dtOceans.Rows.Add("119", "OCEANS", @"../../UsedForResource/Ocean/Ocean_119.jpg");

            dtOceans.Rows.Add("120", "OCEANS", @"../../UsedForResource/Ocean/Ocean_120.jpg");

            dtOceans.Rows.Add("121", "OCEANS", @"../../UsedForResource/Ocean/Ocean_121.jpg");

            dtOceans.Rows.Add("122", "OCEANS", @"../../UsedForResource/Ocean/Ocean_122.jpg");

            dtOceans.Rows.Add("123", "OCEANS", @"../../UsedForResource/Ocean/Ocean_123.jpg");

            dtOceans.Rows.Add("124", "OCEANS", @"../../UsedForResource/Ocean/Ocean_124.jpg");

            dtOceans.Rows.Add("125", "OCEANS", @"../../UsedForResource/Ocean/Ocean_125.jpg");

            dtOceans.Rows.Add("126", "OCEANS", @"../../UsedForResource/Ocean/Ocean_126.jpg");

            dtOceans.Rows.Add("127", "OCEANS", @"../../UsedForResource/Ocean/Ocean_127.jpg");

            dtOceans.Rows.Add("128", "OCEANS", @"../../UsedForResource/Ocean/Ocean_128.jpg");

            dtOceans.Rows.Add("129", "OCEANS", @"../../UsedForResource/Ocean/Ocean_129.jpg");

            dtOceans.Rows.Add("130", "OCEANS", @"../../UsedForResource/Ocean/Ocean_130.jpg");

            dtOceans.Rows.Add("131", "OCEANS", @"../../UsedForResource/Ocean/Ocean_131.jpg");

            dtOceans.Rows.Add("132", "OCEANS", @"../../UsedForResource/Ocean/Ocean_132.jpg");

            dtOceans.Rows.Add("133", "OCEANS", @"../../UsedForResource/Ocean/Ocean_133.jpg");

            dtOceans.Rows.Add("134", "OCEANS", @"../../UsedForResource/Ocean/Ocean_134.jpg");

            dtOceans.Rows.Add("135", "OCEANS", @"../../UsedForResource/Ocean/Ocean_135.jpg");

            dtOceans.Rows.Add("136", "OCEANS", @"../../UsedForResource/Ocean/Ocean_136.jpg");

            dtOceans.Rows.Add("137", "OCEANS", @"../../UsedForResource/Ocean/Ocean_137.jpg");

            dtOceans.Rows.Add("138", "OCEANS", @"../../UsedForResource/Ocean/Ocean_138.jpg");

            dtOceans.Rows.Add("139", "OCEANS", @"../../UsedForResource/Ocean/Ocean_139.jpg");

            dtOceans.Rows.Add("140", "OCEANS", @"../../UsedForResource/Ocean/Ocean_140.jpg");

            dtOceans.Rows.Add("141", "OCEANS", @"../../UsedForResource/Ocean/Ocean_141.jpg");

            dtOceans.Rows.Add("142", "OCEANS", @"../../UsedForResource/Ocean/Ocean_142.jpg");

            dtOceans.Rows.Add("143", "OCEANS", @"../../UsedForResource/Ocean/Ocean_143.jpg");

            dtOceans.Rows.Add("144", "OCEANS", @"../../UsedForResource/Ocean/Ocean_144.jpg");

            dtOceans.Rows.Add("145", "OCEANS", @"../../UsedForResource/Ocean/Ocean_145.jpg");

            dtOceans.Rows.Add("146", "OCEANS", @"../../UsedForResource/Ocean/Ocean_146.jpg");

            dtOceans.Rows.Add("147", "OCEANS", @"../../UsedForResource/Ocean/Ocean_147.jpg");

            dtOceans.Rows.Add("148", "OCEANS", @"../../UsedForResource/Ocean/Ocean_148.jpg");

            dtOceans.Rows.Add("149", "OCEANS", @"../../UsedForResource/Ocean/Ocean_149.jpg");

            dtOceans.Rows.Add("150", "OCEANS", @"../../UsedForResource/Ocean/Ocean_150.jpg");

            dtOceans.Rows.Add("151", "OCEANS", @"../../UsedForResource/Ocean/Ocean_151.jpg");

            dtOceans.Rows.Add("152", "OCEANS", @"../../UsedForResource/Ocean/Ocean_152.jpg");

            dtOceans.Rows.Add("153", "OCEANS", @"../../UsedForResource/Ocean/Ocean_153.jpg");

            dtOceans.Rows.Add("154", "OCEANS", @"../../UsedForResource/Ocean/Ocean_154.jpg");

            dtOceans.Rows.Add("155", "OCEANS", @"../../UsedForResource/Ocean/Ocean_155.jpg");

            dtOceans.Rows.Add("156", "OCEANS", @"../../UsedForResource/Ocean/Ocean_156.jpg");

            dtOceans.Rows.Add("157", "OCEANS", @"../../UsedForResource/Ocean/Ocean_157.jpg");

            dtOceans.Rows.Add("158", "OCEANS", @"../../UsedForResource/Ocean/Ocean_158.jpg");

            dtOceans.Rows.Add("159", "OCEANS", @"../../UsedForResource/Ocean/Ocean_159.jpg");

            dtOceans.Rows.Add("160", "OCEANS", @"../../UsedForResource/Ocean/Ocean_160.jpg");

            dtOceans.Rows.Add("161", "OCEANS", @"../../UsedForResource/Ocean/Ocean_161.jpg");

            dtOceans.Rows.Add("162", "OCEANS", @"../../UsedForResource/Ocean/Ocean_162.jpg");

            dtOceans.Rows.Add("163", "OCEANS", @"../../UsedForResource/Ocean/Ocean_163.jpg");

            dtOceans.Rows.Add("164", "OCEANS", @"../../UsedForResource/Ocean/Ocean_164.jpg");

            dtOceans.Rows.Add("165", "OCEANS", @"../../UsedForResource/Ocean/Ocean_165.jpg");

            dtOceans.Rows.Add("166", "OCEANS", @"../../UsedForResource/Ocean/Ocean_166.jpg");

            dtOceans.Rows.Add("167", "OCEANS", @"../../UsedForResource/Ocean/Ocean_167.jpg");

            dtOceans.Rows.Add("168", "OCEANS", @"../../UsedForResource/Ocean/Ocean_168.jpg");

            dtOceans.Rows.Add("169", "OCEANS", @"../../UsedForResource/Ocean/Ocean_169.jpg");

            dtOceans.Rows.Add("170", "OCEANS", @"../../UsedForResource/Ocean/Ocean_170.jpg");

            dtOceans.Rows.Add("171", "OCEANS", @"../../UsedForResource/Ocean/Ocean_171.jpg");

            dtOceans.Rows.Add("172", "OCEANS", @"../../UsedForResource/Ocean/Ocean_172.jpg");

            dtOceans.Rows.Add("173", "OCEANS", @"../../UsedForResource/Ocean/Ocean_173.jpg");

            dtOceans.Rows.Add("174", "OCEANS", @"../../UsedForResource/Ocean/Ocean_174.jpg");

            dtOceans.Rows.Add("175", "OCEANS", @"../../UsedForResource/Ocean/Ocean_175.jpg");

            dtOceans.Rows.Add("176", "OCEANS", @"../../UsedForResource/Ocean/Ocean_176.jpg");

            dtOceans.Rows.Add("177", "OCEANS", @"../../UsedForResource/Ocean/Ocean_177.jpg");

            dtOceans.Rows.Add("178", "OCEANS", @"../../UsedForResource/Ocean/Ocean_178.jpg");

            dtOceans.Rows.Add("179", "OCEANS", @"../../UsedForResource/Ocean/Ocean_179.jpg");

            dtOceans.Rows.Add("180", "OCEANS", @"../../UsedForResource/Ocean/Ocean_180.jpg");

            dtOceans.Rows.Add("181", "OCEANS", @"../../UsedForResource/Ocean/Ocean_181.jpg");

            dtOceans.Rows.Add("182", "OCEANS", @"../../UsedForResource/Ocean/Ocean_182.jpg");

            dtOceans.Rows.Add("183", "OCEANS", @"../../UsedForResource/Ocean/Ocean_183.jpg");

            dtOceans.Rows.Add("184", "OCEANS", @"../../UsedForResource/Ocean/Ocean_184.jpg");

            dtOceans.Rows.Add("185", "OCEANS", @"../../UsedForResource/Ocean/Ocean_185.jpg");

            dtOceans.Rows.Add("186", "OCEANS", @"../../UsedForResource/Ocean/Ocean_186.jpg");
            //////////////////////////////////////////// ADD THE DATA FOR MOTOBIKE CATEGORIZED ////////////////////////////////////////////////////////
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            dtMotoBike.Rows.Add("1", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_1.jpg");

            dtMotoBike.Rows.Add("2", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_2.jpg");

            dtMotoBike.Rows.Add("3", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_3.jpg");

            dtMotoBike.Rows.Add("4", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_4.jpg");

            dtMotoBike.Rows.Add("5", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_5.jpg");

            dtMotoBike.Rows.Add("6", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_6.jpg");

            dtMotoBike.Rows.Add("7", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_7.jpg");

            dtMotoBike.Rows.Add("8", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_8.jpg");

            dtMotoBike.Rows.Add("9", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_9.jpg");

            dtMotoBike.Rows.Add("10", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_10.jpg");

            dtMotoBike.Rows.Add("11", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_11.jpg");

            dtMotoBike.Rows.Add("12", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_12.jpg");

            dtMotoBike.Rows.Add("13", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_13.jpg");

            dtMotoBike.Rows.Add("14", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_14.jpg");

            dtMotoBike.Rows.Add("15", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_15.jpg");

            dtMotoBike.Rows.Add("16", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_16.jpg");

            dtMotoBike.Rows.Add("17", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_17.jpg");

            dtMotoBike.Rows.Add("18", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_18.jpg");

            dtMotoBike.Rows.Add("19", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_19.jpg");

            dtMotoBike.Rows.Add("20", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_20.jpg");

            dtMotoBike.Rows.Add("21", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_21.jpg");

            dtMotoBike.Rows.Add("22", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_22.jpg");

            dtMotoBike.Rows.Add("23", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_23.jpg");

            dtMotoBike.Rows.Add("24", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_24.jpg");

            dtMotoBike.Rows.Add("25", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_25.jpg");

            dtMotoBike.Rows.Add("26", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_26.jpg");

            dtMotoBike.Rows.Add("27", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_27.jpg");

            dtMotoBike.Rows.Add("28", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_28.jpg");

            dtMotoBike.Rows.Add("29", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_29.jpg");

            dtMotoBike.Rows.Add("30", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_30.jpg");

            dtMotoBike.Rows.Add("31", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_31.jpg");

            dtMotoBike.Rows.Add("32", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_32.jpg");

            dtMotoBike.Rows.Add("33", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_33.jpg");

            dtMotoBike.Rows.Add("34", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_34.jpg");

            dtMotoBike.Rows.Add("35", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_35.jpg");

            dtMotoBike.Rows.Add("36", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_36.jpg");

            dtMotoBike.Rows.Add("37", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_37.jpg");

            dtMotoBike.Rows.Add("38", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_38.jpg");

            dtMotoBike.Rows.Add("39", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_39.jpg");

            dtMotoBike.Rows.Add("40", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_40.jpg");

            dtMotoBike.Rows.Add("41", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_41.jpg");

            dtMotoBike.Rows.Add("42", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_42.jpg");

            dtMotoBike.Rows.Add("43", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_43.jpg");

            dtMotoBike.Rows.Add("44", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_44.jpg");

            dtMotoBike.Rows.Add("45", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_45.jpg");

            dtMotoBike.Rows.Add("46", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_46.jpg");

            dtMotoBike.Rows.Add("47", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_47.jpg");

            dtMotoBike.Rows.Add("48", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_48.jpg");

            dtMotoBike.Rows.Add("49", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_49.jpg");

            dtMotoBike.Rows.Add("50", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_50.jpg");

            dtMotoBike.Rows.Add("51", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_51.jpg");

            dtMotoBike.Rows.Add("52", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_52.jpg");

            dtMotoBike.Rows.Add("53", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_53.jpg");

            dtMotoBike.Rows.Add("54", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_54.jpg");

            dtMotoBike.Rows.Add("55", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_55.jpg");

            dtMotoBike.Rows.Add("56", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_56.jpg");

            dtMotoBike.Rows.Add("57", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_57.jpg");

            dtMotoBike.Rows.Add("58", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_58.jpg");

            dtMotoBike.Rows.Add("59", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_59.jpg");

            dtMotoBike.Rows.Add("60", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_60.jpg");

            dtMotoBike.Rows.Add("61", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_61.jpg");

            dtMotoBike.Rows.Add("62", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_62.jpg");

            dtMotoBike.Rows.Add("63", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_63.jpg");

            dtMotoBike.Rows.Add("64", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_64.jpg");

            dtMotoBike.Rows.Add("65", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_65.jpg");

            dtMotoBike.Rows.Add("66", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_66.jpg");

            dtMotoBike.Rows.Add("67", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_67.jpg");

            dtMotoBike.Rows.Add("68", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_68.jpg");

            dtMotoBike.Rows.Add("69", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_69.jpg");

            dtMotoBike.Rows.Add("70", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_70.jpg");

            dtMotoBike.Rows.Add("71", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_71.jpg");

            dtMotoBike.Rows.Add("72", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_72.jpg");

            dtMotoBike.Rows.Add("73", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_73.jpg");

            dtMotoBike.Rows.Add("74", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_74.jpg");

            dtMotoBike.Rows.Add("75", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_75.jpg");

            dtMotoBike.Rows.Add("76", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_76.jpg");

            dtMotoBike.Rows.Add("77", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_77.jpg");

            dtMotoBike.Rows.Add("78", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_78.jpg");

            dtMotoBike.Rows.Add("79", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_79.jpg");

            dtMotoBike.Rows.Add("80", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_80.jpg");

            dtMotoBike.Rows.Add("81", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_81.jpg");

            dtMotoBike.Rows.Add("82", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_82.jpg");

            dtMotoBike.Rows.Add("83", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_83.jpg");

            dtMotoBike.Rows.Add("84", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_84.jpg");

            dtMotoBike.Rows.Add("85", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_85.jpg");

            dtMotoBike.Rows.Add("86", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_86.jpg");

            dtMotoBike.Rows.Add("87", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_87.jpg");

            dtMotoBike.Rows.Add("88", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_88.jpg");

            dtMotoBike.Rows.Add("89", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_89.jpg");

            dtMotoBike.Rows.Add("90", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_90.jpg");

            dtMotoBike.Rows.Add("91", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_91.jpg");

            dtMotoBike.Rows.Add("92", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_92.jpg");

            dtMotoBike.Rows.Add("93", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_93.jpg");

            dtMotoBike.Rows.Add("94", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_94.jpg");

            dtMotoBike.Rows.Add("95", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_95.jpg");

            dtMotoBike.Rows.Add("96", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_96.jpg");

            dtMotoBike.Rows.Add("97", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_97.jpg");

            dtMotoBike.Rows.Add("98", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_98.jpg");

            dtMotoBike.Rows.Add("99", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_99.jpg");

            dtMotoBike.Rows.Add("100", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_100.jpg");

            dtMotoBike.Rows.Add("101", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_101.jpg");

            dtMotoBike.Rows.Add("102", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_102.jpg");

            dtMotoBike.Rows.Add("103", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_103.jpg");

            dtMotoBike.Rows.Add("104", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_104.jpg");

            dtMotoBike.Rows.Add("105", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_105.jpg");

            dtMotoBike.Rows.Add("106", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_106.jpg");

            dtMotoBike.Rows.Add("107", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_107.jpg");

            dtMotoBike.Rows.Add("108", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_108.jpg");

            dtMotoBike.Rows.Add("109", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_109.jpg");

            dtMotoBike.Rows.Add("110", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_110.jpg");

            dtMotoBike.Rows.Add("111", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_111.jpg");

            dtMotoBike.Rows.Add("112", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_112.jpg");

            dtMotoBike.Rows.Add("113", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_113.jpg");

            dtMotoBike.Rows.Add("114", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_114.jpg");

            dtMotoBike.Rows.Add("115", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_115.jpg");

            dtMotoBike.Rows.Add("116", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_116.jpg");

            dtMotoBike.Rows.Add("117", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_117.jpg");

            dtMotoBike.Rows.Add("118", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_118.jpg");

            dtMotoBike.Rows.Add("119", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_119.jpg");

            dtMotoBike.Rows.Add("120", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_120.jpg");

            dtMotoBike.Rows.Add("121", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_121.jpg");

            dtMotoBike.Rows.Add("122", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_122.jpg");

            dtMotoBike.Rows.Add("123", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_123.jpg");

            dtMotoBike.Rows.Add("124", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_124.jpg");

            dtMotoBike.Rows.Add("125", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_125.jpg");

            dtMotoBike.Rows.Add("126", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_126.jpg");

            dtMotoBike.Rows.Add("127", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_127.jpg");

            dtMotoBike.Rows.Add("128", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_128.jpg");

            dtMotoBike.Rows.Add("129", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_129.jpg");

            dtMotoBike.Rows.Add("130", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_130.jpg");

            dtMotoBike.Rows.Add("131", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_131.jpg");

            dtMotoBike.Rows.Add("132", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_132.jpg");

            dtMotoBike.Rows.Add("133", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_133.jpg");

            dtMotoBike.Rows.Add("134", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_134.jpg");

            dtMotoBike.Rows.Add("135", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_135.jpg");

            dtMotoBike.Rows.Add("136", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_136.jpg");

            dtMotoBike.Rows.Add("137", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_137.jpg");

            dtMotoBike.Rows.Add("138", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_138.jpg");

            dtMotoBike.Rows.Add("139", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_139.jpg");

            dtMotoBike.Rows.Add("140", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_140.jpg");

            dtMotoBike.Rows.Add("141", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_141.jpg");

            dtMotoBike.Rows.Add("142", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_142.jpg");

            dtMotoBike.Rows.Add("143", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_143.jpg");

            dtMotoBike.Rows.Add("144", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_144.jpg");

            dtMotoBike.Rows.Add("145", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_145.jpg");

            dtMotoBike.Rows.Add("146", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_146.jpg");

            dtMotoBike.Rows.Add("147", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_147.jpg");

            dtMotoBike.Rows.Add("148", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_148.jpg");

            dtMotoBike.Rows.Add("149", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_149.jpg");

            dtMotoBike.Rows.Add("150", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_150.jpg");

            dtMotoBike.Rows.Add("151", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_151.jpg");

            dtMotoBike.Rows.Add("152", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_152.jpg");

            dtMotoBike.Rows.Add("153", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_153.jpg");

            dtMotoBike.Rows.Add("154", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_154.jpg");

            dtMotoBike.Rows.Add("155", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_155.jpg");

            dtMotoBike.Rows.Add("156", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_156.jpg");

            dtMotoBike.Rows.Add("157", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_157.jpg");

            dtMotoBike.Rows.Add("158", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_158.jpg");

            dtMotoBike.Rows.Add("159", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_159.jpg");

            dtMotoBike.Rows.Add("160", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_160.jpg");

            dtMotoBike.Rows.Add("161", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_161.jpg");

            dtMotoBike.Rows.Add("162", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_162.jpg");

            dtMotoBike.Rows.Add("163", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_163.jpg");

            dtMotoBike.Rows.Add("164", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_164.jpg");

            dtMotoBike.Rows.Add("165", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_165.jpg");

            dtMotoBike.Rows.Add("166", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_166.jpg");

            dtMotoBike.Rows.Add("167", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_167.jpg");

            dtMotoBike.Rows.Add("168", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_168.jpg");

            dtMotoBike.Rows.Add("169", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_169.jpg");

            dtMotoBike.Rows.Add("170", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_170.jpg");

            dtMotoBike.Rows.Add("171", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_171.jpg");

            dtMotoBike.Rows.Add("172", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_172.jpg");

            dtMotoBike.Rows.Add("173", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_173.jpg");

            dtMotoBike.Rows.Add("174", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_174.jpg");

            dtMotoBike.Rows.Add("175", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_175.jpg");

            dtMotoBike.Rows.Add("176", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_176.jpg");

            dtMotoBike.Rows.Add("177", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_177.jpg");

            dtMotoBike.Rows.Add("178", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_178.jpg");

            dtMotoBike.Rows.Add("179", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_179.jpg");

            dtMotoBike.Rows.Add("180", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_180.jpg");

            dtMotoBike.Rows.Add("181", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_181.jpg");

            dtMotoBike.Rows.Add("182", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_182.jpg");

            dtMotoBike.Rows.Add("183", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_183.jpg");

            dtMotoBike.Rows.Add("184", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_184.jpg");

            dtMotoBike.Rows.Add("185", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_185.jpg");

            dtMotoBike.Rows.Add("186", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_186.jpg");

            dtMotoBike.Rows.Add("187", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_187.jpg");

            dtMotoBike.Rows.Add("188", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_188.jpg");

            dtMotoBike.Rows.Add("189", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_189.jpg");

            dtMotoBike.Rows.Add("190", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_190.jpg");

            dtMotoBike.Rows.Add("191", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_191.jpg");

            dtMotoBike.Rows.Add("192", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_192.jpg");

            dtMotoBike.Rows.Add("193", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_193.jpg");

            dtMotoBike.Rows.Add("194", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_194.jpg");

            dtMotoBike.Rows.Add("195", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_195.jpg");

            dtMotoBike.Rows.Add("196", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_196.jpg");

            dtMotoBike.Rows.Add("197", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_197.jpg");

            dtMotoBike.Rows.Add("198", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_198.jpg");

            dtMotoBike.Rows.Add("199", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_199.jpg");

            dtMotoBike.Rows.Add("200", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_200.jpg");

            dtMotoBike.Rows.Add("201", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_201.jpg");

            dtMotoBike.Rows.Add("202", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_202.jpg");

            dtMotoBike.Rows.Add("203", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_203.jpg");

            dtMotoBike.Rows.Add("204", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_204.jpg");

            dtMotoBike.Rows.Add("205", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_205.jpg");

            dtMotoBike.Rows.Add("206", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_206.jpg");

            dtMotoBike.Rows.Add("207", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_207.jpg");

            dtMotoBike.Rows.Add("208", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_208.jpg");

            dtMotoBike.Rows.Add("209", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_209.jpg");

            dtMotoBike.Rows.Add("210", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_210.jpg");

            dtMotoBike.Rows.Add("211", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_211.jpg");

            dtMotoBike.Rows.Add("212", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_212.jpg");

            dtMotoBike.Rows.Add("213", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_213.jpg");

            dtMotoBike.Rows.Add("214", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_214.jpg");

            dtMotoBike.Rows.Add("215", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_215.jpg");

            dtMotoBike.Rows.Add("216", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_216.jpg");

            dtMotoBike.Rows.Add("217", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_217.jpg");

            dtMotoBike.Rows.Add("218", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_218.jpg");

            dtMotoBike.Rows.Add("219", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_219.jpg");

            dtMotoBike.Rows.Add("220", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_220.jpg");

            dtMotoBike.Rows.Add("221", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_221.jpg");

            dtMotoBike.Rows.Add("222", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_222.jpg");

            dtMotoBike.Rows.Add("223", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_223.jpg");

            dtMotoBike.Rows.Add("224", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_224.jpg");

            dtMotoBike.Rows.Add("225", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_225.jpg");

            dtMotoBike.Rows.Add("226", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_226.jpg");

            dtMotoBike.Rows.Add("227", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_227.jpg");

            dtMotoBike.Rows.Add("228", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_228.jpg");

            dtMotoBike.Rows.Add("229", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_229.jpg");

            dtMotoBike.Rows.Add("230", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_230.jpg");

            dtMotoBike.Rows.Add("231", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_231.jpg");

            dtMotoBike.Rows.Add("232", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_232.jpg");

            dtMotoBike.Rows.Add("233", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_233.jpg");

            dtMotoBike.Rows.Add("234", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_234.jpg");

            dtMotoBike.Rows.Add("235", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_235.jpg");

            dtMotoBike.Rows.Add("236", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_236.jpg");

            dtMotoBike.Rows.Add("237", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_237.jpg");

            dtMotoBike.Rows.Add("238", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_238.jpg");

            dtMotoBike.Rows.Add("239", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_239.jpg");

            dtMotoBike.Rows.Add("240", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_240.jpg");

            dtMotoBike.Rows.Add("241", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_241.jpg");

            dtMotoBike.Rows.Add("242", "MOTOBIKE", @"../../UsedForResource/MotoBike/MotoBike_242.jpg");
            //////////////////////////////////////////// ADD THE DATA FOR FOREST CATEGORIZED ////////////////////////////////////////////////////////
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            dtForest.Rows.Add("1", "FOREST", @"../../UsedForResource/Forest/Forest_1.jpg");

            dtForest.Rows.Add("2", "FOREST", @"../../UsedForResource/Forest/Forest_2.jpg");

            dtForest.Rows.Add("3", "FOREST", @"../../UsedForResource/Forest/Forest_3.jpg");

            dtForest.Rows.Add("4", "FOREST", @"../../UsedForResource/Forest/Forest_4.jpg");

            dtForest.Rows.Add("5", "FOREST", @"../../UsedForResource/Forest/Forest_5.jpg");

            dtForest.Rows.Add("6", "FOREST", @"../../UsedForResource/Forest/Forest_6.jpg");

            dtForest.Rows.Add("7", "FOREST", @"../../UsedForResource/Forest/Forest_7.jpg");

            dtForest.Rows.Add("8", "FOREST", @"../../UsedForResource/Forest/Forest_8.jpg");

            dtForest.Rows.Add("9", "FOREST", @"../../UsedForResource/Forest/Forest_9.jpg");

            dtForest.Rows.Add("10", "FOREST", @"../../UsedForResource/Forest/Forest_10.jpg");

            dtForest.Rows.Add("11", "FOREST", @"../../UsedForResource/Forest/Forest_11.jpg");

            dtForest.Rows.Add("12", "FOREST", @"../../UsedForResource/Forest/Forest_12.jpg");

            dtForest.Rows.Add("13", "FOREST", @"../../UsedForResource/Forest/Forest_13.jpg");

            dtForest.Rows.Add("14", "FOREST", @"../../UsedForResource/Forest/Forest_14.jpg");

            dtForest.Rows.Add("15", "FOREST", @"../../UsedForResource/Forest/Forest_15.jpg");

            dtForest.Rows.Add("16", "FOREST", @"../../UsedForResource/Forest/Forest_16.jpg");

            dtForest.Rows.Add("17", "FOREST", @"../../UsedForResource/Forest/Forest_17.jpg");

            dtForest.Rows.Add("18", "FOREST", @"../../UsedForResource/Forest/Forest_18.jpg");

            dtForest.Rows.Add("19", "FOREST", @"../../UsedForResource/Forest/Forest_19.jpg");

            dtForest.Rows.Add("20", "FOREST", @"../../UsedForResource/Forest/Forest_20.jpg");

            dtForest.Rows.Add("21", "FOREST", @"../../UsedForResource/Forest/Forest_21.jpg");

            dtForest.Rows.Add("22", "FOREST", @"../../UsedForResource/Forest/Forest_22.jpg");

            dtForest.Rows.Add("23", "FOREST", @"../../UsedForResource/Forest/Forest_23.jpg");

            dtForest.Rows.Add("24", "FOREST", @"../../UsedForResource/Forest/Forest_24.jpg");

            dtForest.Rows.Add("25", "FOREST", @"../../UsedForResource/Forest/Forest_25.jpg");

            dtForest.Rows.Add("26", "FOREST", @"../../UsedForResource/Forest/Forest_26.jpg");

            dtForest.Rows.Add("27", "FOREST", @"../../UsedForResource/Forest/Forest_27.jpg");

            dtForest.Rows.Add("28", "FOREST", @"../../UsedForResource/Forest/Forest_28.jpg");

            dtForest.Rows.Add("29", "FOREST", @"../../UsedForResource/Forest/Forest_29.jpg");

            dtForest.Rows.Add("30", "FOREST", @"../../UsedForResource/Forest/Forest_30.jpg");

            dtForest.Rows.Add("31", "FOREST", @"../../UsedForResource/Forest/Forest_31.jpg");

            dtForest.Rows.Add("32", "FOREST", @"../../UsedForResource/Forest/Forest_32.jpg");

            dtForest.Rows.Add("33", "FOREST", @"../../UsedForResource/Forest/Forest_33.jpg");

            dtForest.Rows.Add("34", "FOREST", @"../../UsedForResource/Forest/Forest_34.jpg");

            dtForest.Rows.Add("35", "FOREST", @"../../UsedForResource/Forest/Forest_35.jpg");

            dtForest.Rows.Add("36", "FOREST", @"../../UsedForResource/Forest/Forest_36.jpg");

            dtForest.Rows.Add("37", "FOREST", @"../../UsedForResource/Forest/Forest_37.jpg");

            dtForest.Rows.Add("38", "FOREST", @"../../UsedForResource/Forest/Forest_38.jpg");

            dtForest.Rows.Add("39", "FOREST", @"../../UsedForResource/Forest/Forest_39.jpg");

            dtForest.Rows.Add("40", "FOREST", @"../../UsedForResource/Forest/Forest_40.jpg");

            dtForest.Rows.Add("41", "FOREST", @"../../UsedForResource/Forest/Forest_41.jpg");

            dtForest.Rows.Add("42", "FOREST", @"../../UsedForResource/Forest/Forest_42.jpg");

            dtForest.Rows.Add("43", "FOREST", @"../../UsedForResource/Forest/Forest_43.jpg");

            dtForest.Rows.Add("44", "FOREST", @"../../UsedForResource/Forest/Forest_44.jpg");

            dtForest.Rows.Add("45", "FOREST", @"../../UsedForResource/Forest/Forest_45.jpg");

            dtForest.Rows.Add("46", "FOREST", @"../../UsedForResource/Forest/Forest_46.jpg");

            dtForest.Rows.Add("47", "FOREST", @"../../UsedForResource/Forest/Forest_47.jpg");

            dtForest.Rows.Add("48", "FOREST", @"../../UsedForResource/Forest/Forest_48.jpg");

            dtForest.Rows.Add("49", "FOREST", @"../../UsedForResource/Forest/Forest_49.jpg");

            dtForest.Rows.Add("50", "FOREST", @"../../UsedForResource/Forest/Forest_50.jpg");

            dtForest.Rows.Add("51", "FOREST", @"../../UsedForResource/Forest/Forest_51.jpg");

            dtForest.Rows.Add("52", "FOREST", @"../../UsedForResource/Forest/Forest_52.jpg");

            dtForest.Rows.Add("53", "FOREST", @"../../UsedForResource/Forest/Forest_53.jpg");

            dtForest.Rows.Add("54", "FOREST", @"../../UsedForResource/Forest/Forest_54.jpg");

            dtForest.Rows.Add("55", "FOREST", @"../../UsedForResource/Forest/Forest_55.jpg");

            dtForest.Rows.Add("56", "FOREST", @"../../UsedForResource/Forest/Forest_56.jpg");

            dtForest.Rows.Add("57", "FOREST", @"../../UsedForResource/Forest/Forest_57.jpg");

            dtForest.Rows.Add("58", "FOREST", @"../../UsedForResource/Forest/Forest_58.jpg");

            dtForest.Rows.Add("59", "FOREST", @"../../UsedForResource/Forest/Forest_59.jpg");

            dtForest.Rows.Add("60", "FOREST", @"../../UsedForResource/Forest/Forest_60.jpg");

            dtForest.Rows.Add("61", "FOREST", @"../../UsedForResource/Forest/Forest_61.jpg");

            dtForest.Rows.Add("62", "FOREST", @"../../UsedForResource/Forest/Forest_62.jpg");

            dtForest.Rows.Add("63", "FOREST", @"../../UsedForResource/Forest/Forest_63.jpg");

            dtForest.Rows.Add("64", "FOREST", @"../../UsedForResource/Forest/Forest_64.jpg");

            dtForest.Rows.Add("65", "FOREST", @"../../UsedForResource/Forest/Forest_65.jpg");

            dtForest.Rows.Add("66", "FOREST", @"../../UsedForResource/Forest/Forest_66.jpg");

            dtForest.Rows.Add("67", "FOREST", @"../../UsedForResource/Forest/Forest_67.jpg");

            dtForest.Rows.Add("68", "FOREST", @"../../UsedForResource/Forest/Forest_68.jpg");

            dtForest.Rows.Add("69", "FOREST", @"../../UsedForResource/Forest/Forest_69.jpg");

            dtForest.Rows.Add("70", "FOREST", @"../../UsedForResource/Forest/Forest_70.jpg");

            dtForest.Rows.Add("71", "FOREST", @"../../UsedForResource/Forest/Forest_71.jpg");

            dtForest.Rows.Add("72", "FOREST", @"../../UsedForResource/Forest/Forest_72.jpg");

            dtForest.Rows.Add("73", "FOREST", @"../../UsedForResource/Forest/Forest_73.jpg");

            dtForest.Rows.Add("74", "FOREST", @"../../UsedForResource/Forest/Forest_74.jpg");

            dtForest.Rows.Add("75", "FOREST", @"../../UsedForResource/Forest/Forest_75.jpg");

            dtForest.Rows.Add("76", "FOREST", @"../../UsedForResource/Forest/Forest_76.jpg");

            dtForest.Rows.Add("77", "FOREST", @"../../UsedForResource/Forest/Forest_77.jpg");

            dtForest.Rows.Add("78", "FOREST", @"../../UsedForResource/Forest/Forest_78.jpg");

            dtForest.Rows.Add("79", "FOREST", @"../../UsedForResource/Forest/Forest_79.jpg");

            dtForest.Rows.Add("80", "FOREST", @"../../UsedForResource/Forest/Forest_80.jpg");

            dtForest.Rows.Add("81", "FOREST", @"../../UsedForResource/Forest/Forest_81.jpg");

            dtForest.Rows.Add("82", "FOREST", @"../../UsedForResource/Forest/Forest_82.jpg");

            dtForest.Rows.Add("83", "FOREST", @"../../UsedForResource/Forest/Forest_83.jpg");

            dtForest.Rows.Add("84", "FOREST", @"../../UsedForResource/Forest/Forest_84.jpg");

            dtForest.Rows.Add("85", "FOREST", @"../../UsedForResource/Forest/Forest_85.jpg");

            dtForest.Rows.Add("86", "FOREST", @"../../UsedForResource/Forest/Forest_86.jpg");

            dtForest.Rows.Add("87", "FOREST", @"../../UsedForResource/Forest/Forest_87.jpg");

            dtForest.Rows.Add("88", "FOREST", @"../../UsedForResource/Forest/Forest_88.jpg");

            dtForest.Rows.Add("89", "FOREST", @"../../UsedForResource/Forest/Forest_89.jpg");

            dtForest.Rows.Add("90", "FOREST", @"../../UsedForResource/Forest/Forest_90.jpg");

            dtForest.Rows.Add("91", "FOREST", @"../../UsedForResource/Forest/Forest_91.jpg");

            dtForest.Rows.Add("92", "FOREST", @"../../UsedForResource/Forest/Forest_92.jpg");

            dtForest.Rows.Add("93", "FOREST", @"../../UsedForResource/Forest/Forest_93.jpg");

            dtForest.Rows.Add("94", "FOREST", @"../../UsedForResource/Forest/Forest_94.jpg");

            dtForest.Rows.Add("95", "FOREST", @"../../UsedForResource/Forest/Forest_95.jpg");

            dtForest.Rows.Add("96", "FOREST", @"../../UsedForResource/Forest/Forest_96.jpg");

            dtForest.Rows.Add("97", "FOREST", @"../../UsedForResource/Forest/Forest_97.jpg");

            dtForest.Rows.Add("98", "FOREST", @"../../UsedForResource/Forest/Forest_98.jpg");

            dtForest.Rows.Add("99", "FOREST", @"../../UsedForResource/Forest/Forest_99.jpg");

            dtForest.Rows.Add("100", "FOREST", @"../../UsedForResource/Forest/Forest_100.jpg");

            dtForest.Rows.Add("101", "FOREST", @"../../UsedForResource/Forest/Forest_101.jpg");

            dtForest.Rows.Add("102", "FOREST", @"../../UsedForResource/Forest/Forest_102.jpg");

            dtForest.Rows.Add("103", "FOREST", @"../../UsedForResource/Forest/Forest_103.jpg");

            dtForest.Rows.Add("104", "FOREST", @"../../UsedForResource/Forest/Forest_104.jpg");

            dtForest.Rows.Add("105", "FOREST", @"../../UsedForResource/Forest/Forest_105.jpg");

            dtForest.Rows.Add("106", "FOREST", @"../../UsedForResource/Forest/Forest_106.jpg");

            dtForest.Rows.Add("107", "FOREST", @"../../UsedForResource/Forest/Forest_107.jpg");

            dtForest.Rows.Add("108", "FOREST", @"../../UsedForResource/Forest/Forest_108.jpg");

            dtForest.Rows.Add("109", "FOREST", @"../../UsedForResource/Forest/Forest_109.jpg");

            dtForest.Rows.Add("110", "FOREST", @"../../UsedForResource/Forest/Forest_110.jpg");

            dtForest.Rows.Add("111", "FOREST", @"../../UsedForResource/Forest/Forest_111.jpg");

            dtForest.Rows.Add("112", "FOREST", @"../../UsedForResource/Forest/Forest_112.jpg");

            dtForest.Rows.Add("113", "FOREST", @"../../UsedForResource/Forest/Forest_113.jpg");

            dtForest.Rows.Add("114", "FOREST", @"../../UsedForResource/Forest/Forest_114.jpg");

            dtForest.Rows.Add("115", "FOREST", @"../../UsedForResource/Forest/Forest_115.jpg");

            dtForest.Rows.Add("116", "FOREST", @"../../UsedForResource/Forest/Forest_116.jpg");

            dtForest.Rows.Add("117", "FOREST", @"../../UsedForResource/Forest/Forest_117.jpg");

            dtForest.Rows.Add("118", "FOREST", @"../../UsedForResource/Forest/Forest_118.jpg");

            dtForest.Rows.Add("119", "FOREST", @"../../UsedForResource/Forest/Forest_119.jpg");

            dtForest.Rows.Add("120", "FOREST", @"../../UsedForResource/Forest/Forest_120.jpg");

            dtForest.Rows.Add("121", "FOREST", @"../../UsedForResource/Forest/Forest_121.jpg");

            dtForest.Rows.Add("122", "FOREST", @"../../UsedForResource/Forest/Forest_122.jpg");

            dtForest.Rows.Add("123", "FOREST", @"../../UsedForResource/Forest/Forest_123.jpg");

            dtForest.Rows.Add("124", "FOREST", @"../../UsedForResource/Forest/Forest_124.jpg");

            dtForest.Rows.Add("125", "FOREST", @"../../UsedForResource/Forest/Forest_125.jpg");

            dtForest.Rows.Add("126", "FOREST", @"../../UsedForResource/Forest/Forest_126.jpg");

            dtForest.Rows.Add("127", "FOREST", @"../../UsedForResource/Forest/Forest_127.jpg");

            dtForest.Rows.Add("128", "FOREST", @"../../UsedForResource/Forest/Forest_128.jpg");

            dtForest.Rows.Add("129", "FOREST", @"../../UsedForResource/Forest/Forest_129.jpg");

            dtForest.Rows.Add("130", "FOREST", @"../../UsedForResource/Forest/Forest_130.jpg");

            dtForest.Rows.Add("131", "FOREST", @"../../UsedForResource/Forest/Forest_131.jpg");

            dtForest.Rows.Add("132", "FOREST", @"../../UsedForResource/Forest/Forest_132.jpg");

            dtForest.Rows.Add("133", "FOREST", @"../../UsedForResource/Forest/Forest_133.jpg");

            dtForest.Rows.Add("134", "FOREST", @"../../UsedForResource/Forest/Forest_134.jpg");

            dtForest.Rows.Add("135", "FOREST", @"../../UsedForResource/Forest/Forest_135.jpg");

            dtForest.Rows.Add("136", "FOREST", @"../../UsedForResource/Forest/Forest_136.jpg");

            dtForest.Rows.Add("137", "FOREST", @"../../UsedForResource/Forest/Forest_137.jpg");

            dtForest.Rows.Add("138", "FOREST", @"../../UsedForResource/Forest/Forest_138.jpg");

            dtForest.Rows.Add("139", "FOREST", @"../../UsedForResource/Forest/Forest_139.jpg");

            dtForest.Rows.Add("140", "FOREST", @"../../UsedForResource/Forest/Forest_140.jpg");

            dtForest.Rows.Add("141", "FOREST", @"../../UsedForResource/Forest/Forest_141.jpg");

            dtForest.Rows.Add("142", "FOREST", @"../../UsedForResource/Forest/Forest_142.jpg");

            dtForest.Rows.Add("143", "FOREST", @"../../UsedForResource/Forest/Forest_143.jpg");

            dtForest.Rows.Add("144", "FOREST", @"../../UsedForResource/Forest/Forest_144.jpg");

            dtForest.Rows.Add("145", "FOREST", @"../../UsedForResource/Forest/Forest_145.jpg");

            dtForest.Rows.Add("146", "FOREST", @"../../UsedForResource/Forest/Forest_146.jpg");

            dtForest.Rows.Add("147", "FOREST", @"../../UsedForResource/Forest/Forest_147.jpg");

            dtForest.Rows.Add("148", "FOREST", @"../../UsedForResource/Forest/Forest_148.jpg");

            dtForest.Rows.Add("149", "FOREST", @"../../UsedForResource/Forest/Forest_149.jpg");

            dtForest.Rows.Add("150", "FOREST", @"../../UsedForResource/Forest/Forest_150.jpg");

            dtForest.Rows.Add("151", "FOREST", @"../../UsedForResource/Forest/Forest_151.jpg");

            dtForest.Rows.Add("152", "FOREST", @"../../UsedForResource/Forest/Forest_152.jpg");

            dtForest.Rows.Add("153", "FOREST", @"../../UsedForResource/Forest/Forest_153.jpg");

            dtForest.Rows.Add("154", "FOREST", @"../../UsedForResource/Forest/Forest_154.jpg");

            dtForest.Rows.Add("155", "FOREST", @"../../UsedForResource/Forest/Forest_155.jpg");

            dtForest.Rows.Add("156", "FOREST", @"../../UsedForResource/Forest/Forest_156.jpg");

            dtForest.Rows.Add("157", "FOREST", @"../../UsedForResource/Forest/Forest_157.jpg");

            dtForest.Rows.Add("158", "FOREST", @"../../UsedForResource/Forest/Forest_158.jpg");

            dtForest.Rows.Add("159", "FOREST", @"../../UsedForResource/Forest/Forest_159.jpg");

            dtForest.Rows.Add("160", "FOREST", @"../../UsedForResource/Forest/Forest_160.jpg");

            dtForest.Rows.Add("161", "FOREST", @"../../UsedForResource/Forest/Forest_161.jpg");

            dtForest.Rows.Add("162", "FOREST", @"../../UsedForResource/Forest/Forest_162.jpg");

            dtForest.Rows.Add("163", "FOREST", @"../../UsedForResource/Forest/Forest_163.jpg");

            dtForest.Rows.Add("164", "FOREST", @"../../UsedForResource/Forest/Forest_164.jpg");

            dtForest.Rows.Add("165", "FOREST", @"../../UsedForResource/Forest/Forest_165.jpg");

            dtForest.Rows.Add("166", "FOREST", @"../../UsedForResource/Forest/Forest_166.jpg");

            dtForest.Rows.Add("167", "FOREST", @"../../UsedForResource/Forest/Forest_167.jpg");

            dtForest.Rows.Add("168", "FOREST", @"../../UsedForResource/Forest/Forest_168.jpg");

            dtForest.Rows.Add("169", "FOREST", @"../../UsedForResource/Forest/Forest_169.jpg");

            dtForest.Rows.Add("170", "FOREST", @"../../UsedForResource/Forest/Forest_170.jpg");

            dtForest.Rows.Add("171", "FOREST", @"../../UsedForResource/Forest/Forest_171.jpg");

            dtForest.Rows.Add("172", "FOREST", @"../../UsedForResource/Forest/Forest_172.jpg");

            dtForest.Rows.Add("173", "FOREST", @"../../UsedForResource/Forest/Forest_173.jpg");

            dtForest.Rows.Add("174", "FOREST", @"../../UsedForResource/Forest/Forest_174.jpg");

            dtForest.Rows.Add("175", "FOREST", @"../../UsedForResource/Forest/Forest_175.jpg");

            dtForest.Rows.Add("176", "FOREST", @"../../UsedForResource/Forest/Forest_176.jpg");

            dtForest.Rows.Add("177", "FOREST", @"../../UsedForResource/Forest/Forest_177.jpg");

            dtForest.Rows.Add("178", "FOREST", @"../../UsedForResource/Forest/Forest_178.jpg");

            dtForest.Rows.Add("179", "FOREST", @"../../UsedForResource/Forest/Forest_179.jpg");

            dtForest.Rows.Add("180", "FOREST", @"../../UsedForResource/Forest/Forest_180.jpg");

            dtForest.Rows.Add("181", "FOREST", @"../../UsedForResource/Forest/Forest_181.jpg");

            dtForest.Rows.Add("182", "FOREST", @"../../UsedForResource/Forest/Forest_182.jpg");

            dtForest.Rows.Add("183", "FOREST", @"../../UsedForResource/Forest/Forest_183.jpg");

            dtForest.Rows.Add("184", "FOREST", @"../../UsedForResource/Forest/Forest_184.jpg");

            dtForest.Rows.Add("185", "FOREST", @"../../UsedForResource/Forest/Forest_185.jpg");

            dtForest.Rows.Add("186", "FOREST", @"../../UsedForResource/Forest/Forest_186.jpg");

            dtForest.Rows.Add("187", "FOREST", @"../../UsedForResource/Forest/Forest_187.jpg");

            dtForest.Rows.Add("188", "FOREST", @"../../UsedForResource/Forest/Forest_188.jpg");

            dtForest.Rows.Add("189", "FOREST", @"../../UsedForResource/Forest/Forest_189.jpg");

            dtForest.Rows.Add("190", "FOREST", @"../../UsedForResource/Forest/Forest_190.jpg");

            dtForest.Rows.Add("191", "FOREST", @"../../UsedForResource/Forest/Forest_191.jpg");

            dtForest.Rows.Add("192", "FOREST", @"../../UsedForResource/Forest/Forest_192.jpg");

            dtForest.Rows.Add("193", "FOREST", @"../../UsedForResource/Forest/Forest_193.jpg");

            dtForest.Rows.Add("194", "FOREST", @"../../UsedForResource/Forest/Forest_194.jpg");

            dtForest.Rows.Add("195", "FOREST", @"../../UsedForResource/Forest/Forest_195.jpg");

            dtForest.Rows.Add("196", "FOREST", @"../../UsedForResource/Forest/Forest_196.jpg");

            dtForest.Rows.Add("197", "FOREST", @"../../UsedForResource/Forest/Forest_197.jpg");

            dtForest.Rows.Add("198", "FOREST", @"../../UsedForResource/Forest/Forest_198.jpg");

            dtForest.Rows.Add("199", "FOREST", @"../../UsedForResource/Forest/Forest_199.jpg");

            dtForest.Rows.Add("200", "FOREST", @"../../UsedForResource/Forest/Forest_200.jpg");

            dtForest.Rows.Add("201", "FOREST", @"../../UsedForResource/Forest/Forest_201.jpg");

            dtForest.Rows.Add("202", "FOREST", @"../../UsedForResource/Forest/Forest_202.jpg");

            dtForest.Rows.Add("203", "FOREST", @"../../UsedForResource/Forest/Forest_203.jpg");

            dtForest.Rows.Add("204", "FOREST", @"../../UsedForResource/Forest/Forest_204.jpg");

            dtForest.Rows.Add("205", "FOREST", @"../../UsedForResource/Forest/Forest_205.jpg");
            //////////////////////////////////////////// ADD THE DATA FOR FLOWER CATEGORIZED ////////////////////////////////////////////////////////
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            dtFlower.Rows.Add("1", "FLOWER", @"../../UsedForResource/Flower/Flower_1.jpg");

            dtFlower.Rows.Add("2", "FLOWER", @"../../UsedForResource/Flower/Flower_2.jpg");

            dtFlower.Rows.Add("3", "FLOWER", @"../../UsedForResource/Flower/Flower_3.jpg");

            dtFlower.Rows.Add("4", "FLOWER", @"../../UsedForResource/Flower/Flower_4.jpg");

            dtFlower.Rows.Add("5", "FLOWER", @"../../UsedForResource/Flower/Flower_5.jpg");

            dtFlower.Rows.Add("6", "FLOWER", @"../../UsedForResource/Flower/Flower_6.jpg");

            dtFlower.Rows.Add("7", "FLOWER", @"../../UsedForResource/Flower/Flower_7.jpg");

            dtFlower.Rows.Add("8", "FLOWER", @"../../UsedForResource/Flower/Flower_8.jpg");

            dtFlower.Rows.Add("9", "FLOWER", @"../../UsedForResource/Flower/Flower_9.jpg");

            dtFlower.Rows.Add("10", "FLOWER", @"../../UsedForResource/Flower/Flower_10.jpg");

            dtFlower.Rows.Add("11", "FLOWER", @"../../UsedForResource/Flower/Flower_11.jpg");

            dtFlower.Rows.Add("12", "FLOWER", @"../../UsedForResource/Flower/Flower_12.jpg");

            dtFlower.Rows.Add("13", "FLOWER", @"../../UsedForResource/Flower/Flower_13.jpg");

            dtFlower.Rows.Add("14", "FLOWER", @"../../UsedForResource/Flower/Flower_14.jpg");

            dtFlower.Rows.Add("15", "FLOWER", @"../../UsedForResource/Flower/Flower_15.jpg");

            dtFlower.Rows.Add("16", "FLOWER", @"../../UsedForResource/Flower/Flower_16.jpg");

            dtFlower.Rows.Add("17", "FLOWER", @"../../UsedForResource/Flower/Flower_17.jpg");

            dtFlower.Rows.Add("18", "FLOWER", @"../../UsedForResource/Flower/Flower_18.jpg");

            dtFlower.Rows.Add("19", "FLOWER", @"../../UsedForResource/Flower/Flower_19.jpg");

            dtFlower.Rows.Add("20", "FLOWER", @"../../UsedForResource/Flower/Flower_20.jpg");

            dtFlower.Rows.Add("21", "FLOWER", @"../../UsedForResource/Flower/Flower_21.jpg");

            dtFlower.Rows.Add("22", "FLOWER", @"../../UsedForResource/Flower/Flower_22.jpg");

            dtFlower.Rows.Add("23", "FLOWER", @"../../UsedForResource/Flower/Flower_23.jpg");

            dtFlower.Rows.Add("24", "FLOWER", @"../../UsedForResource/Flower/Flower_24.jpg");

            dtFlower.Rows.Add("25", "FLOWER", @"../../UsedForResource/Flower/Flower_25.jpg");

            dtFlower.Rows.Add("26", "FLOWER", @"../../UsedForResource/Flower/Flower_26.jpg");

            dtFlower.Rows.Add("27", "FLOWER", @"../../UsedForResource/Flower/Flower_27.jpg");

            dtFlower.Rows.Add("28", "FLOWER", @"../../UsedForResource/Flower/Flower_28.jpg");

            dtFlower.Rows.Add("29", "FLOWER", @"../../UsedForResource/Flower/Flower_29.jpg");

            dtFlower.Rows.Add("30", "FLOWER", @"../../UsedForResource/Flower/Flower_30.jpg");

            dtFlower.Rows.Add("31", "FLOWER", @"../../UsedForResource/Flower/Flower_31.jpg");

            dtFlower.Rows.Add("32", "FLOWER", @"../../UsedForResource/Flower/Flower_32.jpg");

            dtFlower.Rows.Add("33", "FLOWER", @"../../UsedForResource/Flower/Flower_33.jpg");

            dtFlower.Rows.Add("34", "FLOWER", @"../../UsedForResource/Flower/Flower_34.jpg");

            dtFlower.Rows.Add("35", "FLOWER", @"../../UsedForResource/Flower/Flower_35.jpg");

            dtFlower.Rows.Add("36", "FLOWER", @"../../UsedForResource/Flower/Flower_36.jpg");

            dtFlower.Rows.Add("37", "FLOWER", @"../../UsedForResource/Flower/Flower_37.jpg");

            dtFlower.Rows.Add("38", "FLOWER", @"../../UsedForResource/Flower/Flower_38.jpg");

            dtFlower.Rows.Add("39", "FLOWER", @"../../UsedForResource/Flower/Flower_39.jpg");

            dtFlower.Rows.Add("40", "FLOWER", @"../../UsedForResource/Flower/Flower_40.jpg");

            dtFlower.Rows.Add("41", "FLOWER", @"../../UsedForResource/Flower/Flower_41.jpg");

            dtFlower.Rows.Add("42", "FLOWER", @"../../UsedForResource/Flower/Flower_42.jpg");

            dtFlower.Rows.Add("43", "FLOWER", @"../../UsedForResource/Flower/Flower_43.jpg");

            dtFlower.Rows.Add("44", "FLOWER", @"../../UsedForResource/Flower/Flower_44.jpg");

            dtFlower.Rows.Add("45", "FLOWER", @"../../UsedForResource/Flower/Flower_45.jpg");

            dtFlower.Rows.Add("46", "FLOWER", @"../../UsedForResource/Flower/Flower_46.jpg");

            dtFlower.Rows.Add("47", "FLOWER", @"../../UsedForResource/Flower/Flower_47.jpg");

            dtFlower.Rows.Add("48", "FLOWER", @"../../UsedForResource/Flower/Flower_48.jpg");

            dtFlower.Rows.Add("49", "FLOWER", @"../../UsedForResource/Flower/Flower_49.jpg");

            dtFlower.Rows.Add("50", "FLOWER", @"../../UsedForResource/Flower/Flower_50.jpg");

            dtFlower.Rows.Add("51", "FLOWER", @"../../UsedForResource/Flower/Flower_51.jpg");

            dtFlower.Rows.Add("52", "FLOWER", @"../../UsedForResource/Flower/Flower_52.jpg");

            dtFlower.Rows.Add("53", "FLOWER", @"../../UsedForResource/Flower/Flower_53.jpg");

            dtFlower.Rows.Add("54", "FLOWER", @"../../UsedForResource/Flower/Flower_54.jpg");

            dtFlower.Rows.Add("55", "FLOWER", @"../../UsedForResource/Flower/Flower_55.jpg");

            dtFlower.Rows.Add("56", "FLOWER", @"../../UsedForResource/Flower/Flower_56.jpg");

            dtFlower.Rows.Add("57", "FLOWER", @"../../UsedForResource/Flower/Flower_57.jpg");

            dtFlower.Rows.Add("58", "FLOWER", @"../../UsedForResource/Flower/Flower_58.jpg");

            dtFlower.Rows.Add("59", "FLOWER", @"../../UsedForResource/Flower/Flower_59.jpg");

            dtFlower.Rows.Add("60", "FLOWER", @"../../UsedForResource/Flower/Flower_60.jpg");

            dtFlower.Rows.Add("61", "FLOWER", @"../../UsedForResource/Flower/Flower_61.jpg");

            dtFlower.Rows.Add("62", "FLOWER", @"../../UsedForResource/Flower/Flower_62.jpg");

            dtFlower.Rows.Add("63", "FLOWER", @"../../UsedForResource/Flower/Flower_63.jpg");

            dtFlower.Rows.Add("64", "FLOWER", @"../../UsedForResource/Flower/Flower_64.jpg");

            dtFlower.Rows.Add("65", "FLOWER", @"../../UsedForResource/Flower/Flower_65.jpg");

            dtFlower.Rows.Add("66", "FLOWER", @"../../UsedForResource/Flower/Flower_66.jpg");

            dtFlower.Rows.Add("67", "FLOWER", @"../../UsedForResource/Flower/Flower_67.jpg");

            dtFlower.Rows.Add("68", "FLOWER", @"../../UsedForResource/Flower/Flower_68.jpg");

            dtFlower.Rows.Add("69", "FLOWER", @"../../UsedForResource/Flower/Flower_69.jpg");

            dtFlower.Rows.Add("70", "FLOWER", @"../../UsedForResource/Flower/Flower_70.jpg");

            dtFlower.Rows.Add("71", "FLOWER", @"../../UsedForResource/Flower/Flower_71.jpg");

            dtFlower.Rows.Add("72", "FLOWER", @"../../UsedForResource/Flower/Flower_72.jpg");

            dtFlower.Rows.Add("73", "FLOWER", @"../../UsedForResource/Flower/Flower_73.jpg");

            dtFlower.Rows.Add("74", "FLOWER", @"../../UsedForResource/Flower/Flower_74.jpg");

            dtFlower.Rows.Add("75", "FLOWER", @"../../UsedForResource/Flower/Flower_75.jpg");

            dtFlower.Rows.Add("76", "FLOWER", @"../../UsedForResource/Flower/Flower_76.jpg");

            dtFlower.Rows.Add("77", "FLOWER", @"../../UsedForResource/Flower/Flower_77.jpg");

            dtFlower.Rows.Add("78", "FLOWER", @"../../UsedForResource/Flower/Flower_78.jpg");

            dtFlower.Rows.Add("79", "FLOWER", @"../../UsedForResource/Flower/Flower_79.jpg");

            dtFlower.Rows.Add("80", "FLOWER", @"../../UsedForResource/Flower/Flower_80.jpg");

            dtFlower.Rows.Add("81", "FLOWER", @"../../UsedForResource/Flower/Flower_81.jpg");

            dtFlower.Rows.Add("82", "FLOWER", @"../../UsedForResource/Flower/Flower_82.jpg");

            dtFlower.Rows.Add("83", "FLOWER", @"../../UsedForResource/Flower/Flower_83.jpg");

            dtFlower.Rows.Add("84", "FLOWER", @"../../UsedForResource/Flower/Flower_84.jpg");

            dtFlower.Rows.Add("85", "FLOWER", @"../../UsedForResource/Flower/Flower_85.jpg");

            dtFlower.Rows.Add("86", "FLOWER", @"../../UsedForResource/Flower/Flower_86.jpg");

            dtFlower.Rows.Add("87", "FLOWER", @"../../UsedForResource/Flower/Flower_87.jpg");

            dtFlower.Rows.Add("88", "FLOWER", @"../../UsedForResource/Flower/Flower_88.jpg");

            dtFlower.Rows.Add("89", "FLOWER", @"../../UsedForResource/Flower/Flower_89.jpg");

            dtFlower.Rows.Add("90", "FLOWER", @"../../UsedForResource/Flower/Flower_90.jpg");

            dtFlower.Rows.Add("91", "FLOWER", @"../../UsedForResource/Flower/Flower_91.jpg");

            dtFlower.Rows.Add("92", "FLOWER", @"../../UsedForResource/Flower/Flower_92.jpg");

            dtFlower.Rows.Add("93", "FLOWER", @"../../UsedForResource/Flower/Flower_93.jpg");

            dtFlower.Rows.Add("94", "FLOWER", @"../../UsedForResource/Flower/Flower_94.jpg");

            dtFlower.Rows.Add("95", "FLOWER", @"../../UsedForResource/Flower/Flower_95.jpg");

            dtFlower.Rows.Add("96", "FLOWER", @"../../UsedForResource/Flower/Flower_96.jpg");

            dtFlower.Rows.Add("97", "FLOWER", @"../../UsedForResource/Flower/Flower_97.jpg");

            dtFlower.Rows.Add("98", "FLOWER", @"../../UsedForResource/Flower/Flower_98.jpg");

            dtFlower.Rows.Add("99", "FLOWER", @"../../UsedForResource/Flower/Flower_99.jpg");

            dtFlower.Rows.Add("100", "FLOWER", @"../../UsedForResource/Flower/Flower_100.jpg");

            dtFlower.Rows.Add("101", "FLOWER", @"../../UsedForResource/Flower/Flower_101.jpg");

            dtFlower.Rows.Add("102", "FLOWER", @"../../UsedForResource/Flower/Flower_102.jpg");

            dtFlower.Rows.Add("103", "FLOWER", @"../../UsedForResource/Flower/Flower_103.jpg");

            dtFlower.Rows.Add("104", "FLOWER", @"../../UsedForResource/Flower/Flower_104.jpg");

            dtFlower.Rows.Add("105", "FLOWER", @"../../UsedForResource/Flower/Flower_105.jpg");

            dtFlower.Rows.Add("106", "FLOWER", @"../../UsedForResource/Flower/Flower_106.jpg");

            dtFlower.Rows.Add("107", "FLOWER", @"../../UsedForResource/Flower/Flower_107.jpg");

            dtFlower.Rows.Add("108", "FLOWER", @"../../UsedForResource/Flower/Flower_108.jpg");

            dtFlower.Rows.Add("109", "FLOWER", @"../../UsedForResource/Flower/Flower_109.jpg");

            dtFlower.Rows.Add("110", "FLOWER", @"../../UsedForResource/Flower/Flower_110.jpg");

            dtFlower.Rows.Add("111", "FLOWER", @"../../UsedForResource/Flower/Flower_111.jpg");

            dtFlower.Rows.Add("112", "FLOWER", @"../../UsedForResource/Flower/Flower_112.jpg");

            dtFlower.Rows.Add("113", "FLOWER", @"../../UsedForResource/Flower/Flower_113.jpg");

            dtFlower.Rows.Add("114", "FLOWER", @"../../UsedForResource/Flower/Flower_114.jpg");

            dtFlower.Rows.Add("115", "FLOWER", @"../../UsedForResource/Flower/Flower_115.jpg");

            dtFlower.Rows.Add("116", "FLOWER", @"../../UsedForResource/Flower/Flower_116.jpg");

            dtFlower.Rows.Add("117", "FLOWER", @"../../UsedForResource/Flower/Flower_117.jpg");

            dtFlower.Rows.Add("118", "FLOWER", @"../../UsedForResource/Flower/Flower_118.jpg");

            dtFlower.Rows.Add("119", "FLOWER", @"../../UsedForResource/Flower/Flower_119.jpg");

            dtFlower.Rows.Add("120", "FLOWER", @"../../UsedForResource/Flower/Flower_120.jpg");

            dtFlower.Rows.Add("121", "FLOWER", @"../../UsedForResource/Flower/Flower_121.jpg");

            dtFlower.Rows.Add("122", "FLOWER", @"../../UsedForResource/Flower/Flower_122.jpg");

            dtFlower.Rows.Add("123", "FLOWER", @"../../UsedForResource/Flower/Flower_123.jpg");

            dtFlower.Rows.Add("124", "FLOWER", @"../../UsedForResource/Flower/Flower_124.jpg");

            dtFlower.Rows.Add("125", "FLOWER", @"../../UsedForResource/Flower/Flower_125.jpg");

            dtFlower.Rows.Add("126", "FLOWER", @"../../UsedForResource/Flower/Flower_126.jpg");

            dtFlower.Rows.Add("127", "FLOWER", @"../../UsedForResource/Flower/Flower_127.jpg");

            dtFlower.Rows.Add("128", "FLOWER", @"../../UsedForResource/Flower/Flower_128.jpg");

            dtFlower.Rows.Add("129", "FLOWER", @"../../UsedForResource/Flower/Flower_129.jpg");

            dtFlower.Rows.Add("130", "FLOWER", @"../../UsedForResource/Flower/Flower_130.jpg");

            dtFlower.Rows.Add("131", "FLOWER", @"../../UsedForResource/Flower/Flower_131.jpg");

            dtFlower.Rows.Add("132", "FLOWER", @"../../UsedForResource/Flower/Flower_132.jpg");

            dtFlower.Rows.Add("133", "FLOWER", @"../../UsedForResource/Flower/Flower_133.jpg");

            dtFlower.Rows.Add("134", "FLOWER", @"../../UsedForResource/Flower/Flower_134.jpg");

            dtFlower.Rows.Add("135", "FLOWER", @"../../UsedForResource/Flower/Flower_135.jpg");

            dtFlower.Rows.Add("136", "FLOWER", @"../../UsedForResource/Flower/Flower_136.jpg");

            dtFlower.Rows.Add("137", "FLOWER", @"../../UsedForResource/Flower/Flower_137.jpg");

            dtFlower.Rows.Add("138", "FLOWER", @"../../UsedForResource/Flower/Flower_138.jpg");

            dtFlower.Rows.Add("139", "FLOWER", @"../../UsedForResource/Flower/Flower_139.jpg");

            dtFlower.Rows.Add("140", "FLOWER", @"../../UsedForResource/Flower/Flower_140.jpg");

            dtFlower.Rows.Add("141", "FLOWER", @"../../UsedForResource/Flower/Flower_141.jpg");

            dtFlower.Rows.Add("142", "FLOWER", @"../../UsedForResource/Flower/Flower_142.jpg");

            dtFlower.Rows.Add("143", "FLOWER", @"../../UsedForResource/Flower/Flower_143.jpg");

            dtFlower.Rows.Add("144", "FLOWER", @"../../UsedForResource/Flower/Flower_144.jpg");

            dtFlower.Rows.Add("145", "FLOWER", @"../../UsedForResource/Flower/Flower_145.jpg");

            dtFlower.Rows.Add("146", "FLOWER", @"../../UsedForResource/Flower/Flower_146.jpg");

            dtFlower.Rows.Add("147", "FLOWER", @"../../UsedForResource/Flower/Flower_147.jpg");

            dtFlower.Rows.Add("148", "FLOWER", @"../../UsedForResource/Flower/Flower_148.jpg");

            dtFlower.Rows.Add("149", "FLOWER", @"../../UsedForResource/Flower/Flower_149.jpg");

            dtFlower.Rows.Add("150", "FLOWER", @"../../UsedForResource/Flower/Flower_150.jpg");

            dtFlower.Rows.Add("151", "FLOWER", @"../../UsedForResource/Flower/Flower_151.jpg");

            dtFlower.Rows.Add("152", "FLOWER", @"../../UsedForResource/Flower/Flower_152.jpg");

            dtFlower.Rows.Add("153", "FLOWER", @"../../UsedForResource/Flower/Flower_153.jpg");

            dtFlower.Rows.Add("154", "FLOWER", @"../../UsedForResource/Flower/Flower_154.jpg");

            dtFlower.Rows.Add("155", "FLOWER", @"../../UsedForResource/Flower/Flower_155.jpg");

            dtFlower.Rows.Add("156", "FLOWER", @"../../UsedForResource/Flower/Flower_156.jpg");

            dtFlower.Rows.Add("157", "FLOWER", @"../../UsedForResource/Flower/Flower_157.jpg");

            dtFlower.Rows.Add("158", "FLOWER", @"../../UsedForResource/Flower/Flower_158.jpg");

            dtFlower.Rows.Add("159", "FLOWER", @"../../UsedForResource/Flower/Flower_159.jpg");

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
                }
                else if (i == numrandomCar_2)
                {
                    pictureBoxShowingMain_2.Image = Image.FromFile(Convert.ToString(dtCar.Rows[numrandomCar_2 - 1]["Path"]));
                    pictureBox_panelSeeMore_flowLayoutPanelDetailPicture_form1_showingMore_2.Image = Image.FromFile(Convert.ToString(dtCar.Rows[numrandomCar_2 - 1]["Path"]));
                }
                else if (i == numrandomCar_3)
                {
                    pictureBoxShowingMain_3.Image = Image.FromFile(Convert.ToString(dtCar.Rows[numrandomCar_3 - 1]["Path"]));
                }
                else if (i == numrandomCar_4)
                {
                    pictureBoxShowingMain_4.Image = Image.FromFile(Convert.ToString(dtCar.Rows[numrandomCar_4 - 1]["Path"]));
                }
            }
            for (int j = 1; j < 230; j++)
            {
                if (j == numrandomInterior_1)
                {
                    pictureBoxShowingMain_5.Image = Image.FromFile(Convert.ToString(dtInterior.Rows[numrandomInterior_1 - 1]["Path"]));
                    pictureBox_click_panelExploreTopics_flowLayoutPanelMain_form1_categorizedInterior.Image = Image.FromFile(Convert.ToString(dtInterior.Rows[numrandomInterior_1 - 1]["Path"]));
                    pictureBox_panelSeeMore_flowLayoutPanelDetailPicture_form1_showingMore_3.Image= Image.FromFile(Convert.ToString(dtInterior.Rows[numrandomInterior_1 - 1]["Path"]));
                }
                else if (j == numrandomInterior_2)
                {
                    pictureBoxShowingMain_6.Image = Image.FromFile(Convert.ToString(dtInterior.Rows[numrandomInterior_2 - 1]["Path"]));
                    pictureBox_panelSeeMore_flowLayoutPanelDetailPicture_form1_showingMore_4.Image = Image.FromFile(Convert.ToString(dtInterior.Rows[numrandomInterior_2 - 1]["Path"]));
                }
                else if (j == numrandomInterior_3)
                {
                    pictureBoxShowingMain_7.Image = Image.FromFile(Convert.ToString(dtInterior.Rows[numrandomInterior_3 - 1]["Path"]));
                }
                else if (j == numrandomInterior_4)
                {
                    pictureBoxShowingMain_8.Image = Image.FromFile(Convert.ToString(dtInterior.Rows[numrandomInterior_4 - 1]["Path"]));
                }
            }
            for (int l = 1; l < 206; l++)
            {
                if (l == numrandomForest_1)
                {
                    pictureBoxShowingMain_9.Image = Image.FromFile(Convert.ToString(dtForest.Rows[numrandomForest_1 - 1]["Path"]));
                    pictureBox_click_panelExploreTopics_flowLayoutPanelMain_form1_categorizedForest.Image = Image.FromFile(Convert.ToString(dtForest.Rows[numrandomForest_1 - 1]["Path"]));
                    pictureBox_panelSeeMore_flowLayoutPanelDetailPicture_form1_showingMore_5.Image= Image.FromFile(Convert.ToString(dtForest.Rows[numrandomForest_1 - 1]["Path"]));
                }
                else if (l == numrandomForest_2)
                {
                    pictureBoxShowingMain_10.Image = Image.FromFile(Convert.ToString(dtForest.Rows[numrandomForest_2 - 1]["Path"]));
                    pictureBox_panelSeeMore_flowLayoutPanelDetailPicture_form1_showingMore_6.Image = Image.FromFile(Convert.ToString(dtForest.Rows[numrandomForest_2 - 1]["Path"]));
                }
                else if (l == numrandomForest_3)
                {
                    pictureBoxShowingMain_11.Image = Image.FromFile(Convert.ToString(dtForest.Rows[numrandomForest_3 - 1]["Path"]));
                }
                else if (l == numrandomForest_4)
                {
                    pictureBoxShowingMain_12.Image = Image.FromFile(Convert.ToString(dtForest.Rows[numrandomForest_4 - 1]["Path"]));
                }
            }
            for (int p = 1; p < 187; p++)
            {
                if (p == numrandomOceans1)
                {
                    pictureBoxShowingMain_13.Image = Image.FromFile(Convert.ToString(dtOceans.Rows[numrandomOceans1 - 1]["Path"]));
                    pictureBox_click_panelExploreTopics_flowLayoutPanelMain_form1_categorizedOceans.Image = Image.FromFile(Convert.ToString(dtOceans.Rows[numrandomOceans1 - 1]["Path"]));
                    pictureBox_panelSeeMore_flowLayoutPanelDetailPicture_form1_showingMore_7.Image=Image.FromFile(Convert.ToString(dtOceans.Rows[numrandomOceans1 - 1]["Path"]));
                }
                else if (p == numrandomOceans2)
                {
                    pictureBoxShowingMain_14.Image = Image.FromFile(Convert.ToString(dtOceans.Rows[numrandomOceans2 - 1]["Path"]));
                    pictureBox_panelSeeMore_flowLayoutPanelDetailPicture_form1_showingMore_8.Image = Image.FromFile(Convert.ToString(dtOceans.Rows[numrandomOceans2 - 1]["Path"]));
                }
                else if (p == numrandomOceans3)
                {
                    pictureBoxShowingMain_15.Image = Image.FromFile(Convert.ToString(dtOceans.Rows[numrandomOceans3 - 1]["Path"]));
                    pictureBox_panelSeeMore_flowLayoutPanelDetailPicture_form1_showingMore_15.Image=Image.FromFile(Convert.ToString(dtOceans.Rows[numrandomOceans3 - 1]["Path"]));
                }
                else if (p == numrandomOceans4)
                {
                    pictureBoxShowingMain_16.Image = Image.FromFile(Convert.ToString(dtOceans.Rows[numrandomOceans4 - 1]["Path"]));
                }
            }
            for (int o = 1; o < 243; o++)
            {
                if (o == numrandomMotoBike_1)
                {
                    pictureBoxShowingMain_17.Image = Image.FromFile(Convert.ToString(dtMotoBike.Rows[numrandomMotoBike_1 - 1]["Path"]));
                    pictureBox_click_panelExploreTopics_flowLayoutPanelMain_form1_categorizedMotoBike.Image = Image.FromFile(Convert.ToString(dtMotoBike.Rows[numrandomMotoBike_1 - 1]["Path"]));
                    pictureBox_panelSeeMore_flowLayoutPanelDetailPicture_form1_showingMore_9.Image= Image.FromFile(Convert.ToString(dtMotoBike.Rows[numrandomMotoBike_1 - 1]["Path"]));
                }
                else if (o == numrandomMotoBike_2)
                {
                    pictureBoxShowingMain_18.Image = Image.FromFile(Convert.ToString(dtMotoBike.Rows[numrandomMotoBike_2 - 1]["Path"]));
                    pictureBox_panelSeeMore_flowLayoutPanelDetailPicture_form1_showingMore_10.Image = Image.FromFile(Convert.ToString(dtMotoBike.Rows[numrandomMotoBike_2 - 1]["Path"]));
                }
                else if (o == numrandomMotoBike_3)
                {
                    pictureBoxShowingMain_19.Image = Image.FromFile(Convert.ToString(dtMotoBike.Rows[numrandomMotoBike_3 - 1]["Path"]));
                    pictureBox_panelSeeMore_flowLayoutPanelDetailPicture_form1_showingMore_14.Image= Image.FromFile(Convert.ToString(dtMotoBike.Rows[numrandomMotoBike_3 - 1]["Path"]));
                }
                else if (o == numrandomMotoBike_4)
                {
                    pictureBoxShowingMain_20.Image = Image.FromFile(Convert.ToString(dtMotoBike.Rows[numrandomMotoBike_4 - 1]["Path"]));
                }
            }
            for (int u = 1; u < 160; u++)
            {
                if (u == numrandomFlower_1)
                {
                    pictureBoxShowingMain_21.Image = Image.FromFile(Convert.ToString(dtFlower.Rows[numrandomFlower_1 - 1]["Path"]));
                    pictureBox_click_panelExploreTopics_flowLayoutPanelMain_form1_categorizedFlower.Image = Image.FromFile(Convert.ToString(dtFlower.Rows[numrandomFlower_1 - 1]["Path"]));
                    pictureBox_panelSeeMore_flowLayoutPanelDetailPicture_form1_showingMore_11.Image= Image.FromFile(Convert.ToString(dtFlower.Rows[numrandomFlower_1 - 1]["Path"]));
                }
                else if (u == numrandomFlower_2)
                {
                    pictureBoxShowingMain_22.Image = Image.FromFile(Convert.ToString(dtFlower.Rows[numrandomFlower_2 - 1]["Path"]));
                    pictureBox_panelSeeMore_flowLayoutPanelDetailPicture_form1_showingMore_12.Image = Image.FromFile(Convert.ToString(dtFlower.Rows[numrandomFlower_2 - 1]["Path"]));
                }
                else if (u == numrandomFlower_3)
                {
                    pictureBoxShowingMain_23.Image = Image.FromFile(Convert.ToString(dtFlower.Rows[numrandomFlower_3 - 1]["Path"]));
                    pictureBox_panelSeeMore_flowLayoutPanelDetailPicture_form1_showingMore_13.Image = Image.FromFile(Convert.ToString(dtFlower.Rows[numrandomFlower_3 - 1]["Path"]));
                }
                else if (u == numrandomFlower_4)
                {
                    pictureBoxShowingMain_24.Image = Image.FromFile(Convert.ToString(dtFlower.Rows[numrandomFlower_4 - 1]["Path"]));
                }
            }


            Random randomCategorizedToPutPictureInPanelSeeMoreAtYouMightLike = new Random();
            int randomCar_youmightlike = randomCategorizedToPutPictureInPanelSeeMoreAtYouMightLike.Next(1, 158);
            int randomInterior_youmightlike = randomCategorizedToPutPictureInPanelSeeMoreAtYouMightLike.Next(1, 230);
            int randomOceans_youmightlike = randomCategorizedToPutPictureInPanelSeeMoreAtYouMightLike.Next(1, 187);
            int randomFlower_youmightlike = randomCategorizedToPutPictureInPanelSeeMoreAtYouMightLike.Next(1, 160);
            int randomMotoBike_youmightlike = randomCategorizedToPutPictureInPanelSeeMoreAtYouMightLike.Next(1, 243);
            int randomForest_youmightlike = randomCategorizedToPutPictureInPanelSeeMoreAtYouMightLike.Next(1, 206);
            for (int i = 1; i <= 157; i++)
            {
                if (randomCar_youmightlike == i)
                {
                    pictureBox_panelSeeMore_flowLayoutPanelDetailPicture_form1_showingMore_19.Image = Image.FromFile(Convert.ToString(dtCar.Rows[randomCar_youmightlike - 1]["Path"]));
                }

            }
            for (int j = 1; j <= 229; j++)
            {
                if (randomInterior_youmightlike == j)
                {
                    pictureBox_panelSeeMore_flowLayoutPanelDetailPicture_form1_showingMore_20.Image = Image.FromFile(Convert.ToString(dtInterior.Rows[randomInterior_youmightlike - 1]["Path"]));
                }
            }
            for (int k = 1; k <= 186; k++)
            {
                if (randomOceans_youmightlike == k)
                {
                    pictureBox_panelSeeMore_flowLayoutPanelDetailPicture_form1_showingMore_21.Image = Image.FromFile(Convert.ToString(dtOceans.Rows[randomOceans_youmightlike - 1]["Path"]));
                }
            }
            for (int p = 1; p <= 159; p++)
            {
                if (randomFlower_youmightlike == p)
                {
                    pictureBox_panelSeeMore_flowLayoutPanelDetailPicture_form1_showingMore_22.Image = Image.FromFile(Convert.ToString(dtFlower.Rows[randomFlower_youmightlike - 1]["Path"]));
                }
            }
            for (int o = 1; o <= 242; o++)
            {
                if (randomMotoBike_youmightlike == o)
                {
                    pictureBox_panelSeeMore_flowLayoutPanelDetailPicture_form1_showingMore_23.Image = Image.FromFile(Convert.ToString(dtMotoBike.Rows[randomMotoBike_youmightlike - 1]["Path"]));
                }
            }
            for (int u = 1; u <= 205; u++)
            {
                if (randomForest_youmightlike == u)
                {
                    pictureBox_panelSeeMore_flowLayoutPanelDetailPicture_form1_showingMore_24.Image = Image.FromFile(Convert.ToString(dtForest.Rows[randomForest_youmightlike - 1]["Path"]));
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

        private void pictureBox23_Click(object sender, EventArgs e)
        {
            pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBox_panelSeeMore_flowLayoutPanelDetailPicture_form1_showingMore_21.Image;
            button_click_panelDetailPicture_flowLayoutPanelDetailPicture_form1_tags_1.Text = "OCEANS";
            danhgiau_pictureBoxShowing = 60;
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
        }

        private void button_click_panelDetailPicture_flowLayoutPanelDetailPicture_form1_detailPictureBack_Click(object sender, EventArgs e)
        {
            if((danhgiau_pictureBoxShowing>=1 && danhgiau_pictureBoxShowing <=24) || (danhgiau_pictureBoxShowing >= 40 && danhgiau_pictureBoxShowing <= 63))
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
        int cmt_panelComment_flowLayoutPanelComment_panelDetailPicture_flowLayoutPanelDetailPicture_form1 = 0;
        private void button_click_panelDetailPicture_flowLayoutPanelDetailPicture_form1_post_Click(object sender, EventArgs e)
        {
            if (cmt_panelComment_flowLayoutPanelComment_panelDetailPicture_flowLayoutPanelDetailPicture_form1 % 2 == 0)
            {
                richTextBox_panelComment_1_flowLayoutPanelComment_panelDetailPicture_flowLayoutPanelDetailPicture_form1_comment_1.Text = " Nakaramiurenaruto                                                                              Dember,13,21\n" + " " + richTextBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_yourcomment.Text;
                panelComment_1_flowLayoutPanelComment_panelDetailPicture_flowLayoutPanelDetailPicture_form1.Visible = true;
                cmt_panelComment_flowLayoutPanelComment_panelDetailPicture_flowLayoutPanelDetailPicture_form1++;
            }
            else if (cmt_panelComment_flowLayoutPanelComment_panelDetailPicture_flowLayoutPanelDetailPicture_form1 % 2 != 0)
            {
                richTextBox_panelComment_2_flowLayoutPanelComment_panelDetailPicture_flowLayoutPanelDetailPicture_form1_comment_2.Text = " Nakaramiurenaruto                                                                              Dember,13,21\n" + " " + richTextBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_yourcomment.Text;
                panelComment_2_flowLayoutPanelComment_panelDetailPicture_flowLayoutPanelDetailPicture_form1.Visible = true;
                cmt_panelComment_flowLayoutPanelComment_panelDetailPicture_flowLayoutPanelDetailPicture_form1++;
            }

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
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
        }

        private void pictureBoxShowingMain_3_Click(object sender, EventArgs e)
        {
            flowLayoutPanelDetailPicture_form1.Visible = true;
            flowLayoutPanelMain_form1.Visible = false;
            pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBoxShowingMain_3.Image;
            danhgiau_pictureBoxShowing = 3;
            button_click_panelDetailPicture_flowLayoutPanelDetailPicture_form1_tags_1.Text = "CAR";
        }

        private void pictureBoxShowingMain_4_Click(object sender, EventArgs e)
        {
            flowLayoutPanelDetailPicture_form1.Visible = true;
            flowLayoutPanelMain_form1.Visible = false;
            pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBoxShowingMain_4.Image;
            danhgiau_pictureBoxShowing = 4;
            button_click_panelDetailPicture_flowLayoutPanelDetailPicture_form1_tags_1.Text = "CAR";
        }

        private void pictureBoxShowingMain_5_Click(object sender, EventArgs e)
        {
            flowLayoutPanelDetailPicture_form1.Visible = true;
            flowLayoutPanelMain_form1.Visible = false;
            pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBoxShowingMain_5.Image;
            danhgiau_pictureBoxShowing = 5;
            button_click_panelDetailPicture_flowLayoutPanelDetailPicture_form1_tags_1.Text = "INTERIOR";
        }

        private void pictureBoxShowingMain_6_Click(object sender, EventArgs e)
        {
            flowLayoutPanelDetailPicture_form1.Visible = true;
            flowLayoutPanelMain_form1.Visible = false;
            pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBoxShowingMain_6.Image;
            danhgiau_pictureBoxShowing = 6;
            button_click_panelDetailPicture_flowLayoutPanelDetailPicture_form1_tags_1.Text = "INTERIOR";
        }

        private void pictureBoxShowingMain_7_Click(object sender, EventArgs e)
        {
            flowLayoutPanelDetailPicture_form1.Visible = true;
            flowLayoutPanelMain_form1.Visible = false;
            pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBoxShowingMain_7.Image;
            danhgiau_pictureBoxShowing = 7;
            button_click_panelDetailPicture_flowLayoutPanelDetailPicture_form1_tags_1.Text = "INTERIOR";
        }

        private void pictureBoxShowingMain_8_Click(object sender, EventArgs e)
        {
            flowLayoutPanelDetailPicture_form1.Visible = true;
            flowLayoutPanelMain_form1.Visible = false;
            pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBoxShowingMain_8.Image;
            danhgiau_pictureBoxShowing = 8;
            button_click_panelDetailPicture_flowLayoutPanelDetailPicture_form1_tags_1.Text = "INTERIOR";
        }

        private void pictureBoxShowingMain_9_Click(object sender, EventArgs e)
        {
            flowLayoutPanelDetailPicture_form1.Visible = true;
            flowLayoutPanelMain_form1.Visible = false;
            pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBoxShowingMain_9.Image;
            danhgiau_pictureBoxShowing = 9;
            button_click_panelDetailPicture_flowLayoutPanelDetailPicture_form1_tags_1.Text = "FOREST";
        }

        private void pictureBoxShowingMain_10_Click(object sender, EventArgs e)
        {
            flowLayoutPanelDetailPicture_form1.Visible = true;
            flowLayoutPanelMain_form1.Visible = false;
            pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBoxShowingMain_10.Image;
            danhgiau_pictureBoxShowing = 10;
            button_click_panelDetailPicture_flowLayoutPanelDetailPicture_form1_tags_1.Text = "FOREST";
        }

        private void pictureBoxShowingMain_11_Click(object sender, EventArgs e)
        {
            flowLayoutPanelDetailPicture_form1.Visible = true;
            flowLayoutPanelMain_form1.Visible = false;
            pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBoxShowingMain_11.Image;
            danhgiau_pictureBoxShowing = 11;
            button_click_panelDetailPicture_flowLayoutPanelDetailPicture_form1_tags_1.Text = "FOREST";
        }

        private void pictureBoxShowingMain_12_Click(object sender, EventArgs e)
        {
            flowLayoutPanelDetailPicture_form1.Visible = true;
            flowLayoutPanelMain_form1.Visible = false;
            pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBoxShowingMain_12.Image;
            danhgiau_pictureBoxShowing = 12;
            button_click_panelDetailPicture_flowLayoutPanelDetailPicture_form1_tags_1.Text = "FOREST";
        }

        private void pictureBoxShowingMain_13_Click(object sender, EventArgs e)
        {
            flowLayoutPanelDetailPicture_form1.Visible = true;
            flowLayoutPanelMain_form1.Visible = false;
            pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBoxShowingMain_13.Image;
            danhgiau_pictureBoxShowing = 13;
            button_click_panelDetailPicture_flowLayoutPanelDetailPicture_form1_tags_1.Text = "OCEANS";
        }

        private void pictureBoxShowingMain_14_Click(object sender, EventArgs e)
        {
            flowLayoutPanelDetailPicture_form1.Visible = true;
            flowLayoutPanelMain_form1.Visible = false;
            pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBoxShowingMain_14.Image;
            danhgiau_pictureBoxShowing = 14;
            button_click_panelDetailPicture_flowLayoutPanelDetailPicture_form1_tags_1.Text = "OCEANS";
        }

        private void pictureBoxShowingMain_15_Click(object sender, EventArgs e)
        {
            flowLayoutPanelDetailPicture_form1.Visible = true;
            flowLayoutPanelMain_form1.Visible = false;
            pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBoxShowingMain_15.Image;
            danhgiau_pictureBoxShowing = 15;
            button_click_panelDetailPicture_flowLayoutPanelDetailPicture_form1_tags_1.Text = "OCEANS";
        }

        private void pictureBoxShowingMain_16_Click(object sender, EventArgs e)
        {
            flowLayoutPanelDetailPicture_form1.Visible = true;
            flowLayoutPanelMain_form1.Visible = false;
            pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBoxShowingMain_16.Image;
            danhgiau_pictureBoxShowing = 16;
            button_click_panelDetailPicture_flowLayoutPanelDetailPicture_form1_tags_1.Text = "OCEANS";
        }

        private void pictureBoxShowingMain_17_Click(object sender, EventArgs e)
        {
            flowLayoutPanelDetailPicture_form1.Visible = true;
            flowLayoutPanelMain_form1.Visible = false;
            pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBoxShowingMain_17.Image;
            danhgiau_pictureBoxShowing = 17;
            button_click_panelDetailPicture_flowLayoutPanelDetailPicture_form1_tags_1.Text = "MOTOBIKE";  
        }

        private void pictureBoxShowingMain_18_Click(object sender, EventArgs e)
        {
            flowLayoutPanelDetailPicture_form1.Visible = true;
            flowLayoutPanelMain_form1.Visible = false;
            pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBoxShowingMain_18.Image;
            danhgiau_pictureBoxShowing = 18;
            button_click_panelDetailPicture_flowLayoutPanelDetailPicture_form1_tags_1.Text = "MOTOBIKE";
        }

        private void pictureBoxShowingMain_19_Click(object sender, EventArgs e)
        {
            flowLayoutPanelDetailPicture_form1.Visible = true;
            flowLayoutPanelMain_form1.Visible = false;
            pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBoxShowingMain_19.Image;
            danhgiau_pictureBoxShowing = 19;
            button_click_panelDetailPicture_flowLayoutPanelDetailPicture_form1_tags_1.Text = "MOTOBIKE";
        }

        private void pictureBoxShowingMain_20_Click(object sender, EventArgs e)
        {
            flowLayoutPanelDetailPicture_form1.Visible = true;
            flowLayoutPanelMain_form1.Visible = false;
            pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBoxShowingMain_20.Image;
            danhgiau_pictureBoxShowing = 20;
            button_click_panelDetailPicture_flowLayoutPanelDetailPicture_form1_tags_1.Text = "MOTOBIKE";
        }

        private void pictureBoxShowingMain_21_Click(object sender, EventArgs e)
        {
            flowLayoutPanelDetailPicture_form1.Visible = true;
            flowLayoutPanelMain_form1.Visible = false;
            pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBoxShowingMain_21.Image;
            danhgiau_pictureBoxShowing = 21;
            button_click_panelDetailPicture_flowLayoutPanelDetailPicture_form1_tags_1.Text = "FLOWER";
        }

        private void pictureBoxShowingMain_22_Click(object sender, EventArgs e)
        {
            flowLayoutPanelDetailPicture_form1.Visible = true;
            flowLayoutPanelMain_form1.Visible = false;
            pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBoxShowingMain_22.Image;
            danhgiau_pictureBoxShowing = 22;
            button_click_panelDetailPicture_flowLayoutPanelDetailPicture_form1_tags_1.Text = "FLOWER";
        }

        private void pictureBoxShowingMain_23_Click(object sender, EventArgs e)
        {
            flowLayoutPanelDetailPicture_form1.Visible = true;
            flowLayoutPanelMain_form1.Visible = false;
            pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBoxShowingMain_23.Image;
            danhgiau_pictureBoxShowing = 23;
            button_click_panelDetailPicture_flowLayoutPanelDetailPicture_form1_tags_1.Text = "FLOWER";
        }

        private void pictureBoxShowingMain_24_Click(object sender, EventArgs e)
        {
            flowLayoutPanelDetailPicture_form1.Visible = true;
            flowLayoutPanelMain_form1.Visible = false;
            pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBoxShowingMain_24.Image;
            danhgiau_pictureBoxShowing = 24;
            button_click_panelDetailPicture_flowLayoutPanelDetailPicture_form1_tags_1.Text = "FLOWER";
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
                case 58:
                    pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBox_panelSeeMore_flowLayoutPanelDetailPicture_form1_showingMore_19.Image;
                    break;
                case 59:
                    pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBox_panelSeeMore_flowLayoutPanelDetailPicture_form1_showingMore_20.Image;
                    break;
                case 60:
                    pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBox_panelSeeMore_flowLayoutPanelDetailPicture_form1_showingMore_21.Image;
                    break;
                case 61:
                    pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBox_panelSeeMore_flowLayoutPanelDetailPicture_form1_showingMore_22.Image;
                    break;
                case 62:
                    pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBox_panelSeeMore_flowLayoutPanelDetailPicture_form1_showingMore_23.Image;
                    break;
                case 63:
                    pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBox_panelSeeMore_flowLayoutPanelDetailPicture_form1_showingMore_24.Image;
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
                case 58:
                    pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBox_panelSeeMore_flowLayoutPanelDetailPicture_form1_showingMore_19.Image;
                    break;
                case 59:
                    pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBox_panelSeeMore_flowLayoutPanelDetailPicture_form1_showingMore_20.Image;
                    break;
                case 60:
                    pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBox_panelSeeMore_flowLayoutPanelDetailPicture_form1_showingMore_21.Image;
                    break;
                case 61:
                    pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBox_panelSeeMore_flowLayoutPanelDetailPicture_form1_showingMore_22.Image;
                    break;
                case 62:
                    pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBox_panelSeeMore_flowLayoutPanelDetailPicture_form1_showingMore_23.Image;
                    break;
                case 63:
                    pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBox_panelSeeMore_flowLayoutPanelDetailPicture_form1_showingMore_24.Image;
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
                }

            }
            for(int j=1;j<=229;j++)
            {
                if (randomInterior == j)
                {
                    pictureBox_panelHome_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_showingHome_2.Image = Image.FromFile(Convert.ToString(dtInterior.Rows[randomInterior - 1]["Path"]));
                }
            }
            for(int k=1;k<=186;k++)
            {
                if (randomOceans == k)
                {
                    pictureBox_panelHome_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_showingHome_3.Image = Image.FromFile(Convert.ToString(dtOceans.Rows[randomOceans - 1]["Path"]));
                }
            }
            for (int p = 1; p <= 159;p++)
            {
                if (randomFlower == p)
                {
                    pictureBox_panelHome_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_showingHome_4.Image = Image.FromFile(Convert.ToString(dtFlower.Rows[randomFlower - 1]["Path"]));
                }
            }
            for (int o=1;o<=242;o++)
            {
                if (randomMotoBike == o)
                {
                    pictureBox_panelHome_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_showingHome_5.Image = Image.FromFile(Convert.ToString(dtMotoBike.Rows[randomMotoBike - 1]["Path"]));
                }
            }
            for(int u=1;u<=205;u++)
            {
                if (randomForest == u)
                {
                    pictureBox_panelHome_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_showingHome_6.Image = Image.FromFile(Convert.ToString(dtForest.Rows[randomForest - 1]["Path"]));
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


        }

        private void pictureBox_panelHome_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_showingHome_2_Click(object sender, EventArgs e)
        {
            pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBox_panelHome_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_showingHome_2.Image;
            danhgiau_pictureBoxShowing = 26;
            button_click_panelDetailPicture_flowLayoutPanelDetailPicture_form1_tags_1.Text = "INTERIOR";
            flowLayoutPanelShowingAuthorDetail_form1.Visible = false;
            flowLayoutPanelDetailPicture_form1.Visible = true;
        }

        private void pictureBox_panelHome_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_showingHome_3_Click(object sender, EventArgs e)
        {
            pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBox_panelHome_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_showingHome_3.Image;
            danhgiau_pictureBoxShowing = 27;
            button_click_panelDetailPicture_flowLayoutPanelDetailPicture_form1_tags_1.Text = "OCEANS";
            flowLayoutPanelShowingAuthorDetail_form1.Visible = false;
            flowLayoutPanelDetailPicture_form1.Visible = true;
        }

        private void pictureBox_panelHome_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_showingHome_4_Click(object sender, EventArgs e)
        {
            pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBox_panelHome_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_showingHome_4.Image;
            danhgiau_pictureBoxShowing = 28;
            button_click_panelDetailPicture_flowLayoutPanelDetailPicture_form1_tags_1.Text = "FLOWER";
            flowLayoutPanelShowingAuthorDetail_form1.Visible = false;
            flowLayoutPanelDetailPicture_form1.Visible = true;
        }

        private void pictureBox_panelHome_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_showingHome_5_Click(object sender, EventArgs e)
        {
            pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBox_panelHome_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_showingHome_5.Image;
            danhgiau_pictureBoxShowing = 29;
            button_click_panelDetailPicture_flowLayoutPanelDetailPicture_form1_tags_1.Text = "MOTOBIKE";
            flowLayoutPanelShowingAuthorDetail_form1.Visible = false;
            flowLayoutPanelDetailPicture_form1.Visible = true;
        }

        private void pictureBox_panelHome_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_showingHome_6_Click(object sender, EventArgs e)
        {
            pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBox_panelHome_panelShowingAuthorDetail_flowLayoutPanelShowingAuthorDetail_form1_showingHome_6.Image;
            danhgiau_pictureBoxShowing = 30;
            button_click_panelDetailPicture_flowLayoutPanelDetailPicture_form1_tags_1.Text = "FOREST";
            flowLayoutPanelShowingAuthorDetail_form1.Visible = false;
            flowLayoutPanelDetailPicture_form1.Visible = true;
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
        }

        private void pictureBox_panelSeeMore_flowLayoutPanelDetailPicture_form1_showingMore_2_Click(object sender, EventArgs e)
        {
            pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBox_panelSeeMore_flowLayoutPanelDetailPicture_form1_showingMore_2.Image;
            button_click_panelDetailPicture_flowLayoutPanelDetailPicture_form1_tags_1.Text = "CAR";
            danhgiau_pictureBoxShowing = 41;
        }

        private void pictureBox_panelSeeMore_flowLayoutPanelDetailPicture_form1_showingMore_3_Click(object sender, EventArgs e)
        {
            pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBox_panelSeeMore_flowLayoutPanelDetailPicture_form1_showingMore_3.Image;
            button_click_panelDetailPicture_flowLayoutPanelDetailPicture_form1_tags_1.Text = "INTERIOR";
            danhgiau_pictureBoxShowing = 42;
        }

        private void pictureBox_panelSeeMore_flowLayoutPanelDetailPicture_form1_showingMore_4_Click(object sender, EventArgs e)
        {
            pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBox_panelSeeMore_flowLayoutPanelDetailPicture_form1_showingMore_4.Image;
            button_click_panelDetailPicture_flowLayoutPanelDetailPicture_form1_tags_1.Text = "INTERIOR";
            danhgiau_pictureBoxShowing = 43;
        }

        private void pictureBox_panelSeeMore_flowLayoutPanelDetailPicture_form1_showingMore_5_Click(object sender, EventArgs e)
        {
            pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBox_panelSeeMore_flowLayoutPanelDetailPicture_form1_showingMore_5.Image;
            button_click_panelDetailPicture_flowLayoutPanelDetailPicture_form1_tags_1.Text = "FOREST";
            danhgiau_pictureBoxShowing = 44;
        }

        private void pictureBox_panelSeeMore_flowLayoutPanelDetailPicture_form1_showingMore_6_Click(object sender, EventArgs e)
        {
            pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBox_panelSeeMore_flowLayoutPanelDetailPicture_form1_showingMore_6.Image;
            button_click_panelDetailPicture_flowLayoutPanelDetailPicture_form1_tags_1.Text = "FOREST";
            danhgiau_pictureBoxShowing = 45;
        }

        private void pictureBox_panelSeeMore_flowLayoutPanelDetailPicture_form1_showingMore_7_Click(object sender, EventArgs e)
        {
            pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBox_panelSeeMore_flowLayoutPanelDetailPicture_form1_showingMore_7.Image;
            button_click_panelDetailPicture_flowLayoutPanelDetailPicture_form1_tags_1.Text = "OCEANS";
            danhgiau_pictureBoxShowing = 46;
        }

        private void pictureBox_panelSeeMore_flowLayoutPanelDetailPicture_form1_showingMore_8_Click(object sender, EventArgs e)
        {
            pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBox_panelSeeMore_flowLayoutPanelDetailPicture_form1_showingMore_8.Image;
            button_click_panelDetailPicture_flowLayoutPanelDetailPicture_form1_tags_1.Text = "OCEANS";
            danhgiau_pictureBoxShowing = 47;
        }

        private void pictureBox_panelSeeMore_flowLayoutPanelDetailPicture_form1_showingMore_9_Click(object sender, EventArgs e)
        {
            pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBox_panelSeeMore_flowLayoutPanelDetailPicture_form1_showingMore_9.Image;
            button_click_panelDetailPicture_flowLayoutPanelDetailPicture_form1_tags_1.Text = "MOTOBIKE";
            danhgiau_pictureBoxShowing = 48;
        }

        private void pictureBox_panelSeeMore_flowLayoutPanelDetailPicture_form1_showingMore_10_Click(object sender, EventArgs e)
        {
            pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBox_panelSeeMore_flowLayoutPanelDetailPicture_form1_showingMore_10.Image;
            button_click_panelDetailPicture_flowLayoutPanelDetailPicture_form1_tags_1.Text = "MOTOBIKE";
            danhgiau_pictureBoxShowing = 49;
        }

        private void pictureBox_panelSeeMore_flowLayoutPanelDetailPicture_form1_showingMore_11_Click(object sender, EventArgs e)
        {
            pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBox_panelSeeMore_flowLayoutPanelDetailPicture_form1_showingMore_11.Image;
            button_click_panelDetailPicture_flowLayoutPanelDetailPicture_form1_tags_1.Text = "FLOWER";
            danhgiau_pictureBoxShowing = 50;
        }

        private void pictureBox_panelSeeMore_flowLayoutPanelDetailPicture_form1_showingMore_12_Click(object sender, EventArgs e)
        {
            pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBox_panelSeeMore_flowLayoutPanelDetailPicture_form1_showingMore_12.Image;
            button_click_panelDetailPicture_flowLayoutPanelDetailPicture_form1_tags_1.Text = "FLOWER";
            danhgiau_pictureBoxShowing = 51;
        }

        private void pictureBox_panelSeeMore_flowLayoutPanelDetailPicture_form1_showingMore_13_Click(object sender, EventArgs e)
        {
            pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBox_panelSeeMore_flowLayoutPanelDetailPicture_form1_showingMore_13.Image;
            button_click_panelDetailPicture_flowLayoutPanelDetailPicture_form1_tags_1.Text = "FLOWER";
            danhgiau_pictureBoxShowing = 52;
        }

        private void pictureBox_panelSeeMore_flowLayoutPanelDetailPicture_form1_showingMore_14_Click(object sender, EventArgs e)
        {
            pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBox_panelSeeMore_flowLayoutPanelDetailPicture_form1_showingMore_14.Image;
            button_click_panelDetailPicture_flowLayoutPanelDetailPicture_form1_tags_1.Text = "MOTOBIKE";
            danhgiau_pictureBoxShowing = 53;
        }

        private void pictureBox_panelSeeMore_flowLayoutPanelDetailPicture_form1_showingMore_15_Click(object sender, EventArgs e)
        {
            pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBox_panelSeeMore_flowLayoutPanelDetailPicture_form1_showingMore_15.Image;
            button_click_panelDetailPicture_flowLayoutPanelDetailPicture_form1_tags_1.Text = "OCEANS";
            danhgiau_pictureBoxShowing = 54;
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

        private void pictureBox_panelSeeMore_flowLayoutPanelDetailPicture_form1_showingMore_19_Click(object sender, EventArgs e)
        {
            pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBox_panelSeeMore_flowLayoutPanelDetailPicture_form1_showingMore_19.Image;
            button_click_panelDetailPicture_flowLayoutPanelDetailPicture_form1_tags_1.Text = "CAR";
            danhgiau_pictureBoxShowing = 58;
        }

        private void pictureBox_panelSeeMore_flowLayoutPanelDetailPicture_form1_showingMore_20_Click(object sender, EventArgs e)
        {
            pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBox_panelSeeMore_flowLayoutPanelDetailPicture_form1_showingMore_20.Image;
            button_click_panelDetailPicture_flowLayoutPanelDetailPicture_form1_tags_1.Text = "INTERIOR";
            danhgiau_pictureBoxShowing = 59;
        }

        private void pictureBox_panelSeeMore_flowLayoutPanelDetailPicture_form1_showingMore_22_Click(object sender, EventArgs e)
        {
            pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBox_panelSeeMore_flowLayoutPanelDetailPicture_form1_showingMore_22.Image;
            button_click_panelDetailPicture_flowLayoutPanelDetailPicture_form1_tags_1.Text = "FLOWER";
            danhgiau_pictureBoxShowing = 61;
        }

        private void pictureBox_panelSeeMore_flowLayoutPanelDetailPicture_form1_showingMore_23_Click(object sender, EventArgs e)
        {
            pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBox_panelSeeMore_flowLayoutPanelDetailPicture_form1_showingMore_23.Image;
            button_click_panelDetailPicture_flowLayoutPanelDetailPicture_form1_tags_1.Text = "MOTOBIKE";
            danhgiau_pictureBoxShowing = 62;
        }

        private void pictureBox_panelSeeMore_flowLayoutPanelDetailPicture_form1_showingMore_24_Click(object sender, EventArgs e)
        {
            pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBox_panelSeeMore_flowLayoutPanelDetailPicture_form1_showingMore_24.Image;
            button_click_panelDetailPicture_flowLayoutPanelDetailPicture_form1_tags_1.Text = "FOREST";
            danhgiau_pictureBoxShowing = 63;
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
              
        }

        private void pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_1_Click(object sender, EventArgs e)
        {
            flowLayoutPanelDetailPicture_form1.Visible = true;
            flowLayoutPanelDailyAndTrending_form1.Visible = false;
            pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_1.Image;
            danhgiau_pictureBoxShowing = 64;
            button_click_panelDetailPicture_flowLayoutPanelDetailPicture_form1_tags_1.Text = "CAR";
        }

        private void pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_2_Click(object sender, EventArgs e)
        {
            flowLayoutPanelDetailPicture_form1.Visible = true;
            flowLayoutPanelDailyAndTrending_form1.Visible = false;
            pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_2.Image;
            danhgiau_pictureBoxShowing = 65;
            button_click_panelDetailPicture_flowLayoutPanelDetailPicture_form1_tags_1.Text = "CAR";
        }

        private void pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_3_Click(object sender, EventArgs e)
        {
            flowLayoutPanelDetailPicture_form1.Visible = true;
            flowLayoutPanelDailyAndTrending_form1.Visible = false;
            pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_3.Image;
            danhgiau_pictureBoxShowing = 66;
            button_click_panelDetailPicture_flowLayoutPanelDetailPicture_form1_tags_1.Text = "INTERIOR";
        }

        private void pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_4_Click(object sender, EventArgs e)
        {
            flowLayoutPanelDetailPicture_form1.Visible = true;
            flowLayoutPanelDailyAndTrending_form1.Visible = false;
            pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_4.Image;
            danhgiau_pictureBoxShowing = 67;
            button_click_panelDetailPicture_flowLayoutPanelDetailPicture_form1_tags_1.Text = "INTERIOR";
        }

        private void pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_5_Click(object sender, EventArgs e)
        {
            flowLayoutPanelDetailPicture_form1.Visible = true;
            flowLayoutPanelDailyAndTrending_form1.Visible = false;
            pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_5.Image;
            danhgiau_pictureBoxShowing = 68;
            button_click_panelDetailPicture_flowLayoutPanelDetailPicture_form1_tags_1.Text = "FOREST";
        }

        private void pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_6_Click(object sender, EventArgs e)
        {
            flowLayoutPanelDetailPicture_form1.Visible = true;
            flowLayoutPanelDailyAndTrending_form1.Visible = false;
            pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_6.Image;
            danhgiau_pictureBoxShowing = 69;
            button_click_panelDetailPicture_flowLayoutPanelDetailPicture_form1_tags_1.Text = "FOREST";
        }

        private void pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_7_Click(object sender, EventArgs e)
        {
            flowLayoutPanelDetailPicture_form1.Visible = true;
            flowLayoutPanelDailyAndTrending_form1.Visible = false;
            pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_7.Image;
            danhgiau_pictureBoxShowing = 70;
            button_click_panelDetailPicture_flowLayoutPanelDetailPicture_form1_tags_1.Text = "OCEANS";
        }

        private void pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_8_Click(object sender, EventArgs e)
        {
            flowLayoutPanelDetailPicture_form1.Visible = true;
            flowLayoutPanelDailyAndTrending_form1.Visible = false;
            pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_8.Image;
            danhgiau_pictureBoxShowing = 71;
            button_click_panelDetailPicture_flowLayoutPanelDetailPicture_form1_tags_1.Text = "OCEANS";
        }

        private void pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_9_Click(object sender, EventArgs e)
        {
            flowLayoutPanelDetailPicture_form1.Visible = true;
            flowLayoutPanelDailyAndTrending_form1.Visible = false;
            pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_9.Image;
            danhgiau_pictureBoxShowing = 72;
            button_click_panelDetailPicture_flowLayoutPanelDetailPicture_form1_tags_1.Text = "MOTOBIKE";
        }

        private void pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_10_Click(object sender, EventArgs e)
        {
            flowLayoutPanelDetailPicture_form1.Visible = true;
            flowLayoutPanelDailyAndTrending_form1.Visible = false;
            pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_10.Image;
            danhgiau_pictureBoxShowing = 73;
            button_click_panelDetailPicture_flowLayoutPanelDetailPicture_form1_tags_1.Text = "MOTOBIKE";
        }

        private void pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_11_Click(object sender, EventArgs e)
        {
            flowLayoutPanelDetailPicture_form1.Visible = true;
            flowLayoutPanelDailyAndTrending_form1.Visible = false;
            pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_11.Image;
            danhgiau_pictureBoxShowing = 74;
            button_click_panelDetailPicture_flowLayoutPanelDetailPicture_form1_tags_1.Text = "FLOWER";
        }

        private void pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_12_Click(object sender, EventArgs e)
        {
            flowLayoutPanelDetailPicture_form1.Visible = true;
            flowLayoutPanelDailyAndTrending_form1.Visible = false;
            pictureBox_panelDetailPicture_flowLayoutPanelDetailPicture_form1_showingPicture.Image = pictureBox_click_flowLayoutPanelDailyAndTrending_form1_showingDailyandTrending_12.Image;
            danhgiau_pictureBoxShowing = 75;

            button_click_panelDetailPicture_flowLayoutPanelDetailPicture_form1_tags_1.Text = "FLOWER";
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
    }
}

