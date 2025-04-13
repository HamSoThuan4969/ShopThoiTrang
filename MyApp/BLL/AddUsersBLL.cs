using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class AddUsersBLL
    {
        private AddUsersDAL usersDAL = new AddUsersDAL(); // tạo đối tượng DAL để gọi hàm thêm người dùng
        public string Register(string displayName ,string username, string password, int idUsersRole)
        {
            // Value intput
            if ((string.IsNullOrWhiteSpace(displayName)) || (string.IsNullOrWhiteSpace(username)) || (string.IsNullOrWhiteSpace(password)) || (idUsersRole<0))
            {
                return "Please enterl all fields !";
            }
            if (!Regex.IsMatch(username, @"^[a-zA-Z0-9]+$")) // điều kiện kiểm tra username có phải là chữ cái hoặc số hay không
            {
                return "Username must be alphanumeric !";
            }
            if(password.Length<6) // điều kiện kiểm tra password có ít nhất 6 ký tự hay không
            {
                return "Password must be at least 6 characters !";
            }
            // Kiểm tra trùng lặp userName
            bool isUserNameExists = usersDAL.CheckUserNameExists(username);
            if (isUserNameExists)
            {
                return "Error: UserName already exists!";
            }
            // mã hóa mật khẩu (SHA256)
            string hashedPassword = HashPassword(password);

            // tạo đối tượng userDTO 
            UsersDTO usersDTO = new UsersDTO
            {
                DisplayName = displayName,
                UserName = username,
                Password = hashedPassword,
                IdUserRole = idUsersRole
            };

            // Gọi DAL để thêm người dùng
            string result = usersDAL.AddUserDAL(usersDTO); // Gọi hàm thêm người dùng ở DAL
            return result;
        }


        // Móa hóa mật khẩu 
        private string HashPassword(string password)
        {
            using ( var sha256 = System.Security.Cryptography.SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder builder = new StringBuilder();
                foreach(var i in bytes)
                {
                    builder.Append(i.ToString("x2"));
                }
                return builder.ToString(); // trả về chuỗi mã hóa 
            }
        }

    }
}
