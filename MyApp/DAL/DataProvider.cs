using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Reflection;

namespace DAL
{
    public class DataProvider
    {
        private string conn = @"Data Source=KUROBA\SQLSERVER_DEV;Initial Catalog=ShopThoiTrang;Integrated Security=True";
                              

        // Thực thi trả dữ liệu về DataTable ( Dùng SELECT )
        //public DataTable ExcuteQuery(string query, object[] parameter = null)
        //{
        //    DataTable data = new DataTable();
        //    using (SqlConnection connection = new SqlConnection(conn))
        //    {
        //        connection.Open();
        //        using (SqlCommand cmd = connection.CreateCommand())
        //        {
        //            AddParameter(cmd, query, parameter); // thêm các tham số vào lệnh cmd
        //            using (SqlDataAdapter adapter = new SqlDataAdapter(cmd)) // sử dụng SqlDataAdapter để thực thi lệnh cmd
        //            {
        //                adapter.Fill(data); // đổ dữ liệu vào DataTable
        //            }
        //        }
        //    }
        //    return data;
        //}
        
            public List<T> ExecuteQuery<T>(string query, object[] parameter =null) where T : new()
            {
                List<T> list = new List<T>();
                using(SqlConnection connection = new SqlConnection(conn))
                {
                    connection.Open();
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        AddParameter(cmd, query, parameter); // thêm các tham số vào lệnh cmd
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read()) 
                            {
                                T obj = new T(); // khỏi tạo đối tượng 
                                // duyệt từng thuộc tính của đối tượng
                                for ( int i =0; i< reader.FieldCount; i++) // fileCount trả về số cột trong bảng
                                {
                                    string proName = reader.GetName(i); // lấy tên thuộc tính ( tên cột ) 
                                    PropertyInfo pro = typeof(T).GetProperty(proName); // lấy thuộc tính của đối tượng
                                    if( pro != null &&  reader[proName] != DBNull.Value)// kiểm tra thuộc tính có null không 
                                    {
                                        pro.SetValue(obj, Convert.ChangeType(reader[proName], pro.PropertyType)); // kiểm tra thuộc tính có thể đọc không
                                    }
                                }
                            list.Add(obj); // thêm đối tượng vào danh sách
                        }
                        }
                    }
                }
                return list; // trả về danh sách đối tượng
        }





        // hàm thực thi lệnh Sql trả về số row bị ảnh hưởng qua các (INSERT, UPDATE, DELETE)
        public int ExecuteNonQuery(string query, object[] parameter = null)
        {
            try
            {
                int rowAffected;
                using (SqlConnection connection = new SqlConnection(conn))
                {
                    connection.Open();
                    using (SqlCommand cmd = connection.CreateCommand())
                    {
                        cmd.CommandText = query; // Thiết lập câu lệnh SQL
                        AddParameter(cmd, query, parameter); // Thêm tham số
                        rowAffected = cmd.ExecuteNonQuery(); // Thực thi lệnh SQL
                    }
                }
                return rowAffected;
            }
            catch (Exception ex)
            {
                // Log lỗi chi tiết
                throw new Exception($"Lỗi trong ExecuteNonQuery: {ex.Message}, câu lệnh: {query}", ex);
            }
        }
        // hàm thực thi lệnh Sql trả về 1 giá trị duy nhất - thông thường id  (dùng select, inset, delete)
        public object ExecuteSalar(string query, object[] parameter = null)
        {
            object result;
            using (SqlConnection connection = new SqlConnection(conn))
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    AddParameter(cmd, query, parameter); // thêm các tham số vào lệnh cmd
                    result = cmd.ExecuteScalar(); // thực thi lệnh cmd và trả về giá trị đầu tiên của dòng đầu tiên
                }
                
            }
            return result; 
        }


        // hàm thựuc thi lệnh sql trả về SqlDataReader ( dùng để dọc dữ liệu dòng - by dòng ) 
        public SqlDataReader ExecuteReader(string query, object[] parameter = null)
        {
            SqlConnection connection = new SqlConnection(conn); // khởi tạo kết nối
            connection.Open();
            SqlCommand cmd = new SqlCommand(query, connection); // khởi tạo lệnh cmd
            AddParameter(cmd, query, parameter); // thêm các tham số vào lệnh cmd

            // Đảm bảo rằng kết nối không bị đóng khi đọc dữ liệu (nhờ CommandBehavior.CloseConnection)
            return cmd.ExecuteReader(CommandBehavior.CloseConnection); // thực thi lệnh cmd và trả về SqlDataReader

        }
        // truyền giá trị vào các tham số của lệnh SqlCommand
        public void AddParameter(SqlCommand cmd, string query, object[] parameter = null)
        {
            if (parameter != null)
            {
                // Duyệt qua từng từ trong câu lệnh SQL
                string[] listPara = query.Split(new char[] { ' ', ',', '(', ')', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
                int i = 0;

                foreach (string item in listPara)
                {
                    // Kiểm tra nếu từ bắt đầu bằng '@' (biến tham số)
                    if (item.StartsWith("@"))
                    {
                        

                        
                        cmd.Parameters.AddWithValue(item, parameter[i] ?? DBNull.Value);
                        i++;
                    }
                }
            }
        }


    }
}
