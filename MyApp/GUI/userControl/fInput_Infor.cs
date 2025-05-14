using BLL;
using DTO;
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
        private SupplierBLL supplierBLL = new SupplierBLL(); // Khởi tạo BLL để lấy dữ liệu nhà cung cấp
        public string DisplayName_Object => tbDisplayName_Object.Text; // Tên hiển thị của đối tượng
        public int Quantity => (int)nbQuantity.Value; // Lấy số lượng từ NumericUpDown
        public int InputPrice => int.Parse(tbPrice_Input.Text); // Giá nhập
        public int OutputPrice => int.Parse(tbPrice_Output.Text); // Giá bán
        public string IdSupplier => cbbSupplier.SelectedValue.ToString(); // Lấy ID nhà cung cấp từ ComboBox
        public string Supplier => cbbSupplier.Text; // ID nhập

        public fInput_Infor()
        {
            InitializeComponent();
            InitializeComboBox();



        }
        private void InitializeComboBox()
        {
            try
            {
                // Gọi BLL để lấy dữ liệu từ cơ sở dữ liệu
                List<SupplierDTO> suppliers = supplierBLL.GetAllSupplier(); // Lấy toàn bộ dữ liệu nhà cung cấp

                // Chuyển danh sách nhà cung cấp thành DataTable hoặc danh sách đối tượng
                DataTable comboBoxData = new DataTable();
                comboBoxData.Columns.Add("DisplayName", typeof(string)); // Cột hiển thị
                comboBoxData.Columns.Add("Id", typeof(string)); // Cột giá trị (ẩn)

                foreach (var supplier in suppliers)
                {
                    comboBoxData.Rows.Add(supplier.DisplayName, supplier.Id); // Thêm dữ liệu
                }

                // Gắn dữ liệu vào ComboBox
                cbbSupplier.DataSource = comboBoxData;
                cbbSupplier.DisplayMember = "DisplayName"; // Hiển thị cột TypeObject
                cbbSupplier.ValueMember = "Id"; // Giá trị sẽ là cột Id
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi load dữ liệu vào ComboBox: {ex.Message}");
            }
        }
    }
}
