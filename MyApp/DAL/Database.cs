using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

using System.Data;
using System.Security.Cryptography;

namespace DAL
{
    public class SqlConnectionData
    {
        public static SqlConnection Connect()
        {
            string strcon = @"Data Source=DESKTOP-ME1OU3E\HUYVO;Initial Catalog=ShopThoiTrang;Integrated Security=True;Trust Server Certificate=True";
            SqlConnection conn = new SqlConnection(strcon); // khởi tạo connect 
            return conn;

        }
    }
    // tạo chuỗi kết nối đến cơ sở dữ liệu :
    public class DatabaseAccess
    {
        public static string CheckLoginDTO(UsersDTO users)
        {
            
            string user = null;
            // hàm connect cơ sở dữ liệu : 
            SqlConnection conn = SqlConnectionData.Connect();
            conn.Open(); // mở kết nối nè 
            SqlCommand command = new SqlCommand("CheckLogin", conn);
            command.CommandType = CommandType.StoredProcedure;
            // truyền Paramester vào : 
            command.Parameters.AddWithValue("@username", users.UserName);
            command.Parameters.AddWithValue("@password", users.Password);
            // kiểm tra quyền : ...... đợi làm 
            command.Connection = conn;
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows) // có cột hàng _ thông tin đó không 
            {
                while(reader.Read())
                {
                    if (reader.GetFieldType(0) == typeof(String))
                    {
                        user=reader.GetString(0);

                    }
                    else
                    {
                        user = reader[0].ToString();
                    }

                }
                reader.Close();
                conn.Close();
            }else
            {
                return "Account does not exist";
            }
            return user;
                
        }
    }

}
