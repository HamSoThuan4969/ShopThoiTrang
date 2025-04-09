using MaterialSkin;
using MaterialSkin.Controls;
using System.Windows.Forms;
using DTO;
using System.Security.Principal;
namespace GUI
{
    public partial class Form1 : MaterialForm
    {
        UsersDTO user = new UsersDTO();
        public Form1()
        {
            InitializeComponent();
            InitializeMaterialSkin();
        }

        private void InitializeMaterialSkin()
        {
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Blue600, Primary.Blue700,
                Primary.Blue200, Accent.LightBlue200,
                TextShade.WHITE);
        }


        private void materialRadioButton1_CheckedChanged(object sender, System.EventArgs e)
        {

        }

        private void materialLabel1_Click(object sender, System.EventArgs e)
        {

        }

        private void materialLabel1_Click_1(object sender, System.EventArgs e)
        {

        }

        private void Form1_Load(object sender, System.EventArgs e)
        {

        }

        private void lbX_Click(object sender, System.EventArgs e)
        {

            Application.Exit();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Are you sure you want to exit?", "Titile", MessageBoxButtons.OKCancel) !=System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
            else
            {
                Application.Exit();
            }
        }

        private void btRegister_Click(object sender, System.EventArgs e)
        {
            fRegister f= new fRegister();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void tbShowPassWord_Click(object sender, System.EventArgs e)
        {

        }

        private void btLogin_Click(object sender, System.EventArgs e)
        {
             fRegister f = new fRegister();
            this.Hide();
            f.ShowDialog();
            this.Show();
           
        }
    }
}