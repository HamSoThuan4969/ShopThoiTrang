using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class UsersDAL : DatabaseAccess
    {
        public string CheckLogin(UsersDTO users)
        {
            string info = CheckLoginDTO(users); // gọi hàm CheckLoginDTO ở DataBaseAccess
            return info; 
        }
        // Hàm này sẽ chuyển lên UsersBLL
    }
}
