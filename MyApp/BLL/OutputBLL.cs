using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;


namespace BLL
{
    public class OutputBLL:BaseBLL<CustomerDTO>
    {
        private OutputDAL outputDAL = new OutputDAL();
        // lấy danh sách sản phẩm phẩnm
        public List<OutputDTO> GetOutPutList()
        {
            // gọi hàm lấy danh sách sản phẩm ở DAL
            return outputDAL.GetAllOutput();
        }
        // thêm
        public void AddOutPut(OutputDTO output)
        {
            try
            {
                // sinh Id tự động nếu chưa có 
                if (string.IsNullOrEmpty(output.Id))
                {
                    output.Id = GenerateAutoId("Output", "Id", "OUT");
                }
                // Gọi hàm DAL lên nhân thông tin và add vào cơ sở dữ liệu
                outputDAL.AddOutput(output);
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi khi thêm sản phẩm ở OutPutBLL: {ex.Message}");
            }
        }
        // xóa sản phẩm
        public void RemoveOutPut(List<string> ids)
        {
            try
            {
                // Gọi hàm trừ bassBLL - Xóa
                DeleteByIds("Output", "Id", ids);
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi khi xóa sản phẩm ở OutPutBLL: {ex.Message}");
            }
        }
        // cập nhật sản phẩm
        public int UpdateOutPut(List<OutputDTO> output)
        {
            if (output == null || output.Count == 0)
            {
                throw new ArgumentException("Danh sách khách hàng không được để trống.");
            }
            return outputDAL.UpdateOutput(output);
        }
    }
}
