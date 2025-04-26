using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class fAddUserGUI : Form
    {
        private AddUsersBLL addUsersBLL = new AddUsersBLL(); // tạo đối tượng BLL để gọi hàm thêm người dùng
        private ErrorProvider errorProvider = new ErrorProvider(); // tạo đối tượng ErrorProvider để hiển thị thông báo lỗi

        public fAddUserGUI()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbUserName_Click(object sender, EventArgs e)
        {

        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        

        private void btReset_Click(object sender, EventArgs e)
        {
            tbDisplayName.Clear();
            tbUserName.Clear();
            tbPassword.Clear();
            tbConfirm_Passoword.Clear();
            cbbIdUserRole.SelectedIndex = -1;

            // xóa lỗi hiển thị 
            lblErrorDisplayName.Text = "";
            lblErrorUserName.Text = "";
            lblErrorPassword.Text = ""; ;
            lblErrorConfirmPassword.Text = "";

        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            string displayName = tbDisplayName.Text.Trim();
            string userName = tbUserName.Text.Trim();
            string password = tbPassword.Text.Trim();
            string confirmPassword = tbPassword.Text.Trim();
            string role = cbbIdUserRole.Text; // lấy giá trị từ combobox - chưa chuyển sang thuộc tính IdUsersRole

            int idUserRole = 0;
            if (role == "Admin")
            {
                idUserRole = 1;
            }
            else if (role == "User")
            {
                idUserRole = 2;
            }
            else
            {
                MessageBox.Show("Please select a valid role !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // gọi hàm thêm người dùng ở BLL
            string result = addUsersBLL.Register(displayName, userName, password, idUserRole);
            if (result == "Add user success!")
            {
                MessageBox.Show(result, "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Hiển thị lỗi cụ thể
                MessageBox.Show(result, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void tbDisplayName_Validating(object sender, CancelEventArgs e)
        {
            string displayName = tbDisplayName.Text.Trim(); // Lấy giá trị từ TextBox và loại bỏ khoảng trắng đầu và cuối
            if (string.IsNullOrWhiteSpace(tbDisplayName.Text))
            {
                lblErrorDisplayName.Text = "Please enter display name";

            }
            else if (!Regex.IsMatch(displayName, @"^[a-zA-Z\s]+$")) // Kiểm tra chỉ chứa chữ cái và khoảng trắng)
            {
               
                lblErrorDisplayName.Text = "Display Name must only contain letters and spaces!";
            }
            else
            {
                lblErrorDisplayName.Text = ""; // Nếu không có lỗi, xóa thông báo lỗi
            }
        }

        private void tbUserName_Validating(object sender, CancelEventArgs e)
        {
            string userName = tbUserName.Text.Trim(); // Lấy giá trị từ TextBox và loại bỏ khoảng trắng đầu và cuối
            if (string.IsNullOrWhiteSpace(tbUserName.Text))
            {
                lblErrorUserName.Text = "Please enter user name";
            }
            else if (!Regex.IsMatch(userName, @"^[a-zA-Z0-9]+$")) // Kiểm tra chỉ chứa chữ cái và số
            {
                lblErrorUserName.Text = "User Name must only contain letters and numbers!";
            }
            else
            {
                lblErrorUserName.Text = ""; // Nếu không có lỗi, xóa thông báo lỗi
            }
        }

        private void tbPassword_Validating(object sender, CancelEventArgs e)
        {
            string password = tbPassword.Text.Trim(); // Lấy giá trị từ TextBox và loại bỏ khoảng trắng đầu và cuối
            if (string.IsNullOrWhiteSpace(password))
            {
                lblErrorPassword.Text = "Please enter password";
            }
            else if (password.Length < 6) // Kiểm tra độ dài mật khẩu
            {
                lblErrorPassword.Text = "Password must be at least 6 characters long!";
            }
            else if (!Regex.IsMatch(password, @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)[a-zA-Z\d]{6,}$")) // Kiểm tra mật khẩu có ít nhất một chữ cái viết hoa, một chữ cái viết thường và một số
            {
                lblErrorPassword.Text = "Password must contain at least one uppercase letter, one lowercase letter, and one number!";
            }
            else
            {
                lblErrorPassword.Text = ""; // Nếu không có lỗi, xóa thông báo lỗi
            }
        }

        private void tbConfirm_Passoword_Validating(object sender, CancelEventArgs e)
        {
            string confirmPassword = tbConfirm_Passoword.Text.Trim(); // Lấy giá trị từ TextBox và loại bỏ khoảng trắng đầu và cuối
            string password = tbPassword.Text.Trim(); // Lấy giá trị từ TextBox và loại bỏ khoảng trắng đầu và cuối
            if (string.IsNullOrWhiteSpace(confirmPassword))
            {
                lblErrorConfirmPassword.Text = "Please enter confirm password";
            }
            else if (confirmPassword != password) // Kiểm tra mật khẩu xác nhận có khớp với mật khẩu không
            {
                lblErrorConfirmPassword.Text = "Confirm Password does not match Password!";
            }
            else
            {
                lblErrorConfirmPassword.Text = ""; // Nếu không có lỗi, xóa thông báo lỗi
            }
        }
        private void lblErrorPassword_Click(object sender, EventArgs e)
        {

        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lbUserName_Click_1(object sender, EventArgs e)
        {

        }
    }
}
