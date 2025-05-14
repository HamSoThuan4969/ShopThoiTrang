using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
namespace BLL
{
    public class SupplierBLL:BaseBLL<SupplierDTO>
    {
        private SupplierDAL supplierDAl = new SupplierDAL();
        // 
        // lấy thông tin của Supplier bằng Id
        public SupplierDTO GetSupplierByIdBLL(string idSupplier)
        {
            return supplierDAl.GetSupplierById(idSupplier);
        }
        // xem toàn bộ danh sách
        public List<SupplierDTO> GetAllSupplier()
        {
            return supplierDAl.GetAllSupplier();
        }
        // thêm
        public void AddSupplier(SupplierDTO supplierDTO)
        {
            try
            {
                // sinh id tự động 
                if (string.IsNullOrEmpty(supplierDTO.Id))
                {
                    supplierDTO.Id = GenerateAutoId("Supplier", "Id", "SUP");
                }
                // gọi hàm DAl để thêm dữ liệu về Supplier
                supplierDAl.AddSupplier(supplierDTO);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi sinh mã tự động: " + ex.Message);
            }
        }
        // xóa 
        public void DeleteSupplier(List<string> ids)
        {
            try
            {
                
                // gọi hàm DAL để xóa dữ liệu về Supplier
                supplierDAl.DeleteSupplier(ids);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi xóa nhà cung cấp BLL: " + ex.Message);
            }
        }
        // sửa thông tin của Supplier
        public void UpdateSupplier(List<SupplierDTO> supplier)
        {
            try
            {
                if(supplier == null || supplier.Count ==0)
                {
                    throw new ArgumentException("Danh sách nhà cung cấp không được null hoặc rỗng");
                }
                // gọi hàm DAL để sửa thông tin nhà cung cấp
                supplierDAl.UpdateSupplier(supplier);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi sửa thông tin nhà cung cấp: " + ex.Message);
            }
        }
        public List<string> GetTypeObject()
        {
            try
            {
                return supplierDAl.GetDistinctValues("Supplier", "TypeObject");
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi lấy danh sách loại đối tượng: " + ex.Message);
            }
        }
    }
}
