using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class InputInforBLL : BaseBLL<InputInforBLL>
    {
        private InputInforDAL inputInforDAL = new InputInforDAL();
        public List<InputInforDTO> GetInputInfor()
        {
            return inputInforDAL.GetAllInputInfor();
        }
        // lấy thông tin với Active =1
        public List<InputInforDTO> GetActiveInputInfor()
        {
            return inputInforDAL.GetActiveInputInfor();
        }

        // XÓa khách hàng nè 
        public void RemoveCustomer(List<string> ids)
        {
            try
            {
                // Gọi hàm trừ bassBLL - Xóa
                DeleteByIds("InputInfor", "Id", ids);
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi khi xóa khách hàng ở CustomerBLL: {ex.Message}");
            }



        }
        // update 
        public int UpdateCustomerList(List<InputInforDTO> inputInfor)
        {
            if (inputInfor == null || inputInfor.Count == 0)
            {
                throw new ArgumentException("Danh sách khách hàng không được để trống.");
            }

            return inputInforDAL.UpdateInputInfor(inputInfor);
        }
        // update cột 
        public void UpdateColumns(string id, string newActiveValue)
        {
            inputInforDAL.UpdateColumn(id, newActiveValue);
        }

    }
}
