using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace BLL
{
    public class CustomerBLL
    {
        private CustomerDAL customerDAL = new CustomerDAL(); // tạo đối tượng DAL để gọi hàm lấy danh sách khách hàng
        public List<CustomerDTO> GetCustomerDALs()
        {
            // gọi hàm lấy danh sách khách hàng ở DAL
            return customerDAL.GetCustomer();

        }
   
    }
}
