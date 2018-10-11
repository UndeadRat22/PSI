using System;
using System.Windows.Forms;

namespace Musix
{
    public partial class AddPlaylistForm : Form
    {
        private MusixForm _mainForm;

        public AddPlaylistForm(MusixForm mainform)
        {
            _mainForm = mainform;
            InitializeComponent();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void _addButton_Click(object sender, EventArgs e)
        {
            var str = textBox1.Text;
            _mainForm.AddPlaylist(str);
            this.Close();
        }
    }
}
