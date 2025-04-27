using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class CustomerDAL : BaseDAL
    {
        private DataProvider dataProvider = new DataProvider();


 
        // lấy danh sách khách hàng 
        public List<CustomerDTO> GetCustomer()
        {
            string query = "SELECT Id, DisplayName, IdGroupCustomer, Address, Phone, Email, DateContract, MoreInfor, IdUserRole FROM Customer";
            return dataProvider.ExecuteQuery<CustomerDTO>(query);   
        }


        // thêm danh sách khách hàng 
       public void AddCustomer(CustomerDTO customer)
        {
            string query = "INSERT INTO Customer (Id, DisplayName, Address, Phone, Email, MoreInfor, IdGroupCustomer, IdUserRole, DateContract) " +
                          "VALUES (@Id, @DisplayName, @Address, @Phone, @Email, @MoreInfor, @IdGroupCustomer, @IdUserRole, @DateContract)";
            object[] parameters = new object[]
            {
                customer.Id,
                customer.DisplayName,
                customer.Address,
                customer.Phone,
                customer.Email,
                customer.MoreInfor,
                customer.IdGroupCustomer,
                customer.IdUserRole,
                customer.DateContract
            };
            dataProvider.ExecuteNonQuery(query, parameters);
        }
        // xóa thông tin khách hàng 
        public int DeleteCustomer(List<string> ids)
        {
            return DeleteByIds("Customer", "Id", ids);
        }
       
        // hàm cập nhật khách hàng 
        public int UpdateCustomers(List<CustomerDTO> customers)
        {
            return Update("Customer", "Id", customers, (command, customers)=>
            {
                command.Parameters.AddWithValue("@Id", customers.Id);
                command.Parameters.AddWithValue("@DisplayName", customers.DisplayName);
                command.Parameters.AddWithValue("@Address", customers.Address);
                command.Parameters.AddWithValue("@Phone", customers.Phone);
                command.Parameters.AddWithValue("@Email", customers.Email);
                command.Parameters.AddWithValue("@MoreInfor", customers.MoreInfor);
                command.Parameters.AddWithValue("@IdGroupCustomer", customers.IdGroupCustomer);
                command.Parameters.AddWithValue("@IdUserRole", customers.IdUserRole);
                command.Parameters.AddWithValue("@DateContract", customers.DateContract);
            });
        }
    }
}
