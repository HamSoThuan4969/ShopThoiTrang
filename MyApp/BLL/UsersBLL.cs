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
        public string CheckLogin(UsersDTO users)  // thông số này là users được đóng gói như 1 đối tượng DTO ở tầng GUI
        {
            // kiểm tra nghiệp vụ : 
            if( users.UserName == "")
            {
                return "Tai khoan khoang the de trong ";
            }
            if(users.Password == "")
            {
                return "Mat khau khong duoc de trong";
            }
            string info = usersDAL.CheckLogin(users);
            return info;
        }
    }
}
