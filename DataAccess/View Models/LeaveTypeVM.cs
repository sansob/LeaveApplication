using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.View_Models
{
    public class LeaveTypeVM 
    {
        public int Id { get; set; }
        public string LeaveName { get; set; }
        public string LeaveTypeParams { get; set; }

        public LeaveTypeVM() { }

        public LeaveTypeVM(string leaveName, string leaveTypeParams)
        {
            this.LeaveName = leaveName;
            this.LeaveTypeParams = leaveTypeParams;
        }

        public void Update(int id, string leaveName, string leaveTypeParams)
        {
            this.Id = id;
            this.LeaveName = leaveName;
            this.LeaveTypeParams = leaveTypeParams;
        }

        
    }
}
