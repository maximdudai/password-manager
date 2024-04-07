using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace password_manager
{
    public partial class Form1 : Form
    {
        private List<Password> passwordList;

        // array to store the visibility of each password
        bool[] isPasswordVisible = { };

        bool isAllPasswordsVisible = false;

        public Form1()
        {
            InitializeComponent();

            // prevent resizing of form
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

        }
        // load passwords on form load
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadPasswords();
        }

        private void LoadPasswords()
        {
            passwordList = PasswordRepository.GetAllPasswords();

            isPasswordVisible = new bool[passwordList.Count];

            passwordGridList.Rows?.Clear();

            foreach(Password password in passwordList)
            {
                string hashedPassword = hashPassword(password.getPassword());
                passwordGridList.Rows.Add(password.getUsername(), hashedPassword, password.getPlatform());
            }
        }

        private void addPassword_Click(object sender, EventArgs e)
        {
            using (NewPassword newPassword = new NewPassword())
            {
                // Subscribe to the event before showing the dialog.
                newPassword.NewPasswordCreated += OnNewPasswordCreated;

                if (newPassword.ShowDialog() == DialogResult.OK)
                {
                    // The event handler OnNewPasswordCreated will be called if a new password is created successfully.
                    // No need to call LoadPasswords() here as it's already called within OnNewPasswordCreated.
                }

                // Unsubscribe from the event to avoid memory leaks.
                newPassword.NewPasswordCreated -= OnNewPasswordCreated;
            }
        }

        private void removePassword_Click(object sender, EventArgs e)
        {
            if(this.passwordGridList.CurrentCell == null)
                return;

            int selectedRow = this.passwordGridList.CurrentCell.RowIndex;

            PasswordRepository.RemovePassword(passwordList[selectedRow]);

            passwordGridList.Rows.RemoveAt(selectedRow);
        }

        private void OnNewPasswordCreated(object sender, EventArgs e)
        {
            LoadPasswords();
        }

        private string hashPassword(string password)
        {
            int passwordLength = password.Length;
            string hashedPassword = "";

            for (int i = 0; i < passwordLength; i++)
            {
                hashedPassword += "*";
            }
            return hashedPassword;
        }

        private void toggleSelectedPassword_Click(object sender, EventArgs e)
        {
            if(this.passwordGridList.CurrentCell == null)
                return;

            int selectedRow = this.passwordGridList.CurrentCell.RowIndex;

            if(selectedRow == -1)
                return;

            // toggle password visibility
            string toggleVisible = isPasswordVisible[selectedRow] ? hashPassword(passwordList[selectedRow].getPassword()) : passwordList[selectedRow].getPassword();
            passwordGridList[1, selectedRow].Value = toggleVisible;

            // update visibility array
            isPasswordVisible[selectedRow] = !isPasswordVisible[selectedRow];
        }

        private void toggleAllPasswords(object sender, EventArgs e)
        {
            int rowCount = passwordGridList.Rows.Count;

            if(rowCount <= 0)
                 return;

            for(int i = 0; i < rowCount; ++i)
            {
                string passwordType = isAllPasswordsVisible ? hashPassword(passwordList[i].getPassword()) : passwordList[i].getPassword();

                passwordGridList[1, i].Value = passwordType;
            }
            

            isAllPasswordsVisible = !isAllPasswordsVisible;
        }

        private void loadAccount_Click(object sender, EventArgs e)
        {
            openAccountDialog.ShowDialog();

            string filePath = openAccountDialog.FileName;

            if(filePath == null) return;
            if(filePath == "") return;

            string fileName = System.IO.Path.GetFileName(filePath);

            loadedAccount.Text = fileName;

            string[] lines = System.IO.File.ReadAllLines(filePath);

            foreach(string line in lines)
            {
                string[] account = line.Split(',');

                Password newAccount = new Password(account[1], account[0], account[2]);

                PasswordRepository.AddPassword(newAccount);
            }

            LoadPasswords();
        }

        private void saveAccount_Click(object sender, EventArgs e)
        {

            var ifFolderExist = Directory.Exists("accounts");
                
            if(!ifFolderExist)
            {
                System.IO.Directory.CreateDirectory("accounts");
            }

            //create new file inside accounts path
            string filePath = "accounts/" + DateTime.Now.ToString("yyyy-MM-dd") + ".txt";
            if(File.Exists(filePath))
            {
                File.Delete(filePath);
            }

            using (StreamWriter sw = File.CreateText(filePath))
            {
                foreach(Password password in passwordList)
                {
                    sw.WriteLine(password.getUsername() + "," + password.getPassword() + "," + password.getPlatform());
                }
            }

            MessageBox.Show("Account saved successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
        }
    }
}
