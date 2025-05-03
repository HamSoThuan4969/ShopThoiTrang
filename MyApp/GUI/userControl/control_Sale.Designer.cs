namespace GUI.userControl
{
    partial class control_Sale
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pnSale_Detail = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbConditionValue = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbDiscount = new System.Windows.Forms.TextBox();
            this.dtEndDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dtStartDate = new System.Windows.Forms.DateTimePicker();
            this.cbbTypeSale = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lbTypeSale = new System.Windows.Forms.Label();
            this.IdUserRole = new System.Windows.Forms.Label();
            this.tbDisplayName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbIdSale_Detail = new System.Windows.Forms.TextBox();
            this.lbIdSale = new System.Windows.Forms.Label();
            this.tbIdSale = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btAdd = new System.Windows.Forms.Button();
            this.btUpdate = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.btClear = new System.Windows.Forms.Button();
            this.btExportExcel = new System.Windows.Forms.Button();
            this.dataGridView_Sale = new System.Windows.Forms.DataGridView();
            this.pnSale_Detail.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Sale)).BeginInit();
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
            // pnSale_Detail
            // 
            this.pnSale_Detail.Controls.Add(this.label6);
            this.pnSale_Detail.Controls.Add(this.tbDescription);
            this.pnSale_Detail.Controls.Add(this.label4);
            this.pnSale_Detail.Controls.Add(this.tbConditionValue);
            this.pnSale_Detail.Controls.Add(this.label3);
            this.pnSale_Detail.Controls.Add(this.tbDiscount);
            this.pnSale_Detail.Controls.Add(this.dtEndDate);
            this.pnSale_Detail.Controls.Add(this.label1);
            this.pnSale_Detail.Controls.Add(this.dtStartDate);
            this.pnSale_Detail.Controls.Add(this.cbbTypeSale);
            this.pnSale_Detail.Controls.Add(this.label5);
            this.pnSale_Detail.Controls.Add(this.lbTypeSale);
            this.pnSale_Detail.Controls.Add(this.IdUserRole);
            this.pnSale_Detail.Controls.Add(this.tbDisplayName);
            this.pnSale_Detail.Controls.Add(this.label2);
            this.pnSale_Detail.Controls.Add(this.tbIdSale_Detail);
            this.pnSale_Detail.Controls.Add(this.lbIdSale);
            this.pnSale_Detail.Controls.Add(this.tbIdSale);
            this.pnSale_Detail.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnSale_Detail.Location = new System.Drawing.Point(815, 0);
            this.pnSale_Detail.Name = "pnSale_Detail";
            this.pnSale_Detail.Size = new System.Drawing.Size(465, 658);
            this.pnSale_Detail.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 408);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 20);
            this.label6.TabIndex = 25;
            this.label6.Text = "Description";
            // 
            // tbDescription
            // 
            this.tbDescription.Location = new System.Drawing.Point(119, 408);
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(336, 26);
            this.tbDescription.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 360);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 20);
            this.label4.TabIndex = 23;
            this.label4.Text = "ConditionValue";
            // 
            // tbConditionValue
            // 
            this.tbConditionValue.Location = new System.Drawing.Point(146, 360);
            this.tbConditionValue.Name = "tbConditionValue";
            this.tbConditionValue.Size = new System.Drawing.Size(309, 26);
            this.tbConditionValue.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 316);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 20);
            this.label3.TabIndex = 21;
            this.label3.Text = "DiscountValue";
            // 
            // tbDiscount
            // 
            this.tbDiscount.Location = new System.Drawing.Point(112, 316);
            this.tbDiscount.Name = "tbDiscount";
            this.tbDiscount.Size = new System.Drawing.Size(336, 26);
            this.tbDiscount.TabIndex = 22;
            // 
            // dtEndDate
            // 
            this.dtEndDate.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.dtEndDate.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            this.dtEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtEndDate.Location = new System.Drawing.Point(134, 530);
            this.dtEndDate.Name = "dtEndDate";
            this.dtEndDate.Size = new System.Drawing.Size(200, 26);
            this.dtEndDate.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 535);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "EndDate";
            // 
            // dtStartDate
            // 
            this.dtStartDate.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            this.dtStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtStartDate.Location = new System.Drawing.Point(134, 470);
            this.dtStartDate.Name = "dtStartDate";
            this.dtStartDate.Size = new System.Drawing.Size(200, 26);
            this.dtStartDate.TabIndex = 18;
            // 
            // cbbTypeSale
            // 
            this.cbbTypeSale.FormattingEnabled = true;
            this.cbbTypeSale.Items.AddRange(new object[] {
            "GroupCustomer",
            "Bill",
            "Event",
            "ComboSet"});
            this.cbbTypeSale.Location = new System.Drawing.Point(142, 257);
            this.cbbTypeSale.Name = "cbbTypeSale";
            this.cbbTypeSale.Size = new System.Drawing.Size(121, 28);
            this.cbbTypeSale.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 475);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "StartDate";
            // 
            // lbTypeSale
            // 
            this.lbTypeSale.AutoSize = true;
            this.lbTypeSale.Location = new System.Drawing.Point(23, 260);
            this.lbTypeSale.Name = "lbTypeSale";
            this.lbTypeSale.Size = new System.Drawing.Size(84, 20);
            this.lbTypeSale.TabIndex = 7;
            this.lbTypeSale.Text = "Type_Sale";
            // 
            // IdUserRole
            // 
            this.IdUserRole.AutoSize = true;
            this.IdUserRole.Location = new System.Drawing.Point(23, 195);
            this.IdUserRole.Name = "IdUserRole";
            this.IdUserRole.Size = new System.Drawing.Size(92, 20);
            this.IdUserRole.TabIndex = 5;
            this.IdUserRole.Text = "Sale_Name";
            // 
            // tbDisplayName
            // 
            this.tbDisplayName.Location = new System.Drawing.Point(119, 195);
            this.tbDisplayName.Name = "tbDisplayName";
            this.tbDisplayName.Size = new System.Drawing.Size(336, 26);
            this.tbDisplayName.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(242, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "IdSale_Detail";
            // 
            // tbIdSale_Detail
            // 
            this.tbIdSale_Detail.Location = new System.Drawing.Point(327, 146);
            this.tbIdSale_Detail.Name = "tbIdSale_Detail";
            this.tbIdSale_Detail.ReadOnly = true;
            this.tbIdSale_Detail.Size = new System.Drawing.Size(95, 26);
            this.tbIdSale_Detail.TabIndex = 4;
            // 
            // lbIdSale
            // 
            this.lbIdSale.AutoSize = true;
            this.lbIdSale.Location = new System.Drawing.Point(23, 137);
            this.lbIdSale.Name = "lbIdSale";
            this.lbIdSale.Size = new System.Drawing.Size(55, 20);
            this.lbIdSale.TabIndex = 1;
            this.lbIdSale.Text = "IdSale";
            // 
            // tbIdSale
            // 
            this.tbIdSale.Location = new System.Drawing.Point(90, 137);
            this.tbIdSale.Name = "tbIdSale";
            this.tbIdSale.ReadOnly = true;
            this.tbIdSale.Size = new System.Drawing.Size(56, 26);
            this.tbIdSale.TabIndex = 2;
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
            // dataGridView_Sale
            // 
            this.dataGridView_Sale.AllowDrop = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dataGridView_Sale.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_Sale.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGridView_Sale.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView_Sale.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Sale.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dataGridView_Sale.Location = new System.Drawing.Point(2, 161);
            this.dataGridView_Sale.Margin = new System.Windows.Forms.Padding(5);
            this.dataGridView_Sale.Name = "dataGridView_Sale";
            this.dataGridView_Sale.RowHeadersVisible = false;
            this.dataGridView_Sale.RowHeadersWidth = 62;
            this.dataGridView_Sale.RowTemplate.Height = 28;
            this.dataGridView_Sale.Size = new System.Drawing.Size(803, 419);
            this.dataGridView_Sale.TabIndex = 11;
            this.dataGridView_Sale.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_Sale_CellClick);
            // 
            // control_Sale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pnSale_Detail);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView_Sale);
            this.Name = "control_Sale";
            this.Size = new System.Drawing.Size(1280, 658);
            this.pnSale_Detail.ResumeLayout(false);
            this.pnSale_Detail.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Sale)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel pnSale_Detail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbTypeSale;
        private System.Windows.Forms.TextBox tbDisplayName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbIdSale_Detail;
        private System.Windows.Forms.Label lbIdSale;
        private System.Windows.Forms.TextBox tbIdSale;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button btUpdate;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btClear;
        private System.Windows.Forms.Button btExportExcel;
        private System.Windows.Forms.DataGridView dataGridView_Sale;
        private System.Windows.Forms.Label IdUserRole;
        private System.Windows.Forms.DateTimePicker dtStartDate;
        private System.Windows.Forms.ComboBox cbbTypeSale;
        private System.Windows.Forms.DateTimePicker dtEndDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbDescription;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbConditionValue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbDiscount;
    }
}
