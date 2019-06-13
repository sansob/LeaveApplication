using System;

namespace DataAccess.ViewModels {
    public class LeaveRequestVM
    {
        public int Id { get; set; }
        public int Leave_Id { get; set; }
        public DateTimeOffset FromDate { get; set; }
        public DateTimeOffset EndDate { get; set; }
        public DateTimeOffset RequestDate { get; set; }
        public string Reason { get; set; }
        public int Requester_Id { get; set; }
        public int ApprovalManager_Id { get; set; }
        public int ApprovalHrd_Id { get; set; }
        public string Attachments { get; set; }
        public int Status_Id { get; set; }

        public LeaveRequestVM() { }

        public LeaveRequestVM(int leave_Id, DateTimeOffset FromDate, DateTimeOffset endDate, DateTimeOffset requestDate, string reason, int requester_Id, 
            int approvalManager_Id, int approvalHrd_Id, string attachments, int status_Id)
        {
            this.Leave_Id = leave_Id;
            this.FromDate = FromDate;
            this.EndDate = endDate;
            this.RequestDate = requestDate;
            this.Reason = reason;
            this.Requester_Id = requester_Id;
            this.ApprovalManager_Id = approvalManager_Id;
            this.ApprovalHrd_Id = approvalHrd_Id;
            this.Attachments = attachments;
            this.Status_Id = status_Id;
        }

        public void Update(int id, int leave_Id, DateTimeOffset FromDate, DateTimeOffset endDate, DateTimeOffset requestDate, string reason, int requester_Id,
            int approvalManager_Id, int approvalHrd_Id, string attachments, int status_Id)
        {
            this.Id = id;
            this.Leave_Id = leave_Id;
            this.FromDate = FromDate;
            this.EndDate = endDate;
            this.RequestDate = requestDate;
            this.Reason = reason;
            this.Requester_Id = requester_Id;
            this.ApprovalManager_Id = approvalManager_Id;
            this.ApprovalHrd_Id = approvalHrd_Id;
            this.Attachments = attachments;
            this.Status_Id = status_Id;
        }
    }
}
