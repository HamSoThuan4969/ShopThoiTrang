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
using GUI.userControl;
namespace GUI

    {
        public partial class fManager : Form
       
        {
            private CustomerBLL customerBLL= new CustomerBLL(); // tạo đối tượng BLL để gọi hàm lấy danh sách khách hàng
            private GroupCustomerBLL groupCustomerBLL = new GroupCustomerBLL(); // tạo đối tượng BLL để gọi hàm lấy danh sách nhóm khách hàng


        public fManager()
            {
                InitializeComponent();
            // Thêm UserControl vào Form
          




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

           

            private void tvFind_TextChanged(object sender, EventArgs e)
            {

            }

            

            private void qUảnLýNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
            {

            }

            private void tbAddress_TextChanged(object sender, EventArgs e)
            {

            }

           

        private void tbMoreInfor_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnMain.Controls.Clear();              // Dọn panel
            var uc = new control_Customer();          // Tạo UC mới
            uc.Dock = DockStyle.Fill;                 // Căng full panel
            pnMain.Controls.Add(uc);
        }

        private void groupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnMain.Controls.Clear();              // Dọn panel
            var uc = new control_GroupCustomer();          // Tạo UC mới
            uc.Dock = DockStyle.Fill;                 // Căng full panel
            pnMain.Controls.Add(uc);
        }

        private void quảnLýKhuyếnMãiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnMain.Controls.Clear();              // Dọn panel
            var uc = new control_Sale();          // Tạo UC mới
            uc.Dock = DockStyle.Fill;                 // Căng full panel
            pnMain.Controls.Add(uc);
        }

        private void nhậpKhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnMain.Controls.Clear();              // Dọn panel
            var uc = new fInput();          // Tạo UC mới
            uc.Dock = DockStyle.Fill;                 // Căng full panel
            pnMain.Controls.Add(uc);
        }
    }   
    

    }
    



