using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace BLL
{
    public class GroupCustomerBLL:BaseBLL<GroupCustomerDTO>
    {
        private GroupCustomerDAL groupCustomerDAL= new GroupCustomerDAL();
        // lấy danh sách nhóm khách hàng
        public List<GroupCustomerDTO> GetGroupCustomer()
        {
            try
            {
                return groupCustomerDAL.GetGroupCustomer();
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi khi lấy danh sách nhóm khách hàng BLL : {ex.Message}");
            }
        }
        // thêm nhóm khách hàng
        public void AddGroupCustomer(GroupCustomerDTO groupCustomer)
        {
            try
            {
                // sinh Id tự động
                if(string.IsNullOrEmpty(groupCustomer.Id))
                {
                    groupCustomer.Id = GenerateAutoId("GroupCustomer", "Id", "GTM");
                }
                // gọi hàm DAL nhận thông tin Group khách hàng
                groupCustomerDAL.AddGroupCustomer(groupCustomer);
                
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi khi thêm nhóm khách hàng BLL : {ex.Message}");
            }
        }
        // xóa nhóm khách hàng
        public int DeleteGroupCustomer(List<string> ids)
        {
            try
            {
                if (ids == null || ids.Count == 0)
                {
                    throw new ArgumentException("Danh sách Id không được null hoặc rỗng");
                }
                return groupCustomerDAL.DeleteGroupCustomer(ids);
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi khi xóa nhóm khách hàng BLL : {ex.Message}");
            }
        }
        // update khách hàng 
        public int UpdateGroupCustomer(List<GroupCustomerDTO> groupCustomer)
        {
            if(groupCustomer == null || groupCustomer.Count == 0)
            {
                throw new ArgumentException("Danh sách khách hàng không được để trống");
            } 
            return groupCustomerDAL.UpdateGroupCustomer(groupCustomer);
        }
       
    }
}
