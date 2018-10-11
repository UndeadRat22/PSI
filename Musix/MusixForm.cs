using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Musix
{
    public partial class MusixForm : Form
    {
        private Form _mainForm;
        private Dictionary<string, List<Track>> _playlists = new Dictionary<string, List<Track>>();

        private Track _selectedMenuItem;
        private ContextMenuStrip _contextMenuStrip;

        public MusixForm(Form mainForm)
        {
            _mainForm = mainForm;
            InitializeComponent();
            LoadPlaylistsFromFile(null);
            UpdatePlaylists();
            var delete = new ToolStripMenuItem {Text = "delete"};
            var edit = new ToolStripMenuItem { Text = "edit" };
            delete.Click += Delete_Click;
            edit.Click += Edit_Click;
            _contextMenuStrip = new ContextMenuStrip();
            _contextMenuStrip.Items.Add(edit);
            _contextMenuStrip.Items.Add(delete);
            TracksListBox.MouseDown += TracksListBox_MouseDown;
            TracksListBox.SelectedIndexChanged += TracksListBox_SelectedIndexChanged;
        }

        private void TracksListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selected = TracksListBox.SelectedItem as Track;
            _albumLabel.Text = selected.Album == null ? "None" : selected.Album;
            _nameLabel.Text = selected.Name == null ? "None" : selected.Name;
            _dateLabel.Text = selected.Date == null ? "None" : selected.Date;
            _artistLabel.Text = selected.Artist == null ? "None" : selected.Artist;
        }

        private void TracksListBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Right) return;
            var index = TracksListBox.IndexFromPoint(e.Location);
            if (index != ListBox.NoMatches)
            {
                _selectedMenuItem = TracksListBox.Items[index] as Track;
                _contextMenuStrip.Show(Cursor.Position);
                _contextMenuStrip.Visible = true;
            }
            else
                _contextMenuStrip.Visible = false;
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            var form = new EditTrackForm(this, _selectedMenuItem);
            form.Show();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            var name = PlaylistsListBox.SelectedItem.ToString();
            var track = TracksListBox.SelectedItem as Track;
            RemoveTrackFromPlaylist(name, track);
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

        public void RemoveTrackFromPlaylist(string playlist, Track t)
        {
            try
            {
                var l = _playlists[playlist];
                l.Remove(t);
            }
            catch
            {

            }
            UpdateTracks(playlist);
        }

        private void LoadPlaylistsFromFile(string fn)
        {
            var defaultTracks = new List<Track>();
            for (int i = 0; i < 10; i++)
            {
                defaultTracks.Add(new Track("url" + i) { Name = "name" + i, Artist = "artist" + i});
            }
            _playlists["(default)"] = defaultTracks;
        }

        public List<Track> AddPlaylist(string name)
        {
            var tracksList = new List<Track>();
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
                _playlists[playlistName].Add(new Track(trackUrl));
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

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                _nowPlayingLabel.Text = TracksListBox.SelectedItem.ToString();
            }
            catch
            {
                
            }
        }

        private void _addTrackButton_Click(object sender, EventArgs e)
        {
            var selected = PlaylistsListBox.SelectedItem.ToString();
            var list = _playlists[selected];
            list.Add(new Track(_urlTextBox.Text));
            //UpdatePlaylists();
            UpdateTracks(selected);
        }
    }
}
