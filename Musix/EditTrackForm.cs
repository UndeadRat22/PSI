using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Musix
{
    public partial class EditTrackForm : Form
    {
        private Form _mainForm;
        private Track _trackToEdit;
        public EditTrackForm(Form mainForm, Track toEdit)
        {
            _mainForm = mainForm;
            _trackToEdit = toEdit;
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void EditTrackForm_Load(object sender, EventArgs e)
        {
            _nameTextBox.Text = _trackToEdit.Name;
            _albumTextBox.Text = _trackToEdit.Album;
            _dateTextBox.Text = _trackToEdit.Date;
            _dateTextBox.Text = _trackToEdit.Artist;
            _urlTextBox.Text = _trackToEdit.Url;
        }

        private void _saveButton_Click(object sender, EventArgs e)
        {
            _trackToEdit.Name = _nameTextBox.Text;
            _trackToEdit.Album = _albumTextBox.Text;
            _trackToEdit.Date = _dateTextBox.Text;
            _trackToEdit.Artist = _dateTextBox.Text;
            _trackToEdit.Url = _urlTextBox.Text;
            Close();
        }
    }
}
