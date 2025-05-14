namespace GUI.userControl
{
    partial class Control_Supplier
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btAdd = new System.Windows.Forms.Button();
            this.btUpdate = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.btClear = new System.Windows.Forms.Button();
            this.btExportExcel = new System.Windows.Forms.Button();
            this.dataGridView_Supplier = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbbTypeObject = new System.Windows.Forms.ComboBox();
            this.tbDisplayName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbAbbreviation = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbPhone = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbMoreInfor = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbId = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Supplier)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.btAdd);
            this.panel1.Controls.Add(this.btUpdate);
            this.panel1.Controls.Add(this.btDelete);
            this.panel1.Controls.Add(this.btClear);
            this.panel1.Controls.Add(this.btExportExcel);
            this.panel1.Location = new System.Drawing.Point(5, 469);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(604, 78);
            this.panel1.TabIndex = 16;
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
            // dataGridView_Supplier
            // 
            this.dataGridView_Supplier.AllowDrop = true;
            this.dataGridView_Supplier.AllowUserToAddRows = false;
            this.dataGridView_Supplier.AllowUserToDeleteRows = false;
            this.dataGridView_Supplier.AllowUserToResizeColumns = false;
            this.dataGridView_Supplier.AllowUserToResizeRows = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dataGridView_Supplier.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_Supplier.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGridView_Supplier.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView_Supplier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Supplier.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dataGridView_Supplier.Location = new System.Drawing.Point(5, 153);
            this.dataGridView_Supplier.Margin = new System.Windows.Forms.Padding(5);
            this.dataGridView_Supplier.Name = "dataGridView_Supplier";
            this.dataGridView_Supplier.RowHeadersVisible = false;
            this.dataGridView_Supplier.RowHeadersWidth = 62;
            this.dataGridView_Supplier.RowTemplate.Height = 28;
            this.dataGridView_Supplier.Size = new System.Drawing.Size(1182, 313);
            this.dataGridView_Supplier.TabIndex = 15;
            this.dataGridView_Supplier.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_Supplier_CellClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tbId);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.tbAddress);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.tbEmail);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.tbMoreInfor);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.tbPhone);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.tbAbbreviation);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.cbbTypeObject);
            this.panel2.Controls.Add(this.tbDisplayName);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(5, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1212, 142);
            this.panel2.TabIndex = 17;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // cbbTypeObject
            // 
            this.cbbTypeObject.FormattingEnabled = true;
            this.cbbTypeObject.Location = new System.Drawing.Point(479, 54);
            this.cbbTypeObject.Name = "cbbTypeObject";
            this.cbbTypeObject.Size = new System.Drawing.Size(197, 28);
            this.cbbTypeObject.TabIndex = 3;
            // 
            // tbDisplayName
            // 
            this.tbDisplayName.Location = new System.Drawing.Point(88, 13);
            this.tbDisplayName.Name = "tbDisplayName";
            this.tbDisplayName.Size = new System.Drawing.Size(198, 26);
            this.tbDisplayName.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // tbAbbreviation
            // 
            this.tbAbbreviation.Location = new System.Drawing.Point(428, 10);
            this.tbAbbreviation.Name = "tbAbbreviation";
            this.tbAbbreviation.Size = new System.Drawing.Size(112, 26);
            this.tbAbbreviation.TabIndex = 6;
            this.tbAbbreviation.Text = "  ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(325, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Abbreviation";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(333, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "TypeObject";
            // 
            // tbPhone
            // 
            this.tbPhone.Location = new System.Drawing.Point(78, 103);
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(198, 26);
            this.tbPhone.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Phone";
            // 
            // tbMoreInfor
            // 
            this.tbMoreInfor.Location = new System.Drawing.Point(998, 4);
            this.tbMoreInfor.Multiline = true;
            this.tbMoreInfor.Name = "tbMoreInfor";
            this.tbMoreInfor.Size = new System.Drawing.Size(215, 85);
            this.tbMoreInfor.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(901, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "More Infor";
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(348, 103);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(226, 26);
            this.tbEmail.TabIndex = 14;
            this.tbEmail.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(282, 103);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Email";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // tbAddress
            // 
            this.tbAddress.Location = new System.Drawing.Point(82, 57);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(221, 26);
            this.tbAddress.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 57);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 20);
            this.label8.TabIndex = 15;
            this.label8.Text = "Address";
            // 
            // tbId
            // 
            this.tbId.Location = new System.Drawing.Point(667, 7);
            this.tbId.Name = "tbId";
            this.tbId.ReadOnly = true;
            this.tbId.Size = new System.Drawing.Size(142, 26);
            this.tbId.TabIndex = 18;
            this.tbId.Text = "  ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(580, 7);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 20);
            this.label9.TabIndex = 17;
            this.label9.Text = "IdSupplier";
            // 
            // Control_Supplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView_Supplier);
            this.Name = "Control_Supplier";
            this.Size = new System.Drawing.Size(1220, 550);
            this.Load += new System.EventHandler(this.Control_Supplier_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Supplier)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button btUpdate;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btClear;
        private System.Windows.Forms.Button btExportExcel;
        private System.Windows.Forms.DataGridView dataGridView_Supplier;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox tbDisplayName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbTypeObject;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbAbbreviation;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbPhone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbMoreInfor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.Label label9;
    }
}
