using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class InputDAL:BaseDAL
    {
        private DataProvider dataProvider = new DataProvider();
        public void AddInput(InputDTO input)
        {
            string query= "INSERT INTO Input (Id, Quantity, ToTalPrice, Type, BarCode, DateInput) " +
                               "VALUES (@Id, @Quantity, @ToTalPrice, @Type, @BarCode, @DateInput)";
            var parameters = new object[]
            {
                input.Id,
                input.Quantity,
                input.ToTalPrice,
                input.Type,
                input.BarCode,
                input.DateInput
            };
            dataProvider.ExecuteNonQuery(query, parameters);
        }
    }
}
