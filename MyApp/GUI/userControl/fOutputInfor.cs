using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DTO;

namespace GUI.userControl
{
    public partial class fOutputInfor : UserControl
    {
        private CustomerBLL customerBLL = new CustomerBLL(); // Khởi tạo BLL để lấy dữ liệu nhà cung cấp
        private BaseBLL<Sale_DetailDTO> baseBLL = new BaseBLL<Sale_DetailDTO>(); // Khởi tạo BLL để lấy dữ liệu nhà cung cấp
        private Sale_DetailBLL sale_DetailBLL = new Sale_DetailBLL(); // Khởi tạo BLL để lấy dữ liệu nhà cung cấp
        private SetObjectBLL setObjectBLL = new SetObjectBLL(); // Khởi tạo BLL để lấy dữ liệu nhà cung cấp
        private SaleBLL saleBLL = new SaleBLL(); // Khởi tạo BLL để lấy dữ liệu nhà cung cấp
        private OutputInforBLL outputInforBLL = new OutputInforBLL(); // Khởi tạo BLL để lấy dữ liệu nhà cung cấp
        public string DisplayName_Object => tbDisplayName_Object.Text; // Tên hiển thị của đối tượng
        public int Quantity => (int)nbQuantity.Value; // Lấy số lượng từ NumericUpDown
        public int InputPrice => int.Parse(tbPrice.Text); // Giá bán
        public string IdSale => cbbDisplayName_Sale_Detail.SelectedValue.ToString(); // Lấy ID nhà cung cấp từ ComboBox
        public string Sale => cbbDisplayName_Sale_Detail.Text; // tên Supplier
        public string IdSet => cbbSetObject.SelectedValue.ToString(); // Lấy ID nhà cung cấp từ ComboBox
        public string Set => cbbSetObject.Text; // tên Supplier
        public string IdObject => tbIdObject.Text; // Lấy ID nhà cung cấp từ TextBox
        public int Discount => int.Parse(tbDiscount.Text); // Lấy giá trị giảm giá từ TextBox
        public int Total => int.Parse(tbTotal.Text); // Lấy tổng tiền từ TextBox



        public fOutputInfor()
        {
            InitializeComponent();
            InitializeComboBox_Supplier();
            InitializeComboBox_SetObject();
        }
        private void InitializeComboBox_Supplier()
        {
            try
            {
                // Gọi BLL để lấy dữ liệu từ cơ sở dữ liệu
                List<SaleDTO> sale_Details = saleBLL.GetAllSale();// Lấy toàn bộ dữ liệu nhà cung cấp

                // Chuyển danh sách nhà cung cấp thành DataTable hoặc danh sách đối tượng
                DataTable comboBoxData = new DataTable();
                comboBoxData.Columns.Add("DisplayName", typeof(string)); // Cột hiển thị
                comboBoxData.Columns.Add("Id", typeof(string)); // Cột giá trị (ẩn)

                foreach (var sale_Detail in sale_Details)
                {
                    comboBoxData.Rows.Add(sale_Detail.DisplayName, sale_Detail.Id); // Thêm dữ liệu
                }

                // Gắn dữ liệu vào ComboBox
                cbbDisplayName_Sale_Detail.DataSource = comboBoxData;
                cbbDisplayName_Sale_Detail.DisplayMember = "DisplayName"; // Hiển thị cột TypeObject
                cbbDisplayName_Sale_Detail.ValueMember = "Id"; // Giá trị sẽ là cột Id
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi load dữ liệu vào ComboBox: {ex.Message}");
            }
        }
        private void InitializeComboBox_SetObject()
        {
            try
            {
                // Gọi BLL để lấy dữ liệu từ cơ sở dữ liệu
                List<SetObjectDTO> setObjectls = setObjectBLL.GetSetObject();// Lấy toàn bộ dữ liệu nhà cung cấp

                // Chuyển danh sách nhà cung cấp thành DataTable hoặc danh sách đối tượng
                DataTable comboBoxData = new DataTable();
                comboBoxData.Columns.Add("DisplayName", typeof(string)); // Cột hiển thị
                comboBoxData.Columns.Add("Id", typeof(string)); // Cột giá trị (ẩn)

                foreach (var setObjectl in setObjectls)
                {
                    comboBoxData.Rows.Add(setObjectl.DisplayName, setObjectl.Id); // Thêm dữ liệu
                }

                // Gắn dữ liệu vào ComboBox
                cbbSetObject.DataSource = comboBoxData;
                cbbSetObject.DisplayMember = "DisplayName"; // Hiển thị cột TypeObject
                cbbSetObject.ValueMember = "Id"; // Giá trị sẽ là cột Id
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi load dữ liệu vào ComboBox: {ex.Message}");
            }
        }
        // Lấy giá trị cho Discount

       

        private void pnContainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CbbDisplayName_Sale_Detail_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                // Lấy IdSale được chọn
                string selectedIdSale = cbbDisplayName_Sale_Detail.SelectedValue?.ToString();

                if (!string.IsNullOrEmpty(selectedIdSale))
                {
                    // Gọi BaseBLL để lấy Discount tương ứng
                    object discount = baseBLL.GetSingleValue("Sale_Detail", "IdSale", selectedIdSale, "Discount");

                    if (discount != null)
                    {
                        // Hiển thị hoặc gán vào biến dùng tính toán
                        tbDiscount.Text = discount.ToString(); // Ví dụ gán vào TextBox giá
                    }
                    else
                    {
                        tbDiscount.Text  = "0";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lấy Discount: " + ex.Message);
            }
        }
        private void UpdateTotalFromUI()
        {
            if (int.TryParse(tbPrice.Text, out int price))
            {
                int quantity = (int)nbQuantity.Value;
                int total = price * quantity ;
                if (int.TryParse(tbDiscount.Text, out int discount))
                {
                    total -= discount;
                }

                tbTotal.Text = total.ToString("N0"); // Format có dấu phẩy
            }
            else
            {
                tbTotal.Text = "0";
            }
        }
        private void tbPrice_TextChanged(object sender, EventArgs e)
        {
            UpdateTotalFromUI();
        }



    }
}
