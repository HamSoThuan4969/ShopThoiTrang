using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
namespace BLL
{
    public class ObjectBLL : BaseBLL<ObjectDTO>
    {
        private ObjectDAL objectDAL = new ObjectDAL();
        // lấy danh sách sản phẩm phẩnm
        public List<ObjectDTO> GetObjectList()
        {
            // gọi hàm lấy danh sách sản phẩm ở DAL
            return objectDAL.GetObjectList();
        }
       


        // thêm 
        public void AddObject(ObjectDTO obj)
        {
            try
            {
                // sinh Id tự động nếu chưa có 
                if (string.IsNullOrEmpty(obj.Id))
                {
                    obj.Id = GenerateAutoId("Object", "Id", "OBJ");
                }
                // Gọi hàm DAL lên nhân thông tin và add vào cơ sở dữ liệu
                objectDAL.AddObject(obj);
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi khi thêm sản phẩm ở ObjectBLL: {ex.Message}");
            }
        }
        // xóa sản phẩm
        public void RemoveObject(List<string> ids)
        {
            try
            {
                // Gọi hàm trừ bassBLL - Xóa
                DeleteByIds("Object", "Id", ids);
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi khi xóa sản phẩm ở ObjectBLL: {ex.Message}");
            }
        }
        // cập nhật sản phẩm
        public int UpdateObject(List<ObjectDTO> obj)
        {
            if (obj == null || obj.Count == 0)
            {
                throw new ArgumentException("Danh sách khách hàng không được để trống.");
            }

            return objectDAL.UpdateObject(obj);
        }

    }
}
