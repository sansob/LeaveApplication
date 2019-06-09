using Core.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    [Table("TB_T_LeaveRequests")]
    public class LeaveRequest : BaseModel
    {
        [ForeignKey("LeaveType")]
        public int LeaveId { get; set; }
        public DateTimeOffset FromDate { get; set; }
        public DateTimeOffset EndDate { get; set; }
        public DateTimeOffset RequestDate { get; set; }
        public string Reason { get; set; }
        public int RequesterId { get; set; }
        public int ApprovalManagerId { get; set; }
        public int ApprovalHrdId { get; set; }
        public string Attachments { get; set; }
        public string Status { get; set; }

        public LeaveRequest() { }
        public LeaveType LeaveType { get; set; }


    }
}
