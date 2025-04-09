using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class SaleDetailDTO
    {
        public int Id { get; set; }
        public string IdSale { get; set; }
        public int Discount { get; set; }
        public int? ConditionValue { get; set; }
        public string Description { get; set; }
    }

}
