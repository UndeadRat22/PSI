using System;
using System.Windows.Forms;

namespace Musix
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void loginClick(object sender, EventArgs e)
        {
            var form = new MusixForm(this);
            form.Show();
            Hide();
        }

        private void registerClick(object sender, EventArgs e)
        {
            var registerForm = new RegisterForm();
            registerForm.Show();
        }
    }
}
