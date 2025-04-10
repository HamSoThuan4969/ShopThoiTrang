using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class UsersDTO
    {
        public int Id { get; set; } // Id này tự tăng - identity => không cần truyền tham số vào 
        public string DisplayName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public int IdUserRole { get; set; }
        public UsersDTO() { }
        public UsersDTO(int id, string displayName, string userName, string password, int idUserRole)
        {
            Id = id;
            DisplayName = displayName;
            UserName = userName;
            Password = password;
            IdUserRole = idUserRole;
        }
    }

}
