using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class CustomerDTO
    {
        public string Id { get; set; }
        public string DisplayName { get; set; }
        public string IdGroupCustomer { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public DateTime DateContract { get; set; }
        public string MoreInfor { get; set; }
        public int IdUserRole { get; set; }
    }

}
