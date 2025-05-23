﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Reflection;
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
        // Lấy thông tin của một đối tượng bất kỳ
        public T GetById<T>(String tableName, string columnName, string id) where T : new ()
        {
            try
            {
                // Tạo câu lệnh truy vấn
                string query = $"SELECT * FROM {tableName} WHERE {columnName} = @Id";
                // Thực thi truy vấn vấn đối tượng 
                var parameters = new object[] { id };
                return dataProvider.ExecuteQuery<T>(query, parameters).FirstOrDefault();
            }catch(Exception ex)
            {
                throw new Exception($"Lỗi khi lấy thông tin đối tượng từ bảng {tableName}: {ex.Message}");
            }
        }

        // Hàm lấy Id lớn nhất từ cơ sở dữ liệu
        public string GetMaxID(string tableName, string columnName, string prefix)
        {
            try
            {
                // Chuẩn hóa prefix về in hoa
                string upperPrefix = prefix.ToUpper();

                // Tìm Id lớn nhất dựa trên tiền tố
                string query = $"SELECT MAX({columnName}) FROM {tableName} WHERE UPPER({columnName}) LIKE '{upperPrefix}%'";
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
                    // tạo câu lệnh update động
                    string query = $"UPDATE {tableName} SET {{columns}} WHERE {keyColumn} = @{keyColumn}";
                    
                    // Tạo SqlCommand
                    using (var connection = GetConnection())
                    using ( var command = new SqlCommand())
                    {
                        command.Connection = connection; // thiết lập kết nối cho lệnh cmd
                        connection.Open(); // mở kết nối
                        // lấy danh sách các thuộc tính không null
                        var propertis = typeof(T).GetProperties()
                            .Where(p => p.GetValue(obj) != null)
                            .ToList();
                        string columns = string.Join(",", propertis.Where(p=>p.Name != keyColumn).Select(p => $"{p.Name} = @{p.Name}"));
                        query = query.Replace("{columns}", columns);


                        // thiết lập câu lệnh sql 
                        command.CommandText = query;


                        // Map các tham số vào Sql
                        mapParameter(command, obj); // gọi hàm mapParameter để ánh xạ các tham số vào SqlCommand


                        // thực thi thông báo 
                        rowAffected += command.ExecuteNonQuery(); // thực thi câu lệnh SQL
                    }
            }
                return rowAffected; // trả về số dòng bị ảnh hưởng
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi khi cập nhật dữ liệu trong bảng {tableName}: {ex.Message}");
            }
          
        }


        // Lấy dữ liệu lên cho Combobox 
        public List<string> GetDistinctValues(string tableName, string columnName)
        {
            try
            {
                // Câu lệnh SQL lấy dữ liệu không trùng lặp
                string query = $"SELECT DISTINCT {columnName} FROM {tableName}";
                List<string> results = new List<string>();

                using (var connection = GetConnection())
                using (var command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            results.Add(reader[columnName].ToString());
                        }
                    }
                }

                return results;
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi khi lấy dữ liệu không trùng lặp từ bảng {tableName}, cột {columnName}: {ex.Message}");
            }
        }
        public object GetValueByCondition(string tableName, string conditionColumn, string conditionValue, string targetColumn)
        {
            object result = null;

            string query = $"SELECT {targetColumn} FROM {tableName} WHERE {conditionColumn} = @value";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@value", conditionValue);

                try
                {
                    conn.Open();
                    result = cmd.ExecuteScalar(); // Lấy giá trị đầu tiên của cột đầu tiên
                }
                catch (Exception ex)
                {
                    throw new Exception("Lỗi khi truy vấn dữ liệu: " + ex.Message);
                }
            }

            return result;
        }




    }

}
