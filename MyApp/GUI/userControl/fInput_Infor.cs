using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.userControl
{
    public partial class fInput_Infor : UserControl
    {
        public string DisplayName_Object => tbDisplayName_Object.Text; // Tên hiển thị của đối tượng
        public int Quantity => (int)nbQuantity.Value; // Lấy số lượng từ NumericUpDown
        public int InputPrice => int.Parse(tbPrice_Input.Text); // Giá nhập
        public int OutputPrice => int.Parse(tbPrice_Output.Text); // Giá bán
        public fInput_Infor()
        {
            InitializeComponent();
        }
    }
}
