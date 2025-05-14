using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class OutputInforDAL : BaseDAL
    {
        private DataProvider dataProvider = new DataProvider();
        // lấy danh sách OutputInfor
        public List<OutputInforDTO> GetOutputInforList()
        {
            string query = "SELECT * FROM OutputInfor";
            return dataProvider.ExecuteQuery<OutputInforDTO>(query);
        }
        // thêm
        public void AddOutputInfor(OutputInforDTO obj)
        {
            string query = "INSERT INTO OutputInfor (Id, IdObject, IdInputInfor, IdCustomer, IdSale_OutputInfor, Quantity, InputPrice) " +
                "VALUES (@Id, @IdObject, @IdInputInfor, @IdCustomer, @IdSale_OutputInfor, @Quantity, @InputPrice)";
        }
        // xóa
        public int DeleteOutputInfor(List<string> ids)
        {
            return DeleteByIds("OutputInfor", "Id", ids);
        }
        // cập nhật
        public int UpdateOutputInfor(List<OutputInforDTO> outputInfor)
        {
            return Update("OutputInfor", "Id", outputInfor, (command, outputInfor) =>
            {
                command.Parameters.AddWithValue("@Id", outputInfor.Id);
                command.Parameters.AddWithValue("@IdObject", outputInfor.IdObject);
                command.Parameters.AddWithValue("@IdInputInfor", outputInfor.IdOutput);
                command.Parameters.AddWithValue("@IdCustomer", outputInfor.IdCustomer);
                command.Parameters.AddWithValue("@IdSale_OutputInfor", outputInfor.IdSale);
                command.Parameters.AddWithValue("@Quantity", outputInfor.Quantity);
                command.Parameters.AddWithValue("@InputPrice", outputInfor.InputPrice);
                command.Parameters.AddWithValue("@Total", outputInfor.Total);
            });
        }

    }
}
