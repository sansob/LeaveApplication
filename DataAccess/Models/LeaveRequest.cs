using Core.Base;
using DataAccess.ViewModels;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccess.Models {
    [Table("TB_T_LeaveRequests")]
    public class LeaveRequest : BaseModel {
        [ForeignKey("LeaveType")] public int? Leave_Id { get; set; }
        [ForeignKey("RequesterEmployee")] public int? Requester_Id { get; set; }
        [ForeignKey("ManagerEmployee")] public int? ApprovalManager_Id { get; set; }
        [ForeignKey("HrdEmployee")] public int? ApprovalHrd_Id { get; set; }
        [ForeignKey("StatusTypeParam")] public int? Status_Id { get; set; }
        public DateTimeOffset FromDate { get; set; }
        public DateTimeOffset EndDate { get; set; }
        public DateTimeOffset RequestDate { get; set; }
        public string Reason { get; set; }
        public string Attachments { get; set; }


        public LeaveRequest() {
        }

        public Employee RequesterEmployee { get; set; }
        public Employee ManagerEmployee { get; set; }
        public Employee HrdEmployee { get; set; }
        public LeaveType LeaveType { get; set; }
        public StatusTypeParam StatusTypeParam { get; set; }
        

        public LeaveRequest(LeaveRequestVM leaveRequestVM) {
            Leave_Id = leaveRequestVM.Leave_Id;
            FromDate = leaveRequestVM.FromDate;
            EndDate = leaveRequestVM.EndDate;
            RequestDate = leaveRequestVM.RequestDate;
            Reason = leaveRequestVM.Reason;
            Requester_Id = leaveRequestVM.Requester_Id;
            ApprovalManager_Id = leaveRequestVM.ApprovalManager_Id;
            ApprovalHrd_Id = leaveRequestVM.ApprovalManager_Id;
            Attachments = leaveRequestVM.Attachments;
            Status_Id = leaveRequestVM.Status_Id;
            CreateDate = DateTimeOffset.Now.ToLocalTime();
        }

        public void Update(int id, LeaveRequestVM leaveRequestVM) {
            Id = leaveRequestVM.Leave_Id;
            Leave_Id = leaveRequestVM.Leave_Id;
            FromDate = leaveRequestVM.FromDate;
            EndDate = leaveRequestVM.EndDate;
            RequestDate = leaveRequestVM.RequestDate;
            Reason = leaveRequestVM.Reason;
            Requester_Id = leaveRequestVM.Requester_Id;
            ApprovalManager_Id = leaveRequestVM.ApprovalManager_Id;
            ApprovalHrd_Id = leaveRequestVM.ApprovalHrd_Id;
            Attachments = leaveRequestVM.Attachments;
            Status_Id = leaveRequestVM.Status_Id;
            CreateDate = DateTimeOffset.Now.ToLocalTime();
        }

        public void ApproveManager (LeaveRequestVM leaveRequestVM) {
//            this.Id = leaveRequestVM.Id;
            this.ApprovalManager_Id = leaveRequestVM.ApprovalManager_Id;
        }

        public void Delete() {
            this.IsDelete = true;
            this.DeleteDate = DateTimeOffset.Now.ToLocalTime();
        }
    }
}