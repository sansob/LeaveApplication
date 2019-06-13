using System;

namespace DataAccess.ViewModels {
    public class LeaveRequestVM {
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

        public LeaveRequestVM() {
        }

        public LeaveRequestVM(int leave_Id, DateTimeOffset FromDate, DateTimeOffset endDate, DateTimeOffset requestDate,
            string reason, int requester_Id,
            string attachments, int status_Id) {
            Leave_Id = leave_Id;
            this.FromDate = FromDate;
            EndDate = endDate;
            RequestDate = requestDate;
            Reason = reason;
            Requester_Id = requester_Id;

            Attachments = attachments;
            Status_Id = status_Id;
        }

//        public LeaveRequestVM(int leave_Id, DateTimeOffset FromDate, DateTimeOffset endDate, DateTimeOffset requestDate,
//            string reason, int requester_Id, int approaApprovalManagerId, int approvalHrdId,
//            string attachments, int status_Id) {
//            Leave_Id = leave_Id;
//            this.FromDate = FromDate;
//            EndDate = endDate;
//            RequestDate = requestDate;
//            Reason = reason;
//            Requester_Id = requester_Id;
//            ApprovalManager_Id = approaApprovalManagerId;
//            ApprovalHrd_Id = approvalHrdId;
//            Attachments = attachments;
//            Status_Id = status_Id;
//        }

        public void ApproveManager(int id, int aapprovalManager_Id) {
            Id = id;
            ApprovalManager_Id = aapprovalManager_Id;
        }

        public void Update(int id, int leave_Id, DateTimeOffset FromDate, DateTimeOffset endDate,
            DateTimeOffset requestDate, string reason, int requester_Id,
            int approvalManager_Id, int approvalHrd_Id, string attachments, int status_Id) {
            Id = id;
            Leave_Id = leave_Id;
            this.FromDate = FromDate;
            EndDate = endDate;
            RequestDate = requestDate;
            Reason = reason;
            Requester_Id = requester_Id;
            ApprovalManager_Id = approvalManager_Id;
            ApprovalHrd_Id = approvalHrd_Id;
            Attachments = attachments;
            Status_Id = status_Id;
        }
    }
}