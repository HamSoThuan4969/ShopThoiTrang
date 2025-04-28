namespace GUI
{
    partial class fEmployee
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngKýMớiThànhViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.traCứuHóaĐơnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.traCứuKháchHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Silver;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.đăngKýMớiThànhViênToolStripMenuItem,
            this.traCứuHóaĐơnToolStripMenuItem,
            this.traCứuKháchHàngToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(202, 450);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.homeToolStripMenuItem.Text = "Home";
            // 
            // đăngKýMớiThànhViênToolStripMenuItem
            // 
            this.đăngKýMớiThànhViênToolStripMenuItem.Name = "đăngKýMớiThànhViênToolStripMenuItem";
            this.đăngKýMớiThànhViênToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.đăngKýMớiThànhViênToolStripMenuItem.Text = "Đăng ký mới thành viên";
            // 
            // traCứuHóaĐơnToolStripMenuItem
            // 
            this.traCứuHóaĐơnToolStripMenuItem.Name = "traCứuHóaĐơnToolStripMenuItem";
            this.traCứuHóaĐơnToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.traCứuHóaĐơnToolStripMenuItem.Text = "Tra cứu hóa đơn";
            // 
            // traCứuKháchHàngToolStripMenuItem
            // 
            this.traCứuKháchHàngToolStripMenuItem.Name = "traCứuKháchHàngToolStripMenuItem";
            this.traCứuKháchHàngToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.traCứuKháchHàngToolStripMenuItem.Text = "Tra cứu khách hàng";
            // 
            // fEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Name = "fEmployee";
            this.Text = "fEmployee";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngKýMớiThànhViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem traCứuHóaĐơnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem traCứuKháchHàngToolStripMenuItem;
    }
}