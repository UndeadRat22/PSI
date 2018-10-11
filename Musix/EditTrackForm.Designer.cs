namespace Musix
{
    partial class EditTrackForm
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
            this.label1 = new System.Windows.Forms.Label();
            this._nameTextBox = new System.Windows.Forms.TextBox();
            this._artistTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this._dateTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this._albumTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this._urlTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this._saveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // _nameTextBox
            // 
            this._nameTextBox.Location = new System.Drawing.Point(178, 40);
            this._nameTextBox.Name = "_nameTextBox";
            this._nameTextBox.Size = new System.Drawing.Size(249, 31);
            this._nameTextBox.TabIndex = 1;
            this._nameTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // _artistTextBox
            // 
            this._artistTextBox.Location = new System.Drawing.Point(178, 89);
            this._artistTextBox.Name = "_artistTextBox";
            this._artistTextBox.Size = new System.Drawing.Size(249, 31);
            this._artistTextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Artist";
            // 
            // _dateTextBox
            // 
            this._dateTextBox.Location = new System.Drawing.Point(178, 136);
            this._dateTextBox.Name = "_dateTextBox";
            this._dateTextBox.Size = new System.Drawing.Size(249, 31);
            this._dateTextBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(88, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Date";
            // 
            // _albumTextBox
            // 
            this._albumTextBox.Location = new System.Drawing.Point(178, 186);
            this._albumTextBox.Name = "_albumTextBox";
            this._albumTextBox.Size = new System.Drawing.Size(249, 31);
            this._albumTextBox.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(88, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Album";
            // 
            // _urlTextBox
            // 
            this._urlTextBox.Location = new System.Drawing.Point(178, 236);
            this._urlTextBox.Name = "_urlTextBox";
            this._urlTextBox.Size = new System.Drawing.Size(249, 31);
            this._urlTextBox.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(88, 239);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "Url";
            // 
            // _saveButton
            // 
            this._saveButton.Location = new System.Drawing.Point(330, 284);
            this._saveButton.Name = "_saveButton";
            this._saveButton.Size = new System.Drawing.Size(97, 47);
            this._saveButton.TabIndex = 10;
            this._saveButton.Text = "Save";
            this._saveButton.UseVisualStyleBackColor = true;
            this._saveButton.Click += new System.EventHandler(this._saveButton_Click);
            // 
            // EditTrackForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 364);
            this.Controls.Add(this._saveButton);
            this.Controls.Add(this._urlTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this._albumTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this._dateTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this._artistTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this._nameTextBox);
            this.Controls.Add(this.label1);
            this.Name = "EditTrackForm";
            this.Text = "EditTrackForm";
            this.Load += new System.EventHandler(this.EditTrackForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox _nameTextBox;
        private System.Windows.Forms.TextBox _artistTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox _dateTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox _albumTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox _urlTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button _saveButton;
    }
}