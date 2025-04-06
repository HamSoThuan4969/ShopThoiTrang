using MaterialSkin;
using MaterialSkin.Controls;
using System.Windows.Forms;

namespace GUI
{
    public partial class Form1 : MaterialForm
    {
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
    }
}