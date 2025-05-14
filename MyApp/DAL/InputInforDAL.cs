using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL   
{
    public class InputInforDAL:BaseDAL
    {
        private DataProvider dataProvider = new DataProvider();
        public void AddInputInfor(InputInforDTO inputInfor)
        {
            string query = "INSERT INTO InputInfor (Id, IdInput, DisplayName_Object, Quantity, InputPrice, OutputPrice, Active, IdSupplier) " +
                           "VALUES (@Id, @IdInput,  @DisplayName_Object, @Quantity, @InputPrice, @OutputPrice, @Active, @Supplier)";
            var parameters = new object[]
            {
                inputInfor.Id,
                inputInfor.IdInput,
                inputInfor.DisplayName_Object,
                inputInfor.Quantity,
                inputInfor.InputPrice,
                inputInfor.OutputPrice,
                inputInfor.Active,
                inputInfor.IdSupplier

            };
            dataProvider.ExecuteNonQuery(query, parameters);
        }
        public List<InputInforDTO> GetAllInputInfor()
        {
            string query = "SELECT * FROM InputInfor";
            return dataProvider.ExecuteQuery<InputInforDTO>(query);
        }
        // lấy thông tin với Active = 1
        public List<InputInforDTO> GetActiveInputInfor()
        {
            string query = "SELECT * FROM InputInfor WHERE Active = '1'";
            return dataProvider.ExecuteQuery<InputInforDTO>(query);
        }

        // Xóa thông tin InputInfor
        public int DeleteInputInfor(List<string> ids)
        {
            return DeleteByIds("InputInfor", "Id", ids);
        }
        // Cập nhật thông tin InputInfor
        public int UpdateInputInfor(List<InputInforDTO> inputInfors)
        {
            return Update("InputInfor", "Id", inputInfors, (command, inputInfors) =>
            {
                command.Parameters.AddWithValue("@Id", inputInfors.Id);
                command.Parameters.AddWithValue("@IdInput", inputInfors.IdInput);
                command.Parameters.AddWithValue("@DisplayName_Object", inputInfors.DisplayName_Object);
                command.Parameters.AddWithValue("@Quantity", inputInfors.Quantity);
                command.Parameters.AddWithValue("@InputPrice", inputInfors.InputPrice);
                command.Parameters.AddWithValue("@OutputPrice", inputInfors.OutputPrice);
                command.Parameters.AddWithValue("@Active", inputInfors.Active);
                command.Parameters.AddWithValue("@IdSupplier", inputInfors.IdSupplier);
            });
        }
        // Update cột 
        public void UpdateColumn(string id, string newActiveValue)
        {
            string query = "UPDATE InputInfor SET Active = @Active WHERE Id = @Id";
            dataProvider.ExecuteNonQuery(query, new object[] { newActiveValue, id });
        }
    }
}
