namespace GUI
{
    partial class fAddUserGUI
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
            this.tbDisplayName = new System.Windows.Forms.TextBox();
            this.lbDisplayName = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblErrorConfirmPassword = new System.Windows.Forms.Label();
            this.lblErrorPassword = new System.Windows.Forms.Label();
            this.lblErrorUserName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblErrorDisplayName = new System.Windows.Forms.Label();
            this.tbConfirm_Passoword = new System.Windows.Forms.TextBox();
            this.cbbIdUserRole = new System.Windows.Forms.ComboBox();
            this.lbIdUserRole = new System.Windows.Forms.Label();
            this.lbConfirm_Password = new System.Windows.Forms.Label();
            this.lbPassword = new System.Windows.Forms.Label();
            this.lbUserName = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbUserName = new System.Windows.Forms.TextBox();
            this.btAdd = new System.Windows.Forms.Button();
            this.btReset = new System.Windows.Forms.Button();
            this.btThoat = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbDisplayName
            // 
            this.tbDisplayName.Location = new System.Drawing.Point(156, 29);
            this.tbDisplayName.Name = "tbDisplayName";
            this.tbDisplayName.Size = new System.Drawing.Size(369, 26);
            this.tbDisplayName.TabIndex = 0;
            this.tbDisplayName.Validating += new System.ComponentModel.CancelEventHandler(this.tbDisplayName_Validating);
            // 
            // lbDisplayName
            // 
            this.lbDisplayName.AutoSize = true;
            this.lbDisplayName.Location = new System.Drawing.Point(22, 32);
            this.lbDisplayName.Name = "lbDisplayName";
            this.lbDisplayName.Size = new System.Drawing.Size(102, 20);
            this.lbDisplayName.TabIndex = 1;
            this.lbDisplayName.Text = "DisplayName";
            this.lbDisplayName.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblErrorConfirmPassword);
            this.panel1.Controls.Add(this.lblErrorPassword);
            this.panel1.Controls.Add(this.lblErrorUserName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblErrorDisplayName);
            this.panel1.Controls.Add(this.tbConfirm_Passoword);
            this.panel1.Controls.Add(this.cbbIdUserRole);
            this.panel1.Controls.Add(this.lbIdUserRole);
            this.panel1.Controls.Add(this.lbConfirm_Password);
            this.panel1.Controls.Add(this.lbPassword);
            this.panel1.Controls.Add(this.lbUserName);
            this.panel1.Controls.Add(this.tbPassword);
            this.panel1.Controls.Add(this.tbUserName);
            this.panel1.Controls.Add(this.lbDisplayName);
            this.panel1.Controls.Add(this.tbDisplayName);
            this.panel1.Location = new System.Drawing.Point(171, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(592, 314);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lblErrorConfirmPassword
            // 
            this.lblErrorConfirmPassword.AutoSize = true;
            this.lblErrorConfirmPassword.BackColor = System.Drawing.SystemColors.Control;
            this.lblErrorConfirmPassword.ForeColor = System.Drawing.Color.Red;
            this.lblErrorConfirmPassword.Location = new System.Drawing.Point(165, 239);
            this.lblErrorConfirmPassword.Name = "lblErrorConfirmPassword";
            this.lblErrorConfirmPassword.Size = new System.Drawing.Size(0, 20);
            this.lblErrorConfirmPassword.TabIndex = 15;
            this.lblErrorConfirmPassword.Visible = false;
            // 
            // lblErrorPassword
            // 
            this.lblErrorPassword.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblErrorPassword.Location = new System.Drawing.Point(142, 175);
            this.lblErrorPassword.Name = "lblErrorPassword";
            this.lblErrorPassword.Size = new System.Drawing.Size(359, 22);
            this.lblErrorPassword.TabIndex = 14;
            this.lblErrorPassword.Visible = false;
            this.lblErrorPassword.Click += new System.EventHandler(this.lblErrorPassword_Click);
            // 
            // lblErrorUserName
            // 
            this.lblErrorUserName.AutoSize = true;
            this.lblErrorUserName.BackColor = System.Drawing.SystemColors.Control;
            this.lblErrorUserName.Location = new System.Drawing.Point(165, 116);
            this.lblErrorUserName.Name = "lblErrorUserName";
            this.lblErrorUserName.Size = new System.Drawing.Size(0, 20);
            this.lblErrorUserName.TabIndex = 13;
            this.lblErrorUserName.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(296, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 12;
            this.label1.Visible = false;
            // 
            // lblErrorDisplayName
            // 
            this.lblErrorDisplayName.AutoSize = true;
            this.lblErrorDisplayName.BackColor = System.Drawing.SystemColors.Control;
            this.lblErrorDisplayName.Location = new System.Drawing.Point(152, 58);
            this.lblErrorDisplayName.Name = "lblErrorDisplayName";
            this.lblErrorDisplayName.Size = new System.Drawing.Size(0, 20);
            this.lblErrorDisplayName.TabIndex = 11;
            this.lblErrorDisplayName.Visible = false;
            // 
            // tbConfirm_Passoword
            // 
            this.tbConfirm_Passoword.Location = new System.Drawing.Point(156, 200);
            this.tbConfirm_Passoword.Name = "tbConfirm_Passoword";
            this.tbConfirm_Passoword.PasswordChar = '*';
            this.tbConfirm_Passoword.Size = new System.Drawing.Size(369, 26);
            this.tbConfirm_Passoword.TabIndex = 10;
            this.tbConfirm_Passoword.Validating += new System.ComponentModel.CancelEventHandler(this.tbConfirm_Passoword_Validating);
            // 
            // cbbIdUserRole
            // 
            this.cbbIdUserRole.FormattingEnabled = true;
            this.cbbIdUserRole.Items.AddRange(new object[] {
            "Admin",
            "Staff",
            "User"});
            this.cbbIdUserRole.Location = new System.Drawing.Point(179, 263);
            this.cbbIdUserRole.Name = "cbbIdUserRole";
            this.cbbIdUserRole.Size = new System.Drawing.Size(121, 28);
            this.cbbIdUserRole.TabIndex = 9;
            // 
            // lbIdUserRole
            // 
            this.lbIdUserRole.AutoSize = true;
            this.lbIdUserRole.Location = new System.Drawing.Point(22, 266);
            this.lbIdUserRole.Name = "lbIdUserRole";
            this.lbIdUserRole.Size = new System.Drawing.Size(90, 20);
            this.lbIdUserRole.TabIndex = 8;
            this.lbIdUserRole.Text = "IdUserRole";
            // 
            // lbConfirm_Password
            // 
            this.lbConfirm_Password.AutoSize = true;
            this.lbConfirm_Password.Location = new System.Drawing.Point(13, 200);
            this.lbConfirm_Password.Name = "lbConfirm_Password";
            this.lbConfirm_Password.Size = new System.Drawing.Size(137, 20);
            this.lbConfirm_Password.TabIndex = 7;
            this.lbConfirm_Password.Text = "Confirm Password";
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Location = new System.Drawing.Point(34, 146);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(78, 20);
            this.lbPassword.TabIndex = 6;
            this.lbPassword.Text = "Password";
            // 
            // lbUserName
            // 
            this.lbUserName.AutoSize = true;
            this.lbUserName.Location = new System.Drawing.Point(22, 87);
            this.lbUserName.Name = "lbUserName";
            this.lbUserName.Size = new System.Drawing.Size(85, 20);
            this.lbUserName.TabIndex = 5;
            this.lbUserName.Text = "UserName";
            this.lbUserName.Click += new System.EventHandler(this.lbUserName_Click);
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(156, 146);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(369, 26);
            this.tbPassword.TabIndex = 3;
            this.tbPassword.Validating += new System.ComponentModel.CancelEventHandler(this.tbPassword_Validating);
            // 
            // tbUserName
            // 
            this.tbUserName.Location = new System.Drawing.Point(156, 87);
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.Size = new System.Drawing.Size(369, 26);
            this.tbUserName.TabIndex = 2;
            this.tbUserName.Validating += new System.ComponentModel.CancelEventHandler(this.tbUserName_Validating);
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(204, 408);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(75, 23);
            this.btAdd.TabIndex = 3;
            this.btAdd.Text = "Add";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // btReset
            // 
            this.btReset.Location = new System.Drawing.Point(371, 408);
            this.btReset.Name = "btReset";
            this.btReset.Size = new System.Drawing.Size(75, 23);
            this.btReset.TabIndex = 4;
            this.btReset.Text = "Reset";
            this.btReset.UseVisualStyleBackColor = true;
            this.btReset.Click += new System.EventHandler(this.btReset_Click);
            // 
            // btThoat
            // 
            this.btThoat.Location = new System.Drawing.Point(597, 414);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(75, 23);
            this.btThoat.TabIndex = 5;
            this.btThoat.Text = "Thoat";
            this.btThoat.UseVisualStyleBackColor = true;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // fAddUserGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.btReset);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.panel1);
            this.Name = "fAddUserGUI";
            this.Text = "fAddUsersGUI";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tbDisplayName;
        private System.Windows.Forms.Label lbDisplayName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbUserName;
        private System.Windows.Forms.Label lbConfirm_Password;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.Label lbUserName;
        private System.Windows.Forms.Label lbIdUserRole;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button btReset;
        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.ComboBox cbbIdUserRole;
        private System.Windows.Forms.TextBox tbConfirm_Passoword;
        private System.Windows.Forms.Label lblErrorConfirmPassword;
        private System.Windows.Forms.Label lblErrorPassword;
        private System.Windows.Forms.Label lblErrorUserName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblErrorDisplayName;
    }
}