using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL   
{
    public class Input_InforDAL:BaseDAL
    {
        private DataProvider dataProvider = new DataProvider();
        public void AddInputInfor(InputInforDTO inputInfor)
        {
            string query = "INSERT INTO InputInfor (Id, IdInput, , DisplayName_Object, Quantity, InputPrice, OutputPrice, DisplayName_Object) " +
                           "VALUES (@Id, @IdInput ,  @DisplayName_Object, @Quantity, @InputPrice, @OutputPrice, @DisplayName_Object)";
            var parameters = new object[]
            {
                inputInfor.Id,
                inputInfor.IdInput,
                inputInfor.DisplayName_Object,
                inputInfor.Quantity,
                inputInfor.InputPrice,
                inputInfor.OutputPrice
            };
            dataProvider.ExecuteNonQuery(query, parameters);
        }
    }
}
