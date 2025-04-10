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
        public string AddUser(UsersDTO users)
        {
            using(SqlConnection conn = GetConnection()) // sử dụng lệnh using để tự động kết nối
            {
                try
                {
                    conn.Open(); // mở kết nối
                    using (SqlCommand cmd = new SqlCommand("AddUsers", conn))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure; // sử dụng lệnh stored procedure
                        // thêm các tham số vào 
                        cmd.Parameters.AddWithValue("@DisplayName", users.DisplayName);
                        cmd.Parameters.AddWithValue("@UserName", users.UserName);
                        cmd.Parameters.AddWithValue("@Password", users.Password);
                        cmd.Parameters.AddWithValue("@IdUserRole", users.IdUserRole);

                        int rowAffected = cmd.ExecuteNonQuery(); // trả số dòng bị ảnh hưởng 
                        if (rowAffected > 0) // nếu có dòng bị ảnh hưởng thì trả về thông báo thành công
                        {
                            return " User added successfully @_@";
                        }
                        else // nếu không có dòng bị ảnh hưởng thì trả về thông báo thất bại
                        {
                            return "User added failed ;(((";
                        }
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
    }
}
