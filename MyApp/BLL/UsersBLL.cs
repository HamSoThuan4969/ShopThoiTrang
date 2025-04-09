using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;


namespace BLL
{
    public class UsersBLL
    {
        UsersDAL usersDAL = new UsersDAL(); // tạo 1 đối tượng ở DAL để chạy phương thức CheckLoin ở đó 
        public string CheckLogin(UsersDTO user)  // thông số này là users được đóng gói như 1 đối tượng DTO ở tầng GUI
        {
            // kiểm tra nghiệp vụ : 
            if (String.IsNullOrEmpty(user.UserName))
            {
                return "requeid_userName";
            }
            if (String.IsNullOrEmpty(user.Password))
            {
                return "requeid_usePasssword";
            }
            string info = usersDAL.CheckLogin(user); // gọi hàm CheckLogin ở UsersDAL
            return info;

        }
    }
}
