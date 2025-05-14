using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class SupplierDTO
    {
        public string Id { get; set; }
        public string DisplayName { get; set; }
        public string Address { get; set; }
        public string Abbreviation { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string TypeObject { get; set; }
        public string MoreInfor { get; set; }
        public DateTime ContractDate { get; set; }

    }
}
