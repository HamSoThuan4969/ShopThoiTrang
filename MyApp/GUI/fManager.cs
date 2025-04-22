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
                                // Đặt DisplayIndex cho các cột hành động
                                // Sắp xếp lại thứ tự các cột

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
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}");
            }
        }   
    
    }
    
}

