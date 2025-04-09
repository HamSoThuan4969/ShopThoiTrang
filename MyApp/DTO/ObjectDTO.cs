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
        public int? IdSet { get; set; }  // Có thể null
        public int IdUnit { get; set; }
        public int IdSuplier { get; set; }
        public int? InputPrice { get; set; }
    }
}
