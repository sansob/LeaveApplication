using Core.Base;
using DataAccess.View_Models;
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

        public LeaveRequest(LeaveRequestVM leaveRequestVM)
        {
            this.LeaveId = leaveRequestVM.LeaveId;
            this.FromDate = leaveRequestVM.FromDate;
            this.EndDate = leaveRequestVM.EndDate;
            this.RequestDate = leaveRequestVM.RequestDate;
            this.Reason = leaveRequestVM.Reason;
            this.RequesterId = leaveRequestVM.RequesterId;
            this.ApprovalManagerId = leaveRequestVM.ApprovalManagerId;
            this.ApprovalHrdId = leaveRequestVM.ApprovalHrdId;
            this.Attachments = leaveRequestVM.Attachments;
            this.Status = leaveRequestVM.Status;
            this.CreateDate = DateTimeOffset.Now.ToLocalTime();
        }

        public void Update(int id, LeaveRequestVM leaveRequestVM)
        {
            this.Id = leaveRequestVM.LeaveId;
            this.LeaveId = leaveRequestVM.LeaveId;
            this.FromDate = leaveRequestVM.FromDate;
            this.EndDate = leaveRequestVM.EndDate;
            this.RequestDate = leaveRequestVM.RequestDate;
            this.Reason = leaveRequestVM.Reason;
            this.RequesterId = leaveRequestVM.RequesterId;
            this.ApprovalManagerId = leaveRequestVM.ApprovalManagerId;
            this.ApprovalHrdId = leaveRequestVM.ApprovalHrdId;
            this.Attachments = leaveRequestVM.Attachments;
            this.Status = leaveRequestVM.Status;
            this.CreateDate = DateTimeOffset.Now.ToLocalTime();
        }

        public void Delete()
        {
            this.IsDalete = true;
            this.DeleteDate = DateTimeOffset.Now.ToLocalTime();
        }

    }
}
