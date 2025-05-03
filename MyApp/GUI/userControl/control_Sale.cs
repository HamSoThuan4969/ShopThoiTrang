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
    public partial class control_Sale : UserControl
    {
        private SaleBLL saleBLL = new SaleBLL() ;
        private Sale_DetailBLL sale_DetailBLL = new Sale_DetailBLL();
        public control_Sale()
        {
            InitializeComponent();
            LoadSaleList(); // gọi hàm lấy danh sách khách hàng lên form
            LoadSale_Detail(); // gọi hàm lấy danh sách Sale_Detail lên form
            AddCheckboxColumn(); // thêm cột checkbox vào DataGridView
            dataGridView_Sale.CellClick += DataGridView_Sale_CellClick;

        }
        private void LoadSaleList()
        {
            try
            {
                List<SaleDTO> customers = saleBLL.GetAllSale() ;
                dataGridView_Sale.DataSource = customers;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải danh sách khách hàng: {ex.Message}");
            }
        }
        private void LoadSale_Detail()
        {
            // lấy danh sách từ bảng Sale_Detail
            try
            {
                List<Sale_DetailDTO> saleDetails = sale_DetailBLL.GetSale_DetailDAL();
            }catch(Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải danh sách Sale_Detail: {ex.Message}");
            }
        }
        private void AddCheckboxColumn()
        {
            DataGridViewCheckBoxColumn checkboxColumn = new DataGridViewCheckBoxColumn
            {
                Name = "Select",
                HeaderText = "Chọn",
                Width = 50
            };
        }
        private void DataGridView_Sale_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView_Sale.Rows.Count)
            {
                DataGridViewRow selectedRow = dataGridView_Sale.Rows[e.RowIndex];
                string idSale = selectedRow.Cells["Id"].Value?.ToString();
                // Hiển thị dữ liệu từ dòng đã chọn vào các TextBox ( thông tin được lấy từ bảng Sale  không phải từ dòng hiện tại))
                SaleDTO saleDTO = saleBLL.GetSaleByIdBLL(idSale); // tài dữ liệu lên 
                tbIdSale.Text = saleDTO.Id;
                tbDisplayName.Text = saleDTO.DisplayName;
                cbbTypeSale.Text = saleDTO.TypeSale;
                dtStartDate.Value = saleDTO.StartDate;
                dtEndDate.Value = saleDTO.EndDate;

                // tải thông tin Sale_Detail lên
                Sale_DetailDTO saleDetailDTO = sale_DetailBLL.GetSale_DetailByIdBLL(idSale);

                tbDiscount.Text = saleDetailDTO.Discount;
                tbConditionValue.Text = saleDetailDTO.ConditionValue;
                tbDescription.Text = saleDetailDTO.Description;
                tbIdSale_Detail.Text = saleDetailDTO.IdSale;
            }
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            try
            {
                // Tạo đối tượng Sale
                SaleDTO sale = new SaleDTO
                {
                    Id = tbIdSale.Text.Trim(),
                    DisplayName = tbDisplayName.Text.Trim(),
                    TypeSale = cbbTypeSale.SelectedItem.ToString(),
                    StartDate =dtStartDate.Value,
                    EndDate = dtEndDate.Value
                };

                // Tạo đối tượng Sale_Detail
                Sale_DetailDTO saleDetail = new Sale_DetailDTO
                {
                    IdSale = tbIdSale_Detail.Text.Trim(), // Liên kết với Sale.Id
                    Discount = tbDiscount.Text.Trim(),
                    ConditionValue = tbConditionValue.Text.Trim(),
                    Description = tbDescription.Text.Trim()

                };

                // Gọi BLL để thêm dữ liệu
                saleBLL.AddSale(sale);
                sale_DetailBLL.AddSale_Detail(saleDetail);

                MessageBox.Show("Thêm Sale thành công!");
                LoadSaleList(); // Tải lại danh sách sau khi thêm
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi thêm Sale: {ex.Message}");
            }
        }

        private void btDelete_Click(object sender, EventArgs e)
        {

        }

        private void btUpdate_Click(object sender, EventArgs e)
        {

        }

        private void btClear_Click(object sender, EventArgs e)
        {

        }

        private void btExportExcel_Click(object sender, EventArgs e)
        {

        }
    }
}
