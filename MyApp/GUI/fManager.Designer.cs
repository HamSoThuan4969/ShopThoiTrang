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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kháchHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.khoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView_Customer = new System.Windows.Forms.DataGridView();
            this.tvFind = new System.Windows.Forms.TextBox();
            this.Add_Customer = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Customer)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.Font = new System.Drawing.Font("Nueva Std", 9F, System.Drawing.FontStyle.Bold);
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.kháchHàngToolStripMenuItem,
            this.khoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(110, 556);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(97, 22);
            this.homeToolStripMenuItem.Text = "Home";
            // 
            // kháchHàngToolStripMenuItem
            // 
            this.kháchHàngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dataToolStripMenuItem,
            this.groupToolStripMenuItem});
            this.kháchHàngToolStripMenuItem.Name = "kháchHàngToolStripMenuItem";
            this.kháchHàngToolStripMenuItem.Size = new System.Drawing.Size(97, 22);
            this.kháchHàngToolStripMenuItem.Text = "Customer";
            // 
            // dataToolStripMenuItem
            // 
            this.dataToolStripMenuItem.Name = "dataToolStripMenuItem";
            this.dataToolStripMenuItem.Size = new System.Drawing.Size(157, 34);
            this.dataToolStripMenuItem.Text = "Data";
            // 
            // groupToolStripMenuItem
            // 
            this.groupToolStripMenuItem.Name = "groupToolStripMenuItem";
            this.groupToolStripMenuItem.Size = new System.Drawing.Size(157, 34);
            this.groupToolStripMenuItem.Text = "Group";
            // 
            // khoToolStripMenuItem
            // 
            this.khoToolStripMenuItem.Name = "khoToolStripMenuItem";
            this.khoToolStripMenuItem.Size = new System.Drawing.Size(97, 22);
            this.khoToolStripMenuItem.Text = "Kho ";
            // 
            // dataGridView_Customer
            // 
            this.dataGridView_Customer.AllowUserToAddRows = false;
            this.dataGridView_Customer.AllowUserToDeleteRows = false;
            this.dataGridView_Customer.AllowUserToResizeColumns = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.LightSkyBlue;
            this.dataGridView_Customer.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView_Customer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_Customer.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView_Customer.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridView_Customer.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_Customer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView_Customer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Customer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView_Customer.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridView_Customer.Location = new System.Drawing.Point(110, 250);
            this.dataGridView_Customer.Margin = new System.Windows.Forms.Padding(4, 3, 5, 3);
            this.dataGridView_Customer.Name = "dataGridView_Customer";
            this.dataGridView_Customer.RowHeadersVisible = false;
            this.dataGridView_Customer.RowHeadersWidth = 62;
            this.dataGridView_Customer.RowTemplate.Height = 28;
            this.dataGridView_Customer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Customer.Size = new System.Drawing.Size(1353, 306);
            this.dataGridView_Customer.TabIndex = 2;
            this.dataGridView_Customer.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // tvFind
            // 
            this.tvFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)), true);
            this.tvFind.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.tvFind.Location = new System.Drawing.Point(123, 60);
            this.tvFind.Name = "tvFind";
            this.tvFind.Size = new System.Drawing.Size(229, 26);
            this.tvFind.TabIndex = 3;
            this.tvFind.Text = "Nhập thông tin tìm kiếm\r\n";
            // 
            // Add_Customer
            // 
            this.Add_Customer.BackColor = System.Drawing.Color.CornflowerBlue;
            this.Add_Customer.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Add_Customer.Location = new System.Drawing.Point(612, 132);
            this.Add_Customer.Name = "Add_Customer";
            this.Add_Customer.Size = new System.Drawing.Size(117, 67);
            this.Add_Customer.TabIndex = 4;
            this.Add_Customer.Text = "Add";
            this.Add_Customer.UseVisualStyleBackColor = false;
            this.Add_Customer.Click += new System.EventHandler(this.Add_Customer_Click);
            // 
            // fManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1463, 556);
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
    }
}