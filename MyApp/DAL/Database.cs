using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

using System.Data;

namespace DAL
{
    public class SqlConnectionData
    {
        public static SqlConnection Connect()
        {
            string strcon = @"Data Source=KUROBA\SQLSERVER_DEV;Initial Catalog=ShopThoiTrang;Integrated Security=True";
            SqlConnection conn = new SqlConnection(strcon); // khởi tạo connect 
            return conn;

        }
    }
    // tạo chuỗi kết nối đến cơ sở dữ liệu :
    public class DatabaseAccess
    {
        public static string CheckLogin(UsersDTO users)
        {
            string user = null;
            // hàm connect cơ sở dữ liệu : 
            SqlConnection conn = SqlConnectionData.Connect();
            conn.Open(); // mở kết nối nè 
            SqlCommand command = new SqlCommand("CheckLogin", conn);
            command.CommandType = CommandType.StoredProcedure;
            // truyền Paramester vào : 
            command.Parameters.AddWithValue("@user", users.UserName);
            command.Parameters.AddWithValue("@pass", users.Password);
            // kiểm tra quyền : ...... đợi làm 
            command.Connection = conn;
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows) // có cột hàng _ thông tin đó không 
            {
                while(reader.Read())
                {
                    user = reader.GetString(0); // cái này chưa tối ưu 
                    return user;
                }
                reader.Close();
                conn.Close();
            }else
            {
                return "Tai khoan khong ton tai!!!";
            }
            return user;
                
        }
    }

}
