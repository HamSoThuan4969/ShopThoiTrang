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
    public partial class fRegister : Form
    {
        public fRegister()
        {
            InitializeComponent();
        }

        private void lbSignIn_Click(object sender, EventArgs e)
        {

        }

        private void fRegister_Load(object sender, EventArgs e)
        {

        }

        private void lbX_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void fSingin_Click(object sender, EventArgs e)
        {
            Form1 loginForm = new Form1();
            loginForm.Show();
            this.Hide();
        }
    }
}
