using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class BaseDAL
    {
        // Chuỗi kết nối đặt trong lớp cơ sở
        protected string connectionString = @"Data Source=KUROBA\SQLSERVER_DEV;Initial Catalog=ShopThoiTrang;Integrated Security=True";

        // Hàm tạo kết nối
        protected SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
