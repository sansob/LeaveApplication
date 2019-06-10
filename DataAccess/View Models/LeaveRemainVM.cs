using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.View_Models
{
    public class LeaveRemainVM
    {
        public int Id { get; set; }
        public int LeaveRequestId { get; set; }
        public string UserID { get; set; }
        public int Duration { get; set; }
        public string Type { get; set; }

        public LeaveRemainVM() { }

        public LeaveRemainVM(int leaveRequestId, string userId, int duration, string type)
        {
            this.LeaveRequestId = leaveRequestId;
            this.UserID = userId;
            this.Duration = duration;
            this.Type = type;
        }

        public void Update(int id, int leaveRequestId, string userId, int duration, string type)
        {
            this.Id = id;
            this.LeaveRequestId = leaveRequestId;
            this.UserID = userId;
            this.Duration = duration;
            this.Type = type;
        }



    }
}
