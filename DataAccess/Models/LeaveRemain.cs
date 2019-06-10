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
    [Table("TB_T_LeaveRemains")]
    public class LeaveRemain : BaseModel
    {
        [ForeignKey("LeaveRequest")]
        public int LeaveRequestId { get; set; }
        public string UserID { get; set; }
        public int Duration { get; set; }
        public string Type { get; set; }

        public LeaveRemain() { }

        public LeaveRequest LeaveRequest { get; set; }

        public LeaveRemain(LeaveRemainVM leaveRemainVM)
        {
            this.LeaveRequestId = leaveRemainVM.LeaveRequestId;
            this.UserID = leaveRemainVM.UserID;
            this.Duration = leaveRemainVM.Duration;
            this.Type = leaveRemainVM.Type;
            this.CreateDate = DateTimeOffset.Now.ToLocalTime();
        }

        public void Update(int id, LeaveRemainVM leaveRemainVM)
        {
            this.Id = leaveRemainVM.Id;
            this.LeaveRequestId = leaveRemainVM.LeaveRequestId;
            this.UserID = leaveRemainVM.UserID;
            this.Duration = leaveRemainVM.Duration;
            this.Type = leaveRemainVM.Type;
            this.CreateDate = DateTimeOffset.Now.ToLocalTime();
        }

        public void Delete()
        {
            this.IsDalete = true;
            this.DeleteDate = DateTimeOffset.Now.ToLocalTime();
        }
    }
}
