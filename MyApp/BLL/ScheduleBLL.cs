using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class ScheduleBLL
    {
        private RequestScheduleDAL dal = new RequestScheduleDAL();

        public void CreateRequest(RequestSchedulesDTO req)
        {
            // Có thể kiểm tra hợp lệ, xử lý logic trước khi gọi DAL
            dal.AddRequest(req);
        }

        public List<RequestSchedulesDTO> GetByDate(DateTime date)
        {
            return new RequestScheduleDAL().GetRequestsByDate(date);
        }

        public List<RequestSchedulesDTO> GetAll()
        {
            return dal.GetAllRequests();  // Gọi DAL để lấy danh sách
        }
    }
}
