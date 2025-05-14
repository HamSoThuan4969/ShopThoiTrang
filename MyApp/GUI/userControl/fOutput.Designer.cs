namespace GUI.userControl
{
    partial class fOutput
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.btDelete = new System.Windows.Forms.Button();
            this.btAdd = new System.Windows.Forms.Button();
            this.pnContainer = new System.Windows.Forms.Panel();
            this.btInPut = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btInPut);
            this.panel2.Controls.Add(this.btDelete);
            this.panel2.Controls.Add(this.btAdd);
            this.panel2.Location = new System.Drawing.Point(21, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(644, 68);
            this.panel2.TabIndex = 4;
            // 
            // btDelete
            // 
            this.btDelete.Location = new System.Drawing.Point(126, 14);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(98, 33);
            this.btDelete.TabIndex = 1;
            this.btDelete.Text = "Delete";
            this.btDelete.UseVisualStyleBackColor = true;
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(25, 14);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(84, 33);
            this.btAdd.TabIndex = 0;
            this.btAdd.Text = "Add";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // pnContainer
            // 
            this.pnContainer.AutoScroll = true;
            this.pnContainer.Location = new System.Drawing.Point(21, 99);
            this.pnContainer.Name = "pnContainer";
            this.pnContainer.Size = new System.Drawing.Size(1158, 448);
            this.pnContainer.TabIndex = 5;
            // 
            // btInPut
            // 
            this.btInPut.Location = new System.Drawing.Point(253, 14);
            this.btInPut.Name = "btInPut";
            this.btInPut.Size = new System.Drawing.Size(98, 33);
            this.btInPut.TabIndex = 6;
            this.btInPut.Text = "Input";
            this.btInPut.UseVisualStyleBackColor = true;
            this.btInPut.Click += new System.EventHandler(this.btInPut_Click);
            // 
            // fOutput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnContainer);
            this.Controls.Add(this.panel2);
            this.Name = "fOutput";
            this.Size = new System.Drawing.Size(1220, 550);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Panel pnContainer;
        private System.Windows.Forms.Button btInPut;
    }
}
