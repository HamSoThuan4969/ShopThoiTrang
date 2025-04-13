namespace GUI
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
            this.lbX = new MaterialSkin.Controls.MaterialLabel();
            this.lbSignIn = new MaterialSkin.Controls.MaterialLabel();
            this.lbUserName = new MaterialSkin.Controls.MaterialLabel();
            this.lbPassword = new MaterialSkin.Controls.MaterialLabel();
            this.cbShowPassword = new MaterialSkin.Controls.MaterialCheckBox();
            this.tbUserName = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbShowPassWord = new MaterialSkin.Controls.MaterialLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.materialCheckBox1 = new MaterialSkin.Controls.MaterialCheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btRegister = new System.Windows.Forms.Button();
            this.btLogin = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbX
            // 
            this.lbX.AutoSize = true;
            this.lbX.Depth = 0;
            this.lbX.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbX.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbX.Location = new System.Drawing.Point(638, 42);
            this.lbX.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbX.Name = "lbX";
            this.lbX.Size = new System.Drawing.Size(26, 27);
            this.lbX.TabIndex = 1;
            this.lbX.Text = "X";
            this.lbX.Click += new System.EventHandler(this.lbX_Click);
            // 
            // lbSignIn
            // 
            this.lbSignIn.AutoSize = true;
            this.lbSignIn.Depth = 0;
            this.lbSignIn.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbSignIn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbSignIn.Location = new System.Drawing.Point(435, 177);
            this.lbSignIn.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbSignIn.Name = "lbSignIn";
            this.lbSignIn.Size = new System.Drawing.Size(77, 27);
            this.lbSignIn.TabIndex = 2;
            this.lbSignIn.Text = "InSign ";
            this.lbSignIn.Click += new System.EventHandler(this.materialLabel1_Click);
            // 
            // lbUserName
            // 
            this.lbUserName.AutoSize = true;
            this.lbUserName.Depth = 0;
            this.lbUserName.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbUserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbUserName.Location = new System.Drawing.Point(435, 235);
            this.lbUserName.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbUserName.Name = "lbUserName";
            this.lbUserName.Size = new System.Drawing.Size(120, 27);
            this.lbUserName.TabIndex = 3;
            this.lbUserName.Text = "User Name";
            this.lbUserName.Click += new System.EventHandler(this.materialLabel1_Click_1);
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Depth = 0;
            this.lbPassword.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbPassword.Location = new System.Drawing.Point(449, 334);
            this.lbPassword.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(109, 27);
            this.lbPassword.TabIndex = 4;
            this.lbPassword.Text = "Password";
            // 
            // cbShowPassword
            // 
            this.cbShowPassword.AutoSize = true;
            this.cbShowPassword.Depth = 0;
            this.cbShowPassword.Font = new System.Drawing.Font("Roboto", 10F);
            this.cbShowPassword.Location = new System.Drawing.Point(440, 470);
            this.cbShowPassword.Margin = new System.Windows.Forms.Padding(0);
            this.cbShowPassword.MouseLocation = new System.Drawing.Point(-1, -1);
            this.cbShowPassword.MouseState = MaterialSkin.MouseState.HOVER;
            this.cbShowPassword.Name = "cbShowPassword";
            this.cbShowPassword.Ripple = true;
            this.cbShowPassword.Size = new System.Drawing.Size(26, 30);
            this.cbShowPassword.TabIndex = 5;
            this.cbShowPassword.UseVisualStyleBackColor = true;
            // 
            // tbUserName
            // 
            this.tbUserName.Location = new System.Drawing.Point(440, 276);
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.Size = new System.Drawing.Size(291, 26);
            this.tbUserName.TabIndex = 6;
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(440, 399);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(291, 26);
            this.tbPassword.TabIndex = 7;
            // 
            // tbShowPassWord
            // 
            this.tbShowPassWord.AutoSize = true;
            this.tbShowPassWord.Depth = 0;
            this.tbShowPassWord.Font = new System.Drawing.Font("Roboto", 11F);
            this.tbShowPassWord.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tbShowPassWord.Location = new System.Drawing.Point(469, 474);
            this.tbShowPassWord.MouseState = MaterialSkin.MouseState.HOVER;
            this.tbShowPassWord.Name = "tbShowPassWord";
            this.tbShowPassWord.Size = new System.Drawing.Size(169, 27);
            this.tbShowPassWord.TabIndex = 8;
            this.tbShowPassWord.Text = "Show Password";
            this.tbShowPassWord.Click += new System.EventHandler(this.tbShowPassWord_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btRegister);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(404, 737);
            this.panel1.TabIndex = 1;
            // 
            // materialCheckBox1
            // 
            this.materialCheckBox1.AutoSize = true;
            this.materialCheckBox1.Depth = 0;
            this.materialCheckBox1.Font = new System.Drawing.Font("Roboto", 10F);
            this.materialCheckBox1.Location = new System.Drawing.Point(440, 529);
            this.materialCheckBox1.Margin = new System.Windows.Forms.Padding(0);
            this.materialCheckBox1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckBox1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCheckBox1.Name = "materialCheckBox1";
            this.materialCheckBox1.Ripple = true;
            this.materialCheckBox1.Size = new System.Drawing.Size(212, 30);
            this.materialCheckBox1.TabIndex = 2;
            this.materialCheckBox1.Text = "materialCheckBox1";
            this.materialCheckBox1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Magneto", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(61, 519);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(277, 52);
            this.button1.TabIndex = 1;
            this.button1.Text = "Create an account";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btRegister
            // 
            this.btRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
            this.btRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btRegister.Location = new System.Drawing.Point(61, 577);
            this.btRegister.Name = "btRegister";
            this.btRegister.Size = new System.Drawing.Size(277, 52);
            this.btRegister.TabIndex = 0;
            this.btRegister.Text = "REGISTER";
            this.btRegister.UseVisualStyleBackColor = false;
            this.btRegister.Click += new System.EventHandler(this.btRegister_Click);
            // 
            // btLogin
            // 
            this.btLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btLogin.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btLogin.Location = new System.Drawing.Point(454, 582);
            this.btLogin.Name = "btLogin";
            this.btLogin.Size = new System.Drawing.Size(130, 33);
            this.btLogin.TabIndex = 9;
            this.btLogin.Text = "Login";
            this.btLogin.UseVisualStyleBackColor = true;
            this.btLogin.Click += new System.EventHandler(this.btLogin_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 737);
            this.Controls.Add(this.materialCheckBox1);
            this.Controls.Add(this.btLogin);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tbShowPassWord);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbUserName);
            this.Controls.Add(this.cbShowPassword);
            this.Controls.Add(this.lbPassword);
            this.Controls.Add(this.lbUserName);
            this.Controls.Add(this.lbSignIn);
            this.Controls.Add(this.lbX);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialLabel lbX;
        private MaterialSkin.Controls.MaterialLabel lbSignIn;
        private MaterialSkin.Controls.MaterialLabel lbUserName;
        private MaterialSkin.Controls.MaterialLabel lbPassword;
        private MaterialSkin.Controls.MaterialCheckBox cbShowPassword;
        private System.Windows.Forms.TextBox tbUserName;
        private System.Windows.Forms.TextBox tbPassword;
        private MaterialSkin.Controls.MaterialLabel tbShowPassWord;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btRegister;
        private MaterialSkin.Controls.MaterialCheckBox materialCheckBox1;
        private System.Windows.Forms.Button btLogin;
    }
}