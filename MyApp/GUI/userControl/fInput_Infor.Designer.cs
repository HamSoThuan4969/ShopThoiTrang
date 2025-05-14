namespace GUI.userControl
{
    partial class fInput_Infor
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
            this.tbDisplayName_Object = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbPrice_Input = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.nbQuantity = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.tbMoreInfor_Object = new System.Windows.Forms.TextBox();
            this.checkBoxSelect = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbPrice_Output = new System.Windows.Forms.TextBox();
            this.cbbSupplier = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.nbQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // tbDisplayName_Object
            // 
            this.tbDisplayName_Object.Location = new System.Drawing.Point(206, 43);
            this.tbDisplayName_Object.Name = "tbDisplayName_Object";
            this.tbDisplayName_Object.Size = new System.Drawing.Size(211, 26);
            this.tbDisplayName_Object.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tên Sản phẩm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Supplier";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(88, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Price_Input";
            // 
            // tbPrice_Input
            // 
            this.tbPrice_Input.Location = new System.Drawing.Point(206, 149);
            this.tbPrice_Input.Name = "tbPrice_Input";
            this.tbPrice_Input.Size = new System.Drawing.Size(104, 26);
            this.tbPrice_Input.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(475, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Quantity";
            // 
            // nbQuantity
            // 
            this.nbQuantity.Location = new System.Drawing.Point(559, 44);
            this.nbQuantity.Name = "nbQuantity";
            this.nbQuantity.Size = new System.Drawing.Size(120, 26);
            this.nbQuantity.TabIndex = 11;
            this.nbQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(88, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "More Infor";
            // 
            // tbMoreInfor_Object
            // 
            this.tbMoreInfor_Object.Location = new System.Drawing.Point(206, 200);
            this.tbMoreInfor_Object.Multiline = true;
            this.tbMoreInfor_Object.Name = "tbMoreInfor_Object";
            this.tbMoreInfor_Object.Size = new System.Drawing.Size(193, 101);
            this.tbMoreInfor_Object.TabIndex = 14;
            // 
            // checkBoxSelect
            // 
            this.checkBoxSelect.AutoSize = true;
            this.checkBoxSelect.Location = new System.Drawing.Point(0, 0);
            this.checkBoxSelect.Name = "checkBoxSelect";
            this.checkBoxSelect.Size = new System.Drawing.Size(22, 21);
            this.checkBoxSelect.TabIndex = 16;
            this.checkBoxSelect.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(390, 155);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 20);
            this.label7.TabIndex = 19;
            this.label7.Text = "Price_Output";
            // 
            // tbPrice_Output
            // 
            this.tbPrice_Output.Location = new System.Drawing.Point(543, 152);
            this.tbPrice_Output.Name = "tbPrice_Output";
            this.tbPrice_Output.Size = new System.Drawing.Size(104, 26);
            this.tbPrice_Output.TabIndex = 18;
            // 
            // cbbSupplier
            // 
            this.cbbSupplier.FormattingEnabled = true;
            this.cbbSupplier.Location = new System.Drawing.Point(212, 102);
            this.cbbSupplier.Name = "cbbSupplier";
            this.cbbSupplier.Size = new System.Drawing.Size(205, 28);
            this.cbbSupplier.TabIndex = 20;
            // 
            // fInput_Infor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.cbbSupplier);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbPrice_Output);
            this.Controls.Add(this.checkBoxSelect);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbMoreInfor_Object);
            this.Controls.Add(this.nbQuantity);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbPrice_Input);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbDisplayName_Object);
            this.Name = "fInput_Infor";
            this.Padding = new System.Windows.Forms.Padding(2, 2, 2, 0);
            this.Size = new System.Drawing.Size(793, 335);
            ((System.ComponentModel.ISupportInitialize)(this.nbQuantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbDisplayName_Object;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbPrice_Input;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nbQuantity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbMoreInfor_Object;
        public System.Windows.Forms.CheckBox checkBoxSelect;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbPrice_Output;
        private System.Windows.Forms.ComboBox cbbSupplier;
    }
}
