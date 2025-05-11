using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class RequestSchedulesDTO
    {
        public int Id { get; set; }
        public string Request { get; set; }
        public string Shift { get; set; }
        public DateTime RequestDate { get; set; }
        public string Status { get; set; }
        

        public static List<string> ListRequest = new List<string>()
        {
            "LEAVE", "WORK"
        };

        public enum ERequest
        {
            LEAVE,
            WORK
        }

        public static List<string> ListShift = new List<string>()
        {
            "MORNING", "EVENING", "NIGHT"
        };

        public enum EShift
        {
            MORNING,
            EVENING,
            NIGHT
        }
    }
}
