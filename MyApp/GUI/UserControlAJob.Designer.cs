namespace GUI
{
    partial class UserControlAJob
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
            this.pnAddJob = new System.Windows.Forms.Panel();
            this.lbShift = new System.Windows.Forms.Label();
            this.cbbShift = new System.Windows.Forms.ComboBox();
            this.pnShift = new System.Windows.Forms.Panel();
            this.lbStatus = new System.Windows.Forms.Label();
            this.lbRequest = new System.Windows.Forms.Label();
            this.cbAddJob = new System.Windows.Forms.CheckBox();
            this.pnStatus = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lbWaiting = new System.Windows.Forms.Label();
            this.btnAddJob = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.pnAddJob.SuspendLayout();
            this.pnStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnAddJob
            // 
            this.pnAddJob.Controls.Add(this.btnEdit);
            this.pnAddJob.Controls.Add(this.btnAddJob);
            this.pnAddJob.Controls.Add(this.lbWaiting);
            this.pnAddJob.Controls.Add(this.lbStatus);
            this.pnAddJob.Controls.Add(this.comboBox1);
            this.pnAddJob.Controls.Add(this.lbShift);
            this.pnAddJob.Controls.Add(this.pnStatus);
            this.pnAddJob.Location = new System.Drawing.Point(3, 3);
            this.pnAddJob.Name = "pnAddJob";
            this.pnAddJob.Size = new System.Drawing.Size(966, 44);
            this.pnAddJob.TabIndex = 0;
            // 
            // lbShift
            // 
            this.lbShift.AutoSize = true;
            this.lbShift.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbShift.Location = new System.Drawing.Point(304, 8);
            this.lbShift.Name = "lbShift";
            this.lbShift.Size = new System.Drawing.Size(57, 25);
            this.lbShift.TabIndex = 1;
            this.lbShift.Text = "Shift:";
            // 
            // cbbShift
            // 
            this.cbbShift.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbShift.FormattingEnabled = true;
            this.cbbShift.Location = new System.Drawing.Point(114, 3);
            this.cbbShift.Name = "cbbShift";
            this.cbbShift.Size = new System.Drawing.Size(165, 33);
            this.cbbShift.TabIndex = 2;
            // 
            // pnShift
            // 
            this.pnShift.Location = new System.Drawing.Point(288, 3);
            this.pnShift.Name = "pnShift";
            this.pnShift.Size = new System.Drawing.Size(235, 41);
            this.pnShift.TabIndex = 4;
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStatus.Location = new System.Drawing.Point(764, 8);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(74, 25);
            this.lbStatus.TabIndex = 1;
            this.lbStatus.Text = "Status:";
            // 
            // lbRequest
            // 
            this.lbRequest.AutoSize = true;
            this.lbRequest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRequest.Location = new System.Drawing.Point(28, 8);
            this.lbRequest.Name = "lbRequest";
            this.lbRequest.Size = new System.Drawing.Size(90, 25);
            this.lbRequest.TabIndex = 1;
            this.lbRequest.Text = "Request:";
            // 
            // cbAddJob
            // 
            this.cbAddJob.AutoSize = true;
            this.cbAddJob.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAddJob.Location = new System.Drawing.Point(4, 11);
            this.cbAddJob.Name = "cbAddJob";
            this.cbAddJob.Size = new System.Drawing.Size(18, 17);
            this.cbAddJob.TabIndex = 0;
            this.cbAddJob.UseVisualStyleBackColor = true;
            // 
            // pnStatus
            // 
            this.pnStatus.Controls.Add(this.cbAddJob);
            this.pnStatus.Controls.Add(this.cbbShift);
            this.pnStatus.Controls.Add(this.lbRequest);
            this.pnStatus.Location = new System.Drawing.Point(0, 0);
            this.pnStatus.Name = "pnStatus";
            this.pnStatus.Size = new System.Drawing.Size(298, 44);
            this.pnStatus.TabIndex = 3;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(367, 5);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(165, 33);
            this.comboBox1.TabIndex = 2;
            // 
            // lbWaiting
            // 
            this.lbWaiting.AutoSize = true;
            this.lbWaiting.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lbWaiting.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWaiting.Location = new System.Drawing.Point(844, 8);
            this.lbWaiting.Name = "lbWaiting";
            this.lbWaiting.Size = new System.Drawing.Size(93, 25);
            this.lbWaiting.TabIndex = 1;
            this.lbWaiting.Text = "Waiting...";
            // 
            // btnAddJob
            // 
            this.btnAddJob.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddJob.Location = new System.Drawing.Point(558, 5);
            this.btnAddJob.Name = "btnAddJob";
            this.btnAddJob.Size = new System.Drawing.Size(82, 31);
            this.btnAddJob.TabIndex = 4;
            this.btnAddJob.Text = "Add";
            this.btnAddJob.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(646, 5);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(82, 31);
            this.btnEdit.TabIndex = 4;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // UserControlAJob
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnAddJob);
            this.Controls.Add(this.pnShift);
            this.Name = "UserControlAJob";
            this.Size = new System.Drawing.Size(972, 52);
            this.pnAddJob.ResumeLayout(false);
            this.pnAddJob.PerformLayout();
            this.pnStatus.ResumeLayout(false);
            this.pnStatus.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnAddJob;
        private System.Windows.Forms.ComboBox cbbShift;
        private System.Windows.Forms.Label lbShift;
        private System.Windows.Forms.Panel pnShift;
        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAddJob;
        private System.Windows.Forms.Label lbWaiting;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Panel pnStatus;
        private System.Windows.Forms.CheckBox cbAddJob;
        private System.Windows.Forms.Label lbRequest;
    }
}
