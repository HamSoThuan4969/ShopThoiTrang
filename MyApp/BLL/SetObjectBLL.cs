using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class SetObjectBLL:BaseBLL<SetObjectDTO>
    {
        private SetObjectDAL setObjectDAL = new SetObjectDAL();
        // lấy danh sách sản phẩm 
        public List<SetObjectDTO> GetSetObject()
        {
            return setObjectDAL.GetAllSetObject();
        }
        // thêm danh sách Object
        public void AddObject(SetObjectDTO setobjects)
        {
            try
            {
                // sinh Id tự động nếu chưa có 
                if (string.IsNullOrEmpty(setobjects.Id))
                {
                    setobjects.Id = GenerateAutoId("SetObject", "Id", "SET");
                }
                // Gọi hàm DAL lên nhân thông tin và add vào cơ sở dữ liệu
                setObjectDAL.AddSetObject(setobjects);
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi khi thêm sản phẩm ở SetObjectBLL: {ex.Message}");
            }
        }
        // xóa 
        public void DeleteSetObject(List<string> ids)
        {
            try
            {
                // gọi hàm DAL để xóa dữ liệu về SetObject
                setObjectDAL.DeleteSetObject(ids);
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi khi xóa sản phẩm ở SetObjectBLL: {ex.Message}");
            }
        }
        // update 
        public void UpdateSetObject(List<SetObjectDTO> setObjectDTOs)
        {
            try
            {
                // gọi hàm DAL để update dữ liệu về SetObject
                setObjectDAL.UpdateSetObject(setObjectDTOs);
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi khi cập nhật sản phẩm ở SetObjectBLL: {ex.Message}");
            }
        }

        
    }
}
