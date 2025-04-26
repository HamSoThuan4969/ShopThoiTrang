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
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi khi lấy Id lớn nhất từ bảng {tableName}: {ex.Message}");
            }
        }


        // Xóa dòng trong cơ sở dữ liệu 
        public int DeleteByIds(string tableName, string columnName, List<string> ids)
        {
            try
            {
                for (int i = 0; i < ids.Count; i++)
                {
                    ids[i] = ids[i].Trim(); // Loại bỏ khoảng trắng
                    Console.WriteLine($"Xóa ID: {ids[i]}");
                }

                // câu lệnh truy xuất để XÓA 
                string query = $"DELETE FROM {tableName} WHERE {columnName} IN ({string.Join(",", ids.Select(id => $"'{id}'"))})";
                Console.WriteLine($"Câu lệnh SQL: {query}");
                return dataProvider.ExecuteNonQuery(query);
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi khi xóa dòng trong bảng Base DAL  {tableName}: {ex.Message}");
            }


        }
        

        // Hàm cập nhật dữ liệu cho đối tượng bất kỳ 
        public int Update<T>(string tableName, string keyColumn, List<T> objects , Action<SqlCommand , T>  mapParameter)
        {
            try
            {
                int rowAffected = 0;
                foreach(var obj in objects)
                {
                    // lấy danh sách các thuộc tính không null của đôi tượng
                    var properties = typeof(T).GetProperties()
                        .Where(p => p.GetValue(obj) != null && p.Name != keyColumn).ToList();

                }
            }
        }
        
    }

}
