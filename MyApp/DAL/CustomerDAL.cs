using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class CustomerDAL
    {
        private DataProvider dataProvider = new DataProvider();
        // lấy danh sách khách hàng 
        public List<CustomerDTO> GetCustomer()
        {
            string query = "SELECT Id, DisplayName, IdGroupCustomer, Address, Phone, Email, DateContract, MoreInfor, IdUserRole FROM Customer";
            return dataProvider.ExecuteQuery<CustomerDTO>(query);   
        }
        public List<CustomerDTO> AddCustomerDTO()
        {
            string query = "INSERT INTO Customer (Id, DisplayName, IdGroupCustomer, Address, Phone, Email, DateContract, MoreInfor, IdUserRole) VALUES (@Id, @DisplayName, @IdGroupCustomer, @Address, @Phone, @Email, @DateContract, @MoreInfor, @IdUserRole)";
            return dataProvider.ExecuteQuery<CustomerDTO>(query);
        }
    }
}
