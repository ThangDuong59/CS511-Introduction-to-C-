using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace exercise10
{
    public partial class FormMain : Form
    {
        private DataTable playlist_dt;
        private int current_listView_index = 0;

        public DataTable PlaylistDataTable
        {
            get { return playlist_dt; }
            set { playlist_dt = value; }
        }

        public ListView PlaylistsListView
        {
            get { return listView_playlists; }
            set { listView_playlists = value; }
        }

        private DataTable initialize_playlist_dt()
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("PlaylistName", typeof(string));
            dt.Columns.Add("VideoName", typeof(string));
            dt.Columns.Add("VideoPath", typeof(string));

            dt.Rows.Add("2019", "2019_CUA LẠI VỢ BẦU", @"D:\UIT\CS511\CS511-Introduction-to-C-Sharp\exercises\exercise10\Buổi 11\Video\2019_CUA LẠI VỢ BẦU.mp4");
            dt.Rows.Add("2019", "2019_NGƯỜI CÁ BÁO THÙ", @"D:\UIT\CS511\CS511-Introduction-to-C-Sharp\exercises\exercise10\Buổi 11\Video\2019_NGƯỜI CÁ BÁO THÙ.mp4");
            dt.Rows.Add("2019", "2019_Những Kẻ Hết Thời", @"D:\UIT\CS511\CS511-Introduction-to-C-Sharp\exercises\exercise10\Buổi 11\Video\2019_Những Kẻ Hết Thời.mp4");
            dt.Rows.Add("2019", "2019_TÂN VUA HÀI KỊCH", @"D:\UIT\CS511\CS511-Introduction-to-C-Sharp\exercises\exercise10\Buổi 11\Video\2019_TÂN VUA HÀI KỊCH.mp4");

            return dt;
        }
        public FormMain()
        {
            InitializeComponent();
            playlist_dt = initialize_playlist_dt();

            ImageList image_list = new ImageList();
            image_list.Images.Add(Image.FromFile("../../Buổi 11/7857193_soundcloud_music_sound_audio_icon.png"));
            image_list.Images.Add(Image.FromFile("../../Buổi 11/4105577_audio_melody_music_sound_icon.png"));
            listView_playlists.View = View.LargeIcon;
            image_list.ImageSize = new Size(32, 32);
            listView_playlists.LargeImageList = image_list;
            ListViewItem item1 = new ListViewItem();
            item1.Text = "2019";
            item1.ImageIndex = 0;
            ListViewItem item2 = new ListViewItem();
            item2.Text = "2020";
            item2.ImageIndex = 1;
            ListViewItem item3 = new ListViewItem();
            item3.Text = "2021";
            item3.ImageIndex = 1;
            ListViewItem item4 = new ListViewItem();
            item4.Text = "2022";
            item4.ImageIndex = 1;

            listView_playlists.Items.Add(item1);
            listView_playlists.Items.Add(item2);
            listView_playlists.Items.Add(item3);
            listView_playlists.Items.Add(item4);

            string searchExpression = "PlaylistName='2019'";
            DataRow[] found_rows = playlist_dt.Select(searchExpression);
            for(int i = 0; i < found_rows.Length; i++)
            {
                listBox_video.Items.Add(found_rows[i]["VideoName"].ToString());
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.Show();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog choose_file = new OpenFileDialog();
            choose_file.Filter = "MP4|*.mp4|All file (*.)|*.*";
            choose_file.Multiselect = true;
            choose_file.ValidateNames = true;
            choose_file.FilterIndex = 1;
            if (choose_file.ShowDialog() == DialogResult.OK)
            {
                string sFileName = choose_file.FileName;
                axWindowsMediaPlayer1.URL = sFileName;
                axWindowsMediaPlayer1.Ctlcontrols.play();
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void listView_itemSelectionChanged_playlists(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            listView_playlists.Items[current_listView_index].ImageIndex = 1;
            listView_playlists.Items[e.ItemIndex].ImageIndex = 0;
            listBox_video.Items.Clear();
            string searchExpression = "PlaylistName='" + listView_playlists.Items[e.ItemIndex].Text + "'";
            DataRow[] found_rows = playlist_dt.Select(searchExpression);
            for(int i = 0; i < found_rows.Length; i++)
            {
                listBox_video.Items.Add(found_rows[i]["VideoName"].ToString());
            }
            current_listView_index = e.ItemIndex;
        }

        private void listBox_selectedIndexChanged_video(object sender, EventArgs e)
        {
            string current_item_name = listBox_video.SelectedItem.ToString();
            string searchExpression = "VideoName='" + current_item_name + "'";
            DataRow[] found_rows = playlist_dt.Select(searchExpression);
            axWindowsMediaPlayer1.URL = found_rows[0]["VideoPath"].ToString();
        }

        private void pictureBox_add_playlists_Click(object sender, EventArgs e)
        {
            FormAddPlaylist formAddPlaylist = new FormAddPlaylist(this);
            formAddPlaylist.Show();
        }

        private void pictureBox_add_video_Click(object sender, EventArgs e)
        {
            OpenFileDialog choose_file = new OpenFileDialog();
            choose_file.Filter = "MP4|*.mp4|All file (*.)|*.*";
            choose_file.Multiselect = true;
            choose_file.ValidateNames = true;
            choose_file.FilterIndex = 1;
            if (choose_file.ShowDialog() == DialogResult.OK)
            {
                string directoryPath = choose_file.FileName;
                string sFileName = System.IO.Path.GetFileNameWithoutExtension(directoryPath);
                listBox_video.Items.Add(sFileName);
                playlist_dt.Rows.Add(listView_playlists.Items[current_listView_index].Text, sFileName, directoryPath);
            }
        }

        private void createPlaylistToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAddPlaylist formAddPlaylist = new FormAddPlaylist(this);
            formAddPlaylist.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
