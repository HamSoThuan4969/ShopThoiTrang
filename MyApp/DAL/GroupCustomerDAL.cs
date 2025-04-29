using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DAL
{
    public class GroupCustomerDAL:BaseDAL
    {
        private DataProvider dataProvider = new DataProvider();
        // lấy danh sách nhóm khách hàng
        public List<GroupCustomerDTO> GetGroupCustomer()
        {
            // câu lệnh truy xuất để lấy danh sách nhóm khách hàng
            string query = "SELECT Id, DisplayName, TypeGroup FROM GroupCustomer";
            return dataProvider.ExecuteQuery<GroupCustomerDTO>(query);
        }

        // thêm nhóm khách hàng
        public void AddGroupCustomer(GroupCustomerDTO groupCustomer)
        {
            // câu lệnh truy xuất để thêm nhóm khách hàng
            string query = "INSERT INTO GroupCustomer (Id, DisplayName, TypeGroup) VALUES (@Id, @DisplayName, @TypeGroup)";
            object[] parameters = new object[]
            {
                groupCustomer.Id,
                groupCustomer.DisplayName,
                groupCustomer.TypeGroup
            };
            dataProvider.ExecuteNonQuery(query, parameters);
        }
        // xóa nhóm khách hàng
        public int DeleteGroupCustomer(List<string> ids)
        {
            // câu lệnh truy xuất để xóa nhóm khách hàng
            return DeleteByIds("GroupCustomer", "Id", ids);
        }
        // hàm cập nhật nhóm khách hàng
        public int UpdateGroupCustomer(List<GroupCustomerDTO> groupCustomers)
        {
            // câu lệnh truy xuất để cập nhật nhóm khách hàng
            return Update("GroupCustomer", "Id", groupCustomers, (command, groupCustomers) =>
            {
                command.Parameters.AddWithValue("@Id", groupCustomers.Id);
                command.Parameters.AddWithValue("@DisplayName", groupCustomers.DisplayName);
                command.Parameters.AddWithValue("@TypeGroup", groupCustomers.TypeGroup);
            });
        }
    }
}
