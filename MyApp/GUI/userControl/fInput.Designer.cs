namespace GUI.userControl
{
    partial class fInput
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
            this.btAdd = new System.Windows.Forms.Button();
            this.pnContainer_Input = new System.Windows.Forms.FlowLayoutPanel();
            this.btDelete = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.bttInput = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(99, 18);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(100, 33);
            this.btAdd.TabIndex = 0;
            this.btAdd.Text = "Add";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // pnContainer_Input
            // 
            this.pnContainer_Input.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnContainer_Input.AutoScroll = true;
            this.pnContainer_Input.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnContainer_Input.Location = new System.Drawing.Point(31, 88);
            this.pnContainer_Input.Name = "pnContainer_Input";
            this.pnContainer_Input.Padding = new System.Windows.Forms.Padding(2, 5, 2, 2);
            this.pnContainer_Input.Size = new System.Drawing.Size(866, 434);
            this.pnContainer_Input.TabIndex = 1;
            // 
            // btDelete
            // 
            this.btDelete.Location = new System.Drawing.Point(244, 18);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(100, 33);
            this.btDelete.TabIndex = 2;
            this.btDelete.Text = "Delete";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(427, 18);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 33);
            this.button1.TabIndex = 3;
            this.button1.Text = "Supplier";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // bttInput
            // 
            this.bttInput.Location = new System.Drawing.Point(927, 18);
            this.bttInput.Name = "bttInput";
            this.bttInput.Size = new System.Drawing.Size(100, 33);
            this.bttInput.TabIndex = 4;
            this.bttInput.Text = "Input_value";
            this.bttInput.UseVisualStyleBackColor = true;
            this.bttInput.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(564, 18);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 33);
            this.button3.TabIndex = 5;
            this.button3.Text = "Kho";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // fInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.button3);
            this.Controls.Add(this.bttInput);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.pnContainer_Input);
            this.Controls.Add(this.btAdd);
            this.Name = "fInput";
            this.Size = new System.Drawing.Size(1218, 548);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.FlowLayoutPanel pnContainer_Input;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button bttInput;
        private System.Windows.Forms.Button button3;
    }
}
