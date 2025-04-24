using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class BaseDAL
    {
        private DataProvider dataProvider = new DataProvider();
        // Chuỗi kết nối đặt trong lớp cơ sở
        private string connectionString = @"Data Source=KUROBA\SQLSERVER_DEV;Initial Catalog=ShopThoiTrang;Integrated Security=True";
        
        // Hàm tạo kết nối
        protected SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
       
        // Hàm lấy Id lớn nhất từ cơ sở dữ liệu
        public string GetMaxID(string tableName, string columnName, string prefix)
        {
            try
            {
                // Tìm Id lớn nhất dựa trên tiền tố
                string query = $"SELECT MAX({columnName}) FROM {tableName} WHERE {columnName} LIKE '{prefix}%'";
                object result = dataProvider.ExecuteSalar(query);

                // trả về Id lớn nhất ( or null nếu là méo có Id )
                return result == DBNull.Value || result == null ? null : result.ToString();
            }catch(Exception ex)
            {
                throw new Exception($"Lỗi khi lấy Id lớn nhất từ bảng {tableName}: {ex.Message}");
            }
        }
        


    }

}
