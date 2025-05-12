using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class InputDTO
    {
        public string Id { get; set; }
        public int Quantity { get; set; }
        public float ToTalPrice { get; set; }
        public string Type { get; set; }
        public string BarCode { get; set; }
        public DateTime DateInput { get; set; }
    }

}
