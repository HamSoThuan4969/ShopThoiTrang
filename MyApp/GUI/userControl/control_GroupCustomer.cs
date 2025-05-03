using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.userControl
{
    public partial class control_GroupCustomer : UserControl
    {
        private GroupCustomerBLL groupCustomerBLL = new GroupCustomerBLL();
        public control_GroupCustomer()
        {
            InitializeComponent();
            LoadCustomerList(); // gọi hàm lấy danh sách khách hàng lên form 
            AddCheckboxColumn(); // Thêm cột checkbox vào DataGridView
                                 // Đăng ký sự kiện CellClick cho DataGridView
            dataGridView_GroupCustomer.CellClick += DataGridView_GroupCustomer_CellClick;
            btUpdate.Click += btUpdate_Click;

        }

        private void LoadCustomerList()
        {
            try
            {
                List<GroupCustomerDTO> groupCustomers = groupCustomerBLL.GetGroupCustomer();
                dataGridView_GroupCustomer.DataSource = groupCustomers;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải danh sách khách hàng: {ex.Message}");
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
            dataGridView_GroupCustomer.Columns.Insert(0, checkboxColumn);
        }
        private void DataGridView_GroupCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView_GroupCustomer.Rows.Count)
            {
                DataGridViewRow selectedRow = dataGridView_GroupCustomer.Rows[e.RowIndex];

                // Hiển thị dữ liệu từ dòng đã chọn vào các TextBox
                tbId.Text = selectedRow.Cells["Id"].Value?.ToString();
                tbTypeGroup.Text = selectedRow.Cells["TypeGroup"].Value?.ToString();
                tbDisplayName.Text = selectedRow.Cells["DisplayName"].Value?.ToString();

            }
        }
        private void btAdd_Click(object sender, EventArgs e)
        {
            try
            {
                GroupCustomerDTO groupCustomer = new GroupCustomerDTO
                {

                    DisplayName = tbDisplayName.Text.Trim(),
                    TypeGroup = tbTypeGroup.Text.Trim()



                };

                groupCustomerBLL.AddGroupCustomer(groupCustomer);
                MessageBox.Show("Thêm khách hàng thành công!");
                LoadCustomerList();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi thêm khách hàng BLL: {ex.Message}");
            }
        }
        private void btDelete_Click(object sender, EventArgs e)
        {
            try
            {
                List<string> selectedIds = new List<string>();
                foreach (DataGridViewRow row in dataGridView_GroupCustomer.Rows)
                {
                    if (Convert.ToBoolean(row.Cells["Select"].Value))
                    {
                        selectedIds.Add(row.Cells["Id"].Value.ToString());
                    }
                }

                groupCustomerBLL.DeleteGroupCustomer(selectedIds);
                MessageBox.Show("Xóa khách hàng thành công!");
                LoadCustomerList();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi xóa khách hàng: {ex.Message}");
            }
        }
        private void btUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                GroupCustomerDTO groupCustomer = new GroupCustomerDTO
                {
                    Id = tbId.Text.Trim(),
                    DisplayName = tbDisplayName.Text.Trim(),
                    TypeGroup = tbTypeGroup.Text.Trim()
                };
                groupCustomerBLL.UpdateGroupCustomer(new List<GroupCustomerDTO> { groupCustomer });
                MessageBox.Show("Cập nhật khách hàng thành công!");
                LoadCustomerList();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi cập nhật khách hàng: {ex.Message}");
            }






        }

        private void btClear_Click(object sender, EventArgs e)
        {
            tbId.Text = "";
            tbDisplayName.Text = "";
            tbTypeGroup.Text = "";

        }

        private void btExportExcel_Click(object sender, EventArgs e)
        {
            try
            {
                // Gọi BLL để lấy toàn bộ dữ liệu nhóm khách hàng
                List<GroupCustomerDTO> groupCustomers = groupCustomerBLL.GetGroupCustomer();

                // Hiển thị hộp thoại lưu file
                SaveFileDialog saveFileDialog = new SaveFileDialog
                {
                    Filter = "Excel Files|*.xlsx",
                    Title = "Lưu file Excel",
                    FileName = "DanhSachNhomKhachHang.xlsx"
                };

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Gọi lớp ExcelExporter để xuất dữ liệu
                    ExcelExporter exporter = new ExcelExporter();
                    exporter.ExportToExcel(groupCustomers, saveFileDialog.FileName, "GroupCustomers");

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
