namespace GUI
{
    partial class fStepJob
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnToday = new System.Windows.Forms.Button();
            this.dtpkJob = new System.Windows.Forms.DateTimePicker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnMatrix = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnPre = new System.Windows.Forms.Button();
            this.btnMon = new System.Windows.Forms.Button();
            this.btnTues = new System.Windows.Forms.Button();
            this.btnWed = new System.Windows.Forms.Button();
            this.btnThurs = new System.Windows.Forms.Button();
            this.btnSun = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnFri = new System.Windows.Forms.Button();
            this.btnSat = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(934, 539);
            this.panel1.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnToday);
            this.panel3.Controls.Add(this.dtpkJob);
            this.panel3.Location = new System.Drawing.Point(3, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(926, 37);
            this.panel3.TabIndex = 1;
            // 
            // btnToday
            // 
            this.btnToday.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnToday.Location = new System.Drawing.Point(554, 3);
            this.btnToday.Name = "btnToday";
            this.btnToday.Size = new System.Drawing.Size(75, 29);
            this.btnToday.TabIndex = 1;
            this.btnToday.Text = "Today";
            this.btnToday.UseVisualStyleBackColor = false;
            this.btnToday.Click += new System.EventHandler(this.btnToday_Click);
            // 
            // dtpkJob
            // 
            this.dtpkJob.Location = new System.Drawing.Point(290, 6);
            this.dtpkJob.Name = "dtpkJob";
            this.dtpkJob.Size = new System.Drawing.Size(258, 22);
            this.dtpkJob.TabIndex = 0;
            this.dtpkJob.ValueChanged += new System.EventHandler(this.dtpkJob_ValueChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pnMatrix);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Location = new System.Drawing.Point(3, 48);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(926, 488);
            this.panel2.TabIndex = 0;
            // 
            // pnMatrix
            // 
            this.pnMatrix.Location = new System.Drawing.Point(108, 67);
            this.pnMatrix.Name = "pnMatrix";
            this.pnMatrix.Size = new System.Drawing.Size(713, 418);
            this.pnMatrix.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnThurs);
            this.panel4.Controls.Add(this.btnSat);
            this.panel4.Controls.Add(this.btnNext);
            this.panel4.Controls.Add(this.btnWed);
            this.panel4.Controls.Add(this.btnFri);
            this.panel4.Controls.Add(this.btnSun);
            this.panel4.Controls.Add(this.btnTues);
            this.panel4.Controls.Add(this.btnMon);
            this.panel4.Controls.Add(this.btnPre);
            this.panel4.Location = new System.Drawing.Point(0, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(926, 61);
            this.panel4.TabIndex = 0;
            // 
            // btnPre
            // 
            this.btnPre.Location = new System.Drawing.Point(7, 3);
            this.btnPre.Name = "btnPre";
            this.btnPre.Size = new System.Drawing.Size(97, 55);
            this.btnPre.TabIndex = 0;
            this.btnPre.Text = "Previous";
            this.btnPre.UseVisualStyleBackColor = true;
            this.btnPre.Click += new System.EventHandler(this.btnPre_Click);
            // 
            // btnMon
            // 
            this.btnMon.Location = new System.Drawing.Point(108, 3);
            this.btnMon.Name = "btnMon";
            this.btnMon.Size = new System.Drawing.Size(97, 55);
            this.btnMon.TabIndex = 0;
            this.btnMon.Text = "Monday";
            this.btnMon.UseVisualStyleBackColor = true;
            // 
            // btnTues
            // 
            this.btnTues.Location = new System.Drawing.Point(209, 3);
            this.btnTues.Name = "btnTues";
            this.btnTues.Size = new System.Drawing.Size(97, 55);
            this.btnTues.TabIndex = 0;
            this.btnTues.Text = "Tuesday";
            this.btnTues.UseVisualStyleBackColor = true;
            // 
            // btnWed
            // 
            this.btnWed.Location = new System.Drawing.Point(312, 3);
            this.btnWed.Name = "btnWed";
            this.btnWed.Size = new System.Drawing.Size(97, 55);
            this.btnWed.TabIndex = 0;
            this.btnWed.Text = "Wednesday";
            this.btnWed.UseVisualStyleBackColor = true;
            // 
            // btnThurs
            // 
            this.btnThurs.Location = new System.Drawing.Point(415, 3);
            this.btnThurs.Name = "btnThurs";
            this.btnThurs.Size = new System.Drawing.Size(97, 55);
            this.btnThurs.TabIndex = 0;
            this.btnThurs.Text = "Thursday";
            this.btnThurs.UseVisualStyleBackColor = true;
            // 
            // btnSun
            // 
            this.btnSun.Location = new System.Drawing.Point(724, 3);
            this.btnSun.Name = "btnSun";
            this.btnSun.Size = new System.Drawing.Size(97, 55);
            this.btnSun.TabIndex = 0;
            this.btnSun.Text = "Sunday";
            this.btnSun.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(827, 3);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(97, 55);
            this.btnNext.TabIndex = 0;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnFri
            // 
            this.btnFri.Location = new System.Drawing.Point(518, 3);
            this.btnFri.Name = "btnFri";
            this.btnFri.Size = new System.Drawing.Size(97, 55);
            this.btnFri.TabIndex = 0;
            this.btnFri.Text = "Friday";
            this.btnFri.UseVisualStyleBackColor = true;
            // 
            // btnSat
            // 
            this.btnSat.Location = new System.Drawing.Point(621, 3);
            this.btnSat.Name = "btnSat";
            this.btnSat.Size = new System.Drawing.Size(97, 55);
            this.btnSat.TabIndex = 0;
            this.btnSat.Text = "Saturday";
            this.btnSat.UseVisualStyleBackColor = true;
            // 
            // fStepJob
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 554);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "fStepJob";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fStepJob";
            this.Load += new System.EventHandler(this.fStepJob_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnToday;
        private System.Windows.Forms.DateTimePicker dtpkJob;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnMatrix;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnPre;
        private System.Windows.Forms.Button btnThurs;
        private System.Windows.Forms.Button btnSat;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnWed;
        private System.Windows.Forms.Button btnFri;
        private System.Windows.Forms.Button btnSun;
        private System.Windows.Forms.Button btnTues;
        private System.Windows.Forms.Button btnMon;
    }
}