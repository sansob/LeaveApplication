using Core.Base;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using DataAccess.ViewModels;

namespace DataAccess.Models {
    [Table("TB_T_LeaveRemains")]
    public class LeaveRemain : BaseModel {
        [ForeignKey("LeaveRequest")] public int LeaveRequest_Id { get; set; }
        [ForeignKey("Employee")] public int User_Id { get; set; }
        [ForeignKey("StatusTypeParam")] public int Type_Id { get; set; }
        public int Duration { get; set; }

        public LeaveRemain() {
        }

        public Employee Employee { get; set; }
        public StatusTypeParam StatusTypeParam { get; set; }

        public LeaveRequest LeaveRequest { get; set; }

        public LeaveRemain(LeaveRemainVM leaveRemainVM) {
            this.LeaveRequest_Id = leaveRemainVM.LeaveRequest_Id;
            this.User_Id = leaveRemainVM.User_Id;
            this.Duration = leaveRemainVM.Duration;
            this.Type_Id = leaveRemainVM.Type_Id;
            this.CreateDate = DateTimeOffset.Now.ToLocalTime();
        }

        public void Update(int id, LeaveRemainVM leaveRemainVM) {
            this.Id = leaveRemainVM.Id;
            this.LeaveRequest_Id = leaveRemainVM.LeaveRequest_Id;
            this.User_Id = leaveRemainVM.User_Id;
            this.Duration = leaveRemainVM.Duration;
            this.Type_Id = leaveRemainVM.Type_Id;
            this.CreateDate = DateTimeOffset.Now.ToLocalTime();
        }

        public void Delete() {
            this.IsDelete = true;
            this.DeleteDate = DateTimeOffset.Now.ToLocalTime();
        }
    }
}