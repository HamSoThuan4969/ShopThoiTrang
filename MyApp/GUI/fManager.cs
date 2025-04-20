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
                List<CustomerDTO> customer = customerBLL.GetCustomerDALs(); // gọi hàm lấy danh sách khách hàng ở BLL
                dataGridView_Customer.DataSource = customer; // gán danh sách khách hàng vào DataGridView
                                                             // Thêm cột nút "Xem"
                if (!dataGridView_Customer.Columns.Contains("Xem"))
                {
                    DataGridViewButtonColumn btnView = new DataGridViewButtonColumn();
                    btnView.Name = "Xem";
                    btnView.HeaderText = "Xem";
                    btnView.Text = "Xem";
                    btnView.UseColumnTextForButtonValue = true; // Hiển thị chữ "Xem" trên nút
                    dataGridView_Customer.Columns.Add(btnView);
                }

                // Thêm cột nút "Sửa"
                if (!dataGridView_Customer.Columns.Contains("Sửa"))
                {
                    DataGridViewButtonColumn btnEdit = new DataGridViewButtonColumn();
                    btnEdit.Name = "Sửa";
                    btnEdit.HeaderText = "Sửa";
                    btnEdit.Text = "Sửa";
                    btnEdit.UseColumnTextForButtonValue = true; // Hiển thị chữ "Sửa" trên nút
                    dataGridView_Customer.Columns.Add(btnEdit);
                }

                // Thêm cột nút "Xóa"
                if (!dataGridView_Customer.Columns.Contains("Xóa"))
                {
                    DataGridViewButtonColumn btnDelete = new DataGridViewButtonColumn();
                    btnDelete.Name = "Xóa";
                    btnDelete.HeaderText = "Xóa";
                    btnDelete.Text = "Xóa";
                    btnDelete.UseColumnTextForButtonValue = true; // Hiển thị chữ "Xóa" trên nút
                    dataGridView_Customer.Columns.Add(btnDelete);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message); // thông báo lỗi
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

        }
    }
    
}
