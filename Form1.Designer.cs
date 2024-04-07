namespace password_manager
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.loadAccount = new System.Windows.Forms.Button();
            this.saveAccount = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.passwordGridList = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.addPassword = new System.Windows.Forms.Button();
            this.removePassword = new System.Windows.Forms.Button();
            this.togglePassword = new System.Windows.Forms.Button();
            this.Account = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Platform = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.passwordGridList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Desktop;
            this.label1.Font = new System.Drawing.Font("Swis721 Blk BT", 24F);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(22, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "PASSWORD";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Desktop;
            this.label2.Font = new System.Drawing.Font("Swis721 BlkEx BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(111, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "MANAGER";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Desktop;
            this.label3.Font = new System.Drawing.Font("Symath", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(284, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(382, 50);
            this.label3.TabIndex = 3;
            this.label3.Text = "------------------------";
            // 
            // loadAccount
            // 
            this.loadAccount.Font = new System.Drawing.Font("Swis721 Blk BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadAccount.Location = new System.Drawing.Point(29, 280);
            this.loadAccount.Name = "loadAccount";
            this.loadAccount.Size = new System.Drawing.Size(203, 60);
            this.loadAccount.TabIndex = 4;
            this.loadAccount.Text = "LOAD ACCOUNT";
            this.loadAccount.UseVisualStyleBackColor = true;
            this.loadAccount.Click += new System.EventHandler(this.loadAccount_Click);
            // 
            // saveAccount
            // 
            this.saveAccount.Font = new System.Drawing.Font("Swis721 Blk BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveAccount.Location = new System.Drawing.Point(29, 346);
            this.saveAccount.Name = "saveAccount";
            this.saveAccount.Size = new System.Drawing.Size(203, 60);
            this.saveAccount.TabIndex = 5;
            this.saveAccount.Text = "SAVE ACCOUNT";
            this.saveAccount.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.passwordGridList);
            this.groupBox1.Location = new System.Drawing.Point(238, 132);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(550, 274);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // passwordGridList
            // 
            this.passwordGridList.AllowUserToAddRows = false;
            this.passwordGridList.AllowUserToDeleteRows = false;
            this.passwordGridList.AllowUserToOrderColumns = true;
            this.passwordGridList.AllowUserToResizeRows = false;
            this.passwordGridList.BackgroundColor = System.Drawing.Color.Black;
            this.passwordGridList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.passwordGridList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Account,
            this.Password,
            this.Platform});
            this.passwordGridList.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.passwordGridList.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.passwordGridList.Location = new System.Drawing.Point(6, 13);
            this.passwordGridList.Name = "passwordGridList";
            this.passwordGridList.ReadOnly = true;
            this.passwordGridList.Size = new System.Drawing.Size(538, 255);
            this.passwordGridList.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.Font = new System.Drawing.Font("Swis721 BT", 9.5F);
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(18, 413);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(781, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "all password will be saved on local folder | after insert new password, SAVE ACCO" +
    "UNT | account = .txt file with all saved passwords";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // addPassword
            // 
            this.addPassword.Font = new System.Drawing.Font("Swis721 Blk BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPassword.Location = new System.Drawing.Point(29, 132);
            this.addPassword.Name = "addPassword";
            this.addPassword.Size = new System.Drawing.Size(203, 60);
            this.addPassword.TabIndex = 8;
            this.addPassword.Text = "ADD";
            this.addPassword.UseVisualStyleBackColor = true;
            this.addPassword.Click += new System.EventHandler(this.addPassword_Click);
            // 
            // removePassword
            // 
            this.removePassword.Font = new System.Drawing.Font("Swis721 Blk BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removePassword.Location = new System.Drawing.Point(29, 198);
            this.removePassword.Name = "removePassword";
            this.removePassword.Size = new System.Drawing.Size(203, 60);
            this.removePassword.TabIndex = 9;
            this.removePassword.Text = "REMOVE";
            this.removePassword.UseVisualStyleBackColor = true;
            this.removePassword.Click += new System.EventHandler(this.removePassword_Click);
            // 
            // togglePassword
            // 
            this.togglePassword.Font = new System.Drawing.Font("Swis721 Blk BT", 10F);
            this.togglePassword.Location = new System.Drawing.Point(492, 96);
            this.togglePassword.Name = "togglePassword";
            this.togglePassword.Size = new System.Drawing.Size(174, 30);
            this.togglePassword.TabIndex = 10;
            this.togglePassword.Text = "TOGGLE SELECTED";
            this.togglePassword.UseVisualStyleBackColor = true;
            this.togglePassword.Click += new System.EventHandler(this.toggleSelectedPassword_Click);
            // 
            // Account
            // 
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            this.Account.DefaultCellStyle = dataGridViewCellStyle12;
            this.Account.HeaderText = "Account";
            this.Account.Name = "Account";
            this.Account.ReadOnly = true;
            this.Account.ToolTipText = "Login nickname or email";
            this.Account.Width = 165;
            // 
            // Password
            // 
            this.Password.HeaderText = "Password";
            this.Password.Name = "Password";
            this.Password.ReadOnly = true;
            this.Password.ToolTipText = "Account Password";
            this.Password.Width = 165;
            // 
            // Platform
            // 
            this.Platform.HeaderText = "Platform";
            this.Platform.Name = "Platform";
            this.Platform.ReadOnly = true;
            this.Platform.ToolTipText = "Website";
            this.Platform.Width = 165;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::password_manager.Properties.Resources.selected_password_manager_logo;
            this.pictureBox1.Location = new System.Drawing.Point(711, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(77, 67);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Desktop;
            this.label6.Font = new System.Drawing.Font("Swis721 Blk BT", 24F);
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(334, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(277, 39);
            this.label6.TabIndex = 12;
            this.label6.Text = "TESTACCOUNT";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Swis721 Blk BT", 10F);
            this.button1.Location = new System.Drawing.Point(682, 96);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 30);
            this.button1.TabIndex = 13;
            this.button1.Text = "TOGGLE ALL";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.toggleAllPasswords);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InfoText;
            this.ClientSize = new System.Drawing.Size(821, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.togglePassword);
            this.Controls.Add(this.removePassword);
            this.Controls.Add(this.addPassword);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.saveAccount);
            this.Controls.Add(this.loadAccount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Password Manager";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.passwordGridList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button loadAccount;
        private System.Windows.Forms.Button saveAccount;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView passwordGridList;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button addPassword;
        private System.Windows.Forms.Button removePassword;
        private System.Windows.Forms.Button togglePassword;
        private System.Windows.Forms.DataGridViewTextBoxColumn Account;
        private System.Windows.Forms.DataGridViewTextBoxColumn Password;
        private System.Windows.Forms.DataGridViewTextBoxColumn Platform;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
    }
}

