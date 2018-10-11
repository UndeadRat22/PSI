using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Musix
{
    public partial class MusixForm : Form
    {
        private Form _mainForm;
        private List<List<string>> defaultPlaylist;
        private Dictionary<string, List<string>> _playlists = new Dictionary<string, List<string>>();

        public MusixForm(Form mainForm)
        {
            _mainForm = mainForm;
            InitializeComponent();
            LoadPlaylistsFromFile(null);
            UpdatePlaylists();
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            _mainForm.Close();
        }

        #region bullshit
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }
        #endregion

        private void LoadPlaylistsFromFile(string fn)
        {
            var defaultTracks = new List<string>();
            for (int i = 0; i < 10; i++)
                defaultTracks.Add("Dummy Track nr." + i.ToString());
            _playlists["(default)"] = defaultTracks;

        }

        public List<string> AddPlaylist(string name)
        {
            var tracksList = new List<string>();
            try
            {
                _playlists.Add(name, tracksList);
            }
            catch
            {
                return null;
            }
            UpdatePlaylists();
            return tracksList;
        }
        //Pair url -> [playlistname1...]
        public void AddTrackToPlaylist(string playlistName, string trackUrl)
        {
            try
            {
                _playlists[playlistName].Add(trackUrl);
            }
            catch
            {

            }
        }

        private void PlaylistsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string playListName = null;
            try
            {
                playListName = PlaylistsListBox.SelectedItem.ToString();
            }
            catch { }
            if (playListName != null)
                UpdateTracks(playListName);
        }

        private void UpdatePlaylists()
        {
            PlaylistsListBox.Items.Clear();
            foreach (var pair in _playlists)
            {
                PlaylistsListBox.Items.Add(pair.Key);
            }
        }

        private void UpdateTracks(string playlistName)
        {
            if (playlistName == "(default)")
            {
                TracksListBox.Items.Clear();
                foreach (var pair in _playlists)
                {
                    TracksListBox.Items.AddRange(pair.Value.ToArray());
                }
                return;
            }
            var tracks = _playlists[playlistName].ToArray();
            TracksListBox.Items.Clear();
            TracksListBox.Items.AddRange(tracks);
        }

        private void newPlaylistButtonClick(object sender, EventArgs e)
        {
            var form = new AddPlaylistForm(this);
            form.Show();
        }

        private void removePlaylistButtonClick(object sender, EventArgs e)
        {
            string name = PlaylistsListBox.SelectedItem.ToString();
            if (name == "(default)")
                return;
            _playlists.Remove(name);
            UpdatePlaylists();
        }
    }
}
