namespace GUI
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tb_account = new System.Windows.Forms.TextBox();
            this.tb_pass = new System.Windows.Forms.TextBox();
            this.lb_signup = new System.Windows.Forms.Label();
            this.lb_forgotpassword = new System.Windows.Forms.Label();
            this.lb_next = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(857, 487);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // tb_account
            // 
            this.tb_account.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_account.Location = new System.Drawing.Point(291, 188);
            this.tb_account.Name = "tb_account";
            this.tb_account.Size = new System.Drawing.Size(308, 40);
            this.tb_account.TabIndex = 1;
            // 
            // tb_pass
            // 
            this.tb_pass.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_pass.Location = new System.Drawing.Point(291, 279);
            this.tb_pass.Name = "tb_pass";
            this.tb_pass.Size = new System.Drawing.Size(308, 40);
            this.tb_pass.TabIndex = 2;
            // 
            // lb_signup
            // 
            this.lb_signup.AutoSize = true;
            this.lb_signup.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lb_signup.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_signup.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lb_signup.Location = new System.Drawing.Point(128, 374);
            this.lb_signup.Name = "lb_signup";
            this.lb_signup.Size = new System.Drawing.Size(116, 34);
            this.lb_signup.TabIndex = 3;
            this.lb_signup.Text = "Sign Up !";
            // 
            // lb_forgotpassword
            // 
            this.lb_forgotpassword.AutoSize = true;
            this.lb_forgotpassword.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lb_forgotpassword.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_forgotpassword.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lb_forgotpassword.Location = new System.Drawing.Point(325, 374);
            this.lb_forgotpassword.Name = "lb_forgotpassword";
            this.lb_forgotpassword.Size = new System.Drawing.Size(223, 34);
            this.lb_forgotpassword.TabIndex = 4;
            this.lb_forgotpassword.Text = "Forgot Password ?";
            // 
            // lb_next
            // 
            this.lb_next.AutoSize = true;
            this.lb_next.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lb_next.Font = new System.Drawing.Font(".VnVogue", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_next.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lb_next.Location = new System.Drawing.Point(642, 358);
            this.lb_next.Name = "lb_next";
            this.lb_next.Size = new System.Drawing.Size(124, 53);
            this.lb_next.TabIndex = 5;
            this.lb_next.Text = "Next";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 486);
            this.Controls.Add(this.lb_next);
            this.Controls.Add(this.lb_forgotpassword);
            this.Controls.Add(this.lb_signup);
            this.Controls.Add(this.tb_pass);
            this.Controls.Add(this.tb_account);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Login";
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox tb_account;
        private System.Windows.Forms.TextBox tb_pass;
        private System.Windows.Forms.Label lb_signup;
        private System.Windows.Forms.Label lb_forgotpassword;
        private System.Windows.Forms.Label lb_next;
    }
}