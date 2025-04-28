using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class fStepJob : Form
    {
        public fStepJob()
        {
            InitializeComponent();

            LoadMatrixJob();
        }
        void LoadMatrixJob()
        {
            Button oldBtn = new Button() { Width = 0, Height = 0, Location = new Point(-Cons.margin, 0)};

            for (int i = 0; i < Cons.DayOfColumn; i++)
            {
                for (int j = 0; j < Cons.DayOfWeek; j++) 
                { 
                    Button btn = new Button() { Width = Cons.dateButtonWidth 
                        + Cons.margin, Height = Cons.dateButtonHeight};
                    btn.Location = new Point(oldBtn.Location.X + oldBtn.Width + Cons.margin, 
                        oldBtn.Location.Y);

                    pnMatrix.Controls.Add(btn);

                    oldBtn = btn;
                }
                Button oldBtn = new Button() { Width = 0, Height = 0, 
                    Location = new Point(-Cons.margin, oldBtn.Location.Y + Cons.dateButtonHeight)};
            }

        }
    }
}
