namespace GUI
{
    partial class fRegister
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btHaveAccount = new System.Windows.Forms.Button();
            this.fSingin = new System.Windows.Forms.Button();
            this.tbShowPassWord = new MaterialSkin.Controls.MaterialLabel();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbUserName = new System.Windows.Forms.TextBox();
            this.cbShowPassword = new MaterialSkin.Controls.MaterialCheckBox();
            this.lbPassword = new MaterialSkin.Controls.MaterialLabel();
            this.lbUserName = new MaterialSkin.Controls.MaterialLabel();
            this.lbRegister = new MaterialSkin.Controls.MaterialLabel();
            this.lbX = new MaterialSkin.Controls.MaterialLabel();
            this.tbConfirmPassword = new System.Windows.Forms.TextBox();
            this.lbConfirmPassword = new MaterialSkin.Controls.MaterialLabel();
            this.btRegister = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
            this.panel1.Controls.Add(this.btHaveAccount);
            this.panel1.Controls.Add(this.fSingin);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(404, 737);
            this.panel1.TabIndex = 9;
            // 
            // btHaveAccount
            // 
            this.btHaveAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
            this.btHaveAccount.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
            this.btHaveAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btHaveAccount.Font = new System.Drawing.Font("Magneto", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btHaveAccount.ForeColor = System.Drawing.Color.Black;
            this.btHaveAccount.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btHaveAccount.Location = new System.Drawing.Point(61, 519);
            this.btHaveAccount.Name = "btHaveAccount";
            this.btHaveAccount.Size = new System.Drawing.Size(277, 52);
            this.btHaveAccount.TabIndex = 1;
            this.btHaveAccount.Text = "Already have ancount";
            this.btHaveAccount.UseVisualStyleBackColor = false;
            // 
            // fSingin
            // 
            this.fSingin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
            this.fSingin.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.fSingin.Location = new System.Drawing.Point(61, 577);
            this.fSingin.Name = "fSingin";
            this.fSingin.Size = new System.Drawing.Size(277, 52);
            this.fSingin.TabIndex = 0;
            this.fSingin.Text = "SIGN IN ";
            this.fSingin.UseVisualStyleBackColor = false;
            this.fSingin.Click += new System.EventHandler(this.fSingin_Click);
            // 
            // tbShowPassWord
            // 
            this.tbShowPassWord.AutoSize = true;
            this.tbShowPassWord.Depth = 0;
            this.tbShowPassWord.Font = new System.Drawing.Font("Roboto", 11F);
            this.tbShowPassWord.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tbShowPassWord.Location = new System.Drawing.Point(493, 519);
            this.tbShowPassWord.MouseState = MaterialSkin.MouseState.HOVER;
            this.tbShowPassWord.Name = "tbShowPassWord";
            this.tbShowPassWord.Size = new System.Drawing.Size(169, 27);
            this.tbShowPassWord.TabIndex = 17;
            this.tbShowPassWord.Text = "Show Password";
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(441, 369);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(291, 26);
            this.tbPassword.TabIndex = 16;
            // 
            // tbUserName
            // 
            this.tbUserName.Location = new System.Drawing.Point(441, 276);
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.Size = new System.Drawing.Size(291, 26);
            this.tbUserName.TabIndex = 15;
            // 
            // cbShowPassword
            // 
            this.cbShowPassword.AutoSize = true;
            this.cbShowPassword.Depth = 0;
            this.cbShowPassword.Font = new System.Drawing.Font("Roboto", 10F);
            this.cbShowPassword.Location = new System.Drawing.Point(452, 516);
            this.cbShowPassword.Margin = new System.Windows.Forms.Padding(0);
            this.cbShowPassword.MouseLocation = new System.Drawing.Point(-1, -1);
            this.cbShowPassword.MouseState = MaterialSkin.MouseState.HOVER;
            this.cbShowPassword.Name = "cbShowPassword";
            this.cbShowPassword.Ripple = true;
            this.cbShowPassword.Size = new System.Drawing.Size(26, 30);
            this.cbShowPassword.TabIndex = 14;
            this.cbShowPassword.UseVisualStyleBackColor = true;
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Depth = 0;
            this.lbPassword.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbPassword.Location = new System.Drawing.Point(447, 318);
            this.lbPassword.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(109, 27);
            this.lbPassword.TabIndex = 13;
            this.lbPassword.Text = "Password";
            // 
            // lbUserName
            // 
            this.lbUserName.AutoSize = true;
            this.lbUserName.Depth = 0;
            this.lbUserName.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbUserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbUserName.Location = new System.Drawing.Point(436, 235);
            this.lbUserName.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbUserName.Name = "lbUserName";
            this.lbUserName.Size = new System.Drawing.Size(120, 27);
            this.lbUserName.TabIndex = 12;
            this.lbUserName.Text = "User Name";
            // 
            // lbRegister
            // 
            this.lbRegister.AutoSize = true;
            this.lbRegister.Depth = 0;
            this.lbRegister.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbRegister.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbRegister.Location = new System.Drawing.Point(436, 177);
            this.lbRegister.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbRegister.Name = "lbRegister";
            this.lbRegister.Size = new System.Drawing.Size(113, 27);
            this.lbRegister.TabIndex = 11;
            this.lbRegister.Text = "REGISTER";
            this.lbRegister.Click += new System.EventHandler(this.lbSignIn_Click);
            // 
            // lbX
            // 
            this.lbX.AutoSize = true;
            this.lbX.Depth = 0;
            this.lbX.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbX.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbX.Location = new System.Drawing.Point(744, 0);
            this.lbX.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbX.Name = "lbX";
            this.lbX.Size = new System.Drawing.Size(26, 27);
            this.lbX.TabIndex = 10;
            this.lbX.Text = "X";
            this.lbX.Click += new System.EventHandler(this.lbX_Click);
            // 
            // tbConfirmPassword
            // 
            this.tbConfirmPassword.Location = new System.Drawing.Point(441, 464);
            this.tbConfirmPassword.Name = "tbConfirmPassword";
            this.tbConfirmPassword.PasswordChar = '*';
            this.tbConfirmPassword.Size = new System.Drawing.Size(291, 26);
            this.tbConfirmPassword.TabIndex = 19;
            // 
            // lbConfirmPassword
            // 
            this.lbConfirmPassword.AutoSize = true;
            this.lbConfirmPassword.Depth = 0;
            this.lbConfirmPassword.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbConfirmPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbConfirmPassword.Location = new System.Drawing.Point(447, 418);
            this.lbConfirmPassword.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbConfirmPassword.Name = "lbConfirmPassword";
            this.lbConfirmPassword.Size = new System.Drawing.Size(192, 27);
            this.lbConfirmPassword.TabIndex = 18;
            this.lbConfirmPassword.Text = "Confirm Password";
            // 
            // btRegister
            // 
            this.btRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
            this.btRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btRegister.Location = new System.Drawing.Point(452, 588);
            this.btRegister.Name = "btRegister";
            this.btRegister.Size = new System.Drawing.Size(158, 41);
            this.btRegister.TabIndex = 20;
            this.btRegister.Text = "REGISTER";
            this.btRegister.UseVisualStyleBackColor = false;
            // 
            // fRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 737);
            this.Controls.Add(this.btRegister);
            this.Controls.Add(this.tbConfirmPassword);
            this.Controls.Add(this.lbConfirmPassword);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tbShowPassWord);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbUserName);
            this.Controls.Add(this.cbShowPassword);
            this.Controls.Add(this.lbPassword);
            this.Controls.Add(this.lbUserName);
            this.Controls.Add(this.lbRegister);
            this.Controls.Add(this.lbX);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fRegister";
            this.Text = "Rigister";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fRegister_FormClosing);
            this.Load += new System.EventHandler(this.fRegister_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btHaveAccount;
        private System.Windows.Forms.Button fSingin;
        private MaterialSkin.Controls.MaterialLabel tbShowPassWord;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbUserName;
        private MaterialSkin.Controls.MaterialCheckBox cbShowPassword;
        private MaterialSkin.Controls.MaterialLabel lbPassword;
        private MaterialSkin.Controls.MaterialLabel lbUserName;
        private MaterialSkin.Controls.MaterialLabel lbRegister;
        private MaterialSkin.Controls.MaterialLabel lbX;
        private System.Windows.Forms.TextBox tbConfirmPassword;
        private MaterialSkin.Controls.MaterialLabel lbConfirmPassword;
        private System.Windows.Forms.Button btRegister;
    }
}