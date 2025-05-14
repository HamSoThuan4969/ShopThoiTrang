using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ObjectDTO
    {
        public string Id { get; set; }
        public string DisplayName { get; set; }
        public string IdSet { get; set; }  // Có thể null
        public string IdSupplier { get; set; }
        public int? InputPrice { get; set; }
        public int Quantity { get; set; }
        public int OutputPrice { get; set; }
        public string IdInputInfor { get; set; }

    }
}
