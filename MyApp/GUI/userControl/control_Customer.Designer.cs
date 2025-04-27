namespace GUI.userControl
{
    partial class control_Customer
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
            this.tbbsad = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbbsad
            // 
            this.tbbsad.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbbsad.Location = new System.Drawing.Point(132, 117);
            this.tbbsad.Name = "tbbsad";
            this.tbbsad.Size = new System.Drawing.Size(100, 26);
            this.tbbsad.TabIndex = 0;
            // 
            // control_Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tbbsad);
            this.Name = "control_Customer";
            this.Size = new System.Drawing.Size(488, 423);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbbsad;
    }
}
