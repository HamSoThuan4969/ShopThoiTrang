using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
using System.Transactions;
using System.Runtime.InteropServices.WindowsRuntime;




namespace BLL
{
    public class InputBLL:BaseBLL<InputBLL>
    {
        private InputDAL inputDAL = new InputDAL();
        private InputInforDAL inputInforDAL = new InputInforDAL();
        public void AddInputAndInput_Infor(List<InputInforDTO> inputInforList)
        {
            try
            {
                if (inputInforList == null || inputInforList.Count == 0)
                {
                    throw new Exception("Danh sách InputInfor bị trống. Vui lòng kiểm tra dữ liệu đầu vào.");
                }
                using (var transaction = new TransactionScope())
                {
                    // sinh Id tự động cho bảng input 
                    string inputId= GenerateAutoId("Input", "Id", "INPUT");

                  
                    // tính toán các giá trị từ inputInforList vào bảng input 
                    int totalQuantity = 0;
                    float totalPrice = 0;
                    foreach (var inputInfor in inputInforList)
                    {
                        totalQuantity += inputInfor.Quantity;
                        totalPrice += inputInfor.Quantity * inputInfor.InputPrice;
                    }
                    // tạo đối tượng InputDTO
                    InputDTO inputDTO = new InputDTO()
                    {
                        Id = inputId,
                        Quantity = totalQuantity,
                        ToTalPrice = totalPrice,
                        Type = "Input",
                        BarCode= "DEFAULT_BARCODE",
                        DateInput = DateTime.Now

                    };

                    // thêm dữ liệu vào bảng Input
                    inputDAL.AddInput(inputDTO);
                    // thêm dữ liệu vào bảng Input_Infor
                    
                    foreach (var inputInfor in inputInforList)
                    {
                        // sinh Id tự động cho bảng Input_Infor
                        inputInfor.Id = GenerateAutoId("InputInfor", "Id", "INFOR");
                        inputInfor.IdInput = inputId; // gán IdInput từ InputDTO vào Input_InforDTO
                        inputInfor.Active = "1"; // gán Active mặc định là 1
                        inputInforDAL.AddInputInfor(inputInfor);
                    }

                    transaction.Complete(); // commit transaction
                }
            }
            catch(Exception ex)
            {
                throw new Exception($"Lỗi khi thêm dữ liệu vào bảng Input và Input_Infor BLL: {ex.Message}");
            }
        }
    }
}
