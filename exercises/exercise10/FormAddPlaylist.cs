using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exercise10
{
    public partial class FormAddPlaylist : Form
    {
        public FormAddPlaylist()
        {
            InitializeComponent();
        }

        private FormMain formMain = null;
        public FormAddPlaylist(Form callingForm)
        {
            InitializeComponent();
            this.formMain = callingForm as FormMain;
        }

        private void pictureBox_click_savePlaylist(object sender, EventArgs e)
        {
            ListView playlist_listView = formMain.PlaylistsListView;
            if (textBox_playlistName.Text == "")
            {
                MessageBox.Show("Playlist's name cannot be empty!");
            }
            else
            {
                ListViewItem item = new ListViewItem();
                item.ImageIndex = 1;
                item.Text = textBox_playlistName.Text;
                playlist_listView.Items.Add(item);
                this.Close();
            }
        }
    }
}
