using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;


namespace BLL
{
    public class OutputInforBLL : BaseBLL<OutputInforDTO>
    {
        private OutputInforDAL outputInforDAL = new OutputInforDAL();

        public List<OutputInforDTO> GetOutputInforList()
        {
            return outputInforDAL.GetOutputInforList();
        }

        // thêm hóa đơn Infor
        public void AddOutputInfor(OutputInforDTO outputInfor)
        {
            try
            {
                if (string.IsNullOrEmpty(outputInfor.Id))
                {
                    outputInfor.Id = GenerateAutoId("Customer", "Id", "CTM");
                }
                // gọi hàm thêmDAL 
                outputInforDAL.AddOutputInfor(outputInfor);
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi khi tự động sinh Id cho hóa đơn Infor: {ex.Message}");
            }
        }

        // xóa hóa đơn Infor
        public void DeleteOutputInfor(List<string> ids)
        {
            try
            {
                // Gọi hàm trừ bassBLL - Xóa
                DeleteByIds("OutputInfor", "Id", ids);
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi khi xóa hóa đơn  ở outputInforBLL: {ex.Message}");
            }
        }
        // cập nhật hóa đơn Infor
        public int UpdateOutputInfor(List<OutputInforDTO> outputInfor)
        {
            if (outputInfor == null || outputInfor.Count == 0)
            {
                throw new ArgumentException("Danh sách khách hàng không được để trống.");
            }

            return outputInforDAL.UpdateOutputInfor(outputInfor);
        }
    }
}

