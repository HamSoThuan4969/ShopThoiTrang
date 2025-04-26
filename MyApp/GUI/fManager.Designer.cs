namespace GUI
{
    partial class fManager
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kháchHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.khoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView_Customer = new System.Windows.Forms.DataGridView();
            this.tvFind = new System.Windows.Forms.TextBox();
            this.Add_Customer = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.btClear = new System.Windows.Forms.Button();
            this.btUpdate = new System.Windows.Forms.Button();
            this.materialContextMenuStrip1 = new MaterialSkin.Controls.MaterialContextMenuStrip();
            this.tbDisplayName = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.lb_DisplayName = new System.Windows.Forms.Label();
            this.lbGroup_Customer = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lb_Phone = new System.Windows.Forms.Label();
            this.tbPhone = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbMoreInfor = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Customer)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.kháchHàngToolStripMenuItem,
            this.khoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(186, 556);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(173, 26);
            this.homeToolStripMenuItem.Text = "Home";
            // 
            // kháchHàngToolStripMenuItem
            // 
            this.kháchHàngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dataToolStripMenuItem,
            this.groupToolStripMenuItem});
            this.kháchHàngToolStripMenuItem.Name = "kháchHàngToolStripMenuItem";
            this.kháchHàngToolStripMenuItem.Size = new System.Drawing.Size(173, 26);
            this.kháchHàngToolStripMenuItem.Text = "Customer";
            // 
            // dataToolStripMenuItem
            // 
            this.dataToolStripMenuItem.Name = "dataToolStripMenuItem";
            this.dataToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.dataToolStripMenuItem.Text = "Data";
            // 
            // groupToolStripMenuItem
            // 
            this.groupToolStripMenuItem.Name = "groupToolStripMenuItem";
            this.groupToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.groupToolStripMenuItem.Text = "Group";
            // 
            // khoToolStripMenuItem
            // 
            this.khoToolStripMenuItem.Name = "khoToolStripMenuItem";
            this.khoToolStripMenuItem.Size = new System.Drawing.Size(173, 26);
            this.khoToolStripMenuItem.Text = "Kho ";
            // 
            // dataGridView_Customer
            // 
            this.dataGridView_Customer.AllowDrop = true;
            this.dataGridView_Customer.AllowUserToDeleteRows = false;
            this.dataGridView_Customer.AllowUserToResizeColumns = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.dataGridView_Customer.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_Customer.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridView_Customer.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_Customer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_Customer.ColumnHeadersHeight = 34;
            this.dataGridView_Customer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView_Customer.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView_Customer.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridView_Customer.Location = new System.Drawing.Point(186, 0);
            this.dataGridView_Customer.Margin = new System.Windows.Forms.Padding(4, 3, 5, 3);
            this.dataGridView_Customer.Name = "dataGridView_Customer";
            this.dataGridView_Customer.RowHeadersVisible = false;
            this.dataGridView_Customer.RowHeadersWidth = 62;
            this.dataGridView_Customer.RowTemplate.Height = 28;
            this.dataGridView_Customer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Customer.Size = new System.Drawing.Size(1277, 228);
            this.dataGridView_Customer.TabIndex = 2;
            // 
            // tvFind
            // 
            this.tvFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)), true);
            this.tvFind.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.tvFind.Location = new System.Drawing.Point(1207, 494);
            this.tvFind.Name = "tvFind";
            this.tvFind.Size = new System.Drawing.Size(229, 26);
            this.tvFind.TabIndex = 3;
            this.tvFind.Text = "Nhập thông tin tìm kiếm\r\n";
            // 
            // Add_Customer
            // 
            this.Add_Customer.BackColor = System.Drawing.Color.CornflowerBlue;
            this.Add_Customer.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Add_Customer.Location = new System.Drawing.Point(144, 453);
            this.Add_Customer.Name = "Add_Customer";
            this.Add_Customer.Size = new System.Drawing.Size(117, 67);
            this.Add_Customer.TabIndex = 4;
            this.Add_Customer.Text = "Add";
            this.Add_Customer.UseVisualStyleBackColor = false;
            // 
            // btDelete
            // 
            this.btDelete.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btDelete.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btDelete.Location = new System.Drawing.Point(466, 453);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(117, 67);
            this.btDelete.TabIndex = 5;
            this.btDelete.Text = "Delete";
            this.btDelete.UseVisualStyleBackColor = false;
            // 
            // btClear
            // 
            this.btClear.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btClear.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btClear.Location = new System.Drawing.Point(611, 453);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(117, 67);
            this.btClear.TabIndex = 6;
            this.btClear.Text = "Clear";
            this.btClear.UseVisualStyleBackColor = false;
            // 
            // btUpdate
            // 
            this.btUpdate.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btUpdate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btUpdate.Location = new System.Drawing.Point(318, 453);
            this.btUpdate.Name = "btUpdate";
            this.btUpdate.Size = new System.Drawing.Size(117, 67);
            this.btUpdate.TabIndex = 7;
            this.btUpdate.Text = "Update";
            this.btUpdate.UseVisualStyleBackColor = false;
            // 
            // materialContextMenuStrip1
            // 
            this.materialContextMenuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialContextMenuStrip1.Depth = 0;
            this.materialContextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.materialContextMenuStrip1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialContextMenuStrip1.Name = "materialContextMenuStrip1";
            this.materialContextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // tbDisplayName
            // 
            this.tbDisplayName.Location = new System.Drawing.Point(278, 258);
            this.tbDisplayName.Name = "tbDisplayName";
            this.tbDisplayName.Size = new System.Drawing.Size(296, 26);
            this.tbDisplayName.TabIndex = 8;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // lb_DisplayName
            // 
            this.lb_DisplayName.AutoSize = true;
            this.lb_DisplayName.Location = new System.Drawing.Point(140, 255);
            this.lb_DisplayName.Name = "lb_DisplayName";
            this.lb_DisplayName.Size = new System.Drawing.Size(51, 20);
            this.lb_DisplayName.TabIndex = 10;
            this.lb_DisplayName.Text = "Name";
            // 
            // lbGroup_Customer
            // 
            this.lbGroup_Customer.AutoSize = true;
            this.lbGroup_Customer.Location = new System.Drawing.Point(129, 312);
            this.lbGroup_Customer.Name = "lbGroup_Customer";
            this.lbGroup_Customer.Size = new System.Drawing.Size(132, 20);
            this.lbGroup_Customer.TabIndex = 12;
            this.lbGroup_Customer.Text = "Group_Customer";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(278, 303);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(296, 26);
            this.textBox1.TabIndex = 11;
            // 
            // lb_Phone
            // 
            this.lb_Phone.AutoSize = true;
            this.lb_Phone.Location = new System.Drawing.Point(140, 368);
            this.lb_Phone.Name = "lb_Phone";
            this.lb_Phone.Size = new System.Drawing.Size(51, 20);
            this.lb_Phone.TabIndex = 14;
            this.lb_Phone.Text = "Name";
            // 
            // tbPhone
            // 
            this.tbPhone.Location = new System.Drawing.Point(278, 368);
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(296, 26);
            this.tbPhone.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(607, 258);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Name";
            // 
            // tbAddress
            // 
            this.tbAddress.Location = new System.Drawing.Point(676, 258);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(296, 26);
            this.tbAddress.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(607, 309);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 20);
            this.label4.TabIndex = 18;
            this.label4.Text = "Name";
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(676, 309);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(296, 26);
            this.tbEmail.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(607, 371);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 20);
            this.label5.TabIndex = 20;
            this.label5.Text = "Name";
            // 
            // tbMoreInfor
            // 
            this.tbMoreInfor.Location = new System.Drawing.Point(676, 371);
            this.tbMoreInfor.Name = "tbMoreInfor";
            this.tbMoreInfor.Size = new System.Drawing.Size(296, 26);
            this.tbMoreInfor.TabIndex = 19;
            // 
            // fManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1463, 556);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbMoreInfor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbAddress);
            this.Controls.Add(this.lb_Phone);
            this.Controls.Add(this.tbPhone);
            this.Controls.Add(this.lbGroup_Customer);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lb_DisplayName);
            this.Controls.Add(this.tbDisplayName);
            this.Controls.Add(this.btUpdate);
            this.Controls.Add(this.btClear);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.Add_Customer);
            this.Controls.Add(this.tvFind);
            this.Controls.Add(this.dataGridView_Customer);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "fManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Test";
            this.Load += new System.EventHandler(this.fManager_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Customer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kháchHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem groupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem khoToolStripMenuItem;
        private System.Windows.Forms.TextBox tvFind;
        private System.Windows.Forms.DataGridView dataGridView_Customer;
        private System.Windows.Forms.Button Add_Customer;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btClear;
        private System.Windows.Forms.Button btUpdate;
        private MaterialSkin.Controls.MaterialContextMenuStrip materialContextMenuStrip1;
        private System.Windows.Forms.TextBox tbDisplayName;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label lb_DisplayName;
        private System.Windows.Forms.Label lbGroup_Customer;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lb_Phone;
        private System.Windows.Forms.TextBox tbPhone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbMoreInfor;
    }
}