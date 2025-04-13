namespace GUI
{
    partial class Test
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.materialContextMenuStrip2 = new MaterialSkin.Controls.MaterialContextMenuStrip();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tàiKhoảngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinCơBảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.materialFlatButton1 = new MaterialSkin.Controls.MaterialFlatButton();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.materialContextMenuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.materialFlatButton1);
            this.panel2.Location = new System.Drawing.Point(2, 50);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(525, 388);
            this.panel2.TabIndex = 1;
            // 
            // materialContextMenuStrip2
            // 
            this.materialContextMenuStrip2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialContextMenuStrip2.Depth = 0;
            this.materialContextMenuStrip2.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.materialContextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adminToolStripMenuItem});
            this.materialContextMenuStrip2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialContextMenuStrip2.Name = "materialContextMenuStrip2";
            this.materialContextMenuStrip2.Size = new System.Drawing.Size(143, 36);
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tàiKhoảngToolStripMenuItem,
            this.thôngTinCơBảnToolStripMenuItem,
            this.đăngXuấtToolStripMenuItem});
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(142, 32);
            this.adminToolStripMenuItem.Text = "Admin ";
            // 
            // tàiKhoảngToolStripMenuItem
            // 
            this.tàiKhoảngToolStripMenuItem.Name = "tàiKhoảngToolStripMenuItem";
            this.tàiKhoảngToolStripMenuItem.Size = new System.Drawing.Size(249, 34);
            this.tàiKhoảngToolStripMenuItem.Text = "Tài khoảng";
            // 
            // thôngTinCơBảnToolStripMenuItem
            // 
            this.thôngTinCơBảnToolStripMenuItem.Name = "thôngTinCơBảnToolStripMenuItem";
            this.thôngTinCơBảnToolStripMenuItem.Size = new System.Drawing.Size(249, 34);
            this.thôngTinCơBảnToolStripMenuItem.Text = "Thông tin cơ bản";
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(249, 34);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            // 
            // materialFlatButton1
            // 
            this.materialFlatButton1.AutoSize = true;
            this.materialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton1.Depth = 0;
            this.materialFlatButton1.Location = new System.Drawing.Point(133, 71);
            this.materialFlatButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton1.Name = "materialFlatButton1";
            this.materialFlatButton1.Primary = false;
            this.materialFlatButton1.Size = new System.Drawing.Size(254, 36);
            this.materialFlatButton1.TabIndex = 0;
            this.materialFlatButton1.Text = "materialFlatButton1";
            this.materialFlatButton1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(133, 147);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Name = "Test";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Test";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.materialContextMenuStrip2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private MaterialSkin.Controls.MaterialContextMenuStrip materialContextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tàiKhoảngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinCơBảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton1;
    }
}