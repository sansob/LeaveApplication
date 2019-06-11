using Core.Base;
using DataAccess.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    [Table("TB_M_LeaveTypes")]
    public class LeaveType : BaseModel
    {

        public string LeaveName { get; set; }
        public string LeaveTypeParams { get; set; }

        public LeaveType() { }

        public LeaveType(LeaveTypeVM leaveTypeVM)
        {
            
            this.LeaveTypeParams = leaveTypeVM.LeaveTypeParams;
            this.CreateDate = DateTimeOffset.Now.ToLocalTime();
        }

        public void Update(int id, LeaveTypeVM leaveTypeVM)
        {
            this.Id = leaveTypeVM.Id;
            this.LeaveName = leaveTypeVM.LeaveName;
            this.LeaveTypeParams = leaveTypeVM.LeaveTypeParams;
            this.CreateDate = DateTimeOffset.Now.ToLocalTime();
        }

        public void Delete()
        {
            this.IsDelete = true;
            this.DeleteDate = DateTimeOffset.Now.ToLocalTime();
        }

    }
}
