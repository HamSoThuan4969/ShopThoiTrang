using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class CustomerDTO
    {
        private string Id { get; set; }
        private string DisplayName { get; set; }
        private string IdGroupCustomer { get; set; }
        private string Address { get; set; }
        private string Phone { get; set; }
        private string Email { get; set; }
        private DateTime DateContract { get; set; }
        private string MoreInfor { get; set; }
        private int IdUserRole { get; set; }
    }

}
