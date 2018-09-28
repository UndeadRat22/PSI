namespace Musix
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playlistsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.TracksListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(751, 40);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.playlistsToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(64, 36);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // playlistsToolStripMenuItem
            // 
            this.playlistsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.playlistsToolStripMenuItem.Name = "playlistsToolStripMenuItem";
            this.playlistsToolStripMenuItem.Size = new System.Drawing.Size(197, 38);
            this.playlistsToolStripMenuItem.Text = "Playlists";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(164, 38);
            this.newToolStripMenuItem.Text = "New";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(164, 38);
            this.saveToolStripMenuItem.Text = "Save";
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
            this.button1.Location = new System.Drawing.Point(656, 450);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 46);
            this.button1.TabIndex = 6;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // TracksListBox
            // 
            this.TracksListBox.FormattingEnabled = true;
            this.TracksListBox.ItemHeight = 25;
            this.TracksListBox.Location = new System.Drawing.Point(19, 77);
            this.TracksListBox.Name = "TracksListBox";
            this.TracksListBox.Size = new System.Drawing.Size(381, 354);
            this.TracksListBox.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Added Tracks";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(407, 77);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(82, 42);
            this.button2.TabIndex = 9;
            this.button2.Text = "Play";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(479, 77);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(94, 42);
            this.button3.TabIndex = 10;
            this.button3.Text = "Pause";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(408, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "info:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(413, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 25);
            this.label4.TabIndex = 12;
            this.label4.Text = "artist:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(484, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 25);
            this.label5.TabIndex = 13;
            this.label5.Text = "None";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(484, 182);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 25);
            this.label6.TabIndex = 15;
            this.label6.Text = "None";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(413, 182);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 25);
            this.label7.TabIndex = 14;
            this.label7.Text = "album:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(484, 208);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 25);
            this.label8.TabIndex = 17;
            this.label8.Text = "None";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(413, 208);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 25);
            this.label9.TabIndex = 16;
            this.label9.Text = "name:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(484, 234);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 25);
            this.label10.TabIndex = 19;
            this.label10.Text = "None";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(413, 234);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 25);
            this.label11.TabIndex = 18;
            this.label11.Text = "date:";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(413, 264);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(117, 46);
            this.button4.TabIndex = 20;
            this.button4.Text = "Edit info";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(418, 402);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(243, 29);
            this.checkBox1.TabIndex = 21;
            this.checkBox1.Text = "save to local storage";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(84, 534);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 31);
            this.textBox3.TabIndex = 23;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(18, 537);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(60, 25);
            this.label12.TabIndex = 24;
            this.label12.Text = "user:";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(193, 537);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(64, 25);
            this.label13.TabIndex = 26;
            this.label13.Text = "pass:";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(259, 534);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 31);
            this.textBox4.TabIndex = 25;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(376, 534);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(97, 34);
            this.button5.TabIndex = 27;
            this.button5.Text = "login";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(19, 509);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(315, 25);
            this.label14.TabIndex = 28;
            this.label14.Text = "Please login to sync with server";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(751, 580);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TracksListBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "MusiX";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem playlistsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox TracksListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label14;
    }
}

