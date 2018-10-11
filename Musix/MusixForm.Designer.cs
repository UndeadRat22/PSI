namespace Musix
{
    partial class MusixForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.PlaylistsListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this._artistLabel = new System.Windows.Forms.Label();
            this._albumLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this._nameLabel = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this._dateLabel = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.TracksListBox = new System.Windows.Forms.ListBox();
            this.label15 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 460);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Track URL";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(131, 460);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(480, 31);
            this.textBox1.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(649, 449);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 46);
            this.button1.TabIndex = 6;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // PlaylistsListBox
            // 
            this.PlaylistsListBox.FormattingEnabled = true;
            this.PlaylistsListBox.ItemHeight = 25;
            this.PlaylistsListBox.Location = new System.Drawing.Point(19, 77);
            this.PlaylistsListBox.Name = "PlaylistsListBox";
            this.PlaylistsListBox.Size = new System.Drawing.Size(271, 304);
            this.PlaylistsListBox.TabIndex = 7;
            this.PlaylistsListBox.SelectedIndexChanged += new System.EventHandler(this.PlaylistsListBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Playlists";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(643, 77);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(82, 42);
            this.button2.TabIndex = 9;
            this.button2.Text = "Play";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(715, 77);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(94, 42);
            this.button3.TabIndex = 10;
            this.button3.Text = "Pause";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(644, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "selected track info:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(649, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 25);
            this.label4.TabIndex = 12;
            this.label4.Text = "artist:";
            // 
            // _artistLabel
            // 
            this._artistLabel.AutoSize = true;
            this._artistLabel.Location = new System.Drawing.Point(720, 156);
            this._artistLabel.Name = "_artistLabel";
            this._artistLabel.Size = new System.Drawing.Size(63, 25);
            this._artistLabel.TabIndex = 13;
            this._artistLabel.Text = "None";
            // 
            // _albumLabel
            // 
            this._albumLabel.AutoSize = true;
            this._albumLabel.Location = new System.Drawing.Point(720, 182);
            this._albumLabel.Name = "_albumLabel";
            this._albumLabel.Size = new System.Drawing.Size(63, 25);
            this._albumLabel.TabIndex = 15;
            this._albumLabel.Text = "None";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(649, 182);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 25);
            this.label7.TabIndex = 14;
            this.label7.Text = "album:";
            // 
            // _nameLabel
            // 
            this._nameLabel.AutoSize = true;
            this._nameLabel.Location = new System.Drawing.Point(720, 208);
            this._nameLabel.Name = "_nameLabel";
            this._nameLabel.Size = new System.Drawing.Size(63, 25);
            this._nameLabel.TabIndex = 17;
            this._nameLabel.Text = "None";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(649, 208);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 25);
            this.label9.TabIndex = 16;
            this.label9.Text = "name:";
            // 
            // _dateLabel
            // 
            this._dateLabel.AutoSize = true;
            this._dateLabel.Location = new System.Drawing.Point(720, 234);
            this._dateLabel.Name = "_dateLabel";
            this._dateLabel.Size = new System.Drawing.Size(63, 25);
            this._dateLabel.TabIndex = 19;
            this._dateLabel.Text = "None";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(649, 234);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 25);
            this.label11.TabIndex = 18;
            this.label11.Text = "date:";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(758, 462);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(243, 29);
            this.checkBox1.TabIndex = 21;
            this.checkBox1.Text = "save to local storage";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // TracksListBox
            // 
            this.TracksListBox.FormattingEnabled = true;
            this.TracksListBox.ItemHeight = 25;
            this.TracksListBox.Location = new System.Drawing.Point(323, 77);
            this.TracksListBox.Name = "TracksListBox";
            this.TracksListBox.Size = new System.Drawing.Size(288, 354);
            this.TracksListBox.TabIndex = 29;
            this.TracksListBox.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(319, 40);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(77, 25);
            this.label15.TabIndex = 30;
            this.label15.Text = "Tracks";
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(19, 387);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(117, 46);
            this.button7.TabIndex = 32;
            this.button7.Text = "New ";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.newPlaylistButtonClick);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(173, 387);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(117, 46);
            this.button8.TabIndex = 33;
            this.button8.Text = "Remove";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.removePlaylistButtonClick);
            // 
            // MusixForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1013, 580);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.TracksListBox);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this._dateLabel);
            this.Controls.Add(this.label11);
            this.Controls.Add(this._nameLabel);
            this.Controls.Add(this.label9);
            this.Controls.Add(this._albumLabel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this._artistLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PlaylistsListBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Name = "MusixForm";
            this.Text = "MusiX";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox PlaylistsListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label _artistLabel;
        private System.Windows.Forms.Label _albumLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label _nameLabel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label _dateLabel;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ListBox TracksListBox;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
    }
}

