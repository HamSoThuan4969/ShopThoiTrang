using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class SetObjectDAL : BaseDAL
    {
        private DataProvider dataProvider = new DataProvider();
        // lấy danh sách SetObject
        public List<SetObjectDTO> GetAllSetObject()
        {
            try
            {
                // Tạo câu lệnh truy vấn
                string query = "SELECT * FROM SetObject";
                // Thực thi truy vấn và trả về danh sách sản phẩm
                return dataProvider.ExecuteQuery<SetObjectDTO>(query, null);
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi khi lấy danh sách sản phẩm: {ex.Message}");
            }
        }
        // thêm danh sách Object
        public void AddSetObject(SetObjectDTO setobjects)
        {
            try
            {
                string query = "INSERT INTO SetObject (Id, DisplayName) " +
                    "VALUES (@Id, @DisplayName)";
                var parameters = new object[]
                {
                    setobjects.Id,
                    setobjects.DisplayName
                };
                dataProvider.ExecuteNonQuery(query, parameters);
            }catch(Exception ex)
            {
                throw new Exception($"Lỗi khi thêm sản phẩm: {ex.Message}");
            }
        }
        // xóa 
        public int DeleteSetObject(List<string> ids)
        {
            return DeleteByIds("SetObject", "Id", ids);
        }
        // update
        public int UpdateSetObject(List<SetObjectDTO> setobjects)
        {
            return Update("SetObject", "Id", setobjects, (command, setobjects) =>
            {
                command.Parameters.AddWithValue("@Id", setobjects.Id);
                command.Parameters.AddWithValue("@DisplayName", setobjects.DisplayName);
            });
        }
    }
}
