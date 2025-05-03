using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    // lớp này quản lý tất cả việc thao tác với bảng Sale
    public class SaleDAL:BaseDAL
    {
        private DataProvider dataProvider = new DataProvider();
        public List<SaleDTO> GetAllSale()
        {
            string query = "SELECT * FROM Sale";
            return dataProvider.ExecuteQuery<SaleDTO>(query);
        }
        // lấy thông tin của Salez
        public SaleDTO GetSaleById(String idSale)
        {
            return GetById<SaleDTO>("Sale", "Id", idSale);
        }
        public void AddSale(SaleDTO sale)
        {
            string query = "INSERT INTO Sale (Id, DisplayName, TypeSale, StartDate, EndDate) VALUES (@Id, @DisplayName, @TypeSale, @StartDate, @EndDate)";
            var parameters = new object[]
            {
                 sale.Id,
                 sale.DisplayName,
                 sale.TypeSale,
                 sale.StartDate,
                 sale.EndDate

            };
            dataProvider.ExecuteNonQuery(query, parameters);
        }

        // xóa thông tin sale 
        public int DeleteSale(List<string> ids)
        {
            return DeleteByIds("Sale", "Id", ids);
        }
        // cập nhật thông tin sale
        public int UpdateSale(List<SaleDTO> sale)
        {
            return Update("Sale", "Id", sale, (command, sale) =>
            {
                command.Parameters.AddWithValue("@Id", sale.Id);
                command.Parameters.AddWithValue("@DisplayName", sale.DisplayName);
                command.Parameters.AddWithValue("@TypeSale", sale.TypeSale);
                command.Parameters.AddWithValue("@StartDate", sale.StartDate);
                command.Parameters.AddWithValue("@EndDate", sale.EndDate);
                // Thêm các tham số khác nếu cần


            });
        }
    }
}
