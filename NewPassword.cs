using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace password_manager
{
    public partial class NewPassword : Form
    {
        public event EventHandler NewPasswordCreated;
        private bool isPasswordVisible = false;
        public NewPassword()
        {
            InitializeComponent();

            // prevent resizing of form
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        protected virtual void OnNewPasswordCreated()
        {
            NewPasswordCreated?.Invoke(this, EventArgs.Empty);
        }

        private void createPassword_Click(object sender, EventArgs e)
        {
            string name = newPasswordName.Text;
            string pass = newPasswordPass.Text;
            string platform = newPasswordPlatform.Text;

            if(string.IsNullOrEmpty(name) || string.IsNullOrEmpty(pass) || string.IsNullOrEmpty(platform))
            {
                MessageBox.Show("Please fill in all fields", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                return;
            }

            Password newPassword = new Password(pass, name, platform);

            // add new password to password list
            PasswordRepository.AddPassword(newPassword);

            
            // update grid list on main form
            OnNewPasswordCreated();

            // close new password form
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void togglePasswordVisible(object sender, EventArgs e)
        {
            newPasswordPass.UseSystemPasswordChar = isPasswordVisible;
            isPasswordVisible = !isPasswordVisible;
        }

        private void handleCreatePassword(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                createPassword_Click(sender, e);
            }
        }
    }
}
