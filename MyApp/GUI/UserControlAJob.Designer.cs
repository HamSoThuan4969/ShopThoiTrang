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
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAddJob = new System.Windows.Forms.Button();
            this.lbWaiting = new System.Windows.Forms.Label();
            this.lbStatus = new System.Windows.Forms.Label();
            this.cbbShift = new System.Windows.Forms.ComboBox();
            this.lbShift = new System.Windows.Forms.Label();
            this.pnStatus = new System.Windows.Forms.Panel();
            this.cbAddJob = new System.Windows.Forms.CheckBox();
            this.cbbRequest = new System.Windows.Forms.ComboBox();
            this.lbRequest = new System.Windows.Forms.Label();
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
            this.pnAddJob.Controls.Add(this.cbbShift);
            this.pnAddJob.Controls.Add(this.lbShift);
            this.pnAddJob.Controls.Add(this.pnStatus);
            this.pnAddJob.Location = new System.Drawing.Point(3, 3);
            this.pnAddJob.Name = "pnAddJob";
            this.pnAddJob.Size = new System.Drawing.Size(966, 44);
            this.pnAddJob.TabIndex = 1;
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
            this.btnAddJob.Click += new System.EventHandler(this.btnAddJob_Click);
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
            // cbbShift
            // 
            this.cbbShift.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbShift.FormattingEnabled = true;
            this.cbbShift.Location = new System.Drawing.Point(367, 3);
            this.cbbShift.Name = "cbbShift";
            this.cbbShift.Size = new System.Drawing.Size(165, 33);
            this.cbbShift.TabIndex = 2;
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
            // pnStatus
            // 
            this.pnStatus.Controls.Add(this.cbAddJob);
            this.pnStatus.Controls.Add(this.cbbRequest);
            this.pnStatus.Controls.Add(this.lbRequest);
            this.pnStatus.Location = new System.Drawing.Point(0, 0);
            this.pnStatus.Name = "pnStatus";
            this.pnStatus.Size = new System.Drawing.Size(298, 44);
            this.pnStatus.TabIndex = 3;
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
            // cbbRequest
            // 
            this.cbbRequest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbRequest.FormattingEnabled = true;
            this.cbbRequest.Location = new System.Drawing.Point(187, 5);
            this.cbbRequest.Name = "cbbRequest";
            this.cbbRequest.Size = new System.Drawing.Size(108, 33);
            this.cbbRequest.TabIndex = 2;
            // 
            // lbRequest
            // 
            this.lbRequest.AutoSize = true;
            this.lbRequest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRequest.Location = new System.Drawing.Point(91, 8);
            this.lbRequest.Name = "lbRequest";
            this.lbRequest.Size = new System.Drawing.Size(90, 25);
            this.lbRequest.TabIndex = 1;
            this.lbRequest.Text = "Request:";
            // 
            // UserControlAJob
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnAddJob);
            this.Name = "UserControlAJob";
            this.Size = new System.Drawing.Size(973, 49);
            this.pnAddJob.ResumeLayout(false);
            this.pnAddJob.PerformLayout();
            this.pnStatus.ResumeLayout(false);
            this.pnStatus.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnAddJob;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAddJob;
        private System.Windows.Forms.Label lbWaiting;
        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.ComboBox cbbShift;
        private System.Windows.Forms.Label lbShift;
        private System.Windows.Forms.Panel pnStatus;
        private System.Windows.Forms.CheckBox cbAddJob;
        private System.Windows.Forms.ComboBox cbbRequest;
        private System.Windows.Forms.Label lbRequest;
    }
}
