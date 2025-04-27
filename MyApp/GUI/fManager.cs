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
    namespace GUI
    {
        public partial class fManager : Form
       
        {
            private CustomerBLL customerBLL= new CustomerBLL(); // tạo đối tượng BLL để gọi hàm lấy danh sách khách hàng
        

            public fManager()
            {
                InitializeComponent();
                LoadCustomerList(); // gọi hàm lấy danh sách khách hàng lên form 
                AddCheckboxColumn(); // Thêm cột checkbox vào DataGridView
                // Đăng ký sự kiện CellClick cho DataGridView
            dataGridView_Customer.CellClick += dataGridView_Customer_CellClick;
            btUpdate.Click += btUpdate_Click;



            }
            private void LoadCustomerList()
            {
                try
                {
                    List<CustomerDTO> customers = customerBLL.GetCustomerDALs();
                    dataGridView_Customer.DataSource = customers;
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
                dataGridView_Customer.Columns.Insert(0, checkboxColumn);
            }

            private void btCustomer_Click(object sender, EventArgs e)
            {

            }

            private void fManager_Load(object sender, EventArgs e)
            {

            }

            private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
            {

            }

            private void materialContextMenuStrip1_Layout(object sender, LayoutEventArgs e)
            {

            }

            private void materialContextMenuStrip2_Opening(object sender, CancelEventArgs e)
            {

            }

            private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
            {

            }

            private void Add_Customer_Click(object sender, EventArgs e)
            {
                try
                {
                    // Thu thập dữ liệu từ TextBox
                    CustomerDTO customer = new CustomerDTO
                    {
                        DisplayName = tbDisplayName.Text.Trim(),
                        Address = tbAddress.Text.Trim(),
                        Phone = tbPhone.Text.Trim(),
                        Email = tbEmail.Text.Trim(),
                        MoreInfor = tbMoreInfor.Text.Trim(),
                        IdGroupCustomer = tbIdGroupCustomer.Text.Trim(),
                        DateContract = DateTime.Now
                    };
                    // Gọi BLL để thêm khách hàng
                    customerBLL.AddCustomer(customer);

                    // Thông báo thành công và làm mới danh sách
                    MessageBox.Show("Thêm khách hàng thành công!");
                    LoadCustomerList();

                } catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi thêm khách hàng: {ex.Message}");

                }
            }

            private void tvFind_TextChanged(object sender, EventArgs e)
            {

            }

            private void btDelete_Click(object sender, EventArgs e)
            {
                try   { 
                // Thu nhận danh sách Id của khách hàng được chọn ( tick)
                List<string> selectIds = new List<string>();
                    foreach (DataGridViewRow row in dataGridView_Customer.Rows)
                    {


                        if (Convert.ToBoolean(row.Cells["Select"].Value))
                        {
                            selectIds.Add(row.Cells["Id"].Value.ToString());
                        }
                    }
                    foreach (var id in selectIds)
                    {
                        Console.WriteLine($"ID được chọn: {id}");
                    }

                    // gọi BLL đế xóa khách hàng 
                    customerBLL.RemoveCustomer(selectIds);

                        // load lại danh sách khách hàng sau khi xoá
                        MessageBox.Show("Xóa khách hàng thành công!");
                        LoadCustomerList();
                
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Lỗi khi xóa khách hàng: {ex.Message}");
                    }
            
            }

            private void qUảnLýNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
            {

            }

            private void tbAddress_TextChanged(object sender, EventArgs e)
            {

            }

            private void dataGridView_Customer_CellClick(object sender, DataGridViewCellEventArgs e)
            {
                // Kiểm tra xem người dùng có click vào dòng dữ liệu hợp lệ không
                if(e.RowIndex>=0 && e.RowIndex < dataGridView_Customer.Rows.Count)
            {
                DataGridViewRow selectedRow = dataGridView_Customer.Rows[e.RowIndex];

                // Hiển thị dữ liệu từ dòng đã chọn vào các TextBox
                tbId.Text = selectedRow.Cells["Id"].Value?.ToString();
                tbIdUserRole.Text = selectedRow.Cells["IdUserRole"].Value?.ToString();
                tbDisplayName.Text = selectedRow.Cells["DisplayName"].Value?.ToString();
                tbIdGroupCustomer.Text = selectedRow.Cells["IdGroupCustomer"].Value?.ToString();
                tbEmail.Text = selectedRow.Cells["Email"].Value?.ToString();
                tbAddress.Text = selectedRow.Cells["Address"].Value?.ToString();
                tbPhone.Text = selectedRow.Cells["Phone"].Value?.ToString();
                tbMoreInfor.Text = selectedRow.Cells["MoreInfor"].Value?.ToString();
            }
            }

        private void tbMoreInfor_TextChanged(object sender, EventArgs e)
        {

        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                // thu thấp dữ liệu ở các textbox
                CustomerDTO customer = new CustomerDTO
                {
                    Id = tbId.Text.Trim(),
                    DisplayName = tbDisplayName.Text.Trim(),
                    Address = tbAddress.Text.Trim(),
                    Phone = tbPhone.Text.Trim(),
                    Email = tbEmail.Text.Trim(),
                    MoreInfor = tbMoreInfor.Text.Trim(),
                    IdGroupCustomer = tbIdGroupCustomer.Text.Trim(),
                    DateContract = DateTime.Now, // Giả sử ngày hợp đồng sẽ được cập nhật
                    IdUserRole = int.Parse(tbIdUserRole.Text.Trim()) // IdUserRole không thay đổi
                };
                customerBLL.UpdateCustomerList(new List<CustomerDTO> { customer });
                MessageBox.Show("Cập nhật khách hàng thành công!");
                LoadCustomerList();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi cập nhật khách hàng GUI: {ex.Message}");
            }
        }


        private void btClear_Click_1(object sender, EventArgs e)
        {
            // Làm trống tất cả các TextBox
            tbId.Text = "";
            tbIdUserRole.Text = "";
            tbDisplayName.Text = "";
            tbIdGroupCustomer.Text = "";
            tbEmail.Text = "";
            tbAddress.Text = "";
            tbPhone.Text = "";
            tbMoreInfor.Text = "";
        }

        private void btExportExcel_Click(object sender, EventArgs e)
        {
            try
            {
                // Gọi BLL để lấy toàn bộ dữ liệu khách hàng
                List<CustomerDTO> customers = customerBLL.GetCustomerDALs();

                // Hiển thị hộp thoại lưu file
                SaveFileDialog saveFileDialog = new SaveFileDialog
                {
                    Filter = "Excel Files|*.xlsx",
                    Title = "Lưu file Excel",
                    FileName = "DanhSachKhachHang.xlsx"
                };

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Gọi lớp ExcelExporter để xuất dữ liệu
                    ExcelExporter exporter = new ExcelExporter();
                    exporter.ExportToExcel(customers, saveFileDialog.FileName, "Customers");

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
    



