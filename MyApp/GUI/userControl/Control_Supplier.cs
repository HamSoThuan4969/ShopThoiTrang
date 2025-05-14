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
    public partial class Control_Supplier : UserControl
    {
        private SupplierBLL supplierBLL = new SupplierBLL();
        public Control_Supplier()
        {
            InitializeComponent();
            LoadSupplier();
            AddCheckboxColumn(); // thêm cột checkbox vào datagridview
            InitializeComboBox(); // khởi tạo combobox
            dataGridView_Supplier.CellClick += DataGridView_Supplier_CellClick;
        }

        private void LoadSupplier()
        {
            try
            {
                List<SupplierDTO> suppliers = supplierBLL.GetAllSupplier();
                dataGridView_Supplier.DataSource = suppliers;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading suppliers: " + ex.Message);
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
            dataGridView_Supplier.Columns.Insert(0, checkboxColumn);
        }
        private void InitializeComboBox()
        {
            try
            {
                // Gọi BLL để lấy dữ liệu không trùng lặp
                List<string> typeObject = supplierBLL.GetTypeObject();

                // Gắn dữ liệu vào ComboBox
                cbbTypeObject.Items.Clear();
                cbbTypeObject.Items.AddRange(typeObject.ToArray());
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi load dữ liệu vào ComboBox: {ex.Message}");
            }
        }
        private void DataGridView_Supplier_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView_Supplier.Rows.Count) // Kiểm tra nếu là cột checkbox
            {
                DataGridViewRow selecteRow = dataGridView_Supplier.Rows[e.RowIndex];
                
                // hiểm thị dữ liệu supplier qua các đối tượng trên giao diện
                tbDisplayName.Text = selecteRow.Cells["DisplayName"].Value.ToString();
                tbAddress.Text = selecteRow.Cells["Address"].Value.ToString();
                tbPhone.Text = selecteRow.Cells["Phone"].Value.ToString();
                tbEmail.Text = selecteRow.Cells["Email"].Value.ToString();
                tbAbbreviation.Text = selecteRow.Cells["Abbreviation"].Value.ToString();
                tbId.Text = selecteRow.Cells["Id"].Value.ToString();
                cbbTypeObject.Text = selecteRow.Cells["TypeObject"].Value.ToString();
                tbMoreInfor.Text = selecteRow.Cells["MoreInfor"].Value.ToString();

            }
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            try
            {
                SupplierDTO supplierDTO = new SupplierDTO
                {
                    DisplayName = tbDisplayName.Text,
                    Address = tbAddress.Text,
                    Phone = tbPhone.Text,
                    Email = tbEmail.Text,
                    Abbreviation = tbAbbreviation.Text,
                    TypeObject = cbbTypeObject.Text,
                    ContractDate = DateTime.Now,
                    MoreInfor = tbMoreInfor.Text,
                };
                supplierBLL.AddSupplier(supplierDTO);
                MessageBox.Show("Thêm nhà cung cấp thành công");
                LoadSupplier(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding supplier GUI: " + ex.Message);
            }
        }

        private void Control_Supplier_Load(object sender, EventArgs e)
        {

        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            try
            {
                List<string> selectedIds = new List<string>();
                foreach (DataGridViewRow row in dataGridView_Supplier.Rows)
                {
                    // kiểm tra có tick checkbox chưa 
                    if (Convert.ToBoolean(row.Cells["Select"].Value) == true)
                    {
                        selectedIds.Add(row.Cells["Id"].Value.ToString());
                    }
                }
                if (selectedIds.Count > 0)
                {
                    supplierBLL.DeleteSupplier(selectedIds);
                    MessageBox.Show("Xóa nhà cung cấp thành công");
                    LoadSupplier();
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn ít nhất một nhà cung cấp để xóa.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting supplier: " + ex.Message);
            }
        }

        private void btClear_Click(object sender, EventArgs e)
        {
            // làm trống 
            tbDisplayName.Clear();
            tbAddress.Clear();
            tbPhone.Clear();
            tbEmail.Clear();
            tbAbbreviation.Clear();
            tbId.Clear();
            cbbTypeObject.SelectedIndex = -1;
            tbMoreInfor.Clear();

        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                // lấy dữ liệu thay đổi 
                SupplierDTO supplierDTO = new SupplierDTO
                {
                    Id = tbId.Text,
                    DisplayName = tbDisplayName.Text,
                    Address = tbAddress.Text,
                    Phone = tbPhone.Text,
                    Email = tbEmail.Text,
                    Abbreviation = tbAbbreviation.Text,
                    TypeObject = cbbTypeObject.Text,
                    ContractDate = DateTime.Now,
                    MoreInfor = tbMoreInfor.Text,
                };
                // gọi hàm BLL để sửa thông tin nhà cung cấp
                supplierBLL.UpdateSupplier(new List<SupplierDTO> { supplierDTO });
                MessageBox.Show("Cập nhật nhà cung cấp thành công");
                LoadSupplier();

            }catch(Exception ex)
            {
                MessageBox.Show("Error updating supplier GUI: " + ex.Message);
            }
        }

        private void btExportExcel_Click(object sender, EventArgs e)
        {
            try
            {
                // Gọi BLL để lấy toàn bộ dữ liệu khách hàng
                List<SupplierDTO> suppliers = supplierBLL.GetAllSupplier();

                // Hiển thị hộp thoại lưu file
                SaveFileDialog saveFileDialog = new SaveFileDialog
                {
                    Filter = "Excel Files|*.xlsx",
                    Title = "Lưu file Excel",
                    FileName = "DanhSachSupplier.xlsx"
                };

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Gọi lớp ExcelExporter để xuất dữ liệu
                    ExcelExporter exporter = new ExcelExporter();
                    exporter.ExportToExcel(suppliers, saveFileDialog.FileName, "Suppliers");

                    MessageBox.Show("Xuất dữ liệu ra file Excel thành công!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi xuất dữ liệu ra Excel: {ex.Message}");
            }
        }
    }
}
