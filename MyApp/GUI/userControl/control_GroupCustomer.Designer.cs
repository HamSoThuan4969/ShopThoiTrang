namespace GUI.userControl
{
    partial class control_GroupCustomer
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tbTypeGroup = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbDisplayName = new System.Windows.Forms.TextBox();
            this.lbDisplayName = new System.Windows.Forms.Label();
            this.tbId = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btAdd = new System.Windows.Forms.Button();
            this.btUpdate = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.btClear = new System.Windows.Forms.Button();
            this.btExportExcel = new System.Windows.Forms.Button();
            this.dataGridView_GroupCustomer = new System.Windows.Forms.DataGridView();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_GroupCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textBox1.Location = new System.Drawing.Point(25, 118);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(228, 26);
            this.textBox1.TabIndex = 14;
            this.textBox1.Text = "Tìm kiếm ";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.tbTypeGroup);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.tbDisplayName);
            this.panel2.Controls.Add(this.lbDisplayName);
            this.panel2.Controls.Add(this.tbId);
            this.panel2.Location = new System.Drawing.Point(813, 15);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(465, 628);
            this.panel2.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 301);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "TypeGroup";
            // 
            // tbTypeGroup
            // 
            this.tbTypeGroup.Location = new System.Drawing.Point(83, 301);
            this.tbTypeGroup.Name = "tbTypeGroup";
            this.tbTypeGroup.Size = new System.Drawing.Size(365, 26);
            this.tbTypeGroup.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 473);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 20);
            this.label7.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 248);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Name";
            // 
            // tbDisplayName
            // 
            this.tbDisplayName.Location = new System.Drawing.Point(90, 248);
            this.tbDisplayName.Name = "tbDisplayName";
            this.tbDisplayName.Size = new System.Drawing.Size(365, 26);
            this.tbDisplayName.TabIndex = 4;
            // 
            // lbDisplayName
            // 
            this.lbDisplayName.AutoSize = true;
            this.lbDisplayName.Location = new System.Drawing.Point(23, 187);
            this.lbDisplayName.Name = "lbDisplayName";
            this.lbDisplayName.Size = new System.Drawing.Size(23, 20);
            this.lbDisplayName.TabIndex = 1;
            this.lbDisplayName.Text = "Id";
            // 
            // tbId
            // 
            this.tbId.Location = new System.Drawing.Point(90, 181);
            this.tbId.Name = "tbId";
            this.tbId.ReadOnly = true;
            this.tbId.Size = new System.Drawing.Size(365, 26);
            this.tbId.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btAdd);
            this.panel1.Controls.Add(this.btUpdate);
            this.panel1.Controls.Add(this.btDelete);
            this.panel1.Controls.Add(this.btClear);
            this.panel1.Controls.Add(this.btExportExcel);
            this.panel1.Location = new System.Drawing.Point(25, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(604, 78);
            this.panel1.TabIndex = 12;
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(26, 19);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(78, 31);
            this.btAdd.TabIndex = 3;
            this.btAdd.Text = "Add";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // btUpdate
            // 
            this.btUpdate.Location = new System.Drawing.Point(225, 19);
            this.btUpdate.Name = "btUpdate";
            this.btUpdate.Size = new System.Drawing.Size(78, 31);
            this.btUpdate.TabIndex = 7;
            this.btUpdate.Text = "Update";
            this.btUpdate.UseVisualStyleBackColor = true;
            this.btUpdate.Click += new System.EventHandler(this.btUpdate_Click);
            // 
            // btDelete
            // 
            this.btDelete.Location = new System.Drawing.Point(132, 19);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(78, 31);
            this.btDelete.TabIndex = 4;
            this.btDelete.Text = "Delete";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // btClear
            // 
            this.btClear.Location = new System.Drawing.Point(329, 19);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(78, 31);
            this.btClear.TabIndex = 6;
            this.btClear.Text = "Clear";
            this.btClear.UseVisualStyleBackColor = true;
            this.btClear.Click += new System.EventHandler(this.btClear_Click);
            // 
            // btExportExcel
            // 
            this.btExportExcel.Location = new System.Drawing.Point(410, 19);
            this.btExportExcel.Name = "btExportExcel";
            this.btExportExcel.Size = new System.Drawing.Size(78, 31);
            this.btExportExcel.TabIndex = 5;
            this.btExportExcel.Text = "EportExcel";
            this.btExportExcel.UseVisualStyleBackColor = true;
            this.btExportExcel.Click += new System.EventHandler(this.btExportExcel_Click);
            // 
            // dataGridView_GroupCustomer
            // 
            this.dataGridView_GroupCustomer.AllowDrop = true;
            this.dataGridView_GroupCustomer.AllowUserToAddRows = false;
            this.dataGridView_GroupCustomer.AllowUserToDeleteRows = false;
            this.dataGridView_GroupCustomer.AllowUserToResizeColumns = false;
            this.dataGridView_GroupCustomer.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dataGridView_GroupCustomer.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView_GroupCustomer.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGridView_GroupCustomer.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView_GroupCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_GroupCustomer.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dataGridView_GroupCustomer.Location = new System.Drawing.Point(2, 161);
            this.dataGridView_GroupCustomer.Margin = new System.Windows.Forms.Padding(5);
            this.dataGridView_GroupCustomer.Name = "dataGridView_GroupCustomer";
            this.dataGridView_GroupCustomer.RowHeadersVisible = false;
            this.dataGridView_GroupCustomer.RowHeadersWidth = 62;
            this.dataGridView_GroupCustomer.RowTemplate.Height = 28;
            this.dataGridView_GroupCustomer.Size = new System.Drawing.Size(803, 419);
            this.dataGridView_GroupCustomer.TabIndex = 11;
            // 
            // control_GroupCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView_GroupCustomer);
            this.Name = "control_GroupCustomer";
            this.Size = new System.Drawing.Size(1280, 658);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_GroupCustomer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbDisplayName;
        private System.Windows.Forms.Label lbDisplayName;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button btUpdate;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btClear;
        private System.Windows.Forms.Button btExportExcel;
        private System.Windows.Forms.DataGridView dataGridView_GroupCustomer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbTypeGroup;
    }
}
