using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace DAL
{
    public class DataProvider
    {
        private string conn = @"Data Source=KUROBA\SQLSERVER_DEV;Initial Catalog=ShopThoiTrang;Integrated Security=True";

        // Thực thi trả dữ liệu về DataTable ( Dùng SELECT )
        public DataTable ExcuteQuery(string query, object[] parameter = null)
        {
            DataTable data = new DataTable();
            using (SqlConnection connection = new SqlConnection(conn))
            {
                connection.Open();
                using (SqlCommand cmd = connection.CreateCommand())
                {
                    AddParameter(cmd, query, parameter); // thêm các tham số vào lệnh cmd
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd)) // sử dụng SqlDataAdapter để thực thi lệnh cmd
                    {
                        adapter.Fill(data); // đổ dữ liệu vào DataTable
                    }
                }
            }
            return data;
        }
        // hàm thực thi lệnh Sql trả về số row bị ảnh hưởng qua các (INSERT, UPDATE, DELETE)
        public int ExecuteNonQuery(string query, object[] parameter = null)
        {
            int rowAffected;
            using (SqlConnection connection = new SqlConnection(conn))
            {
                connection.Open();
                using (SqlCommand cmd = connection.CreateCommand())
                {
                    AddParameter(cmd, query, parameter); // thêm các tham số vào lệnh cmd
                    rowAffected = cmd.ExecuteNonQuery(); // thực thi lệnh cmd và trả về số dòng bị ảnh hưởng
                }
            }
            return rowAffected;
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

        public void AddParameter(SqlCommand cmd, string query, object[] parameter = null)
        {

            if (parameter != null)
            {
                string[] listPara = query.Split(' ');   // tách chuỗi query thành mảng các từ - split khoảng trắng
                int i = 0;
                foreach (string item in listPara)
                {
                    if (item.StartsWith("@")) // kiểm tra chuỗi có ký tự bắt đầu là  @  => nó chưa Para
                    {
                        cmd.Parameters.AddWithValue(item, parameter[i]);
                        i++;
                    }
                }

            }       
        }

        
    }
}
