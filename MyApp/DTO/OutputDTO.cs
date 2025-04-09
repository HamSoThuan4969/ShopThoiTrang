using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class OutputDTO
    {
        public string Id { get; set; }
        public string IdCustomer { get; set; }
        public string IdSale_Output { get; set; }
        public DateTime DateOuput { get; set; }
        public float ToTal { get; set; }
        public string Type { get; set; }
        public string Status { get; set; }
    }

}
