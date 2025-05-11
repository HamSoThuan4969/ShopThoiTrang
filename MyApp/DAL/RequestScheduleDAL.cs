using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace DAL
{
    public class RequestScheduleDAL : BaseDAL
    {
        private string connectionString = "Data Source=DESKTOP-ME1OU3E\\HUYVO;Initial Catalog=ShopThoiTrang;Integrated Security=True;";
        public void AddRequest(RequestSchedulesDTO req)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string sql = "INSERT INTO Requests (Request, Shift, RequestDate, Status) VALUES (@Request, @Shift, @Date, @Status)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Request", req.Request);
                cmd.Parameters.AddWithValue("@Shift", req.Shift);
                cmd.Parameters.AddWithValue("@Date", req.RequestDate);
                cmd.Parameters.AddWithValue("@Status", req.Status);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public List<RequestSchedulesDTO> GetRequestsByDate(DateTime date)
        {
            List<RequestSchedulesDTO> list = new List<RequestSchedulesDTO>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string sql = "SELECT * FROM Requests WHERE CAST(RequestDate AS DATE) = @date";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@date", date.Date);  // So sánh theo ngày

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    list.Add(new RequestSchedulesDTO
                    {
                        Id = (int)reader["Id"],
                        Request = reader["Request"].ToString(),
                        Shift = reader["Shift"].ToString(),
                        RequestDate = (DateTime)reader["RequestDate"],
                        Status = reader["Status"].ToString()
                    });
                }
            }
            return list;
        }

        public List<RequestSchedulesDTO> GetAllRequests()
        {
            List<RequestSchedulesDTO> list = new List<RequestSchedulesDTO>();

            using (SqlConnection conn = new SqlConnection("Data Source=DESKTOP-ME1OU3E\\HUYVO;Initial Catalog=ShopThoiTrang;Integrated Security=True;"))
            {
                string query = "SELECT * FROM Requests";
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    RequestSchedulesDTO dto = new RequestSchedulesDTO
                    {
                        Id = Convert.ToInt32(reader["Id"]),
                        Request = reader["Request"].ToString(),
                        Shift = reader["Shift"].ToString(),
                        RequestDate = Convert.ToDateTime(reader["RequestDate"]),
                        Status = reader["Status"].ToString()
                    };

                    list.Add(dto);
                }
            }

            return list;
        }
    }
}
