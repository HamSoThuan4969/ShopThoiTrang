using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace BLL
{
    public class CustomerBLL : BaseBLL<CustomerDTO>
    {
        private CustomerDAL customerDAL = new CustomerDAL(); // tạo đối tượng DAL để gọi hàm lấy danh sách khách
        
        public List<CustomerDTO> GetCustomerDALs()
        {
            // gọi hàm lấy danh sách khách hàng ở DAL
            return customerDAL.GetCustomer();

        }


        // thêm khách hàng nè
        public void AddCustomer(CustomerDTO customer)
        {
            try
            {
                // sinh Id tự động nếu chưa có 
                if (string.IsNullOrEmpty(customer.Id))
                {
                    customer.Id = GenerateAutoId("Customer", "Id", "CTM");
                }

                // Gán giá trị mặc định cho IdUserRole
                customer.IdUserRole = 2;

                // Gọi hàm DAL lên nhân thông tin và add vào cơ sở dữ liệu
                customerDAL.AddCustomer(customer);
            }catch(Exception ex)
            {
                throw new Exception($"Lỗi khi thêm khách hàng ở CustomerBLL: {ex.Message}");
            }
        }


        // XÓa khách hàng nè 
        public void RemoveCustomer(List<string> ids)
        {
            try
            {
                // Gọi hàm trừ bassBLL - Xóa
                DeleteByIds("Customer", "Id", ids);
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi khi xóa khách hàng ở CustomerBLL: {ex.Message}");
            }



        }

    }
}
