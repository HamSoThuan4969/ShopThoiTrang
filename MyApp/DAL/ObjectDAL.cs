using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class ObjectDAL: BaseDAL
    {
        private DataProvider dataProvider = new DataProvider();
        // lấy danh sách sản phẩm phẩnm
        public List<ObjectDTO> GetObjectList()
        {
            string query = "SELECT * FROM Object";
            return dataProvider.ExecuteQuery<ObjectDTO>(query);
        }
        // lấy thông tin với Active =1 
        
        // thêm 
        public void AddObject(ObjectDTO obj)
        {
            string query = "INSERT INTO Object (Id, DisplayName, IdSet, IdSupplier, InputPrice, Quantity, IdInputInfor, OutputPrice) " +
                "VALUES (@Id, @DisplayName, @IdSet, @IdSupplier, @InputPrice, @Quantity, @IdInputInfor, @OutputPrice)";
            var parameters = new object[]
            {
                obj.Id,
                obj.DisplayName,
                obj.IdSet,
                obj.IdSupplier,
                obj.InputPrice,
                obj.Quantity,
                obj.IdInputInfor,
                obj.OutputPrice

            };
            dataProvider.ExecuteNonQuery(query, parameters);
        }
        // xóa 
        public int DeleteObject(List<string> ids)
        {
            return DeleteByIds("Object", "Id", ids);
        }
        // cập nhật 
        public int UpdateObject(List<ObjectDTO> objects)
        {
            return Update("Object", "Id", objects, (command, obj) =>
            {
                command.Parameters.AddWithValue("@Id", obj.Id);
                command.Parameters.AddWithValue("@DisplayName", obj.DisplayName);
                command.Parameters.AddWithValue("@IdSet", obj.IdSet);
                command.Parameters.AddWithValue("@IdSupplier", obj.IdSupplier);
                command.Parameters.AddWithValue("@InputPrice", obj.InputPrice);
                command.Parameters.AddWithValue("@Quantity", obj.Quantity);
            });
        }
    }
}
