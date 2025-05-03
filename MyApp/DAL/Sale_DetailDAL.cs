using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class Sale_DetailDAL:BaseDAL
    {
        private DataProvider dataProvider = new DataProvider();

        // lấy thông tin của Sale_Detail bằng Id
        public Sale_DetailDTO GetSaleDetailById(string idSale_Detail)
        {
            return GetById<Sale_DetailDTO>("Sale_Detail", "IdSale", idSale_Detail);
        }
        // lấy danh sách chi tiết Sale_Detail
        public List<Sale_DetailDTO> GetAllSale_Detail()
        {
            string query = "SELECT * FROM Sale_Detail ";
            return dataProvider.ExecuteQuery<Sale_DetailDTO>(query);
        }
        // thêm chi tiết Sale_Detail
        public void AddSale_Detail(Sale_DetailDTO saleDetail)
        {
            string query = "INSERT INTO Sale_Detail (Id, IdSale, Discount, ConditionValue) VALUES (@Id, @IdSale, @Discount, @ConditionValue, @Description)";
            object[] parameters = new object[]
            {
                saleDetail.Id,
                saleDetail.IdSale,
                saleDetail.Discount,
                saleDetail.ConditionValue,
                saleDetail.Description,
            };
            dataProvider.ExecuteNonQuery(query, parameters);
        }
        // xóa chi tiết Sale_Detail
        public int DeleteSale_Detail(List<string> ids)
        {
           return DeleteByIds("Sale_Detail", "Id", ids);
        }
        // cập nhật chi tiết Sale_Detail 
        public int UpdateSale_Detail(List<Sale_DetailDTO> saleDetail)
        {
            return Update("Sale_Detail", "Id",saleDetail, (command, saleDetail) =>
            {
                command.Parameters.AddWithValue("@Id", saleDetail.Id);
                command.Parameters.AddWithValue("@IdSale", saleDetail.IdSale);
                command.Parameters.AddWithValue("@Discount", saleDetail.Discount);
                command.Parameters.AddWithValue("@ConditionValue", saleDetail.ConditionValue);
                command.Parameters.AddWithValue("@Description", saleDetail.Description);
            }); 
        }

    }
}
