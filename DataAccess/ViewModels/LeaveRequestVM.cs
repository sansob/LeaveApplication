using System;

namespace DataAccess.ViewModels {
    public class LeaveRequestVM
    {
        public int Id { get; set; }
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

        public LeaveRequestVM() { }

        public LeaveRequestVM( int leaveId, DateTimeOffset FromDate, DateTimeOffset endDate, DateTimeOffset requestDate, string reason, int requesterId, 
            int approvalManagerId, int approvalHrdId, string attachments, string status)
        {
            this.LeaveId = leaveId;
            this.FromDate = FromDate;
            this.EndDate = endDate;
            this.RequestDate = requestDate;
            this.Reason = reason;
            this.RequesterId = requesterId;
            this.ApprovalManagerId = approvalManagerId;
            this.ApprovalHrdId = approvalHrdId;
            this.Attachments = attachments;
            this.Status = status;
        }

        public void Update(int id, int leaveId, DateTimeOffset FromDate, DateTimeOffset endDate, DateTimeOffset requestDate, string reason, int requesterId,
            int approvalManagerId, int approvalHrdId, string attachments, string status)
        {
            this.Id = id;
            this.LeaveId = leaveId;
            this.FromDate = FromDate;
            this.EndDate = endDate;
            this.RequestDate = requestDate;
            this.Reason = reason;
            this.RequesterId = requesterId;
            this.ApprovalManagerId = approvalManagerId;
            this.ApprovalHrdId = approvalHrdId;
            this.Attachments = attachments;
            this.Status = status;
        }
    }
}
