namespace Musix
{
    partial class LoginForm
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
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this._registerButton = new System.Windows.Forms.Button();
            this._loginButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(154, 83);
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '*';
            this.textBox2.Size = new System.Drawing.Size(200, 29);
            this.textBox2.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "password:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(154, 48);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 29);
            this.textBox1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "username:";
            // 
            // _registerButton
            // 
            this._registerButton.Location = new System.Drawing.Point(154, 250);
            this._registerButton.Name = "_registerButton";
            this._registerButton.Size = new System.Drawing.Size(102, 49);
            this._registerButton.TabIndex = 8;
            this._registerButton.Text = "Create";
            this._registerButton.UseVisualStyleBackColor = true;
            this._registerButton.Click += new System.EventHandler(this.registerClick);
            // 
            // _loginButton
            // 
            this._loginButton.Location = new System.Drawing.Point(154, 131);
            this._loginButton.Name = "_loginButton";
            this._loginButton.Size = new System.Drawing.Size(102, 49);
            this._loginButton.TabIndex = 9;
            this._loginButton.Text = "Login";
            this._loginButton.UseVisualStyleBackColor = true;
            this._loginButton.Click += new System.EventHandler(this.loginClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(101, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(222, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "Don\'t have an account ?";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 313);
            this.Controls.Add(this.label3);
            this.Controls.Add(this._loginButton);
            this.Controls.Add(this._registerButton);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button _registerButton;
        private System.Windows.Forms.Button _loginButton;
        private System.Windows.Forms.Label label3;
    }
}