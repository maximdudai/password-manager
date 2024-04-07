namespace password_manager
{
    partial class NewPassword
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
            this.createPassword = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.newPasswordName = new System.Windows.Forms.TextBox();
            this.newPasswordPass = new System.Windows.Forms.TextBox();
            this.newPasswordPlatform = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // createPassword
            // 
            this.createPassword.Font = new System.Drawing.Font("Swis721 Blk BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createPassword.Location = new System.Drawing.Point(53, 248);
            this.createPassword.Name = "createPassword";
            this.createPassword.Size = new System.Drawing.Size(203, 60);
            this.createPassword.TabIndex = 5;
            this.createPassword.Text = "CREATE";
            this.createPassword.UseVisualStyleBackColor = true;
            this.createPassword.Click += new System.EventHandler(this.createPassword_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Swis721 Blk BT", 14.25F);
            this.label1.Location = new System.Drawing.Point(49, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 22);
            this.label1.TabIndex = 6;
            this.label1.Text = "Account";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Swis721 Blk BT", 14.25F);
            this.label2.Location = new System.Drawing.Point(49, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 22);
            this.label2.TabIndex = 7;
            this.label2.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Swis721 Blk BT", 14.25F);
            this.label3.Location = new System.Drawing.Point(49, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 22);
            this.label3.TabIndex = 8;
            this.label3.Text = "Platform";
            // 
            // newPasswordName
            // 
            this.newPasswordName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.newPasswordName.Location = new System.Drawing.Point(53, 56);
            this.newPasswordName.Name = "newPasswordName";
            this.newPasswordName.Size = new System.Drawing.Size(203, 20);
            this.newPasswordName.TabIndex = 9;
            // 
            // newPasswordPass
            // 
            this.newPasswordPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.newPasswordPass.Location = new System.Drawing.Point(53, 122);
            this.newPasswordPass.Name = "newPasswordPass";
            this.newPasswordPass.Size = new System.Drawing.Size(177, 20);
            this.newPasswordPass.TabIndex = 10;
            this.newPasswordPass.UseSystemPasswordChar = true;
            // 
            // newPasswordPlatform
            // 
            this.newPasswordPlatform.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.newPasswordPlatform.Location = new System.Drawing.Point(53, 192);
            this.newPasswordPlatform.Name = "newPasswordPlatform";
            this.newPasswordPlatform.Size = new System.Drawing.Size(203, 20);
            this.newPasswordPlatform.TabIndex = 11;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::password_manager.Properties.Resources._633655;
            this.pictureBox1.Location = new System.Drawing.Point(231, 122);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(26, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.togglePasswordVisible);
            // 
            // NewPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 338);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.newPasswordPlatform);
            this.Controls.Add(this.newPasswordPass);
            this.Controls.Add(this.newPasswordName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.createPassword);
            this.Name = "NewPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NewPassword";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.handleCreatePassword);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button createPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox newPasswordName;
        private System.Windows.Forms.TextBox newPasswordPass;
        private System.Windows.Forms.TextBox newPasswordPlatform;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}