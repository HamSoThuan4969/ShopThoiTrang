using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;


namespace DAL
{
    public class OutputDAL : BaseDAL
    {
        private DataProvider dataProvider = new DataProvider();
        // lấy danh sách Output
        public List<OutputDTO> GetAllOutput()
        {
            try
            {
                // Tạo câu lệnh truy vấn
                string query = "SELECT * FROM Output";
                // Thực thi truy vấn và trả về danh sách sản phẩm
                return dataProvider.ExecuteQuery<OutputDTO>(query, null);
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi khi lấy danh sách sản phẩm: {ex.Message}");
            }
        }
        // thêm 
        public void AddOutput(OutputDTO output)
        {
            try
            {
                string query = "INSERT INTO Output (Id, IdCustomer, IdSale_Output, DateOuput, ToTal, Type, Status) " +
                    "VALUES (@Id, @IdCustomer, @IdSale_Output, @DateOuput, @ToTal, @Type, @Status)";
                var parameters = new object[]
                {
                    output.Id,
                    output.IdCustomer,
                    output.IdSale_Output,
                    output.DateOuput,
                    output.ToTal,
                    output.Type,
                    output.Status
                };
                dataProvider.ExecuteNonQuery(query, parameters);
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi khi thêm sản phẩm: {ex.Message}");
            }
        }
        // xóa 
        public int DeleteOutput(List<string> ids)
        {
            return DeleteByIds("Output", "Id", ids);
        }
        // update
        public int UpdateOutput(List<OutputDTO> outputs)
        {
            return Update("Output", "Id", outputs, (command, output) =>
            {
                command.Parameters.AddWithValue("@Id", output.Id);
                command.Parameters.AddWithValue("@IdCustomer", output.IdCustomer);
                command.Parameters.AddWithValue("@IdSale_Output", output.IdSale_Output);
                command.Parameters.AddWithValue("@DateOuput", output.DateOuput);
                command.Parameters.AddWithValue("@ToTal", output.ToTal);
                command.Parameters.AddWithValue("@Type", output.Type);
                command.Parameters.AddWithValue("@Status", output.Status);
            });
        }

    }
}
