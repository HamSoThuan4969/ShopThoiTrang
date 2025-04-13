using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class AddUsersDAL:BaseDAL
    {
        public string AddUserDAL(UsersDTO users)
        {
            using(SqlConnection conn = GetConnection()) // sử dụng lệnh using để tự động kết nối
            {
                try
                {
                    conn.Open(); // mở kết nối
                    using (SqlCommand cmd = new SqlCommand("AddUser", conn))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure; // sử dụng lệnh stored procedure
                        // thêm các tham số vào 
                        cmd.Parameters.AddWithValue("@displayName", users.DisplayName);
                        cmd.Parameters.AddWithValue("@userName", users.UserName);
                        cmd.Parameters.AddWithValue("@password", users.Password);
                        cmd.Parameters.AddWithValue("@idUserRole", users.IdUserRole);

                        int rowAffected = cmd.ExecuteNonQuery(); // trả số dòng bị ảnh hưởng 
                        return rowAffected >0 ? "Add user success!" : "Add user failed!"; // nếu số dòng bị ảnh hưởng >0 thì thêm thành công
                    }
                }
                catch (SqlException ex)
                {
                    // các lỗi được bắt bằng SqlException
                    if (ex.Number == 2627) // lỗi trùng khóa chính
                    {
                        return "UserName already exists !";
                    }
                    else if (ex.Number == 547) // lỗi khóa ngoại
                    {
                        return "IdUserRole not exists !";
                    }
                    else
                    {
                        return "Error: " + ex.Message;
                    }

                }
                    
            }
           
        }
        public bool CheckUserNameExists(string userName)
        {
            using (SqlConnection conn = GetConnection())
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Users WHERE UserName = @userName", conn))
                    {
                        cmd.Parameters.AddWithValue("@userName", userName);
                        int count = (int)cmd.ExecuteScalar(); // Trả về số lượng bản ghi
                        return count > 0; // Trả về true nếu userName tồn tại
                    }
                }
                catch
                {
                    return false; // Xử lý lỗi ngoại lệ (nếu có)
                }
            }
        }
    }
}
