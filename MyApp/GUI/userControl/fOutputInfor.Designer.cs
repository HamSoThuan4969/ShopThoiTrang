namespace GUI.userControl
{
    partial class fOutputInfor
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbDisplayName_Object = new System.Windows.Forms.TextBox();
            this.cbbDisplayName_Sale_Detail = new System.Windows.Forms.ComboBox();
            this.nbQuantity = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.labelTypeSale = new System.Windows.Forms.Label();
            this.tbDiscount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbTotal = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbPrice_Total = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbIdObject = new System.Windows.Forms.TextBox();
            this.cbbSetObject = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.checkBoxSelect = new System.Windows.Forms.CheckBox();
            this.tbId_Customer = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nbQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name_Object";
            // 
            // tbDisplayName_Object
            // 
            this.tbDisplayName_Object.Location = new System.Drawing.Point(160, 50);
            this.tbDisplayName_Object.Name = "tbDisplayName_Object";
            this.tbDisplayName_Object.Size = new System.Drawing.Size(181, 26);
            this.tbDisplayName_Object.TabIndex = 3;
            // 
            // cbbDisplayName_Sale_Detail
            // 
            this.cbbDisplayName_Sale_Detail.FormattingEnabled = true;
            this.cbbDisplayName_Sale_Detail.Location = new System.Drawing.Point(160, 151);
            this.cbbDisplayName_Sale_Detail.Name = "cbbDisplayName_Sale_Detail";
            this.cbbDisplayName_Sale_Detail.Size = new System.Drawing.Size(181, 28);
            this.cbbDisplayName_Sale_Detail.TabIndex = 4;
            this.cbbDisplayName_Sale_Detail.SelectedIndexChanged += new System.EventHandler(this.CbbDisplayName_Sale_Detail_SelectedIndexChanged);
            // 
            // nbQuantity
            // 
            this.nbQuantity.Location = new System.Drawing.Point(481, 94);
            this.nbQuantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nbQuantity.Name = "nbQuantity";
            this.nbQuantity.Size = new System.Drawing.Size(120, 26);
            this.nbQuantity.TabIndex = 6;
            this.nbQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(395, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Quantity";
            // 
            // tbPrice
            // 
            this.tbPrice.Location = new System.Drawing.Point(160, 93);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(181, 26);
            this.tbPrice.TabIndex = 10;
            this.tbPrice.TextChanged += new System.EventHandler(this.tbPrice_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Price";
            // 
            // labelTypeSale
            // 
            this.labelTypeSale.AutoSize = true;
            this.labelTypeSale.Location = new System.Drawing.Point(3, 151);
            this.labelTypeSale.Name = "labelTypeSale";
            this.labelTypeSale.Size = new System.Drawing.Size(143, 20);
            this.labelTypeSale.TabIndex = 11;
            this.labelTypeSale.Text = "DisplayName_Sale";
            // 
            // tbDiscount
            // 
            this.tbDiscount.Location = new System.Drawing.Point(481, 156);
            this.tbDiscount.Name = "tbDiscount";
            this.tbDiscount.Size = new System.Drawing.Size(181, 26);
            this.tbDiscount.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(395, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Discount";
            // 
            // tbTotal
            // 
            this.tbTotal.Location = new System.Drawing.Point(160, 203);
            this.tbTotal.Name = "tbTotal";
            this.tbTotal.Size = new System.Drawing.Size(171, 26);
            this.tbTotal.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(53, 209);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "Total";
            // 
            // tbPrice_Total
            // 
            this.tbPrice_Total.Location = new System.Drawing.Point(751, 99);
            this.tbPrice_Total.Name = "tbPrice_Total";
            this.tbPrice_Total.Size = new System.Drawing.Size(99, 26);
            this.tbPrice_Total.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(657, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 20);
            this.label6.TabIndex = 18;
            this.label6.Text = "Price_Total";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(414, 45);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 20);
            this.label7.TabIndex = 20;
            this.label7.Text = "Id_Object";
            // 
            // tbIdObject
            // 
            this.tbIdObject.Location = new System.Drawing.Point(508, 45);
            this.tbIdObject.Name = "tbIdObject";
            this.tbIdObject.Size = new System.Drawing.Size(99, 26);
            this.tbIdObject.TabIndex = 19;
            // 
            // cbbSetObject
            // 
            this.cbbSetObject.FormattingEnabled = true;
            this.cbbSetObject.Location = new System.Drawing.Point(751, 43);
            this.cbbSetObject.Name = "cbbSetObject";
            this.cbbSetObject.Size = new System.Drawing.Size(121, 28);
            this.cbbSetObject.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(657, 45);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 20);
            this.label8.TabIndex = 22;
            this.label8.Text = "SetObject";
            // 
            // checkBoxSelect
            // 
            this.checkBoxSelect.AutoSize = true;
            this.checkBoxSelect.Location = new System.Drawing.Point(3, 3);
            this.checkBoxSelect.Name = "checkBoxSelect";
            this.checkBoxSelect.Size = new System.Drawing.Size(22, 21);
            this.checkBoxSelect.TabIndex = 23;
            this.checkBoxSelect.UseVisualStyleBackColor = true;
            // 
            // tbId_Customer
            // 
            this.tbId_Customer.Location = new System.Drawing.Point(986, 6);
            this.tbId_Customer.Name = "tbId_Customer";
            this.tbId_Customer.Size = new System.Drawing.Size(191, 26);
            this.tbId_Customer.TabIndex = 30;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(879, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 20);
            this.label9.TabIndex = 31;
            this.label9.Text = "Id_Customer";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(382, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(191, 26);
            this.textBox1.TabIndex = 24;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(247, 3);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(129, 20);
            this.label10.TabIndex = 25;
            this.label10.Text = "Name_Customer";
            // 
            // fOutputInfor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.Controls.Add(this.tbId_Customer);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.checkBoxSelect);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbbSetObject);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbIdObject);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbPrice_Total);
            this.Controls.Add(this.tbTotal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbDiscount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelTypeSale);
            this.Controls.Add(this.tbPrice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nbQuantity);
            this.Controls.Add(this.cbbDisplayName_Sale_Detail);
            this.Controls.Add(this.tbDisplayName_Object);
            this.Controls.Add(this.label1);
            this.Name = "fOutputInfor";
            this.Size = new System.Drawing.Size(1210, 250);
            ((System.ComponentModel.ISupportInitialize)(this.nbQuantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbDisplayName_Object;
        private System.Windows.Forms.ComboBox cbbDisplayName_Sale_Detail;
        private System.Windows.Forms.NumericUpDown nbQuantity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelTypeSale;
        private System.Windows.Forms.TextBox tbDiscount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbTotal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbPrice_Total;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbIdObject;
        private System.Windows.Forms.ComboBox cbbSetObject;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.CheckBox checkBoxSelect;
        private System.Windows.Forms.TextBox tbId_Customer;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label10;
    }
}
